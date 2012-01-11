using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Data.SQLite;
using System.Data.SQLite.Properties;

namespace mraSharp.Classes
{
    public static class FileOperations
    {
        public static void ReadingListToXML(string fileName)
        {
            //TODO: Disable reload/backup when database is empty.
            //TODO: Insert Countries of MangaKa
            using (mangaDatabaseEntities mdb = new mangaDatabaseEntities())
            {

                var dataDump = from read in mdb.READING_LIST
                               join mangas in mdb.MANGA_INFO
                               on read.MANGA_ID equals mangas.MANGA_ID
                               select new MangaRead(mangas.MANGA_TITLE, read.READ_STARTING_CHAPTER, read.READ_CURRENT_CHAPTER, read.READ_LAST_TIME, read.READ_ONLINE_URL, read.READ_IS_FINISHED, read.READ_NOTE);

                var xDoc = new XDocument(
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

        public static void ReadingListFromXML(object info)
        {
            var information = (DataPasser)info;
            var fileName = information.FilePath;
            var mf = information.Form;

            var count = 0;
            var xDoc = XDocument.Load(fileName);
            using (var db = new Mds(Properties.Settings.Default.DbConnection))
            {
                var xData = from data in xDoc.Descendants("manga")
                            select new
                                       {
                                           MangaTitle = (string)data.Element("Title"),
                                           StartingChapter = String.IsNullOrEmpty((string)data.Element("startingChapter")) ? (double?)null : (double)data.Element("startingChapter"),
                                           CurrentChapter = String.IsNullOrEmpty((string)data.Element("currentChapter")) ? (double?)null : (double)data.Element("currentChapter"),
                                           DateLastRead = String.IsNullOrEmpty((string)data.Element("dateRead")) ? (DateTime?)null : (DateTime)data.Element("dateRead"),
                                           OnLineURL = (string)data.Element("onlineURL") ?? "",
                                           Finished = !String.IsNullOrEmpty((string)data.Element("finishedReading")) && (bool)data.Element("finishedReading"),
                                           Note = (string)data.Element("mangaNote") ?? ""
                                       };
                mf.ProgressChanged(xData.Count(), count);
                foreach (var mR in xData.Select(line => new Mr_readingList() { MangaID = DatabaseOperations.GetMangaID(line.MangaTitle), Mr_StartingChapter = line.StartingChapter, Mr_CurrentChapter = line.CurrentChapter, Mr_LastRead = line.DateLastRead, Mr_OnlineURL = line.OnLineURL, Mr_IsReadingFinished = line.Finished }))
                {
                    db.Mr_readingList.InsertOnSubmit(mR);
                    db.SubmitChanges();
                    count++;
                    mf.ProgressChanged(xData.Count(), count);
                }
            }
            mf.LoadDatagrid();
        }

        /// <summary>
        /// RSS subscription exporter.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public static void RssSubscriptionExporter(string filePath)
        {
            try
            {
                using (var db = new Mds(Properties.Settings.Default.DbConnection))
                {
                    var rssSubs = from rssUrl in db.Rss_Subscriptions
                                  select rssUrl;
                    foreach (var rssUrl in rssSubs)
                    {
                        Stream stream = new FileStream(filePath, FileMode.Append);
                        var file = new StreamWriter(stream);
                        file.WriteLine(rssUrl.RssURL, "\n");
                        file.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// RSS subscription importer.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public static void RssSubscriptionImporter(string filePath)
        {
            try
            {
                using (var db = new Mds(Properties.Settings.Default.DbConnection))
                {
                    Stream stream = new FileStream(filePath, FileMode.Open);
                    var file = new StreamReader(stream);
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        var sub = new Rss_Subscriptions { RssURL = line };
                        db.Rss_Subscriptions.InsertOnSubmit(sub);
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }
    }
}