using Hackovic.FreshUserControls;
namespace Hackovic.TimeReport
{
	partial class UserControlMaintenance
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
			this.m_GroupBoxClean = new System.Windows.Forms.GroupBox();
			this.m_ButtonClean = new Hackovic.FreshUserControls.ColorButton();
			this.label1 = new System.Windows.Forms.Label();
			this.m_RadioButtonAfter = new System.Windows.Forms.RadioButton();
			this.m_RadioButtonBetween = new System.Windows.Forms.RadioButton();
			this.m_RadioButtonBefore = new System.Windows.Forms.RadioButton();
			this.m_ColorPanel = new Hackovic.FreshUserControls.ColorPanel();
			this.m_DigitalClock = new Hackovic.FreshUserControls.DigitalClock();
			this.m_UserControlMonthSelectorAfter = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_UserControlMonthSelectorTo = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_UserControlMonthSelectorFrom = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_UserControlMonthSelectorBefore = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_GroupBoxClean.SuspendLayout();
			this.m_ColorPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_GroupBoxClean
			// 
			this.m_GroupBoxClean.Controls.Add(this.m_DigitalClock);
			this.m_GroupBoxClean.Controls.Add(this.m_ButtonClean);
			this.m_GroupBoxClean.Controls.Add(this.label1);
			this.m_GroupBoxClean.Controls.Add(this.m_UserControlMonthSelectorAfter);
			this.m_GroupBoxClean.Controls.Add(this.m_UserControlMonthSelectorTo);
			this.m_GroupBoxClean.Controls.Add(this.m_UserControlMonthSelectorFrom);
			this.m_GroupBoxClean.Controls.Add(this.m_UserControlMonthSelectorBefore);
			this.m_GroupBoxClean.Controls.Add(this.m_RadioButtonAfter);
			this.m_GroupBoxClean.Controls.Add(this.m_RadioButtonBetween);
			this.m_GroupBoxClean.Controls.Add(this.m_RadioButtonBefore);
			this.m_GroupBoxClean.Location = new System.Drawing.Point(19, 29);
			this.m_GroupBoxClean.Name = "m_GroupBoxClean";
			this.m_GroupBoxClean.Size = new System.Drawing.Size(478, 178);
			this.m_GroupBoxClean.TabIndex = 0;
			this.m_GroupBoxClean.TabStop = false;
			this.m_GroupBoxClean.Text = "Rensa";
			// 
			// m_ButtonClean
			// 
			this.m_ButtonClean.BgColor1 = System.Drawing.Color.WhiteSmoke;
			this.m_ButtonClean.BgColor2 = System.Drawing.Color.DarkGray;
			this.m_ButtonClean.FgColor1 = System.Drawing.Color.Black;
			this.m_ButtonClean.FgColor2 = System.Drawing.Color.Black;
			this.m_ButtonClean.ForeColor = System.Drawing.Color.White;
			this.m_ButtonClean.Location = new System.Drawing.Point(7, 142);
			this.m_ButtonClean.Name = "m_ButtonClean";
			this.m_ButtonClean.Size = new System.Drawing.Size(178, 29);
			this.m_ButtonClean.TabIndex = 8;
			this.m_ButtonClean.Text = "Rensa";
			this.m_ButtonClean.TextHasShadow = false;
			this.m_ButtonClean.TextShadowColor = System.Drawing.Color.Empty;
			this.m_ButtonClean.UseVisualStyleBackColor = true;
			this.m_ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(233, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "och innan";
			// 
			// m_RadioButtonAfter
			// 
			this.m_RadioButtonAfter.AutoSize = true;
			this.m_RadioButtonAfter.Location = new System.Drawing.Point(6, 98);
			this.m_RadioButtonAfter.Name = "m_RadioButtonAfter";
			this.m_RadioButtonAfter.Size = new System.Drawing.Size(47, 17);
			this.m_RadioButtonAfter.TabIndex = 6;
			this.m_RadioButtonAfter.Text = "Efter";
			this.m_RadioButtonAfter.UseVisualStyleBackColor = true;
			this.m_RadioButtonAfter.CheckedChanged += new System.EventHandler(this.RadioButtonAfter_CheckedChanged);
			// 
			// m_RadioButtonBetween
			// 
			this.m_RadioButtonBetween.AutoSize = true;
			this.m_RadioButtonBetween.Location = new System.Drawing.Point(7, 65);
			this.m_RadioButtonBetween.Name = "m_RadioButtonBetween";
			this.m_RadioButtonBetween.Size = new System.Drawing.Size(90, 17);
			this.m_RadioButtonBetween.TabIndex = 2;
			this.m_RadioButtonBetween.Text = "Från och med";
			this.m_RadioButtonBetween.UseVisualStyleBackColor = true;
			this.m_RadioButtonBetween.CheckedChanged += new System.EventHandler(this.RadioButtonBetween_CheckedChanged);
			// 
			// m_RadioButtonBefore
			// 
			this.m_RadioButtonBefore.AutoSize = true;
			this.m_RadioButtonBefore.Checked = true;
			this.m_RadioButtonBefore.Location = new System.Drawing.Point(7, 36);
			this.m_RadioButtonBefore.Name = "m_RadioButtonBefore";
			this.m_RadioButtonBefore.Size = new System.Drawing.Size(52, 17);
			this.m_RadioButtonBefore.TabIndex = 0;
			this.m_RadioButtonBefore.TabStop = true;
			this.m_RadioButtonBefore.Text = "Innan";
			this.m_RadioButtonBefore.UseVisualStyleBackColor = true;
			this.m_RadioButtonBefore.CheckedChanged += new System.EventHandler(this.RadioButtonBefore_CheckedChanged);
			// 
			// m_ColorPanel
			// 
			this.m_ColorPanel.BackColor = System.Drawing.Color.Transparent;
			this.m_ColorPanel.BgColor1 = System.Drawing.Color.WhiteSmoke;
			this.m_ColorPanel.BgColor2 = System.Drawing.Color.DimGray;
			this.m_ColorPanel.Controls.Add(this.m_GroupBoxClean);
			this.m_ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ColorPanel.Location = new System.Drawing.Point(0, 0);
			this.m_ColorPanel.Name = "m_ColorPanel";
			this.m_ColorPanel.Size = new System.Drawing.Size(685, 418);
			this.m_ColorPanel.TabIndex = 1;
			// 
			// m_DigitalClock
			// 
			this.m_DigitalClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.m_DigitalClock.BackColor2 = System.Drawing.Color.Silver;
			this.m_DigitalClock.ClockStyle = Hackovic.FreshUserControls.DigitalClockStyle.FullClock;
			this.m_DigitalClock.DateTimeFormat = "\'Idag:\'   yyyy-MM-dd";
			this.m_DigitalClock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_DigitalClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.m_DigitalClock.ForeColor2 = System.Drawing.Color.Black;
			this.m_DigitalClock.FramePrecent = 3;
			this.m_DigitalClock.Location = new System.Drawing.Point(261, 138);
			this.m_DigitalClock.Name = "m_DigitalClock";
			this.m_DigitalClock.Size = new System.Drawing.Size(211, 33);
			this.m_DigitalClock.TabIndex = 1;
			// 
			// m_UserControlMonthSelectorAfter
			// 
			this.m_UserControlMonthSelectorAfter.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorAfter.Location = new System.Drawing.Point(57, 94);
			this.m_UserControlMonthSelectorAfter.Margin = new System.Windows.Forms.Padding(1);
			this.m_UserControlMonthSelectorAfter.Month = 1;
			this.m_UserControlMonthSelectorAfter.Name = "m_UserControlMonthSelectorAfter";
			this.m_UserControlMonthSelectorAfter.ShowOkButton = false;
			this.m_UserControlMonthSelectorAfter.Size = new System.Drawing.Size(128, 21);
			this.m_UserControlMonthSelectorAfter.TabIndex = 7;
			this.m_UserControlMonthSelectorAfter.Year = 2009;
			// 
			// m_UserControlMonthSelectorTo
			// 
			this.m_UserControlMonthSelectorTo.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorTo.Location = new System.Drawing.Point(300, 61);
			this.m_UserControlMonthSelectorTo.Margin = new System.Windows.Forms.Padding(1);
			this.m_UserControlMonthSelectorTo.Month = 1;
			this.m_UserControlMonthSelectorTo.Name = "m_UserControlMonthSelectorTo";
			this.m_UserControlMonthSelectorTo.ShowOkButton = false;
			this.m_UserControlMonthSelectorTo.Size = new System.Drawing.Size(132, 21);
			this.m_UserControlMonthSelectorTo.TabIndex = 5;
			this.m_UserControlMonthSelectorTo.Year = 2009;
			this.m_UserControlMonthSelectorTo.DateChanged += new Hackovic.TimeReport.DateTimeEventHandler(this.UserControlMonthSelector_DateChanged);
			// 
			// m_UserControlMonthSelectorFrom
			// 
			this.m_UserControlMonthSelectorFrom.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorFrom.Location = new System.Drawing.Point(101, 61);
			this.m_UserControlMonthSelectorFrom.Margin = new System.Windows.Forms.Padding(1);
			this.m_UserControlMonthSelectorFrom.Month = 1;
			this.m_UserControlMonthSelectorFrom.Name = "m_UserControlMonthSelectorFrom";
			this.m_UserControlMonthSelectorFrom.ShowOkButton = false;
			this.m_UserControlMonthSelectorFrom.Size = new System.Drawing.Size(128, 21);
			this.m_UserControlMonthSelectorFrom.TabIndex = 3;
			this.m_UserControlMonthSelectorFrom.Year = 2009;
			this.m_UserControlMonthSelectorFrom.DateChanged += new Hackovic.TimeReport.DateTimeEventHandler(this.UserControlMonthSelector_DateChanged);
			// 
			// m_UserControlMonthSelectorBefore
			// 
			this.m_UserControlMonthSelectorBefore.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorBefore.Location = new System.Drawing.Point(63, 32);
			this.m_UserControlMonthSelectorBefore.Margin = new System.Windows.Forms.Padding(1);
			this.m_UserControlMonthSelectorBefore.Month = 1;
			this.m_UserControlMonthSelectorBefore.Name = "m_UserControlMonthSelectorBefore";
			this.m_UserControlMonthSelectorBefore.ShowOkButton = false;
			this.m_UserControlMonthSelectorBefore.Size = new System.Drawing.Size(128, 21);
			this.m_UserControlMonthSelectorBefore.TabIndex = 1;
			this.m_UserControlMonthSelectorBefore.Year = 2009;
			// 
			// UserControlMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_ColorPanel);
			this.Name = "UserControlMaintenance";
			this.Size = new System.Drawing.Size(685, 418);
			this.m_GroupBoxClean.ResumeLayout(false);
			this.m_GroupBoxClean.PerformLayout();
			this.m_ColorPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox m_GroupBoxClean;
		private System.Windows.Forms.RadioButton m_RadioButtonAfter;
		private System.Windows.Forms.RadioButton m_RadioButtonBetween;
		private System.Windows.Forms.RadioButton m_RadioButtonBefore;
		private UserControlMonthSelector m_UserControlMonthSelectorAfter;
		private UserControlMonthSelector m_UserControlMonthSelectorTo;
		private UserControlMonthSelector m_UserControlMonthSelectorFrom;
		private UserControlMonthSelector m_UserControlMonthSelectorBefore;
		private ColorButton m_ButtonClean;
		private System.Windows.Forms.Label label1;
		private Hackovic.FreshUserControls.ColorPanel m_ColorPanel;
		private DigitalClock m_DigitalClock;
	}
}
