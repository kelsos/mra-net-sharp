using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace mraSharp.Classes
{
    public static class FileOperations
    {
        public static void ReadingListToXml(string fileName)
        {
            //TODO: Disable reload/backup when database is empty.
            //TODO: Insert Countries of MangaKa
            //using (mdbEntities mdb = new mdbEntities())
            //{
            //    var dataDump = from read in mdb.READING_LIST
            //                   join mangas in mdb.MANGA_INFO
            //                       on read.MANGA_ID equals mangas.MANGA_ID
            //                   select
            //                       new MangaRead(mangas.MANGA_TITLE, read.READ_STARTING_CHAPTER,
            //                                     read.READ_CURRENT_CHAPTER, read.READ_LAST_TIME, read.READ_ONLINE_URL,
            //                                     read.READ_IS_FINISHED, read.READ_NOTE);

            //    var xDoc = new XDocument(
            //        new XDeclaration("1.0", "utf-8", "yes"),
            //        new XComment("Manga Reading Assistant Reading List"),
            //        new XElement("mangaReadingList",
            //                     from entry in dataDump
            //                     select new XElement("manga",
            //                                         new XElement("Title", entry.Title),
            //                                         new XElement("startingChapter", entry.StartingChapter),
            //                                         new XElement("currentChapter", entry.CurrentChapter),
            //                                         new XElement("dateRead", entry.LastRead),
            //                                         new XElement("onlineURL", entry.OnlineURL),
            //                                         new XElement("finishedReading", entry.FinishedReading),
            //                                         new XElement("mangaNote", entry.PersonalNote))
            //            )
            //        );
            //    xDoc.Save(fileName);
            //}
        }

        public static void ReadingListFromXml(object info)
        {
            //var information = (DataPasser) info;
            //var fileName = information.FilePath;
            //var mf = information.Form;

            //var count = 0;
            //var xDoc = XDocument.Load(fileName);
            //using (mdbEntities db = new mdbEntities())
            //{
            //    var xData = from data in xDoc.Descendants("manga")
            //                select new
            //                           {
            //                               MangaTitle = (string) data.Element("Title"),
            //                               StartingChapter =
            //                    String.IsNullOrEmpty((string) data.Element("startingChapter"))
            //                        ? (double?) null
            //                        : (double) data.Element("startingChapter"),
            //                               CurrentChapter =
            //                    String.IsNullOrEmpty((string) data.Element("currentChapter"))
            //                        ? (double?) null
            //                        : (double) data.Element("currentChapter"),
            //                               DateLastRead =
            //                    String.IsNullOrEmpty((string) data.Element("dateRead"))
            //                        ? (DateTime?) null
            //                        : (DateTime) data.Element("dateRead"),
            //                               OnLineURL = (string) data.Element("onlineURL") ?? "",
            //                               Finished =
            //                    !String.IsNullOrEmpty((string) data.Element("finishedReading")) &&
            //                    (bool) data.Element("finishedReading"),
            //                               Note = (string) data.Element("mangaNote") ?? ""
            //                           };
            //    mf.ProgressChanged(xData.Count(), count);
            //    foreach (
            //        var mR in
            //            xData.Select(
            //                line =>
            //                new READING_LIST()
            //                    {
            //                        MANGA_ID = DatabaseOperations.GetMANGA_ID(line.MangaTitle),
            //                        READ_STARTING_CHAPTER = (long?) line.StartingChapter,
            //                        READ_CURRENT_CHAPTER = (long?) line.CurrentChapter,
            //                        READ_LAST_TIME = line.DateLastRead,
            //                        READ_ONLINE_URL = line.OnLineURL,
            //                        READ_IS_FINISHED = line.Finished
            //                    }))
            //    {
            //        db.READING_LIST.AddObject(mR);
            //        db.SaveChanges();
            //        count++;
            //        mf.ProgressChanged(xData.Count(), count);
            //    }
            //}
            //mf.LoadDatagrid();
        }

        /// <summary>
        /// Saves the stored in database news subscription urls to the specified file.
        /// </summary>
        /// <param name="fileName">The filename.</param>
        public static void NewsSubscriptionToTextFile(string fileName)
        {
            try
            {
                using (Stream subStream = new FileStream(fileName, FileMode.Append))
                {
                    foreach (var entry in DatabaseWrapper.GetSubscriptionList())
                    {
                        StreamWriter subFile = new StreamWriter(subStream);
                        subFile.WriteLine(entry);
                        subFile.Close();
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
        /// <param name="fileName">The file path.</param>
        public static void RssSubscriptionImporter(string fileName)
        {
            try
            {
                using (Stream subStream = new FileStream(fileName, FileMode.Open))
                {
                    StreamReader subFile = new StreamReader(subStream);
                    string line;
                    while((line = subFile.ReadLine())!=null)
                    {
                        DatabaseWrapper.InsertNewsSubscription(line,RssManager.GetSubscriptionChannelName(line));
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