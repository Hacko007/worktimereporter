using System.Linq;
using System.Collections.Generic;

namespace Hackovic.TimeReport
{
    
    
    public partial class TimeLogDataSet {
        partial class CategoryDataTable
        {
            public CategoryRow DefaultRow(CompanyRow comapny_row)
            {
                CategoryRow cat_row = this.First(cat => cat.Company == comapny_row.CompanyName);
 
                if (cat_row == null)
                {
                    cat_row = this.NewCategoryRow();
                    cat_row.Company = comapny_row.CompanyName;
                    cat_row.CompanyRow = comapny_row;
                    cat_row.Project = "Default";
                    cat_row.Code = "Normal";
                    this.AddCategoryRow(cat_row);
                }
                return cat_row;
            }
        }
    
        partial class CompanyDataTable
        {
            public CompanyRow DefaultRow() {
                CompanyRow cmp_row = this.First();
                if (cmp_row == null)
                {
                    cmp_row = this.AddCompanyRow("My Company");
                }
                return cmp_row;
            }
        }

		partial class TimeLogDataTable
		{
			internal List<TimeLogRow> FindIncmpleteTimeLogs(System.DateTime dateTime)
			{
				var incompleteTimeLogs = this.Where(
					timeLog =>
						(timeLog.Day.Date == dateTime.Date)
						&& (timeLog.IsInTimeNull() || timeLog.IsOutTimeNull())).ToList();
				
				return incompleteTimeLogs;
			}
		}

    }
}
