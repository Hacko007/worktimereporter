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
			this.m_ToolStripButton12Months = new System.Windows.Forms.ToolStripButton();
			this.m_ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_FlowLayoutPanelEverything
			// 
			this.m_FlowLayoutPanelEverything.AutoScroll = true;
			this.m_FlowLayoutPanelEverything.BackColor = System.Drawing.Color.White;
			this.m_FlowLayoutPanelEverything.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_FlowLayoutPanelEverything.Location = new System.Drawing.Point(0, 25);
			this.m_FlowLayoutPanelEverything.Name = "m_FlowLayoutPanelEverything";
			this.m_FlowLayoutPanelEverything.Size = new System.Drawing.Size(923, 637);
			this.m_FlowLayoutPanelEverything.TabIndex = 3;
			// 
			// m_ToolStrip1
			// 
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
			this.m_ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.m_ToolStrip1.Name = "m_ToolStrip1";
			this.m_ToolStrip1.Size = new System.Drawing.Size(923, 25);
			this.m_ToolStrip1.TabIndex = 4;
			this.m_ToolStrip1.Text = "m_ToolStrip1";
			// 
			// m_ToolStripButtonPrintOverview
			// 
			this.m_ToolStripButtonPrintOverview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButtonPrintOverview.Name = "m_ToolStripButtonPrintOverview";
			this.m_ToolStripButtonPrintOverview.Size = new System.Drawing.Size(33, 22);
			this.m_ToolStripButtonPrintOverview.Text = "Print";
			this.m_ToolStripButtonPrintOverview.ToolTipText = "Print Sammanställning";
			this.m_ToolStripButtonPrintOverview.Click += new System.EventHandler(this.ToolStripButtonPrintOverview_Click);
			// 
			// m_ToolStripButtonPrinterSetup
			// 
			this.m_ToolStripButtonPrinterSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButtonPrinterSetup.Name = "m_ToolStripButtonPrinterSetup";
			this.m_ToolStripButtonPrinterSetup.Size = new System.Drawing.Size(73, 22);
			this.m_ToolStripButtonPrinterSetup.Text = "Printer setup";
			this.m_ToolStripButtonPrinterSetup.Click += new System.EventHandler(this.ToolStripButtonPrinterSetup_Click);
			// 
			// m_ToolStripSeparator1
			// 
			this.m_ToolStripSeparator1.Name = "m_ToolStripSeparator1";
			this.m_ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// m_ToolStripButtonShowLastYear
			// 
			this.m_ToolStripButtonShowLastYear.Checked = true;
			this.m_ToolStripButtonShowLastYear.CheckOnClick = true;
			this.m_ToolStripButtonShowLastYear.CheckState = System.Windows.Forms.CheckState.Checked;
			this.m_ToolStripButtonShowLastYear.Image = ((System.Drawing.Image)(resources.GetObject("m_ToolStripButtonShowLastYear.Image")));
			this.m_ToolStripButtonShowLastYear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButtonShowLastYear.Name = "m_ToolStripButtonShowLastYear";
			this.m_ToolStripButtonShowLastYear.Size = new System.Drawing.Size(94, 22);
			this.m_ToolStripButtonShowLastYear.Text = "Visa sista året";
			this.m_ToolStripButtonShowLastYear.ToolTipText = "Visa sista året";
			this.m_ToolStripButtonShowLastYear.CheckedChanged += new System.EventHandler(this.m_ToolStripButtonShowLastYear_CheckedChanged);
			// 
			// m_ToolStripSeparator2
			// 
			this.m_ToolStripSeparator2.Name = "m_ToolStripSeparator2";
			this.m_ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// m_ToolStripLabelSumaryTimeSpan
			// 
			this.m_ToolStripLabelSumaryTimeSpan.Enabled = false;
			this.m_ToolStripLabelSumaryTimeSpan.Name = "m_ToolStripLabelSumaryTimeSpan";
			this.m_ToolStripLabelSumaryTimeSpan.Size = new System.Drawing.Size(59, 22);
			this.m_ToolStripLabelSumaryTimeSpan.Text = "Visa mellan";
			// 
			// m_ToolStripSplitButtonFrom
			// 
			this.m_ToolStripSplitButtonFrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_ToolStripSplitButtonFrom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripMonthCalendarFrom});
			this.m_ToolStripSplitButtonFrom.Enabled = false;
			this.m_ToolStripSplitButtonFrom.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripSplitButtonFrom.Name = "m_ToolStripSplitButtonFrom";
			this.m_ToolStripSplitButtonFrom.Size = new System.Drawing.Size(45, 22);
			this.m_ToolStripSplitButtonFrom.Text = "Från";
			// 
			// m_ToolStripMonthCalendarFrom
			// 
			this.m_ToolStripMonthCalendarFrom.FirstDayOfWeek = System.Windows.Forms.Day.Default;
			this.m_ToolStripMonthCalendarFrom.Name = "m_ToolStripMonthCalendarFrom";
			this.m_ToolStripMonthCalendarFrom.Size = new System.Drawing.Size(164, 155);
			this.m_ToolStripMonthCalendarFrom.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ToolStripMonthCalendarFrom_DateChanged);
			// 
			// m_ToolStripLabelAnd
			// 
			this.m_ToolStripLabelAnd.Enabled = false;
			this.m_ToolStripLabelAnd.Name = "m_ToolStripLabelAnd";
			this.m_ToolStripLabelAnd.Size = new System.Drawing.Size(24, 22);
			this.m_ToolStripLabelAnd.Text = "och";
			// 
			// m_ToolStripSplitButtonTo
			// 
			this.m_ToolStripSplitButtonTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_ToolStripSplitButtonTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_ToolStripMonthCalendarTo});
			this.m_ToolStripSplitButtonTo.Enabled = false;
			this.m_ToolStripSplitButtonTo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripSplitButtonTo.Name = "m_ToolStripSplitButtonTo";
			this.m_ToolStripSplitButtonTo.Size = new System.Drawing.Size(35, 22);
			this.m_ToolStripSplitButtonTo.Text = "Till";
			// 
			// m_ToolStripMonthCalendarTo
			// 
			this.m_ToolStripMonthCalendarTo.FirstDayOfWeek = System.Windows.Forms.Day.Default;
			this.m_ToolStripMonthCalendarTo.Name = "m_ToolStripMonthCalendarTo";
			this.m_ToolStripMonthCalendarTo.Size = new System.Drawing.Size(164, 155);
			this.m_ToolStripMonthCalendarTo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ToolStripMonthCalendarTo_DateChanged);
			// 
			// m_ToolStripButtonApplayTimeSpan
			// 
			this.m_ToolStripButtonApplayTimeSpan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.m_ToolStripButtonApplayTimeSpan.Enabled = false;
			this.m_ToolStripButtonApplayTimeSpan.Image = ((System.Drawing.Image)(resources.GetObject("m_ToolStripButtonApplayTimeSpan.Image")));
			this.m_ToolStripButtonApplayTimeSpan.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButtonApplayTimeSpan.Name = "m_ToolStripButtonApplayTimeSpan";
			this.m_ToolStripButtonApplayTimeSpan.Size = new System.Drawing.Size(38, 22);
			this.m_ToolStripButtonApplayTimeSpan.Text = "Apply";
			this.m_ToolStripButtonApplayTimeSpan.Click += new System.EventHandler(this.ToolStripButtonApplayTimeSpan_Click);
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
			// m_printDocument
			// 
			this.m_printDocument.DocumentName = "Översikt";
			this.m_printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
			// 
			// m_pageSetupDialog
			// 
			this.m_pageSetupDialog.Document = this.m_printDocument;
			// 
			// m_ToolStripButton12Months
			// 
			this.m_ToolStripButton12Months.CheckOnClick = true;
			this.m_ToolStripButton12Months.Image = ((System.Drawing.Image)(resources.GetObject("m_ToolStripButton12Months.Image")));
			this.m_ToolStripButton12Months.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.m_ToolStripButton12Months.Name = "m_ToolStripButton12Months";
			this.m_ToolStripButton12Months.Size = new System.Drawing.Size(84, 22);
			this.m_ToolStripButton12Months.Text = "12 månader";
			this.m_ToolStripButton12Months.CheckedChanged += new System.EventHandler(this.m_ToolStripButton12Months_CheckedChanged);
			// 
			// UserControlSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_FlowLayoutPanelEverything);
			this.Controls.Add(this.m_ToolStrip1);
			this.Name = "UserControlSummary";
			this.Size = new System.Drawing.Size(923, 662);
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
