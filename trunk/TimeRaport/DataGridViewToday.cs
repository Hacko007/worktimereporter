using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Hackovic.TimeReport
{
	public class DataGridViewToday : UserControl// DataGridView
	{		
		public event EventHandler TimeLogChange ;

		public DataGridViewToday() {
			InitializeComponent();			
		}

		public DataGridView DataGrid { get; set; }

		private DataGridViewTextBoxColumn m_ColumnDay;
		private DataGridViewTimeColumn m_ColumnInTime;
		private DataGridViewTimeColumn m_ColumnOutTime;
		private DataGridViewTextBoxColumn m_ColumnCategoryText;
		private DataGridViewTextBoxColumn m_ColumnCategoryId;
		private DataGridViewTextBoxColumn m_CoulmnInfo;
		private System.ComponentModel.IContainer components;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.DataGrid = new DataGridView();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_DeleteSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeLogDataSet = new Hackovic.TimeReport.TimeLogDataSet();
			this.m_ColumnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColumnInTime = new Hackovic.TimeReport.DataGridViewTimeColumn();
			this.m_ColumnOutTime = new Hackovic.TimeReport.DataGridViewTimeColumn();
			this.m_ColumnCategoryText = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColumnCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_CoulmnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// m_ContextMenuStrip
			// 
			this.m_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_DeleteSelectedRowToolStripMenuItem});
			this.m_ContextMenuStrip.Name = "m_ContextMenuStrip";
			this.m_ContextMenuStrip.Size = new System.Drawing.Size(163, 26);
			this.m_ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
			// 
			// m_DeleteSelectedRowToolStripMenuItem
			// 
			this.m_DeleteSelectedRowToolStripMenuItem.Name = "m_DeleteSelectedRowToolStripMenuItem";
			this.m_DeleteSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.m_DeleteSelectedRowToolStripMenuItem.Text = "Radera vald rad";
			this.m_DeleteSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.DeleteSelectedRowToolStripMenuItem_Click);
			// 
			// timeLogBindingSource
			// 
			this.timeLogBindingSource.DataMember = "TimeLog";
			this.timeLogBindingSource.DataSource = this.timeLogDataSet;
			// 
			// timeLogDataSet
			// 
			this.timeLogDataSet.DataSetName = "TimeLogDataSet";
			this.timeLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// m_ColumnDay
			// 
			this.m_ColumnDay.DataPropertyName = "Day";
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.Format = "dddd dd";
			dataGridViewCellStyle1.NullValue = null;
			this.m_ColumnDay.DefaultCellStyle = dataGridViewCellStyle1;
			this.m_ColumnDay.FillWeight = 120F;
			this.m_ColumnDay.HeaderText = "Dag";
			this.m_ColumnDay.Name = "m_ColumnDay";
			this.m_ColumnDay.ReadOnly = true;
			this.m_ColumnDay.Width = 120;
			// 
			// m_ColumnInTime
			// 
			this.m_ColumnInTime.DataPropertyName = "InTime";
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.Format = "t";
			dataGridViewCellStyle2.NullValue = null;
			this.m_ColumnInTime.DefaultCellStyle = dataGridViewCellStyle2;
			this.m_ColumnInTime.FillWeight = 130F;
			this.m_ColumnInTime.HeaderText = "In";
			this.m_ColumnInTime.Name = "m_ColumnInTime";
			this.m_ColumnInTime.Width = 130;
			// 
			// m_ColumnOutTime
			// 
			this.m_ColumnOutTime.DataPropertyName = "OutTime";
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "t";
			dataGridViewCellStyle3.NullValue = null;
			this.m_ColumnOutTime.DefaultCellStyle = dataGridViewCellStyle3;
			this.m_ColumnOutTime.FillWeight = 130F;
			this.m_ColumnOutTime.HeaderText = "Ut";
			this.m_ColumnOutTime.Name = "m_ColumnOutTime";
			this.m_ColumnOutTime.Width = 130;
			// 
			// m_ColumnCategoryText
			// 
			this.m_ColumnCategoryText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.m_ColumnCategoryText.DataPropertyName = "CategoryText";
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_ColumnCategoryText.DefaultCellStyle = dataGridViewCellStyle4;
			this.m_ColumnCategoryText.HeaderText = "Kategory";
			this.m_ColumnCategoryText.Name = "m_ColumnCategoryText";
			this.m_ColumnCategoryText.ReadOnly = true;
			// 
			// m_ColumnCategoryId
			// 
			this.m_ColumnCategoryId.DataPropertyName = "CategoryId";
			this.m_ColumnCategoryId.HeaderText = "CategoryId";
			this.m_ColumnCategoryId.Name = "m_ColumnCategoryId";
			this.m_ColumnCategoryId.Visible = false;
			// 
			// m_CoulmnInfo
			// 
			this.m_CoulmnInfo.DataPropertyName = "Info";
			this.m_CoulmnInfo.HeaderText = "Info";
			this.m_CoulmnInfo.Name = "m_CoulmnInfo";
			// 
			// DataGridViewToday
			// 
			this.DataGrid.AllowUserToAddRows = false;
			this.DataGrid.AllowUserToOrderColumns = true;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DataGrid.AutoGenerateColumns = false;
			this.DataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
			this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.DataGrid.ColumnHeadersHeight = 22;
			this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_ColumnDay,
            this.m_ColumnInTime,
            this.m_ColumnOutTime,
            this.m_ColumnCategoryText,
            this.m_ColumnCategoryId,
            this.m_CoulmnInfo});
			this.DataGrid.ContextMenuStrip = this.m_ContextMenuStrip;
			this.DataGrid.DataSource = this.timeLogBindingSource;
			this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.DataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
			this.DataGrid.Name = "dataGridView_Timmar";
			this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.DataGrid.RowHeadersWidth = 20;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkRed;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.DataGrid.RowTemplate.Height = 30;
			this.DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGrid.Size = new System.Drawing.Size(661, 175);
			this.DataGrid.DataError += new DataGridViewDataErrorEventHandler(DataGrid_DataError);
			this.DataGrid.Dock = DockStyle.Fill;
			this.m_ContextMenuStrip.ResumeLayout(false);			
			this.Controls.Add(this.DataGrid);
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			
		}
		
		private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (this.DataGrid.SelectedRows.Count == 0)
			{
				e.Cancel = true;
			}
		}
		private void DeleteSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DateTime? dtIn = this.DataGrid.SelectedRows[0].Cells[1].Value as DateTime?;
			DateTime? dtOut = this.DataGrid.SelectedRows[0].Cells[2].Value as DateTime?;

			var p = TimeLogFactory.Instance.TimeLog.
				Where(tl =>
						(!dtIn.HasValue && tl.IsInTimeNull() || (dtIn.HasValue && tl.InTime == dtIn.Value))
					&& (!dtOut.HasValue && tl.IsOutTimeNull() || (dtOut.HasValue && tl.OutTime == dtOut.Value)));

			if (p.Count() > 0)
			{
				var row = p.First();

				row.Delete();

				OnTimeLogChange();			

			}
		}

		private void OnTimeLogChange()
		{
			if (TimeLogChange != null) {
				TimeLogChange(this, EventArgs.Empty);
			}
		}		

 
		private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem m_DeleteSelectedRowToolStripMenuItem;
		private TimeLogDataSet timeLogDataSet;
		private System.Windows.Forms.BindingSource timeLogBindingSource;

		public System.Windows.Forms.BindingSource TimeLogBindingSource
		{
			get { return timeLogBindingSource; }
			set
			{
				timeLogBindingSource = value;
				this.DataGrid.DataSource = timeLogBindingSource;
			}
		}
		
	}
}
