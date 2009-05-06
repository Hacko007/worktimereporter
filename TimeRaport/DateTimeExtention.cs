using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Hackovic
{
	public static class DateTimeExtention
	{

        /// <summary>
        /// Get GregorianCalendar.GetWeekOfYear(this, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
		public static int GetWeekOfYear(this DateTime dt) {
           
           GregorianCalendar gr_calendar = new GregorianCalendar();
           int week_nr = gr_calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

           return week_nr;

		}
	}
}
