namespace TimeReportMobile
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu m_mainMenu;

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
			this.m_mainMenu = new System.Windows.Forms.MainMenu();
			this.m_tabControl = new System.Windows.Forms.TabControl();
			this.m_tabPageCheckin = new System.Windows.Forms.TabPage();
			this.m_tabPageReport = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.m_buttonOut = new System.Windows.Forms.Button();
			this.m_buttonIn = new System.Windows.Forms.Button();
			this.m_numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
			this.m_numericUpDownHour = new System.Windows.Forms.NumericUpDown();
			this.m_dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.m_textBox = new System.Windows.Forms.TextBox();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.m_tabControl.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_mainMenu
			// 
			this.m_mainMenu.MenuItems.Add(this.menuItem1);
			this.m_mainMenu.MenuItems.Add(this.menuItem2);
			// 
			// m_tabControl
			// 
			this.m_tabControl.Controls.Add(this.m_tabPageCheckin);
			this.m_tabControl.Controls.Add(this.m_tabPageReport);
			this.m_tabControl.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
			this.m_tabControl.Location = new System.Drawing.Point(0, 0);
			this.m_tabControl.Name = "m_tabControl";
			this.m_tabControl.SelectedIndex = 0;
			this.m_tabControl.Size = new System.Drawing.Size(480, 100);
			this.m_tabControl.TabIndex = 0;
			// 
			// m_tabPageCheckin
			// 
			this.m_tabPageCheckin.Location = new System.Drawing.Point(0, 0);
			this.m_tabPageCheckin.Name = "m_tabPageCheckin";
			this.m_tabPageCheckin.Size = new System.Drawing.Size(480, 36);
			this.m_tabPageCheckin.Text = "Check in";
			// 
			// m_tabPageReport
			// 
			this.m_tabPageReport.Location = new System.Drawing.Point(0, 0);
			this.m_tabPageReport.Name = "m_tabPageReport";
			this.m_tabPageReport.Size = new System.Drawing.Size(472, 42);
			this.m_tabPageReport.Text = "Report";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.m_textBox);
			this.panel1.Controls.Add(this.m_buttonOut);
			this.panel1.Controls.Add(this.m_buttonIn);
			this.panel1.Controls.Add(this.m_numericUpDownMinute);
			this.panel1.Controls.Add(this.m_numericUpDownHour);
			this.panel1.Controls.Add(this.m_dateTimePickerDate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 436);
			// 
			// m_buttonOut
			// 
			this.m_buttonOut.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
			this.m_buttonOut.Location = new System.Drawing.Point(259, 253);
			this.m_buttonOut.Name = "m_buttonOut";
			this.m_buttonOut.Size = new System.Drawing.Size(207, 166);
			this.m_buttonOut.TabIndex = 4;
			this.m_buttonOut.Text = "Out";
			// 
			// m_buttonIn
			// 
			this.m_buttonIn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
			this.m_buttonIn.Location = new System.Drawing.Point(16, 253);
			this.m_buttonIn.Name = "m_buttonIn";
			this.m_buttonIn.Size = new System.Drawing.Size(208, 166);
			this.m_buttonIn.TabIndex = 3;
			this.m_buttonIn.Text = "In";
			this.m_buttonIn.Click += new System.EventHandler(this.ButtonIn_Click);
			// 
			// m_numericUpDownMinute
			// 
			this.m_numericUpDownMinute.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
			this.m_numericUpDownMinute.Location = new System.Drawing.Point(259, 117);
			this.m_numericUpDownMinute.Name = "m_numericUpDownMinute";
			this.m_numericUpDownMinute.Size = new System.Drawing.Size(207, 72);
			this.m_numericUpDownMinute.TabIndex = 2;
			// 
			// m_numericUpDownHour
			// 
			this.m_numericUpDownHour.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
			this.m_numericUpDownHour.Location = new System.Drawing.Point(16, 117);
			this.m_numericUpDownHour.Name = "m_numericUpDownHour";
			this.m_numericUpDownHour.Size = new System.Drawing.Size(208, 72);
			this.m_numericUpDownHour.TabIndex = 1;
			// 
			// m_dateTimePickerDate
			// 
			this.m_dateTimePickerDate.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
			this.m_dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.m_dateTimePickerDate.Location = new System.Drawing.Point(16, 18);
			this.m_dateTimePickerDate.Name = "m_dateTimePickerDate";
			this.m_dateTimePickerDate.Size = new System.Drawing.Size(450, 59);
			this.m_dateTimePickerDate.TabIndex = 0;
			// 
			// m_textBox
			// 
			this.m_textBox.Location = new System.Drawing.Point(16, 206);
			this.m_textBox.Name = "m_textBox";
			this.m_textBox.Size = new System.Drawing.Size(442, 41);
			this.m_textBox.TabIndex = 5;
			// 
			// menuItem1
			// 
			this.menuItem1.Text = "In";
			// 
			// menuItem2
			// 
			this.menuItem2.Text = "Out";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(480, 536);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.m_tabControl);
			this.Location = new System.Drawing.Point(0, 52);
			this.Menu = this.m_mainMenu;
			this.Name = "FormMain";
			this.Text = "Time report";
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
			this.m_tabControl.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl m_tabControl;
		private System.Windows.Forms.TabPage m_tabPageCheckin;
		private System.Windows.Forms.TabPage m_tabPageReport;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button m_buttonOut;
		private System.Windows.Forms.Button m_buttonIn;
		private System.Windows.Forms.NumericUpDown m_numericUpDownMinute;
		private System.Windows.Forms.NumericUpDown m_numericUpDownHour;
		private System.Windows.Forms.DateTimePicker m_dateTimePickerDate;
		private System.Windows.Forms.TextBox m_textBox;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
	}
}

