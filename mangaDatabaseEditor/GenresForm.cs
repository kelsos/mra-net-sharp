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
	public partial class GenresForm : Form
	{
		public GenresForm()
		{
			InitializeComponent();
		}
		private MangaDBDataContext mangaDatabase = new MangaDBDataContext();

		private void refreshGenres()
		{
			genreInfoBindingSource.DataSource =
				from genres in mangaDatabase.genreInfos
				orderby genres.genreID
				select genres;
			genreInfoBindingSource.MoveFirst();
		}
		private void searchButton_Click(object sender, EventArgs e)
		{
			genreInfoBindingSource.DataSource =
				from genres in mangaDatabase.genreInfos
				where genres.genreName.Contains(searchTextBox.Text)
				orderby genres.genreID
				select genres;
			genreInfoBindingSource.MoveFirst();
		}

		private void GenresForm_Load(object sender, EventArgs e)
		{
			refreshGenres();
		}

		private void browseAllButton_Click(object sender, EventArgs e)
		{
			refreshGenres();
			searchTextBox.Text = "";
		}

		private void genreInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			genreInfoBindingSource.EndEdit();
			mangaDatabase.SubmitChanges();
			refreshGenres();
		}

		private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				searchButton_Click(sender,e);
			}
		}
	}
}
