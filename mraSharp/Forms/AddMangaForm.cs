using System;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
    public partial class AddMangaForm : Form
    {
        private bool _displayAddedManga;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMangaForm"/> class.
        /// </summary>
        public AddMangaForm()
        {
            InitializeComponent();
            _displayAddedManga = false;
        }

        /// <summary>
        /// Handles the Load event of the AddMangaForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HandleFormLoad(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mangaListComboBox control. And Populates the various controls with the data for the currently selected manga.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HandleMangaListComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (mangaListComboBox.Text == null)
                return;
            mangaCoverPictureBox.Image =
                DatabaseWrapper.GetMangaCover(mangaListComboBox.Text);
            mangaTitleTextBox.Text = mangaListComboBox.Text;
            descriptionTextBox.Text =
                DatabaseWrapper.GetMangaDescriptions(mangaListComboBox.Text);
            yearTextBox.Text = DatabaseWrapper.GetMangaYearOfPublish(mangaListComboBox.Text).ToString();
            statusTextBox.Text = DatabaseWrapper.GetMangaStatus(mangaListComboBox.Text);
            publisherTextBox.Text = DatabaseWrapper.GetPublisherName(mangaListComboBox.Text);
            authorsListBox.DataSource = DatabaseWrapper.GetAuthorsList(mangaListComboBox.Text);
            genresListBox.DataSource = DatabaseWrapper.GetGenresList(mangaListComboBox.Text);
        }

        /// <summary>
        /// Handles the Click event of the addToReadingListButton control. The button adds the selected manga to the reading list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HandleAddToReadingListButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mangaListComboBox.Text))
                return;
            if(Communicator.Instance.GetReadItem()==null)
                DatabaseWrapper.InsertNewReadingItem(DatabaseWrapper.GetMangaId(mangaListComboBox.Text), 1, 0, "", false,
                                                 DateTime.Now, "");
            else
            {
                DatabaseWrapper.InsertNewReadingItem(Communicator.Instance.GetReadItem());
                Communicator.Instance.ClearReadItem();
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the displayMangaInMyListCheckBox control. If enabled the mangas already in the reading list are also displayed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HandleDisplayMangaInMyListCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            _displayAddedManga = !_displayAddedManga;
            mangaListComboBox.DataSource = DatabaseWrapper.GetMangaTitleList(_displayAddedManga);
        }

        /// <summary>
        /// Handles the Click event of the specifyNewEntryInfoButton control. Shows the form for the custom manga Info for the new entry.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SpecifyNewEntryInfoButtonClick(object sender, EventArgs e)
        {
            using (SpecifyNewEntryInfoForm entryInfoForm = new SpecifyNewEntryInfoForm())
            {
                if (entryInfoForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            Communicator.Instance.ClearReadItem();
        }
    }
}