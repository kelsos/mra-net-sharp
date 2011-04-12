using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace mraSharp
{
	class FileOperations
	{

		public static void readingListToXML(string fileName)
		{
			using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
			{
				var dataDump = from read in db.mangaReadingLists
									join mangas in db.mangaInfos
									on read.mangaID equals mangas.mangaID
									select new mangaRead(mangas.mangaTitle, read.mangaStartingChapter, read.mangaCurrentChapter, read.mangaDateRead, read.mangaURL, read.mangaReadingFinished);

				XDocument xDoc = new XDocument(
					new XDeclaration("1.0", "utf-8", "yes"),
					new XComment("Manga Reading Assistant Reading List"),
					new XElement("mangaReadingList",
						from entry in dataDump
						select new XElement("manga",
							new XElement("Title", entry.Title),
							new XElement("startingChapter", entry.StartingChapter),
							new XElement("currentChapter", entry.CurrentChapter),
							new XElement("dateRead", entry.LastRead),
							new XElement("onlineURL", entry.OnlineURL),
							new XElement("finishedReading", entry.FinishedReading))
					)
				 );
				xDoc.Save(fileName);
			}
		}

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
