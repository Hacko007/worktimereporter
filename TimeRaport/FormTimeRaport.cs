using System;
using System.Windows.Forms;

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
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormTimeReport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			m_UserControlCheckInMain = new UserControlCheckInMain { Dock = DockStyle.Fill };
			m_TabPageCurrent.Controls.Add(m_UserControlCheckInMain);

			m_UserControlCheckInMain.RefreshOverview += m_UserControlSummary.InitAnnualOverview;
			m_UserControlMaintenance.DbCleaned += m_UserControlCheckInMain.RefreshDataGrids;

			m_UserControlSummary.InitAnnualOverview();

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
			this.m_UserControlSummary = new Hackovic.TimeReport.UserControlSummary();
			this.m_TabPageCalender = new System.Windows.Forms.TabPage();
			this.m_UserControlYearOverview1 = new Hackovic.TimeReport.UserControlYearOverview();
			this.m_TabPageMaintaince = new System.Windows.Forms.TabPage();
			this.m_UserControlMaintenance = new Hackovic.TimeReport.UserControlMaintenance();
			this.m_MyTabControlMain.SuspendLayout();
			this.m_TabPageAll.SuspendLayout();
			this.m_TabPageCalender.SuspendLayout();
			this.m_TabPageMaintaince.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_MyTabControlMain
			// 
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageCurrent);
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageAll);
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageCalender);
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageMaintaince);
			this.m_MyTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_MyTabControlMain.Location = new System.Drawing.Point(0, 0);
			this.m_MyTabControlMain.Margin = new System.Windows.Forms.Padding(0);
			this.m_MyTabControlMain.Name = "m_MyTabControlMain";
			this.m_MyTabControlMain.SelectedIndex = 0;
			this.m_MyTabControlMain.Size = new System.Drawing.Size(1222, 646);
			this.m_MyTabControlMain.TabIndex = 0;
			// 
			// m_TabPageCurrent
			// 
			this.m_TabPageCurrent.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageCurrent.Name = "m_TabPageCurrent";
			this.m_TabPageCurrent.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageCurrent.Size = new System.Drawing.Size(1214, 620);
			this.m_TabPageCurrent.TabIndex = 0;
			this.m_TabPageCurrent.Text = "       Vy: Dag - Vecka - Månad        ";
			this.m_TabPageCurrent.UseVisualStyleBackColor = true;
			// 
			// m_TabPageAll
			// 
			this.m_TabPageAll.Controls.Add(this.m_UserControlSummary);
			this.m_TabPageAll.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageAll.Name = "m_TabPageAll";
			this.m_TabPageAll.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageAll.Size = new System.Drawing.Size(1214, 620);
			this.m_TabPageAll.TabIndex = 1;
			this.m_TabPageAll.Text = "            Sammanställning                  ";
			this.m_TabPageAll.UseVisualStyleBackColor = true;
			// 
			// m_UserControlSummary
			// 
			this.m_UserControlSummary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserControlSummary.Location = new System.Drawing.Point(3, 3);
			this.m_UserControlSummary.Name = "m_UserControlSummary";
			this.m_UserControlSummary.Size = new System.Drawing.Size(1208, 614);
			this.m_UserControlSummary.TabIndex = 0;
			// 
			// m_TabPageCalender
			// 
			this.m_TabPageCalender.Controls.Add(this.m_UserControlYearOverview1);
			this.m_TabPageCalender.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageCalender.Name = "m_TabPageCalender";
			this.m_TabPageCalender.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageCalender.Size = new System.Drawing.Size(1214, 620);
			this.m_TabPageCalender.TabIndex = 2;
			this.m_TabPageCalender.Text = "Kalender";
			this.m_TabPageCalender.UseVisualStyleBackColor = true;
			// 
			// m_UserControlYearOverview1
			// 
			this.m_UserControlYearOverview1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserControlYearOverview1.Location = new System.Drawing.Point(3, 3);
			this.m_UserControlYearOverview1.Name = "m_UserControlYearOverview1";
			this.m_UserControlYearOverview1.Size = new System.Drawing.Size(1208, 614);
			this.m_UserControlYearOverview1.TabIndex = 1;
			// 
			// m_TabPageMaintaince
			// 
			this.m_TabPageMaintaince.Controls.Add(this.m_UserControlMaintenance);
			this.m_TabPageMaintaince.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageMaintaince.Name = "m_TabPageMaintaince";
			this.m_TabPageMaintaince.Size = new System.Drawing.Size(1214, 620);
			this.m_TabPageMaintaince.TabIndex = 3;
			this.m_TabPageMaintaince.Text = "Underhåll";
			this.m_TabPageMaintaince.UseVisualStyleBackColor = true;
			// 
			// m_UserControlMaintenance
			// 
			this.m_UserControlMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_UserControlMaintenance.Location = new System.Drawing.Point(0, 0);
			this.m_UserControlMaintenance.Name = "m_UserControlMaintenance";
			this.m_UserControlMaintenance.Size = new System.Drawing.Size(1214, 620);
			this.m_UserControlMaintenance.TabIndex = 0;
			// 
			// FormTimeRaport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1222, 646);
			this.Controls.Add(this.m_MyTabControlMain);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTimeRaport";
			this.Text = "Tidsrapport";
			this.m_MyTabControlMain.ResumeLayout(false);
			this.m_TabPageAll.ResumeLayout(false);
			this.m_TabPageCalender.ResumeLayout(false);
			this.m_TabPageMaintaince.ResumeLayout(false);
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
