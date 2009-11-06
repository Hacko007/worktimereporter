using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Hackovic.TimeReport
{
	public partial class UserControlMaintenance : UserControl, ILocalizableControl
	{
		public delegate void DbCleanedDelegate();

		// Declare the event.
		public event DbCleanedDelegate DbCleaned;
		public event EventHandler CurrentUICultureChanged;

		// Wrap the event in a protected virtual method
		// to enable derived classes to raise the event.
		protected virtual void RaiseDbCleaned()
		{
			if (DbCleaned != null)
				DbCleaned();
		}

		protected virtual void RaiseCurrentUICultureChanged()
		{
			if (CurrentUICultureChanged != null)
				CurrentUICultureChanged(this, EventArgs.Empty);
		}


		public UserControlMaintenance()
		{
			InitializeComponent();
			SetEnabledOnControls();
			LoadDefaultLanguage();
		}

		private void LoadDefaultLanguage()
		{
			if (global::Hackovic.TimeReport.Properties.Settings.Default.Language == null ||
			global::Hackovic.TimeReport.Properties.Settings.Default.Language == "")
				return;
			switch (global::Hackovic.TimeReport.Properties.Settings.Default.Language)
			{
				case Langages.Bosnian:
					m_RadioButtonBosanski.Checked = true;
					break;
				case Langages.English:
					m_RadioButtonEnglish.Checked = true;
					break;
				default: m_RadioButtonSvenska.Checked = true;
					break;
			}
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

		private void RadioButtonLanguage_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (m_RadioButtonBosanski.Checked)
				{
					SetCurrentUICulture(Langages.Bosnian);
				}
				else if (m_RadioButtonEnglish.Checked)
				{
					SetCurrentUICulture(Langages.English);
				}
				else
				{
					SetCurrentUICulture(Langages.Swedesh);
				}
				RaiseCurrentUICultureChanged();
			}
			catch { }
		}

		private static void SetCurrentUICulture(string cultureCode)
		{
			Properties.Settings.Default.Language = cultureCode;
			Properties.Settings.Default.Save();
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode, true);
		}


		#region ILocalizableControl Members

		public void ChangeLanguage()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMaintenance));
			resources.ApplyResources(this.m_ButtonClean, "m_ButtonClean");
			resources.ApplyResources(this.m_GroupBoxClean, "m_GroupBoxClean");
			resources.ApplyResources(this.m_RadioButtonEnglish, "m_RadioButtonEnglish");
			resources.ApplyResources(this.m_DigitalClock, "m_DigitalClock");
			resources.ApplyResources(this.m_RadioButtonBosanski, "m_RadioButtonBosanski");
			resources.ApplyResources(this.m_RadioButtonSvenska, "m_RadioButtonSvenska");
			resources.ApplyResources(this.m_ColorPanel, "m_ColorPanel");
			resources.ApplyResources(this.m_ButtonClean, "m_ButtonClean");
			resources.ApplyResources(this.m_GroupBoxLangage, "m_GroupBoxLangage");
			resources.ApplyResources(this.label1, "label1");
			resources.ApplyResources(this.m_UserControlMonthSelectorAfter, "m_UserControlMonthSelectorAfter");
			resources.ApplyResources(this.m_UserControlMonthSelectorTo, "m_UserControlMonthSelectorTo");
			resources.ApplyResources(this.m_UserControlMonthSelectorFrom, "m_UserControlMonthSelectorFrom");
			resources.ApplyResources(this.m_UserControlMonthSelectorFrom, "m_UserControlMonthSelectorFrom");
			resources.ApplyResources(this.m_UserControlMonthSelectorFrom, "m_UserControlMonthSelectorFrom");
			resources.ApplyResources(this.m_RadioButtonBetween, "m_RadioButtonBetween");
			resources.ApplyResources(this.m_RadioButtonBefore, "m_RadioButtonBefore");
			resources.ApplyResources(this.m_RadioButtonAfter, "m_RadioButtonAfter");			
			resources.ApplyResources(this, "$this");
		}

		#endregion
	}
}
