using System;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public partial class FormAddCategory : Form
	{        

		public FormAddCategory()
		{
			InitializeComponent();
			
		}

        public TimeLogDataSet TimeReportDS { get { return timeLogDataSet; } 
            set {
                timeLogDataSet = value ;
                RefreshData();
            } 
        }
        void LoadData() {          
            categoryTableAdapter.Fill(timeLogDataSet.Category);            
            companyTableAdapter.Fill(timeLogDataSet.Company);
            
        }
        private void RefreshData() {

            LoadData();
            companyBindingSource.DataSource = timeLogDataSet.Company;
            categoryBindingSource.DataSource = timeLogDataSet.Category;
        }
        

        private void FormAddWorkCategry_Load(object sender, EventArgs e)
        {           
            RefreshData();
        }

        #region Category
        private void Button_Save_Click(object sender, EventArgs e)
		{
            categoryTableAdapter.Update(timeLogDataSet.Category);
            timeLogDataSet.Category.AcceptChanges();
            RefreshData();
		}

        private void button_workCategoryReset_Click(object sender, EventArgs e)
        {
            timeLogDataSet.Category.RejectChanges();
        }

        #endregion Category
        #region Company

        private void button_SaveCompany_Click(object sender, EventArgs e)
        {
            try
            {
                companyTableAdapter.Update(this.timeLogDataSet.Company);
                timeLogDataSet.Company.AcceptChanges();
                RefreshData();

            }
            catch { }
        }

        private void button_comnapnyReset_Click(object sender, EventArgs e)
        {
            timeLogDataSet.Company.RejectChanges();
        }

        #endregion

		private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{			
		}

     
	}
}
