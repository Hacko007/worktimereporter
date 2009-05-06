using System;

namespace Hackovic.TimeReport
{	
	public class Holiday 
	{
		public Holiday() {
			TimeToWork = 0;
			Date = DateTime.MinValue;
			Name = "";
			Info = "";
		}


		public DateTime Date { get; set; }
		public string Name { get; set; }
		public string Info { get; set; }	   		
		public double TimeToWork { get; set; }

		public override string ToString()
		{
			string str = 
				string.Format("{0} - (jobba: {3} tim.) - {1} - {2} ", 
				Date.ToString("d. MMM"), 
				Name, 
				Info, 
				TimeToWork);
			return str;
		}

		public string ToXml()
		{
			String xml = string.Format("	<Holiday>"
			+ "<Date>{0}</Date>"
			+ "<Name>{1}</Name>"
			+ "<Info>{2}</Info>"
			+ "<TimeToWork>{3}</TimeToWork>"
			+ "</Holiday>",
		Date,
		Name,
		Info,
		TimeToWork);

			return xml;
		}
	}
}
