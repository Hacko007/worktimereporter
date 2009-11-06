namespace Hackovic.TimeReport
{
	partial class UserControlMonthSummary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMonthSummary));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.m_LabelMonth = new System.Windows.Forms.Label();
			this.m_ColorPanel1 = new Hackovic.FreshUserControls.ColorPanel();
			this.m_DataGridViewMonth = new System.Windows.Forms.DataGridView();
			this.m_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_LabelHours = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_WorkedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_PlanedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_DiffCoulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_WorkTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColorPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewMonth)).BeginInit();
			this.m_TableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_LabelMonth
			// 
			this.m_LabelMonth.AccessibleDescription = null;
			this.m_LabelMonth.AccessibleName = null;
			resources.ApplyResources(this.m_LabelMonth, "m_LabelMonth");
			this.m_LabelMonth.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelMonth.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.m_LabelMonth.Name = "m_LabelMonth";
			// 
			// m_ColorPanel1
			// 
			this.m_ColorPanel1.AccessibleDescription = null;
			this.m_ColorPanel1.AccessibleName = null;
			resources.ApplyResources(this.m_ColorPanel1, "m_ColorPanel1");
			this.m_ColorPanel1.BackgroundImage = null;
			this.m_ColorPanel1.BgColor1 = System.Drawing.SystemColors.ControlDark;
			this.m_ColorPanel1.BgColor2 = System.Drawing.SystemColors.ControlLightLight;
			this.m_ColorPanel1.Controls.Add(this.m_DataGridViewMonth);
			this.m_ColorPanel1.Controls.Add(this.m_TableLayoutPanel);
			this.m_ColorPanel1.Font = null;
			this.m_ColorPanel1.Name = "m_ColorPanel1";
			// 
			// m_DataGridViewMonth
			// 
			this.m_DataGridViewMonth.AccessibleDescription = null;
			this.m_DataGridViewMonth.AccessibleName = null;
			this.m_DataGridViewMonth.AllowUserToAddRows = false;
			this.m_DataGridViewMonth.AllowUserToDeleteRows = false;
			resources.ApplyResources(this.m_DataGridViewMonth, "m_DataGridViewMonth");
			this.m_DataGridViewMonth.BackgroundColor = System.Drawing.SystemColors.Control;
			this.m_DataGridViewMonth.BackgroundImage = null;
			this.m_DataGridViewMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.m_DataGridViewMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.m_DataGridViewMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_DataGridViewMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_WorkedColumn,
            this.m_PlanedColumn,
            this.m_DiffCoulmn,
            this.m_WorkTypeColumn});
			this.m_DataGridViewMonth.Font = null;
			this.m_DataGridViewMonth.Name = "m_DataGridViewMonth";
			this.m_DataGridViewMonth.ReadOnly = true;
			// 
			// m_TableLayoutPanel
			// 
			this.m_TableLayoutPanel.AccessibleDescription = null;
			this.m_TableLayoutPanel.AccessibleName = null;
			resources.ApplyResources(this.m_TableLayoutPanel, "m_TableLayoutPanel");
			this.m_TableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.m_TableLayoutPanel.BackgroundImage = null;
			this.m_TableLayoutPanel.Controls.Add(this.m_LabelHours, 1, 0);
			this.m_TableLayoutPanel.Controls.Add(this.m_LabelMonth, 0, 0);
			this.m_TableLayoutPanel.Font = null;
			this.m_TableLayoutPanel.Name = "m_TableLayoutPanel";
			// 
			// m_LabelHours
			// 
			this.m_LabelHours.AccessibleDescription = null;
			this.m_LabelHours.AccessibleName = null;
			resources.ApplyResources(this.m_LabelHours, "m_LabelHours");
			this.m_LabelHours.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelHours.ForeColor = System.Drawing.SystemColors.ControlText;
			this.m_LabelHours.Name = "m_LabelHours";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = null;
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
			resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.Format = "N2";
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
			resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.Format = "N2";
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
			resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// m_WorkedColumn
			// 
			this.m_WorkedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.m_WorkedColumn.DefaultCellStyle = dataGridViewCellStyle2;
			resources.ApplyResources(this.m_WorkedColumn, "m_WorkedColumn");
			this.m_WorkedColumn.Name = "m_WorkedColumn";
			this.m_WorkedColumn.ReadOnly = true;
			// 
			// m_PlanedColumn
			// 
			this.m_PlanedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "N2";
			this.m_PlanedColumn.DefaultCellStyle = dataGridViewCellStyle3;
			resources.ApplyResources(this.m_PlanedColumn, "m_PlanedColumn");
			this.m_PlanedColumn.Name = "m_PlanedColumn";
			this.m_PlanedColumn.ReadOnly = true;
			// 
			// m_DiffCoulmn
			// 
			this.m_DiffCoulmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "N2";
			this.m_DiffCoulmn.DefaultCellStyle = dataGridViewCellStyle4;
			resources.ApplyResources(this.m_DiffCoulmn, "m_DiffCoulmn");
			this.m_DiffCoulmn.Name = "m_DiffCoulmn";
			this.m_DiffCoulmn.ReadOnly = true;
			// 
			// m_WorkTypeColumn
			// 
			this.m_WorkTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			resources.ApplyResources(this.m_WorkTypeColumn, "m_WorkTypeColumn");
			this.m_WorkTypeColumn.Name = "m_WorkTypeColumn";
			this.m_WorkTypeColumn.ReadOnly = true;
			// 
			// UserControlMonthSummary
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.m_ColorPanel1);
			this.Font = null;
			this.Name = "UserControlMonthSummary";
			this.m_ColorPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewMonth)).EndInit();
			this.m_TableLayoutPanel.ResumeLayout(false);
			this.m_TableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label m_LabelMonth;
		private Hackovic.FreshUserControls.ColorPanel m_ColorPanel1;
		private System.Windows.Forms.DataGridView m_DataGridViewMonth;
		private System.Windows.Forms.Label m_LabelHours;
		private System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;
		//private System.Windows.Forms.DataGridViewTextBoxColumn m_DiffColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_WorkedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_PlanedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_DiffCoulmn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_WorkTypeColumn;

	}
}
