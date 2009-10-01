using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace Hackovic.TimeReport
{
	public partial class UserControlMonthSummary : UserControl
	{
		TimeLogDataSet dsTimeReport ;
		
		private DateTime m_Month = DateTime.MinValue;

		public DateTime Month { 
			get { return m_Month; }
			set
			{
				m_Month = value;
				this.SetTotalLabel();
				try
				{
					m_LabelMonth.Text = m_Month.ToString("MMMM ´yy", CultureInfo.CreateSpecificCulture("sv-SE"));
					m_LabelMonth.Text = m_LabelMonth.Text.Substring(0,1).ToUpper() + m_LabelMonth.Text.Substring(1);
				}
				catch { }
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

		public int TotalHeight {
			get
			{
				return m_TableLayoutPanel.Height
					+ m_DataGridViewMonth.ColumnHeadersHeight
					+ (m_DataGridViewMonth.RowCount * m_DataGridViewMonth.RowTemplate.Height);

			}
		}

		public void SetTotalLabel()
		{						
			double totalHours = 0;
			double totalPlanned = 0;
			double totalDiff = 0;
			m_DataGridViewMonth.Rows.Clear();
			var worked = dsTimeReport.DayTimeLog.GroupBy(dl => dl.CategoryId, dl => dl);
			foreach (var category in worked)
			{
				double sum = category.Sum(day => day.Hours);
				double plan = category.Sum(day => day.PlannedHours);
				double diff = sum - plan;
				totalHours += sum;
				totalPlanned += plan;
				totalDiff += diff;
				m_DataGridViewMonth.Rows.Add(sum, plan, diff, dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue);
			}

			m_LabelHours.Text = string.Format("Arbetat:{0:N2}  Plan:{1:N2}  Delta:{2:N2}", totalHours, totalPlanned , totalDiff);			
		}
 
     
	}
}
