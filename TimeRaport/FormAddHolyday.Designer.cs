namespace Hackovic.TimeReport
{
	partial class FormAddHolyday
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHolyday));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.m_numericUpDownToWork = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_textBoxInfo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_textBoxName = new System.Windows.Forms.TextBox();
			this.m_MonthCalendar = new System.Windows.Forms.MonthCalendar();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownToWork)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonCancel);
			this.groupBox1.Controls.Add(this.buttonOK);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.m_numericUpDownToWork);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.m_textBoxInfo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.m_textBoxName);
			this.groupBox1.Controls.Add(this.m_MonthCalendar);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// m_numericUpDownToWork
			// 
			this.m_numericUpDownToWork.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
			resources.ApplyResources(this.m_numericUpDownToWork, "m_numericUpDownToWork");
			this.m_numericUpDownToWork.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.m_numericUpDownToWork.Name = "m_numericUpDownToWork";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// m_textBoxInfo
			// 
			resources.ApplyResources(this.m_textBoxInfo, "m_textBoxInfo");
			this.m_textBoxInfo.Name = "m_textBoxInfo";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// m_textBoxName
			// 
			resources.ApplyResources(this.m_textBoxName, "m_textBoxName");
			this.m_textBoxName.Name = "m_textBoxName";
			// 
			// m_MonthCalendar
			// 
			resources.ApplyResources(this.m_MonthCalendar, "m_MonthCalendar");
			this.m_MonthCalendar.Name = "m_MonthCalendar";
			// 
			// FormAddHolyday
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddHolyday";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownToWork)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown m_numericUpDownToWork;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox m_textBoxInfo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_textBoxName;
		private System.Windows.Forms.MonthCalendar m_MonthCalendar;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label4;
	}
}
