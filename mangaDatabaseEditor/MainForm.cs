using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

#endregion 

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
		}

		private void genresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(GenresForm gF = new GenresForm())
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
			}
		}

		private void addGenreButton_Click(object sender, EventArgs e)
		{
			var genID = 
				(from genres in mangaDatabase.genreInfos
				where genres.genreName.Equals(genreNameComboBox.Text)
				select genres.genreID).Single();
	
			mangaGenre mg = new mangaGenre
			{
				genreID = genID,
				mangaID = Convert.ToInt32(mangaIDTextBox.Text)
			};
			mangaDatabase.mangaGenres.InsertOnSubmit(mg);
			mangaDatabase.SubmitChanges();
			loadMangaGenre();
		}

		private void mangaInfoBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			loadMangaGenre();
			loadAuthorManga();
		}

		private void removeGenreButton_Click(object sender, EventArgs e)
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
			loadMangaGenre();
		}

		private void addAuthorButton_Click(object sender, EventArgs e)
		{
			var authID =
				(from auth in mangaDatabase.authorTables
				 where auth.authorFullName.Equals(authorsComboBox.Text)
				 select auth.authorID).Single();

			mangaAuthor ma = new mangaAuthor
			{
				authorID = authID,
				mangaID = Convert.ToInt32(mangaIDTextBox.Text)
			};
			mangaDatabase.mangaAuthors.InsertOnSubmit(ma);
			mangaDatabase.SubmitChanges();
			loadAuthorManga();
		}

		private void removeAuthorButton_Click(object sender, EventArgs e)
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
			loadAuthorManga();
		}

		private void addPublisherButton_Click(object sender, EventArgs e)
		{

		}

		private void removePublisherButton_Click(object sender, EventArgs e)
		{

		}

		private void mangaIDTextBox_TextChanged(object sender, EventArgs e)
		{
			checkIfEntryExists();
		}
	}
}
