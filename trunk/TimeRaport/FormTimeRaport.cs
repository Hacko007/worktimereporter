using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Hackovic.TimeReport
{
	public delegate	void RefreshOverview();
	/// <summary>
	/// Summary description for FormTimeRaport.
	/// </summary>
	public class FormTimeRaport : Form
	{
		public const string _IN = "In";
		public const string _OUT = "Ut";

		private TabControl m_MyTabControlMain;
		private TabPage m_TabPageCurrent;
		private TabPage m_TabPageAll;
		private FlowLayoutPanel m_FlowLayoutPanelEverything;
		private ToolStrip m_ToolStrip1;
		private ToolStripButton m_ToolStripButtonPrintOverview;
		private PageSetupDialog m_pageSetupDialog;
		private PrintDocument m_printDocument;
		private PrintPreviewDialog m_printPreviewDialog;
		private ToolStripButton m_ToolStripButtonPrinterSetup;
		private TabPage m_TabPageCalender;
		private UserControlYearOverview m_UserControlYearOverview1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormTimeRaport()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            UserControlCheckInMain checkinmainForm = new UserControlCheckInMain {Dock = DockStyle.Fill};
			m_TabPageCurrent.Controls.Add(checkinmainForm);

			checkinmainForm.RefreshOverview += InitAnnualOverview;
			InitAnnualOverview();
			
		   }

		public void InitAnnualOverview() {
			
			m_FlowLayoutPanelEverything.Controls.Clear();
			int month = DateTime.Today.Month-12;
			DateTime actualMonth = DateTime.Today.AddMonths(month);
			actualMonth = new DateTime(actualMonth.Year, actualMonth.Month, 1);
			
			for (; actualMonth <= new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1); )
			{

				TimeLogFactory.CalculateMonths(actualMonth);

				UserControlMonthSummary userControlMonthSummary = new UserControlMonthSummary {Month = actualMonth};
				userControlMonthSummary.Height = userControlMonthSummary.TotalHeight + 5;
				
				if (!userControlMonthSummary.IsEmpty())
				{
					m_FlowLayoutPanelEverything.Controls.Add(userControlMonthSummary);				
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
			Print(m_FlowLayoutPanelEverything);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimeRaport));
			this.m_MyTabControlMain = new System.Windows.Forms.TabControl();
			this.m_TabPageCurrent = new System.Windows.Forms.TabPage();
			this.m_TabPageAll = new System.Windows.Forms.TabPage();
			this.m_FlowLayoutPanelEverything = new System.Windows.Forms.FlowLayoutPanel();
			this.m_ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.m_ToolStripButtonPrintOverview = new System.Windows.Forms.ToolStripButton();
			this.m_ToolStripButtonPrinterSetup = new System.Windows.Forms.ToolStripButton();
			this.m_pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
			this.m_printDocument = new System.Drawing.Printing.PrintDocument();
			this.m_printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.m_TabPageCalender = new System.Windows.Forms.TabPage();
			this.m_UserControlYearOverview1 = new Hackovic.TimeReport.UserControlYearOverview();
			this.m_MyTabControlMain.SuspendLayout();
			this.m_TabPageAll.SuspendLayout();
			this.m_ToolStrip1.SuspendLayout();
			this.m_TabPageCalender.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_MyTabControlMain
			// 
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageCurrent);
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageAll);
			this.m_MyTabControlMain.Controls.Add(this.m_TabPageCalender);
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
			this.m_TabPageAll.Controls.Add(this.m_FlowLayoutPanelEverything);
			this.m_TabPageAll.Controls.Add(this.m_ToolStrip1);
			this.m_TabPageAll.Location = new System.Drawing.Point(4, 22);
			this.m_TabPageAll.Name = "m_TabPageAll";
			this.m_TabPageAll.Padding = new System.Windows.Forms.Padding(3);
			this.m_TabPageAll.Size = new System.Drawing.Size(1214, 620);
			this.m_TabPageAll.TabIndex = 1;
			this.m_TabPageAll.Text = "            Sammanställning                  ";
			this.m_TabPageAll.UseVisualStyleBackColor = true;
			// 
			// m_FlowLayoutPanelEverything
			// 
			this.m_FlowLayoutPanelEverything.AutoScroll = true;
			this.m_FlowLayoutPanelEverything.BackColor = System.Drawing.Color.White;
			this.m_FlowLayoutPanelEverything.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_FlowLayoutPanelEverything.Location = new System.Drawing.Point(3, 28);
			this.m_FlowLayoutPanelEverything.Name = "m_FlowLayoutPanelEverything";
			this.m_FlowLayoutPanelEverything.Size = new System.Drawing.Size(1208, 589);
			this.m_FlowLayoutPanelEverything.TabIndex = 2;
			// 
			// m_ToolStrip1
			// 
			this.m_ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripButtonPrintOverview,
            this.m_ToolStripButtonPrinterSetup});
			this.m_ToolStrip1.Location = new System.Drawing.Point(3, 3);
			this.m_ToolStrip1.Name = "m_ToolStrip1";
			this.m_ToolStrip1.Size = new System.Drawing.Size(1208, 25);
			this.m_ToolStrip1.TabIndex = 3;
			this.m_ToolStrip1.Text = "m_ToolStrip1";
			// 
			// m_ToolStripButtonPrintOverview
			// 
			this.m_ToolStripButtonPrintOverview.Image = ((System.Drawing.Image)(resources.GetObject("m_ToolStripButtonPrintOverview.Image")));
			this.m_ToolStripButtonPrintOverview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButtonPrintOverview.Name = "m_ToolStripButtonPrintOverview";
			this.m_ToolStripButtonPrintOverview.Size = new System.Drawing.Size(49, 22);
			this.m_ToolStripButtonPrintOverview.Text = "Print";
			this.m_ToolStripButtonPrintOverview.ToolTipText = "Print Sammanställning";
			this.m_ToolStripButtonPrintOverview.Click += new System.EventHandler(this.m_toolStripButton_PrintOverview_Click);
			// 
			// m_ToolStripButtonPrinterSetup
			// 
			this.m_ToolStripButtonPrinterSetup.Image = ((System.Drawing.Image)(resources.GetObject("m_ToolStripButtonPrinterSetup.Image")));
			this.m_ToolStripButtonPrinterSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButtonPrinterSetup.Name = "m_ToolStripButtonPrinterSetup";
			this.m_ToolStripButtonPrinterSetup.Size = new System.Drawing.Size(89, 22);
			this.m_ToolStripButtonPrinterSetup.Text = "Printer setup";
			this.m_ToolStripButtonPrinterSetup.Click += new System.EventHandler(this.m_toolStripButton_PrinterSetup_Click);
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
			// TimeRaportForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.DarkSlateGray;
			this.ClientSize = new System.Drawing.Size(1222, 646);
			this.Controls.Add(this.m_MyTabControlMain);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TimeRaportForm";
			this.Text = "Tidsrapport";
			this.m_MyTabControlMain.ResumeLayout(false);
			this.m_TabPageAll.ResumeLayout(false);
			this.m_TabPageAll.PerformLayout();
			this.m_ToolStrip1.ResumeLayout(false);
			this.m_ToolStrip1.PerformLayout();
			this.m_TabPageCalender.ResumeLayout(false);
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
			Application.Run(new FormTimeRaport());
		}


	}
}
