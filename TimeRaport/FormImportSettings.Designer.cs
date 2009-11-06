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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportSettings));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.radioButtonBoth = new System.Windows.Forms.RadioButton();
			this.radioButtonCurrentPrio = new System.Windows.Forms.RadioButton();
			this.radioButtonImportPrio = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonOK);
			this.groupBox1.Controls.Add(this.radioButtonBoth);
			this.groupBox1.Controls.Add(this.radioButtonCurrentPrio);
			this.groupBox1.Controls.Add(this.radioButtonImportPrio);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// radioButtonBoth
			// 
			resources.ApplyResources(this.radioButtonBoth, "radioButtonBoth");
			this.radioButtonBoth.Name = "radioButtonBoth";
			this.radioButtonBoth.UseVisualStyleBackColor = true;
			this.radioButtonBoth.CheckedChanged += new System.EventHandler(this.radioButtonBoth_CheckedChanged);
			// 
			// radioButtonCurrentPrio
			// 
			resources.ApplyResources(this.radioButtonCurrentPrio, "radioButtonCurrentPrio");
			this.radioButtonCurrentPrio.Name = "radioButtonCurrentPrio";
			this.radioButtonCurrentPrio.UseVisualStyleBackColor = true;
			this.radioButtonCurrentPrio.CheckedChanged += new System.EventHandler(this.radioButtonCurrentPrio_CheckedChanged);
			// 
			// radioButtonImportPrio
			// 
			resources.ApplyResources(this.radioButtonImportPrio, "radioButtonImportPrio");
			this.radioButtonImportPrio.Checked = true;
			this.radioButtonImportPrio.Name = "radioButtonImportPrio";
			this.radioButtonImportPrio.TabStop = true;
			this.radioButtonImportPrio.UseVisualStyleBackColor = true;
			this.radioButtonImportPrio.CheckedChanged += new System.EventHandler(this.radioButtonImportPrio_CheckedChanged);
			// 
			// FormImportSettings
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormImportSettings";
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