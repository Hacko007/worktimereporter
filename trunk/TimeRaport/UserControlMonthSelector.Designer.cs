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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMonthSelector));
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
			resources.ApplyResources(this.m_ComboBoxMonth, "m_ComboBoxMonth");
			this.m_ComboBoxMonth.DropDownHeight = 165;
			this.m_ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_ComboBoxMonth.FormattingEnabled = true;
			this.m_ComboBoxMonth.Name = "m_ComboBoxMonth";
			this.m_ComboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMonth_SelectedIndexChanged);
			// 
			// m_NumericUpDownYear
			// 
			resources.ApplyResources(this.m_NumericUpDownYear, "m_NumericUpDownYear");
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
			this.m_NumericUpDownYear.Value = new decimal(new int[] {
            2009,
            0,
            0,
            0});
			this.m_NumericUpDownYear.ValueChanged += new System.EventHandler(this.NumericUpDownYear_ValueChanged);
			// 
			// m_TableLayoutPanel
			// 
			resources.ApplyResources(this.m_TableLayoutPanel, "m_TableLayoutPanel");
			this.m_TableLayoutPanel.Controls.Add(this.m_NumericUpDownYear, 1, 0);
			this.m_TableLayoutPanel.Controls.Add(this.m_ComboBoxMonth, 0, 0);
			this.m_TableLayoutPanel.Controls.Add(this.m_ButtonOk, 2, 0);
			this.m_TableLayoutPanel.Name = "m_TableLayoutPanel";
			// 
			// m_ButtonOk
			// 
			resources.ApplyResources(this.m_ButtonOk, "m_ButtonOk");
			this.m_ButtonOk.Name = "m_ButtonOk";
			this.m_ButtonOk.UseVisualStyleBackColor = true;
			this.m_ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
			// 
			// UserControlMonthSelector
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_TableLayoutPanel);
			this.Name = "UserControlMonthSelector";
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
