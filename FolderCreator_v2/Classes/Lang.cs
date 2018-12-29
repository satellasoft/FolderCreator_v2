using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCreator_v2.Classes
{
	public class Lang
	{
		private string fileName;
		private string[] texts;

		public Lang()
		{
			this.FileName = "Language.txt";
			Texts = new string[] {
				"Check All",
				"Uncheck All",
				"Move files to folder",
				"Invalid Folder",//Using in Alert
				//Menu Strip
				"File",
				"Extension files",
				"About",
				"Exit",
				 //Using on frmExtension
				"The extent already in the list",//8
				"Extension File",//9
				"Invalid extension", //10
				//
				"No files found based on extensions",//11
			};
		}

		public string FileName { get => fileName; set => fileName = value; }
		public string[] Texts { get => texts; set => texts = value; }
	}
}
