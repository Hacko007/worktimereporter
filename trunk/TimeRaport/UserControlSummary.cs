using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public partial class UserControlSummary : UserControl
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
				userControlMonthSummary.Height = userControlMonthSummary.TotalHeight + 5;
				
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

		public void GetPrintArea(Panel pnl)
		{			
			Graphics myGraphics = pnl.CreateGraphics();
			Size s = pnl.Size;			
			m_MemoryImage = new Bitmap(s.Width, s.Height, myGraphics);
			Graphics memoryGraphics = Graphics.FromImage(m_MemoryImage);

			Point loc = GetAbsoluteLocation(pnl, pnl.Location);
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

		
	}
}
