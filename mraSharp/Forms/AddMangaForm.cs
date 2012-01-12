using System;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
    public partial class AddMangaForm : Form
    {
        private bool _displayAddedManga;
        private bool _setEntryInfo;
        private MangaRead _interFormCommunicator;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMangaForm"/> class.
        /// </summary>
        public AddMangaForm()
        {
            InitializeComponent();
            _displayAddedManga = false;
            _setEntryInfo = false;
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
            //try
            //{
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        if (mangaListComboBox.Text != null)
            //        {
            //            //var mID = (from current in db.MANGA_INFO
            //            //           where current.mangaTitle == mangaListComboBox.Text
            //            //           select current.MANGA_ID).SingleOrDefault();
            //            var mId = DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text);
            //            if (_setEntryInfo == false)
            //            {
            //                READING_LIST maReadList = new READING_LIST
            //                                              {
            //                                                  MANGA_ID = mId,
            //                                                  READ_NOTE = "",
            //                                                  READ_LAST_TIME = DateTime.Now,
            //                                                  READ_STARTING_CHAPTER = 1,
            //                                                  READ_CURRENT_CHAPTER = 1,
            //                                                  READ_IS_FINISHED = false,
            //                                                  READ_ONLINE_URL = ""
            //                                              };
            //                db.READING_LIST.AddObject(maReadList);
            //            }
            //            else
            //            {
            //                var mRl = new READING_LIST
            //                              {
            //                                  MANGA_ID = mId,
            //                                  READ_NOTE = _interFormCommunicator.PersonalNote,
            //                                  READ_LAST_TIME = _interFormCommunicator.LastRead,
            //                                  READ_STARTING_CHAPTER = (long?) _interFormCommunicator.StartingChapter,
            //                                  READ_CURRENT_CHAPTER = (long?) _interFormCommunicator.CurrentChapter,
            //                                  READ_IS_FINISHED = _interFormCommunicator.FinishedReading,
            //                                  READ_ONLINE_URL = _interFormCommunicator.OnlineURL
            //                              };
            //                db.READING_LIST.AddObject(mRl);
            //            }
            //            db.SaveChanges();
            //            _setEntryInfo = false;
            //            PopulateMangaListComboBox();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessageBox.Show(ex.Message, ex.ToString());
            //    Logger.ErrorLogger("error.txt", ex.ToString());
            //}
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
            _interFormCommunicator = new MangaRead();
            using (var sne = new SpecifyNewEntryInfoForm(ref _interFormCommunicator))
            {
                if (sne.ShowDialog() == DialogResult.OK)
                {
                    _setEntryInfo = true;
                }
            }
        }
    }
}