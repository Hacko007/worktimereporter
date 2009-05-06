using System.Data;

namespace Hackovic.TimeReport
{
	public static class DataTableExtention
	{
		public static T Distinct<T>(this T table, params DataColumn[] columns) 
			where T : DataTable , new()
		{

			if (table == null) return null;
			if (table.Rows.Count < 2) return table;			

			T result = (T) table.Clone();			

			foreach (DataRow row in table.Rows)
			{
				if (! IsRowInTable(result, row, columns)) {
					result.Rows.Add(row.ItemArray);
				}
			}
			return result;
		}


		private static bool IsRowInTable<T>(T table, DataRow row, DataColumn[] columns)
			where T : DataTable, new()
		{			
			foreach (DataRow myrow in table.Rows)
			{
				bool eq = true;
				if(columns == null)
					foreach (DataColumn col in table.Columns) eq = eq && (myrow[col.ColumnName] == row[col.ColumnName]);
				else
					foreach (DataColumn col in columns) eq = eq && (myrow[col.ColumnName] == row[col.ColumnName]);
				
				if (eq == false) return true;
			}
			return false;
		}


	}
}