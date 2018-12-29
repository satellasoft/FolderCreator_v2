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
	public partial class frmExtensionFiles : Form
	{
		private FilesMethods fileMethods;
		private Config config;
		private string[] texts;
		private string[] extensions;

		public frmExtensionFiles()
		{
			InitializeComponent();

			this.fileMethods = new FilesMethods();
			this.config = new Config();
			texts = this.config.GetLanguages();
			this.extensions = this.config.GetExtensions();
			this.Text = texts[9];

			FillList();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtExtension.Text.Trim().Length > 0)
			{
				if (!CheckExtensionExistsInList(txtExtension.Text))
				{
					listExtension.Items.Add(txtExtension.Text.ToLower());
					txtExtension.Text = ".";
				}
				else
				{
					MessageBox.Show(this.texts[8], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show(this.texts[10], "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private bool CheckExtensionExistsInList(string ex)
		{
			foreach (string s in this.listExtension.Items)
			{
				if (s == ex.ToLower())
					return true;
			}

			return false;
		}

		private void FillList()
		{

			if (this.extensions == null) {
				return;
			}

			foreach (string s in this.extensions)
			{
				if (s.Trim().Length > 0)
					listExtension.Items.Add(s);
			}
		}

		private void listExtension_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				listExtension.Items.Remove(listExtension.SelectedItem);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string[] data = this.listExtension.Items.OfType<string>().ToArray();
			this.Close();
			config.SaveExtensions(data);
		}

		private void listExtension_MouseHover(object sender, EventArgs e)
		{
		}
	}
}
