namespace Hackovic.TimeReport
{
	partial class FormImportSettings
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonImportPrio = new System.Windows.Forms.RadioButton();
			this.radioButtonCurrentPrio = new System.Windows.Forms.RadioButton();
			this.radioButtonBoth = new System.Windows.Forms.RadioButton();
			this.buttonOK = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonOK);
			this.groupBox1.Controls.Add(this.radioButtonBoth);
			this.groupBox1.Controls.Add(this.radioButtonCurrentPrio);
			this.groupBox1.Controls.Add(this.radioButtonImportPrio);
			this.groupBox1.Location = new System.Drawing.Point(8, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(286, 123);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vad ska man göra med samma datum";
			// 
			// radioButtonImportPrio
			// 
			this.radioButtonImportPrio.AutoSize = true;
			this.radioButtonImportPrio.Checked = true;
			this.radioButtonImportPrio.Location = new System.Drawing.Point(6, 28);
			this.radioButtonImportPrio.Name = "radioButtonImportPrio";
			this.radioButtonImportPrio.Size = new System.Drawing.Size(196, 17);
			this.radioButtonImportPrio.TabIndex = 0;
			this.radioButtonImportPrio.TabStop = true;
			this.radioButtonImportPrio.Text = "Ta importerade (skriv över befintliga)";
			this.radioButtonImportPrio.UseVisualStyleBackColor = true;
			this.radioButtonImportPrio.CheckedChanged += new System.EventHandler(this.radioButtonImportPrio_CheckedChanged);
			// 
			// radioButtonCurrentPrio
			// 
			this.radioButtonCurrentPrio.AutoSize = true;
			this.radioButtonCurrentPrio.Location = new System.Drawing.Point(6, 53);
			this.radioButtonCurrentPrio.Name = "radioButtonCurrentPrio";
			this.radioButtonCurrentPrio.Size = new System.Drawing.Size(122, 17);
			this.radioButtonCurrentPrio.TabIndex = 1;
			this.radioButtonCurrentPrio.Text = "Ignorera importerade";
			this.radioButtonCurrentPrio.UseVisualStyleBackColor = true;
			this.radioButtonCurrentPrio.CheckedChanged += new System.EventHandler(this.radioButtonCurrentPrio_CheckedChanged);
			// 
			// radioButtonBoth
			// 
			this.radioButtonBoth.AutoSize = true;
			this.radioButtonBoth.Location = new System.Drawing.Point(6, 78);
			this.radioButtonBoth.Name = "radioButtonBoth";
			this.radioButtonBoth.Size = new System.Drawing.Size(99, 17);
			this.radioButtonBoth.TabIndex = 2;
			this.radioButtonBoth.Text = "Behåll båda två";
			this.radioButtonBoth.UseVisualStyleBackColor = true;
			this.radioButtonBoth.CheckedChanged += new System.EventHandler(this.radioButtonBoth_CheckedChanged);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(194, 78);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// FormImportSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 142);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormImportSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonBoth;
		private System.Windows.Forms.RadioButton radioButtonCurrentPrio;
		private System.Windows.Forms.RadioButton radioButtonImportPrio;
		private System.Windows.Forms.Button buttonOK;
	}
}