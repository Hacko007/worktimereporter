using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Status;
namespace TimeReportMobile
{
	public partial class FormMain : Form
	{
		private SystemState m_DisplayRotation = new SystemState(SystemProperty.DisplayRotation);


		public FormMain()
		{
			InitializeComponent();
			m_DisplayRotation.Changed += new ChangeEventHandler(DisplayRotation_Changed);
			new SystemState(SystemProperty.Time);
		}

		void DisplayRotation_Changed(object sender, ChangeEventArgs args)
		{
			m_textBox.Text ="Rotation:"+ args.NewValue.ToString() ;
		}

		private void FormMain_KeyUp(object sender, KeyEventArgs e)
		{
			m_textBox.Text = e.ToString();
		}

		private void FormMain_MouseUp(object sender, MouseEventArgs e)
		{
			m_textBox.Text = e.ToString();
		}

		private void ButtonIn_Click(object sender, EventArgs e)
		{

			m_textBox.Text = Microsoft.WindowsMobile.Status.SystemState.DisplayRotation.ToString();
		}						
	}
}