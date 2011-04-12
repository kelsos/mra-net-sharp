using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace mraSharp
{
	class FileOperations
	{
		///// <summary>
		///// Backups the manga list.
		///// </summary>
		///// <param name="dataSetToBackup">The data set to backup.</param>
		///// <param name="fileName">Name of the file.</param>
		//public static void backupMangaList(DataStoreDataSet dataSetToBackup, string fileName)
		//{
		//   try
		//   {
		//      if (!String.IsNullOrEmpty(fileName))
		//      {
		//         dataSetToBackup.WriteXml(fileName);
		//      }
		//   }
		//   catch(Exception ex)
		//   {
		//      Logger.errorLogger("error.txt", ex.ToString());
		//   }
		//}

		/// <summary>
		/// Restores the manga list.
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="dataSetToRestore">The data set to restore.</param>
		//public static void restoreMangaList(string fileName, ref DataStoreDataSet dataSetToRestore)
		//{
		//   try
		//   {
		//      if (!String.IsNullOrEmpty(fileName))
		//      {
		//         dataSetToRestore.ReadXml(fileName);
		//      }
		//   }
		//   catch (Exception ex)
		//   {
		//      Logger.errorLogger("error.txt", ex.ToString());
		//   }
		//}

		/// <summary>
		/// RSS subscription exporter.
		/// </summary>
		/// <param name="filePath">The file path.</param>
		public static void rssSubscriptionExporter(string filePath)
		{
			try
			{
				Stream stream = null;
				dataLinqSqlDataContext data = new dataLinqSqlDataContext();
				var rssSubs = from rssUrl in data.rssSubscriptions
								  select rssUrl;
				foreach (var rssUrl in rssSubs)
				{
					stream = new FileStream(filePath, FileMode.Append);
					StreamWriter file = new StreamWriter(stream);
					file.WriteLine(rssUrl.rssUrl, "\n");
					file.Close();
					stream = null;
				}
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		/// <summary>
		/// RSS subscription importer.
		/// </summary>
		/// <param name="filePath">The file path.</param>
		public static void rssSubscriptionImporter(string filePath)
		{
			try
			{
				Stream stream = null;
				dataLinqSqlDataContext data = new dataLinqSqlDataContext();
				stream = new FileStream(filePath, FileMode.Open);
				StreamReader file = new StreamReader(stream);
				string line;
				while ((line = file.ReadLine()) != null)
				{
					rssSubscription sub = new rssSubscription
					{
						rssUrl = line
					};
					data.rssSubscriptions.InsertOnSubmit(sub);
					data.SubmitChanges();
				}
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}
	}
}
