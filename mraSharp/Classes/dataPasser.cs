using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mraSharp
{
	class dataPasser
	{
		private MainForm _form;
		private string _filePath;

		public dataPasser(MainForm form, string filepath)
		{
			_form = form;
			_filePath = filepath;
		}
		public MainForm Form
		{
			get { return _form; }
			set { _form = value; }
		}

		public string FilePath
		{
			get { return _filePath; }
			set { _filePath = value; }
		}
	}
}
