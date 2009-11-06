using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Hackovic.TimeReport
{
	public partial class UserControlSummary : UserControl, ILocalizableControl
	{
		public UserControlSummary()
		{
			InitializeComponent();
			SetThisYearTimeSpan();
		}	
		
		public void InitAnnualOverview() {
			
			m_FlowLayoutPanelEverything.Controls.Clear();

			DateTime actualMonth = m_ToolStripMonthCalendarFrom.MonthCalendarControl.SelectionStart ;						

			for (; actualMonth <= m_ToolStripMonthCalendarTo.MonthCalendarControl.SelectionStart; )
			{

				TimeLogFactory.CalculateMonths(actualMonth);

				UserControlMonthSummary userControlMonthSummary = new UserControlMonthSummary {Month = actualMonth};
				userControlMonthSummary.AjustHight();
				
				if (!userControlMonthSummary.IsEmpty())
				{
					m_FlowLayoutPanelEverything.Controls.Add(userControlMonthSummary);				
				}
				
				actualMonth = actualMonth.AddMonths(1);
				actualMonth = new DateTime(actualMonth.Year, actualMonth.Month, 1);
			}
		}

		private void SetThisYearTimeSpan()
		{
			DateTime actualMonth = new DateTime(DateTime.Today.Year , 1,1);			
			m_ToolStripMonthCalendarFrom.MonthCalendarControl.SetDate(new DateTime(actualMonth.Year, actualMonth.Month, 1));
			m_ToolStripMonthCalendarTo.MonthCalendarControl.SetDate(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)));
		}

		private void SetWholeYearTimeSpan()
		{
			DateTime actualMonth = DateTime.Today.AddMonths(-12);
			actualMonth = new DateTime(actualMonth.Year, actualMonth.Month, 1);

			m_ToolStripMonthCalendarFrom.MonthCalendarControl.SetDate(new DateTime(actualMonth.Year, actualMonth.Month, 1));
			m_ToolStripMonthCalendarTo.MonthCalendarControl.SetDate(new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month)));
		}

		#region Print FlowLayoutPanel

		private static Point GetAbsoluteLocation(Control ctr, Point loc) {
			
			
			if (ctr == null) return loc;

			loc = new Point(loc.X + ctr.Location.X, loc.Y + ctr.Location.Y);

			return ctr.Parent == null ? loc : GetAbsoluteLocation(ctr.Parent, loc);
		}

		private void ToolStripButtonPrintOverview_Click(object sender, EventArgs e)
		{
			Print(m_FlowLayoutPanelEverything);
		}

		private void ToolStripButtonPrinterSetup_Click(object sender, EventArgs e)
		{
			m_pageSetupDialog.ShowDialog();
		}

		public void GetPrintArea(Control panel)
		{			
			Graphics myGraphics = panel.CreateGraphics();
			Size s = panel.Size;			
			m_MemoryImage = new Bitmap(s.Width, s.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(m_MemoryImage);

			Point loc = GetAbsoluteLocation(panel, panel.Location);
			memoryGraphics.CopyFromScreen(loc.X+5, loc.Y+5, 0, 0, s, CopyPixelOperation.SourceCopy);
		}


		void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			int newH = (m_MemoryImage.Height * e.MarginBounds.Width) / m_MemoryImage.Width;
			e.Graphics.DrawImage(m_MemoryImage, e.MarginBounds.Top, e.MarginBounds.Left, e.MarginBounds.Width, newH);
		}
		
		public void Print(Panel pnl)
		{			
			
			GetPrintArea(pnl);
			m_printPreviewDialog.ShowDialog();
		}

		#endregion Print panel

		private void m_ToolStripButtonShowLastYear_CheckedChanged(object sender, EventArgs e)
		{
			if (m_ToolStripButtonShowLastYear.Checked)
			{
				SetThisYearTimeSpan();
			}
			m_ToolStripButton12Months.Checked = !m_ToolStripButtonShowLastYear.Checked;
			EnableTimeSpanSelection();
			InitAnnualOverview();
		}

		private void m_ToolStripButton12Months_CheckedChanged(object sender, EventArgs e)
		{
			if (m_ToolStripButton12Months.Checked)
			{
				SetWholeYearTimeSpan();
			}
			m_ToolStripButtonShowLastYear.Checked = !m_ToolStripButton12Months.Checked;

			EnableTimeSpanSelection();
			InitAnnualOverview();
		}

		private void EnableTimeSpanSelection()
		{
			bool enable = ! m_ToolStripButtonShowLastYear.Checked && ! m_ToolStripButton12Months.Checked;
			m_ToolStripLabelSumaryTimeSpan.Enabled = enable;
			m_ToolStripLabelAnd.Enabled = enable;
			m_ToolStripSplitButtonFrom.Enabled = enable;
			m_ToolStripSplitButtonTo.Enabled = enable;
			m_ToolStripButtonApplayTimeSpan.Enabled = enable;
		}

		private void ToolStripButtonApplayTimeSpan_Click(object sender, EventArgs e)
		{
			InitAnnualOverview();
		}

		private void ToolStripMonthCalendarFrom_DateChanged(object sender, DateRangeEventArgs e)
		{
			m_ToolStripSplitButtonFrom.Text = e.Start.ToShortDateString();
			m_ToolStripSplitButtonFrom.HideDropDown();
		}

		private void ToolStripMonthCalendarTo_DateChanged(object sender, DateRangeEventArgs e)
		{
			m_ToolStripSplitButtonTo.Text = e.Start.ToShortDateString();
			m_ToolStripSplitButtonTo.HideDropDown();
		}



		#region ILocalizableControl Members

		public void ChangeLanguage()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(UserControlSummary));

			resources.ApplyResources(this.m_ToolStrip1, "m_ToolStrip1");
			resources.ApplyResources(this.m_ToolStripButtonPrintOverview, "m_ToolStripButtonPrintOverview");
			resources.ApplyResources(this.m_ToolStripButtonPrinterSetup, "m_ToolStripButtonPrinterSetup");
			resources.ApplyResources(this.m_ToolStripButtonShowLastYear, "m_ToolStripButtonShowLastYear");
			resources.ApplyResources(this.m_ToolStripButton12Months, "m_ToolStripButton12Months");
			resources.ApplyResources(this.m_ToolStripLabelSumaryTimeSpan, "m_ToolStripLabelSumaryTimeSpan");
			resources.ApplyResources(this.m_ToolStripSplitButtonFrom, "m_ToolStripSplitButtonFrom");
			resources.ApplyResources(this.m_ToolStripMonthCalendarFrom, "m_ToolStripMonthCalendarFrom");
			resources.ApplyResources(this.m_ToolStripLabelAnd, "m_ToolStripLabelAnd");
			resources.ApplyResources(this.m_ToolStripSplitButtonTo, "m_ToolStripSplitButtonTo");
			resources.ApplyResources(this.m_ToolStripMonthCalendarTo, "m_ToolStripMonthCalendarTo");
			resources.ApplyResources(this.m_ToolStripButtonApplayTimeSpan, "m_ToolStripButtonApplayTimeSpan");
			resources.ApplyResources(this.m_printPreviewDialog, "m_printPreviewDialog");
			resources.ApplyResources(this, "$this");
			
		
		}

		#endregion
	}
}
