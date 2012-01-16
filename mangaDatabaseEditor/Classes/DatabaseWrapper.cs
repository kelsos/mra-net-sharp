using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using mangaDbEditor.Classes.Data;
using mangaDbEditor.Classes.Utilities;

namespace mangaDbEditor.Classes
{
    public sealed class DatabaseWrapper
    {
        private static readonly DatabaseWrapper ClassInstance = new DatabaseWrapper();
        private static readonly string ConnectionString = "Data Source=" + Application.StartupPath + "\\mdb.db3";

        private DatabaseWrapper()
        {
        }

        static DatabaseWrapper()
        {
        }

        public static DatabaseWrapper Instance
        {
            get { return ClassInstance; }
        }

        public int GetMangaInfoNumberOfElements()
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
                                                                        "FROM MANGA_INFO "
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
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public int GetAuthorInfoNumberOfElements()
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
                                                                        "FROM AUTHOR_INFO "
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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public int GetPublisherInfoNumberOfElements()
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
                                                                        "FROM PUBLISHER_INFO "
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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public MangaInfo GetMangaInfoElement(int mangaId)
        {
            MangaInfo returnData = new MangaInfo();
            if (mangaId <= 0)
            {
                return returnData;
            }
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText =
                                                              "SELECT MANGA_TITLE, MANGA_DESCRIPTION, MANGA_PUBLICATION_DATE, MANGA_PUBLICATION_STATUS " +
                                                              "FROM MANGA_INFO " +
                                                              "WHERE MANGA_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    returnData.Title = dataTable.Rows[0][0].ToString();
                    returnData.Description = dataTable.Rows[0][1].ToString();
                    returnData.PublicationDate = DateTime.Parse(dataTable.Rows[0][2].ToString());
                    returnData.PublicationStatus = dataTable.Rows[0][3].ToString();
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public AuthorInfo GetAuthorInfoElement(int authorId)
        {
            AuthorInfo returnData = new AuthorInfo();
            if (authorId <= 0)
            {
                return returnData;
            }
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText =
                                                              "SELECT AUTHOR_NAME, AUTHOR_NATIONALITY, AUTHOR_BIRTHDAY, AUTHOR_WEBSITE " +
                                                              "FROM AUTHOR_INFO " +
                                                              "WHERE AUTHOR_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, authorId);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    returnData.Name = dataTable.Rows[0][0].ToString();
                    returnData.Country = dataTable.Rows[0][1].ToString();
                    returnData.Birthday = DateTime.Parse(dataTable.Rows[0][2].ToString());
                    returnData.Website = dataTable.Rows[0][3].ToString();
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public PublisherInfo GetPublisherInfoElement(int publisherId)
        {
            PublisherInfo returnData = new PublisherInfo();
            if (publisherId <= 0)
            {
                return returnData;
            }
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText =
                                                              "SELECT PUBLISHER_NAME, PUBLISHER_COUNTRY, PUBLISHER_WEBSITE, PUBLISHER_NOTE " +
                                                              "FROM PUBLISHER_INFO " +
                                                              "WHERE PUBLISHER_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, publisherId);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    returnData.Name = dataTable.Rows[0][0].ToString();
                    returnData.Country = dataTable.Rows[0][1].ToString();
                    returnData.Website = dataTable.Rows[0][2].ToString();
                    returnData.Note = dataTable.Rows[0][3].ToString();
                    reader.Close();
                    sqLiteConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        /// <summary>
        /// Given a manga entry ID the functions retrieves and returns the Cover image for the specific manga.
        /// </summary>
        /// <returns>Image of the cover</returns>
        public Image GetMangaCover(int mangaId)
        {
            if (mangaId <= 0)
                return null;
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT MANGA_COVER " +
                                                                        "FROM MANGA_INFO " +
                                                                        "WHERE MANGA_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);
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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return null;
        }

        private static byte[] GetBytes(SQLiteDataReader reader)
        {
            if (reader == null) throw new ArgumentNullException("reader");
            const int chunkSize = 2*1024;
            byte[] buffer = new byte[chunkSize];
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                long bytesRead;
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

        public List<string> GetAuthorsList(int mangaId)
        {
            List<string> returnData = new List<string>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT AI.AUTHOR_NAME " +
                                                                        "FROM AUTHOR_INFO AI, MANGA_AUTHORS MA, MANGA_INFO MI " +
                                                                        "WHERE AI.AUTHOR_ID = MA.AUTHOR_ID AND MA.MANGA_ID = MI.MANGA_ID AND " +
                                                                        "MI.MANGA_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);

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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public List<string> GetGenresList(int mangaId)
        {
            List<string> returnData = new List<string>();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT GI.GENRE_NAME " +
                                                                        "FROM GENRE_INFO GI, MANGA_GENRES MG, MANGA_INFO MI " +
                                                                        "WHERE GI.GENRE_ID = MG.GENRE_ID AND MG.MANGA_ID = MI.MANGA_ID AND " +
                                                                        "MI.MANGA_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);

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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public string GetPublisherName(int mangaId)
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
                                                                        "WHERE PI.PUBLISHER_ID = MI.MANGA_PUBLISHER_ID AND MI.MANGA_ID = ?"
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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public void SetMangaCover(int mangaId, byte[] mangaCover)
        {
            if (mangaId <= 0)
                return;

            using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
            {
                sqLiteConnection.Open();
                SQLiteCommand insertCommand = new SQLiteCommand(sqLiteConnection)
                                                  {
                                                      CommandText = "UPDATE MANGA_INFO " +
                                                                    "SET MANGA_COVER = ? " +
                                                                    "WHERE MANGA_ID = ?"
                                                  };
                insertCommand.Parameters.AddWithValue(null, mangaCover);
                insertCommand.Parameters.AddWithValue(null, mangaId);
                insertCommand.ExecuteNonQuery();
                sqLiteConnection.Close();
            }
        }

        public List<string> GetNonSelectedAuthors(int mangaId)
        {
            List<string> returnData = new List<string> {""};
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT AUTHOR_NAME " +
                                                                        "FROM AUTHOR_INFO " +
                                                                        "WHERE AUTHOR_NAME NOT IN " +
                                                                        "(SELECT AI.AUTHOR_NAME " +
                                                                        "FROM AUTHOR_INFO AI, MANGA_AUTHORS MA, MANGA_INFO MI " +
                                                                        "WHERE AI.AUTHOR_ID = MA.AUTHOR_ID AND MA.MANGA_ID = MI.MANGA_ID AND " +
                                                                        "MI.MANGA_ID = ? )"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);

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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public List<string> GetNonSelectedGenresList(int mangaId)
        {
            List<string> returnData = new List<string> {""};
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText = "SELECT GENRE_NAME " +
                                                                        "FROM GENRE_INFO " +
                                                                        "WHERE GENRE_NAME NOT IN " +
                                                                        "(SELECT GI.GENRE_NAME " +
                                                                        "FROM GENRE_INFO GI, MANGA_GENRES MG, MANGA_INFO MI " +
                                                                        "WHERE GI.GENRE_ID = MG.GENRE_ID AND MG.MANGA_ID = MI.MANGA_ID AND " +
                                                                        "MI.MANGA_ID = ? )"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);

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
                ErrorHandler.LogError(ex);
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }
    }
}