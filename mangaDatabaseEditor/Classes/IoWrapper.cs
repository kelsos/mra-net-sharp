using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using mangaDbEditor.Classes.Data;

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
            XDocument xDoc = new XDocument {Declaration = new XDeclaration("1.0", "utf-8", "yes")};
            XComment xComment = new XComment("Manga Reading Assistant Database Exporter");
            xDoc.Add(xComment, new XElement("MangaDatabase"));
            if (xDoc.Root != null)
            {
                xDoc.Root.Add(PublisherXElement(DatabaseWrapper.Instance.GetAllPublisherInfoElements()));
                xDoc.Root.Add(GenresXElement(DatabaseWrapper.Instance.GetAllGenreInfoElements()));
                xDoc.Root.Add(AuthorXElement(DatabaseWrapper.Instance.GetAllAuthorInfoElements()));
                xDoc.Root.Add(MangaXElement(DatabaseWrapper.Instance.GetAllMangaInfoElements()));
                xDoc.Root.Add(MangaGenreXElement(DatabaseWrapper.Instance.GetAllMangaGenreElements()));
                xDoc.Root.Add(MangaAuthorsXElement(DatabaseWrapper.Instance.GetAllMangaAuthorElements()));
            }
            xDoc.Save(fileName);
        }

        private XElement MangaAuthorsXElement(IEnumerable<MangaAuthor> mangaAuthorData)
        {
            XElement mangaAuthorsXElement = new XElement("MangaAuthors",
                                                         from entry in mangaAuthorData
                                                         select new XElement("MangaAuthor",
                                                                             new XElement("MangaID", entry.MangaId),
                                                                             new XElement("AuthorID", entry.MangaId))
                );
            return mangaAuthorsXElement;
        }

        private XElement MangaGenreXElement(IEnumerable<MangaGenre> mangaGenreData)
        {
            XElement mangaGenreXElement = new XElement("MangaGenres",
                                                       from entry in mangaGenreData
                                                       select new XElement("MangaGenre",
                                                                           new XElement("MangaID", entry.MangaId),
                                                                           new XElement("GenreID", entry.GenreId))
                );
            return mangaGenreXElement;
        }

        private XElement MangaXElement(IEnumerable<MangaInfo> mangaData)
        {
            XElement mangaXElement = new XElement("Mangas",
                                                  from entry in mangaData
                                                  select new XElement("Manga",
                                                                      new XElement("MangaID", entry.Id),
                                                                      new XElement("MangaTitle", entry.Title),
                                                                      new XElement("MangaYearOfPublish",
                                                                                   entry.PublicationDate),
                                                                      new XElement("MangaStatus",
                                                                                   entry.PublicationStatus),
                                                                      new XElement("MangaPublisherID", entry.PublisherId),
                                                                      new XElement("MangaDescription", entry.Description),
                                                                      new XElement("MangaCover", entry.Image)));
            return mangaXElement;
        }

        private XElement AuthorXElement(IEnumerable<AuthorInfo> authorData)
        {
            XElement authorXElement = new XElement("Authors",
                                                   from entry in authorData
                                                   select new XElement("Author",
                                                                       new XElement("AuthorID", entry.Id),
                                                                       new XElement("AuthorName", entry.Name),
                                                                       new XElement("AuthorCountry", entry.Country),
                                                                       new XElement("AuthorBirth", entry.Birthday),
                                                                       new XElement("AuthorWebsite", entry.Website))
                );
            return authorXElement;
        }

        private XElement GenresXElement(IEnumerable<GenreInfo> genreData)
        {
            XElement genresXElement = new XElement("Genres",
                                                   from entry in genreData
                                                   select new XElement("Genre",
                                                                       new XElement("GenreID", entry.Id),
                                                                       new XElement("GenreName", entry.Name))
                );
            return genresXElement;
        }

        private XElement PublisherXElement(IEnumerable<PublisherInfo> publisherData)
        {
            XElement publisherXElement = new XElement("Publishers",
                                                      from entry in publisherData
                                                      select new XElement("Publisher",
                                                                          new XElement("Id", entry.Id),
                                                                          new XElement("Name", entry.Name),
                                                                          new XElement("Country", entry.Country),
                                                                          new XElement("Website", entry.Website),
                                                                          new XElement("Note", entry.Note))
                );
            return publisherXElement;
        }

        public void LoadFromXmlFile(string fileName)
        {
            XDocument xDoc = XDocument.Load(fileName);
            ReadPublisherInfo(xDoc);
            ReadGenreInfo(xDoc);
            ReadAuthorInfo(xDoc);
            ReadMangaInfo(xDoc);
            ReadMangaGenre(xDoc);
            ReadMangaAuthor(xDoc);
            //Refreshing all the data after the import
            //fire event.
        }

        private void ReadMangaAuthor(XDocument xDoc)
        {
            var maData = from data in xDoc.Descendants("MangaAuthor")
                         select new MangaAuthor
                                    {
                                        MangaId = (uint) data.Element("MangaID"),
                                        AuthorId = (uint) data.Element("AuthorID")
                                    };

            foreach (MangaAuthor ma in maData)
            {
                DatabaseWrapper.Instance.SetMangaAuthorElement(ma);
            }
        }

        private void ReadMangaGenre(XDocument xDoc)
        {
            var mgData = from data in xDoc.Descendants("MangaGenre")
                         select new MangaGenre
                                    {
                                        MangaId = (uint) data.Element("MangaID"),
                                        GenreId = (uint) data.Element("GenreID")
                                    };

            foreach (MangaGenre mg in mgData)
            {
                DatabaseWrapper.Instance.SetMangaGenreElement(mg);
            }
        }

        private void ReadMangaInfo(XDocument xDoc)
        {
            var mData = from data in xDoc.Descendants("Manga")
                        select new MangaInfo
                                   {
                                       Id = (uint) data.Element("MangaID"),
                                       Title = (string) data.Element("MangaTitle"),
                                       PublicationDate =
                                           String.IsNullOrEmpty((string) data.Element("MangaYearOfPublish"))
                                               ? (DateTime?) null
                                               : (DateTime) data.Element("MangaYearOfPublish"),
                                       PublicationStatus = (string) data.Element("MangaStatus") ?? "Ongoing",
                                       PublisherId = String.IsNullOrEmpty((string) data.Element("MangaPublisherID"))
                                                         ? 0
                                                         : (uint) data.Element("MangaPublisherID"),
                                       Description = (string) data.Element("MangaDescription") ?? "",
                                       Image = (string) data.Element("MangaCover") ?? ""
                                   };

            foreach (MangaInfo man in mData)
            {
                DatabaseWrapper.Instance.SetMangaInfoElement(man);
            }
        }

        private void ReadAuthorInfo(XDocument xDoc)
        {
            var aData = from data in xDoc.Descendants("Author")
                        select new AuthorInfo
                                   {
                                       Id = (uint) data.Element("AuthorID"),
                                       Name = (string) data.Element("AuthorName"),
                                       Country = (string) data.Element("AuthorCountry") ?? "",
                                       Birthday = String.IsNullOrEmpty((string) data.Element("AuthorBirth"))
                                                      ? (DateTime?) null
                                                      : (DateTime) data.Element("AuthorBirth"),
                                       Website = (string) data.Element("AuthorWebsite") ?? ""
                                   };

            foreach (AuthorInfo auth in aData)
            {
                DatabaseWrapper.Instance.SetAuthorInfoElement(auth);
            }
        }

        private void ReadGenreInfo(XDocument xDoc)
        {
            var gData = from data in xDoc.Descendants("Genre")
                        select new GenreInfo
                                   {
                                       Id = (uint) data.Element("GenreID"),
                                       Name = (string) data.Element("GenreName")
                                   };
            foreach (GenreInfo genre in gData)
            {
                DatabaseWrapper.Instance.SetGenreInfoElement(genre);
            }
        }

        private void ReadPublisherInfo(XDocument xDoc)
        {
            var pData = from data in xDoc.Descendants("Publisher")
                        select new PublisherInfo
                                   {
                                       Id = (uint) data.Element("PublisherID"),
                                       Name = (string) data.Element("PublisherName"),
                                       Country = (string) data.Element("PublisherCountry") ?? "",
                                       Website = (string) data.Element("PublisherWebsite") ?? "",
                                       Note = (string) data.Element("PublisherNote") ?? ""
                                   };
            foreach (PublisherInfo pub in pData)
            {
                DatabaseWrapper.Instance.SetPublisherInfoElement(pub);
            }
        }
    }
}