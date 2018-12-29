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

namespace FolderCreator_v2.Forms
{
	public partial class frmAnotherFiles : Form
	{
		private FileConfig fileConfig;
		private string[] texts;
		private string[] anotherFiles;

		public frmAnotherFiles()
		{
			this.fileConfig = new FileConfig();
			InitializeComponent();
			texts = this.fileConfig.GetLanguages();
			this.anotherFiles = this.fileConfig.GetAnotherFiles();
			FillList();
		}

		private bool CheckExtensionExistsInList(string file)
		{
			foreach (string s in this.listAnotherFiles.Items)
			{
				if (s.ToLower() == file.ToLower())
					return true;
			}

			return false;
		}

		private void FillList()
		{

			if (this.anotherFiles == null)
			{
				return;
			}

			foreach (string s in this.anotherFiles)
			{
				if (s.Trim().Length > 0)
					listAnotherFiles.Items.Add(s);
			}
		}

		private void lbAnotherFiles_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				listAnotherFiles.Items.Remove(listAnotherFiles.SelectedItem);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string file = "";

			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					file = ofd.FileName;
				}
			}

			if (!CheckExtensionExistsInList(file))
			{
				listAnotherFiles.Items.Add(file);
			}
			else {
				MessageBox.Show(this.texts[13], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string[] data = listAnotherFiles.Items.OfType<string>().ToArray();
			this.fileConfig.SaveAnotherFiles(data);
			this.Close();
		}
	}
}
