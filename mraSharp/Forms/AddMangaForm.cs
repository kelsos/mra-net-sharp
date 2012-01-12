using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using mraSharp.Classes;
using mraSharp.Properties;

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
        private void AddMangaFormLoad(object sender, EventArgs e)
        {
            PopulateMangaListComboBox();
        }

        #region Linq to SQL

        /// <summary>
        /// Populates the manga list combo box.
        /// </summary>
        private void PopulateMangaListComboBox()
        {
            //try
            //{
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        //If display added manga check box is checked it will return every single manga in the list.
            //        if (_displayAddedManga)
            //        {
            //            mangaListComboBox.DataSource = from mangas in db.MANGA_INFO
            //                                           select mangas.MANGA_TITLE;
            //        }
            //            //Else it will return only the mangas not in the reading list.
            //        else
            //        {
            //            mangaListComboBox.DataSource = (from mg in db.MANGA_INFO
            //                                            select mg.MANGA_TITLE).Except(from mangas in db.MANGA_INFO
            //                                                                          where
            //                                                                              (from manga in db.READING_LIST
            //                                                                               select manga.MANGA_ID).
            //                                                                              Contains(mangas.MANGA_ID)
            //                                                                          select mangas.MANGA_TITLE);
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
        /// Gets the manga cover for the currently selected manga from the Database and it loads it to the manga Cover PictureBox
        /// </summary>
        private void GetMangaCover()
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

            //            var image = (from current in db.MANGA_INFO
            //                         where current.MANGA_ID == mId
            //                         select current.MANGA_COVER).Single();
            //            var imageByte = image.ToArray();

            //            mangaCoverPictureBox.Image = Image.FromStream(new MemoryStream(imageByte));
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
        /// Gets the manga description for the currently selected manga and displays it in the proper textbox.
        /// </summary>
        private void GetMangaDescription()
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

            //            var description = (from current in db.MANGA_INFO
            //                               where current.MANGA_ID == mId
            //                               select current.MANGA_DESCRIPTION).SingleOrDefault();
            //            descriptionTextBox.Text = description;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessageBox.Show(ex.Message, ex.ToString());
            //    Logger.ErrorLogger("error.txt", ex.ToString());
            //}
        }

/*
      /// <summary>
      /// Gets the authors of the currently selected manga and displays them on the proper list box.
      /// </summary>
      private void GetAuthors()
      {
         try
         {
            using (mdbEntities db = new mdbEntities())
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.MANGA_INFO
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MANGA_ID).SingleOrDefault();
                  var mID = DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text);

                  var authors = from current in db.Mm_mangaAuthors
                                join author in db.M_authorInfo
                                on current.Ma_authorID equals author.AuthorID
                                where current.Ma_MANGA_ID == mID
                                select author.AuthorFullName;
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }
*/

        /// <summary>
        /// Gets the year of the Mangas' first publish and posts it to the proper text box.
        /// </summary>
        private void GetYearOfFirstPublish()
        {
            //try
            //{
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        if (mangaListComboBox.Text != null)
            //        {
            //            var year = (from entry in db.MANGA_INFO
            //                        where entry.MANGA_ID == DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text)
            //                        select entry.MANGA_PUBLICATION_DATE).SingleOrDefault();

            //            yearTextBox.Text = year.HasValue
            //                                   ? year.Value.ToString("yyyy")
            //                                   : Resources.AddMangaForm_GetPublisherName__N_A_;
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
        /// Gets the name of the publisher for the currently selected manga and puts it on the proper textbox.
        /// </summary>
        private void GetPublisherName()
        {
            //try
            //{
            //    publisherTextBox.Text = "";
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        if (mangaListComboBox.Text != null)
            //        {
            //            var pubId = (from entry in db.MANGA_INFO
            //                         where entry.MANGA_ID == DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text)
            //                         select entry.MANGA_PUBLISHER_ID).SingleOrDefault();
            //            if (pubId != null)
            //            {
            //                var publisherName = (from entry in db.PUBLISHER_INFO
            //                                     where entry.PUBLISHER_ID == (int) pubId
            //                                     select entry.PUBLISHER_NAME).SingleOrDefault();
            //                publisherTextBox.Text = publisherName;
            //            }
            //            else
            //            {
            //                publisherTextBox.Text = Resources.AddMangaForm_GetPublisherName__N_A_;
            //            }
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
        /// Gets the manga status.
        /// </summary>
        private void GetMangaStatus()
        {
            //try
            //{
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        if (mangaListComboBox.Text != null)
            //        {
            //            var mStat = (from entry in db.MANGA_INFO
            //                         where entry.MANGA_ID == DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text)
            //                         select entry.MANGA_PUBLICATION_STATUS).SingleOrDefault();
            //            statusTextBox.Text = mStat;
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
        /// Gets the manga genres for the currently selected manga and puts them in the proper textbox.
        /// </summary>
        private void GetMangaGenre()
        {
            //try
            //{
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        genresListBox.DataSource =
            //            from mg in db.MANGA_INFO
            //            where mg.MANGA_ID == DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text)
            //            select mg.GENRE_INFO;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessageBox.Show(ex.Message, ex.ToString());
            //    Logger.ErrorLogger("error.txt", ex.ToString());
            //}
        }

        /// <summary>
        /// Gets the manga authors for the currently selected manga.
        /// </summary>
        private void GetMangaAuthors()
        {
            //try
            //{
            //    using (mdbEntities db = new mdbEntities())
            //    {
            //        authorsListBox.DataSource =
            //            from auth in db.MANGA_INFO
            //            where auth.MANGA_ID == DatabaseOperations.GetMANGA_ID(mangaListComboBox.Text)
            //            select auth.AUTHOR_INFO;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessageBox.Show(ex.Message, ex.ToString());
            //    Logger.ErrorLogger("error.txt", ex.ToString());
            //}
        }

        #endregion Linq to SQL

        /// <summary>
        /// Handles the SelectedIndexChanged event of the mangaListComboBox control. And Populates tha various controls with the data for the currently selected manga.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MangaListComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            GetMangaCover();
            mangaTitleTextBox.Text = mangaListComboBox.Text;
            GetMangaDescription();
            GetYearOfFirstPublish();
            GetPublisherName();
            GetMangaStatus();
            GetMangaAuthors();
            GetMangaGenre();
        }

        /// <summary>
        /// Handles the Click event of the addToReadingListButton control. The button adds the selected manga to the reading list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AddToReadingListButtonClick(object sender, EventArgs e)
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
        private void DisplayMangaInMyListCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            _displayAddedManga = !_displayAddedManga;
            PopulateMangaListComboBox();
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