using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCreator_v2.Classes
{
	public class FileAnotherFiles
	{
		private string fileName;

		public FileAnotherFiles()
		{
			this.fileName = "AnotherFiles.txt";
		}

		public string FileName { get => fileName; set => fileName = value; }
	}
}
