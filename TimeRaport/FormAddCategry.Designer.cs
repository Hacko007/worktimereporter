namespace Hackovic.TimeReport
{
	partial class FormAddCategry
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabPage_WorkCategory = new System.Windows.Forms.TabPage();
			this.dataGridView_WorkCategory = new System.Windows.Forms.DataGridView();
			this.companyDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeLogDataSet = new Hackovic.TimeReport.TimeLogDataSet();
			this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.displayValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button_save = new System.Windows.Forms.Button();
			this.button_workCategoryReset = new System.Windows.Forms.Button();
			this.tabPage_Company = new System.Windows.Forms.TabPage();
			this.button_comnapnyReset = new System.Windows.Forms.Button();
			this.button_SaveCompany = new System.Windows.Forms.Button();
			this.dataGridView_Company = new System.Windows.Forms.DataGridView();
			this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl_Main = new System.Windows.Forms.TabControl();
			this.companyTableAdapter = new Hackovic.TimeReport.TimeLogDataSetTableAdapters.CompanyTableAdapter();
			this.categoryTableAdapter = new Hackovic.TimeReport.TimeLogDataSetTableAdapters.CategoryTableAdapter();
			this.tabPage_WorkCategory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			this.tabPage_Company.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Company)).BeginInit();
			this.tabControl_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage_WorkCategory
			// 
			this.tabPage_WorkCategory.Controls.Add(this.dataGridView_WorkCategory);
			this.tabPage_WorkCategory.Controls.Add(this.button_save);
			this.tabPage_WorkCategory.Controls.Add(this.button_workCategoryReset);
			this.tabPage_WorkCategory.Location = new System.Drawing.Point(4, 22);
			this.tabPage_WorkCategory.Name = "tabPage_WorkCategory";
			this.tabPage_WorkCategory.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_WorkCategory.Size = new System.Drawing.Size(803, 471);
			this.tabPage_WorkCategory.TabIndex = 0;
			this.tabPage_WorkCategory.Text = "Arbetsgrupp";
			this.tabPage_WorkCategory.UseVisualStyleBackColor = true;
			// 
			// dataGridView_WorkCategory
			// 
			this.dataGridView_WorkCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_WorkCategory.AutoGenerateColumns = false;
			this.dataGridView_WorkCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_WorkCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyDataGridViewComboBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.displayValueDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn});
			this.dataGridView_WorkCategory.DataSource = this.categoryBindingSource;
			this.dataGridView_WorkCategory.Location = new System.Drawing.Point(6, 45);
			this.dataGridView_WorkCategory.Name = "dataGridView_WorkCategory";
			this.dataGridView_WorkCategory.Size = new System.Drawing.Size(791, 420);
			this.dataGridView_WorkCategory.TabIndex = 9;
			this.dataGridView_WorkCategory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
			// 
			// companyDataGridViewComboBoxColumn
			// 
			this.companyDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.companyDataGridViewComboBoxColumn.DataPropertyName = "Company";
			this.companyDataGridViewComboBoxColumn.DataSource = this.companyBindingSource;
			this.companyDataGridViewComboBoxColumn.DisplayMember = "CompanyName";
			this.companyDataGridViewComboBoxColumn.HeaderText = "Company";
			this.companyDataGridViewComboBoxColumn.Name = "companyDataGridViewComboBoxColumn";
			this.companyDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.companyDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// companyBindingSource
			// 
			this.companyBindingSource.DataMember = "Company";
			this.companyBindingSource.DataSource = this.timeLogDataSet;
			// 
			// timeLogDataSet
			// 
			this.timeLogDataSet.DataSetName = "TimeReportDataSet";
			this.timeLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// projectDataGridViewTextBoxColumn
			// 
			this.projectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
			this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
			this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
			// 
			// codeDataGridViewTextBoxColumn
			// 
			this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
			this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
			this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
			// 
			// infoDataGridViewTextBoxColumn
			// 
			this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
			this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
			this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
			// 
			// displayValueDataGridViewTextBoxColumn
			// 
			this.displayValueDataGridViewTextBoxColumn.DataPropertyName = "DisplayValue";
			this.displayValueDataGridViewTextBoxColumn.HeaderText = "DisplayValue";
			this.displayValueDataGridViewTextBoxColumn.Name = "displayValueDataGridViewTextBoxColumn";
			this.displayValueDataGridViewTextBoxColumn.Visible = false;
			// 
			// categoryIdDataGridViewTextBoxColumn
			// 
			this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
			this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.categoryIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataMember = "Category";
			this.categoryBindingSource.DataSource = this.timeLogDataSet;
			// 
			// button_save
			// 
			this.button_save.Location = new System.Drawing.Point(8, 16);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(136, 23);
			this.button_save.TabIndex = 1;
			this.button_save.Text = "Spara";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.Button_Save_Click);
			// 
			// button_workCategoryReset
			// 
			this.button_workCategoryReset.Location = new System.Drawing.Point(150, 16);
			this.button_workCategoryReset.Name = "button_workCategoryReset";
			this.button_workCategoryReset.Size = new System.Drawing.Size(136, 23);
			this.button_workCategoryReset.TabIndex = 8;
			this.button_workCategoryReset.Text = "Återställ";
			this.button_workCategoryReset.UseVisualStyleBackColor = true;
			this.button_workCategoryReset.Click += new System.EventHandler(this.button_workCategoryReset_Click);
			// 
			// tabPage_Company
			// 
			this.tabPage_Company.Controls.Add(this.button_comnapnyReset);
			this.tabPage_Company.Controls.Add(this.button_SaveCompany);
			this.tabPage_Company.Controls.Add(this.dataGridView_Company);
			this.tabPage_Company.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Company.Name = "tabPage_Company";
			this.tabPage_Company.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Company.Size = new System.Drawing.Size(803, 471);
			this.tabPage_Company.TabIndex = 1;
			this.tabPage_Company.Text = "Företag";
			this.tabPage_Company.UseVisualStyleBackColor = true;
			// 
			// button_comnapnyReset
			// 
			this.button_comnapnyReset.Location = new System.Drawing.Point(142, 21);
			this.button_comnapnyReset.Name = "button_comnapnyReset";
			this.button_comnapnyReset.Size = new System.Drawing.Size(127, 23);
			this.button_comnapnyReset.TabIndex = 9;
			this.button_comnapnyReset.Text = "Återställ";
			this.button_comnapnyReset.UseVisualStyleBackColor = true;
			this.button_comnapnyReset.Click += new System.EventHandler(this.button_comnapnyReset_Click);
			// 
			// button_SaveCompany
			// 
			this.button_SaveCompany.Location = new System.Drawing.Point(9, 21);
			this.button_SaveCompany.Name = "button_SaveCompany";
			this.button_SaveCompany.Size = new System.Drawing.Size(127, 23);
			this.button_SaveCompany.TabIndex = 1;
			this.button_SaveCompany.Text = "Spara";
			this.button_SaveCompany.UseVisualStyleBackColor = true;
			this.button_SaveCompany.Click += new System.EventHandler(this.button_SaveCompany_Click);
			// 
			// dataGridView_Company
			// 
			this.dataGridView_Company.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Company.AutoGenerateColumns = false;
			this.dataGridView_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Company.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn});
			this.dataGridView_Company.DataSource = this.companyBindingSource;
			this.dataGridView_Company.Location = new System.Drawing.Point(9, 66);
			this.dataGridView_Company.Name = "dataGridView_Company";
			this.dataGridView_Company.Size = new System.Drawing.Size(786, 397);
			this.dataGridView_Company.TabIndex = 0;
			this.dataGridView_Company.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
			// 
			// companyNameDataGridViewTextBoxColumn
			// 
			this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
			this.companyNameDataGridViewTextBoxColumn.HeaderText = "Företags namn";
			this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
			// 
			// tabControl_Main
			// 
			this.tabControl_Main.Controls.Add(this.tabPage_Company);
			this.tabControl_Main.Controls.Add(this.tabPage_WorkCategory);
			this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
			this.tabControl_Main.Name = "tabControl_Main";
			this.tabControl_Main.SelectedIndex = 0;
			this.tabControl_Main.Size = new System.Drawing.Size(811, 497);
			this.tabControl_Main.TabIndex = 13;
			// 
			// companyTableAdapter
			// 
			this.companyTableAdapter.ClearBeforeFill = true;
			// 
			// categoryTableAdapter
			// 
			this.categoryTableAdapter.ClearBeforeFill = true;
			// 
			// FormAddCategry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 497);
			this.Controls.Add(this.tabControl_Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormAddCategry";
			this.Text = "Lägg till ny kategory";
			this.Load += new System.EventHandler(this.FormAddWorkCategry_Load);
			this.tabPage_WorkCategory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			this.tabPage_Company.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Company)).EndInit();
			this.tabControl_Main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

        private TimeLogDataSet timeLogDataSet;
        private System.Windows.Forms.TabPage tabPage_WorkCategory;
        private System.Windows.Forms.DataGridView dataGridView_WorkCategory;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_workCategoryReset;
        private System.Windows.Forms.TabPage tabPage_Company;
        private System.Windows.Forms.Button button_comnapnyReset;
        private System.Windows.Forms.Button button_SaveCompany;
        private System.Windows.Forms.DataGridView dataGridView_Company;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private Hackovic.TimeReport.TimeLogDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Hackovic.TimeReport.TimeLogDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn companyDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
	}
}