using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCreator_v2.Forms
{
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
		}

		private void tslSiteGunnar_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.gunnarcorrea.com");
		}

		private void tslSiteSatellaSoft_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.satellasoft.com");
		}
	}
}
