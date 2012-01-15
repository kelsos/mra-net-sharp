using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using mangaDbEditor.Classes.Data;

namespace mangaDbEditor.Classes
{
    public sealed class DatabaseWrapper
    {
        private static readonly DatabaseWrapper ClassInstance = new DatabaseWrapper();
        private static readonly string ConnectionString = "Data Source=" + Application.StartupPath + "\\mdb.db3";
        
        DatabaseWrapper(){}
        static DatabaseWrapper(){}

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
                //ErrorMessageBox.Show(ex.Message, ex.ToString());
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public MangaInfo GetMangaInfoElement(int mangaId)
        {
            MangaInfo returnData = new MangaInfo();
            try
            {
                using (SQLiteConnection sqLiteConnection = new SQLiteConnection(ConnectionString))
                {
                    sqLiteConnection.Open();
                    SQLiteCommand sqLiteCommand = new SQLiteCommand(sqLiteConnection)
                                                      {
                                                          CommandText =
                                                              "SELECT MANGA_ID, MANGA_TITLE, MANGA_DESCRIPTION, MANGA_PUBLICATION_DATE, MANGA_PUBLICATION_STATUS " +
                                                              "FROM MANGA_INFO " +
                                                              "WHERE MANGA_ID = ?"
                                                      };

                    sqLiteCommand.Parameters.AddWithValue(null, mangaId);
                    SQLiteDataReader reader = sqLiteCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    returnData.Id = int.Parse(dataTable.Rows[0][0].ToString());
                    returnData.Title = dataTable.Rows[0][1].ToString();
                    returnData.Description = dataTable.Rows[0][2].ToString();
                    returnData.PublicationDate = DateTime.Parse(dataTable.Rows[0][3].ToString());
                    returnData.PublicationStatus = dataTable.Rows[0][4].ToString();
                    reader.Close();
                    sqLiteConnection.Close();

                }
            }
            catch (Exception ex)
            {
                //ErrorMessageBox.Show(ex.Message, ex.ToString());
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
            if (mangaId<=0)
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
                //ErrorMessageBox.Show(ex.Message, ex.ToString());
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return null;
        }

        private byte[] GetBytes(SQLiteDataReader reader)
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

        public List<String> GetAuthorsList(int mangaId)
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
                                                "MI.MANGA_ID = ?";
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
                //ErrorMessageBox.Show(ex.Message, ex.ToString());
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }

        public List<String> GetGenresList(int mangaId)
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
                                                "MI.MANGA_ID = ?";
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
                //ErrorMessageBox.Show(ex.Message, ex.ToString());
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
                //ErrorMessageBox.Show(ex.Message, ex.ToString());
                //Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return returnData;
        }
    }
}
