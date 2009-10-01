using System;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public class DataGridViewTimeColumn : DataGridViewColumn
	{
		public DataGridViewTimeColumn()
			: base(new TimeCell())
		{
		}

		public override DataGridViewCell CellTemplate
		{
			get
			{
				return base.CellTemplate;
			}
			set
			{
				// Ensure that the cell used for the template is a CalendarCell.
				if (value != null &&
					!value.GetType().IsAssignableFrom(typeof(TimeCell)))
				{
					throw new InvalidCastException("Must be a CalendarCell");
				}
				base.CellTemplate = value;
			}
		}
	}


	internal class TimeCell : DataGridViewTextBoxCell
	{

		public TimeCell()
			: base()
		{
			// Use the short date format.
			this.Style.Format = "t";
		}

		public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
		{
			// Set the value of the editing control to the current cell value.
			base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
			TimeEditingControl ctl = DataGridView.EditingControl as TimeEditingControl;
			if (this.Value != null)
				ctl.Time = (DateTime)this.Value;
		}

		public override Type EditType
		{
			get
			{
				// Return the type of the editing contol that CalendarCell uses.
				return typeof(TimeEditingControl);
			}
		}

		public override Type ValueType
		{
			get
			{
				// Return the type of the value that CalendarCell contains.
				return typeof(DateTime);
			}
		}

		public override object DefaultNewRowValue
		{
			get
			{
				// Use the current date and time as the default value.
				return DateTime.Now;
			}
		}
	}



	internal class TimeEditingControl : MaskedTextBox, IDataGridViewEditingControl
	{
		DataGridView dataGridView;
		private bool valueChanged ;
		int rowIndex;

		public TimeEditingControl()
		{
			//ValidatingType = typeof(DateTime);
			this.Mask = "90:00";
			Time = DateTime.Now;
		}

		public DateTime Parse(string value)
		{
			string[] hhmm = value.Split(':');
			int hh;
			int mm;

			if (int.TryParse(hhmm[0], out hh) == false || hh > 23)
			{
				return DateTime.MinValue;
			}
			if (int.TryParse(hhmm[1], out mm) == false || mm > 59)
			{
				return DateTime.MinValue;
			}

			return new DateTime(Time.Year, Time.Month, Time.Day, hh, mm, 0);
		}

		DateTime m_Time;
		public DateTime Time
		{
			get { return m_Time; }
			set
			{
				m_Time = value;
				EditingControlFormattedValue = m_Time;
			}
		}



		// Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
		// property.
		public object EditingControlFormattedValue
		{
			get
			{
				DateTime editDateTime = (DateTime)Parse(this.Text);
				if (editDateTime.Equals(DateTime.MinValue))
				{
					return Time.ToString("t");
				}
				else
				{
					return editDateTime.ToString("t");
				}
			}
			set
			{
				if (value is DateTime)
				{
					this.Text = ((DateTime)value).ToString("t");
				}
			}
		}

		// Implements the 
		// IDataGridViewEditingControl.GetEditingControlFormattedValue method.
		public object GetEditingControlFormattedValue(
			DataGridViewDataErrorContexts context)
		{
			return EditingControlFormattedValue;
		}

		// Implements the 
		// IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
		public void ApplyCellStyleToEditingControl(
			DataGridViewCellStyle dataGridViewCellStyle)
		{
			this.Font = dataGridViewCellStyle.Font;
			this.BackColor = dataGridViewCellStyle.BackColor;			
		}

		// Implements the IDataGridViewEditingControl.EditingControlRowIndex 
		// property.
		public int EditingControlRowIndex
		{
			get
			{
				return rowIndex;
			}
			set
			{
				rowIndex = value;
			}
		}

		// Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
		// method.
		public bool EditingControlWantsInputKey(
			Keys key, bool dataGridViewWantsInputKey)
		{
			int selStart = SelectionStart;
			// Let the DateTimePicker handle the keys listed.
			switch (key & Keys.KeyCode)
			{
				case Keys.Left:
				case Keys.Right:
				case Keys.Home:
				case Keys.End:
					return true;
				case Keys.Down:
					selStart = Math.Max(0, SelectionStart - 1);
					DecreaseSelectedValue(selStart);
					return true;
				case Keys.PageDown:
					DecreaseSelectedValue(selStart);
					return true;
				case Keys.Up:
					selStart = Math.Min(5, SelectionStart + 1);
					IncreasSelectedValue(selStart);
					return true;
				case Keys.PageUp:
					IncreasSelectedValue(selStart);
					return true;
				case Keys.Scroll:
					return true;
				default:
					return !dataGridViewWantsInputKey;
			}
		}



		private void IncreasSelectedValue(int selStart)
		{
			if (selStart < 3)
			{
				Time = Time.AddHours(1);
			}
			else
			{
				Time = Time.AddMinutes(1);
			}
			SelectionStart = selStart;
		}

		private void DecreaseSelectedValue(int selStart)
		{

			if (selStart < 3)
			{
				Time = Time.AddHours(-1);
			}
			else
			{
				Time = Time.AddMinutes(-1);
			}
			SelectionStart = selStart;
		}



		// Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
		// method.
		public void PrepareEditingControlForEdit(bool selectAll)
		{
			if (selectAll)
			{
				SelectAll();
			}
			else
			{
				try
				{
					this.SelectionStart = 0;
					this.SelectionLength = 2;
				}
				catch { }
			}
		}

		// Implements the IDataGridViewEditingControl
		// .RepositionEditingControlOnValueChange property.
		public bool RepositionEditingControlOnValueChange
		{
			get
			{
				return false;
			}
		}

		// Implements the IDataGridViewEditingControl
		// .EditingControlDataGridView property.
		public DataGridView EditingControlDataGridView
		{
			get
			{
				return dataGridView;
			}
			set
			{
				dataGridView = value;
			}
		}

		// Implements the IDataGridViewEditingControl
		// .EditingControlValueChanged property.
		public bool EditingControlValueChanged
		{
			get
			{
				return valueChanged;
			}
			set
			{
				valueChanged = value;
			}
		}

		// Implements the IDataGridViewEditingControl
		// .EditingPanelCursor property.
		public Cursor EditingPanelCursor
		{
			get
			{
				return base.Cursor;
			}
		}

		protected override void OnTextChanged(EventArgs e)
		{
			// Notify the DataGridView that the contents of the cell
			// have changed.
			valueChanged = true;
			try
			{
				if (EditingControlDataGridView != null)
					EditingControlDataGridView.NotifyCurrentCellDirty(true);
			}
			catch { }
			base.OnTextChanged(e);
		}
	}


}
