using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCreator_v2.Classes
{
	public class FileExtension
	{
		private string fileName;
		private string[] defaultExtension;

		public FileExtension()
		{
			this.FileName = "Extension.txt";
			this.DefaultExtension = new string[2] {
				".mp4",
				".mp3"
			};
		}

		public string FileName { get => fileName; set => fileName = value; }
		public string[] DefaultExtension { get => defaultExtension; set => defaultExtension = value; }
	}
}
