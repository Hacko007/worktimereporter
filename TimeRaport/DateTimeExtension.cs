using System;
using System.Globalization;

namespace Hackovic.TimeReport
{
	public static class DateTimeExtension
	{

		/// <summary>
		/// Get GregorianCalendar.GetWeekOfYear(this, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		public static int GetWeekOfYear(this DateTime dt) {
           
			GregorianCalendar grCalendar = new GregorianCalendar();
			int weekNr = grCalendar.GetWeekOfYear(dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

			return weekNr;

		}
	}
}