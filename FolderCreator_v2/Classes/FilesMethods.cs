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
			using (StreamWriter sw = new StreamWriter(path))
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
			if (FileExists(path))
			{
				using (StreamReader sr = new StreamReader(path))
				{
					data = sr.ReadLine();
				}
			}

			return data;
		}

		public string[] GetAllFilesInnerDirectory(string path)
		{
			return Directory.GetFiles(path);
		}

		public string GetFileNameWithoutExtension(string path)
		{
			return Path.GetFileNameWithoutExtension(path);
		}

		public string GetFileWithExtension(string file)
		{
			return Path.GetFileName(file);
		}

		public void MoveFileToFolder(string file, string path)
		{
			File.Move(file, path);
		}

		public void CopyFile(string originalFilePath, string copyFilePath)
		{
			File.Copy(originalFilePath, copyFilePath);
		}

		public void WriteText(string path, List<string> lines)
		{
			using (StreamWriter sw = new StreamWriter(path))
			{
				int i = 1;
				foreach (string s in lines)
				{
					string currnetLine = ((i < 10) ? "0" + i : i.ToString());
					sw.WriteLine(string.Format("{0} - {1}", currnetLine, s));
					i++;
				}
			}
		}
	}
}
