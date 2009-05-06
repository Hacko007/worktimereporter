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
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(404, 255);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lägg till ledig dag";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(306, 212);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Ångra";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(200, 212);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(100, 23);
			this.buttonOK.TabIndex = 9;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(269, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "tim.";
			// 
			// m_numericUpDownToWork
			// 
			this.m_numericUpDownToWork.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.m_numericUpDownToWork.Location = new System.Drawing.Point(200, 169);
			this.m_numericUpDownToWork.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
			this.m_numericUpDownToWork.Name = "m_numericUpDownToWork";
			this.m_numericUpDownToWork.Size = new System.Drawing.Size(63, 20);
			this.m_numericUpDownToWork.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Att jobba denna dag";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(197, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Info";
			// 
			// m_textBoxInfo
			// 
			this.m_textBoxInfo.Location = new System.Drawing.Point(200, 90);
			this.m_textBoxInfo.Multiline = true;
			this.m_textBoxInfo.Name = "m_textBoxInfo";
			this.m_textBoxInfo.Size = new System.Drawing.Size(169, 49);
			this.m_textBoxInfo.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(197, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Namn";
			// 
			// m_textBoxName
			// 
			this.m_textBoxName.Location = new System.Drawing.Point(200, 39);
			this.m_textBoxName.Name = "m_textBoxName";
			this.m_textBoxName.Size = new System.Drawing.Size(169, 20);
			this.m_textBoxName.TabIndex = 1;
			// 
			// m_MonthCalendar
			// 
			this.m_MonthCalendar.Location = new System.Drawing.Point(12, 25);
			this.m_MonthCalendar.Name = "m_MonthCalendar";
			this.m_MonthCalendar.TabIndex = 0;
			// 
			// FormAddHolyday
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 265);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddHolyday";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Lägg till ";
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
