using System;
using System.Linq;

namespace mraSharp
{
	public static class DatabaseOperations
	{
		private static dataLinqSqlDataContext db = new dataLinqSqlDataContext();

		/// <summary>
		/// Clears the database.
		/// </summary>
		public static void clearDatabase()
		{
         try
         {
            db.mangaReadingLists.DeleteAllOnSubmit(db.mangaReadingLists);
            db.SubmitChanges();
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
		}

		/// <summary>
		/// Removes the old entries (entries that have been in the database more than the specified time) from the database.
		/// </summary>
		/// <param name="daysInDB">The number of days in the database after which the entry is considered old...</param>
		public static void oldRssRemover(int daysInDB)
		{
			try
			{
				DateTime date = DateTime.Now;
				TimeSpan tS = new TimeSpan(daysInDB, 0, 0, 0);
				date = date.Subtract(tS);
				var deleteOldRss = from rssNews in db.newsStorages
										 where rssNews.rssDateAquired <= date
										 select rssNews;
				foreach (var rssNews in deleteOldRss)
				{
					db.newsStorages.DeleteOnSubmit(rssNews);
				}
				db.SubmitChanges();
			}
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
		}

		/// <summary>
		/// Removes the specified RSS subscription.
		/// </summary>
		/// <param name="url">The URL of the subscription to be removed.</param>
		public static void removeRssSubscription(string url)
		{
         try
         {
            var deleteSub = from rssSub in db.rssSubscriptions
                            where rssSub.rssUrl == url
                            select rssSub;
            foreach (var rssSub in deleteSub)
            {
               db.rssSubscriptions.DeleteOnSubmit(rssSub);
            }
            db.SubmitChanges();
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
		}

		/// <summary>
		/// Inserts an RSS subscription url to the database.
		/// </summary>
		/// <param name="url">The URL.</param>
		public static void insertRssSubscription(string url)
		{
         try
         {
            rssSubscription sub = new rssSubscription
            {
               rssUrl = url
            };
            db.rssSubscriptions.InsertOnSubmit(sub);
            db.SubmitChanges();
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
		}

		/// <summary>
		/// Gets the manga ID.
		/// </summary>
		/// <param name="mangaTitle">The manga title.</param>
		/// <returns></returns>
		public static int getMangaID(string mangaTitle)
		{
         try
         {
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (!string.IsNullOrEmpty(mangaTitle))
               {
                  var mangaID = (from manga in db.mangaInfos
                                 where manga.mangaTitle == mangaTitle
                                 select manga.mangaID).SingleOrDefault();
                  return mangaID;
               }
               else
               {
                  return 0;
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
            return 0;
         }
		}

		#region Statistics Methods

		/// <summary>
		/// Returns the of the mangas read.
		/// </summary>
		/// <returns></returns>
		public static int numberOfMangasRead()
		{
         try
         {
            var mangaList = from mangas in db.mangaReadingLists
                            select mangas;
            return mangaList.Count();
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
            return 0;
         }

		}

		/// <summary>
		/// Returns the number the of chapters read.
		/// </summary>
		/// <returns></returns>
		public static int numberOfChaptersRead()
		{
         try
         {
            int chapterCount = 0;
            var chaptersList = from mangas in db.mangaReadingLists
                               select mangas;
            foreach (var manga in chaptersList)
            {
               if (manga.mangaStartingChapter == 1)
               {
                  chapterCount += Convert.ToInt16(manga.mangaCurrentChapter);
               }
               else
               {
                  chapterCount += (Convert.ToInt16(manga.mangaCurrentChapter) - (Convert.ToInt16(manga.mangaStartingChapter) - 1));
               }
            }
            return chapterCount;
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
            return 0;
         }
		}

		/// <summary>
		/// Returns the number of the mangas finished.
		/// </summary>
		/// <returns></returns>
		public static int? numberofMangasFinished()
		{
         try
         {
            int mangasFinishedCount = 0;
            var mangaList = from mangas in db.mangaReadingLists
                            select mangas;
            foreach (var manga in mangaList)
            {
               if (manga.mangaReadingFinished == true)
                  mangasFinishedCount += 1;
            }
            return mangasFinishedCount;
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
            return null;
         }
		}

		/// <summary>
		/// Returns the date the latest manga was read.
		/// </summary>
		/// <returns></returns>
		public static DateTime? dateILastRead()
		{
         try
         {
            var mangaList = (from mangas in db.mangaReadingLists
                             orderby mangas.mangaDateRead descending
                             select mangas).First();
            return mangaList.mangaDateRead;
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
            return null;
         }
		}

		/// <summary>
		/// Returns the period from the date last read to the current day.
		/// </summary>
		/// <returns></returns>
		public static int daysSinceILastRead()
		{
         try
         {
            TimeSpan dateDiff = DateTime.Now - Convert.ToDateTime(dateILastRead());
            return dateDiff.Days;
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
            return 0;
         }
		}

		#endregion Statistics Methods
	}
}