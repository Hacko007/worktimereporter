using System;
using System.Linq;

namespace Hackovic.TimeReport
{
	public	class TimeLogFactory
	{
		private TimeLogFactory() { }


		#region TimeLogDataSet factory method
		private static TimeLogDataSet m_Instance;


		public static TimeLogDataSet Instance
		{
			get
			{
				lock (typeof(TimeLogFactory))
				{

					if (m_Instance == null)
					{
						m_Instance = new TimeLogDataSet();
					}
				}
				return m_Instance;
			}
		}
		#endregion

		public static void FillAllTables() {
			new TimeLogDataSetTableAdapters.CategoryTableAdapter().Fill(Instance.Category);
			new TimeLogDataSetTableAdapters.CompanyTableAdapter().Fill(Instance.Company);
			new TimeLogDataSetTableAdapters.PlannedTableAdapter().Fill(Instance.Planned);
			new TimeLogDataSetTableAdapters.TimeLogTableAdapter().Fill(Instance.TimeLog);
			Instance.AcceptChanges();
		}


		public static void CalculateMonths(DateTime Month)
		{

			try
			{
				if (Instance.TimeLog.Count == 0)
					FillAllTables();

				DateTime fromTime = Month;
				fromTime = new DateTime(fromTime.Year, fromTime.Month, 1);
				DateTime toTime = new DateTime(fromTime.Year, fromTime.Month, DateTime.DaysInMonth(fromTime.Year, fromTime.Month));

				var month = from p in m_Instance.Planned
							join d in m_Instance.TimeLog on new { p.Day, p.CategoryId } equals new { d.Day, d.CategoryId }
							where fromTime <= p.Day && p.Day <= toTime
							orderby p.Day descending
							select new
							{
								CategoryId = p.CategoryId,
								Category = p.CategoryRow.DisplayValue,
								Day = p.Day,
								PlannedHours = p.Hours,
								Hours = (d.IsInTimeNull() || d.IsOutTimeNull()) ? 0 : (d.OutTime - d.InTime).TotalHours,
								Info = (d.IsInfoNull()) ? "" : d.Info
							};

				m_Instance.DayTimeLog.Clear();
				foreach (var day in month)
				{
					TimeLogDataSet.DayTimeLogRow row = m_Instance.DayTimeLog.FindByDayCategoryId(day.Day, day.CategoryId);
					string info = string.IsNullOrEmpty(day.Info) ? "" : " * " + day.Info;
					if (row == null)
					{
						m_Instance.DayTimeLog.AddDayTimeLogRow(day.Day, day.Hours, day.PlannedHours, day.CategoryId, day.Category, info);
					}
					else
					{
						row.Hours += day.Hours;
						row.Info += info;
					}

				}
				m_Instance.DayTimeLog.AcceptChanges();

			}
			catch
			{

			}

		}
	}
}
