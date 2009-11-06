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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMaintenance));
			this.m_ColorPanel = new Hackovic.FreshUserControls.ColorPanel();
			this.m_GroupBoxLangage = new System.Windows.Forms.GroupBox();
			this.m_RadioButtonBosanski = new System.Windows.Forms.RadioButton();
			this.m_RadioButtonEnglish = new System.Windows.Forms.RadioButton();
			this.m_RadioButtonSvenska = new System.Windows.Forms.RadioButton();
			this.m_GroupBoxClean = new System.Windows.Forms.GroupBox();
			this.m_DigitalClock = new Hackovic.FreshUserControls.DigitalClock();
			this.m_ButtonClean = new Hackovic.FreshUserControls.ColorButton();
			this.label1 = new System.Windows.Forms.Label();
			this.m_UserControlMonthSelectorAfter = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_UserControlMonthSelectorTo = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_UserControlMonthSelectorFrom = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_UserControlMonthSelectorBefore = new Hackovic.TimeReport.UserControlMonthSelector();
			this.m_RadioButtonAfter = new System.Windows.Forms.RadioButton();
			this.m_RadioButtonBetween = new System.Windows.Forms.RadioButton();
			this.m_RadioButtonBefore = new System.Windows.Forms.RadioButton();
			this.m_ColorPanel.SuspendLayout();
			this.m_GroupBoxLangage.SuspendLayout();
			this.m_GroupBoxClean.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_ColorPanel
			// 
			this.m_ColorPanel.AccessibleDescription = null;
			this.m_ColorPanel.AccessibleName = null;
			resources.ApplyResources(this.m_ColorPanel, "m_ColorPanel");
			this.m_ColorPanel.BackColor = System.Drawing.Color.Transparent;
			this.m_ColorPanel.BackgroundImage = null;
			this.m_ColorPanel.BgColor1 = System.Drawing.Color.WhiteSmoke;
			this.m_ColorPanel.BgColor2 = System.Drawing.Color.DimGray;
			this.m_ColorPanel.Controls.Add(this.m_GroupBoxLangage);
			this.m_ColorPanel.Controls.Add(this.m_GroupBoxClean);
			this.m_ColorPanel.Font = null;
			this.m_ColorPanel.Name = "m_ColorPanel";
			// 
			// m_GroupBoxLangage
			// 
			this.m_GroupBoxLangage.AccessibleDescription = null;
			this.m_GroupBoxLangage.AccessibleName = null;
			resources.ApplyResources(this.m_GroupBoxLangage, "m_GroupBoxLangage");
			this.m_GroupBoxLangage.BackgroundImage = null;
			this.m_GroupBoxLangage.Controls.Add(this.m_RadioButtonBosanski);
			this.m_GroupBoxLangage.Controls.Add(this.m_RadioButtonEnglish);
			this.m_GroupBoxLangage.Controls.Add(this.m_RadioButtonSvenska);
			this.m_GroupBoxLangage.Font = null;
			this.m_GroupBoxLangage.Name = "m_GroupBoxLangage";
			this.m_GroupBoxLangage.TabStop = false;
			// 
			// m_RadioButtonBosanski
			// 
			this.m_RadioButtonBosanski.AccessibleDescription = null;
			this.m_RadioButtonBosanski.AccessibleName = null;
			resources.ApplyResources(this.m_RadioButtonBosanski, "m_RadioButtonBosanski");
			this.m_RadioButtonBosanski.BackgroundImage = null;
			this.m_RadioButtonBosanski.Font = null;
			this.m_RadioButtonBosanski.Name = "m_RadioButtonBosanski";
			this.m_RadioButtonBosanski.UseVisualStyleBackColor = true;
			this.m_RadioButtonBosanski.CheckedChanged += new System.EventHandler(this.RadioButtonLanguage_CheckedChanged);
			// 
			// m_RadioButtonEnglish
			// 
			this.m_RadioButtonEnglish.AccessibleDescription = null;
			this.m_RadioButtonEnglish.AccessibleName = null;
			resources.ApplyResources(this.m_RadioButtonEnglish, "m_RadioButtonEnglish");
			this.m_RadioButtonEnglish.BackgroundImage = null;
			this.m_RadioButtonEnglish.Font = null;
			this.m_RadioButtonEnglish.Name = "m_RadioButtonEnglish";
			this.m_RadioButtonEnglish.UseVisualStyleBackColor = true;
			this.m_RadioButtonEnglish.CheckedChanged += new System.EventHandler(this.RadioButtonLanguage_CheckedChanged);
			// 
			// m_RadioButtonSvenska
			// 
			this.m_RadioButtonSvenska.AccessibleDescription = null;
			this.m_RadioButtonSvenska.AccessibleName = null;
			resources.ApplyResources(this.m_RadioButtonSvenska, "m_RadioButtonSvenska");
			this.m_RadioButtonSvenska.BackgroundImage = null;
			this.m_RadioButtonSvenska.Checked = true;
			this.m_RadioButtonSvenska.Font = null;
			this.m_RadioButtonSvenska.Name = "m_RadioButtonSvenska";
			this.m_RadioButtonSvenska.TabStop = true;
			this.m_RadioButtonSvenska.UseVisualStyleBackColor = true;
			this.m_RadioButtonSvenska.CheckedChanged += new System.EventHandler(this.RadioButtonLanguage_CheckedChanged);
			// 
			// m_GroupBoxClean
			// 
			this.m_GroupBoxClean.AccessibleDescription = null;
			this.m_GroupBoxClean.AccessibleName = null;
			resources.ApplyResources(this.m_GroupBoxClean, "m_GroupBoxClean");
			this.m_GroupBoxClean.BackgroundImage = null;
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
			this.m_GroupBoxClean.Font = null;
			this.m_GroupBoxClean.Name = "m_GroupBoxClean";
			this.m_GroupBoxClean.TabStop = false;
			// 
			// m_DigitalClock
			// 
			this.m_DigitalClock.AccessibleDescription = null;
			this.m_DigitalClock.AccessibleName = null;
			resources.ApplyResources(this.m_DigitalClock, "m_DigitalClock");
			this.m_DigitalClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.m_DigitalClock.BackgroundImage = null;
			this.m_DigitalClock.ClockStyle = Hackovic.FreshUserControls.DigitalClockStyle.FullClock;
			this.m_DigitalClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.m_DigitalClock.ForeColor2 = System.Drawing.Color.Black;
			this.m_DigitalClock.FramePrecent = 3;
			this.m_DigitalClock.Name = "m_DigitalClock";
			// 
			// m_ButtonClean
			// 
			this.m_ButtonClean.AccessibleDescription = null;
			this.m_ButtonClean.AccessibleName = null;
			resources.ApplyResources(this.m_ButtonClean, "m_ButtonClean");
			this.m_ButtonClean.BackgroundImage = null;
			this.m_ButtonClean.BgColor1 = System.Drawing.Color.WhiteSmoke;
			this.m_ButtonClean.BgColor2 = System.Drawing.Color.DarkGray;
			this.m_ButtonClean.FgColor1 = System.Drawing.Color.Black;
			this.m_ButtonClean.FgColor2 = System.Drawing.Color.Black;
			this.m_ButtonClean.Font = null;
			this.m_ButtonClean.ForeColor = System.Drawing.Color.White;
			this.m_ButtonClean.Name = "m_ButtonClean";
			this.m_ButtonClean.TextHasShadow = false;
			this.m_ButtonClean.TextShadowColor = System.Drawing.Color.Empty;
			this.m_ButtonClean.UseVisualStyleBackColor = true;
			this.m_ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
			// 
			// label1
			// 
			this.label1.AccessibleDescription = null;
			this.label1.AccessibleName = null;
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = null;
			this.label1.Name = "label1";
			// 
			// m_UserControlMonthSelectorAfter
			// 
			this.m_UserControlMonthSelectorAfter.AccessibleDescription = null;
			this.m_UserControlMonthSelectorAfter.AccessibleName = null;
			resources.ApplyResources(this.m_UserControlMonthSelectorAfter, "m_UserControlMonthSelectorAfter");
			this.m_UserControlMonthSelectorAfter.BackgroundImage = null;
			this.m_UserControlMonthSelectorAfter.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorAfter.Font = null;
			this.m_UserControlMonthSelectorAfter.Month = 1;
			this.m_UserControlMonthSelectorAfter.Name = "m_UserControlMonthSelectorAfter";
			this.m_UserControlMonthSelectorAfter.ShowOkButton = false;
			this.m_UserControlMonthSelectorAfter.Year = 2009;
			// 
			// m_UserControlMonthSelectorTo
			// 
			this.m_UserControlMonthSelectorTo.AccessibleDescription = null;
			this.m_UserControlMonthSelectorTo.AccessibleName = null;
			resources.ApplyResources(this.m_UserControlMonthSelectorTo, "m_UserControlMonthSelectorTo");
			this.m_UserControlMonthSelectorTo.BackgroundImage = null;
			this.m_UserControlMonthSelectorTo.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorTo.Font = null;
			this.m_UserControlMonthSelectorTo.Month = 1;
			this.m_UserControlMonthSelectorTo.Name = "m_UserControlMonthSelectorTo";
			this.m_UserControlMonthSelectorTo.ShowOkButton = false;
			this.m_UserControlMonthSelectorTo.Year = 2009;
			this.m_UserControlMonthSelectorTo.DateChanged += new Hackovic.TimeReport.DateTimeEventHandler(this.UserControlMonthSelector_DateChanged);
			// 
			// m_UserControlMonthSelectorFrom
			// 
			this.m_UserControlMonthSelectorFrom.AccessibleDescription = null;
			this.m_UserControlMonthSelectorFrom.AccessibleName = null;
			resources.ApplyResources(this.m_UserControlMonthSelectorFrom, "m_UserControlMonthSelectorFrom");
			this.m_UserControlMonthSelectorFrom.BackgroundImage = null;
			this.m_UserControlMonthSelectorFrom.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorFrom.Font = null;
			this.m_UserControlMonthSelectorFrom.Month = 1;
			this.m_UserControlMonthSelectorFrom.Name = "m_UserControlMonthSelectorFrom";
			this.m_UserControlMonthSelectorFrom.ShowOkButton = false;
			this.m_UserControlMonthSelectorFrom.Year = 2009;
			this.m_UserControlMonthSelectorFrom.DateChanged += new Hackovic.TimeReport.DateTimeEventHandler(this.UserControlMonthSelector_DateChanged);
			// 
			// m_UserControlMonthSelectorBefore
			// 
			this.m_UserControlMonthSelectorBefore.AccessibleDescription = null;
			this.m_UserControlMonthSelectorBefore.AccessibleName = null;
			resources.ApplyResources(this.m_UserControlMonthSelectorBefore, "m_UserControlMonthSelectorBefore");
			this.m_UserControlMonthSelectorBefore.BackgroundImage = null;
			this.m_UserControlMonthSelectorBefore.Date = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
			this.m_UserControlMonthSelectorBefore.Font = null;
			this.m_UserControlMonthSelectorBefore.Month = 1;
			this.m_UserControlMonthSelectorBefore.Name = "m_UserControlMonthSelectorBefore";
			this.m_UserControlMonthSelectorBefore.ShowOkButton = false;
			this.m_UserControlMonthSelectorBefore.Year = 2009;
			// 
			// m_RadioButtonAfter
			// 
			this.m_RadioButtonAfter.AccessibleDescription = null;
			this.m_RadioButtonAfter.AccessibleName = null;
			resources.ApplyResources(this.m_RadioButtonAfter, "m_RadioButtonAfter");
			this.m_RadioButtonAfter.BackgroundImage = null;
			this.m_RadioButtonAfter.Font = null;
			this.m_RadioButtonAfter.Name = "m_RadioButtonAfter";
			this.m_RadioButtonAfter.UseVisualStyleBackColor = true;
			this.m_RadioButtonAfter.CheckedChanged += new System.EventHandler(this.RadioButtonAfter_CheckedChanged);
			// 
			// m_RadioButtonBetween
			// 
			this.m_RadioButtonBetween.AccessibleDescription = null;
			this.m_RadioButtonBetween.AccessibleName = null;
			resources.ApplyResources(this.m_RadioButtonBetween, "m_RadioButtonBetween");
			this.m_RadioButtonBetween.BackgroundImage = null;
			this.m_RadioButtonBetween.Font = null;
			this.m_RadioButtonBetween.Name = "m_RadioButtonBetween";
			this.m_RadioButtonBetween.UseVisualStyleBackColor = true;
			this.m_RadioButtonBetween.CheckedChanged += new System.EventHandler(this.RadioButtonBetween_CheckedChanged);
			// 
			// m_RadioButtonBefore
			// 
			this.m_RadioButtonBefore.AccessibleDescription = null;
			this.m_RadioButtonBefore.AccessibleName = null;
			resources.ApplyResources(this.m_RadioButtonBefore, "m_RadioButtonBefore");
			this.m_RadioButtonBefore.BackgroundImage = null;
			this.m_RadioButtonBefore.Checked = true;
			this.m_RadioButtonBefore.Font = null;
			this.m_RadioButtonBefore.Name = "m_RadioButtonBefore";
			this.m_RadioButtonBefore.TabStop = true;
			this.m_RadioButtonBefore.UseVisualStyleBackColor = true;
			this.m_RadioButtonBefore.CheckedChanged += new System.EventHandler(this.RadioButtonBefore_CheckedChanged);
			// 
			// UserControlMaintenance
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.m_ColorPanel);
			this.Font = null;
			this.Name = "UserControlMaintenance";
			this.m_ColorPanel.ResumeLayout(false);
			this.m_GroupBoxLangage.ResumeLayout(false);
			this.m_GroupBoxLangage.PerformLayout();
			this.m_GroupBoxClean.ResumeLayout(false);
			this.m_GroupBoxClean.PerformLayout();
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
		private System.Windows.Forms.GroupBox m_GroupBoxLangage;
		private System.Windows.Forms.RadioButton m_RadioButtonBosanski;
		private System.Windows.Forms.RadioButton m_RadioButtonEnglish;
		private System.Windows.Forms.RadioButton m_RadioButtonSvenska;
	}
}
