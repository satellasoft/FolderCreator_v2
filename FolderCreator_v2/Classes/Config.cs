using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCreator_v2.Classes
{
	public class Config
	{
		#region "Variables"
		private string configPath;
		private Lang lang = new Lang();
		private FileExtension fileExtension = new FileExtension();
		private FilesMethods fileMethods = new FilesMethods();
		#endregion

		public Config()
		{
			this.configPath = "config/";
			this.CreateDefautConfigs();
		}

		#region "Create Configs"

		private void CreateDefautConfigs()
		{
			CreateConfigFolder();
			CreateExtensionFile();
			CreateLanguageFile();
		}

		private void CreateConfigFolder()
		{
			//Create config folder
			if (!fileMethods.DirectoryExists(this.configPath))
			{
				fileMethods.CreateFolder(this.configPath);
			}
		}

		private void CreateExtensionFile()
		{
			string path = string.Format("{0}/{1}", this.configPath, this.fileExtension.FileName);
			if (!fileMethods.FileExists(path))
			{
				fileMethods.CreateExtensionFileData(path, fileExtension.DefaultExtension);
			}
		}

		private void CreateLanguageFile()
		{
			string path = string.Format("{0}/{1}", this.configPath, this.lang.FileName);
			if (!fileMethods.FileExists(path))
			{
				fileMethods.CreateExtensionFileData(path, lang.Texts);
			}
		}
		#endregion

		public string[] GetLanguages()
		{
			string path = string.Format("{0}/{1}", this.configPath, this.lang.FileName);

			return this.fileMethods.GetFileData(path).Split('|');
		}

		public string[] GetExtensions()
		{
			string path = string.Format("{0}/{1}", this.configPath, this.fileExtension.FileName);
			string data = this.fileMethods.GetFileData(path);

			if (data != null)
			{
				return data.Split('|');
			}
			else
			{
				return null;
			}

		}

		public void SaveExtensions(string[] extensions)
		{
			string path = string.Format("{0}/{1}", this.configPath, this.fileExtension.FileName);
			this.fileMethods.CreateExtensionFileData(path, extensions);
		}

		public List<string> GetAllFilesExtensions(string path)
		{
			string[] extensions = this.GetExtensions();

			if (extensions != null && extensions.Length > 0)
			{
				List<string> files = new List<string>();

				foreach (string file in this.fileMethods.GetAllFilesInnerDirectory(path))
				{
					string ex = System.IO.Path.GetExtension(file);

					for (int i = 0; i < extensions.Length; i++)
					{
						if (ex == extensions[i])
							files.Add(file);
					}

				}

				return files;
			}
			else
			{
				return null;
			}
		}
	}
}
