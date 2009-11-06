namespace Hackovic.FreshUserControls
{
    partial class DigitalClock 
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalClock));
			this.Clock_timer = new System.Windows.Forms.Timer(this.components);
			this.DigitalClock_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripTextBox_DateTimeFormat = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox_Style = new System.Windows.Forms.ToolStripComboBox();
			this.DigitalClock_contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Clock_timer
			// 
			this.Clock_timer.Enabled = true;
			this.Clock_timer.Interval = 1000;
			this.Clock_timer.Tick += new System.EventHandler(this.Clock_timer_Tick);
			// 
			// DigitalClock_contextMenuStrip
			// 
			this.DigitalClock_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_DateTimeFormat,
            this.toolStripSeparator1,
            this.toolStripComboBox_Style});
			this.DigitalClock_contextMenuStrip.Name = "DigitalClock_contextMenuStrip";
			resources.ApplyResources(this.DigitalClock_contextMenuStrip, "DigitalClock_contextMenuStrip");
			this.DigitalClock_contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.DigitalClock_contextMenuStrip_Opening);
			// 
			// toolStripTextBox_DateTimeFormat
			// 
			this.toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource"),
            resources.GetString("toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource1"),
            resources.GetString("toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource2"),
            resources.GetString("toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource3"),
            resources.GetString("toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource4"),
            resources.GetString("toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource5")});
			this.toolStripTextBox_DateTimeFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.toolStripTextBox_DateTimeFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.toolStripTextBox_DateTimeFormat.Name = "toolStripTextBox_DateTimeFormat";
			resources.ApplyResources(this.toolStripTextBox_DateTimeFormat, "toolStripTextBox_DateTimeFormat");
			this.toolStripTextBox_DateTimeFormat.TextChanged += new System.EventHandler(this.toolStripTextBox_DateTimeFormat_TextChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// toolStripComboBox_Style
			// 
			this.toolStripComboBox_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.toolStripComboBox_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox_Style.Items.AddRange(new object[] {
            resources.GetString("toolStripComboBox_Style.Items"),
            resources.GetString("toolStripComboBox_Style.Items1"),
            resources.GetString("toolStripComboBox_Style.Items2")});
			this.toolStripComboBox_Style.Name = "toolStripComboBox_Style";
			resources.ApplyResources(this.toolStripComboBox_Style, "toolStripComboBox_Style");
			this.DigitalClock_contextMenuStrip.ResumeLayout(false);
			this.DigitalClock_contextMenuStrip.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Clock_timer;
        private System.Windows.Forms.ContextMenuStrip DigitalClock_contextMenuStrip;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_DateTimeFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Style;
    }
}
