using System.Collections.Generic;
using System.Linq;
using mangaDbEditor.Classes.Data;
using System.Xml.Linq;

namespace mangaDbEditor.Classes
{
    public sealed class IoWrapper
    {
        private static readonly IoWrapper ClassInstance = new IoWrapper();

        private IoWrapper()
        {
        }

        static IoWrapper()
        {
        }

        public static IoWrapper Instance
        {
            get { return ClassInstance; }
        }

        public void SaveToXmlFile(string fileName)
        {
            //   var publisherData = from publishers in db.M_publisherInfo
            //                             select publishers;
            //   var genreData = from genres in db.M_genreInfo
            //                        select genres;
            //   var authorData = from authors in db.M_authorInfo
            //                         select authors;
            //

            List<MangaInfo> mangaData = DatabaseWrapper.Instance.GetAllMangaInfoElements();
            //                        select mangas;
            //   var mangaGenreData = from mangaGenresInfo in db.Mm_mangaGenres
            //                               select mangaGenresInfo;
            //   var mangaAuthorData = from mangaAuthorsInfo in db.Mm_mangaAuthors
            //                                select mangaAuthorsInfo;
            
            XDocument xDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            XComment xComment = new XComment("Manga Reading Assistant Database Exporter");

            //   var publisherXElement = new XElement("Publishers",
            //               from entry in publisherData
            //               select new XElement("Publisher",
            //                   new XElement("PublisherID", entry.PublisherID),
            //                   new XElement("PublisherName", entry.PublisherName),
            //                   new XElement("PublisherCountry", entry.PublisherCountry),
            //                   new XElement("PublisherWebsite", entry.PublisherWebsite),
            //                   new XElement("PublisherNote", entry.PublisherNote))
            //           );
            //   var genresXElement = new XElement("Genres",
            //               from entry in genreData
            //               select new XElement("Genre",
            //                   new XElement("GenreID", entry.GenreID),
            //                   new XElement("GenreName", entry.GenreName))
            //           );

            //   var authorXElement = new XElement("Authors",
            //               from entry in authorData
            //               select new XElement("Author",
            //                   new XElement("AuthorID", entry.AuthorID),
            //                   new XElement("AuthorName", entry.AuthorFullName),
            //                   new XElement("AuthorCountry", entry.AuthorCountryOfOrigin),
            //                   new XElement("AuthorBirth", entry.AuthorDateOfBirth),
            //                   new XElement("AuthorWebsite", entry.AuthorWebsite))
            //           );

            var mangaXElement = new XElement("Mangas",
                                             from entry in mangaData
                                             select new XElement("Manga",
                                                                 new XElement("MangaID", entry.Id),
                                                                 new XElement("MangaTitle", entry.Title),
                                                                 new XElement("MangaYearOfPublish",
                                                                              entry.PublicationDate),
                                                                 new XElement("MangaStatus", entry.PublicationStatus),
                                                                 new XElement("MangaPublisherID", entry.PublisherId),
                                                                 new XElement("MangaDescription", entry.Description),
                                                                 new XElement("MangaCover", entry.Image)));

            //   var mangaGenreXElement = new XElement("MangaGenres",
            //               from entry in mangaGenreData
            //               select new XElement("MangaGenre",
            //                   new XElement("MangaID", entry.Mm_mangaID),
            //                   new XElement("GenreID", entry.Mm_genreID))
            //           );

            //   var mangaAuthorsXElement = new XElement("MangaAuthors",
            //       from entry in mangaAuthorData
            //       select new XElement("MangaAuthor",
            //           new XElement("MangaID", entry.Ma_mangaID),
            //           new XElement("AuthorID", entry.Ma_authorID))
            //);
               xDoc.Declaration = xDeclaration;
               xDoc.Add(xComment);
               xDoc.Add(new XElement("MangaDatabase"));
               if (xDoc.Root != null)
               {
            //       xDoc.Root.Add(publisherXElement);
            //       xDoc.Root.Add(genresXElement);
            //       xDoc.Root.Add(authorXElement);
                  xDoc.Root.Add(mangaXElement);
            //       xDoc.Root.Add(mangaGenreXElement);
            //       xDoc.Root.Add(mangaAuthorsXElement);
               }
               xDoc.Save(fileName);
        }

        public void LoadFromXmlFile(string fileName)
        {
            //using (Mds mds = new Mds(Properties.Settings.Default.DbConnection))
            //{
            //    //TODO: Fix the Import - Export Progress Report
            //    var xDoc = XDocument.Load(fileName);
            //    tableLoadProgress.Maximum = 6;
            //    tableLoadProgress.Value = 0;

            //    var publisherData = from data in xDoc.Descendants("Publisher")
            //                              select new
            //                              {
            //                                  PublisherID = (int)data.Element("PublisherID"),
            //                                  PublisherName = (string)data.Element("PublisherName"),
            //                                  PublisherCountry = (string)data.Element("PublisherCountry") ?? "",
            //                                  PublisherWebsite = (string)data.Element("PublisherWebsite") ?? "",
            //                                  PublisherNote = (string)data.Element("PublisherNote") ?? ""
            //                              };

            //    if (currentTableLoadProgress != null)
            //    {
            //        int count = publisherData.Count();
            //        currentTableLoadProgress.Maximum = count;
            //        currentTableLoadProgress.Value = 0;

            //        foreach (M_publisherInfo publisher in publisherData.Select(line => new M_publisherInfo()
            //                                                                               {
            //                                                                                   PublisherID = line.PublisherID, PublisherName = line.PublisherName, PublisherCountry = line.PublisherCountry, PublisherWebsite = line.PublisherWebsite, PublisherNote = line.PublisherNote
            //                                                                               }))
            //        {
            //            mds.M_publisherInfo.InsertOnSubmit(publisher);
            //            mds.SubmitChanges();

            //            currentTableLoadProgress.Value++;
            //        }
            //    }

            //    tableLoadProgress.Value++;

            //    var genresData = from data in xDoc.Descendants("Genre")
            //                          select new
            //                          {
            //                              GenreID = (int)data.Element("GenreID"),
            //                              GenreName = (string)data.Element("GenreName")
            //                          };

            //    if (currentTableLoadProgress != null)
            //    {
            //        currentTableLoadProgress.Maximum = genresData.Count();
            //        currentTableLoadProgress.Value = 0;

            //        foreach (var genre in genresData.Select(line => new M_genreInfo()
            //                                                            {
            //                                                                GenreID = line.GenreID,
            //                                                                GenreName = line.GenreName
            //                                                            }))
            //        {
            //            mds.M_genreInfo.InsertOnSubmit(genre);
            //            mds.SubmitChanges();

            //            currentTableLoadProgress.Value++;
            //        }
            //    }

            //    tableLoadProgress.Value++;

            //    var authorData = from data in xDoc.Descendants("Author")
            //                          select new
            //                          {
            //                              AuthorID = (int)data.Element("AuthorID"),
            //                              AuthorName = (string)data.Element("AuthorName"),
            //                              AuthorCountry = (string)data.Element("AuthorCountry") ?? "",
            //                              AuthorBirth = String.IsNullOrEmpty((string)data.Element("AuthorBirth")) ? (DateTime?)null : (DateTime)data.Element("AuthorBirth"),
            //                              AuthorWebsite = (string)data.Element("AuthorWebsite") ?? ""
            //                          };

            //    if (currentTableLoadProgress != null)
            //    {
            //        currentTableLoadProgress.Maximum = authorData.Count();
            //        currentTableLoadProgress.Value = 0;

            //        foreach (var authorInfo in authorData.Select(line => new M_authorInfo
            //                                                                 {
            //                                                                     AuthorID = line.AuthorID,
            //                                                                     AuthorFullName = line.AuthorName,
            //                                                                     AuthorCountryOfOrigin = line.AuthorCountry,
            //                                                                     AuthorDateOfBirth = line.AuthorBirth,
            //                                                                     AuthorWebsite = line.AuthorWebsite
            //                                                                 }))
            //        {
            //            mds.M_authorInfo.InsertOnSubmit(authorInfo);
            //            mds.SubmitChanges();

            //            currentTableLoadProgress.Value++;
            //        }
            //    }

            //    tableLoadProgress.Value++;

            //    var mangaData = from data in xDoc.Descendants("Manga")
            //                         select new
            //                         {
            //                             MangaID = (int)data.Element("MangaID"),
            //                             MangaTitle = (string)data.Element("MangaTitle"),
            //                             MangaYearOfPublish = String.IsNullOrEmpty((string)data.Element("MangaYearOfPublish")) ? (DateTime?)null : (DateTime)data.Element("MangaYearOfPublish"),
            //                             MangaStatus = (string)data.Element("MangaStatus") ?? "Ongoing",
            //                             MangaPublisherID = String.IsNullOrEmpty((string)data.Element("MangaPublisherID")) ? (int?)null : (int)data.Element("MangaPublisherID"),
            //                             MangaDescription = (string)data.Element("MangaDescription") ?? "",
            //                             MangaCover = (string)data.Element("MangaCover") ?? ""
            //                         };

            //    currentTableLoadProgress.Maximum = mangaData.Count();
            //    currentTableLoadProgress.Value = 0;

            //    foreach (var mangaInfo in mangaData.Select(line => new M_mangaInfo()
            //                                                           {
            //                                                               MangaID = line.MangaID,
            //                                                               MangaTitle = line.MangaTitle,
            //                                                               MangaYearOfPublisher = line.MangaYearOfPublish,
            //                                                               MangaStatus = line.MangaStatus,
            //                                                               MangaPublisherID = line.MangaPublisherID,
            //                                                               MangaDescription = line.MangaDescription,
            //                                                               MangaCover = new System.Data.Linq.Binary(Convert.FromBase64String(line.MangaCover))
            //                                                           }))
            //    {
            //        mds.M_mangaInfo.InsertOnSubmit(mangaInfo);
            //        mds.SubmitChanges();

            //        currentTableLoadProgress.Value++;
            //    }
            //    tableLoadProgress.Value++;

            //    var mangaGenreData = from data in xDoc.Descendants("MangaGenre")
            //                                select new
            //                                {
            //                                    MangaID = (int)data.Element("MangaID"),
            //                                    GenreID = (int)data.Element("GenreID")
            //                                };

            //    currentTableLoadProgress.Maximum = mangaGenreData.Count();
            //    currentTableLoadProgress.Value = 0;

            //    foreach (var mangaGenreInfo in mangaGenreData.Select(line => new Mm_mangaGenres()
            //                                                                     {
            //                                                                         Mm_mangaID = line.MangaID,
            //                                                                         Mm_genreID = line.GenreID
            //                                                                     }))
            //    {
            //        mds.Mm_mangaGenres.InsertOnSubmit(mangaGenreInfo);
            //        mds.SubmitChanges();

            //        currentTableLoadProgress.Value++;
            //    }

            //    tableLoadProgress.Value++;

            //    var mangaAuthorData = from data in xDoc.Descendants("MangaAuthor")
            //                                 select new
            //                                 {
            //                                     MangaID = (int)data.Element("MangaID"),
            //                                     AuthorID = (int)data.Element("AuthorID")
            //                                 };

            //    currentTableLoadProgress.Maximum = mangaAuthorData.Count();
            //    currentTableLoadProgress.Value = 0;

            //    foreach (var mangaAuthorInfo in mangaAuthorData.Select(line => new Mm_mangaAuthors()
            //                                                                       {
            //                                                                           Ma_mangaID = line.MangaID,
            //                                                                           Ma_authorID = line.AuthorID
            //                                                                       }))
            //    {
            //        mds.Mm_mangaAuthors.InsertOnSubmit(mangaAuthorInfo);
            //        mds.SubmitChanges();

            //        currentTableLoadProgress.Value++;
            //    }

            //    tableLoadProgress.Value++;

            //    //Refreshing all the data after the import
            //    RefreshAuthorData();
            //    RefreshPublisherData();
            //    LoadGenreData();
            //    RefreshMangaData();
            //    LoadAuthorData();
            //    HandleNewEntry();
            //    LoadPublisherData();
            //}
        }
    }
}