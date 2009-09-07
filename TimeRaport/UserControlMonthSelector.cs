using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Hackovic.TimeReport
{
	public partial class UserControlMonthSelector : UserControl
	{
		public delegate void DateTimeHandler(object sender, DateTime dateTime);
		public event DateTimeHandler DateChanged;

		private bool m_ShowOkButton = true;

		public UserControlMonthSelector()
		{
			Year = DateTime.Now.Year;
			Month = 1;			
			InitializeComponent();
		}

		

		public bool ShowOkButton 
		{ 
			get { return m_ShowOkButton; }
			set
			{
				m_ShowOkButton = value;
				m_ButtonOk.Visible = value;
				if (value)
				{
					if (m_TableLayoutPanel.ColumnStyles.Count == 2)
					{
						this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
					}
				}
				else
				{
					if (m_TableLayoutPanel.ColumnStyles.Count == 3)
					{
						this.m_TableLayoutPanel.ColumnStyles.RemoveAt(2);
					}
				}
			}
		}

		public DateTime Date { get { return new DateTime(Year, Month, 1); }
			set {
				Year = value.Year;
				Month = value.Month;
				UpdateControls();
			}

		}
		public int Year { get; set; }
		public int Month { get; set; }


		private void UserControlMonthSelector_Load(object sender, EventArgs e)
		{
			try
			{
				m_NumericUpDownYear.Value = Year;
				for (int i = 0; i < 12; i++)
				{
					m_ComboBoxMonth.Items.Add(DateTimeFormatInfo.CurrentInfo.MonthNames[i]);
				}
				m_ComboBoxMonth.SelectedIndex = 0;
			}
			catch { }
			
		}

		private void ComboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			Month = m_ComboBoxMonth.SelectedIndex == -1 ? 1 : m_ComboBoxMonth.SelectedIndex + 1;
			if (Month < 1) Month = 1;
			if (Month > 12) Month = 12;
			if (ShowOkButton == false)
				OnDateChanged();
		}

		private void NumericUpDownYear_ValueChanged(object sender, EventArgs e)
		{
			Year = (int)m_NumericUpDownYear.Value;
			if (ShowOkButton == false)
				OnDateChanged();
		}
		private void UpdateControls(){
			int index = Month - 1 ;
			m_ComboBoxMonth.SelectedIndex = -1 <= index && index < m_ComboBoxMonth.Items.Count ? index : -1 ;
			m_NumericUpDownYear.Value = Year;
		}
		private void OnDateChanged() 
		{
			if (DateChanged != null) {
				DateChanged(this, Date);
			}
		}

		private void ButtonOk_Click(object sender, EventArgs e)
		{
			OnDateChanged();
		}
	}
}
