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
			genreInfoCustom.DataSource =
				from genres in mangaDatabase.genreInfos
				orderby genres.genreID
				select genres.genreName;
			genreInfoCustom.MoveFirst();
		}
		private void loadMangaGenre()
		{
			mangaGenreCustom.DataSource =
				from mg in mangaDatabase.mangaGenres
				where mg.mangaID.Equals(Convert.ToInt32(mangaIDTextBox.Text))
				select mg.genreInfo.genreName;
			mangaGenreCustom.MoveFirst();
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
		}

		private void genresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(GenresForm gF = new GenresForm())
			{
				gF.ShowDialog();
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
			mangaGenre mg = new mangaGenre
			{
				genreID = genreNameComboBox.SelectedIndex,
				mangaID = Convert.ToInt16(mangaIDTextBox.Text)
			};
			mangaDatabase.mangaGenres.InsertOnSubmit(mg);
			mangaDatabase.SubmitChanges();

		}

		private void mangaInfoBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			loadMangaGenre();
		}
	}
}
