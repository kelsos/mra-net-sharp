using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace mraSharp
{
	class Logger
	{
		public static void errorLogger(string fileName, string errorText)
		{
			Stream stream = null;
			try
			{
				stream = new FileStream(fileName, FileMode.OpenOrCreate);
				using (StreamWriter fW = new StreamWriter(stream))
				{
					fW.WriteLine(DateTime.Now.ToString() + "\n\n");
					fW.Write(errorText);
					fW.WriteLine("\n\n");
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


