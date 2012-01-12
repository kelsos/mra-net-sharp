using System;
using System.Linq;
using mraSharp.Forms;

namespace mraSharp.Classes
{
    //TODO: Database operations should use a temporary mds instance for each function.
    public static class DatabaseOperations
    {
        private static mdbEntities db = new mdbEntities();

        /// <summary>
        /// Clears the database.
        /// </summary>
        public static void ClearTheReadingList()
        {
            try
            {
                //db.Mr_readingList.DeleteAllOnSubmit(db.Mr_readingList);
                //db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// Removes the old entries (entries that have been in the database more than the specified time) from the database.
        /// </summary>
        /// <param name="daysInDb">The number of days in the database after which the entry is considered old...</param>
        public static void OldRssRemover(int daysInDb)
        {
            try
            {
                var date = DateTime.Now;
                var tS = new TimeSpan(daysInDb, 0, 0, 0);
                date = date.Subtract(tS);
                //var deleteOldRss = from rssNews in db.Rss_NewsStorage
                //                   where rssNews. <= date
                //                   select rssNews;
                var oldRssToDelete = from newsItems in db.NEWS_STORAGE
                                     where newsItems.NEWSITEM_AQUISITION_DATE <= date
                                     select newsItems;
                foreach (var newsItem in oldRssToDelete)
                {
                    db.NEWS_STORAGE.DeleteObject(newsItem);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// Removes the specified RSS subscription.
        /// </summary>
        /// <param name="url">The URL of the subscription to be removed.</param>
        public static void RemoveRssSubscription(string url)
        {
            try
            {
                var subscriptionsToDelete = from rssSubscription in db.NEWS_SUBSCRIPTIONS
                                            where rssSubscription.SUBSCRIPTION_URL == url
                                            select rssSubscription;
                foreach (var rssSubscription in subscriptionsToDelete)
                {
                    db.NEWS_SUBSCRIPTIONS.DeleteObject(rssSubscription);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// Inserts an RSS subscription url to the database.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="channelName">The RSS channel name.</param>
        public static void InsertRssSubscription(string url, string channelName)
        {
            try
            {
                var subscription = new NEWS_SUBSCRIPTIONS
                                       {
                                           SUBSCRIPTION_URL = url,
                                           SUBSCRIPTION_CHANNEL_NAME = channelName
                                       };
                db.NEWS_SUBSCRIPTIONS.AddObject(subscription);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// Gets the manga ID.
        /// </summary>
        /// <param name="mangaTitle">The manga title.</param>
        /// <returns></returns>
        public static int GetMANGA_ID(string mangaTitle)
        {
            try
            {
                if (!string.IsNullOrEmpty(mangaTitle))
                {
                    var MANGA_ID = (from manga in db.MANGA_INFO
                                   where manga.MANGA_TITLE == mangaTitle
                                   select manga.MANGA_ID).SingleOrDefault();
                    return (int) MANGA_ID;
                }
                return 0;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return 0;
            }
        }

        #region Statistics Methods

        /// <summary>
        /// Returns the of the mangas read.
        /// </summary>
        /// <returns></returns>
        public static int NumberOfMangasRead()
        {
            try
            {
                var mangaList = from mangas in db.READING_LIST
                                select mangas;
                return mangaList.Count();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// Returns the number the of chapters read.
        /// </summary>
        /// <returns></returns>
        public static int NumberOfChaptersRead()
        {
            try
            {
                int chapterCount = 0;
                var chaptersList = from mangas in db.READING_LIST
                                   select mangas;
                foreach (var manga in chaptersList)
                {
                    if (manga.READ_STARTING_CHAPTER == 1)
                    {
                        chapterCount += Convert.ToInt16(manga.READ_CURRENT_CHAPTER);
                    }
                    else
                    {
                        chapterCount += (Convert.ToInt16(manga.READ_CURRENT_CHAPTER) -
                                         (Convert.ToInt16(manga.READ_STARTING_CHAPTER) - 1));
                    }
                }
                return chapterCount;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return 0;
            }
        }

        /// <summary>
        /// Returns the number of the mangas finished.
        /// </summary>
        /// <returns></returns>
        public static int? NumberofMangasFinished()
        {
            try
            {
                var mangaList = from mangas in db.READING_LIST
                                select mangas;
                return Enumerable.Count(mangaList,
                                        manga => manga.READ_IS_FINISHED != null && (bool) manga.READ_IS_FINISHED);
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Returns the date the latest manga was read.
        /// </summary>
        /// <returns></returns>
        public static DateTime? DateILastRead()
        {
            try
            {
                var mangaTest = from mangas in db.READING_LIST
                                select mangas;
                if (mangaTest.Any())
                {
                    var mangaList = (from mangas in db.READING_LIST
                                     orderby mangas.READ_LAST_TIME descending
                                     select mangas).First();

                    return mangaList.READ_LAST_TIME;
                }
                return null;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// Returns the period from the date last read to the current day.
        /// </summary>
        /// <returns></returns>
        public static int DaysSinceILastRead()
        {
            try
            {
                TimeSpan dateDiff = DateTime.Now - Convert.ToDateTime(DateILastRead());
                if (DateILastRead() != null)
                {
                    return dateDiff.Days;
                }
                return 0;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return 0;
            }
        }

        #endregion Statistics Methods
    }
}