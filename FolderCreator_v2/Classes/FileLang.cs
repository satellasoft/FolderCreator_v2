using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCreator_v2.Classes
{
	public class FileLang
	{
		private string fileName;
		private string[] texts;

		public FileLang()
		{
			this.FileName = "Language.txt";
			Texts = new string[] {
				"Check All",
				"Uncheck All",
				"Move files to folder",
				"Invalid Folder",
				"File",
				"Extension files",
				"About",
				"Exit",
				"The extent already in the list",
				"Extension File",
				"Invalid extension",
				"No files found based on extensions",
				"Another Files",
				"The selected file is already in the list",
				"Do you want to quit?",
				"No files are selected in the list",
				"All files have been moved", //16
			};
		}

		public string FileName { get => fileName; set => fileName = value; }
		public string[] Texts { get => texts; set => texts = value; }
	}
}
