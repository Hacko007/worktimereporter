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
	}
}
