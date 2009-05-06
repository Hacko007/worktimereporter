using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.IO;
using System.Configuration;
using System.Xml;
using System.Drawing.Printing;

namespace Hackovic.TimeReport
{
	public delegate	void RefreshOverview();
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TimeRaportForm : System.Windows.Forms.Form
	{
		public const string _IN = "In";
		public const string _OUT = "Ut";

		private TabControl My_TabControl_Main;
		private TabPage tabPage_Current;
		private TabPage tabPage_All;
		private FlowLayoutPanel m_flowLayoutPanel_Everything;
		private ToolStrip toolStrip1;
		private ToolStripButton m_toolStripButton_PrintOverview;
		private PageSetupDialog m_pageSetupDialog;
		private PrintDocument m_printDocument;
		private PrintPreviewDialog m_printPreviewDialog;
		private ToolStripButton m_toolStripButton_PrinterSetup;
		private TabPage tabPage_Calender;
		private UserControlYearOverview userControlYearOverview1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TimeRaportForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            UserControlCheckInMain checkinmain_form = new UserControlCheckInMain();
            checkinmain_form.Dock = DockStyle.Fill;
            tabPage_Current.Controls.Add(checkinmain_form);

			checkinmain_form.RefreshOverview += new RefreshOverview(this.InitAnnualOverview);
			InitAnnualOverview();
			
		   }

		public void InitAnnualOverview() {
			
			m_flowLayoutPanel_Everything.Controls.Clear();
			int month = DateTime.Today.Month-12;
			DateTime actualMonth = DateTime.Today.AddMonths(month);
			actualMonth = new DateTime(actualMonth.Year, actualMonth.Month, 1);
			
			for (; actualMonth <= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); )
			{

				TimeLogFactory.CalculateMonths(actualMonth);

				UserControlMonthSummary _userControlMonthSummary = new UserControlMonthSummary();
				_userControlMonthSummary.Month = actualMonth;
				_userControlMonthSummary.Height = _userControlMonthSummary.TotalHeight + 5;
				
				if (!_userControlMonthSummary.IsEmpty())
				{
					m_flowLayoutPanel_Everything.Controls.Add(_userControlMonthSummary);				
				}


				month++;
				actualMonth = DateTime.Today.AddMonths(month);
				actualMonth = new DateTime(actualMonth.Year, actualMonth.Month, 1);
			}
		}
		
		#region Print FlowLayoutPanel

		private Point GetAbsoluteLocation(Control ctr, Point loc) {
			if (loc == null) loc = new Point(0, 0);
			
			if (ctr == null) return loc;

			loc = new Point(loc.X + ctr.Location.X, loc.Y + ctr.Location.Y);

			if (ctr.Parent == null) {				
				return loc;
			}
			else
			{
				return GetAbsoluteLocation(ctr.Parent, loc);
			}
		}

		private void m_toolStripButton_PrintOverview_Click(object sender, EventArgs e)
		{
			Print(m_flowLayoutPanel_Everything);
		}

		private void m_toolStripButton_PrinterSetup_Click(object sender, EventArgs e)
		{
			m_pageSetupDialog.ShowDialog();
		}

		Bitmap MemoryImage;
		public void GetPrintArea(Panel pnl)
		{
			Rectangle rect = new Rectangle(pnl.Location.X, pnl.Location.Y, pnl.Width, pnl.Height);
			Graphics myGraphics = pnl.CreateGraphics();
			Size s = pnl.Size;			
			MemoryImage = new Bitmap(s.Width, s.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(MemoryImage);

			Point loc = GetAbsoluteLocation(pnl, pnl.Location);
			memoryGraphics.CopyFromScreen(loc.X, loc.Y, 0, 0, s, CopyPixelOperation.SourceCopy);
		}


		void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			int newH = (MemoryImage.Height * e.MarginBounds.Width) / MemoryImage.Width;
			e.Graphics.DrawImage(MemoryImage, e.MarginBounds.Top, e.MarginBounds.Left, e.MarginBounds.Width, newH);
		}
		
		public void Print(Panel pnl)
		{			
			
			GetPrintArea(pnl);
			//printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);					
			m_printPreviewDialog.ShowDialog();
		}

		#endregion Print panel


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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeRaportForm));
			this.My_TabControl_Main = new System.Windows.Forms.TabControl();
			this.tabPage_Current = new System.Windows.Forms.TabPage();
			this.tabPage_All = new System.Windows.Forms.TabPage();
			this.m_flowLayoutPanel_Everything = new System.Windows.Forms.FlowLayoutPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.m_toolStripButton_PrintOverview = new System.Windows.Forms.ToolStripButton();
			this.m_toolStripButton_PrinterSetup = new System.Windows.Forms.ToolStripButton();
			this.m_pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
			this.m_printDocument = new System.Drawing.Printing.PrintDocument();
			this.m_printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.tabPage_Calender = new System.Windows.Forms.TabPage();
			this.userControlYearOverview1 = new Hackovic.TimeReport.UserControlYearOverview();
			this.My_TabControl_Main.SuspendLayout();
			this.tabPage_All.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabPage_Calender.SuspendLayout();
			this.SuspendLayout();
			// 
			// My_TabControl_Main
			// 
			this.My_TabControl_Main.Controls.Add(this.tabPage_Current);
			this.My_TabControl_Main.Controls.Add(this.tabPage_All);
			this.My_TabControl_Main.Controls.Add(this.tabPage_Calender);
			this.My_TabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.My_TabControl_Main.Location = new System.Drawing.Point(0, 0);
			this.My_TabControl_Main.Margin = new System.Windows.Forms.Padding(0);
			this.My_TabControl_Main.Name = "My_TabControl_Main";
			this.My_TabControl_Main.SelectedIndex = 0;
			this.My_TabControl_Main.Size = new System.Drawing.Size(1222, 646);
			this.My_TabControl_Main.TabIndex = 0;
			// 
			// tabPage_Current
			// 
			this.tabPage_Current.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Current.Name = "tabPage_Current";
			this.tabPage_Current.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Current.Size = new System.Drawing.Size(1214, 620);
			this.tabPage_Current.TabIndex = 0;
			this.tabPage_Current.Text = "       Vy: Dag - Vecka - Månad        ";
			this.tabPage_Current.UseVisualStyleBackColor = true;
			// 
			// tabPage_All
			// 
			this.tabPage_All.Controls.Add(this.m_flowLayoutPanel_Everything);
			this.tabPage_All.Controls.Add(this.toolStrip1);
			this.tabPage_All.Location = new System.Drawing.Point(4, 22);
			this.tabPage_All.Name = "tabPage_All";
			this.tabPage_All.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_All.Size = new System.Drawing.Size(1214, 620);
			this.tabPage_All.TabIndex = 1;
			this.tabPage_All.Text = "            Sammanställning                  ";
			this.tabPage_All.UseVisualStyleBackColor = true;
			// 
			// m_flowLayoutPanel_Everything
			// 
			this.m_flowLayoutPanel_Everything.AutoScroll = true;
			this.m_flowLayoutPanel_Everything.BackColor = System.Drawing.Color.White;
			this.m_flowLayoutPanel_Everything.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_flowLayoutPanel_Everything.Location = new System.Drawing.Point(3, 28);
			this.m_flowLayoutPanel_Everything.Name = "m_flowLayoutPanel_Everything";
			this.m_flowLayoutPanel_Everything.Size = new System.Drawing.Size(1208, 589);
			this.m_flowLayoutPanel_Everything.TabIndex = 2;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_toolStripButton_PrintOverview,
            this.m_toolStripButton_PrinterSetup});
			this.toolStrip1.Location = new System.Drawing.Point(3, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1208, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// m_toolStripButton_PrintOverview
			// 
			this.m_toolStripButton_PrintOverview.Image = ((System.Drawing.Image)(resources.GetObject("m_toolStripButton_PrintOverview.Image")));
			this.m_toolStripButton_PrintOverview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_toolStripButton_PrintOverview.Name = "m_toolStripButton_PrintOverview";
			this.m_toolStripButton_PrintOverview.Size = new System.Drawing.Size(49, 22);
			this.m_toolStripButton_PrintOverview.Text = "Print";
			this.m_toolStripButton_PrintOverview.ToolTipText = "Print Sammanställning";
			this.m_toolStripButton_PrintOverview.Click += new System.EventHandler(this.m_toolStripButton_PrintOverview_Click);
			// 
			// m_toolStripButton_PrinterSetup
			// 
			this.m_toolStripButton_PrinterSetup.Image = ((System.Drawing.Image)(resources.GetObject("m_toolStripButton_PrinterSetup.Image")));
			this.m_toolStripButton_PrinterSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_toolStripButton_PrinterSetup.Name = "m_toolStripButton_PrinterSetup";
			this.m_toolStripButton_PrinterSetup.Size = new System.Drawing.Size(89, 22);
			this.m_toolStripButton_PrinterSetup.Text = "Printer setup";
			this.m_toolStripButton_PrinterSetup.Click += new System.EventHandler(this.m_toolStripButton_PrinterSetup_Click);
			// 
			// m_pageSetupDialog
			// 
			this.m_pageSetupDialog.Document = this.m_printDocument;
			// 
			// m_printDocument
			// 
			this.m_printDocument.DocumentName = "Översikt";
			this.m_printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
			// 
			// m_printPreviewDialog
			// 
			this.m_printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.m_printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.m_printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
			this.m_printPreviewDialog.Document = this.m_printDocument;
			this.m_printPreviewDialog.Enabled = true;
			this.m_printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("m_printPreviewDialog.Icon")));
			this.m_printPreviewDialog.Name = "m_printPreviewDialog";
			this.m_printPreviewDialog.Visible = false;
			// 
			// tabPage_Calender
			// 
			this.tabPage_Calender.Controls.Add(this.userControlYearOverview1);
			this.tabPage_Calender.Location = new System.Drawing.Point(4, 22);
			this.tabPage_Calender.Name = "tabPage_Calender";
			this.tabPage_Calender.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage_Calender.Size = new System.Drawing.Size(1214, 620);
			this.tabPage_Calender.TabIndex = 2;
			this.tabPage_Calender.Text = "Kalender";
			this.tabPage_Calender.UseVisualStyleBackColor = true;
			// 
			// userControlYearOverview1
			// 
			this.userControlYearOverview1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userControlYearOverview1.Location = new System.Drawing.Point(3, 3);
			this.userControlYearOverview1.Name = "userControlYearOverview1";
			this.userControlYearOverview1.Size = new System.Drawing.Size(1208, 614);
			this.userControlYearOverview1.TabIndex = 1;
			// 
			// TimeRaportForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(1222, 646);
			this.Controls.Add(this.My_TabControl_Main);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TimeRaportForm";
			this.Text = "Tidsrapport";
			this.My_TabControl_Main.ResumeLayout(false);
			this.tabPage_All.ResumeLayout(false);
			this.tabPage_All.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabPage_Calender.ResumeLayout(false);
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
			Application.Run(new TimeRaportForm());
		}


	}
}
