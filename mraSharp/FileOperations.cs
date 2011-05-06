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
			//TODO: Disable reload/backup when database is empty.
			//TODO: Insert Countries of MangaKa
			using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
			{
				var dataDump = from read in db.Mr_readingList
									join mangas in db.M_mangaInfo
									on read.MangaID equals mangas.MangaID
									select new mangaRead(mangas.MangaTitle, read.Mr_StartingChapter, read.Mr_CurrentChapter, read.Mr_LastRead, read.Mr_OnlineURL, read.Mr_IsReadingFinished, read.Mr_Note);

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
							new XElement("finishedReading", entry.FinishedReading),
							new XElement("mangaNote", entry.PersonalNote))
					)
				 );
				xDoc.Save(fileName);
			}
		}

		public static void readingListFromXML(string fileName, MainForm mf)
		{
			int count = 0;
			XDocument xDoc = XDocument.Load(fileName);
			Mds db = new Mds(Properties.Settings.Default.DbConnection);

			var xData = from data in xDoc.Descendants("manga")
							select new
							{
								MangaTitle = (string)data.Element("Title"),
								StartingChapter = String.IsNullOrEmpty((string)data.Element("startingChapter")) ? (double?)null : (double)data.Element("startingChapter"),
								CurrentChapter = String.IsNullOrEmpty((string)data.Element("currentChapter")) ? (double?)null : (double)data.Element("currentChapter"),
								DateLastRead = String.IsNullOrEmpty((string)data.Element("dateRead")) ? (DateTime?)null : (DateTime)data.Element("dateRead"),
								OnLineURL = (string)data.Element("onlineURL") ?? "",
								Finished = String.IsNullOrEmpty((string)data.Element("finishedReading")) ? false : (bool)data.Element("finishedReading"),
								Note = (string)data.Element("mangaNote") ?? ""
							};
			mf.progressChanged(xData.Count(), count);

			foreach (var line in xData)
			{
				Mr_readingList mR = new Mr_readingList()
				{
					MangaID = DatabaseOperations.getMangaID(line.MangaTitle),
					Mr_StartingChapter = line.StartingChapter,
					Mr_CurrentChapter = line.CurrentChapter,
					Mr_LastRead = line.DateLastRead,
					Mr_OnlineURL = line.OnLineURL,
					Mr_IsReadingFinished = line.Finished
				};

				db.Mr_readingList.InsertOnSubmit(mR);
				db.SubmitChanges();

				mf.progressChanged(xData.Count(), count + 1);
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
				Mds db = new Mds(Properties.Settings.Default.DbConnection);
				var rssSubs = from rssUrl in db.Rss_Subscriptions
								  select rssUrl;
				foreach (var rssUrl in rssSubs)
				{
					stream = new FileStream(filePath, FileMode.Append);
					StreamWriter file = new StreamWriter(stream);
					file.WriteLine(rssUrl.RssURL, "\n");
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
				Mds db = new Mds(Properties.Settings.Default.DbConnection);
				stream = new FileStream(filePath, FileMode.Open);
				StreamReader file = new StreamReader(stream);
				string line;
				while ((line = file.ReadLine()) != null)
				{
					Rss_Subscriptions sub = new Rss_Subscriptions()
					{
						RssURL = line
					};
					db.Rss_Subscriptions.InsertOnSubmit(sub);
					db.SubmitChanges();
				}
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}
	}
}