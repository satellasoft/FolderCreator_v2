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
				"Invalid Folder"
			};
		}

		public string FileName { get => fileName; set => fileName = value; }
		public string[] Texts { get => texts; set => texts = value; }
	}
}
