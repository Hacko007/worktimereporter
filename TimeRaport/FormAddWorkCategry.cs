using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeRaport
{
	public partial class FormAddWorkCategry : Form
	{        

		public FormAddWorkCategry()
		{
			InitializeComponent();
			
		}

        public TimeLogDataSet TimeReportDS { get { return timeLogDataSet; } 
            set {
                timeLogDataSet = value ;
                RefreshData();
            } 
        }

        private void RefreshData() {
           
 
           
            //this.companyTableAdapter.Fill(this.timeLogDataSet.Company);

            //dataGridView_Company.DataSource = timeLogDataSet.Company;
            //dataGridView_WorkCategory.DataSource = timeLogDataSet.WorkCategory;

            dataGridView_Company.DataSource = timeLogDataSet.Company;

            this.comboBox_Company.DisplayMember = this.timeLogDataSet.Company.CompanyNameColumn.ColumnName;
            this.comboBox_Company.ValueMember = this.timeLogDataSet.Company.CompanyNameColumn.ColumnName;
            this.comboBox_Company.DataSource = timeLogDataSet.Company;
           
           }
        

        private void FormAddWorkCategry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeReportDataSet.Company' table. You can move, or remove it, as needed.
            //this.companyTableAdapter.Fill(this.timeLogDataSet.Company);
            //this.workCategoryTableAdapter.Fill(this.timeLogDataSet.WorkCategory);

            RefreshData();
        }

        #region Work Category
        private void Button_Save_Click(object sender, EventArgs e)
		{
            //this.workCategoryTableAdapter.Insert(textBox_Project.Text.Trim(), comboBox_Company.Text, textBox_TimeCode.Text.Trim());
            //this.workCategoryTableAdapter.Fill(this.timeLogDataSet.WorkCategory);            
		}

        private void button_workCategoryReset_Click(object sender, EventArgs e)
        {
            //this.timeLogDataSet.WorkCategory.RejectChanges();
        }

        #endregion Work Category
        #region Company

        private void button_SaveCompany_Click(object sender, EventArgs e)
        {
            
            //this.companyTableAdapter.Update(this.timeLogDataSet.Company);
            //this.timeLogDataSet.Company.AcceptChanges();
        }

        private void button_comnapnyReset_Click(object sender, EventArgs e)
        {
            this.timeLogDataSet.Company.RejectChanges();
        }

        #endregion
      
      
      
	}
}
