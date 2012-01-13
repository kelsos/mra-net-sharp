using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
        public static DataTable GetReadingData(bool displayFinished)
        {
            DataTable returnData = new DataTable();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    if (displayFinished)
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
                    returnData.Columns[0].ColumnName = "Manga\nTitle";
                    returnData.Columns[1].ColumnName = "Starting\nChapter";
                    returnData.Columns[2].ColumnName = "Current\nChapter";
                    returnData.Columns[3].ColumnName = "Online Url";
                    returnData.Columns[4].ColumnName = "Last Time Read";
                    if (Settings.Default.displayFinished)
                        returnData.Columns[5].ColumnName = "Finished?";
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public static DataTable GetCompleteReadingData()
        {
            DataTable returnData = new DataTable();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();


                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText =
                        "SELECT * " +
                        "FROM READING_LIST ";

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
                            "WHERE MI.MANGA_ID = RL.MANGA_ID AND RL.READ_IS_FINISHED = 'false' AND MI.MANGA_TITLE LIKE '%" +
                            keyword + "%'";
                    }
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    returnData.Load(reader);
                    reader.Close();
                    sqLiteConnection.Close();
                    returnData.Columns[0].ColumnName = "Manga\nTitle";
                    returnData.Columns[1].ColumnName = "Starting\nChapter";
                    returnData.Columns[2].ColumnName = "Current\nChapter";
                    returnData.Columns[3].ColumnName = "Online Url";
                    returnData.Columns[4].ColumnName = "Last Time Read";
                    if(Settings.Default.displayFinished)
                        returnData.Columns[5].ColumnName = "Finished?";
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
        /// <param name="mangaTitle"> </param>
        /// <returns>Image of the cover</returns>
        public static Image GetMangaCover(string mangaTitle)
        {
            if (string.IsNullOrEmpty(mangaTitle))
                return null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText = "SELECT MANGA_COVER " +
                                                "FROM MANGA_INFO " +
                                                "WHERE MANGA_TITLE = ?";
                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);
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

        public static String GetMangaDescriptions(string mangaTitle)
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
                                                                        "WHERE MANGA_TITLE = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);
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

        public static DateTime? GetMangaYearOfPublish(string mangaTitle)
        {
            DateTime? returnData = null;
            if (String.IsNullOrEmpty(mangaTitle))
                throw new Exception("Invalid manga title value.");
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText = "SELECT MANGA_PUBLICATION_DATE " +
                                                "FROM MANGA_INFO " +
                                                "WHERE MANGA_TITLE = ?";
                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        returnData = reader.GetDateTime(0);
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

        public static String GetMangaTitle(int mangaId)
        {
            String returnData = null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT MANGA_TITLE " +
                                                                        "FROM MANGA_INFO " +
                                                                        "WHERE MANGA_ID= ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);
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

        public static String GetMangaStatus(string mangaTitle)
        {
            String returnData = null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT MANGA_PUBLICATION_STATUS " +
                                                                        "FROM MANGA_INFO " +
                                                                        "WHERE MANGA_TITLE= ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);
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

        public static List<string> GetMangaTitleList(bool includeReadingList)
        {
            List<string> returnData = new List<string>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);
                    if (includeReadingList)
                    {
                        sqLiteCommand.CommandText = "SELECT MANGA_TITLE " +
                                                    "FROM MANGA_INFO ";
                    }
                    else
                    {
                        sqLiteCommand.CommandText = "SELECT MANGA_TITLE " +
                                                    "FROM MANGA_INFO " +
                                                    "WHERE MANGA_ID NOT IN (SELECT MANGA_ID " +
                                                    "FROM READING_LIST )";
                    }
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

        public static List<NewsItem> GetNewsItemList()
        {
            List<NewsItem> returnData = new List<NewsItem>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText = "SELECT * " +
                                                "FROM NEWS_STORAGE ";

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();

                    dataTable.Load(reader);

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        NewsItem newsItem = new NewsItem
                                                {
                                                    Title = dataTable.Rows[i][1] as string,
                                                    Link = dataTable.Rows[i][2] as string,
                                                    Description = dataTable.Rows[i][3] as string,
                                                    AquisitionDate = dataTable.Rows[i][5] as DateTime?
                                                };

                        returnData.Add(newsItem);
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

        public static void InsertNewReadingItem(int mangaId, double? startingChapter, double? currentChapter,
                                                string onlineUrl, bool isFinished, DateTime? readLastTime, string note)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    using (SQLiteCommand insertCommand = new SQLiteCommand(sqLiteConnection))
                    {
                        insertCommand.CommandText =
                            "INSERT INTO READING_LIST (MANGA_ID, READ_STARTING_CHAPTER, READ_CURRENT_CHAPTER, READ_ONLINE_URL, " +
                            "READ_IS_FINISHED, READ_LAST_TIME, READ_NOTE) VALUES (?, ?, ?, ?, ?, ?, ?)";
                        insertCommand.Parameters.AddWithValue(null, mangaId);
                        insertCommand.Parameters.AddWithValue(null, startingChapter);
                        insertCommand.Parameters.AddWithValue(null, currentChapter);
                        insertCommand.Parameters.AddWithValue(null, onlineUrl);
                        insertCommand.Parameters.AddWithValue(null, isFinished);
                        insertCommand.Parameters.AddWithValue(null, readLastTime);
                        insertCommand.Parameters.AddWithValue(null, note);
                        insertCommand.ExecuteNonQuery();
                    }
                    sqLiteConnection.Close();
                }
            }

            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        public static void InsertNewReadingItem(ReadItem item)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    using (SQLiteCommand insertCommand = new SQLiteCommand(sqLiteConnection))
                    {
                        insertCommand.CommandText =
                            "INSERT INTO READING_LIST (MANGA_ID, READ_STARTING_CHAPTER, READ_CURRENT_CHAPTER, READ_ONLINE_URL, " +
                            "READ_IS_FINISHED, READ_LAST_TIME, READ_NOTE) VALUES (?, ?, ?, ?, ?, ?, ?)";
                        insertCommand.Parameters.AddWithValue(null, GetMangaId(item.Title));
                        insertCommand.Parameters.AddWithValue(null, item.StartingChapter);
                        insertCommand.Parameters.AddWithValue(null, item.CurrentChapter);
                        insertCommand.Parameters.AddWithValue(null, item.OnlineUrl);
                        insertCommand.Parameters.AddWithValue(null, item.FinishedReading);
                        insertCommand.Parameters.AddWithValue(null, item.LastRead);
                        insertCommand.Parameters.AddWithValue(null, item.PersonalNote);
                        insertCommand.ExecuteNonQuery();
                    }
                    sqLiteConnection.Close();
                }
            }

            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        public static void NewsItemsRetriever()
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText = "SELECT SUBSCRIPTION_URL " +
                                                "FROM NEWS_SUBSCRIPTIONS ";

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        foreach (NewsItem newsItem in RssManager.ProcessNewsFeed(reader.GetString(0)))
                        {
                            string title = newsItem.Title;
                            title = title.Replace("'", "").Trim();
                            using (SQLiteCommand filterCommand = new SQLiteCommand(sqLiteConnection))
                            {
                                filterCommand.CommandText = "SELECT * " +
                                                            "FROM NEWS_STORAGE " +
                                                            "WHERE NEWSITEM_TITLE = ? ";
                                filterCommand.Parameters.AddWithValue(null, title);
                                SQLiteDataReader filterReader = filterCommand.ExecuteReader();
                                if (filterReader.HasRows)
                                    continue;
                                filterReader.Close();
                            }
                            using (SQLiteCommand insertCommand = new SQLiteCommand(sqLiteConnection))
                            {
                                insertCommand.CommandText =
                                    "INSERT INTO NEWS_STORAGE (NEWSITEM_TITLE, NEWSITEM_HYPERLINK, NEWSITEM_DESCRIPTION, NEWSITEM_AQUISITION_DATE) " +
                                    "VALUES (?, ?, ?, ?)";
                                insertCommand.Parameters.AddWithValue(null, newsItem.Title);
                                insertCommand.Parameters.AddWithValue(null, newsItem.Link);
                                insertCommand.Parameters.AddWithValue(null, newsItem.Description);
                                insertCommand.Parameters.AddWithValue(null, DateTime.Now);
                                insertCommand.ExecuteNonQuery();
                            }
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
        }

        public static void ChapterFinished(string mangaTitle)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "UPDATE READING_LIST " +
                                                                        "SET READ_CURRENT_CHAPTER = READ_CURRENT_CHAPTER + 1, READ_LAST_TIME = ? " +
                                                                        "WHERE MANGA_ID = ?"
                                                      };
                    sqLiteCommand.Parameters.AddWithValue(null, DateTime.Now);
                    sqLiteCommand.Parameters.AddWithValue(null, GetMangaId(mangaTitle));
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

        private static byte[] GetBytes(SQLiteDataReader reader)
        {
            const int chunkSize = 2*1024;
            byte[] buffer = new byte[chunkSize];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(0, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    byte[] actualRead = new byte[bytesRead];
                    Buffer.BlockCopy(buffer, 0, actualRead, 0, (int) bytesRead);
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
        public static void CleanNewsOlderThan(int olderThan)
        {
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    DateTime olderDate = DateTime.Now;
                    TimeSpan daySpan = new TimeSpan(olderThan, 0, 0, 0);
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

        public static string GetPublisherName(string mangaTitle)
        {
            string returnData = null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();

                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                    {
                        CommandText = "SELECT PI.PUBLISHER_NAME " +
                                      "FROM PUBLISHER_INFO PI, MANGA_INFO MI " +
                                      "WHERE PI.PUBLISHER_ID = MI.MANGA_PUBLISHER_ID AND MI.MANGA_TITLE = ?"
                    };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);

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

        public static List<String> GetAuthorsList(string mangaTitle)
        {
            List<string> returnData = new List<string>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                    sqLiteCommand.CommandText = "SELECT AI.AUTHOR_NAME " +
                                                "FROM AUTHOR_INFO AI, MANGA_AUTHORS MA, MANGA_INFO MI " +
                                                "WHERE AI.AUTHOR_ID = MA.AUTHOR_ID AND MA.MANGA_ID = MI.MANGA_ID AND " +
                                                "MI.MANGA_TITLE = ?";
                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);

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

        public static List<String> GetGenresList(string mangaTitle)
        {
            List<string> returnData = new List<string>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection);

                        sqLiteCommand.CommandText = "SELECT GI.GENRE_NAME " +
                                                    "FROM GENRE_INFO GI, MANGA_GENRES MG, MANGA_INFO MI " +
                                                    "WHERE GI.GENRE_ID = MG.GENRE_ID AND MG.MANGA_ID = MI.MANGA_ID AND " +
                                                    "MI.MANGA_TITLE = ?";
                    sqLiteCommand.Parameters.AddWithValue(null, mangaTitle);
                    
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

        /// <summary>
        /// Loads the Rss Subscriptions (URLs) from the database.
        /// </summary>
        public static List<string> GetSubscriptionList()
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
                        if (int.Parse(dataTable.Rows[i][2].ToString())==1)
                        {
                            returnData += int.Parse(dataTable.Rows[i][3].ToString());
                        }
                        else
                        {
                            returnData += int.Parse(dataTable.Rows[i][3].ToString()) - int.Parse(dataTable.Rows[i][2].ToString()) - 1;
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
                                                                        "ORDER BY READ_LAST_TIME DESC LIMIT 1,1"
                                                      };

                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        returnData = reader.GetDateTime(0);
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