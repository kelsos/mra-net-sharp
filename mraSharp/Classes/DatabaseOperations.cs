using System;
using System.Linq;

namespace mraSharp
{
	//TODO: Database operations should use a temporary mds instance for each function.
	public static class DatabaseOperations
	{
		private static Mds db = new Mds(Properties.Settings.Default.DbConnection);

		/// <summary>
		/// Clears the database.
		/// </summary>
		public static void clearTheReadingList()
		{
			try
			{
				db.Mr_readingList.DeleteAllOnSubmit(db.Mr_readingList);
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
				//var deleteOldRss = from rssNews in db.Rss_NewsStorage
				//                   where rssNews. <= date
				//                   select rssNews;
				var oldRssToDelete = from newsItems in db.Rss_NewsStorage
											where newsItems.NewsDateAquired <= date
											select newsItems;
				foreach (var newsItem in oldRssToDelete)
				{
					db.Rss_NewsStorage.DeleteOnSubmit(newsItem);
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
				var subscriptionsToDelete = from rssSubscription in db.Rss_Subscriptions
													 where rssSubscription.RssURL == url
													 select rssSubscription;
				foreach (var rssSubscription in subscriptionsToDelete)
				{
					db.Rss_Subscriptions.DeleteOnSubmit(rssSubscription);
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
		public static void insertRssSubscription(string url, string channelName)
		{
			try
			{
				Rss_Subscriptions subscription = new Rss_Subscriptions
				{
					RssURL = url,
					RssChannelName = channelName
				};
				db.Rss_Subscriptions.InsertOnSubmit(subscription);
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
				using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
				{
					if (!string.IsNullOrEmpty(mangaTitle))
					{
						var mangaID = (from manga in db.M_mangaInfo
											where manga.MangaTitle == mangaTitle
											select manga.MangaID).SingleOrDefault();
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
				var mangaList = from mangas in db.Mr_readingList
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
				var chaptersList = from mangas in db.Mr_readingList
										 select mangas;
				foreach (var manga in chaptersList)
				{
					if (manga.Mr_StartingChapter == 1)
					{
						chapterCount += Convert.ToInt16(manga.Mr_CurrentChapter);
					}
					else
					{
						chapterCount += (Convert.ToInt16(manga.Mr_CurrentChapter) - (Convert.ToInt16(manga.Mr_StartingChapter) - 1));
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
				var mangaList = from mangas in db.Mr_readingList
									 select mangas;
				foreach (var manga in mangaList)
				{
					if (manga.Mr_IsReadingFinished == true)
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
				var mangaTest = from mangas in db.Mr_readingList
									 select mangas;
				if (mangaTest.Count() > 0)
				{

					var mangaList = (from mangas in db.Mr_readingList
										  orderby mangas.Mr_LastRead descending
										  select mangas).First();

					return mangaList.Mr_LastRead;
				}
				else
				{
					return (DateTime?)null;
				}
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
				return (DateTime?)null;
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
				if (dateILastRead() != null)
				{
					return dateDiff.Days;
				}
				else
				{
					return 0;
				}
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