using System;
using System.Windows.Forms;

namespace mangaDbEditor.Forms
{
	public partial class GenresForm : Form
	{
		public GenresForm()
		{
			InitializeComponent();
		}

		private void refreshGenres()
		{
            //genreInfoBindingSource.DataSource =
            //    from genres in db.M_genreInfo
            //    orderby genres.GenreID
            //    select genres;
            //genreInfoBindingSource.MoveFirst();
		}

		private void HandleSearchButtonClick(object sender, EventArgs e)
		{
            //genreInfoBindingSource.DataSource =
            //    from genres in db.M_genreInfo
            //    where genres.GenreName.Contains(searchTextBox.Text)
            //    orderby genres.GenreID
            //    select genres;
            //genreInfoBindingSource.MoveFirst();
		}

		private void GenresFormLoad(object sender, EventArgs e)
		{
			refreshGenres();
		}

		private void HandleBrowseAllButtonClick(object sender, EventArgs e)
		{
			refreshGenres();
			searchTextBox.Text = "";
		}

		private void HandleGenreInfoBindingNavigatorSaveItemClick(object sender, EventArgs e)
		{
            //Validate();
            //genreInfoBindingSource.EndEdit();
            //db.SubmitChanges();
            //refreshGenres();
		}

		private void HandleSearchTextBoxKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				HandleSearchButtonClick(sender, e);
			}
		}
	}
}