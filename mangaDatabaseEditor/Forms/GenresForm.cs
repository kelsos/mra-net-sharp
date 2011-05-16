using System;
using System.Linq;
using System.Windows.Forms;

namespace mangaDatabaseEditor
{
	public partial class GenresForm : Form
	{
		public GenresForm()
		{
			InitializeComponent();
		}

		private Mds db = new Mds(Properties.Settings.Default.DbConnection);

		private void refreshGenres()
		{
			genreInfoBindingSource.DataSource =
				from genres in db.M_genreInfo
				orderby genres.GenreID
				select genres;
			genreInfoBindingSource.MoveFirst();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			genreInfoBindingSource.DataSource =
				from genres in db.M_genreInfo
				where genres.GenreName.Contains(searchTextBox.Text)
				orderby genres.GenreID
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
			db.SubmitChanges();
			refreshGenres();
		}

		private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				searchButton_Click(sender, e);
			}
		}
	}
}