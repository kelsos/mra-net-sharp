using System;
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
            List<PublisherInfo> publisherData = DatabaseWrapper.Instance.GetAllPublisherInfoElements();
            List<GenreInfo> genreData = DatabaseWrapper.Instance.GetAllGenreInfoElements();
            List<AuthorInfo> authorData = DatabaseWrapper.Instance.GetAllAuthorInfoElements();
            List<MangaInfo> mangaData = DatabaseWrapper.Instance.GetAllMangaInfoElements();
            List<MangaGenre> mangaGenreData = DatabaseWrapper.Instance.GetAllMangaGenreElements();
            List<MangaAuthor> mangaAuthorData = DatabaseWrapper.Instance.GetAllMangaAuthorElements();

            XDocument xDoc = new XDocument();
            XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
            XComment xComment = new XComment("Manga Reading Assistant Database Exporter");

            var publisherXElement = new XElement("Publishers",
                                                 from entry in publisherData
                                                 select new XElement("Publisher",
                                                                     new XElement("Id", entry.Id),
                                                                     new XElement("Name", entry.Name),
                                                                     new XElement("Country", entry.Country),
                                                                     new XElement("Website", entry.Website),
                                                                     new XElement("Note", entry.Note))
                );
            var genresXElement = new XElement("Genres",
                                              from entry in genreData
                                              select new XElement("Genre",
                                                                  new XElement("GenreID", entry.Id),
                                                                  new XElement("GenreName", entry.Name))
                );

            var authorXElement = new XElement("Authors",
                                              from entry in authorData
                                              select new XElement("Author",
                                                                  new XElement("AuthorID", entry.Id),
                                                                  new XElement("AuthorName", entry.Name),
                                                                  new XElement("AuthorCountry", entry.Country),
                                                                  new XElement("AuthorBirth", entry.Birthday),
                                                                  new XElement("AuthorWebsite", entry.Website))
                );

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

            var mangaGenreXElement = new XElement("MangaGenres",
                                                  from entry in mangaGenreData
                                                  select new XElement("MangaGenre",
                                                                      new XElement("MangaID", entry.MangaId),
                                                                      new XElement("GenreID", entry.GenreId))
                );

            var mangaAuthorsXElement = new XElement("MangaAuthors",
                                                    from entry in mangaAuthorData
                                                    select new XElement("MangaAuthor",
                                                                        new XElement("MangaID", entry.MangaId),
                                                                        new XElement("AuthorID", entry.MangaId))
                );
            xDoc.Declaration = xDeclaration;
            xDoc.Add(xComment);
            xDoc.Add(new XElement("MangaDatabase"));
            if (xDoc.Root != null)
            {
                xDoc.Root.Add(publisherXElement);
                xDoc.Root.Add(genresXElement);
                xDoc.Root.Add(authorXElement);
                xDoc.Root.Add(mangaXElement);
                xDoc.Root.Add(mangaGenreXElement);
                xDoc.Root.Add(mangaAuthorsXElement);
            }
            xDoc.Save(fileName);
        }

        public void LoadFromXmlFile(string fileName)
        {
            XDocument xDoc = XDocument.Load(fileName);
            var pData = from data in xDoc.Descendants("Publisher")
                        select new PublisherInfo
                                   {
                                       Id = (uint)data.Element("PublisherID"),
                                       Name = (string)data.Element("PublisherName"),
                                       Country = (string)data.Element("PublisherCountry") ?? "",
                                       Website = (string)data.Element("PublisherWebsite") ?? "",
                                       Note = (string)data.Element("PublisherNote") ?? ""
                                   };
            foreach (PublisherInfo pub in pData)
            {
                DatabaseWrapper.Instance.SetPublisherInfoElement(pub);
            }

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

            var aData = from data in xDoc.Descendants("Author")
                        select new AuthorInfo
                                   {
                                       Id = (uint) data.Element("AuthorID"),
                                       Name = (string) data.Element("AuthorName"),
                                       Country = (string) data.Element("AuthorCountry") ?? "",
                                       Birthday = String.IsNullOrEmpty((string) data.Element("AuthorBirth"))
                                            ? (DateTime?) null : (DateTime) data.Element("AuthorBirth"),
                                       Website = (string) data.Element("AuthorWebsite") ?? ""
                                   };

            foreach (AuthorInfo auth in aData)
            {
                DatabaseWrapper.Instance.SetAuthorInfoElement(auth);
            }

            var mData = from data in xDoc.Descendants("Manga")
                            select new MangaInfo
                                       {
                                           Id = (uint) data.Element("MangaID"),
                                           Title = (string) data.Element("MangaTitle"),
                                           PublicationDate = String.IsNullOrEmpty((string) data.Element("MangaYearOfPublish"))
                                    ? (DateTime?) null : (DateTime) data.Element("MangaYearOfPublish"),
                                           PublicationStatus = (string) data.Element("MangaStatus") ?? "Ongoing",
                                           PublisherId = String.IsNullOrEmpty((string) data.Element("MangaPublisherID"))
                                    ? 0 : (uint) data.Element("MangaPublisherID"),
                                           Description = (string) data.Element("MangaDescription") ?? "",
                                           Image = (string) data.Element("MangaCover") ?? ""
                                       };

            foreach (MangaInfo man in mData)
            {
                DatabaseWrapper.Instance.SetMangaInfoElement(man);
            }

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

            //Refreshing all the data after the import
            //fire event.
        }
    }
}