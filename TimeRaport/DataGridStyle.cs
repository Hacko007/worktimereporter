using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Hackovic.TimeReport
{
	public static class DataGridStyle
	{
		public static DataGridViewCellStyle RowsDefaultCellStyle { get; set; }
		public static DataGridViewCellStyle AlternativeCellStyle { get; set; }

		public static void ApplyStyle(this DataGridView dataGrid, DataGridViewCellStyle rowsDefaultCellStyle, DataGridViewCellStyle alternativeCellStyle)
		{
			RowsDefaultCellStyle = rowsDefaultCellStyle;
			AlternativeCellStyle = alternativeCellStyle;
			dataGrid.ApplyDefaultStyle();
		}

		public static void ApplyDefaultStyle(this DataGridView dataGrid)
		{
			//dataGrid.DefaultCellStyle = DefaultCellStyle;
			dataGrid.AlternatingRowsDefaultCellStyle = AlternativeCellStyle;
			dataGrid.RowsDefaultCellStyle = RowsDefaultCellStyle;
			dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
		}

		public static void InitDefaultStyle()
		{
			RowsDefaultCellStyle = new DataGridViewCellStyle();

			RowsDefaultCellStyle.BackColor = Color.FromArgb( 245, 245, 240 );
			//RowsDefaultCellStyle.Font = new System.Drawing.Font("Verdana", 9F);
//			RowsDefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
			RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			RowsDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

			AlternativeCellStyle = new DataGridViewCellStyle();

			AlternativeCellStyle.BackColor = Color.FromArgb(230, 230, 230);
			AlternativeCellStyle.ForeColor = System.Drawing.Color.Black;
			AlternativeCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
			AlternativeCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			//AlternativeCellStyle.Font = new System.Drawing.Font("Verdana", 9F);
			//AlternativeCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
		}
	}
}
