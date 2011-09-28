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
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               //If display added manga checkbox is checked it will return every single manga in the list.
               if (_displayAddedManga)
               {
                  mangaListComboBox.DataSource = from mangas in db.M_mangaInfo
                                                 select mangas.MangaTitle;
               }
               //Else it will return only the mangas not in the reading list.
               else
               {
                  mangaListComboBox.DataSource = (from mg in db.M_mangaInfo
                                                  select mg.MangaTitle).Except(from mangas in db.M_mangaInfo
                                                                               where (from manga in db.Mr_readingList
                                                                                      select manga.MangaID).Contains(mangas.MangaID)
                                                                               select mangas.MangaTitle);
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga cover for the currently selected manga from the Database and it loads it to the manga Cover PictureBox
      /// </summary>
      private void GetMangaCover()
      {
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();

                  var mID = DatabaseOperations.GetMangaID(mangaListComboBox.Text);

                  var image = (from current in db.M_mangaInfo
                               where current.MangaID == mID
                               select current.MangaCover).Single();
                  var imageByte = image.ToArray();

                  mangaCoverPictureBox.Image = Image.FromStream(new MemoryStream(imageByte));
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga description for the currently selected manga and displays it in the proper textbox.
      /// </summary>
      private void GetMangaDescription()
      {
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();
                  var mID = DatabaseOperations.GetMangaID(mangaListComboBox.Text);

                  var description = (from current in db.M_mangaInfo
                                     where current.MangaID == mID
                                     select current.MangaDescription).SingleOrDefault();
                  descriptionTextBox.Text = description;
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

/*
      /// <summary>
      /// Gets the authors of the currently selected manga and displays them on the proper list box.
      /// </summary>
      private void GetAuthors()
      {
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();
                  var mID = DatabaseOperations.GetMangaID(mangaListComboBox.Text);

                  var authors = from current in db.Mm_mangaAuthors
                                join author in db.M_authorInfo
                                on current.Ma_authorID equals author.AuthorID
                                where current.Ma_mangaID == mID
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
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  var year = (from entry in db.M_mangaInfo
                              where entry.MangaID == DatabaseOperations.GetMangaID(mangaListComboBox.Text)
                              select entry.MangaYearOfPublisher).SingleOrDefault();

                  yearTextBox.Text = year.HasValue ? year.Value.ToString("yyyy") : Resources.AddMangaForm_GetPublisherName__N_A_;
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the name of the publisher for the currently selected manga and puts it on the proper textbox.
      /// </summary>
      private void GetPublisherName()
      {
         try
         {
            publisherTextBox.Text = "";
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  var pubID = (from entry in db.M_mangaInfo
                               where entry.MangaID == DatabaseOperations.GetMangaID(mangaListComboBox.Text)
                               select entry.MangaPublisherID).SingleOrDefault();
                  if (pubID != null)
                  {
                     var publisherName = (from entry in db.M_publisherInfo
                                          where entry.PublisherID == (int)pubID
                                          select entry.PublisherName).SingleOrDefault();
                     publisherTextBox.Text = publisherName;
                  }
                  else
                  {
                     publisherTextBox.Text = Resources.AddMangaForm_GetPublisherName__N_A_;
                  }
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga status.
      /// </summary>
      private void GetMangaStatus()
      {
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  var mStat = (from entry in db.M_mangaInfo
                               where entry.MangaID == DatabaseOperations.GetMangaID(mangaListComboBox.Text)
                               select entry.MangaStatus).SingleOrDefault();
                  statusTextBox.Text = mStat;
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga genres for the currently selected manga and puts them in the proper textbox.
      /// </summary>
      private void GetMangaGenre()
      {
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               genresListBox.DataSource =
                   from mg in db.Mm_mangaGenres
                   where mg.Mm_mangaID == DatabaseOperations.GetMangaID(mangaListComboBox.Text)
                   select mg.M_genreInfo.GenreName;
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga authors for the currently selected manga.
      /// </summary>
      private void GetMangaAuthors()
      {
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               authorsListBox.DataSource =
                  from auth in db.Mm_mangaAuthors
                  where auth.Ma_mangaID == DatabaseOperations.GetMangaID(mangaListComboBox.Text)
                  select auth.M_authorInfo.AuthorFullName;
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
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
         try
         {
            using (var db = new Mds(Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();
                  var mID = DatabaseOperations.GetMangaID(mangaListComboBox.Text);
                  if (_setEntryInfo == false)
                  {
                     var maReadList = new Mr_readingList
                     {
                        MangaID = mID,
                        Mr_Note = "",
                        Mr_LastRead = DateTime.Now,
                        Mr_StartingChapter = 1,
                        Mr_CurrentChapter = 1,
								Mr_IsReadingFinished = false,
                        Mr_OnlineURL = ""
                     };
                     db.Mr_readingList.InsertOnSubmit(maReadList);
                  }
                  else
                  {
                     var mRl = new Mr_readingList
                     {
                        MangaID = mID,
								Mr_Note = _interFormCommunicator.PersonalNote,
								Mr_LastRead = _interFormCommunicator.LastRead,
                        Mr_StartingChapter = (double)_interFormCommunicator.StartingChapter,
								Mr_CurrentChapter = (double)_interFormCommunicator.CurrentChapter,
								Mr_IsReadingFinished = (bool)_interFormCommunicator.FinishedReading,
								Mr_OnlineURL = _interFormCommunicator.OnlineURL
                     };
                     db.Mr_readingList.InsertOnSubmit(mRl);
                  }
                  db.SubmitChanges();
                  _setEntryInfo = false;
                  PopulateMangaListComboBox();
               }
            }
         }
         catch (Exception ex)
         {
            ErrorMessageBox.Show(ex.Message, ex.ToString());
            Logger.ErrorLogger("error.txt", ex.ToString());
         }
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