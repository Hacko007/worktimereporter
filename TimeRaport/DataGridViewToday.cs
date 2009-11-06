using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public class DataGridViewToday : UserControl,ILocalizableControl
	{		
		public event EventHandler TimeLogChange ;

		private System.Windows.Forms.ContextMenuStrip m_ContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem m_DeleteSelectedRowToolStripMenuItem;
		private TimeLogDataSet timeLogDataSet;
		private System.Windows.Forms.BindingSource timeLogBindingSource;
		private System.ComponentModel.IContainer components;
		private DataGridViewTextBoxColumn m_ColumnDay;
		private DataGridViewTimeColumn m_ColumnInTime;
		private DataGridViewTimeColumn m_ColumnOutTime;
		private DataGridViewTextBoxColumn m_ColumnCategoryText;
		private DataGridViewTextBoxColumn m_ColumnCategoryId;
		private DataGridViewTextBoxColumn m_CoulmnInfo;
		private DataGridView m_DataGrid;

		public DataGridViewToday() {
			InitializeComponent();			
		}

		public DataGridView DataGrid { 
			get { return m_DataGrid; }
			set { m_DataGrid = value; }
		}


		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewToday));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.m_DataGrid = new System.Windows.Forms.DataGridView();
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
			((System.ComponentModel.ISupportInitialize)(this.m_DataGrid)).BeginInit();
			this.m_ContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// m_DataGrid
			// 
			this.m_DataGrid.AccessibleDescription = null;
			this.m_DataGrid.AccessibleName = null;
			this.m_DataGrid.AllowUserToAddRows = false;
			this.m_DataGrid.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.m_DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			resources.ApplyResources(this.m_DataGrid, "m_DataGrid");
			this.m_DataGrid.AutoGenerateColumns = false;
			this.m_DataGrid.BackgroundColor = System.Drawing.Color.DarkGray;
			this.m_DataGrid.BackgroundImage = null;
			this.m_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.m_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.m_DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.m_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_ColumnDay,
            this.m_ColumnInTime,
            this.m_ColumnOutTime,
            this.m_ColumnCategoryText,
            this.m_ColumnCategoryId,
            this.m_CoulmnInfo});
			this.m_DataGrid.ContextMenuStrip = this.m_ContextMenuStrip;
			this.m_DataGrid.DataSource = this.timeLogBindingSource;
			this.m_DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.m_DataGrid.Font = null;
			this.m_DataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
			this.m_DataGrid.Name = "m_DataGrid";
			this.m_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.m_DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkRed;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.m_DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.m_DataGrid.RowTemplate.Height = 30;
			this.m_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.m_DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_DataGrid_CellValueChanged);
			this.m_DataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGrid_DataError);
			// 
			// m_ContextMenuStrip
			// 
			this.m_ContextMenuStrip.AccessibleDescription = null;
			this.m_ContextMenuStrip.AccessibleName = null;
			resources.ApplyResources(this.m_ContextMenuStrip, "m_ContextMenuStrip");
			this.m_ContextMenuStrip.BackgroundImage = null;
			this.m_ContextMenuStrip.Font = null;
			this.m_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_DeleteSelectedRowToolStripMenuItem});
			this.m_ContextMenuStrip.Name = "m_ContextMenuStrip";
			this.m_ContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
			// 
			// m_DeleteSelectedRowToolStripMenuItem
			// 
			this.m_DeleteSelectedRowToolStripMenuItem.AccessibleDescription = null;
			this.m_DeleteSelectedRowToolStripMenuItem.AccessibleName = null;
			resources.ApplyResources(this.m_DeleteSelectedRowToolStripMenuItem, "m_DeleteSelectedRowToolStripMenuItem");
			this.m_DeleteSelectedRowToolStripMenuItem.BackgroundImage = null;
			this.m_DeleteSelectedRowToolStripMenuItem.Name = "m_DeleteSelectedRowToolStripMenuItem";
			this.m_DeleteSelectedRowToolStripMenuItem.ShortcutKeyDisplayString = null;
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
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "dddd dd";
			dataGridViewCellStyle3.NullValue = null;
			this.m_ColumnDay.DefaultCellStyle = dataGridViewCellStyle3;
			this.m_ColumnDay.FillWeight = 120F;
			resources.ApplyResources(this.m_ColumnDay, "m_ColumnDay");
			this.m_ColumnDay.Name = "m_ColumnDay";
			this.m_ColumnDay.ReadOnly = true;
			// 
			// m_ColumnInTime
			// 
			this.m_ColumnInTime.DataPropertyName = "InTime";
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "t";
			dataGridViewCellStyle4.NullValue = null;
			this.m_ColumnInTime.DefaultCellStyle = dataGridViewCellStyle4;
			this.m_ColumnInTime.FillWeight = 130F;
			resources.ApplyResources(this.m_ColumnInTime, "m_ColumnInTime");
			this.m_ColumnInTime.Name = "m_ColumnInTime";
			// 
			// m_ColumnOutTime
			// 
			this.m_ColumnOutTime.DataPropertyName = "OutTime";
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.Format = "t";
			dataGridViewCellStyle5.NullValue = null;
			this.m_ColumnOutTime.DefaultCellStyle = dataGridViewCellStyle5;
			this.m_ColumnOutTime.FillWeight = 130F;
			resources.ApplyResources(this.m_ColumnOutTime, "m_ColumnOutTime");
			this.m_ColumnOutTime.Name = "m_ColumnOutTime";
			// 
			// m_ColumnCategoryText
			// 
			this.m_ColumnCategoryText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.m_ColumnCategoryText.DataPropertyName = "CategoryText";
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_ColumnCategoryText.DefaultCellStyle = dataGridViewCellStyle6;
			resources.ApplyResources(this.m_ColumnCategoryText, "m_ColumnCategoryText");
			this.m_ColumnCategoryText.Name = "m_ColumnCategoryText";
			this.m_ColumnCategoryText.ReadOnly = true;
			// 
			// m_ColumnCategoryId
			// 
			this.m_ColumnCategoryId.DataPropertyName = "CategoryId";
			resources.ApplyResources(this.m_ColumnCategoryId, "m_ColumnCategoryId");
			this.m_ColumnCategoryId.Name = "m_ColumnCategoryId";
			// 
			// m_CoulmnInfo
			// 
			this.m_CoulmnInfo.DataPropertyName = "Info";
			resources.ApplyResources(this.m_CoulmnInfo, "m_CoulmnInfo");
			this.m_CoulmnInfo.Name = "m_CoulmnInfo";
			// 
			// DataGridViewToday
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.BackgroundImage = null;
			this.Controls.Add(this.m_DataGrid);
			this.Font = null;
			this.Name = "DataGridViewToday";
			((System.ComponentModel.ISupportInitialize)(this.m_DataGrid)).EndInit();
			this.m_ContextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeLogBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeLogDataSet)).EndInit();
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
 

		private void m_DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			OnTimeLogChange();
		}


		#region ILocalizableControl Members

		public void ChangeLanguage()
		{
			try
			{
				ComponentResourceManager resources = new ComponentResourceManager(typeof(DataGridViewToday));
				resources.ApplyResources(this.m_DeleteSelectedRowToolStripMenuItem, "m_DeleteSelectedRowToolStripMenuItem");
				resources.ApplyResources(this.m_ColumnDay, "m_ColumnDay");
				resources.ApplyResources(this.m_ColumnInTime, "m_ColumnInTime");
				resources.ApplyResources(this.m_ColumnOutTime, "m_ColumnOutTime");
				resources.ApplyResources(this.m_ColumnCategoryText, "m_ColumnCategoryText");
				resources.ApplyResources(this.m_CoulmnInfo, "m_CoulmnInfo");
			}
			catch { }
		}

		#endregion
	}
}
