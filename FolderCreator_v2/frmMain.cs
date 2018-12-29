using FolderCreator_v2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCreator_v2
{
	public partial class frmMain : Form
	{
		private FilesMethods fileMethods;
		private Config config;
		private string[] texts;

		public frmMain()
		{
			InitializeComponent();
			this.fileMethods = new FilesMethods();
			this.config = new Config();
			texts = this.config.GetLanguages();
			TranslateElements();
		}

		private void TranslateElements()
		{
			btnCheckAll.Text = texts[0];
			btnUncheckAll.Text = texts[1];
			ckMoveFiles.Text = texts[2];
		}

		private void btnFindFolder_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					txtFolderPath.Text = fbd.SelectedPath;
				}
			}
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			if (txtFolderPath.Text.Trim().Length > 0 && fileMethods.DirectoryExists(txtFolderPath.Text))
			{
				txtFolderPath.Enabled = false;
				btnList.Enabled = false;

				MessageBox.Show("Exists");
			}
			else
			{
				MessageBox.Show(this.texts[3], "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
