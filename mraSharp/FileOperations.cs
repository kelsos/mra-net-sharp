using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace mraSharp
{
	public static class FileOperations
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
		public static void readingListFromXML(string fileName)
		{
			XDocument xDoc = XDocument.Load(fileName);
			dataLinqSqlDataContext db = new dataLinqSqlDataContext();
			//progress bar goes here

			var xData = from data in xDoc.Descendants("manga")
							select new
							{
								MangaTitle = (string)data.Element("Title"),
								StartingChapter = (string)data.Element("startingChapter") ?? "1",
								CurrentChapter = (string)data.Element("currentChapter") ?? "1",
								DateLastRead = (string)data.Element("dateRead") ?? "01-01-2000",
								OnLineURL = (string)data.Element("onlineURL") ?? "",
								Finished = (string)data.Element("finishedReading") ?? "false"
							};
			//progress bar size goes here

			foreach (var line in xData)
			{
				mangaReadingList mR = new mangaReadingList()
				{
					mangaID = DatabaseOperations.getMangaID(line.MangaTitle),
					mangaStartingChapter = Convert.ToInt32(line.StartingChapter),
					mangaCurrentChapter = Convert.ToInt32(line.CurrentChapter),
					mangaDateRead = DateTime.Parse(line.DateLastRead),
					mangaURL = line.OnLineURL,
					mangaReadingFinished = Convert.ToBoolean(line.Finished)
				};

				db.mangaReadingLists.InsertOnSubmit(mR);
				db.SubmitChanges();
				//progress loader goes here
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
