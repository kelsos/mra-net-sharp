using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT COUNT(*) " +
                                                    "FROM MANGA_INFO ";

                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            returnData = reader.GetInt16(0);
                        }
                        reader.Close();
                    }
                    connection.Close();
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT COUNT(*) " +
                                                    "FROM AUTHOR_INFO ";

                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            returnData = reader.GetInt16(0);
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public int GetPublisherInfoNumberOfElements()
        {
            int returnData = 0;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT COUNT(*) " +
                                                    "FROM PUBLISHER_INFO ";

                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            returnData = reader.GetInt16(0);
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText =
                            "SELECT MANGA_TITLE, MANGA_DESCRIPTION, MANGA_PUBLICATION_DATE, MANGA_PUBLICATION_STATUS " +
                            "FROM MANGA_INFO " +
                            "WHERE MANGA_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, mangaId);
                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        returnData.Title = dataTable.Rows[0][0].ToString();
                        returnData.Description = dataTable.Rows[0][1].ToString();
                        returnData.PublicationDate = DateTime.Parse(dataTable.Rows[0][2].ToString());
                        returnData.PublicationStatus = dataTable.Rows[0][3].ToString();
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText =
                            "SELECT AUTHOR_NAME, AUTHOR_NATIONALITY, AUTHOR_BIRTHDAY, AUTHOR_WEBSITE " +
                            "FROM AUTHOR_INFO " +
                            "WHERE AUTHOR_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, authorId);
                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        returnData.Name = dataTable.Rows[0][0].ToString();
                        returnData.Country = dataTable.Rows[0][1].ToString();
                        returnData.Birthday = DateTime.Parse(dataTable.Rows[0][2].ToString());
                        returnData.Website = dataTable.Rows[0][3].ToString();
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText =
                            "SELECT PUBLISHER_NAME, PUBLISHER_COUNTRY, PUBLISHER_WEBSITE, PUBLISHER_NOTE " +
                            "FROM PUBLISHER_INFO " +
                            "WHERE PUBLISHER_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, publisherId);
                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        returnData.Name = dataTable.Rows[0][0].ToString();
                        returnData.Country = dataTable.Rows[0][1].ToString();
                        returnData.Website = dataTable.Rows[0][2].ToString();
                        returnData.Note = dataTable.Rows[0][3].ToString();
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    byte[] imageArray = new byte[6000];
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT MANGA_COVER " +
                                                    "FROM MANGA_INFO " +
                                                    "WHERE MANGA_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, mangaId);
                        SQLiteDataReader reader = selectCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            imageArray = GetBytes(reader);
                        }
                        reader.Close();
                    }
                    connection.Close();
                    return Image.FromStream(new MemoryStream(imageArray));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
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
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT AI.AUTHOR_NAME " +
                                                    "FROM AUTHOR_INFO AI, MANGA_AUTHORS MA, MANGA_INFO MI " +
                                                    "WHERE AI.AUTHOR_ID = MA.AUTHOR_ID AND MA.MANGA_ID = MI.MANGA_ID AND " +
                                                    "MI.MANGA_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, mangaId);

                        SQLiteDataReader reader = selectCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            returnData.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public List<string> GetGenresList(int mangaId)
        {
            List<string> returnData = new List<string>();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT GI.GENRE_NAME " +
                                                    "FROM GENRE_INFO GI, MANGA_GENRES MG, MANGA_INFO MI " +
                                                    "WHERE GI.GENRE_ID = MG.GENRE_ID AND MG.MANGA_ID = MI.MANGA_ID AND " +
                                                    "MI.MANGA_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, mangaId);

                        SQLiteDataReader reader = selectCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            returnData.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public string GetPublisherName(int mangaId)
        {
            string returnData = null;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT PI.PUBLISHER_NAME " +
                                                    "FROM PUBLISHER_INFO PI, MANGA_INFO MI " +
                                                    "WHERE PI.PUBLISHER_ID = MI.MANGA_PUBLISHER_ID AND MI.MANGA_ID = ?";

                        selectCommand.Parameters.AddWithValue(null, mangaId);

                        SQLiteDataReader reader = selectCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            returnData = reader.GetString(0);
                        }

                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public void SetMangaCover(int mangaId, byte[] mangaCover)
        {
            if (mangaId <= 0)
                return;

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand updateCommand = new SQLiteCommand(connection))
                {
                    updateCommand.CommandText = "UPDATE MANGA_INFO " +
                                                "SET MANGA_COVER = ? " +
                                                "WHERE MANGA_ID = ?";
                    updateCommand.Parameters.AddWithValue(null, mangaCover);
                    updateCommand.Parameters.AddWithValue(null, mangaId);
                    updateCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<string> GetNonSelectedAuthors(int mangaId)
        {
            List<string> returnData = new List<string> {""};
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT AUTHOR_NAME " +
                                                    "FROM AUTHOR_INFO " +
                                                    "WHERE AUTHOR_NAME NOT IN " +
                                                    "(SELECT AI.AUTHOR_NAME " +
                                                    "FROM AUTHOR_INFO AI, MANGA_AUTHORS MA, MANGA_INFO MI " +
                                                    "WHERE AI.AUTHOR_ID = MA.AUTHOR_ID AND MA.MANGA_ID = MI.MANGA_ID AND " +
                                                    "MI.MANGA_ID = ? )";

                        selectCommand.Parameters.AddWithValue(null, mangaId);

                        SQLiteDataReader reader = selectCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            returnData.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public List<string> GetNonSelectedGenresList(int mangaId)
        {
            List<string> returnData = new List<string> {""};
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();
                    using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                    {
                        selectCommand.CommandText = "SELECT GENRE_NAME " +
                                                    "FROM GENRE_INFO " +
                                                    "WHERE GENRE_NAME NOT IN " +
                                                    "(SELECT GI.GENRE_NAME " +
                                                    "FROM GENRE_INFO GI, MANGA_GENRES MG, MANGA_INFO MI " +
                                                    "WHERE GI.GENRE_ID = MG.GENRE_ID AND MG.MANGA_ID = MI.MANGA_ID AND " +
                                                    "MI.MANGA_ID = ? )";

                        selectCommand.Parameters.AddWithValue(null, mangaId);

                        SQLiteDataReader reader = selectCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            returnData.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.LogError(ex);
            }
            return returnData;
        }

        public List<MangaInfo> GetAllMangaInfoElements()
        {
            List<MangaInfo> returnData = new List<MangaInfo>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                {
                    selectCommand.CommandText = "SELECT * " +
                                                "FROM MANGA_INFO";
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    using (DataTable mDataTable = new DataTable())
                    {
                        mDataTable.Load(reader);
                        returnData.AddRange(from DataRow row in mDataTable.Rows
                                            select new MangaInfo
                                                       {
                                                           Id = uint.Parse(row[0].ToString()),
                                                           Title = row[1].ToString(),
                                                           Description = row[2].ToString(),
                                                           PublicationDate =
                                                               !string.IsNullOrEmpty(row[3].ToString())
                                                                   ? DateTime.Parse(row[3].ToString())
                                                                   : (DateTime?) null,
                                                           PublicationStatus = row[4].ToString(),
                                                           PublisherId =
                                                               !string.IsNullOrEmpty(row[5].ToString())
                                                                   ? uint.Parse(row[5].ToString())
                                                                   : 0,
                                                           Image = Convert.ToBase64String((byte[]) row[6])
                                                       });
                    }
                    reader.Close();
                }
                connection.Close();
            }

            return returnData;
        }

        public List<AuthorInfo> GetAllAuthorInfoElements()
        {
            List<AuthorInfo> returnData = new List<AuthorInfo>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                {
                    selectCommand.CommandText = "SELECT * " +
                                                "FROM AUTHOR_INFO";
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    using (DataTable mDataTable = new DataTable())
                    {
                        mDataTable.Load(reader);
                        returnData.AddRange(from DataRow row in mDataTable.Rows
                                            select new AuthorInfo
                                                       {
                                                           Id = uint.Parse(row[0].ToString()),
                                                           Name = row[1].ToString(),
                                                           Country = row[2].ToString(),
                                                           Birthday =
                                                               !string.IsNullOrEmpty(row[3].ToString())
                                                                   ? DateTime.Parse(row[3].ToString())
                                                                   : (DateTime?) null,
                                                           Website = row[4].ToString()
                                                       });
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return returnData;
        }

        public List<PublisherInfo> GetAllPublisherInfoElements()
        {
            List<PublisherInfo> returnData = new List<PublisherInfo>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                {
                    selectCommand.CommandText = "SELECT * " +
                                                "FROM PUBLISHER_INFO";
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    using (DataTable mDataTable = new DataTable())
                    {
                        mDataTable.Load(reader);
                        returnData.AddRange(from DataRow row in mDataTable.Rows
                                            select new PublisherInfo
                                                       {
                                                           Id = uint.Parse(row[0].ToString()),
                                                           Name = row[1].ToString(),
                                                           Country = row[2].ToString(),
                                                           Website = row[3].ToString(),
                                                           Note = row[4].ToString()
                                                       });
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return returnData;
        }

        public List<GenreInfo> GetAllGenreInfoElements()
        {
            List<GenreInfo> returnData = new List<GenreInfo>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                {
                    selectCommand.CommandText = "SELECT * " +
                                                "FROM GENRE_INFO";
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    using (DataTable mDataTable = new DataTable())
                    {
                        mDataTable.Load(reader);
                        returnData.AddRange(from DataRow row in mDataTable.Rows
                                            select
                                                new GenreInfo
                                                    {Id = uint.Parse(row[0].ToString()), Name = row[1].ToString()});
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return returnData;
        }

        public List<MangaGenre> GetAllMangaGenreElements()
        {
            List<MangaGenre> returnData = new List<MangaGenre>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                {
                    selectCommand.CommandText = "SELECT * " +
                                                "FROM MANGA_GENRES";
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    using (DataTable mDataTable = new DataTable())
                    {
                        mDataTable.Load(reader);
                        returnData.AddRange(from DataRow row in mDataTable.Rows
                                            select new MangaGenre
                                                       {
                                                           MangaId = uint.Parse(row[0].ToString()),
                                                           GenreId = uint.Parse(row[1].ToString())
                                                       });
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return returnData;
        }

        public List<MangaAuthor> GetAllMangaAuthorElements()
        {
            List<MangaAuthor> returnData = new List<MangaAuthor>();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand selectCommand = new SQLiteCommand(connection))
                {
                    selectCommand.CommandText = "SELECT * " +
                                                "FROM MANGA_AUTHORS";
                    SQLiteDataReader reader = selectCommand.ExecuteReader();
                    using (DataTable mDataTable = new DataTable())
                    {
                        mDataTable.Load(reader);
                        returnData.AddRange(from DataRow row in mDataTable.Rows
                                            select new MangaAuthor
                                                       {
                                                           MangaId = uint.Parse(row[0].ToString()),
                                                           AuthorId = uint.Parse(row[1].ToString())
                                                       });
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return returnData;
        }

        public void SetMangaInfoElement(MangaInfo info)
        {
            if (info == null)
                return;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                {
                    insertCommand.CommandText = "INSERT INTO MANGA_INFO " +
                                                "(MANGA_ID, MANGA_TITLE, MANGA_DESCRIPTION, MANGA_PUBLICATION_DATE, MANGA_PUBLICATION_STATUS, " +
                                                "MANGA_PUBLISHER_ID, MANGA_COVER) VALUES (?, ?, ?, ?, ?, ?, ?)";
                    insertCommand.Parameters.AddWithValue(null, info.Id);
                    insertCommand.Parameters.AddWithValue(null, info.Title);
                    insertCommand.Parameters.AddWithValue(null, info.Description);
                    insertCommand.Parameters.AddWithValue(null, info.PublicationDate);
                    insertCommand.Parameters.AddWithValue(null, info.PublicationStatus);
                    insertCommand.Parameters.AddWithValue(null, info.PublisherId);
                    insertCommand.Parameters.AddWithValue(null, Convert.FromBase64String(info.Image));
                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void SetAuthorInfoElement(AuthorInfo info)
        {
            if (info == null)
                return;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                {
                    insertCommand.CommandText =
                        "INSERT INTO AUTHOR_INFO (AUTHOR_ID, AUTHOR_NAME, AUTHOR_NATIONALITY, " +
                        "AUTHOR_BIRTHDAY, AUTHOR_WEBSITE ) VALUES (?, ?, ?, ?, ?)";
                    insertCommand.Parameters.AddWithValue(null, info.Id);
                    insertCommand.Parameters.AddWithValue(null, info.Name);
                    insertCommand.Parameters.AddWithValue(null, info.Country);
                    insertCommand.Parameters.AddWithValue(null, info.Birthday);
                    insertCommand.Parameters.AddWithValue(null, info.Website);
                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void SetPublisherInfoElement(PublisherInfo info)
        {
            if (info == null)
                return;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                {
                    insertCommand.CommandText =
                        "INSERT INTO PUBLISHER_INFO (PUBLISHER_ID, PUBLISHER_NAME, " +
                        "PUBLISHER_COUNTRY, PUBLISHER_WEBSITE, PUBLISHER_NOTE) values (?, ?, ?, ?, ?)";
                    insertCommand.Parameters.AddWithValue(null, info.Id);
                    insertCommand.Parameters.AddWithValue(null, info.Name);
                    insertCommand.Parameters.AddWithValue(null, info.Country);
                    insertCommand.Parameters.AddWithValue(null, info.Website);
                    insertCommand.Parameters.AddWithValue(null, info.Note);
                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void SetGenreInfoElement(GenreInfo info)
        {
            if (info == null)
                return;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                {
                    insertCommand.CommandText =
                        "INSERT INTO GENRE_INFO (GENRE_ID, GENRE_NAME) VALUES (?, ?)";
                    insertCommand.Parameters.AddWithValue(null, info.Id);
                    insertCommand.Parameters.AddWithValue(null, info.Name);

                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void SetMangaGenreElement(MangaGenre info)
        {
            if (info == null)
                return;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                {
                    insertCommand.CommandText =
                        "INSERT INTO MANGA_GENRES (MANGA_ID, GENRE_ID) VALUES (?, ?)";
                    insertCommand.Parameters.AddWithValue(null, info.MangaId);
                    insertCommand.Parameters.AddWithValue(null, info.GenreId);
                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void SetMangaAuthorElement(MangaAuthor info)
        {
            if (info == null)
                return;
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                {
                    insertCommand.CommandText =
                        "INSERT INTO MANGA_AUTHORS (MANGA_ID, AUTHOR_ID) VALUES (?, ?)";
                    insertCommand.Parameters.AddWithValue(null, info.MangaId);
                    insertCommand.Parameters.AddWithValue(null, info.AuthorId);
                    insertCommand.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}