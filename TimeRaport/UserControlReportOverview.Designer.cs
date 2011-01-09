namespace Hackovic.TimeReport
{
    partial class UserControlReportOverview
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.m_ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TimeLogDataSet = new Hackovic.TimeReport.TimeLogDataSet();
            this.TimeLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TimeLogTableAdapter = new Hackovic.TimeReport.TimeLogDataSetTableAdapters.TimeLogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ReportViewer
            // 
            this.m_ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TimeLogDataSet_TimeLog";
            reportDataSource1.Value = this.TimeLogBindingSource;
            this.m_ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.m_ReportViewer.LocalReport.ReportEmbeddedResource = "Hackovic.TimeReport.Reports.ReportMonth.rdlc";
            this.m_ReportViewer.Location = new System.Drawing.Point(0, 0);
            this.m_ReportViewer.Name = "m_ReportViewer";
            this.m_ReportViewer.Size = new System.Drawing.Size(887, 440);
            this.m_ReportViewer.TabIndex = 0;
            // 
            // TimeLogDataSet
            // 
            this.TimeLogDataSet.DataSetName = "TimeLogDataSet";
            this.TimeLogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TimeLogBindingSource
            // 
            this.TimeLogBindingSource.DataMember = "TimeLog";
            this.TimeLogBindingSource.DataSource = this.TimeLogDataSet;
            // 
            // TimeLogTableAdapter
            // 
            this.TimeLogTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlReportOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_ReportViewer);
            this.Name = "UserControlReportOverview";
            this.Size = new System.Drawing.Size(887, 440);
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer m_ReportViewer;
        private System.Windows.Forms.BindingSource TimeLogBindingSource;
        private TimeLogDataSet TimeLogDataSet;
        private Hackovic.TimeReport.TimeLogDataSetTableAdapters.TimeLogTableAdapter TimeLogTableAdapter;
    }
}
