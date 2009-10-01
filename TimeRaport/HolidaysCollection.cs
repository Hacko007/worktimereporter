using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;

namespace Hackovic.TimeReport
{
	public enum DistinctDateSetting
	{
		NewRowOverwritesOld,
		IgnoreNew,
		CreateNewRow
	}

	public class HolidaysCollection : List<Holiday>
	{
		private static HolidaysCollection m_Instance;
		public static HolidaysCollection Instance {
			get {
				if (m_Instance == null) {
					m_Instance = new HolidaysCollection();
					m_Instance.LoadHolidays();					
				}
				return m_Instance;
			}
		}

		public DistinctDateSetting DistinctDateSetting { get; set; }

		public void LoadHolidays() { 
			string xml =  Properties.Settings.Default.Holidays;			
			LoadHolidays(xml);
		}

		public void LoadHolidays(string xml)
		{
			DistinctDateSetting = DistinctDateSetting.CreateNewRow;
			
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xml);

			XmlNodeList nodes = doc.GetElementsByTagName("Holiday");
			
		  ///<Holiday>
		  ///  <Date>2001-01-06</Date>
		  ///  <Name>13 dag</Name>
		  ///  <Info>Vi är lediga</Info>
		  ///  <TimeToWork>0,5</TimeToWork>
		  ///</Holiday>
			foreach (XmlNode item in nodes)
			{
				if (item.HasChildNodes && item.ChildNodes.Count > 3)
				{
					try
					{
						Holiday hol = new Holiday();						
						hol.Date = DateTime.Parse(item["Date"].InnerText);
						hol.Date = hol.Date.AddYears(DateTime.Today.Year - hol.Date.Year);
						hol.Name = item["Name"].InnerText;
						hol.Info = item["Info"].InnerText;
						hol.TimeToWork = double.Parse(item["TimeToWork"].InnerText);

						bool isnew = this.Where(h => h.Date == hol.Date).Count() == 0;
						if (isnew || DistinctDateSetting == DistinctDateSetting.CreateNewRow)
						{
							this.Add(hol);
						}
						else if(DistinctDateSetting == DistinctDateSetting.NewRowOverwritesOld)
						{
							var p = this.Where(h => h.Date == hol.Date);
							if (p.Count() > 0) {
								Holiday h = p.First();
								Remove(h);								
							}
							Add(hol);
						}
					}
					catch (Exception e){
							Console.WriteLine(e.ToString());
					}
				}
			}
		}

		internal DateTime[] GetDates()
		{
			return this.Select(Holiday => Holiday.Date).ToArray();
		}

		public DataTable ToDataTable() {
			DataTable table = GetTable();

			foreach (Holiday item in this.OrderBy( h => h.Date) )
			{
				DataRow row = table.NewRow();
				
				row["Date"] = item.Date;
				row["Name"]= item.Name;
				row["Info"]= item.Info;
				row["TimeToWork"]= item.TimeToWork;
				table.Rows.Add(row);
			}
			return table;
		}

		public void Update(DataTable table)
		{
			Clear();
			foreach (DataRow row in table.Select("","", DataViewRowState.CurrentRows) )
			{
				try
				{
					Holiday item = new Holiday();
					item.Date = (DateTime)row["Date"];
					item.Name = row["Name"].ToString();
					item.Info = row["Info"].ToString();
					item.TimeToWork = (double)row["TimeToWork"];
					Add(item);
				}
				catch { }
			}
			Save();
		}
		public string ToXml()
		{
			StringBuilder xml = new StringBuilder(string.Format( "<?xml version=\"1.0\" encoding=\"utf-8\" ?>{0}<Root>{0}", Environment.NewLine )) ;
			foreach (Holiday item in this)
			{
				xml.AppendLine(item.ToXml());
			}
			xml.AppendLine("</Root>");
			return xml.ToString();			
		}

		public void Save() {			

			Properties.Settings.Default["Holidays"] = ToXml() ;
			Properties.Settings.Default.Save();
		}


		private static DataTable GetTable()
		{
			DataTable table = new DataTable();

			DataColumn c1 = new DataColumn
			{
				ColumnName = "Date",
				Caption = "Datum",
				DataType = typeof(DateTime)
			};
			DataColumn c2 = new DataColumn
			{
				ColumnName = "Name",
				Caption = "Namn",
				DataType = typeof(string)
			};
			DataColumn c3 = new DataColumn
			{
				ColumnName = "Info",
				Caption = "Info",
				DataType = typeof(string)
			};
			DataColumn c4 = new DataColumn
			{
				ColumnName = "TimeToWork",
				Caption = "Att jobba",
				DataType = typeof(double)
			};

			table.Columns.Add(c1);
			table.Columns.Add(c2);
			table.Columns.Add(c3);
			table.Columns.Add(c4);
			return table;
		}

		internal static Holiday GetHoliday(DateTime SelectedDate)
		{
			var h = Instance.Where(hol => hol.Date == SelectedDate);
			return h.Count() > 0 ? h.First() : null;
		}
	}
}
