using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace Hackovic.TimeReport
{
	public partial class UserControlYearOverview : UserControl , ILocalizableControl
	{
		private HolidaysCollection m_Holydays;
		private DataTable m_Table;

		public UserControlYearOverview()
		{
			InitializeComponent();
			
		}

		void UserControlYearOverview_Load(object sender, EventArgs e)
		{

			m_Holydays = HolidaysCollection.Instance;			

			UpdateDataGrid();
			m_MonthCalendar.AnnuallyBoldedDates = m_Holydays.GetDates();
			m_DataGridView.DataError += DataGridView_DataError;
		}

		void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{			
		}

		void m_DataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (m_Table == null) return;
			
			m_Holydays.Update(m_Table);			
		}

		void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (m_Holydays == null) return;

			m_Holydays.Update(m_Table);			
		}

		void buttonAddHolyday_Click(object sender, EventArgs e)
		{
			AddNewHolyday();
		}

		void AddNewHolyday()
		{
			FormAddHolyday formHolyday = new FormAddHolyday();
			
			if (formHolyday.ShowDialog(this) == DialogResult.OK)
			{
				m_Holydays.Add(formHolyday.Holyday);
				UpdateDataGrid();
				m_Holydays.Save();
			}
		}

		void UpdateDataGrid()
		{
			m_Table = m_Holydays.ToDataTable();
			m_DataGridView.DataSource = m_Table ;
			m_DataGridView.Refresh();
		}

		void ButtonImp_Click(object sender, EventArgs e)
		{
			if (m_OpenFileDialog.ShowDialog() == DialogResult.OK)
			{

				FormImportSettings setting = new FormImportSettings();
				if (setting.ShowDialog() == DialogResult.OK)
				{
					m_Holydays.DistinctDateSetting = setting.DistinctDateSetting;
				}
				try
				{
					TextReader tr = new StreamReader(m_OpenFileDialog.FileName);
					string xml = tr.ReadToEnd();
					tr.Close();
					m_Holydays.LoadHolidays(xml);
					UpdateDataGrid();
				}
				catch {
					MessageBox.Show("Import misslyckades!");
				}
			}
		}

		private void ButtonExport_Click(object sender, EventArgs e)
		{
			Stream myStream;
			if (m_SaveFileDialog.ShowDialog() != DialogResult.OK) return;

			if ((myStream = m_SaveFileDialog.OpenFile()) != null)
			{
				try
				{
					TextWriter tw = new StreamWriter(myStream);
					tw.Write(m_Holydays.ToXml());
					tw.Close();
					myStream.Close();
				}
				catch
				{
					MessageBox.Show("Export misslyckades!");
				}
			}
			else
			{
				MessageBox.Show("Kunde inte komma åt filen!");
			}
		}

		private void m_MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			if (m_MonthCalendar.AnnuallyBoldedDates.Contains(m_MonthCalendar.SelectionStart))
			{
				Holiday h = HolidaysCollection.GetHoliday(m_MonthCalendar.SelectionStart);
				m_ToolTip.ToolTipTitle = m_MonthCalendar.SelectionStart.ToShortDateString();
				m_ToolTip.SetToolTip(m_MonthCalendar, h.ToString());
				m_ToolTip.Active = true;


			}
			else
			{
				m_ToolTip.Active = false;
			}
		}




		#region ILocalizableControl Members

		public void ChangeLanguage()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(UserControlYearOverview));
			resources.ApplyResources(this.m_MonthCalendar, "m_MonthCalendar");
			this.m_ToolTip.SetToolTip(this.m_MonthCalendar, resources.GetString("m_MonthCalendar.ToolTip"));
			resources.ApplyResources(this.ButtonExport, "ButtonExport");
			this.m_ToolTip.SetToolTip(this.ButtonExport, resources.GetString("ButtonExport.ToolTip"));
			resources.ApplyResources(this.ButtonImp, "ButtonImp");
			this.m_ToolTip.SetToolTip(this.ButtonImp, resources.GetString("ButtonImp.ToolTip"));
			resources.ApplyResources(this.buttonAddHolyday, "buttonAddHolyday");
			this.m_ToolTip.SetToolTip(this.buttonAddHolyday, resources.GetString("buttonAddHolyday.ToolTip"));
			resources.ApplyResources(this.m_DataGridView, "m_DataGridView");
			this.m_ToolTip.SetToolTip(this.m_DataGridView, resources.GetString("m_DataGridView.ToolTip"));
			resources.ApplyResources(this.m_LabelHolydays, "m_LabelHolydays");
			this.m_ToolTip.SetToolTip(this.m_LabelHolydays, resources.GetString("m_LabelHolydays.ToolTip"));
			resources.ApplyResources(this.m_OpenFileDialog, "m_OpenFileDialog");
			resources.ApplyResources(this.m_SaveFileDialog, "m_SaveFileDialog");
			resources.ApplyResources(this.m_ColorPanel, "m_ColorPanel");
			this.m_ToolTip.SetToolTip(this.m_ColorPanel, resources.GetString("m_ColorPanel.ToolTip"));
			resources.ApplyResources(this, "$this");
		}

		#endregion
	}
}
