﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace mraSharp
{
	class Logger
	{
		/// <summary>
		/// This methods logs every runtime error at the specied file.
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="errorText">The error text.</param>
		public static void errorLogger(string fileName, string errorText)
		{
			Stream stream = null;
			try
			{
				stream = new FileStream(fileName, FileMode.Append);
				using (StreamWriter fW = new StreamWriter(stream))
				{
					fW.WriteLine(DateTime.Now.ToString() + "\n");
					fW.Write(errorText);
					fW.WriteLine("\n");
					stream = null;
				}
			}
			catch (Exception ex)
			{
				throw;
			}

		}
	}
}


