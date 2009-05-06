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
	public partial class FormAddHolyday : Form
	{
		public Holiday Holyday { get; set; }

		public FormAddHolyday()
		{
			InitializeComponent();			
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (Holyday == null) {
				Holyday = new Holiday();
			}
			Holyday.Date = m_MonthCalendar.SelectionStart;
			Holyday.Name = m_textBoxName.Text;
			Holyday.Info = m_textBoxInfo.Text;
			Holyday.TimeToWork = (double)m_numericUpDownToWork.Value;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			m_MonthCalendar.SelectionStart = DateTime.Today;
			m_textBoxName.Text = "";
			m_textBoxInfo.Text= "";
			m_numericUpDownToWork.Value = 0;
			Holyday = null;
			DialogResult = DialogResult.Cancel;
			
		}
	}
}
