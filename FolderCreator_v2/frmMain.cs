using FolderCreator_v2.Classes;
using FolderCreator_v2.Forms;
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
		#region "Variables"
		private FilesMethods fileMethods;
		private FileConfig config;
		private string[] texts;
		#endregion

		public frmMain()
		{
			InitializeComponent();
			this.fileMethods = new FilesMethods();
			this.config = new FileConfig();
			texts = this.config.GetLanguages();
			TranslateElements();
		}

		private void TranslateElements()
		{
			btnCheckAll.Text = texts[0];
			btnUncheckAll.Text = texts[1];
			ckMoveFiles.Text = texts[2];

			//Menu Strip
			topMenuFile.Text = texts[4];
			topMenuExtensionFiles.Text = texts[5];
			topMenuAbout.Text = texts[6];
			topMenuExit.Text = texts[7];
			topMenuAnotherFiles.Text = texts[12];
		}

		private void btnFindFolder_Click(object sender, EventArgs e)
		{
			txtFolderPath.Enabled = true;
			btnList.Enabled = true;

			using (FolderBrowserDialog fbd = new FolderBrowserDialog())
			{
				if (fbd.ShowDialog() == DialogResult.OK)
				{
					txtFolderPath.Text = fbd.SelectedPath;
					ListFilesDirectory(txtFolderPath.Text);
				}
			}
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			string path = txtFolderPath.Text;
			if (path.Trim().Length > 0 && fileMethods.DirectoryExists(path))
			{
				ListFilesDirectory(path);
			}
			else
			{
				MessageBox.Show(this.texts[3], "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ListFilesDirectory(string path)
		{
			List<string> listFiles = this.config.GetAllFilesExtensions(path);

			if (listFiles != null && listFiles.Count > 0)
			{
				txtFolderPath.Enabled = false;
				btnList.Enabled = false;
				clbFiles.Items.Clear();

				foreach (string s in listFiles)
				{
					clbFiles.Items.Add(s.Replace(path, "..."));
				}
			}
			else
			{
				MessageBox.Show(this.texts[11], "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void topMenuExtensionFiles_Click(object sender, EventArgs e)
		{
			new frmExtensionFiles().ShowDialog();
		}

		private void topMenuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCheckAll_Click(object sender, EventArgs e)
		{
			if (clbFiles.Items.Count > 0)
				for (int i = 0; i < clbFiles.Items.Count; i++)
				{
					clbFiles.SetItemChecked(i, true);
				}
		}

		private void btnUncheckAll_Click(object sender, EventArgs e)
		{
			if (clbFiles.Items.Count > 0)
				for (int i = 0; i < clbFiles.Items.Count; i++)
				{
					clbFiles.SetItemChecked(i, false);
				}
		}

		private void topMenuAbout_Click(object sender, EventArgs e)
		{
			new frmAbout().ShowDialog();
		}

		private void topMenuAnotherFiles_Click(object sender, EventArgs e)
		{
			new frmAnotherFiles().ShowDialog();
		}
	}
}
