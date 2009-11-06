using Hackovic.FreshUserControls;
namespace Hackovic.TimeReport
{
	partial class UserControlYearOverview
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlYearOverview));
			this.m_MonthCalendar = new System.Windows.Forms.MonthCalendar();
			this.ButtonExport = new Hackovic.FreshUserControls.ColorButton();
			this.ButtonImp = new Hackovic.FreshUserControls.ColorButton();
			this.buttonAddHolyday = new Hackovic.FreshUserControls.ColorButton();
			this.m_DataGridView = new System.Windows.Forms.DataGridView();
			this.m_LabelHolydays = new System.Windows.Forms.Label();
			this.m_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.m_ColorPanel = new Hackovic.FreshUserControls.ColorPanel();
			this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).BeginInit();
			this.m_ColorPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_MonthCalendar
			// 
			this.m_MonthCalendar.AccessibleDescription = null;
			this.m_MonthCalendar.AccessibleName = null;
			resources.ApplyResources(this.m_MonthCalendar, "m_MonthCalendar");
			this.m_MonthCalendar.BackColor = System.Drawing.Color.AntiqueWhite;
			this.m_MonthCalendar.BackgroundImage = null;
			this.m_MonthCalendar.Font = null;
			this.m_MonthCalendar.Name = "m_MonthCalendar";
			this.m_MonthCalendar.TitleBackColor = System.Drawing.Color.SaddleBrown;
			this.m_ToolTip.SetToolTip(this.m_MonthCalendar, resources.GetString("m_MonthCalendar.ToolTip"));
			this.m_MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.m_MonthCalendar_DateSelected);
			// 
			// ButtonExport
			// 
			this.ButtonExport.AccessibleDescription = null;
			this.ButtonExport.AccessibleName = null;
			resources.ApplyResources(this.ButtonExport, "ButtonExport");
			this.ButtonExport.BackgroundImage = null;
			this.ButtonExport.BgColor1 = System.Drawing.Color.BurlyWood;
			this.ButtonExport.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.ButtonExport.FgColor1 = System.Drawing.Color.White;
			this.ButtonExport.FgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ButtonExport.Font = null;
			this.ButtonExport.Name = "ButtonExport";
			this.ButtonExport.TextHasShadow = false;
			this.ButtonExport.TextShadowColor = System.Drawing.Color.Empty;
			this.m_ToolTip.SetToolTip(this.ButtonExport, resources.GetString("ButtonExport.ToolTip"));
			this.ButtonExport.UseVisualStyleBackColor = true;
			this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
			// 
			// ButtonImp
			// 
			this.ButtonImp.AccessibleDescription = null;
			this.ButtonImp.AccessibleName = null;
			resources.ApplyResources(this.ButtonImp, "ButtonImp");
			this.ButtonImp.BackgroundImage = null;
			this.ButtonImp.BgColor1 = System.Drawing.Color.BurlyWood;
			this.ButtonImp.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.ButtonImp.FgColor1 = System.Drawing.Color.White;
			this.ButtonImp.FgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ButtonImp.Font = null;
			this.ButtonImp.Name = "ButtonImp";
			this.ButtonImp.TextHasShadow = false;
			this.ButtonImp.TextShadowColor = System.Drawing.Color.Empty;
			this.m_ToolTip.SetToolTip(this.ButtonImp, resources.GetString("ButtonImp.ToolTip"));
			this.ButtonImp.UseVisualStyleBackColor = true;
			this.ButtonImp.Click += new System.EventHandler(this.ButtonImp_Click);
			// 
			// buttonAddHolyday
			// 
			this.buttonAddHolyday.AccessibleDescription = null;
			this.buttonAddHolyday.AccessibleName = null;
			resources.ApplyResources(this.buttonAddHolyday, "buttonAddHolyday");
			this.buttonAddHolyday.BackgroundImage = null;
			this.buttonAddHolyday.BgColor1 = System.Drawing.Color.BurlyWood;
			this.buttonAddHolyday.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.buttonAddHolyday.FgColor1 = System.Drawing.Color.White;
			this.buttonAddHolyday.FgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.buttonAddHolyday.Name = "buttonAddHolyday";
			this.buttonAddHolyday.TextHasShadow = false;
			this.buttonAddHolyday.TextShadowColor = System.Drawing.Color.Empty;
			this.m_ToolTip.SetToolTip(this.buttonAddHolyday, resources.GetString("buttonAddHolyday.ToolTip"));
			this.buttonAddHolyday.UseVisualStyleBackColor = true;
			this.buttonAddHolyday.Click += new System.EventHandler(this.buttonAddHolyday_Click);
			// 
			// m_DataGridView
			// 
			this.m_DataGridView.AccessibleDescription = null;
			this.m_DataGridView.AccessibleName = null;
			this.m_DataGridView.AllowUserToAddRows = false;
			resources.ApplyResources(this.m_DataGridView, "m_DataGridView");
			this.m_DataGridView.BackgroundImage = null;
			this.m_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_DataGridView.Font = null;
			this.m_DataGridView.Name = "m_DataGridView";
			this.m_ToolTip.SetToolTip(this.m_DataGridView, resources.GetString("m_DataGridView.ToolTip"));
			this.m_DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.m_DataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.m_DataGridView_RowsRemoved);
			// 
			// m_LabelHolydays
			// 
			this.m_LabelHolydays.AccessibleDescription = null;
			this.m_LabelHolydays.AccessibleName = null;
			resources.ApplyResources(this.m_LabelHolydays, "m_LabelHolydays");
			this.m_LabelHolydays.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelHolydays.ForeColor = System.Drawing.Color.Maroon;
			this.m_LabelHolydays.Name = "m_LabelHolydays";
			this.m_ToolTip.SetToolTip(this.m_LabelHolydays, resources.GetString("m_LabelHolydays.ToolTip"));
			// 
			// m_OpenFileDialog
			// 
			this.m_OpenFileDialog.DefaultExt = "xml";
			resources.ApplyResources(this.m_OpenFileDialog, "m_OpenFileDialog");
			// 
			// m_SaveFileDialog
			// 
			this.m_SaveFileDialog.DefaultExt = "xml";
			resources.ApplyResources(this.m_SaveFileDialog, "m_SaveFileDialog");
			// 
			// m_ColorPanel
			// 
			this.m_ColorPanel.AccessibleDescription = null;
			this.m_ColorPanel.AccessibleName = null;
			resources.ApplyResources(this.m_ColorPanel, "m_ColorPanel");
			this.m_ColorPanel.BackgroundImage = null;
			this.m_ColorPanel.BgColor1 = System.Drawing.Color.BurlyWood;
			this.m_ColorPanel.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.m_ColorPanel.Controls.Add(this.m_DataGridView);
			this.m_ColorPanel.Controls.Add(this.ButtonExport);
			this.m_ColorPanel.Controls.Add(this.m_LabelHolydays);
			this.m_ColorPanel.Controls.Add(this.ButtonImp);
			this.m_ColorPanel.Controls.Add(this.buttonAddHolyday);
			this.m_ColorPanel.Font = null;
			this.m_ColorPanel.Name = "m_ColorPanel";
			this.m_ToolTip.SetToolTip(this.m_ColorPanel, resources.GetString("m_ColorPanel.ToolTip"));
			// 
			// UserControlYearOverview
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.m_MonthCalendar);
			this.Controls.Add(this.m_ColorPanel);
			this.Font = null;
			this.Name = "UserControlYearOverview";
			this.m_ToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.Load += new System.EventHandler(this.UserControlYearOverview_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).EndInit();
			this.m_ColorPanel.ResumeLayout(false);
			this.m_ColorPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MonthCalendar m_MonthCalendar;
		private System.Windows.Forms.Label m_LabelHolydays;
		private System.Windows.Forms.DataGridView m_DataGridView;
		private ColorButton buttonAddHolyday;
		private ColorButton ButtonExport;
		private ColorButton ButtonImp;
		private System.Windows.Forms.OpenFileDialog m_OpenFileDialog;
		private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;
		private Hackovic.FreshUserControls.ColorPanel m_ColorPanel;
		private System.Windows.Forms.ToolTip m_ToolTip;
	}
}
