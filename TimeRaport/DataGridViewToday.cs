using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Hackovic.TimeReport
{
	public class DataGridViewToday : DataGridView
	{
		private System.ComponentModel.IContainer components;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.timeLogDataSet = new Hackovic.TimeReport.TimeLogDataSet();
			this.m_ColumnDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColumnInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColumnOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColumnCategoryText = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_ColumnCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.m_CoulmnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();

			this.m_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.m_DeleteSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			// 
			// m_ColumnDay
			// 
			this.m_ColumnDay.DataPropertyName = "Day";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.m_ColumnDay.DefaultCellStyle = dataGridViewCellStyle2;
			this.m_ColumnDay.FillWeight = 160F;
			this.m_ColumnDay.HeaderText = "Dag";
			this.m_ColumnDay.Name = "m_ColumnDay";
			this.m_ColumnDay.Width = 160;
			// 
			// m_ColumnInTime
			// 
			this.m_ColumnInTime.DataPropertyName = "InTime";
			dataGridViewCellStyle3.Format = "t";
			dataGridViewCellStyle3.NullValue = null;
			this.m_ColumnInTime.DefaultCellStyle = dataGridViewCellStyle3;
			this.m_ColumnInTime.HeaderText = "In";
			this.m_ColumnInTime.Name = "m_ColumnInTime";
			// 
			// m_ColumnOutTime
			// 
			this.m_ColumnOutTime.DataPropertyName = "OutTime";
			dataGridViewCellStyle4.Format = "t";
			dataGridViewCellStyle4.NullValue = null;
			this.m_ColumnOutTime.DefaultCellStyle = dataGridViewCellStyle4;
			this.m_ColumnOutTime.HeaderText = "Ut";
			this.m_ColumnOutTime.Name = "m_ColumnOutTime";
			// 
			// m_ColumnCategoryText
			// 
			this.m_ColumnCategoryText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.m_ColumnCategoryText.DataPropertyName = "CategoryText";
			this.m_ColumnCategoryText.HeaderText = "Kategory";
			this.m_ColumnCategoryText.Name = "m_ColumnCategoryText";
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
			// m_DeleteSelectedRowToolStripMenuItem
			// 
			this.m_DeleteSelectedRowToolStripMenuItem.Name = "m_DeleteSelectedRowToolStripMenuItem";
			this.m_DeleteSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.m_DeleteSelectedRowToolStripMenuItem.Text = "Radera vald rad";
			this.m_DeleteSelectedRowToolStripMenuItem.Click += new System.EventHandler(this.m_DeleteSelectedRowToolStripMenuItem_Click);
			// 
			// m_ContextMenuStrip
			// 
			this.m_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_DeleteSelectedRowToolStripMenuItem});
			this.m_ContextMenuStrip.Name = "m_ContextMenuStrip";
			this.m_ContextMenuStrip.Size = new System.Drawing.Size(163, 26);
			this.m_ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.m_ContextMenuStrip_Opening);
			
			// 
			// dataGridView_Timmar
			// 
			this.AllowUserToAddRows = false;
			this.AutoGenerateColumns = false;
			this.BackgroundColor = System.Drawing.Color.DarkGray;
			this.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ColumnHeadersHeight = 35;
			this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_ColumnDay,
            this.m_ColumnInTime,
            this.m_ColumnOutTime,
            this.m_ColumnCategoryText,
            this.m_ColumnCategoryId,
            this.m_CoulmnInfo});
			this.ContextMenuStrip = this.m_ContextMenuStrip;
			this.DataSource = this.timeLogBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DefaultCellStyle = dataGridViewCellStyle5;
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridColor = System.Drawing.Color.DarkGray;
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "dataGridView_Timmar";
			this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.RowHeadersWidth = 20;
			this.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
			this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.RowTemplate.Height = 30;
			this.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Size = new System.Drawing.Size(661, 175);
			this.TabIndex = 0;
			this.CellValueChanged += new DataGridViewCellEventHandler(DataGridViewToday_CellValueChanged);
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}

		void DataGridViewToday_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void m_ContextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (this.SelectedRows.Count == 0)
			{
				e.Cancel = true;
			}
		}
		private void m_DeleteSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DateTime? dtIn = this.SelectedRows[0].Cells[1].Value as DateTime?;
			DateTime? dtOut = this.SelectedRows[0].Cells[2].Value as DateTime?;

			var p = TimeLogFactory.Instance.TimeLog.
				Where(tl =>
						(!dtIn.HasValue && tl.IsInTimeNull() || (dtIn.HasValue && tl.InTime == dtIn.Value))
					&& (!dtOut.HasValue && tl.IsOutTimeNull() || (dtOut.HasValue && tl.OutTime == dtOut.Value)));

			if (p.Count() > 0)
			{
				var row = p.First();

				row.Delete();

				throw new NotImplementedException();
			//	UpdateTimeLogToday();
			//	RefreshDataGrids();

			}
		}


 
		private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem m_DeleteSelectedRowToolStripMenuItem;
		private TimeLogDataSet timeLogDataSet;
		private System.Windows.Forms.BindingSource timeLogBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnCategoryText;        
		private System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnDay;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnInTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnOutTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_ColumnCategoryId;
		private System.Windows.Forms.DataGridViewTextBoxColumn m_CoulmnInfo;
		
	}
}
