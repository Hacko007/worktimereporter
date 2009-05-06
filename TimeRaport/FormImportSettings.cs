using System;
using System.Windows.Forms;

namespace Hackovic.TimeReport
{
	public partial class FormImportSettings : Form
	{
		public FormImportSettings()
		{
			InitializeComponent();
			DistinctDateSetting = DistinctDateSetting.NewRowOverwritesOld;
		}

		public DistinctDateSetting DistinctDateSetting { get; set; }

		private void buttonOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void radioButtonImportPrio_CheckedChanged(object sender, EventArgs e)
		{
			DistinctDateSetting = DistinctDateSetting.NewRowOverwritesOld;
		}

		private void radioButtonCurrentPrio_CheckedChanged(object sender, EventArgs e)
		{
			DistinctDateSetting = DistinctDateSetting.IgnoreNew;

		}

		private void radioButtonBoth_CheckedChanged(object sender, EventArgs e)
		{
			DistinctDateSetting = DistinctDateSetting.CreateNewRow;
		}
	}

}
