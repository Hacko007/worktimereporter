using System;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Threading;
using System.ComponentModel;
using System.Globalization;

[assembly: SecurityPermission(SecurityAction.RequestMinimum, ControlThread = true)]
namespace Hackovic.TimeReport
{
	/// <summary>
	/// Summary description for FormTimeRaport.
	/// </summary>
	public class FormTimeReport : Form
	{
		public const string m_In = "In";
		public const string m_Out = "Ut";

		private TabControl m_MyTabControlMain;
		private TabPage m_TabPageCurrent;
		private TabPage m_TabPageAll;
		private TabPage m_TabPageCalender;
		private UserControlYearOverview m_UserControlYearOverview1;
		private UserControlSummary m_UserControlSummary;
		private TabPage m_TabPageMaintaince;
		private UserControlMaintenance m_UserControlMaintenance;
		UserControlCheckInMain m_UserControlCheckInMain;
        private TabPage m_TabPageReport;
        private UserControlReportOverview m_UserControlReportOverview;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormTimeReport()
		{
			LoadCultureInfo();
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			m_UserControlCheckInMain = new UserControlCheckInMain { Dock = DockStyle.Fill };
			m_TabPageCurrent.Controls.Add(m_UserControlCheckInMain);

			m_UserControlCheckInMain.RefreshOverview += m_UserControlSummary.InitAnnualOverview;
			m_UserControlMaintenance.DbCleaned += m_UserControlCheckInMain.RefreshDataGrids;

			m_UserControlSummary.InitAnnualOverview();
			m_UserControlMaintenance.CurrentUICultureChanged += new EventHandler(UserControlMaintenance_CurrentUICultureChanged);
		    
		}

		private static void LoadCultureInfo()
		{
			try
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo(global::Hackovic.TimeReport.Properties.Settings.Default.Language, true);
				Thread.CurrentThread.CurrentCulture = new CultureInfo(global::Hackovic.TimeReport.Properties.Settings.Default.Language, true);
			}
			catch
			{
			}
		}

		void UserControlMaintenance_CurrentUICultureChanged(object sender, EventArgs e)
		{
			try
			{
				ComponentResourceManager resources = new ComponentResourceManager(typeof(FormTimeReport));
				resources.ApplyResources(this.m_MyTabControlMain, "m_MyTabControlMain");
				resources.ApplyResources(this.m_TabPageCurrent, "m_TabPageCurrent");
				resources.ApplyResources(this.m_TabPageAll, "m_TabPageAll");
				resources.ApplyResources(this.m_UserControlSummary, "m_UserControlSummary");
				resources.ApplyResources(this.m_TabPageCalender, "m_TabPageCalender");
				resources.ApplyResources(this.m_UserControlYearOverview1, "m_UserControlYearOverview1");
				resources.ApplyResources(this.m_TabPageMaintaince, "m_TabPageMaintaince");
				resources.ApplyResources(this.m_UserControlMaintenance, "m_UserControlMaintenance");
				resources.ApplyResources(this, "$this");
				ChangeUICulture(this.Controls);
			}
			catch { }
		}

		private void ChangeUICulture(Control.ControlCollection controlCollection)
		{
			if (controlCollection == null || controlCollection.Count == 0) return;

			foreach (Control item in controlCollection)
			{
				ChangeUICulture(item.Controls);
				var localizebleControl = item as ILocalizableControl;
				if (localizebleControl == null) continue;

				localizebleControl.ChangeLanguage();
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimeReport));
            this.m_MyTabControlMain = new System.Windows.Forms.TabControl();
            this.m_TabPageCurrent = new System.Windows.Forms.TabPage();
            this.m_TabPageAll = new System.Windows.Forms.TabPage();
            this.m_TabPageCalender = new System.Windows.Forms.TabPage();
            this.m_TabPageMaintaince = new System.Windows.Forms.TabPage();
            this.m_TabPageReport = new System.Windows.Forms.TabPage();
            this.m_UserControlSummary = new Hackovic.TimeReport.UserControlSummary();
            this.m_UserControlYearOverview1 = new Hackovic.TimeReport.UserControlYearOverview();
            this.m_UserControlMaintenance = new Hackovic.TimeReport.UserControlMaintenance();
            this.m_UserControlReportOverview = new Hackovic.TimeReport.UserControlReportOverview();
            this.m_MyTabControlMain.SuspendLayout();
            this.m_TabPageAll.SuspendLayout();
            this.m_TabPageCalender.SuspendLayout();
            this.m_TabPageMaintaince.SuspendLayout();
            this.m_TabPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_MyTabControlMain
            // 
            this.m_MyTabControlMain.Controls.Add(this.m_TabPageCurrent);
            this.m_MyTabControlMain.Controls.Add(this.m_TabPageAll);
            this.m_MyTabControlMain.Controls.Add(this.m_TabPageCalender);
            this.m_MyTabControlMain.Controls.Add(this.m_TabPageMaintaince);
            this.m_MyTabControlMain.Controls.Add(this.m_TabPageReport);
            resources.ApplyResources(this.m_MyTabControlMain, "m_MyTabControlMain");
            this.m_MyTabControlMain.Name = "m_MyTabControlMain";
            this.m_MyTabControlMain.SelectedIndex = 0;
            // 
            // m_TabPageCurrent
            // 
            resources.ApplyResources(this.m_TabPageCurrent, "m_TabPageCurrent");
            this.m_TabPageCurrent.Name = "m_TabPageCurrent";
            this.m_TabPageCurrent.UseVisualStyleBackColor = true;
            // 
            // m_TabPageAll
            // 
            this.m_TabPageAll.Controls.Add(this.m_UserControlSummary);
            resources.ApplyResources(this.m_TabPageAll, "m_TabPageAll");
            this.m_TabPageAll.Name = "m_TabPageAll";
            this.m_TabPageAll.UseVisualStyleBackColor = true;
            // 
            // m_TabPageCalender
            // 
            this.m_TabPageCalender.Controls.Add(this.m_UserControlYearOverview1);
            resources.ApplyResources(this.m_TabPageCalender, "m_TabPageCalender");
            this.m_TabPageCalender.Name = "m_TabPageCalender";
            this.m_TabPageCalender.UseVisualStyleBackColor = true;
            // 
            // m_TabPageMaintaince
            // 
            this.m_TabPageMaintaince.Controls.Add(this.m_UserControlMaintenance);
            resources.ApplyResources(this.m_TabPageMaintaince, "m_TabPageMaintaince");
            this.m_TabPageMaintaince.Name = "m_TabPageMaintaince";
            this.m_TabPageMaintaince.UseVisualStyleBackColor = true;
            // 
            // m_TabPageReport
            // 
            this.m_TabPageReport.Controls.Add(this.m_UserControlReportOverview);
            resources.ApplyResources(this.m_TabPageReport, "m_TabPageReport");
            this.m_TabPageReport.Name = "m_TabPageReport";
            this.m_TabPageReport.UseVisualStyleBackColor = true;
            // 
            // m_UserControlSummary
            // 
            resources.ApplyResources(this.m_UserControlSummary, "m_UserControlSummary");
            this.m_UserControlSummary.Name = "m_UserControlSummary";
            // 
            // m_UserControlYearOverview1
            // 
            resources.ApplyResources(this.m_UserControlYearOverview1, "m_UserControlYearOverview1");
            this.m_UserControlYearOverview1.Name = "m_UserControlYearOverview1";
            // 
            // m_UserControlMaintenance
            // 
            resources.ApplyResources(this.m_UserControlMaintenance, "m_UserControlMaintenance");
            this.m_UserControlMaintenance.Name = "m_UserControlMaintenance";
            // 
            // m_UserControlReportOverview
            // 
            resources.ApplyResources(this.m_UserControlReportOverview, "m_UserControlReportOverview");
            this.m_UserControlReportOverview.Name = "m_UserControlReportOverview";
            // 
            // FormTimeReport
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.m_MyTabControlMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormTimeReport";
            this.m_MyTabControlMain.ResumeLayout(false);
            this.m_TabPageAll.ResumeLayout(false);
            this.m_TabPageCalender.ResumeLayout(false);
            this.m_TabPageMaintaince.ResumeLayout(false);
            this.m_TabPageReport.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormTimeReport());
		}


	}
}
