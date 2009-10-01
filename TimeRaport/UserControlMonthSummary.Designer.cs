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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.m_LabelMonth = new System.Windows.Forms.Label();
			this.m_ColorPanel1 = new Hackovic.FreshUserControls.ColorPanel();
			this.m_DataGridViewMonth = new System.Windows.Forms.DataGridView();
			this.m_WorkedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_PlanedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_DiffColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_WorkTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_LabelHours = new System.Windows.Forms.Label();
			this.m_ColorPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewMonth)).BeginInit();
			this.m_TableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_LabelMonth
			// 
			this.m_LabelMonth.AutoSize = true;
			this.m_LabelMonth.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelMonth.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_LabelMonth.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.m_LabelMonth.Location = new System.Drawing.Point(3, 0);
			this.m_LabelMonth.Name = "m_LabelMonth";
			this.m_LabelMonth.Size = new System.Drawing.Size(113, 18);
			this.m_LabelMonth.TabIndex = 0;
			this.m_LabelMonth.Text = "September \'08";
			this.m_LabelMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// m_ColorPanel1
			// 
			this.m_ColorPanel1.BgColor1 = System.Drawing.SystemColors.ControlDark;
			this.m_ColorPanel1.BgColor2 = System.Drawing.SystemColors.ControlLightLight;
			this.m_ColorPanel1.Controls.Add(this.m_DataGridViewMonth);
			this.m_ColorPanel1.Controls.Add(this.m_TableLayoutPanel);
			this.m_ColorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ColorPanel1.Location = new System.Drawing.Point(0, 0);
			this.m_ColorPanel1.Name = "m_ColorPanel1";
			this.m_ColorPanel1.Size = new System.Drawing.Size(523, 131);
			this.m_ColorPanel1.TabIndex = 1;
			// 
			// m_DataGridViewMonth
			// 
			this.m_DataGridViewMonth.AllowUserToAddRows = false;
			this.m_DataGridViewMonth.AllowUserToDeleteRows = false;
			this.m_DataGridViewMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_DataGridViewMonth.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.m_DiffColumn,
            this.m_WorkTypeColumn});
			this.m_DataGridViewMonth.Location = new System.Drawing.Point(3, 29);
			this.m_DataGridViewMonth.Name = "m_DataGridViewMonth";
			this.m_DataGridViewMonth.ReadOnly = true;
			this.m_DataGridViewMonth.RowHeadersWidth = 5;
			this.m_DataGridViewMonth.Size = new System.Drawing.Size(517, 99);
			this.m_DataGridViewMonth.TabIndex = 1;
			// 
			// m_WorkedColumn
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.m_WorkedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.m_WorkedColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.m_WorkedColumn.HeaderText = "Arbetat";
			this.m_WorkedColumn.Name = "m_WorkedColumn";
			this.m_WorkedColumn.ReadOnly = true;
			// 
			// m_PlanedColumn
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "N2";
			this.m_PlanedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.m_PlanedColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.m_PlanedColumn.HeaderText = "Planerat";
			this.m_PlanedColumn.Name = "m_PlanedColumn";
			this.m_PlanedColumn.ReadOnly = true;
			// 
			// m_DiffCoulmn
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "N2";
			this.m_DiffColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.m_DiffColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.m_DiffColumn.HeaderText = "Diff";
			this.m_DiffColumn.Name = "m_DiffCoulmn";
			this.m_DiffColumn.ReadOnly = true;
			// 
			// m_WorkTypeColumn
			// 
			this.m_WorkTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.m_WorkTypeColumn.HeaderText = "Specifikation";
			this.m_WorkTypeColumn.Name = "m_WorkTypeColumn";
			this.m_WorkTypeColumn.ReadOnly = true;
			// 
			// m_TableLayoutPanel
			// 
			this.m_TableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.m_TableLayoutPanel.ColumnCount = 2;
			this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.37137F));
			this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.62862F));
			this.m_TableLayoutPanel.Controls.Add(this.m_LabelHours, 1, 0);
			this.m_TableLayoutPanel.Controls.Add(this.m_LabelMonth, 0, 0);
			this.m_TableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.m_TableLayoutPanel.Name = "m_TableLayoutPanel";
			this.m_TableLayoutPanel.RowCount = 1;
			this.m_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.m_TableLayoutPanel.Size = new System.Drawing.Size(517, 27);
			this.m_TableLayoutPanel.TabIndex = 3;
			// 
			// m_LabelHours
			// 
			this.m_LabelHours.AutoSize = true;
			this.m_LabelHours.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelHours.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_LabelHours.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_LabelHours.ForeColor = System.Drawing.SystemColors.ControlText;
			this.m_LabelHours.Location = new System.Drawing.Point(129, 0);
			this.m_LabelHours.Name = "m_LabelHours";
			this.m_LabelHours.Size = new System.Drawing.Size(385, 27);
			this.m_LabelHours.TabIndex = 2;
			this.m_LabelHours.Text = "156 timmar";
			this.m_LabelHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UserControlMonthSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_ColorPanel1);
			this.Name = "UserControlMonthSummary";
			this.Size = new System.Drawing.Size(523, 131);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn m_WorkedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_PlanedColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_WorkTypeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_DiffColumn;

	}
}
