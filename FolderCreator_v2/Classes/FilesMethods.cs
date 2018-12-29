using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderCreator_v2.Classes
{
	public class FilesMethods
	{
		public FilesMethods()
		{

		}

		public bool DirectoryExists(string dir)
		{
			return Directory.Exists(dir);
		}

		public bool FileExists(string file)
		{
			return File.Exists(file);
		}

		public void CreateFolder(string folderPath)
		{
			Directory.CreateDirectory(folderPath);
		}

		public void CreateExtensionFileData(string path, string[] data)
		{
			using (StreamWriter sw = new StreamWriter(path, true))
			{
				foreach (string s in data)
				{
					sw.Write(string.Format("{0}|", s));
				}
			}
		}

		public string GetFileData(string path)
		{
			string data = "";

			using (StreamReader sr = new StreamReader(path))
			{
				data = sr.ReadLine();
			}

			return data;
		}
	}
}
