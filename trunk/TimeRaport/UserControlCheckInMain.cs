using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using Hackovic.TimeReport.TimeLogDataSetTableAdapters;

namespace Hackovic.TimeReport
{
    public partial class UserControlCheckInMain : UserControl
    {
    	private double m_Hours ;
		public delegate void RefreshOverviewHandler();

		// Declare the event.
		public event RefreshOverviewHandler RefreshOverview;

		// Wrap the event in a protected virtual method
		// to enable derived classes to raise the event.
		protected virtual void RaiseRefreshOverview()
		{
			if(RefreshOverview != null)
				RefreshOverview();
		}


        public UserControlCheckInMain()
        {
			
			dsTimeReport = TimeLogFactory.Instance;
            
			InitializeComponent();
			Application.DoEvents();            

			SelectedTime = DateTime.Now;
            SelectedDate = DateTime.Today;

            RefreshDataGrids();
            
			dataGridView_week.DataError += DataGrid_DataError;
			dataGridView_month.DataError += DataGrid_DataError;

			m_dataGridViewToday.TimeLogChange += new EventHandler(DataGridViewToday_TimeLogChange);
			m_MonthCalendar.AnnuallyBoldedDates = HolidaysCollection.Instance.GetDates();
			InitDataGridStyle();
		}

		private void InitDataGridStyle()
		{
			DataGridStyle.InitDefaultStyle();
			dataGridView_month.ApplyDefaultStyle();
			dataGridView_week.ApplyDefaultStyle();
			m_userControlMonthSummary.DataGrid.ApplyDefaultStyle();
		}

		void DataGridViewToday_TimeLogChange(object sender, EventArgs e)
		{
			UpdateTimeLogToday();
			RefreshDataGrids();
		}


		#region Properties
		private double Hour
        {
            get
            {
                try
                {
					m_Hours = (double)m_NumericUpDownToWork.Value;
                }
                catch { }
                return m_Hours;
            }
            set
            {
                m_Hours = value;				
				m_NumericUpDownToWork.Value = (decimal)value;
            }

        }
        public DateTime SelectedDate
        {
			get
			{
				return m_MonthCalendar.SelectionStart.Date;
			}
            set { 
				m_MonthCalendar.SelectionStart = value; 
			}
        }
        public DateTime SelectedTime
        {
			get
			{
				return new DateTime(SelectedDate.Year,SelectedDate.Month, SelectedDate.Day, 
					(int)m_NumericUpDownHour.Value ,(int) m_NumericUpDownMinute.Value, 0 );
			}
			set
			{				
				m_NumericUpDownHour.Value = value.Hour;
				m_NumericUpDownMinute.Value = value.Minute;
				
			}
        }


        public TimeLogDataSet.CategoryRow SelectedCategory
        {
			get
			{
				try
				{
					if (ListBox_WorkCaegory.SelectedItem != null)
						return (TimeLogDataSet.CategoryRow)((DataRowView)ListBox_WorkCaegory.SelectedItem).Row;
					else
					{
						return GetDefaultCategory();
					}
				}
				catch
				{
					return GetDefaultCategory();
				}
			}
			set {
				ListBox_WorkCaegory.SelectedItem = value;
			}
        }

		private TimeLogDataSet.CategoryRow GetDefaultCategory()
		{
			if (dsTimeReport.Category.Count > 0)
			{
				return dsTimeReport.Category.First();
			}

			TimeLogDataSet.CompanyRow cmpRow = dsTimeReport.Company.DefaultRow();
			TimeLogDataSet.CategoryRow workCatRow = dsTimeReport.Category.DefaultRow(cmpRow);
			return workCatRow;
		}

 
		private TimeLogDataSet.TimeLogRow SelectedTimeLogRow
		{
			get
			{
				TimeLogDataSet.TimeLogRow selectedTimelog = null;
				try
				{
					if (dsTimeReport.TimeLog.Count > 0)
					{
						selectedTimelog = dsTimeReport.TimeLog
						.Where(tl => tl.Day == SelectedDate
							&& tl.CategoryId == SelectedCategory.CategoryId
							&& (tl.IsInTimeNull() || tl.IsOutTimeNull())).FirstOrDefault();
					}
				}
				catch { }
				if (selectedTimelog == null)
				{
					selectedTimelog = dsTimeReport.TimeLog.NewTimeLogRow();
				}
				return selectedTimelog;
			}
		}

		private TimeLogDataSet.PlannedRow SelectedPlannedRow
		{
			get
			{
				TimeLogDataSet.PlannedRow selectedPlanned= null;
				try
				{
					if (dsTimeReport.Planned.Count > 0)
					{
						selectedPlanned = dsTimeReport.Planned
						.Where(tl => tl.Day == SelectedDate
							&& tl.CategoryId == SelectedCategory.CategoryId ).FirstOrDefault();
					}
				}
				catch { }
				if (selectedPlanned == null)
				{
					selectedPlanned = dsTimeReport.Planned.NewPlannedRow();
					selectedPlanned.Day = SelectedDate;
					selectedPlanned.CategoryId = SelectedCategory.CategoryId;
					selectedPlanned.CategoryRow = SelectedCategory;
					selectedPlanned.Hours = Hour;
				}
				return selectedPlanned;
			}
		}

		#endregion Properties

		#region Public methods
		public void TrimDataGridHeights (){

			int dgDailyHight = m_dataGridViewToday.DataGrid.ColumnHeadersHeight
					+ (m_dataGridViewToday.DataGrid.RowCount * m_dataGridViewToday.DataGrid.RowTemplate.Height);

			int dgWeekHight = dataGridView_week.ColumnHeadersHeight
					+ (dataGridView_week.RowCount * dataGridView_week.RowTemplate.Height);
			
			

			splitContainer1.SplitterDistance = Math.Max( dgDailyHight + 15 , 80);
			splitContainer2.SplitterDistance = Math.Max( dgWeekHight + 15 , 60);
		}

        public void RefreshDataGrids()
        {
			TimeLogFactory.FillAllTables();
			RaiseRefreshOverview();			
            TimeLogFactory.CalculateMonths(SelectedDate);			
			dsTimeReport.DayTimeLog.AcceptChanges();
			dayTimeLogBindingSource.DataSource = dsTimeReport.DayTimeLog;
			FilterWeeks();
            categoryBindingSource.DataSource = dsTimeReport.Category;
            RefreshTodayOnly();
			SetHowLongToWorkTodayLabel();
			SetTotalLabel();
			TrimDataGridHeights();
        }

		#endregion

		#region Private methods
		
		private void WriteEntery(bool IsInTime)
        {

			TimeLogDataSet.TimeLogRow timeLogRow = SelectedTimeLogRow;

			if (timeLogRow.RowState == DataRowState.Detached) { 
				/// 
				/// New Time Log row
				/// 
				TimeLogDataSet.CategoryRow catRow = SelectedCategory ;
				timeLogRow.CategoryId = catRow.CategoryId;
				timeLogRow.CategoryRow = catRow;
				timeLogRow.CategoryText= catRow.DisplayValue;
				if (IsInTime)
				{					
					timeLogRow.InTime = SelectedTime;
				}
				else
				{
					timeLogRow.OutTime = SelectedTime;
				}
				
				if (SelectedPlannedRow.RowState == DataRowState.Detached)
					dsTimeReport.Planned.AddPlannedRow(SelectedPlannedRow);

				timeLogRow.PlannedRowParent = SelectedPlannedRow;
				timeLogRow.Day = SelectedDate;
				dsTimeReport.TimeLog.AddTimeLogRow(timeLogRow);            
				
			} else {
				if (IsInTime)
				{
					timeLogRow.InTime = SelectedTime;
				}
				else
				{
					timeLogRow.OutTime = SelectedTime;
				}				
			}

			try
			{
				new CompanyTableAdapter().Update(dsTimeReport.Company);
				new CategoryTableAdapter().Update(dsTimeReport.Category);
				new PlannedTableAdapter().Update(dsTimeReport.Planned);
				timeLogTableAdapter.Update(dsTimeReport.TimeLog);
			}
			catch { }

            dsTimeReport.AcceptChanges();
			RefreshDataGrids();
        }

        private void RefreshTodayOnly()
        {
            timeLogBindingSource.DataSource = dsTimeReport.TimeLog.Where(time => time.Day == SelectedDate).ToArray() ;
        }

		private void FilterWeeks()
		{

			try
			{				
				dsTimeReport.WeekTimeLog.Clear();
				foreach (var day in dsTimeReport.DayTimeLog)
				{
					TimeLogDataSet.WeekTimeLogRow row = dsTimeReport.WeekTimeLog.FindByYearCategoryIdWeekNr(day.Day.Year, day.CategoryId , day.Day.GetWeekOfYear());
					if (row == null)
					{
						dsTimeReport.WeekTimeLog.AddWeekTimeLogRow(day.Day.GetWeekOfYear(), day.Hours, day.PlannedHours, day.CategoryId, day.Category, day.Day.Year);
					}
					else
					{
						row.Hours += day.Hours;
						row.PlannedHours += day.PlannedHours;
					}

				}
				dsTimeReport.WeekTimeLog.AcceptChanges();

				weekTimeLogBindingSource.DataSource = dsTimeReport.WeekTimeLog ;

			}
			catch
			{

			}

		}

		private void UpdateTimeLogToday()
		{
			TimeLogDataSet.TimeLogDataTable changesDel =
				(TimeLogDataSet.TimeLogDataTable) dsTimeReport.TimeLog.GetChanges(DataRowState.Deleted);
			TimeLogDataSet.TimeLogDataTable changes = (TimeLogDataSet.TimeLogDataTable) dsTimeReport.TimeLog.GetChanges();
			
			if (changes == null && changesDel == null) return;
			
			try
			{
				try
				{
					timeLogTableAdapter.Update(dsTimeReport.TimeLog);
				}
				catch
				{
				}
				if (changes != null) changes.AcceptChanges();
				dsTimeReport.TimeLog.AcceptChanges();
				RefreshTodayOnly();

				var emptyPlnRows = dsTimeReport.Planned.Where(ph => dsTimeReport.TimeLog.Count > 0
				                                                      &&
				                                                      dsTimeReport.TimeLog.Where(
				                                                      	time =>
				                                                      	time.Day == ph.Day && time.CategoryId == ph.CategoryId).
				                                                      	Count() == 0);
				if (emptyPlnRows.Count() > 0)
				{
					foreach (TimeLogDataSet.PlannedRow row in emptyPlnRows)
					{
						row.Delete();
					}
					new PlannedTableAdapter().Update(dsTimeReport.Planned);
				}
			}
			catch
			{
			}
		}

    	private void SetTotalLabel()
		{

			m_userControlMonthSummary.Month = this.SelectedDate;
			return;

			//label_info.Text = "Denna månad:" + Environment.NewLine;
			//int daycount = dsTimeReport.DayTimeLog.GroupBy(dl => dl.Day, dl => dl).Count();
			//label_info.Text += daycount + " arbetsdagar" + Environment.NewLine +Environment.NewLine ;

			//double totalHours = 0; 
			//double totalPlanned = 0;
			//double totalDiff = 0;

			//var worked = dsTimeReport.DayTimeLog.GroupBy(dl => dl.CategoryId, dl => dl );
			//foreach (var category in worked)
			//{
			//    double sum = category.Sum(day => day.Hours);
			//    double plan = category.Sum(day => day.PlannedHours);
			//    double diff = sum - plan;
			//    totalHours += sum;
			//    totalPlanned += plan;
			//    totalDiff += diff;
			//    string format = "{0,4:N2} av {1,4:N2} [+{2,4:N2}] - ";
			//    if (diff < 0) {
			//        format = "{0,4:N2} av {1,4:N2} [{2,4:N2}] - ";
			//    }
			//    else if (diff == 0) {
			//        format = "{0,4:N2} av {1,4:N2} - ";
			//    }
			//    label_info.Text += string.Format(format , sum, plan, diff);
			//    label_info.Text += dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue + Environment.NewLine;
			//}

			//label_monthTotal.Text = string.Format("Arbetat:{0,7:N2}  tim.{2}Plan:{1,10:N2}  tim.", totalHours, totalPlanned, Environment.NewLine);
			//if(totalDiff > 0){
			//    label_Diff.Text = string.Format("Skilnad:+{0,7:N2}  tim.", totalDiff);
			//    label_Diff.ForeColor = Color.GreenYellow;
			//}else{
			//    label_Diff.Text = string.Format("Skilnad:{0,7:N2}  tim.", totalDiff);
			//    label_Diff.ForeColor = Color.OrangeRed;

			//}
			
		}


		/// <summary>
		/// Set label text that displays how long do you need to
		/// work today to fulfill todays planed hours.
		/// </summary>
		private void SetHowLongToWorkTodayLabel() 
		{
			var today = TimeLogFactory.Instance.DayTimeLog.FindByDayCategoryId(SelectedDate, SelectedCategory.CategoryId);
			DateTime timeToLeave = SelectedTime.AddHours(Hour);
			if (today != null) {
				timeToLeave = DateTime.Now.AddHours(-today.Diff); 
			}

			List<TimeLogDataSet.TimeLogRow> incompleteTimeLogs = TimeLogFactory.Instance.TimeLog.FindIncmpleteTimeLogs(SelectedDate);
			if (incompleteTimeLogs != null) {
				foreach (TimeLogDataSet.TimeLogRow row in incompleteTimeLogs)
				{
					if (row.CategoryId == SelectedCategory.CategoryId
						&& row.IsInTimeNull() == false
						&& row.IsOutTimeNull() == true)
					{
						timeToLeave = row.InTime.AddHours(-today.Diff);
						break;
					}
				}
			}
			m_LabelTimeToFinishToday.Text = string.Format("Klar {0:HH.mm}", timeToLeave);

		}
		#endregion        
		
		#region Events



		private void Button_in_Click(object sender, EventArgs e)
		{
			WriteEntery(true);
		}

		private void Button_out_Click(object sender, EventArgs e)
		{
			WriteEntery(false);
		}

		//private void Button_Refresh_Click(object sender, EventArgs e)
		//{
		//    RefreshDataGrids();
		//    RefreshTodayOnly();
		//}

        private void Button_AddCategory_Click(object sender, EventArgs e)
        {
            if (m_FormAddCategory == null)
            {
                m_FormAddCategory = new FormAddCategory();
            }
            m_FormAddCategory.TimeReportDS = dsTimeReport;
            m_FormAddCategory.ShowDialog();

            RefreshDataGrids();
        }

		private void NumericUpDownToWork_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (dsTimeReport.Category.Count == 0) return;
			
				int wid = SelectedCategory.CategoryId;
				TimeLogDataSet.PlannedRow planned = dsTimeReport.Planned.FindByDayCategoryId(SelectedDate, wid);

				if (planned == null) return;

				planned.Hours = Hour;
				new PlannedTableAdapter().Update(dsTimeReport.Planned);
				dsTimeReport.Planned.AcceptChanges();
				RefreshDataGrids();
			}
			catch
			{
			}
		}
       
        private void DigitalClock_Now_Click(object sender, EventArgs e)
        {            
            SelectedTime = DateTime.Now;
            SelectedDate = DateTime.Today;
        }

        void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e) {}

		//private void DataGridView_Timmar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		//{
		//    timeLogTableAdapter.Update(dsTimeReport.TimeLog);
		//    RefreshDataGrids();
		//}       
        
        private void ListBox_Category_SelectedValueChanged(object sender, EventArgs e)
        {
        	if (ListBox_WorkCaegory.SelectedItem == null) return;

			m_NumericUpDownToWork.ValueChanged -= NumericUpDownToWork_ValueChanged;

			Holiday holiday = HolidaysCollection.Instance.Find(holid => holid.Date == SelectedDate);			
			if (holiday != null) {
				Hour = holiday.TimeToWork;
			}

        	TimeLogDataSet.PlannedRow dayRow = dsTimeReport.Planned.FindByDayCategoryId(SelectedDate, SelectedCategory.CategoryId);
        	if (dayRow != null)
        	{
        		Hour = dayRow.Hours;
        	}

			m_NumericUpDownToWork.ValueChanged += this.NumericUpDownToWork_ValueChanged;
        }

 
		private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			SelectedDate = e.Start;
			
			RefreshDataGrids();
			if (dsTimeReport.Category.Count > 0)
			{
				List<TimeLogDataSet.TimeLogRow> incompleteTimeLogs = dsTimeReport.TimeLog.FindIncmpleteTimeLogs(SelectedDate);
				TimeLogDataSet.PlannedRow planedDayHour = dsTimeReport.Planned.FindByDayCategoryId(SelectedDate, SelectedCategory.CategoryId);
				Holiday holiday = HolidaysCollection.Instance.Find(holid => holid.Date == SelectedDate);

				if (incompleteTimeLogs != null && incompleteTimeLogs.Count > 0 )
				{
					Hour = incompleteTimeLogs.First().PlannedRowParent.Hours;
					SelectedCategory = incompleteTimeLogs.First().CategoryRow;
				}
				else if (planedDayHour != null)
				{
					Hour = planedDayHour.Hours;
				}
				else if (holiday != null)
				{
					Hour = holiday.TimeToWork;
				}
				else
				{
					Hour = 8;
				}
			}

			if (m_MonthCalendar.AnnuallyBoldedDates.Contains(SelectedDate))
			{
			
				Holiday h = HolidaysCollection.GetHoliday(SelectedDate);
				m_ToolTip.ToolTipTitle = SelectedDate.ToShortDateString();
				m_ToolTip.SetToolTip(m_MonthCalendar, h.ToString());
				m_ToolTip.Active = true;

			}
			else
			{
				m_ToolTip.Active = false;
			}


		}

		private void m_DeleteSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DateTime? dtIn = m_dataGridViewToday.DataGrid.SelectedRows[0].Cells[1].Value as DateTime?;
			DateTime? dtOut = m_dataGridViewToday.DataGrid.SelectedRows[0].Cells[2].Value as DateTime?;

			var p = TimeLogFactory.Instance.TimeLog.
				Where(	tl =>
						(!dtIn.HasValue && tl.IsInTimeNull() || (dtIn.HasValue && tl.InTime == dtIn.Value))
					&& (!dtOut.HasValue && tl.IsOutTimeNull() || (dtOut.HasValue && tl.OutTime == dtOut.Value)));

			if (p.Count() > 0) {
				var row = p.First();
				
				row.Delete();
				
				UpdateTimeLogToday();
				RefreshDataGrids();
				
			}
		}

		private void m_ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (m_dataGridViewToday.DataGrid.SelectedRows.Count == 0)
			{
				e.Cancel = true;
			}
		}

        #endregion

		private void m_NumericUpDownMinute_ValueChanged(object sender, EventArgs e)
		{
			decimal minute = m_NumericUpDownMinute.Value;
			if (minute == 59)
			{
				m_NumericUpDownMinute.Value = 0;
				return;
			}

			if (minute < 0)
			{
				m_NumericUpDownMinute.Value = 55;
				return;
			}


			while ((minute%5) != 0)
			{
				if (minute == 0) break;
				minute--;
			}
			m_NumericUpDownMinute.Value = minute;

		}




    }
}
