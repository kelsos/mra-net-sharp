using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using mraSharp.Forms;
using mraSharp.Properties;

namespace mraSharp.Classes
{
    internal class DatabaseWrapper
    {
        private static readonly string ConnectionString = "Data Source=" + Application.StartupPath + "\\mdb.db3";

        /// <summary>
        /// Queries the database and returns the reading list for the user. If the displayFinished setting is selected,
        /// then all the reading list is returned, if not then only the unfinished entries are returned;
        /// </summary>
        /// <returns>Reading List Datatable</returns>
        public static DataTable GetReadingData()
        {
            DataTable returnData = new DataTable();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();


                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    if (Settings.Default.displayFinished)
                    {
                        sqLiteCommand.CommandText =
                            "SELECT MI.MANGA_TITLE, RL.READ_STARTING_CHAPTER, RL.READ_CURRENT_CHAPTER, RL.READ_ONLINE_URL, RL.READ_LAST_TIME, RL.READ_IS_FINISHED " +
                            "FROM MANGA_INFO MI, READING_LIST RL " +
                            "WHERE MI.MANGA_ID = RL.MANGA_ID";
                    }
                    else
                    {
                        sqLiteCommand.CommandText =
                            "SELECT MI.MANGA_TITLE, RL.READ_STARTING_CHAPTER, RL.READ_CURRENT_CHAPTER, RL.READ_ONLINE_URL, RL.READ_LAST_TIME " +
                            "FROM MANGA_INFO MI, READING_LIST RL " +
                            "WHERE MI.MANGA_ID = RL.MANGA_ID AND RL.READ_IS_FINISHED = 'false'";
                    }
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    returnData.Load(reader);
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        /// <summary>
        /// Queries the database and returns the matching entries of the reading list for the user. If the displayFinished 
        /// setting is selected, then all the matching reading list elements are returned, if not then only the unfinished
        /// matching entries are returned;
        /// </summary>
        /// <param name="keyword">The keyword used in search</param>
        /// <returns>Matching results Datatable</returns>
        public static DataTable GetMatchingManga(String keyword)
        {
            DataTable returnData = new DataTable();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();


                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    if (Settings.Default.displayFinished)
                    {
                        sqLiteCommand.CommandText =
                            "SELECT MI.MANGA_TITLE, RL.READ_STARTING_CHAPTER, RL.READ_CURRENT_CHAPTER, RL.READ_ONLINE_URL, RL.READ_LAST_TIME, RL.READ_IS_FINISHED " +
                            "FROM MANGA_INFO MI, READING_LIST RL " +
                            "WHERE MI.MANGA_ID = RL.MANGA_ID AND MI.MANGA_TITLE LIKE '%" + keyword + "%'";
                    }
                    else
                    {
                        sqLiteCommand.CommandText =
                            "SELECT MI.MANGA_TITLE, RL.READ_STARTING_CHAPTER, RL.READ_CURRENT_CHAPTER, RL.READ_ONLINE_URL, RL.READ_LAST_TIME " +
                            "FROM MANGA_INFO MI, READING_LIST RL " +
                            "WHERE MI.MANGA_ID = RL.MANGA_ID AND RL.READ_IS_FINISHED = 'false' AND MI.MANGA_TITLE LIKE '%"+keyword+"%'";
                    }
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                        
                    returnData.Load(reader);
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        /// <summary>
        /// Given a manga entry ID the functions retrieves and returns the Cover image for the specific manga.
        /// </summary>
        /// <param name="mangaId">Integer id of the manga in the database</param>
        /// <returns>Image of the cover</returns>
        public static Image GetMangaCover(int mangaId)
        {
            if(mangaId<=0)
                throw new Exception("Invalid manga id value.");
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText = "SELECT MANGA_COVER " +
                                                "FROM MANGA_INFO " +
                                                "WHERE MANGA_ID = " + mangaId;

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    byte[] imageArray = new byte[6000];
                    while (reader.Read())
                    {
                        imageArray = GetBytes(reader);
                    }
                    reader.Close();
                    sqLiteConnection.Close();

                    return Image.FromStream(new MemoryStream(imageArray));
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return null;
        }

        public static String GetMangaDescriptions(int mangaId)
        {
            String returnData = null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();


                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT MANGA_DESCRIPTION " +
                                                                        "FROM MANGA_INFO " +
                                                                        "WHERE MANGA_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    while(reader.Read())
                    {
                        returnData = reader.GetString(0);
                    }
                    
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public static bool FeedDataExistInTheDatabase()
        {
            bool returnData;
            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
            {
                sqLiteConnection.Open();

                SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                  {
                                                      CommandText = "SELECT COUNT(*) " +
                                                                    "FROM NEWS_STORAGE "
                                                  };

                SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                returnData = reader.HasRows;
         
                reader.Close();
                sqLiteConnection.Close();
            }
            return returnData;
        }

        /// <summary>
        /// Gets the manga ID.
        /// </summary>
        /// <param name="mangaTitle">The manga title.</param>
        /// <returns></returns>
        public static int GetMangaId(string mangaTitle)
        {
            int returnData = 0;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);
                    if (string.IsNullOrEmpty(mangaTitle))
                        return returnData;
                    sqLiteCommand.CommandText = "SELECT MANGA_ID " +
                                                "FROM MANGA_INFO " +
                                                "WHERE MANGA_TITLE = ?";
                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    while(reader.Read())
                    {
                        returnData = reader.GetInt16(0);
                    }

                    reader.Close();
                    sqLiteConnection.Close();
                    return returnData;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
                return 0;
            }
        }

        //public List<NewsItem> GetNewsList()
        //{
        //    using (mdbEntities db = new mdbEntities())
        //        _newsList = (from news in db.NEWS_STORAGE
        //                     select news).ToList();
        //}

        //private void RssFetcher()
        //{
        //    try
        //    {
        //        using (mdbEntities db = new mdbEntities())
        //        {
        //            //Mds db = new Mds(Properties.Settings.Default.DbConnection);
        //            var rssSubs = from subs in db.NEWS_SUBSCRIPTIONS
        //                          select subs.SUBSCRIPTION_URL;
        //            foreach (var result in rssSubs.Select(channel => RssManager.ProcessNewsFeed(channel)))
        //            {
        //                ProgressChanged(result.Count, 0);
        //                var count = 0;
        //                foreach (NewsItem newsItem in result)
        //                {
        //                    var title = newsItem.Title;
        //                    title = title.Replace("'", "");
        //                    title = title.Trim();
        //                    var newsFilter = from line in db.NEWS_STORAGE
        //                                     where line.NEWSITEM_TITLE == title
        //                                     select line;
        //                    //TODO: Add implementation for the RSS to keep info about the Publication Date.
        //                    if (!newsFilter.Any())
        //                    {
        //                        var ne = new NEWS_STORAGE
        //                        {
        //                            NEWSITEM_TITLE = title,
        //                            NEWSITEM_HYPERLINK = newsItem.Link,
        //                            NEWSITEM_DESCRIPTION =
        //                                RegularExpressions.HtmlTagRemover(newsItem.Description),
        //                            NEWSITEM_AQUISITION_DATE = DateTime.Now
        //                        };
        //                        db.NEWS_STORAGE.AddObject(ne);
        //                        db.SaveChanges();
        //                    }
        //                    count++;
        //                    ProgressChanged(result.Count, count);
        //                }
        //            }
        //            _newsList = (from news in db.NEWS_STORAGE
        //                         select news).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorMessageBox.Show(ex.Message, ex.ToString());
        //        Logger.ErrorLogger("error.txt", ex.ToString());
        //    }
        //}

        //TODO:Just Read a Chapter functionality

                //        using (mdbEntities db = new mdbEntities())
                //{
                //    if (mangaListDataGridView.CurrentRow != null)
                //    {
                //        var mId =
                //            DatabaseOperations.GetMANGA_ID(
                //                (string) mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
                //        var manga = (from current in db.READING_LIST
                //                     where current.MANGA_ID == mId
                //                     select current).Single();
                //        manga.READ_CURRENT_CHAPTER += 1;
                //        manga.READ_LAST_TIME = DateTime.Now;
                //    }
                //    db.SaveChanges();
                //}
       

        private static byte[] GetBytes(SQLiteDataReader reader)
        {
            const int chunkSize = 2 * 1024;
            byte[] buffer = new byte[chunkSize];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    byte[] actualRead = new byte[bytesRead];
                    Buffer.BlockCopy(buffer, 0, actualRead, 0, (int)bytesRead);
                    stream.Write(actualRead, 0, actualRead.Length);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }
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
        /// <param name="olderThan">The number of days in the database after which the entry is considered old...</param>
        public static void OldRssRemover(int olderThan)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    DateTime olderDate = DateTime.Now;
                    TimeSpan daySpan = new TimeSpan(olderThan,0,0,0);
                    olderDate = olderDate.Subtract(daySpan);

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "DELETE " +
                                                                        "FROM NEWS_STORAGE " +
                                                                        "WHERE NEWSITEM_AQUISITION_DATE <= ?"
                                                      };
                    sqLiteCommand.Parameters.AddWithValue(null, olderDate);
                    sqLiteCommand.ExecuteNonQuery();

                    sqLiteConnection.Close();
                }
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
        public static void RemoveNewsSubscription(string url)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "DELETE * " +
                                                                        "FROM NEWS_SUBSCRIPTIONS " +
                                                                        "WHERE SUBSCRIPTION_URL = ?"
                                                      };
                    sqLiteCommand.Parameters.AddWithValue(null, url);
                    sqLiteCommand.ExecuteNonQuery();

                    sqLiteConnection.Close();
                }
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
        public static void InsertNewsSubscription(string url, string channelName)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText =
                                                              "INSERT INTO NEWS_SUBSCRIPTIONS (SUBSCRIPTION_URL, SUBSCRIPTION_CHANNEL_NAME) " +
                                                              "VALUES (?, ?)"
                                                      };
                    sqLiteCommand.Parameters.AddWithValue(null, url);
                    sqLiteCommand.Parameters.AddWithValue(null, channelName);
                    sqLiteCommand.ExecuteNonQuery();

                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// Loads the Rss Subscriptions (URLs) from the database.
        /// </summary>
        public static List<string> LoadSubscriptions()
        {
            List<String> returnData = new List<string>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT SUBSCRIPTION_URL " +
                                      "FROM NEWS_SUBSCRIPTIONS"
                    };

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        returnData.Add(reader.GetString(0));
                    }

                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public static string GetNewsSubscriptionChannelName(string subscriptionUrl)
        {
            string returnData = null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT SUBSCRIPTION_CHANNEL_NAME " +
                                      "FROM NEWS_SUBSCRIPTIONS " +
                                      "WHERE SUBSCRIPTION_URL = ?"
                    };
                    sqLiteCommand.Parameters.AddWithValue(null, subscriptionUrl);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        returnData = reader.GetString(0);
                    }

                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        //private void GetChannelName()
        //{
        //    using (mdbEntities db = new mdbEntities())
        //    {
        //        if (!String.IsNullOrEmpty(SUBSCRIPTION_URLComboBox.Text))
        //        {
        //            var channelName = (from data in db.NEWS_SUBSCRIPTIONS
        //                               where data.SUBSCRIPTION_URL == SUBSCRIPTION_URLComboBox.Text
        //                               select data.SUBSCRIPTION_CHANNEL_NAME).SingleOrDefault();
        //            channelTitleTextBox.Text = channelName;
        //        }
        //        else
        //        {
        //            channelTitleTextBox.Text = "";
        //        }
        //    }
        //}

        #region Statistics Methods

        /// <summary>
        /// Returns the of the mangas read.
        /// </summary>
        /// <returns></returns>
        public static int GetNumberOfMangasRead()
        {
            int returnData = 0;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT COUNT(*) " +
                                      "FROM READING_LIST "
                    };

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        returnData = reader.GetInt16(0);
                    }

                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        /// <summary>
        /// Returns the number the of chapters read.
        /// </summary>
        /// <returns></returns>
        public static int GetNumberOfChaptersRead()
        {
            int returnData = 0;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT * " +
                                      "FROM READING_LIST "
                    };

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        if (dataTable.Rows[i][2].Equals(1))
                        {
                            returnData += dataTable.Rows[i][3] is int ? (int)dataTable.Rows[i][3] : 0;
                        }
                        else
                        {
                            //TODO: Change it a little bit.
                            returnData += (int)dataTable.Rows[i][3] - (int)dataTable.Rows[i][2] - 1;
                        }
                    }
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        /// <summary>
        /// Returns the number of the mangas finished.
        /// </summary>
        /// <returns></returns>
        public static int? NumberofMangasFinished()
        {
            int returnData = 0;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT COUNT(*) " +
                                      "FROM READING_LIST " +
                                      "WHERE READ_IS_FINISHED = 'false'"
                    };

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        returnData = reader.GetInt16(0);
                    }

                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        /// <summary>
        /// Returns the date the latest manga was read.
        /// </summary>
        /// <returns></returns>
        public static DateTime? DateILastRead()
        {
            DateTime? returnData = null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT READ_LAST_TIME " +
                                      "FROM READING_LIST " +
                                      "ORDER BY READ_LAST_TIME DESC"
                    };

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    returnData = reader.GetDateTime(0);
                    
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
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
                return DateILastRead() != null ? dateDiff.Days : 0;
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