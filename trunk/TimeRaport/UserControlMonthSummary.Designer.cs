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
			this.label_Month = new System.Windows.Forms.Label();
			this.colorPanel1 = new Hackovic.FreshUserControls.ColorPanel();
			this.dataGridView_Month = new System.Windows.Forms.DataGridView();
			this.Worked = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Planed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WorkType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label_Hours = new System.Windows.Forms.Label();
			this.colorPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Month)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Month
			// 
			this.label_Month.AutoSize = true;
			this.label_Month.BackColor = System.Drawing.Color.Transparent;
			this.label_Month.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Month.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label_Month.Location = new System.Drawing.Point(3, 0);
			this.label_Month.Name = "label_Month";
			this.label_Month.Size = new System.Drawing.Size(138, 23);
			this.label_Month.TabIndex = 0;
			this.label_Month.Text = "September \'08";
			this.label_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// colorPanel1
			// 
			this.colorPanel1.BgColor1 = System.Drawing.SystemColors.ControlDark;
			this.colorPanel1.BgColor2 = System.Drawing.SystemColors.ControlLightLight;
			this.colorPanel1.Controls.Add(this.dataGridView_Month);
			this.colorPanel1.Controls.Add(this.tableLayoutPanel1);
			this.colorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colorPanel1.Location = new System.Drawing.Point(0, 0);
			this.colorPanel1.Name = "colorPanel1";
			this.colorPanel1.Size = new System.Drawing.Size(523, 131);
			this.colorPanel1.TabIndex = 1;
			// 
			// dataGridView_Month
			// 
			this.dataGridView_Month.AllowUserToAddRows = false;
			this.dataGridView_Month.AllowUserToDeleteRows = false;
			this.dataGridView_Month.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Month.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView_Month.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Month.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Month.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Worked,
            this.Planed,
            this.Diff,
            this.WorkType});
			this.dataGridView_Month.Location = new System.Drawing.Point(3, 29);
			this.dataGridView_Month.Name = "dataGridView_Month";
			this.dataGridView_Month.ReadOnly = true;
			this.dataGridView_Month.RowHeadersWidth = 5;
			this.dataGridView_Month.Size = new System.Drawing.Size(517, 99);
			this.dataGridView_Month.TabIndex = 1;
			// 
			// Worked
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = null;
			this.Worked.DefaultCellStyle = dataGridViewCellStyle2;
			this.Worked.HeaderText = "Arbetat";
			this.Worked.Name = "Worked";
			this.Worked.ReadOnly = true;
			// 
			// Planed
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "N2";
			this.Planed.DefaultCellStyle = dataGridViewCellStyle3;
			this.Planed.HeaderText = "Planerat";
			this.Planed.Name = "Planed";
			this.Planed.ReadOnly = true;
			// 
			// Diff
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "N2";
			this.Diff.DefaultCellStyle = dataGridViewCellStyle4;
			this.Diff.HeaderText = "Diff";
			this.Diff.Name = "Diff";
			this.Diff.ReadOnly = true;
			// 
			// WorkType
			// 
			this.WorkType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.WorkType.HeaderText = "Specifikation";
			this.WorkType.Name = "WorkType";
			this.WorkType.ReadOnly = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.98066F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.01934F));
			this.tableLayoutPanel1.Controls.Add(this.label_Hours, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label_Month, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 27);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// label_Hours
			// 
			this.label_Hours.AutoSize = true;
			this.label_Hours.BackColor = System.Drawing.Color.Transparent;
			this.label_Hours.Dock = System.Windows.Forms.DockStyle.Right;
			this.label_Hours.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Hours.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label_Hours.Location = new System.Drawing.Point(426, 0);
			this.label_Hours.Name = "label_Hours";
			this.label_Hours.Size = new System.Drawing.Size(88, 27);
			this.label_Hours.TabIndex = 2;
			this.label_Hours.Text = "156 timmar";
			this.label_Hours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UserControlMonthSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.colorPanel1);
			this.Name = "UserControlMonthSummary";
			this.Size = new System.Drawing.Size(523, 131);
			this.colorPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Month)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_Month;
		private Hackovic.FreshUserControls.ColorPanel colorPanel1;
		private System.Windows.Forms.DataGridView dataGridView_Month;
		private System.Windows.Forms.Label label_Hours;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Worked;
		private System.Windows.Forms.DataGridViewTextBoxColumn Planed;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diff;
		private System.Windows.Forms.DataGridViewTextBoxColumn WorkType;

	}
}
