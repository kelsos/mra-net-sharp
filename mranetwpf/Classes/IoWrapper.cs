using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using mranetwpf.Classes.Utilities;

namespace mranetwpf.Classes
{
    public static class IoWrapper
    {
        public static void ReadingListToXml(string fileName)
        {
            DataTable readData = DatabaseWrapper.GetCompleteReadingData();
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Reading List Xml file"));
            XElement rootElement = new XElement("mangaReadingList");
            xDocument.AddFirst(rootElement);
            for (int i = 0; i < readData.Rows.Count; i++)
            {
                Debug.WriteLine(readData.Rows[i][1].ToString());
                XElement readElement = new XElement("manga",
                                                    new XElement("Title",
                                                                 DatabaseWrapper.GetMangaTitle(
                                                                     int.Parse(readData.Rows[i][1].ToString()))),
                                                    new XElement("startingChapter", readData.Rows[i][2].ToString()),
                                                    new XElement("currentChapter", readData.Rows[i][3].ToString()),
                                                    new XElement("onlineURL", readData.Rows[i][4].ToString()),
                                                    new XElement("finishedReading",
                                                                 bool.Parse(readData.Rows[i][5].ToString())),
                                                    new XElement("dateRead", readData.Rows[i][6].ToString()),
                                                    new XElement("mangaNote", readData.Rows[i][7].ToString())
                    );
                rootElement.Add(readElement);
            }
            xDocument.Save(fileName);
        }

        public static void ReadingListFromXml(object info)
        {
            
            string fileName = info.ToString();

            var xDoc = XDocument.Load(fileName);
            var xData = from data in xDoc.Descendants("manga")
                        select new
                                   {
                                       MangaTitle = (string) data.Element("Title"),
                                       StartingChapter =
                            String.IsNullOrEmpty((string) data.Element("startingChapter"))
                                ? (double?) null
                                : (double) data.Element("startingChapter"),
                                       CurrentChapter =
                            String.IsNullOrEmpty((string) data.Element("currentChapter"))
                                ? (double?) null
                                : (double) data.Element("currentChapter"),
                                       DateLastRead =
                            String.IsNullOrEmpty((string) data.Element("dateRead"))
                                ? (DateTime?) null
                                : (DateTime) data.Element("dateRead"),
                                       OnLineURL = (string) data.Element("onlineURL") ?? "",
                                       Finished =
                            !String.IsNullOrEmpty((string) data.Element("finishedReading")) &&
                            (bool) data.Element("finishedReading"),
                                       Note = (string) data.Element("mangaNote") ?? ""
                                   };

            foreach (var entry in xData)
            {
                DatabaseWrapper.InsertNewReadingItem(DatabaseWrapper.GetMangaId(entry.MangaTitle), entry.StartingChapter,
                                                     entry.CurrentChapter, entry.OnLineURL, entry.Finished,
                                                     entry.DateLastRead, entry.Note);
            }
        }

        /// <summary>
        ///   Saves the stored in database news subscription urls to the specified file.
        /// </summary>
        /// <param name="fileName"> The filename. </param>
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
                ErrorHandler.HandleException(ex);
            }
        }

        /// <summary>
        ///   RSS subscription importer.
        /// </summary>
        /// <param name="fileName"> The file path. </param>
        public static void RssSubscriptionImporter(string fileName)
        {
            try
            {
                using (Stream subStream = new FileStream(fileName, FileMode.Open))
                {
                    StreamReader subFile = new StreamReader(subStream);
                    string line;
                    while ((line = subFile.ReadLine()) != null)
                    {
                        DatabaseWrapper.InsertNewsSubscription(line, NewsSubscriptionManager.GetSubscriptionChannelName(line));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.HandleException(ex);
            }
        }
    }
}