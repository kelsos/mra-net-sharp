using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mangaDatabaseEditor
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      #region Private Methods

      private MangaDBDataContext mangaDatabase = new MangaDBDataContext();

      private void refreshMangaData()
      {
         mangaInfoBindingSource.DataSource =
            from manga in mangaDatabase.mangaInfos
            orderby manga.mangaID
            select manga;
         mangaInfoBindingSource.MoveFirst();
      }

      private void refreshAuthorData()
      {
         authorTableBindingSource.DataSource =
            from author in mangaDatabase.authorTables
            orderby author.authorID
            select author;
         mangaAuthorsBindingSource.MoveFirst();
      }

      private void refreshPublisherData()
      {
         publisherInfoBindingSource.DataSource =
            from publishers in mangaDatabase.publisherInfos
            orderby publishers.publisherID
            select publishers;
         publisherInfoBindingSource.MoveFirst();
      }

      private void loadGenreData()
      {
         genreNameComboBox.DataSource =
            from genres in mangaDatabase.genreInfos
            orderby genres.genreID
            select genres.genreName;
      }

      private void loadMangaGenre()
      {
         genreNameListBox.DataSource =
            from mg in mangaDatabase.mangaGenres
            where mg.mangaID == Convert.ToInt32(mangaIDTextBox.Text)
            select mg.genreInfo.genreName;
      }

      private void loadAuthorData()
      {
         authorsComboBox.DataSource =
            from auth in mangaDatabase.authorTables
            orderby auth.authorID
            select auth.authorFullName;
      }

      private void loadAuthorManga()
      {
         authorsNameListBox.DataSource =
            from auth in mangaDatabase.mangaAuthors
            where auth.mangaID == Convert.ToInt32(mangaIDTextBox.Text)
            select auth.authorTable.authorFullName;
      }

      private void loadPublisherData()
      {
         publisherComboBox.DataSource =
            from publishers in mangaDatabase.publisherInfos
            orderby publishers.publisherName
            select publishers.publisherName;
      }

      private void checkIfEntryExists()
      {
         if (mangaIDTextBox.Text != null && mangaIDTextBox.Text != "0")
         {
            mangaAuthorGroupBox.Enabled = true;
            publisherGroupBox.Enabled = true;
            mangaGenresGroupBox.Enabled = true;
            buttonImageLoad.Enabled = true;
         }
         else
         {
            mangaAuthorGroupBox.Enabled = false;
            publisherGroupBox.Enabled = false;
            mangaGenresGroupBox.Enabled = false;
            buttonImageLoad.Enabled = false;
         }
      }

      private void loadCurrentImage()
      {
         var image = (from current in mangaDatabase.mangaInfos
                      where current.mangaID == Convert.ToInt32(mangaIDTextBox.Text)
                      select current.mangaCover).Single();
         byte[] imageByte = (byte[])image.ToArray();
         mangaCoverPictureBox.Image = Image.FromStream(new MemoryStream(imageByte));
      }

      private void loadMangaPublisher()
      {
         publisherNameTextBox1.Text = "";
         var curPubID = (from current in mangaDatabase.mangaInfos
                         where current.mangaID == Convert.ToInt32(mangaIDTextBox.Text)
                         select current.publisherID).Single();
         if (curPubID != null)
         {
            var publisherName = (from current in mangaDatabase.publisherInfos
                                 where current.publisherID == curPubID
                                 select current.publisherName).Single();
            publisherNameTextBox1.Text = publisherName;
         }
      }

      #endregion Private Methods

      private void mangaInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         Validate();
         mangaInfoBindingSource.EndEdit();
         mangaDatabase.SubmitChanges();
         refreshMangaData();
      }

      private void authorTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         Validate();
         authorTableBindingSource.EndEdit();
         mangaDatabase.SubmitChanges();
         refreshAuthorData();
         loadAuthorData();
      }

      private void publisherInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         Validate();
         publisherInfoBindingSource.EndEdit();
         mangaDatabase.SubmitChanges();
         refreshPublisherData();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         refreshAuthorData();
         refreshPublisherData();
         loadGenreData();
         refreshMangaData();
         loadAuthorData();
         checkIfEntryExists();
         loadPublisherData();
      }

      private void genresToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (GenresForm gF = new GenresForm())
         {
            gF.ShowDialog();
            loadGenreData();
         }
      }

      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (AboutForm ab = new AboutForm())
         {
            ab.ShowDialog();
         }
      }

      private void buttonImageLoad_Click(object sender, EventArgs e)
      {
         if (openImageFileDialog.ShowDialog() == DialogResult.OK)
         {
            mangaCoverPictureBox.Image = Image.FromFile(openImageFileDialog.FileName);
            imageToDatabaseLoader(ImageToByteArray(imageSizeToStandard(mangaCoverPictureBox.Image)));
         }
      }

      private void addGenreButton_Click(object sender, EventArgs e)
      {
         bool mgE = false;
         var genID =
            (from genres in mangaDatabase.genreInfos
             where genres.genreName.Equals(genreNameComboBox.Text)
             select genres.genreID).Single();
         var mangaGen = (from mg in mangaDatabase.mangaGenres
                         where mg.genreID == genID && mg.mangaID == Convert.ToInt32(mangaIDTextBox.Text)
                         select mg).SingleOrDefault();
         if (mangaGen == null)
         {
            mgE = true;
         }
         if (mgE == true)
         {
            mangaGenre mg = new mangaGenre
            {
               genreID = genID,
               mangaID = Convert.ToInt32(mangaIDTextBox.Text)
            };
            mangaDatabase.mangaGenres.InsertOnSubmit(mg);
            mangaDatabase.SubmitChanges();
         }
         loadMangaGenre();
      }

      private void mangaInfoBindingSource_CurrentChanged(object sender, EventArgs e)
      {
         loadMangaGenre();
         loadAuthorManga();
         loadCurrentImage();
         loadMangaPublisher();
      }

      private void removeGenreButton_Click(object sender, EventArgs e)
      {
         if (genreNameListBox.Items.Count >= 1)
         {
            var genID =
               (from genres in mangaDatabase.genreInfos
                where genres.genreName.Equals(genreNameListBox.SelectedItem.ToString())
                select genres.genreID).Single();

            var deleteMangaGenre = from mg in mangaDatabase.mangaGenres
                                   where (mg.mangaID == Convert.ToInt32(mangaIDTextBox.Text)) && (mg.genreID == genID)
                                   select mg;
            foreach (var mg in deleteMangaGenre)
            {
               mangaDatabase.mangaGenres.DeleteOnSubmit(mg);
            }
            mangaDatabase.SubmitChanges();
         }
         loadMangaGenre();
      }

      private void addAuthorButton_Click(object sender, EventArgs e)
      {
         bool auE = false;
         var authID =
            (from auth in mangaDatabase.authorTables
             where auth.authorFullName.Equals(authorsComboBox.Text)
             select auth.authorID).Single();

         var mangaAuth = (from ma in mangaDatabase.mangaAuthors
                          where ma.authorID == authID && ma.mangaID == Convert.ToInt32(mangaIDTextBox.Text)
                          select ma).SingleOrDefault();
         if (mangaAuth == null)
         {
            auE = true;
         }
         if (auE == true)
         {
            mangaAuthor ma = new mangaAuthor
            {
               authorID = authID,
               mangaID = Convert.ToInt32(mangaIDTextBox.Text)
            };
            mangaDatabase.mangaAuthors.InsertOnSubmit(ma);
            mangaDatabase.SubmitChanges();
         }
         loadAuthorManga();
      }

      private void removeAuthorButton_Click(object sender, EventArgs e)
      {
         try
         {
            if (authorsNameListBox.Items.Count >= 1)
            {
               var authID =
                  (from auth in mangaDatabase.authorTables
                   where auth.authorFullName.Equals(authorsNameListBox.SelectedItem.ToString())
                   select auth.authorID).Single();

               var deleteMangaAuthor = from ma in mangaDatabase.mangaAuthors
                                       where (ma.mangaID == Convert.ToInt32(mangaIDTextBox.Text)) && (ma.authorID == authID)
                                       select ma;
               foreach (var ma in deleteMangaAuthor)
               {
                  mangaDatabase.mangaAuthors.DeleteOnSubmit(ma);
               }
               mangaDatabase.SubmitChanges();
            }
            loadAuthorManga();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }

      private void addPublisherButton_Click(object sender, EventArgs e)
      {
         var publID =
            (from pub in mangaDatabase.publisherInfos
             where pub.publisherName.Equals(publisherComboBox.SelectedItem.ToString())
             select pub.publisherID).Single();
         var mangaPublisher =
            (from manga in mangaDatabase.mangaInfos
             where (manga.mangaID == Convert.ToInt32(mangaIDTextBox.Text))
             select manga).Single();
         mangaPublisher.publisherID = publID;
         mangaDatabase.SubmitChanges();
         loadMangaPublisher();
      }

      private void removePublisherButton_Click(object sender, EventArgs e)
      {
         var mangaPublisher = (from manga in mangaDatabase.mangaInfos
                               where (manga.mangaID == Convert.ToInt32(mangaIDTextBox.Text))
                               select manga).Single();
         mangaPublisher.publisherID = null;
         mangaDatabase.SubmitChanges();
         loadMangaPublisher();
      }

      private void mangaIDTextBox_TextChanged(object sender, EventArgs e)
      {
         checkIfEntryExists();
      }

      /// <summary>
      /// Image to byte array convertion. The function gets an Image and converts it to a byte array which it returns.
      /// </summary>
      /// <param name="myImage">My image.</param>
      /// <returns></returns>
      private byte[] ImageToByteArray(System.Drawing.Image myImage)
      {
         using (MemoryStream ms = new MemoryStream())
         {
            myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
         }
      }

      /// <summary>
      /// Inserts an image to the database entry with the specified MangaTitle.
      /// </summary>
      /// <param name="imageByteArray">The image byte array.</param>
      /// <param name="myMangaTitle">My manga title.</param>
      public void imageToDatabaseLoader(byte[] imageByteArray)
      {
         System.Data.Linq.Binary binary_file = new System.Data.Linq.Binary(imageByteArray);
         var mangaCoverImage = (from image in mangaDatabase.mangaInfos
                                where image.mangaID == Convert.ToInt16(mangaIDTextBox.Text)
                                select image).Single();
         mangaCoverImage.mangaCover = binary_file;
         mangaDatabase.SubmitChanges();
      }

      /// <summary>
      /// Get an Image in whatever Resolution and converts it to the closest to 160w*230h.
      /// </summary>
      /// <param name="sourceImage">The source image.</param>
      /// <returns>The resized Image</returns>
      private static Image imageSizeToStandard(Image sourceImage)
      {
         int sourceWidth = sourceImage.Width;
         int sourceHeight = sourceImage.Height;

         float nPercent = 0;
         float nPercentW = 0;
         float nPercentH = 0;

         nPercentW = ((float)160 / (float)sourceWidth);
         nPercentH = ((float)230 / (float)sourceHeight);

         if (nPercentH < nPercentW)
            nPercent = nPercentH;
         else
            nPercent = nPercentW;

         int destWidth = (int)(sourceWidth * nPercent);
         int destHeight = (int)(sourceHeight * nPercent);

         Bitmap bmp = new Bitmap(destWidth, destHeight);
         Graphics graph = Graphics.FromImage((Image)bmp);
         graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

         graph.DrawImage(sourceImage, 0, 0, destWidth, destHeight);
         graph.Dispose();

         return (Image)bmp;
      }

      private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DatabaseInfoExporter("temp.xml");
      }

      private void DatabaseInfoExporter(string fileName)
      {
         var publisherData = from publishers in mangaDatabase.publisherInfos
                             select publishers;
         var genreData = from genres in mangaDatabase.genreInfos
                         select genres;
         var authorData = from authors in mangaDatabase.authorTables
                          select authors;
         var mangaData = from mangas in mangaDatabase.mangaInfos
                         select mangas;
         var mangaGenreData = from mangaGenresInfo in mangaDatabase.mangaGenres
                              select mangaGenresInfo;
         var mangaAuthorData = from mangaAuthorsInfo in mangaDatabase.mangaAuthors
                               select mangaAuthorsInfo;
         XDocument xDoc = new XDocument(
               new XDeclaration("1.0", "utf-8", "yes"),
               new XComment("Manga Reading Assistant Database Exporter"),
               new XElement("Publishers",
                  from entry in publisherData
                  select new XElement("Publisher",
                     new XElement("PublisherID", entry.publisherID),
                     new XElement("PublisherName", entry.publisherName),
                     new XElement("PublisherCountry", entry.publisherCountry),
                     new XElement("PublisherWebsite", entry.publisherWebsite),
                     new XElement("PublisherNote", entry.publisherNote))
               ),
               new XElement("Genres",
                  from entry in genreData
                  select new XElement("Genre",
                     new XElement("GenreID", entry.genreID),
                     new XElement("GenreName", entry.genreName))
               ),
               new XElement("Authors",
                  from entry in authorData
                  select new XElement("Author",
                     new XElement("AuthorID", entry.authorID),
                     new XElement("AuthorName", entry.authorFullName),
                     new XElement("AuthorCountry", entry.authorCountryOfOrigin),
                     new XElement("AuthorBirth", entry.authorDateOfBirth),
                     new XElement("AuthorWebsite", entry.authorWebsite))
               ),
               new XElement("Manga",
                  from entry in mangaData
                  select new XElement("Manga",
                     new XElement("MangaID", entry.mangaID),
                     new XElement("MangaTitle", entry.mangaTitle),
                     new XElement("MangaDateOfPublish", entry.dateOfPublish),
                     new XElement("MangaStatus", entry.mangaStatus),
                     new XElement("MangaPublisher", entry.publisherID),
                     new XElement("MangaDescription", entry.mangaDescription),
                     new XElement("MangaCover", entry.mangaCover))
               ),
               new XElement("MangaGenres",
                  from entry in mangaGenreData
                  select new XElement("MangaGenre",
                     new XElement("MangaID", entry.mangaID),
                     new XElement("GenreID", entry.genreID))
               ),
               new XElement("MangaAuthors",
                  from entry in mangaAuthorData
                  select new XElement("MangaAuthor",
                     new XElement("MangaID", entry.mangaID),
                     new XElement("AuthorID", entry.authorID))
               )
             );
         xDoc.Save(fileName);
      }

   }
}