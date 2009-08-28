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
			this.DigitalClock_contextMenuStrip.Size = new System.Drawing.Size(261, 58);
			this.DigitalClock_contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.DigitalClock_contextMenuStrip_Opening);
			// 
			// toolStripTextBox_DateTimeFormat
			// 
			this.toolStripTextBox_DateTimeFormat.AutoCompleteCustomSource.AddRange(new string[] {
            "HH:mm",
            "HH:mm:ss",
            "yyyy-MM-dd",
            "yyyy-MM-dd  HH:mm",
            "yyyy-MM-dd  HH:mm:ss",
            "d MMM yyyy"});
			this.toolStripTextBox_DateTimeFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.toolStripTextBox_DateTimeFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.toolStripTextBox_DateTimeFormat.Name = "toolStripTextBox_DateTimeFormat";
			this.toolStripTextBox_DateTimeFormat.Size = new System.Drawing.Size(200, 21);
			this.toolStripTextBox_DateTimeFormat.Text = "Time Format";
			this.toolStripTextBox_DateTimeFormat.ToolTipText = "DateTime Format";
			this.toolStripTextBox_DateTimeFormat.TextChanged += new System.EventHandler(this.toolStripTextBox_DateTimeFormat_TextChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
			// 
			// toolStripComboBox_Style
			// 
			this.toolStripComboBox_Style.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.toolStripComboBox_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox_Style.Items.AddRange(new object[] {
            "Simple",
            "Full",
            "Image"});
			this.toolStripComboBox_Style.Name = "toolStripComboBox_Style";
			this.toolStripComboBox_Style.Size = new System.Drawing.Size(200, 21);
			// 
			// DigitalClock
			// 
			//this.Paint += new System.Windows.Forms.PaintEventHandler(this.DigitalClock_Paint);
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
