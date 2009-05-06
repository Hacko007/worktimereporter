namespace TimeRaport
{
	partial class FormAddWorkCategry
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
            this.timeLogDataSet = new TimeLogDataSet();
            this.tabPage_WorkCategory = new System.Windows.Forms.TabPage();
            this.button_workCategoryReset = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_WorkCategory = new System.Windows.Forms.DataGridView();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.textBox_Project = new System.Windows.Forms.TextBox();
            this.textBox_TimeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_Company = new System.Windows.Forms.TabPage();
            this.dataGridView_Company = new System.Windows.Forms.DataGridView();
            this.button_SaveCompany = new System.Windows.Forms.Button();
            this.button_comnapnyReset = new System.Windows.Forms.Button();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).BeginInit();
            this.tabPage_WorkCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkCategory)).BeginInit();
            this.tabPage_Company.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Company)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeReportDataSet
            // 
            this.timeLogDataSet.DataSetName = "TimeReportDataSet";
            this.timeLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage_WorkCategory
            // 
            this.tabPage_WorkCategory.Controls.Add(this.label3);
            this.tabPage_WorkCategory.Controls.Add(this.label2);
            this.tabPage_WorkCategory.Controls.Add(this.label1);
            this.tabPage_WorkCategory.Controls.Add(this.textBox_TimeCode);
            this.tabPage_WorkCategory.Controls.Add(this.textBox_Project);
            this.tabPage_WorkCategory.Controls.Add(this.comboBox_Company);
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
            // button_workCategoryReset
            // 
            this.button_workCategoryReset.Location = new System.Drawing.Point(343, 45);
            this.button_workCategoryReset.Name = "button_workCategoryReset";
            this.button_workCategoryReset.Size = new System.Drawing.Size(136, 23);
            this.button_workCategoryReset.TabIndex = 8;
            this.button_workCategoryReset.Text = "Återställ";
            this.button_workCategoryReset.UseVisualStyleBackColor = true;
            this.button_workCategoryReset.Click += new System.EventHandler(this.button_workCategoryReset_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(343, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(136, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Spara";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // dataGridView_WorkCategory
            // 
            this.dataGridView_WorkCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WorkCategory.Location = new System.Drawing.Point(6, 114);
            this.dataGridView_WorkCategory.Name = "dataGridView_WorkCategory";
            this.dataGridView_WorkCategory.Size = new System.Drawing.Size(674, 351);
            this.dataGridView_WorkCategory.TabIndex = 9;
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(95, 21);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(214, 21);
            this.comboBox_Company.TabIndex = 10;
            // 
            // textBox_Project
            // 
            this.textBox_Project.Location = new System.Drawing.Point(95, 47);
            this.textBox_Project.Name = "textBox_Project";
            this.textBox_Project.Size = new System.Drawing.Size(214, 20);
            this.textBox_Project.TabIndex = 11;
            // 
            // textBox_TimeCode
            // 
            this.textBox_TimeCode.Location = new System.Drawing.Point(95, 74);
            this.textBox_TimeCode.Name = "textBox_TimeCode";
            this.textBox_TimeCode.Size = new System.Drawing.Size(214, 20);
            this.textBox_TimeCode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Företag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Projekt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tidskod";
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
            // dataGridView_Company
            // 
            this.dataGridView_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Company.Location = new System.Drawing.Point(9, 22);
            this.dataGridView_Company.Name = "dataGridView_Company";
            this.dataGridView_Company.Size = new System.Drawing.Size(544, 441);
            this.dataGridView_Company.TabIndex = 0;
            // 
            // button_SaveCompany
            // 
            this.button_SaveCompany.Location = new System.Drawing.Point(560, 22);
            this.button_SaveCompany.Name = "button_SaveCompany";
            this.button_SaveCompany.Size = new System.Drawing.Size(127, 23);
            this.button_SaveCompany.TabIndex = 1;
            this.button_SaveCompany.Text = "Spara";
            this.button_SaveCompany.UseVisualStyleBackColor = true;
            this.button_SaveCompany.Click += new System.EventHandler(this.button_SaveCompany_Click);
            // 
            // button_comnapnyReset
            // 
            this.button_comnapnyReset.Location = new System.Drawing.Point(560, 51);
            this.button_comnapnyReset.Name = "button_comnapnyReset";
            this.button_comnapnyReset.Size = new System.Drawing.Size(127, 23);
            this.button_comnapnyReset.TabIndex = 9;
            this.button_comnapnyReset.Text = "Återställ";
            this.button_comnapnyReset.UseVisualStyleBackColor = true;
            this.button_comnapnyReset.Click += new System.EventHandler(this.button_comnapnyReset_Click);
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
            // FormAddWorkCategry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 497);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "FormAddWorkCategry";
            this.Text = "FormAddWorkCategry";
            this.Load += new System.EventHandler(this.FormAddWorkCategry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).EndInit();
            this.tabPage_WorkCategory.ResumeLayout(false);
            this.tabPage_WorkCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorkCategory)).EndInit();
            this.tabPage_Company.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Company)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private TimeLogDataSet timeLogDataSet;
        private System.Windows.Forms.TabPage tabPage_WorkCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TimeCode;
        private System.Windows.Forms.TextBox textBox_Project;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.DataGridView dataGridView_WorkCategory;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_workCategoryReset;
        private System.Windows.Forms.TabPage tabPage_Company;
        private System.Windows.Forms.Button button_comnapnyReset;
        private System.Windows.Forms.Button button_SaveCompany;
        private System.Windows.Forms.DataGridView dataGridView_Company;
        private System.Windows.Forms.TabControl tabControl_Main;
	}
}