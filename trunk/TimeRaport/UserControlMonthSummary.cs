using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace Hackovic.TimeReport
{
	public partial class UserControlMonthSummary : UserControl, ILocalizableControl
	{
		private double m_TotalHours;
		private double m_TotalPlanned;
		private double m_TotalDiff;
		TimeLogDataSet dsTimeReport ;
		private string m_SpecificationFormat;
		private DateTime m_Month = DateTime.MinValue;


		[Browsable(true), Localizable(true)]
		public string SpecificationFormat
		{
			get { return m_SpecificationFormat; }
			set { m_SpecificationFormat = value; }
		}

		public DateTime Month { 
			get { return m_Month; }
			set
			{
				m_Month = value;
				this.CalculateTotalForMonth();
				SetMonthLable();
			}
		}

		private void SetMonthLable()
		{
			try
			{
				m_LabelMonth.Text = m_Month.ToString("MMMM ´yy", Thread.CurrentThread.CurrentUICulture);
				m_LabelMonth.Text = m_LabelMonth.Text.Substring(0, 1).ToUpper() + m_LabelMonth.Text.Substring(1);
			}
			catch { }
		}
		private void SetHoursLable()
		{
			try
			{
				m_LabelHours.Text = string.Format(TextLocalizations.SpecificationFormat, m_TotalHours, m_TotalPlanned, m_TotalDiff);
			}
			catch {
				m_LabelHours.Text = string.Format("Worked:{0:N2}  Planed:{1:N2}  Delta:{2:N2}", m_TotalHours, m_TotalPlanned, m_TotalDiff);
			}
		}
	
		public DataGridView DataGrid{
			get { return m_DataGridViewMonth; }
			set { m_DataGridViewMonth = value; }
		}

		public UserControlMonthSummary()
		{
			dsTimeReport = TimeLogFactory.Instance;
			InitializeComponent();
		}

		public bool IsEmpty() {
			return m_DataGridViewMonth.Rows.Count == 0;
		}

		public void AjustHight() {
			this.Height = TotalHeight + 10;
		}

		public int TotalHeight {
			get
			{
				return m_TableLayoutPanel.Height
					+ m_DataGridViewMonth.ColumnHeadersHeight
					+ (m_DataGridViewMonth.RowCount * m_DataGridViewMonth.RowTemplate.Height);

			}
		}

		public void CalculateTotalForMonth()
		{						
			m_TotalHours = 0;
			m_TotalPlanned = 0;
			m_TotalDiff = 0;
			m_DataGridViewMonth.Rows.Clear();
			var worked = dsTimeReport.DayTimeLog.GroupBy(dl => dl.CategoryId, dl => dl);
			foreach (var category in worked)
			{
				double sum = category.Sum(day => day.Hours);
				double plan = category.Sum(day => day.PlannedHours);
				double diff = sum - plan;
				m_TotalHours += sum;
				m_TotalPlanned += plan;
				m_TotalDiff += diff;
				m_DataGridViewMonth.Rows.Add(sum, plan, diff, dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue);
			}

			SetHoursLable();
			AjustHight();
		}


		

		#region ILocalizableControl Members

		public void ChangeLanguage()
		{
			try
			{
				ComponentResourceManager resources = new ComponentResourceManager(typeof(UserControlMonthSummary));
				
				resources.ApplyResources(this.m_LabelMonth, "m_LabelMonth");
				resources.ApplyResources(this.m_ColorPanel1, "m_ColorPanel1");
				resources.ApplyResources(this.m_DataGridViewMonth, "m_DataGridViewMonth");
				resources.ApplyResources(this.m_WorkedColumn, "m_WorkedColumn");
				resources.ApplyResources(this.m_PlanedColumn, "m_PlanedColumn");
				resources.ApplyResources(this.m_DiffCoulmn, "m_DiffCoulmn");
				resources.ApplyResources(this.m_WorkTypeColumn, "m_WorkTypeColumn");
				resources.ApplyResources(this.m_TableLayoutPanel, "m_TableLayoutPanel");
				resources.ApplyResources(this.m_LabelHours, "m_LabelHours");
				resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
				resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
				resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
				resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
				resources.ApplyResources(this, "$this");

				SetHoursLable();
				SetMonthLable();
				AjustHight();
			}
			catch { }
		}
		#endregion		
	}
}
