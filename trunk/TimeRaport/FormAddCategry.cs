using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public partial class FormAddCategry : Form
	{        

		public FormAddCategry()
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
            this.categoryTableAdapter.Fill(this.timeLogDataSet.Category);            
            this.companyTableAdapter.Fill(this.timeLogDataSet.Company);
            
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
            this.categoryTableAdapter.Update(timeLogDataSet.Category);
            this.timeLogDataSet.Category.AcceptChanges();
            this.RefreshData();
		}

        private void button_workCategoryReset_Click(object sender, EventArgs e)
        {
            this.timeLogDataSet.Category.RejectChanges();
        }

        #endregion Category
        #region Company

        private void button_SaveCompany_Click(object sender, EventArgs e)
        {
            try
            {
                this.companyTableAdapter.Update(this.timeLogDataSet.Company);
                this.timeLogDataSet.Company.AcceptChanges();
                this.RefreshData();

            }
            catch { }
        }

        private void button_comnapnyReset_Click(object sender, EventArgs e)
        {
            this.timeLogDataSet.Company.RejectChanges();
        }

        #endregion
      
      
      
	}
}
