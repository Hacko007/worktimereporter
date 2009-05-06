using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Linq;
using Hackovic.TimeReport.TimeLogDataSetTableAdapters;

namespace Hackovic.TimeReport
{
    public partial class UserControlCheckInMain : UserControl
    {
		private FormAddCategry m_FormAddCategory;       
		private TimeLogDataSet dsTimeReport ;
		private double m_Hours = 0;


		// Declare the event.
		public event RefreshOverview RefreshOverview;

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
            DateTime dt = DateTime.Now;

			this.SelectedTime = DateTime.Now;
            this.SelectedDate = DateTime.Today;

            RefreshDataGrids();

            dataGridView_Timmar.DataError += DataGrid_DataError;
			dataGridView_week.DataError += DataGrid_DataError;
			dataGridView_month.DataError += DataGrid_DataError;

			m_MonthCalendar.AnnuallyBoldedDates = HolidaysCollection.Instance.GetDates();
		}


		#region Properties
		private double Hour
        {
            get
            {
                try
                {
					this.m_Hours = (double)m_NumericUpDownToWork.Value;
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
				this.m_MonthCalendar.SelectionStart = value; 
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
                    return (TimeLogDataSet.CategoryRow)((DataRowView)this.ListBox_WorkCaegory.SelectedItem).Row;
                }
                catch
                {
					if (dsTimeReport.Category.Count > 0) {
						return dsTimeReport.Category.First();
					}
					else
					{
						TimeLogDataSet.CompanyRow cmp_row = dsTimeReport.Company.DefaultRow();
						TimeLogDataSet.CategoryRow work_cat_row = dsTimeReport.Category.DefaultRow(cmp_row);
						return work_cat_row;
					}
                    
                }
            }
			set {
				this.ListBox_WorkCaegory.SelectedItem = value;
			}
        }

 
		private TimeLogDataSet.TimeLogRow SelectedTimeLogRow
		{
			get
			{
				TimeLogDataSet.TimeLogRow selected_timelog = null;
				try
				{
					if (dsTimeReport.TimeLog.Count > 0)
					{
						selected_timelog = dsTimeReport.TimeLog
						.Where(tl => tl.Day == this.SelectedDate
							&& tl.CategoryId == this.SelectedCategory.CategoryId
							&& (tl.IsInTimeNull() || tl.IsOutTimeNull())).First();
					}
				}
				catch { }
				if (selected_timelog == null)
				{
					selected_timelog = dsTimeReport.TimeLog.NewTimeLogRow();
				}
				return selected_timelog;
			}
		}

		private TimeLogDataSet.PlannedRow SelectedPlannedRow
		{
			get
			{
				TimeLogDataSet.PlannedRow selected_planned= null;
				try
				{
					if (dsTimeReport.Planned.Count > 0)
					{
						selected_planned = dsTimeReport.Planned
						.Where(tl => tl.Day == this.SelectedDate
							&& tl.CategoryId == this.SelectedCategory.CategoryId ).First();
					}
				}
				catch { }
				if (selected_planned == null)
				{
					selected_planned = dsTimeReport.Planned.NewPlannedRow();
					selected_planned.Day = this.SelectedDate;
					selected_planned.CategoryId = this.SelectedCategory.CategoryId;
					selected_planned.CategoryRow = this.SelectedCategory;
					selected_planned.Hours = this.Hour;
				}
				return selected_planned;
			}
		}

		#endregion Properties

		#region Public methods
		public void TrimDataGridHeights (){

			int dgDailyHight = dataGridView_Timmar.ColumnHeadersHeight
					+ (dataGridView_Timmar.RowCount * dataGridView_Timmar.RowTemplate.Height);

			int dgWeekHight = dataGridView_week.ColumnHeadersHeight
					+ (dataGridView_week.RowCount * dataGridView_week.RowTemplate.Height);
			
			

			splitContainer1.SplitterDistance = Math.Max( dgDailyHight + 15 , 80);
			splitContainer2.SplitterDistance = Math.Max( dgWeekHight + 15 , 60);
		}

		#endregion

		#region Private methods
		
		private void WriteEntery(bool is_InTime)
        {

			TimeLogDataSet.TimeLogRow time_log_row = this.SelectedTimeLogRow;

			if (time_log_row.RowState == DataRowState.Detached) { 
				/// 
				/// New Time Log row
				/// 
				TimeLogDataSet.CategoryRow cat_row = this.SelectedCategory ;
				time_log_row.CategoryId = cat_row.CategoryId;
				time_log_row.CategoryRow = cat_row;
				time_log_row.CategoryText= cat_row.DisplayValue;
				if (is_InTime)
				{					
					time_log_row.InTime = this.SelectedTime;
				}
				else
				{
					time_log_row.OutTime = this.SelectedTime;
				}
				
				if (this.SelectedPlannedRow.RowState == DataRowState.Detached)
					dsTimeReport.Planned.AddPlannedRow(this.SelectedPlannedRow);

				time_log_row.PlannedRowParent = this.SelectedPlannedRow;
				time_log_row.Day = this.SelectedDate;
				dsTimeReport.TimeLog.AddTimeLogRow(time_log_row);            
				
			} else {
				if (is_InTime)
				{
					time_log_row.InTime = this.SelectedTime;
				}
				else
				{
					time_log_row.OutTime = this.SelectedTime;
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
			this.RefreshDataGrids();
        }

        private void RefreshDataGrids()
        {
			TimeLogFactory.FillAllTables();
			this.RaiseRefreshOverview();			
            TimeLogFactory.CalculateMonths(this.SelectedDate);			
			dsTimeReport.DayTimeLog.AcceptChanges();
			dayTimeLogBindingSource.DataSource = dsTimeReport.DayTimeLog;
			this.FilterWeeks();
            this.categoryBindingSource.DataSource = dsTimeReport.Category;
            this.RefreshTodayOnly();
			this.SetTotalLabel();
			this.TrimDataGridHeights();
        }

        private void RefreshTodayOnly()
        {
            this.timeLogBindingSource.DataSource = dsTimeReport.TimeLog.Where(time => time.Day == this.SelectedDate).ToArray() ;
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
            TimeLogDataSet.TimeLogDataTable changes_del = (TimeLogDataSet.TimeLogDataTable)dsTimeReport.TimeLog.GetChanges(DataRowState.Deleted);
            TimeLogDataSet.TimeLogDataTable changes = (TimeLogDataSet.TimeLogDataTable)dsTimeReport.TimeLog.GetChanges();
            if (changes != null || changes_del != null)
            {
                try
                {
                    try
                    {
                        timeLogTableAdapter.Update(dsTimeReport.TimeLog);
                    }
                    catch { }
                    changes.AcceptChanges();
                    dsTimeReport.TimeLog.AcceptChanges();
                    this.RefreshTodayOnly();
                    
                    var empty_pln_rows = dsTimeReport.Planned.Where(ph => dsTimeReport.TimeLog.Count > 0
                    && dsTimeReport.TimeLog.Where(time => time.Day == ph.Day && time.CategoryId == ph.CategoryId).Count() == 0);
                    if (empty_pln_rows != null && empty_pln_rows.Count() > 0) {
                        foreach (TimeLogDataSet.PlannedRow row in empty_pln_rows)
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
        }

		private void SetTotalLabel()
		{
			label_info.Text = "Denna månad:" + Environment.NewLine;
			int daycount = dsTimeReport.DayTimeLog.GroupBy(dl => dl.Day, dl => dl).Count();
			label_info.Text += daycount + " arbetsdagar" + Environment.NewLine +Environment.NewLine ;

			double total_hours = 0; 
			double total_planned = 0;
			double total_diff = 0;

			var worked = dsTimeReport.DayTimeLog.GroupBy(dl => dl.CategoryId, dl => dl );
			foreach (var category in worked)
			{
				double sum = category.Sum(day => day.Hours);
				double plan = category.Sum(day => day.PlannedHours);
				double diff = sum - plan;
				total_hours += sum;
				total_planned += plan;
				total_diff += diff;
				string format = "{0,4:N2} av {1,4:N2} [+{2,4:N2}] - ";
				if (diff < 0) {
					format = "{0,4:N2} av {1,4:N2} [{2,4:N2}] - ";
				}
				else if (diff == 0) {
					format = "{0,4:N2} av {1,4:N2} - ";
				}
				label_info.Text += string.Format(format , sum, plan, diff);
				label_info.Text += dsTimeReport.Category.FindByCategoryId(category.Key).DisplayValue + Environment.NewLine;
			}

			label_monthTotal.Text = string.Format("Arbetat:{0,7:N2}  tim.{2}Plan:{1,10:N2}  tim.", total_hours, total_planned, Environment.NewLine);
			if(total_diff > 0){
				label_Diff.Text = string.Format("Skilnad:+{0,7:N2}  tim.", total_diff);
				label_Diff.ForeColor = Color.GreenYellow;
			}else{
				label_Diff.Text = string.Format("Skilnad:{0,7:N2}  tim.", total_diff);
				label_Diff.ForeColor = Color.OrangeRed;

 			}
			
		}

		#endregion        
		
		#region Events



		private void Button_in_Click(object sender, System.EventArgs e)
		{
			this.WriteEntery(true);
		}

		private void Button_out_Click(object sender, System.EventArgs e)
		{
			this.WriteEntery(false);
		}

		private void Button_Refresh_Click(object sender, EventArgs e)
		{
			RefreshDataGrids();
			RefreshTodayOnly();
		}

        private void Button_AddCategory_Click(object sender, EventArgs e)
        {
            if (m_FormAddCategory == null)
            {
                m_FormAddCategory = new FormAddCategry();
            }
            m_FormAddCategory.TimeReportDS = dsTimeReport;
            m_FormAddCategory.ShowDialog();

            RefreshDataGrids();
        }

		private void NumericUpDownToWork_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				int wid = 0;
				if (dsTimeReport.Category.Count > 0)
				{
					wid = this.SelectedCategory.CategoryId;
					TimeLogDataSet.PlannedRow planned = dsTimeReport.Planned.FindByDayCategoryId(this.SelectedDate, wid);
					
					if (planned == null) return;
				
					planned.Hours = this.Hour;
					new TimeLogDataSetTableAdapters.PlannedTableAdapter().Update(dsTimeReport.Planned);
					dsTimeReport.Planned.AcceptChanges();
					this.RefreshDataGrids();
				}
			}
			catch
			{
			}
		}
       
        private void DigitalClock_Now_Click(object sender, EventArgs e)
        {            
            this.SelectedTime = DateTime.Now;
            this.SelectedDate = DateTime.Today;
        }

        void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e) {}

        private void DataGridView_Timmar_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            timeLogTableAdapter.Update(dsTimeReport.TimeLog);
            RefreshDataGrids();
        }       
        
        private void ListBox_Category_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListBox_WorkCaegory.SelectedItem != null) {
                TimeLogDataSet.PlannedRow day_row = dsTimeReport.Planned.FindByDayCategoryId(this.SelectedDate, this.SelectedCategory.CategoryId);
               if (day_row != null)
               {
				   this.Hour = day_row.Hours;
               }
            }
        }

 
		private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			SelectedDate = e.Start;
			
			this.RefreshDataGrids();
			if (dsTimeReport.Category.Count > 0)
			{
				List<Hackovic.TimeReport.TimeLogDataSet.TimeLogRow> incompleteTimeLogs = dsTimeReport.TimeLog.FindIncmpleteTimeLogs(this.SelectedDate);
				TimeLogDataSet.PlannedRow dayh = dsTimeReport.Planned.FindByDayCategoryId(this.SelectedDate, this.SelectedCategory.CategoryId);
				if (incompleteTimeLogs != null && incompleteTimeLogs.Count > 0 )
				{
					this.Hour = incompleteTimeLogs.First().PlannedRowParent.Hours;
					this.SelectedCategory = incompleteTimeLogs.First().CategoryRow;
				}
				else if (dayh != null)
				{
					this.Hour = dayh.Hours;
				}

				else
				{
					this.Hour = 8;
				}
			}

			if (m_MonthCalendar.AnnuallyBoldedDates.Contains(SelectedDate))
			{
			
				Holiday h = HolidaysCollection.Instance.GetHoliday(SelectedDate);
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
			DateTime? dt_in = dataGridView_Timmar.SelectedRows[0].Cells[1].Value as DateTime?;
			DateTime? dt_out = dataGridView_Timmar.SelectedRows[0].Cells[2].Value as DateTime?;

			var p = TimeLogFactory.Instance.TimeLog.
				Where(	tl =>
						(!dt_in.HasValue && tl.IsInTimeNull() || (dt_in.HasValue && tl.InTime == dt_in.Value))
					&& (!dt_out.HasValue && tl.IsOutTimeNull() || (dt_out.HasValue && tl.OutTime == dt_out.Value)));

			if (p.Count() > 0) {
				var row = p.First();
				
				row.Delete();
				
				UpdateTimeLogToday();
				RefreshDataGrids();
				
			}
		}

		private void m_ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (dataGridView_Timmar.SelectedRows.Count == 0) {
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
			else if (minute < 0) {
				m_NumericUpDownMinute.Value = 55;
				return;			
			}
			else
			{
				while ((minute % 5) != 0)
				{
					if (minute == 0) break;
					minute--;
				}
				m_NumericUpDownMinute.Value = minute;
			}
		}
      


		
    }
}
