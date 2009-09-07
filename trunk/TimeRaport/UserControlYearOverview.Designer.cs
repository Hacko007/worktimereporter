using Hackovic.FreshUserControls;
namespace Hackovic.TimeReport
{
	partial class UserControlYearOverview
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
			this.m_MonthCalendar = new System.Windows.Forms.MonthCalendar();
			this.ButtonExport = new Hackovic.FreshUserControls.ColorButton();
			this.ButtonImp = new Hackovic.FreshUserControls.ColorButton();
			this.buttonAddHolyday = new Hackovic.FreshUserControls.ColorButton();
			this.m_DataGridView = new System.Windows.Forms.DataGridView();
			this.m_LabelHolydays = new System.Windows.Forms.Label();
			this.m_OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.m_SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.m_ColorPanel = new Hackovic.FreshUserControls.ColorPanel();
			this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).BeginInit();
			this.m_ColorPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_MonthCalendar
			// 
			this.m_MonthCalendar.BackColor = System.Drawing.Color.AntiqueWhite;
			this.m_MonthCalendar.CalendarDimensions = new System.Drawing.Size(3, 4);
			this.m_MonthCalendar.Location = new System.Drawing.Point(4, 4);
			this.m_MonthCalendar.Name = "m_MonthCalendar";
			this.m_MonthCalendar.ShowWeekNumbers = true;
			this.m_MonthCalendar.TabIndex = 0;
			this.m_MonthCalendar.TitleBackColor = System.Drawing.Color.SaddleBrown;
			this.m_MonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.m_MonthCalendar_DateSelected);
			// 
			// ButtonExport
			// 
			this.ButtonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonExport.BgColor1 = System.Drawing.Color.BurlyWood;
			this.ButtonExport.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.ButtonExport.FgColor1 = System.Drawing.Color.White;
			this.ButtonExport.FgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ButtonExport.Location = new System.Drawing.Point(788, 4);
			this.ButtonExport.Name = "ButtonExport";
			this.ButtonExport.Size = new System.Drawing.Size(75, 23);
			this.ButtonExport.TabIndex = 4;
			this.ButtonExport.Text = "Exportera";
			this.ButtonExport.TextHasShadow = false;
			this.ButtonExport.TextShadowColor = System.Drawing.Color.Empty;
			this.ButtonExport.UseVisualStyleBackColor = true;
			this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
			// 
			// ButtonImp
			// 
			this.ButtonImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonImp.BgColor1 = System.Drawing.Color.BurlyWood;
			this.ButtonImp.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.ButtonImp.FgColor1 = System.Drawing.Color.White;
			this.ButtonImp.FgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ButtonImp.Location = new System.Drawing.Point(720, 4);
			this.ButtonImp.Name = "ButtonImp";
			this.ButtonImp.Size = new System.Drawing.Size(62, 23);
			this.ButtonImp.TabIndex = 3;
			this.ButtonImp.Text = "Importera";
			this.ButtonImp.TextHasShadow = false;
			this.ButtonImp.TextShadowColor = System.Drawing.Color.Empty;
			this.ButtonImp.UseVisualStyleBackColor = true;
			this.ButtonImp.Click += new System.EventHandler(this.ButtonImp_Click);
			// 
			// buttonAddHolyday
			// 
			this.buttonAddHolyday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddHolyday.BgColor1 = System.Drawing.Color.BurlyWood;
			this.buttonAddHolyday.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.buttonAddHolyday.FgColor1 = System.Drawing.Color.White;
			this.buttonAddHolyday.FgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.buttonAddHolyday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddHolyday.Location = new System.Drawing.Point(632, 4);
			this.buttonAddHolyday.Name = "buttonAddHolyday";
			this.buttonAddHolyday.Size = new System.Drawing.Size(82, 23);
			this.buttonAddHolyday.TabIndex = 2;
			this.buttonAddHolyday.Text = "+";
			this.buttonAddHolyday.TextHasShadow = false;
			this.buttonAddHolyday.TextShadowColor = System.Drawing.Color.Empty;
			this.buttonAddHolyday.UseVisualStyleBackColor = true;
			this.buttonAddHolyday.Click += new System.EventHandler(this.buttonAddHolyday_Click);
			// 
			// m_DataGridView
			// 
			this.m_DataGridView.AllowUserToAddRows = false;
			this.m_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.m_DataGridView.Location = new System.Drawing.Point(519, 33);
			this.m_DataGridView.Name = "m_DataGridView";
			this.m_DataGridView.Size = new System.Drawing.Size(344, 552);
			this.m_DataGridView.TabIndex = 0;
			this.m_DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			this.m_DataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.m_DataGridView_RowsRemoved);
			// 
			// m_LabelHolydays
			// 
			this.m_LabelHolydays.AutoSize = true;
			this.m_LabelHolydays.BackColor = System.Drawing.Color.Transparent;
			this.m_LabelHolydays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_LabelHolydays.ForeColor = System.Drawing.Color.Maroon;
			this.m_LabelHolydays.Location = new System.Drawing.Point(515, 7);
			this.m_LabelHolydays.Name = "m_LabelHolydays";
			this.m_LabelHolydays.Size = new System.Drawing.Size(103, 20);
			this.m_LabelHolydays.TabIndex = 1;
			this.m_LabelHolydays.Text = "Röda dagar";
			// 
			// m_OpenFileDialog
			// 
			this.m_OpenFileDialog.DefaultExt = "xml";
			this.m_OpenFileDialog.Filter = "XML filer|*.xml";
			this.m_OpenFileDialog.Title = "Importera XML";
			// 
			// m_SaveFileDialog
			// 
			this.m_SaveFileDialog.DefaultExt = "xml";
			this.m_SaveFileDialog.Filter = "XML filer|*.xml";
			this.m_SaveFileDialog.Title = "Spara XML";
			// 
			// m_ColorPanel
			// 
			this.m_ColorPanel.BgColor1 = System.Drawing.Color.BurlyWood;
			this.m_ColorPanel.BgColor2 = System.Drawing.Color.SaddleBrown;
			this.m_ColorPanel.Controls.Add(this.m_DataGridView);
			this.m_ColorPanel.Controls.Add(this.ButtonExport);
			this.m_ColorPanel.Controls.Add(this.m_LabelHolydays);
			this.m_ColorPanel.Controls.Add(this.ButtonImp);
			this.m_ColorPanel.Controls.Add(this.buttonAddHolyday);
			this.m_ColorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_ColorPanel.Location = new System.Drawing.Point(0, 0);
			this.m_ColorPanel.Name = "m_ColorPanel";
			this.m_ColorPanel.Size = new System.Drawing.Size(866, 602);
			this.m_ColorPanel.TabIndex = 2;
			// 
			// UserControlYearOverview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.m_MonthCalendar);
			this.Controls.Add(this.m_ColorPanel);
			this.Name = "UserControlYearOverview";
			this.Size = new System.Drawing.Size(866, 602);
			this.Load += new System.EventHandler(this.UserControlYearOverview_Load);
			((System.ComponentModel.ISupportInitialize)(this.m_DataGridView)).EndInit();
			this.m_ColorPanel.ResumeLayout(false);
			this.m_ColorPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MonthCalendar m_MonthCalendar;
		private System.Windows.Forms.Label m_LabelHolydays;
		private System.Windows.Forms.DataGridView m_DataGridView;
		private ColorButton buttonAddHolyday;
		private ColorButton ButtonExport;
		private ColorButton ButtonImp;
		private System.Windows.Forms.OpenFileDialog m_OpenFileDialog;
		private System.Windows.Forms.SaveFileDialog m_SaveFileDialog;
		private Hackovic.FreshUserControls.ColorPanel m_ColorPanel;
		private System.Windows.Forms.ToolTip m_ToolTip;
	}
}
