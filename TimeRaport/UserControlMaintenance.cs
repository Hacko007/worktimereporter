using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public partial class UserControlMaintenance : UserControl
	{
		public delegate void DbCleanedDelegate();

		// Declare the event.
		public event DbCleanedDelegate DbCleaned;

		// Wrap the event in a protected virtual method
		// to enable derived classes to raise the event.
		protected virtual void RaiseDbCleaned()
		{
			if (DbCleaned != null)
				DbCleaned();
		}


		public UserControlMaintenance()
		{
			InitializeComponent();
			SetEnabledOnControls();
		}

		private void RadioButtonBefore_CheckedChanged(object sender, EventArgs e)
		{
			SetEnabledOnControls();
		}

		private void RadioButtonBetween_CheckedChanged(object sender, EventArgs e)
		{
			SetEnabledOnControls();
		}

		private void RadioButtonAfter_CheckedChanged(object sender, EventArgs e)
		{
			SetEnabledOnControls();
		}

		private void SetEnabledOnControls() 
		{
			m_UserControlMonthSelectorAfter.Visible = m_RadioButtonAfter.Checked;
			m_UserControlMonthSelectorBefore.Visible = m_RadioButtonBefore.Checked;
			m_UserControlMonthSelectorFrom.Visible = m_RadioButtonBetween.Checked;
			m_UserControlMonthSelectorTo.Visible = m_RadioButtonBetween.Checked;
			label1.Visible = m_RadioButtonBetween.Checked;			
		}

		private void ButtonClean_Click(object sender, EventArgs e)
		{
			CleanDb();
		}

		private void CleanDb()
		{
			DateTime from = DateTime.MinValue;
			DateTime to = DateTime.MinValue;
			if (m_RadioButtonAfter.Checked) 
			{
				from = m_UserControlMonthSelectorAfter.Date.AddMonths(1);				
				to = DateTime.MaxValue;
			}else 
			if (m_RadioButtonBefore.Checked) 
			{
				from = DateTime.MinValue;
				to = m_UserControlMonthSelectorBefore.Date;
			}else 
			if (m_RadioButtonBetween.Checked) 
			{
				from = m_UserControlMonthSelectorFrom.Date;
				to = m_UserControlMonthSelectorTo.Date;
			}

			var dayToDelete =  TimeLogFactory.Instance.TimeLog.Where(tl => to >= tl.Day && tl.Day >= from );
			foreach (var item in dayToDelete)
			{
				item.Delete();
			}

			TimeLogDataSet.TimeLogDataTable deleted = (TimeLogDataSet.TimeLogDataTable)TimeLogFactory.Instance.TimeLog.GetChanges(DataRowState.Deleted);
			if (deleted != null)
			{
				new TimeLogDataSetTableAdapters.TimeLogTableAdapter().Update(deleted);
				TimeLogFactory.Instance.TimeLog.AcceptChanges();
				TimeLogFactory.FillAllTables();
				RaiseDbCleaned();
			}


		}

		private void UserControlMonthSelector_DateChanged(object sender, DateTime dateTime)
		{
			if (m_UserControlMonthSelectorFrom.Date <= m_UserControlMonthSelectorTo.Date) return;

			if (sender == m_UserControlMonthSelectorFrom)
			{
				m_UserControlMonthSelectorTo.Date = m_UserControlMonthSelectorFrom.Date;
			}
			else if (sender == m_UserControlMonthSelectorTo)
			{
				m_UserControlMonthSelectorFrom.Date = m_UserControlMonthSelectorTo.Date;
			}
		}
	}
}
