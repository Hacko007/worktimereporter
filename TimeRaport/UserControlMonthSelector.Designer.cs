namespace Hackovic.TimeReport
{
	partial class UserControlMonthSelector
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
			this.m_ComboBoxMonth = new System.Windows.Forms.ComboBox();
			this.m_NumericUpDownYear = new System.Windows.Forms.NumericUpDown();
			this.m_TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.m_ButtonOk = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownYear)).BeginInit();
			this.m_TableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_ComboBoxMonth
			// 
			this.m_ComboBoxMonth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ComboBoxMonth.DropDownHeight = 165;
			this.m_ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_ComboBoxMonth.FormattingEnabled = true;
			this.m_ComboBoxMonth.IntegralHeight = false;
			this.m_ComboBoxMonth.ItemHeight = 13;
			this.m_ComboBoxMonth.Location = new System.Drawing.Point(0, 0);
			this.m_ComboBoxMonth.Margin = new System.Windows.Forms.Padding(0);
			this.m_ComboBoxMonth.Name = "m_ComboBoxMonth";
			this.m_ComboBoxMonth.Size = new System.Drawing.Size(126, 21);
			this.m_ComboBoxMonth.TabIndex = 0;
			this.m_ComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMonth_SelectedIndexChanged);
			// 
			// m_NumericUpDownYear
			// 
			this.m_NumericUpDownYear.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_NumericUpDownYear.Location = new System.Drawing.Point(128, 0);
			this.m_NumericUpDownYear.Margin = new System.Windows.Forms.Padding(2, 0, 1, 0);
			this.m_NumericUpDownYear.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
			this.m_NumericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			this.m_NumericUpDownYear.Name = "m_NumericUpDownYear";
			this.m_NumericUpDownYear.Size = new System.Drawing.Size(48, 20);
			this.m_NumericUpDownYear.TabIndex = 1;
			this.m_NumericUpDownYear.Value = new decimal(new int[] {
            2009,
            0,
            0,
            0});
			this.m_NumericUpDownYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// m_TableLayoutPanel
			// 
			this.m_TableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.m_TableLayoutPanel.ColumnCount = 3;
			this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
			this.m_TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.m_TableLayoutPanel.Controls.Add(this.m_NumericUpDownYear, 1, 0);
			this.m_TableLayoutPanel.Controls.Add(this.m_ComboBoxMonth, 0, 0);
			this.m_TableLayoutPanel.Controls.Add(this.m_ButtonOk, 2, 0);
			this.m_TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.m_TableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.m_TableLayoutPanel.Name = "m_TableLayoutPanel";
			this.m_TableLayoutPanel.RowCount = 1;
			this.m_TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.m_TableLayoutPanel.Size = new System.Drawing.Size(213, 21);
			this.m_TableLayoutPanel.TabIndex = 2;
			// 
			// m_ButtonOk
			// 
			this.m_ButtonOk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_ButtonOk.Location = new System.Drawing.Point(177, 0);
			this.m_ButtonOk.Margin = new System.Windows.Forms.Padding(0);
			this.m_ButtonOk.Name = "m_ButtonOk";
			this.m_ButtonOk.Size = new System.Drawing.Size(36, 21);
			this.m_ButtonOk.TabIndex = 2;
			this.m_ButtonOk.Text = "Ok";
			this.m_ButtonOk.UseVisualStyleBackColor = true;
			this.m_ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// UserControlMonthSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_TableLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "UserControlMonthSelector";
			this.Size = new System.Drawing.Size(213, 21);
			this.Load += new System.EventHandler(this.UserControlMonthSelector_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownYear)).EndInit();
			this.m_TableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox m_ComboBoxMonth;
		private System.Windows.Forms.NumericUpDown m_NumericUpDownYear;
		private System.Windows.Forms.TableLayoutPanel m_TableLayoutPanel;
		private System.Windows.Forms.Button m_ButtonOk;
	}
}
