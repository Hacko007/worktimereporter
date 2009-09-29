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
					label_Month.Text = m_Month.ToString("MMMM ´yy", CultureInfo.CreateSpecificCulture("sv-SE"));
					label_Month.Text = label_Month.Text.Substring(0,1).ToUpper() + label_Month.Text.Substring(1);
				}
				catch { }
			}
		}
		
		public DataGridView DataGrid{
			get { return dataGridView_Month; }
			set { dataGridView_Month = value; }
		}

		public UserControlMonthSummary()
		{
			dsTimeReport = TimeLogFactory.Instance;
			InitializeComponent();
			
		}

		public bool IsEmpty() {
			return dataGridView_Month.Rows.Count == 0;
		}

		public int TotalHeight {
			get
			{
				return tableLayoutPanel1.Height
					+ dataGridView_Month.ColumnHeadersHeight
					+ (dataGridView_Month.RowCount * dataGridView_Month.RowTemplate.Height);

			}
		}

		public void SetTotalLabel()
		{						
			double totalHours = 0;
			double totalPlanned = 0;
			double totalDiff = 0;
			dataGridView_Month.Rows.Clear();
			var worked = dsTimeReport.DayTimeLog.GroupBy(dl => dl.CategoryId, dl => dl);
			foreach (var category in worked)
			{
				double sum = category.Sum(day => day.Hours);
				double plan = category.Sum(day => day.PlannedHours);
				double diff = sum - plan;
				totalHours += sum;
				totalPlanned += plan;
				totalDiff += diff;
				dataGridView_Month.Rows.Add(sum, plan, diff, dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue);
			}

			label_Hours.Text = string.Format("Arbetat:{0:N2}  Plan:{1:N2}  Delta:{2:N2}", totalHours, totalPlanned , totalDiff);			
		}
 
     
	}
}
