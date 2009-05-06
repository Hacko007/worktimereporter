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

			//label_info.Text = "Denna månad:" + Environment.NewLine;
			int daycount = dsTimeReport.DayTimeLog.GroupBy(dl => dl.Day, dl => dl).Count();
			//label_info.Text += daycount + " arbetsdagar" + Environment.NewLine + Environment.NewLine;

			double total_hours = 0;
			double total_planned = 0;
			double total_diff = 0;

			var worked = dsTimeReport.DayTimeLog.GroupBy(dl => dl.CategoryId, dl => dl);
			foreach (var category in worked)
			{
				double sum = category.Sum(day => day.Hours);
				double plan = category.Sum(day => day.PlannedHours);
				double diff = sum - plan;
				total_hours += sum;
				total_planned += plan;
				total_diff += diff;
				//string format = "{0,4:N2} av {1,4:N2} [+{2,4:N2}] - ";
				//if (diff < 0)
				//{
				//    format = "{0,4:N2} av {1,4:N2} [{2,4:N2}] - ";
				//}
				//else if (diff == 0)
				//{
				//    format = "{0,4:N2} av {1,4:N2} - ";
				//}
				//label_info.Text += string.Format(format, sum, plan, diff);
				//label_info.Text += dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue + Environment.NewLine;
				dataGridView_Month.Rows.Add(sum, plan, diff, dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue);
			}

			label_Hours.Text = string.Format("Arbetat:{0:N2}   Plan:{1:N2}  Delta:{2:N2}", total_hours, total_planned , total_diff);
			if (total_diff > 0)
			{
				//label_Diff.Text = string.Format("Skilnad:+{0,7:N2}  tim.", total_diff);
				//label_Diff.ForeColor = Color.GreenYellow;
			}
			else
			{
				//label_Diff.Text = string.Format("Skilnad:{0,7:N2}  tim.", total_diff);
				//label_Diff.ForeColor = Color.OrangeRed;
			}


		}
 
     
	}
}
