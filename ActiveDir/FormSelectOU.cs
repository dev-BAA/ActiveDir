using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveDir
{
	public partial class FormSelectOU : Form
    {
		public FormSelectOU()
        {
			InitializeComponent();
        }
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (FormSettings._ouType == "userOU")
            {
				Properties.Settings.Default.fullUserPathAD = adPicker1.ADsPath;
				Properties.Settings.Default.Save();
				this.Close();
			}
			if (FormSettings._ouType == "gpoOUuser")
			{
				Properties.Settings.Default.fullFolderPathAD = adPicker1.ADsPath;
				Properties.Settings.Default.Save();
				this.Close();
			}
			if (FormSettings._ouType == "gpoOUgpo")
			{
				Properties.Settings.Default.fullFolderPathGPO = adPicker1.ADsPath;
				Properties.Settings.Default.Save();
				this.Close();
			}

		}
	}
}
