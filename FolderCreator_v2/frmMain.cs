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
				clbFiles.Items.Clear();
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
			if (MessageBox.Show(texts[14], texts[7], MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
			{
				this.Close();
			}
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

		private void btnCreateFolders_Click(object sender, EventArgs e)
		{
			if (clbFiles.CheckedItems.Count <= 0)
			{
				MessageBox.Show(this.texts[15], "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			DisableControls(false);
			List<string> files = new List<string>();
			List<string> folders = new List<string>();

			foreach (string s in clbFiles.CheckedItems.OfType<string>().ToList())
			{
				files.Add(s.Replace("...", txtFolderPath.Text));
			}

			folders = CreateFolders(files);
			MoveFileToFolder(files);
			CopyAnotherFiles(folders);

			CreateLogFile(folders);
			DisableControls(true);
			ResetControls();

			MessageBox.Show(this.texts[16], "", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private List<string> CreateFolders(List<string> files)
		{
			List<string> temp = new List<string>();

			foreach (string s in files)
			{
				string fileName = fileMethods.GetFileNameWithoutExtension(s);
				temp.Add(fileName);
				string path = (string.Format("{0}/{1}", txtFolderPath.Text, fileMethods.GetFileNameWithoutExtension(s)));
				fileMethods.CreateFolder(path);
				//string newFilePath = string.Format("{0}/{1}", path, fileMethods.GetFileWithExtension(s));
				//fileMethods.MoveFileToFolder(s, newFilePath);
			}

			return temp;
		}

		private void MoveFileToFolder(List<string> files)
		{
			if (!ckMoveFiles.Checked)
				return;

			for (int i = 0; i < files.Count; i++)
			{
				string newFilePath = string.Format("{0}/{1}", txtFolderPath.Text, fileMethods.GetFileNameWithoutExtension(files[i]));
				fileMethods.MoveFileToFolder(files[i], string.Format("{0}/{1}", newFilePath, fileMethods.GetFileWithExtension(files[i])));
			}
		}

		private void CopyAnotherFiles(List<string> folder)
		{
			string[] anotherFiles = this.config.GetAnotherFiles();

			if (anotherFiles == null || anotherFiles.Length == 0)
			{
				return;
			}

			foreach (string s in folder)
			{
				for (int i = 0; i < anotherFiles.Length; i++)
				{
					if (anotherFiles[i] != "" && anotherFiles[i] != "|")
					{
						//fileMethods.CopyFile(anotherFiles[i], string.Format("{0}/{1}", string.Format("{0}/{1}", txtFolderPath.Text, s), fileMethods.GetFileWithExtension(anotherFiles[i])));
						string newPath = string.Format("{0}/{1}", txtFolderPath.Text, s);
						string fileName = fileMethods.GetFileWithExtension(anotherFiles[i]);
						string fullPath = string.Format("{0}/{1}", newPath, fileName);

						fileMethods.CopyFile(anotherFiles[i], fullPath);
					}
				}
			}

		}

		private void DisableControls(bool disable)
		{
			txtFolderPath.Enabled = disable;
			btnCheckAll.Enabled = disable;
			btnUncheckAll.Enabled = disable;
			btnList.Enabled = disable;
			btnFindFolder.Enabled = disable;
			clbFiles.Enabled = disable;
			ckMoveFiles.Enabled = disable;
			topMenuFile.Enabled = disable;
			btnCreateFolders.Enabled = disable;

			pbEffect.Visible = !disable;
		}

		private void CreateLogFile(List<string> files) {
			this.config.CreateLogFile(txtFolderPath.Text, files);
		}

		private void ResetControls()
		{
			clbFiles.Items.Clear();
			txtFolderPath.Text = string.Empty;
		}
	}
}
