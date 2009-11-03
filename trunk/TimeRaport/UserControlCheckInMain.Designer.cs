namespace Hackovic.TimeReport
{
    using Hackovic.FreshUserControls;

	partial class UserControlCheckInMain
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label2 = new System.Windows.Forms.Label();
			this.button_out = new Hackovic.FreshUserControls.ColorButton();
			this.button_in = new Hackovic.FreshUserControls.ColorButton();
			this.My_Button_AddCategory = new Hackovic.FreshUserControls.ColorButton();
			this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_DeleteSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeLogDataSet = new Hackovic.TimeReport.TimeLogDataSet();
			this.digitalClock_Now = new Hackovic.FreshUserControls.DigitalClock();
			this.dataGridView_week = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.plannedHoursDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.weekTimeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView_month = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.plannedHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dayTimeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel_dataGrids = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.m_dataGridViewToday = new Hackovic.TimeReport.DataGridViewToday();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.m_userControlMonthSummary = new Hackovic.TimeReport.UserControlMonthSummary();
			this.ListBox_WorkCaegory = new System.Windows.Forms.ListBox();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.timeLogTableAdapter = new Hackovic.TimeReport.TimeLogDataSetTableAdapters.TimeLogTableAdapter();
			this.categoryTableAdapter = new Hackovic.TimeReport.TimeLogDataSetTableAdapters.CategoryTableAdapter();
			this.colorPanel1 = new Hackovic.FreshUserControls.ColorPanel();
			this.m_LabelTimeToFinishToday = new System.Windows.Forms.Label();
			this.m_NumericUpDownToWork = new System.Windows.Forms.NumericUpDown();
			this.m_NumericUpDownMinute = new System.Windows.Forms.NumericUpDown();
			this.m_NumericUpDownHour = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_MonthCalendar = new System.Windows.Forms.MonthCalendar();
			this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.m_ContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_week)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.weekTimeLogBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_month)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dayTimeLogBindingSource)).BeginInit();
			this.panel_dataGrids.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			this.colorPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownToWork)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownHour)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(356, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Att jobba idag";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// button_out
			// 
			this.button_out.BgColor1 = System.Drawing.SystemColors.Control;
			this.button_out.BgColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.button_out.FgColor1 = System.Drawing.SystemColors.ActiveCaptionText;
			this.button_out.FgColor2 = System.Drawing.SystemColors.ControlText;
			this.button_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_out.Font = new System.Drawing.Font("Arial Black", 24F);
			this.button_out.ForeColor = System.Drawing.Color.White;
			this.button_out.Location = new System.Drawing.Point(253, 329);
			this.button_out.Name = "button_out";
			this.button_out.Size = new System.Drawing.Size(191, 51);
			this.button_out.TabIndex = 13;
			this.button_out.Text = "Ut";
			this.button_out.TextHasShadow = true;
			this.button_out.TextShadowColor = System.Drawing.Color.Black;
			this.button_out.Click += new System.EventHandler(this.Button_out_Click);
			// 
			// button_in
			// 
			this.button_in.BgColor1 = System.Drawing.SystemColors.Control;
			this.button_in.BgColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.button_in.FgColor1 = System.Drawing.SystemColors.ActiveCaptionText;
			this.button_in.FgColor2 = System.Drawing.SystemColors.ControlText;
			this.button_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_in.Font = new System.Drawing.Font("Arial Black", 24F);
			this.button_in.ForeColor = System.Drawing.Color.White;
			this.button_in.Location = new System.Drawing.Point(23, 329);
			this.button_in.Name = "button_in";
			this.button_in.Size = new System.Drawing.Size(202, 51);
			this.button_in.TabIndex = 12;
			this.button_in.Text = "In";
			this.button_in.TextHasShadow = true;
			this.button_in.TextShadowColor = System.Drawing.Color.Black;
			this.button_in.Click += new System.EventHandler(this.Button_in_Click);
			// 
			// My_Button_AddCategory
			// 
			this.My_Button_AddCategory.BgColor1 = System.Drawing.SystemColors.Control;
			this.My_Button_AddCategory.BgColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.My_Button_AddCategory.FgColor1 = System.Drawing.Color.White;
			this.My_Button_AddCategory.FgColor2 = System.Drawing.Color.LightGray;
			this.My_Button_AddCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.My_Button_AddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.My_Button_AddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
			this.My_Button_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.My_Button_AddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.My_Button_AddCategory.ForeColor = System.Drawing.Color.White;
			this.My_Button_AddCategory.Location = new System.Drawing.Point(339, 219);
			this.My_Button_AddCategory.Name = "My_Button_AddCategory";
			this.My_Button_AddCategory.Size = new System.Drawing.Size(105, 21);
			this.My_Button_AddCategory.TabIndex = 10;
			this.My_Button_AddCategory.Text = "+";
			this.My_Button_AddCategory.TextHasShadow = false;
			this.My_Button_AddCategory.TextShadowColor = System.Drawing.Color.Empty;
			this.m_ToolTip.SetToolTip(this.My_Button_AddCategory, "Ändra kategory");
			this.My_Button_AddCategory.UseVisualStyleBackColor = false;
			this.My_Button_AddCategory.Click += new System.EventHandler(this.Button_AddCategory_Click);
			// 
			// m_ContextMenuStrip
			// 
			this.m_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_DeleteSelectedRowToolStripMenuItem});
			this.m_ContextMenuStrip.Name = "m_ContextMenuStrip";
			this.m_ContextMenuStrip.Size = new System.Drawing.Size(163, 26);
			this.m_ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.m_ContextMenuStrip_Opening);
			// 
			// m_DeleteSelectedRowToolStripMenuItem
			// 
			this.m_DeleteSelectedRowToolStripMenuItem.Name = "m_DeleteSelectedRowToolStripMenuItem";
			this.m_DeleteSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.m_DeleteSelectedRowToolStripMenuItem.Text = "Radera vald rad";
			this.m_DeleteSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.m_DeleteSelectedRowToolStripMenuItem_Click);
			// 
			// timeLogBindingSource
			// 
			this.timeLogBindingSource.DataMember = "TimeLog";
			this.timeLogBindingSource.DataSource = this.timeLogDataSet;
			// 
			// timeLogDataSet
			// 
			this.timeLogDataSet.DataSetName = "TimeLogDataSet";
			this.timeLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// digitalClock_Now
			// 
			this.digitalClock_Now.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.digitalClock_Now.BackColor2 = System.Drawing.SystemColors.Desktop;
			this.digitalClock_Now.ClockStyle = Hackovic.FreshUserControls.DigitalClockStyle.FullClock;
			this.digitalClock_Now.DateTimeFormat = "yyy-MM-dd       HH:mm:ss";
			this.digitalClock_Now.ForeColor = System.Drawing.SystemColors.ControlText;
			this.digitalClock_Now.ForeColor2 = System.Drawing.SystemColors.InactiveCaptionText;
			this.digitalClock_Now.FramePrecent = 0;
			this.digitalClock_Now.Location = new System.Drawing.Point(0, 0);
			this.digitalClock_Now.Name = "digitalClock_Now";
			this.digitalClock_Now.Size = new System.Drawing.Size(462, 41);
			this.digitalClock_Now.TabIndex = 0;
			this.digitalClock_Now.Text = "digitalClock1";
			this.digitalClock_Now.Click += new System.EventHandler(this.DigitalClock_Now_Click);
			// 
			// dataGridView_week
			// 
			this.dataGridView_week.AllowUserToAddRows = false;
			this.dataGridView_week.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_week.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_week.AutoGenerateColumns = false;
			this.dataGridView_week.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dataGridView_week.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_week.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.dataGridView_week.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.plannedHoursDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn10,
            this.categoryIdDataGridViewTextBoxColumn2,
            this.categoryDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn});
			this.dataGridView_week.DataSource = this.weekTimeLogBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_week.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView_week.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_week.GridColor = System.Drawing.Color.DarkGray;
			this.dataGridView_week.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_week.Name = "dataGridView_week";
			this.dataGridView_week.ReadOnly = true;
			this.dataGridView_week.RowHeadersWidth = 20;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_week.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView_week.Size = new System.Drawing.Size(710, 171);
			this.dataGridView_week.TabIndex = 0;
			this.dataGridView_week.SelectionChanged += new System.EventHandler(this.DataGridViewWeek_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "WeekNr";
			this.dataGridViewTextBoxColumn8.HeaderText = "Week Nr";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Hours";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn9.HeaderText = "Hours";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// plannedHoursDataGridViewTextBoxColumn1
			// 
			this.plannedHoursDataGridViewTextBoxColumn1.DataPropertyName = "PlannedHours";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.plannedHoursDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
			this.plannedHoursDataGridViewTextBoxColumn1.HeaderText = "Planned";
			this.plannedHoursDataGridViewTextBoxColumn1.Name = "plannedHoursDataGridViewTextBoxColumn1";
			this.plannedHoursDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Diff";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn10.HeaderText = "Diff";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// categoryIdDataGridViewTextBoxColumn2
			// 
			this.categoryIdDataGridViewTextBoxColumn2.DataPropertyName = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn2.HeaderText = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn2.Name = "categoryIdDataGridViewTextBoxColumn2";
			this.categoryIdDataGridViewTextBoxColumn2.ReadOnly = true;
			this.categoryIdDataGridViewTextBoxColumn2.Visible = false;
			// 
			// categoryDataGridViewTextBoxColumn1
			// 
			this.categoryDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
			this.categoryDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// yearDataGridViewTextBoxColumn
			// 
			this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
			this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
			this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
			this.yearDataGridViewTextBoxColumn.ReadOnly = true;
			this.yearDataGridViewTextBoxColumn.Visible = false;
			// 
			// weekTimeLogBindingSource
			// 
			this.weekTimeLogBindingSource.DataMember = "WeekTimeLog";
			this.weekTimeLogBindingSource.DataSource = this.timeLogDataSet;
			// 
			// dataGridView_month
			// 
			this.dataGridView_month.AllowUserToAddRows = false;
			this.dataGridView_month.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_month.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView_month.AutoGenerateColumns = false;
			this.dataGridView_month.BackgroundColor = System.Drawing.Color.DarkGray;
			this.dataGridView_month.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_month.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			this.dataGridView_month.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.plannedHoursDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.categoryIdDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn,
            this.Info});
			this.dataGridView_month.DataSource = this.dayTimeLogBindingSource;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_month.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView_month.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_month.GridColor = System.Drawing.Color.DarkGray;
			this.dataGridView_month.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_month.Name = "dataGridView_month";
			this.dataGridView_month.ReadOnly = true;
			this.dataGridView_month.RowHeadersWidth = 20;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_month.RowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridView_month.Size = new System.Drawing.Size(710, 247);
			this.dataGridView_month.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Day";
			dataGridViewCellStyle8.Format = "dd  dddd ";
			dataGridViewCellStyle8.NullValue = null;
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTextBoxColumn5.HeaderText = "Day";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Hours";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.Format = "N2";
			dataGridViewCellStyle9.NullValue = "0";
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn6.HeaderText = "Hours";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// plannedHoursDataGridViewTextBoxColumn
			// 
			this.plannedHoursDataGridViewTextBoxColumn.DataPropertyName = "PlannedHours";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "N2";
			dataGridViewCellStyle10.NullValue = "0";
			this.plannedHoursDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
			this.plannedHoursDataGridViewTextBoxColumn.HeaderText = "PlannedHours";
			this.plannedHoursDataGridViewTextBoxColumn.Name = "plannedHoursDataGridViewTextBoxColumn";
			this.plannedHoursDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Diff";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle11.Format = "N2";
			dataGridViewCellStyle11.NullValue = "0";
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridViewTextBoxColumn7.HeaderText = "Diff";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// categoryIdDataGridViewTextBoxColumn1
			// 
			this.categoryIdDataGridViewTextBoxColumn1.DataPropertyName = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn1.HeaderText = "CategoryId";
			this.categoryIdDataGridViewTextBoxColumn1.Name = "categoryIdDataGridViewTextBoxColumn1";
			this.categoryIdDataGridViewTextBoxColumn1.ReadOnly = true;
			this.categoryIdDataGridViewTextBoxColumn1.Visible = false;
			// 
			// categoryDataGridViewTextBoxColumn
			// 
			this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
			this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
			this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
			this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Info
			// 
			this.Info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Info.DataPropertyName = "Info";
			this.Info.HeaderText = "Info";
			this.Info.Name = "Info";
			this.Info.ReadOnly = true;
			// 
			// dayTimeLogBindingSource
			// 
			this.dayTimeLogBindingSource.DataMember = "DayTimeLog";
			this.dayTimeLogBindingSource.DataSource = this.timeLogDataSet;
			// 
			// panel_dataGrids
			// 
			this.panel_dataGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panel_dataGrids.Controls.Add(this.splitContainer1);
			this.panel_dataGrids.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.panel_dataGrids.Location = new System.Drawing.Point(459, 0);
			this.panel_dataGrids.Name = "panel_dataGrids";
			this.panel_dataGrids.Size = new System.Drawing.Size(714, 623);
			this.panel_dataGrids.TabIndex = 22;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.m_dataGridViewToday);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(714, 623);
			this.splitContainer1.SplitterDistance = 189;
			this.splitContainer1.TabIndex = 0;
			// 
			// m_dataGridViewToday
			// 
			this.m_dataGridViewToday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_dataGridViewToday.Location = new System.Drawing.Point(0, 0);
			this.m_dataGridViewToday.Name = "m_dataGridViewToday";
			this.m_dataGridViewToday.Size = new System.Drawing.Size(710, 185);
			this.m_dataGridViewToday.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dataGridView_week);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.dataGridView_month);
			this.splitContainer2.Size = new System.Drawing.Size(714, 430);
			this.splitContainer2.SplitterDistance = 175;
			this.splitContainer2.TabIndex = 0;
			// 
			// m_userControlMonthSummary
			// 
			this.m_userControlMonthSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_userControlMonthSummary.BackColor = System.Drawing.Color.Silver;
			this.m_userControlMonthSummary.Location = new System.Drawing.Point(0, 401);
			this.m_userControlMonthSummary.Month = new System.DateTime(((long)(0)));
			this.m_userControlMonthSummary.Name = "m_userControlMonthSummary";
			this.m_userControlMonthSummary.Size = new System.Drawing.Size(462, 222);
			this.m_userControlMonthSummary.TabIndex = 14;
			// 
			// ListBox_WorkCaegory
			// 
			this.ListBox_WorkCaegory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ListBox_WorkCaegory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListBox_WorkCaegory.DataSource = this.categoryBindingSource;
			this.ListBox_WorkCaegory.DisplayMember = "DisplayValue";
			this.ListBox_WorkCaegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListBox_WorkCaegory.ForeColor = System.Drawing.Color.White;
			this.ListBox_WorkCaegory.FormattingEnabled = true;
			this.ListBox_WorkCaegory.Location = new System.Drawing.Point(8, 243);
			this.ListBox_WorkCaegory.Name = "ListBox_WorkCaegory";
			this.ListBox_WorkCaegory.Size = new System.Drawing.Size(445, 80);
			this.ListBox_WorkCaegory.TabIndex = 11;
			this.ListBox_WorkCaegory.SelectedValueChanged += new System.EventHandler(this.ListBox_Category_SelectedValueChanged);
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataMember = "Category";
			this.categoryBindingSource.DataSource = this.timeLogDataSet;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Honeydew;
			this.label1.Location = new System.Drawing.Point(6, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 26);
			this.label1.TabIndex = 9;
			this.label1.Text = "Välj kategory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// timeLogTableAdapter
			// 
			this.timeLogTableAdapter.ClearBeforeFill = true;
			// 
			// categoryTableAdapter
			// 
			this.categoryTableAdapter.ClearBeforeFill = true;
			// 
			// colorPanel1
			// 
			this.colorPanel1.AutoScroll = true;
			this.colorPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.colorPanel1.BgColor1 = System.Drawing.SystemColors.ControlLight;
			this.colorPanel1.BgColor2 = System.Drawing.SystemColors.ControlDarkDark;
			this.colorPanel1.Controls.Add(this.m_userControlMonthSummary);
			this.colorPanel1.Controls.Add(this.m_LabelTimeToFinishToday);
			this.colorPanel1.Controls.Add(this.digitalClock_Now);
			this.colorPanel1.Controls.Add(this.m_NumericUpDownToWork);
			this.colorPanel1.Controls.Add(this.m_NumericUpDownMinute);
			this.colorPanel1.Controls.Add(this.m_NumericUpDownHour);
			this.colorPanel1.Controls.Add(this.label4);
			this.colorPanel1.Controls.Add(this.label3);
			this.colorPanel1.Controls.Add(this.m_MonthCalendar);
			this.colorPanel1.Controls.Add(this.button_in);
			this.colorPanel1.Controls.Add(this.button_out);
			this.colorPanel1.Controls.Add(this.label1);
			this.colorPanel1.Controls.Add(this.ListBox_WorkCaegory);
			this.colorPanel1.Controls.Add(this.label2);
			this.colorPanel1.Controls.Add(this.My_Button_AddCategory);
			this.colorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colorPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.colorPanel1.Location = new System.Drawing.Point(0, 0);
			this.colorPanel1.Name = "colorPanel1";
			this.colorPanel1.Size = new System.Drawing.Size(1173, 623);
			this.colorPanel1.TabIndex = 0;
			// 
			// m_LabelTimeToFinishToday
			// 
			this.m_LabelTimeToFinishToday.AutoSize = true;
			this.m_LabelTimeToFinishToday.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelTimeToFinishToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_LabelTimeToFinishToday.ForeColor = System.Drawing.SystemColors.ControlText;
			this.m_LabelTimeToFinishToday.Location = new System.Drawing.Point(278, 145);
			this.m_LabelTimeToFinishToday.Name = "m_LabelTimeToFinishToday";
			this.m_LabelTimeToFinishToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.m_LabelTimeToFinishToday.Size = new System.Drawing.Size(71, 16);
			this.m_LabelTimeToFinishToday.TabIndex = 6;
			this.m_LabelTimeToFinishToday.Text = "Klar : 18.00";
			this.m_LabelTimeToFinishToday.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// m_NumericUpDownToWork
			// 
			this.m_NumericUpDownToWork.BackColor = System.Drawing.SystemColors.Control;
			this.m_NumericUpDownToWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.m_NumericUpDownToWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_NumericUpDownToWork.ForeColor = System.Drawing.SystemColors.ControlText;
			this.m_NumericUpDownToWork.Location = new System.Drawing.Point(392, 89);
			this.m_NumericUpDownToWork.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.m_NumericUpDownToWork.Name = "m_NumericUpDownToWork";
			this.m_NumericUpDownToWork.Size = new System.Drawing.Size(52, 44);
			this.m_NumericUpDownToWork.TabIndex = 8;
			this.m_NumericUpDownToWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.m_NumericUpDownToWork.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.m_NumericUpDownToWork.ValueChanged += new System.EventHandler(this.NumericUpDownToWork_ValueChanged);
			// 
			// m_NumericUpDownMinute
			// 
			this.m_NumericUpDownMinute.BackColor = System.Drawing.SystemColors.Control;
			this.m_NumericUpDownMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.m_NumericUpDownMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_NumericUpDownMinute.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.m_NumericUpDownMinute.Location = new System.Drawing.Point(285, 89);
			this.m_NumericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.m_NumericUpDownMinute.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.m_NumericUpDownMinute.Name = "m_NumericUpDownMinute";
			this.m_NumericUpDownMinute.Size = new System.Drawing.Size(61, 44);
			this.m_NumericUpDownMinute.TabIndex = 5;
			this.m_NumericUpDownMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.m_NumericUpDownMinute.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
			this.m_NumericUpDownMinute.ValueChanged += new System.EventHandler(this.m_NumericUpDownMinute_ValueChanged);
			// 
			// m_NumericUpDownHour
			// 
			this.m_NumericUpDownHour.BackColor = System.Drawing.SystemColors.Control;
			this.m_NumericUpDownHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.m_NumericUpDownHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_NumericUpDownHour.Location = new System.Drawing.Point(217, 89);
			this.m_NumericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
			this.m_NumericUpDownHour.Name = "m_NumericUpDownHour";
			this.m_NumericUpDownHour.Size = new System.Drawing.Size(59, 44);
			this.m_NumericUpDownHour.TabIndex = 3;
			this.m_NumericUpDownHour.Tag = "";
			this.m_NumericUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.m_NumericUpDownHour.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(304, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Minuter";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(235, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Timmar";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// m_MonthCalendar
			// 
			this.m_MonthCalendar.Location = new System.Drawing.Point(8, 61);
			this.m_MonthCalendar.Name = "m_MonthCalendar";
			this.m_MonthCalendar.ShowWeekNumbers = true;
			this.m_MonthCalendar.TabIndex = 1;
			this.m_MonthCalendar.TitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.m_MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
			// 
			// UserControlCheckInMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.Controls.Add(this.panel_dataGrids);
			this.Controls.Add(this.colorPanel1);
			this.DoubleBuffered = true;
			this.Name = "UserControlCheckInMain";
			this.Size = new System.Drawing.Size(1173, 623);
			this.m_ContextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_week)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.weekTimeLogBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_month)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dayTimeLogBindingSource)).EndInit();
			this.panel_dataGrids.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			this.colorPanel1.ResumeLayout(false);
			this.colorPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownToWork)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownHour)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label2;
        private ColorButton button_out;
        private ColorButton button_in;
        private ColorButton My_Button_AddCategory;		
		private DigitalClock digitalClock_Now;
		private System.Windows.Forms.DataGridView dataGridView_week;
        private System.Windows.Forms.DataGridView dataGridView_month;
        private System.Windows.Forms.Panel panel_dataGrids;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox ListBox_WorkCaegory;
        private System.Windows.Forms.Label label1;
        private TimeLogDataSet timeLogDataSet;
        private System.Windows.Forms.BindingSource timeLogBindingSource;
        private Hackovic.TimeReport.TimeLogDataSetTableAdapters.TimeLogTableAdapter timeLogTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Hackovic.TimeReport.TimeLogDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
		private ColorPanel colorPanel1;
		private System.Windows.Forms.BindingSource dayTimeLogBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn plannedHoursDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource weekTimeLogBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn plannedHoursDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Info;
		private System.Windows.Forms.NumericUpDown m_NumericUpDownMinute;
		private System.Windows.Forms.NumericUpDown m_NumericUpDownHour;
		private System.Windows.Forms.MonthCalendar m_MonthCalendar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown m_NumericUpDownToWork;
		private System.Windows.Forms.ToolTip m_ToolTip;
		private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem m_DeleteSelectedRowToolStripMenuItem;
		private FormAddCategory m_FormAddCategory;
		private TimeLogDataSet dsTimeReport ;
		private System.Windows.Forms.Label m_LabelTimeToFinishToday;
		private DataGridViewToday m_dataGridViewToday;
			

		private UserControlMonthSummary m_userControlMonthSummary;
	}
}
