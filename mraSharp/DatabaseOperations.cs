using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace mraSharp
{
	class DatabaseOperations
	{
		private static dataLinqSqlDataContext sqlLinq = new dataLinqSqlDataContext();

		public static void clearDatabase()
		{
			sqlLinq.mangaLists.DeleteAllOnSubmit(sqlLinq.mangaLists);
			sqlLinq.SubmitChanges();
		}

		public static void imageToDatabaseLoader(byte[] imageByteArray, string myMangaTitle)
		{
			System.Data.Linq.Binary binary_file = new System.Data.Linq.Binary(imageByteArray);
			var mangaCoverImage = (from image in sqlLinq.mangaLists
										 where image.mangaTitle == myMangaTitle
										 select image).Single();
			mangaCoverImage.mangaCover = binary_file;
			sqlLinq.SubmitChanges();
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
				var deleteOldRss = from rssNews in sqlLinq.newsStorages
										 where rssNews.rssDateAquired <= date
										 select rssNews;
				foreach (var rssNews in deleteOldRss)
				{
					sqlLinq.newsStorages.DeleteOnSubmit(rssNews);
				}
				sqlLinq.SubmitChanges();
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		public static void removeRssSubscription(string url)
		{
			var deleteSub = from rssSub in sqlLinq.rssSubscriptions
								 where rssSub.rssUrl == url
								 select rssSub;
			foreach (var rssSub in deleteSub)
			{
				sqlLinq.rssSubscriptions.DeleteOnSubmit(rssSub);
			}
			sqlLinq.SubmitChanges();
		}

		public static void insertRssSubscription(string url)
		{
			rssSubscription sub = new rssSubscription
			{
				rssUrl = url
			};
			sqlLinq.rssSubscriptions.InsertOnSubmit(sub);
			sqlLinq.SubmitChanges();
		}
	}
}
