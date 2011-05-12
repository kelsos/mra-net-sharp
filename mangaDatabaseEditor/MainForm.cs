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
		//TODO: db object with using in each method.
		private Mds db = new Mds(Properties.Settings.Default.DbConnection);

		private void refreshMangaData()
		{
			mangaInfoBindingSource.DataSource =
				from manga in db.M_mangaInfo
				orderby manga.MangaID
				select manga;
			mangaInfoBindingSource.MoveFirst();
		}

		private void refreshAuthorData()
		{
			authorTableBindingSource.DataSource =
				from author in db.M_authorInfo
				orderby author.AuthorID
				select author;
			mangaAuthorsBindingSource.MoveFirst();
		}

		private void refreshPublisherData()
		{
			publisherInfoBindingSource.DataSource =
				from publishers in db.M_publisherInfo
				orderby publishers.PublisherID
				select publishers;
			publisherInfoBindingSource.MoveFirst();
		}

		private void loadGenreData()
		{
			genreNameComboBox.DataSource =
				from genres in db.M_genreInfo
				orderby genres.GenreID
				select genres.GenreName;
		}

		private void loadMangaGenre()
		{
			genreNameListBox.DataSource =
				from mg in db.Mm_mangaGenres
				where mg.Mm_mangaID == Convert.ToInt32(mangaIDTextBox.Text)
				select mg.M_genreInfo.GenreName;
		}

		private void loadAuthorData()
		{
			authorsComboBox.DataSource =
				from auth in db.M_authorInfo
				orderby auth.AuthorID
				select auth.AuthorFullName;
		}

		private void loadAuthorManga()
		{
			authorsNameListBox.DataSource =
				from auth in db.Mm_mangaAuthors
				where auth.Ma_mangaID == Convert.ToInt32(mangaIDTextBox.Text)
				select auth.M_authorInfo.AuthorFullName;
		}

		private void loadPublisherData()
		{
			publisherComboBox.DataSource =
				from publishers in db.M_publisherInfo
				orderby publishers.PublisherName
				select publishers.PublisherName;
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
            if (!String.IsNullOrEmpty(mangaIDTextBox.Text))
            {
                var image = (from current in db.M_mangaInfo
                             where current.MangaID == Convert.ToInt32(mangaIDTextBox.Text)
                             select current.MangaCover).Single();
                byte[] imageByte = (byte[])image.ToArray();
                mangaCoverPictureBox.Image = Image.FromStream(new MemoryStream(imageByte));
            }
		}

		private void loadMangaPublisher()
		{
			publisherNameTextBox1.Text = "";
            if (!String.IsNullOrEmpty(mangaIDTextBox.Text))
            {
                var curPubID = (from current in db.M_mangaInfo
                                where current.MangaID == Convert.ToInt32(mangaIDTextBox.Text)
                                select current.MangaPublisherID).Single();
                if (curPubID != null)
                {
                    var publisherName = (from current in db.M_publisherInfo
                                         where current.PublisherID == curPubID
                                         select current.PublisherName).Single();
                    publisherNameTextBox1.Text = publisherName;
                }
            }
		}

		#endregion Private Methods

		private void mangaInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			mangaInfoBindingSource.EndEdit();
			db.SubmitChanges();
			refreshMangaData();
		}

		private void authorTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			authorTableBindingSource.EndEdit();
			db.SubmitChanges();
			refreshAuthorData();
			loadAuthorData();
		}

		private void publisherInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			publisherInfoBindingSource.EndEdit();
			db.SubmitChanges();
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
				(from genres in db.M_genreInfo
				 where genres.GenreName.Equals(genreNameComboBox.Text)
				 select genres.GenreID).Single();
			var mangaGen = (from mg in db.Mm_mangaGenres
								 where mg.Mm_genreID == genID && mg.Mm_mangaID == Convert.ToInt32(mangaIDTextBox.Text)
								 select mg).SingleOrDefault();
			if (mangaGen == null)
			{
				mgE = true;
			}
			if (mgE == true)
			{
				Mm_mangaGenres mangaGenre = new Mm_mangaGenres
				{
					Mm_genreID = genID,
					Mm_mangaID = Convert.ToInt32(mangaIDTextBox.Text)
				};
				db.Mm_mangaGenres.InsertOnSubmit(mangaGenre);
				db.SubmitChanges();
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
					(from genres in db.M_genreInfo
					 where genres.GenreName.Equals(genreNameListBox.SelectedItem.ToString())
					 select genres.GenreID).Single();

				var deleteMangaGenre = from mg in db.Mm_mangaGenres
											  where (mg.Mm_mangaID == Convert.ToInt32(mangaIDTextBox.Text)) && (mg.Mm_genreID == genID)
											  select mg;
				foreach (var mg in deleteMangaGenre)
				{
					db.Mm_mangaGenres.DeleteOnSubmit(mg);
				}
				db.SubmitChanges();
			}
			loadMangaGenre();
		}

		private void addAuthorButton_Click(object sender, EventArgs e)
		{
			bool auE = false;
			var authID =
				(from auth in db.M_authorInfo
				 where auth.AuthorFullName.Equals(authorsComboBox.Text)
				 select auth.AuthorID).Single();

			var mangaAuth = (from ma in db.Mm_mangaAuthors
								  where ma.Ma_authorID == authID && ma.Ma_mangaID == Convert.ToInt32(mangaIDTextBox.Text)
								  select ma).SingleOrDefault();
			if (mangaAuth == null)
			{
				auE = true;
			}
			if (auE == true)
			{
				Mm_mangaAuthors mangaAuthor = new Mm_mangaAuthors
				{
					Ma_authorID = authID,
					Ma_mangaID = Convert.ToInt32(mangaIDTextBox.Text)
				};
				db.Mm_mangaAuthors.InsertOnSubmit(mangaAuthor);
				db.SubmitChanges();
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
						(from auth in db.M_authorInfo
						 where auth.AuthorFullName.Equals(authorsNameListBox.SelectedItem.ToString())
						 select auth.AuthorID).Single();

					var deleteMangaAuthor = from ma in db.Mm_mangaAuthors
													where (ma.Ma_mangaID == Convert.ToInt32(mangaIDTextBox.Text)) && (ma.Ma_authorID == authID)
													select ma;
					foreach (var ma in deleteMangaAuthor)
					{
						db.Mm_mangaAuthors.DeleteOnSubmit(ma);
					}
					db.SubmitChanges();
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
				(from pub in db.M_publisherInfo
				 where pub.PublisherName.Equals(publisherComboBox.SelectedItem.ToString())
				 select pub.PublisherID).Single();
			var mangaPublisher =
				(from manga in db.M_mangaInfo
				 where (manga.MangaID == Convert.ToInt32(mangaIDTextBox.Text))
				 select manga).Single();
			mangaPublisher.MangaPublisherID = publID;
			db.SubmitChanges();
			loadMangaPublisher();
		}

		private void removePublisherButton_Click(object sender, EventArgs e)
		{
			var mangaPublisher = (from manga in db.M_mangaInfo
										 where (manga.MangaID == Convert.ToInt32(mangaIDTextBox.Text))
										 select manga).Single();
			mangaPublisher.MangaPublisherID = null;
			db.SubmitChanges();
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
			var mangaCoverImage = (from image in db.M_mangaInfo
										  where image.MangaID == Convert.ToInt16(mangaIDTextBox.Text)
										  select image).Single();
			mangaCoverImage.MangaCover = binary_file;
			db.SubmitChanges();
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
            //TODO: Not null & more checks.
            if (ExportDatabaseSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DatabaseInfoExporter(ExportDatabaseSaveFileDialog.FileName);
            }
		}

		private void DatabaseInfoExporter(string fileName)
		{
			var publisherData = from publishers in db.M_publisherInfo
									  select publishers;
			var genreData = from genres in db.M_genreInfo
								 select genres;
			var authorData = from authors in db.M_authorInfo
								  select authors;
			var mangaData = from mangas in db.M_mangaInfo
								 select mangas;
			var mangaGenreData = from mangaGenresInfo in db.Mm_mangaGenres
										select mangaGenresInfo;
			var mangaAuthorData = from mangaAuthorsInfo in db.Mm_mangaAuthors
										 select mangaAuthorsInfo;

			XDocument xDoc = new XDocument();
			XDeclaration xDeclaration = new XDeclaration("1.0", "utf-8", "yes");
			XComment xComment = new XComment("Manga Reading Assistant Database Exporter");

			XElement publisherXElement = new XElement("Publishers",
						from entry in publisherData
						select new XElement("Publisher",
							new XElement("PublisherID", entry.PublisherID),
							new XElement("PublisherName", entry.PublisherName),
							new XElement("PublisherCountry", entry.PublisherCountry),
							new XElement("PublisherWebsite", entry.PublisherWebsite),
							new XElement("PublisherNote", entry.PublisherNote))
					);
			XElement genresXElement = new XElement("Genres",
						from entry in genreData
						select new XElement("Genre",
							new XElement("GenreID", entry.GenreID),
							new XElement("GenreName", entry.GenreName))
					);

			XElement authorXElement = new XElement("Authors",
						from entry in authorData
						select new XElement("Author",
							new XElement("AuthorID", entry.AuthorID),
							new XElement("AuthorName", entry.AuthorFullName),
							new XElement("AuthorCountry", entry.AuthorCountryOfOrigin),
							new XElement("AuthorBirth", entry.AuthorDateOfBirth),
							new XElement("AuthorWebsite", entry.AuthorWebsite))
					);

			XElement mangaXElement = new XElement("Mangas",
						from entry in mangaData
						select new XElement("Manga",
							new XElement("MangaID", entry.MangaID),
							new XElement("MangaTitle", entry.MangaTitle),
							new XElement("MangaYearOfPublish", entry.MangaYearOfPublisher),
							new XElement("MangaStatus", entry.MangaStatus),
							new XElement("MangaPublisherID", entry.MangaPublisherID),
							new XElement("MangaDescription", entry.MangaDescription),
							new XElement("MangaCover", Convert.ToBase64String(entry.MangaCover.ToArray())))
					);

			XElement mangaGenreXElement = new XElement("MangaGenres",
						from entry in mangaGenreData
						select new XElement("MangaGenre",
							new XElement("MangaID", entry.Mm_mangaID),
							new XElement("GenreID", entry.Mm_genreID))
					);

			XElement mangaAuthorsXElement = new XElement("MangaAuthors",
				from entry in mangaAuthorData
				select new XElement("MangaAuthor",
					new XElement("MangaID", entry.Ma_mangaID),
					new XElement("AuthorID", entry.Ma_authorID))
		 );
			xDoc.Declaration = xDeclaration;
			xDoc.Add(xComment);
			xDoc.Add(new XElement("MangaDatabase"));
			xDoc.Root.Add(publisherXElement);
			xDoc.Root.Add(genresXElement);
			xDoc.Root.Add(authorXElement);
			xDoc.Root.Add(mangaXElement);
			xDoc.Root.Add(mangaGenreXElement);
			xDoc.Root.Add(mangaAuthorsXElement);
			xDoc.Save(fileName);
		}

		private void databaseInfoImporter(string fileName)
		{
			using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
			{
				//TODO: Fix the Import - Export Progress Report
				XDocument xDoc = XDocument.Load(fileName);
				tableLoadProgress.Maximum = 6;
				tableLoadProgress.Value = 0;

				var publisherData = from data in xDoc.Descendants("Publisher")
										  select new
										  {
											  PublisherID = (int)data.Element("PublisherID"),
											  PublisherName = (string)data.Element("PublisherName"),
											  PublisherCountry = (string)data.Element("PublisherCountry") ?? "",
											  PublisherWebsite = (string)data.Element("PublisherWebsite") ?? "",
											  PublisherNote = (string)data.Element("PublisherNote") ?? ""
										  };

				currentTableLoadProgress.Maximum = publisherData.Count();
				currentTableLoadProgress.Value = 0;

				foreach (var line in publisherData)
				{
					M_publisherInfo publisher = new M_publisherInfo()
					{
						PublisherID = line.PublisherID,
						PublisherName = line.PublisherName,
						PublisherCountry = line.PublisherCountry,
						PublisherWebsite = line.PublisherWebsite,
						PublisherNote = line.PublisherNote
					};
					db.M_publisherInfo.InsertOnSubmit(publisher);
					db.SubmitChanges();

					currentTableLoadProgress.Value++;
				}

				tableLoadProgress.Value++;

				var genresData = from data in xDoc.Descendants("Genre")
									  select new
									  {
										  GenreID = (int)data.Element("GenreID"),
										  GenreName = (string)data.Element("GenreName")
									  };

				currentTableLoadProgress.Maximum = genresData.Count();
				currentTableLoadProgress.Value = 0;

				foreach (var line in genresData)
				{
					M_genreInfo genre = new M_genreInfo()
					{
						GenreID = line.GenreID,
						GenreName = line.GenreName
					};
					db.M_genreInfo.InsertOnSubmit(genre);
					db.SubmitChanges();

					currentTableLoadProgress.Value++;
				}

				tableLoadProgress.Value++;

				var authorData = from data in xDoc.Descendants("Author")
									  select new
									  {
										  AuthorID = (int)data.Element("AuthorID"),
										  AuthorName = (string)data.Element("AuthorFullName"),
										  AuthorCountry = (string)data.Element("AuthorCountryOfOrigin") ?? "",
										  AuthorBirth = String.IsNullOrEmpty((string)data.Element("AuthorDateOfBirth")) ? (DateTime?)null : (DateTime)data.Element("AuthorDateOfBirth"),
										  AuthorWebsite = (string)data.Element("AuthorWebsite") ?? ""
									  };

				currentTableLoadProgress.Maximum = authorData.Count();
				currentTableLoadProgress.Value = 0;

				foreach (var line in authorData)
				{
					M_authorInfo authorInfo = new M_authorInfo
					{
						AuthorID = line.AuthorID,
						AuthorFullName = line.AuthorName,
						AuthorCountryOfOrigin = line.AuthorCountry,
						AuthorDateOfBirth = line.AuthorBirth,
						AuthorWebsite = line.AuthorWebsite
					};
					db.M_authorInfo.InsertOnSubmit(authorInfo);
					db.SubmitChanges();

					currentTableLoadProgress.Value++;
				}

				tableLoadProgress.Value++;

				var mangaData = from data in xDoc.Descendants("Manga")
									 select new
									 {
										 MangaID = (int)data.Element("MangaID"),
										 MangaTitle = (string)data.Element("MangaTitle"),
										 MangaYearOfPublish = String.IsNullOrEmpty((string)data.Element("MangaYearOfPublish")) ? (DateTime?)null : (DateTime)data.Element("MangaYearOfPublish"),
										 MangaStatus = (string)data.Element("MangaStatus") ?? "Ongoing",
										 MangaPublisherID = String.IsNullOrEmpty((string)data.Element("MangaPublisherID")) ? (int?)null : (int)data.Element("MangaPublisherID"),
										 MangaDescription = (string)data.Element("MangaDescription") ?? "",
										 MangaCover = (string)data.Element("MangaCover") ?? ""
									 };

				currentTableLoadProgress.Maximum = mangaData.Count();
				currentTableLoadProgress.Value = 0;

				foreach (var line in mangaData)
				{
					M_mangaInfo mangaInfo = new M_mangaInfo()
					{
						MangaID = line.MangaID,
						MangaTitle = line.MangaTitle,
						MangaYearOfPublisher = line.MangaYearOfPublish,
						MangaStatus = line.MangaStatus,
						MangaPublisherID = line.MangaPublisherID,
						MangaDescription = line.MangaDescription,
						MangaCover = new System.Data.Linq.Binary(Convert.FromBase64String(line.MangaCover))
					};
					db.M_mangaInfo.InsertOnSubmit(mangaInfo);
					db.SubmitChanges();

					currentTableLoadProgress.Value++;
				}
				tableLoadProgress.Value++;

				var mangaGenreData = from data in xDoc.Descendants("MangaGenre")
											select new
											{
												MangaID = (int)data.Element("MangaID"),
												GenreID = (int)data.Element("GenreID")
											};

				currentTableLoadProgress.Maximum = mangaGenreData.Count();
				currentTableLoadProgress.Value = 0;

				foreach (var line in mangaGenreData)
				{
					Mm_mangaGenres mangaGenreInfo = new Mm_mangaGenres()
					{
						Mm_mangaID = line.MangaID,
						Mm_genreID = line.GenreID
					};
					db.Mm_mangaGenres.InsertOnSubmit(mangaGenreInfo);
					db.SubmitChanges();

					currentTableLoadProgress.Value++;
				}

				tableLoadProgress.Value++;

				var mangaAuthorData = from data in xDoc.Descendants("MangaAuthor")
											 select new
											 {
												 MangaID = (int)data.Element("MangaID"),
												 AuthorID = (int)data.Element("AuthorID")
											 };

				currentTableLoadProgress.Maximum = mangaAuthorData.Count();
				currentTableLoadProgress.Value = 0;

				foreach (var line in mangaAuthorData)
				{
					Mm_mangaAuthors mangaAuthorInfo = new Mm_mangaAuthors()
					{
						Ma_mangaID = line.MangaID,
						Ma_authorID = line.AuthorID
					};
					db.Mm_mangaAuthors.InsertOnSubmit(mangaAuthorInfo);
					db.SubmitChanges();

					currentTableLoadProgress.Value++;
				}

				tableLoadProgress.Value++;

				//Refreshing all the data after the import
				refreshAuthorData();
				refreshPublisherData();
				loadGenreData();
				refreshMangaData();
				loadAuthorData();
				checkIfEntryExists();
				loadPublisherData();
			}
		}

		private void importDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (importDatabaseOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                databaseInfoImporter(importDatabaseOpenFileDialog.FileName);
            }
		}
	}
}

