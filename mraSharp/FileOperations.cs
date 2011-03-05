using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mraSharp
{
	class FileOperations
	{
		public static void backupMangaList(DataStoreDataSet dataSetToBackup, string fileName)
		{
			try
			{
				if (!String.IsNullOrEmpty(fileName))
				{
					dataSetToBackup.WriteXml(fileName);
				}
			}
			catch(Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}
		public static void restoreMangaList(string fileName, ref DataStoreDataSet dataSetToRestore)
		{
			try
			{
				if (!String.IsNullOrEmpty(fileName))
				{
					dataSetToRestore.ReadXml(fileName);
				}
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}
	}
}
