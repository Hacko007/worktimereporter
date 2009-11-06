using System.Drawing;

namespace Hackovic.TimeReport
{
	partial class UserControlSummary
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
				m_MemoryImage.Dispose();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSummary));
			this.m_FlowLayoutPanelEverything = new System.Windows.Forms.FlowLayoutPanel();
			this.m_ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.m_ToolStripButtonPrintOverview = new System.Windows.Forms.ToolStripButton();
			this.m_ToolStripButtonPrinterSetup = new System.Windows.Forms.ToolStripButton();
			this.m_ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ToolStripButtonShowLastYear = new System.Windows.Forms.ToolStripButton();
			this.m_ToolStripButton12Months = new System.Windows.Forms.ToolStripButton();
			this.m_ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.m_ToolStripLabelSumaryTimeSpan = new System.Windows.Forms.ToolStripLabel();
			this.m_ToolStripSplitButtonFrom = new System.Windows.Forms.ToolStripSplitButton();
			this.m_ToolStripMonthCalendarFrom = new Hackovic.TimeReport.ToolStripMonthCalendar();
			this.m_ToolStripLabelAnd = new System.Windows.Forms.ToolStripLabel();
			this.m_ToolStripSplitButtonTo = new System.Windows.Forms.ToolStripSplitButton();
			this.m_ToolStripMonthCalendarTo = new Hackovic.TimeReport.ToolStripMonthCalendar();
			this.m_ToolStripButtonApplayTimeSpan = new System.Windows.Forms.ToolStripButton();
			this.m_printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
			this.m_printDocument = new System.Drawing.Printing.PrintDocument();
			this.m_pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
			this.m_ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_FlowLayoutPanelEverything
			// 
			this.m_FlowLayoutPanelEverything.AccessibleDescription = null;
			this.m_FlowLayoutPanelEverything.AccessibleName = null;
			resources.ApplyResources(this.m_FlowLayoutPanelEverything, "m_FlowLayoutPanelEverything");
			this.m_FlowLayoutPanelEverything.BackColor = System.Drawing.Color.White;
			this.m_FlowLayoutPanelEverything.BackgroundImage = null;
			this.m_FlowLayoutPanelEverything.Font = null;
			this.m_FlowLayoutPanelEverything.Name = "m_FlowLayoutPanelEverything";
			// 
			// m_ToolStrip1
			// 
			this.m_ToolStrip1.AccessibleDescription = null;
			this.m_ToolStrip1.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStrip1, "m_ToolStrip1");
			this.m_ToolStrip1.BackgroundImage = null;
			this.m_ToolStrip1.Font = null;
			this.m_ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripButtonPrintOverview,
            this.m_ToolStripButtonPrinterSetup,
            this.m_ToolStripSeparator1,
            this.m_ToolStripButtonShowLastYear,
            this.m_ToolStripButton12Months,
            this.m_ToolStripSeparator2,
            this.m_ToolStripLabelSumaryTimeSpan,
            this.m_ToolStripSplitButtonFrom,
            this.m_ToolStripLabelAnd,
            this.m_ToolStripSplitButtonTo,
            this.m_ToolStripButtonApplayTimeSpan});
			this.m_ToolStrip1.Name = "m_ToolStrip1";
			// 
			// m_ToolStripButtonPrintOverview
			// 
			this.m_ToolStripButtonPrintOverview.AccessibleDescription = null;
			this.m_ToolStripButtonPrintOverview.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripButtonPrintOverview, "m_ToolStripButtonPrintOverview");
			this.m_ToolStripButtonPrintOverview.BackgroundImage = null;
			this.m_ToolStripButtonPrintOverview.Name = "m_ToolStripButtonPrintOverview";
			this.m_ToolStripButtonPrintOverview.Click += new System.EventHandler(this.ToolStripButtonPrintOverview_Click);
			// 
			// m_ToolStripButtonPrinterSetup
			// 
			this.m_ToolStripButtonPrinterSetup.AccessibleDescription = null;
			this.m_ToolStripButtonPrinterSetup.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripButtonPrinterSetup, "m_ToolStripButtonPrinterSetup");
			this.m_ToolStripButtonPrinterSetup.BackgroundImage = null;
			this.m_ToolStripButtonPrinterSetup.Name = "m_ToolStripButtonPrinterSetup";
			this.m_ToolStripButtonPrinterSetup.Click += new System.EventHandler(this.ToolStripButtonPrinterSetup_Click);
			// 
			// m_ToolStripSeparator1
			// 
			this.m_ToolStripSeparator1.AccessibleDescription = null;
			this.m_ToolStripSeparator1.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripSeparator1, "m_ToolStripSeparator1");
			this.m_ToolStripSeparator1.Name = "m_ToolStripSeparator1";
			// 
			// m_ToolStripButtonShowLastYear
			// 
			this.m_ToolStripButtonShowLastYear.AccessibleDescription = null;
			this.m_ToolStripButtonShowLastYear.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripButtonShowLastYear, "m_ToolStripButtonShowLastYear");
			this.m_ToolStripButtonShowLastYear.BackgroundImage = null;
			this.m_ToolStripButtonShowLastYear.Checked = true;
			this.m_ToolStripButtonShowLastYear.CheckOnClick = true;
			this.m_ToolStripButtonShowLastYear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_ToolStripButtonShowLastYear.Name = "m_ToolStripButtonShowLastYear";
			this.m_ToolStripButtonShowLastYear.CheckedChanged += new System.EventHandler(this.m_ToolStripButtonShowLastYear_CheckedChanged);
			// 
			// m_ToolStripButton12Months
			// 
			this.m_ToolStripButton12Months.AccessibleDescription = null;
			this.m_ToolStripButton12Months.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripButton12Months, "m_ToolStripButton12Months");
			this.m_ToolStripButton12Months.BackgroundImage = null;
			this.m_ToolStripButton12Months.CheckOnClick = true;
			this.m_ToolStripButton12Months.Name = "m_ToolStripButton12Months";
			this.m_ToolStripButton12Months.CheckedChanged += new System.EventHandler(this.m_ToolStripButton12Months_CheckedChanged);
			// 
			// m_ToolStripSeparator2
			// 
			this.m_ToolStripSeparator2.AccessibleDescription = null;
			this.m_ToolStripSeparator2.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripSeparator2, "m_ToolStripSeparator2");
			this.m_ToolStripSeparator2.Name = "m_ToolStripSeparator2";
			// 
			// m_ToolStripLabelSumaryTimeSpan
			// 
			this.m_ToolStripLabelSumaryTimeSpan.AccessibleDescription = null;
			this.m_ToolStripLabelSumaryTimeSpan.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripLabelSumaryTimeSpan, "m_ToolStripLabelSumaryTimeSpan");
			this.m_ToolStripLabelSumaryTimeSpan.BackgroundImage = null;
			this.m_ToolStripLabelSumaryTimeSpan.Name = "m_ToolStripLabelSumaryTimeSpan";
			// 
			// m_ToolStripSplitButtonFrom
			// 
			this.m_ToolStripSplitButtonFrom.AccessibleDescription = null;
			this.m_ToolStripSplitButtonFrom.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripSplitButtonFrom, "m_ToolStripSplitButtonFrom");
			this.m_ToolStripSplitButtonFrom.BackgroundImage = null;
			this.m_ToolStripSplitButtonFrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_ToolStripSplitButtonFrom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripMonthCalendarFrom});
			this.m_ToolStripSplitButtonFrom.Name = "m_ToolStripSplitButtonFrom";
			// 
			// m_ToolStripMonthCalendarFrom
			// 
			this.m_ToolStripMonthCalendarFrom.AccessibleDescription = null;
			this.m_ToolStripMonthCalendarFrom.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripMonthCalendarFrom, "m_ToolStripMonthCalendarFrom");
			this.m_ToolStripMonthCalendarFrom.BackgroundImage = null;
			this.m_ToolStripMonthCalendarFrom.FirstDayOfWeek = System.Windows.Forms.Day.Default;
			this.m_ToolStripMonthCalendarFrom.Name = "m_ToolStripMonthCalendarFrom";
			this.m_ToolStripMonthCalendarFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ToolStripMonthCalendarFrom_DateChanged);
			// 
			// m_ToolStripLabelAnd
			// 
			this.m_ToolStripLabelAnd.AccessibleDescription = null;
			this.m_ToolStripLabelAnd.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripLabelAnd, "m_ToolStripLabelAnd");
			this.m_ToolStripLabelAnd.BackgroundImage = null;
			this.m_ToolStripLabelAnd.Name = "m_ToolStripLabelAnd";
			// 
			// m_ToolStripSplitButtonTo
			// 
			this.m_ToolStripSplitButtonTo.AccessibleDescription = null;
			this.m_ToolStripSplitButtonTo.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripSplitButtonTo, "m_ToolStripSplitButtonTo");
			this.m_ToolStripSplitButtonTo.BackgroundImage = null;
			this.m_ToolStripSplitButtonTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_ToolStripSplitButtonTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripMonthCalendarTo});
			this.m_ToolStripSplitButtonTo.Name = "m_ToolStripSplitButtonTo";
			// 
			// m_ToolStripMonthCalendarTo
			// 
			this.m_ToolStripMonthCalendarTo.AccessibleDescription = null;
			this.m_ToolStripMonthCalendarTo.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripMonthCalendarTo, "m_ToolStripMonthCalendarTo");
			this.m_ToolStripMonthCalendarTo.BackgroundImage = null;
			this.m_ToolStripMonthCalendarTo.FirstDayOfWeek = System.Windows.Forms.Day.Default;
			this.m_ToolStripMonthCalendarTo.Name = "m_ToolStripMonthCalendarTo";
			this.m_ToolStripMonthCalendarTo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ToolStripMonthCalendarTo_DateChanged);
			// 
			// m_ToolStripButtonApplayTimeSpan
			// 
			this.m_ToolStripButtonApplayTimeSpan.AccessibleDescription = null;
			this.m_ToolStripButtonApplayTimeSpan.AccessibleName = null;
			resources.ApplyResources(this.m_ToolStripButtonApplayTimeSpan, "m_ToolStripButtonApplayTimeSpan");
			this.m_ToolStripButtonApplayTimeSpan.BackgroundImage = null;
			this.m_ToolStripButtonApplayTimeSpan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_ToolStripButtonApplayTimeSpan.Name = "m_ToolStripButtonApplayTimeSpan";
			this.m_ToolStripButtonApplayTimeSpan.Click += new System.EventHandler(this.ToolStripButtonApplayTimeSpan_Click);
			// 
			// m_printPreviewDialog
			// 
			this.m_printPreviewDialog.AccessibleDescription = null;
			this.m_printPreviewDialog.AccessibleName = null;
			resources.ApplyResources(this.m_printPreviewDialog, "m_printPreviewDialog");
			this.m_printPreviewDialog.BackgroundImage = null;
			this.m_printPreviewDialog.Document = this.m_printDocument;
			this.m_printPreviewDialog.Font = null;
			this.m_printPreviewDialog.Name = "m_printPreviewDialog";
			// 
			// m_printDocument
			// 
			this.m_printDocument.DocumentName = "Översikt";
			this.m_printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
			// 
			// m_pageSetupDialog
			// 
			this.m_pageSetupDialog.Document = this.m_printDocument;
			// 
			// UserControlSummary
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = null;
			this.Controls.Add(this.m_FlowLayoutPanelEverything);
			this.Controls.Add(this.m_ToolStrip1);
			this.Font = null;
			this.Name = "UserControlSummary";
			this.m_ToolStrip1.ResumeLayout(false);
			this.m_ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel m_FlowLayoutPanelEverything;
		private System.Windows.Forms.ToolStrip m_ToolStrip1;
		private System.Windows.Forms.ToolStripButton m_ToolStripButtonPrintOverview;
		private System.Windows.Forms.ToolStripButton m_ToolStripButtonPrinterSetup;
		private System.Windows.Forms.ToolStripSeparator m_ToolStripSeparator1;
		private System.Windows.Forms.ToolStripButton m_ToolStripButtonShowLastYear;
		private System.Windows.Forms.ToolStripSeparator m_ToolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel m_ToolStripLabelSumaryTimeSpan;
		private ToolStripMonthCalendar m_ToolStripMonthCalendarFrom;
		private System.Windows.Forms.ToolStripLabel m_ToolStripLabelAnd;
		private ToolStripMonthCalendar m_ToolStripMonthCalendarTo;
		private System.Windows.Forms.ToolStripButton m_ToolStripButtonApplayTimeSpan;
		private System.Windows.Forms.PrintPreviewDialog m_printPreviewDialog;
		private System.Drawing.Printing.PrintDocument m_printDocument;
		private System.Windows.Forms.PageSetupDialog m_pageSetupDialog;
		private System.Windows.Forms.ToolStripSplitButton m_ToolStripSplitButtonFrom;
		private System.Windows.Forms.ToolStripSplitButton m_ToolStripSplitButtonTo;
		private Bitmap m_MemoryImage;
		private System.Windows.Forms.ToolStripButton m_ToolStripButton12Months;
	}
}
