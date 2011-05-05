using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace mraSharp
{
   public partial class AddMangaForm : Form
   {
      private bool displayAddedManga;
      private bool setEntryInfo;
      private mangaRead interFormCommunicator;

      /// <summary>
      /// Initializes a new instance of the <see cref="AddMangaForm"/> class.
      /// </summary>
      public AddMangaForm()
      {
         InitializeComponent();
         displayAddedManga = false;
         setEntryInfo = false;
      }

      /// <summary>
      /// Handles the Load event of the AddMangaForm control.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void AddMangaForm_Load(object sender, EventArgs e)
      {
         populateMangaListComboBox();
      }

      #region Linq to SQL

      /// <summary>
      /// Populates the manga list combo box.
      /// </summary>
      private void populateMangaListComboBox()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               //If display added manga checkbox is checked it will return every single manga in the list.
               if (displayAddedManga == true)
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
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga cover for the currently selected manga from the Database and it loads it to the manga Cover PictureBox
      /// </summary>
      private void getMangaCover()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();

                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);

                  var image = (from current in db.M_mangaInfo
                               where current.MangaID == mID
                               select current.MangaCover).Single();
                  byte[] imageByte = (byte[])image.ToArray();

                  mangaCoverPictureBox.Image = Image.FromStream(new MemoryStream(imageByte));
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga description for the currently selected manga and displays it in the proper textbox.
      /// </summary>
      private void getMangaDescription()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);

                  var description = (from current in db.M_mangaInfo
                                     where current.MangaID == mID
                                     select current.MangaDescription).SingleOrDefault();
                  descriptionTextBox.Text = description;
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the authors of the currently selected manga and displays them on the proper list box.
      /// </summary>
      private void getAuthors()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);

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
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the year of the Mangas' first publish and posts it to the proper text box.
      /// </summary>
      private void getYearOfFirstPublish()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  var year = (from entry in db.M_mangaInfo
                              where entry.MangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                              select entry.MangaYearOfPublisher).SingleOrDefault();

                  yearTextBox.Text = year.HasValue ? year.Value.ToString("yyyy") : "[N/A]";
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the name of the publisher for the currently selected manga and puts it on the proper textbox.
      /// </summary>
      private void getPublisherName()
      {
         try
         {
            publisherTextBox.Text = "";
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  var pubID = (from entry in db.M_mangaInfo
                               where entry.MangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
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
                     publisherTextBox.Text = "[N/A]";
                  }
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga status.
      /// </summary>
      private void getMangaStatus()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  var mStat = (from entry in db.M_mangaInfo
                               where entry.MangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                               select entry.MangaStatus).SingleOrDefault();
                  statusTextBox.Text = mStat;
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga genres for the currently selected manga and puts them in the proper textbox.
      /// </summary>
      private void getMangaGenre()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               genresListBox.DataSource =
                   from mg in db.Mm_mangaGenres
                   where mg.Mm_mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                   select mg.M_genreInfo.GenreName;
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Gets the manga authors for the currently selected manga.
      /// </summary>
      private void getMangaAuthors()
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               authorsListBox.DataSource =
                  from auth in db.Mm_mangaAuthors
                  where auth.Ma_mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                  select auth.M_authorInfo.AuthorFullName;
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      #endregion Linq to SQL

      /// <summary>
      /// Handles the SelectedIndexChanged event of the mangaListComboBox control. And Populates tha various controls with the data for the currently selected manga.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void mangaListComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         getMangaCover();
         mangaTitleTextBox.Text = mangaListComboBox.Text;
         getMangaDescription();
         getYearOfFirstPublish();
         getPublisherName();
         getMangaStatus();
         getMangaAuthors();
         getMangaGenre();
      }

      /// <summary>
      /// Handles the Click event of the addToReadingListButton control. The button adds the selected manga to the reading list.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void addToReadingListButton_Click(object sender, EventArgs e)
      {
         try
         {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.M_mangaInfo
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.MangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);
                  if (setEntryInfo == false)
                  {
                     Mr_readingList mRL = new Mr_readingList
                     {
                        MangaID = mID,
                        Mr_Note = "",
                        Mr_LastRead = DateTime.Now,
                        Mr_StartingChapter = 1,
                        Mr_CurrentChapter = 1,
								Mr_IsReadingFinished = false,
                        Mr_OnlineURL = ""
                     };
                     db.Mr_readingList.InsertOnSubmit(mRL);
                  }
                  else
                  {
                     Mr_readingList mRL = new Mr_readingList
                     {
                        MangaID = mID,
								Mr_Note = interFormCommunicator.PersonalNote,
								Mr_LastRead = interFormCommunicator.LastRead,
                        Mr_StartingChapter = (double)interFormCommunicator.StartingChapter,
								Mr_CurrentChapter = (double)interFormCommunicator.CurrentChapter,
								Mr_IsReadingFinished = (bool)interFormCommunicator.FinishedReading,
								Mr_OnlineURL = interFormCommunicator.OnlineURL
                     };
                     db.Mr_readingList.InsertOnSubmit(mRL);
                  }
                  db.SubmitChanges();
                  setEntryInfo = false;
                  populateMangaListComboBox();
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// Handles the CheckedChanged event of the displayMangaInMyListCheckBox control. If enabled the mangas already in the reading list are also displayed.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void displayMangaInMyListCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         displayAddedManga = !displayAddedManga;
         populateMangaListComboBox();
      }

      /// <summary>
      /// Handles the Click event of the specifyNewEntryInfoButton control. Shows the form for the custom manga Info for the new entry.
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void specifyNewEntryInfoButton_Click(object sender, EventArgs e)
      {
         interFormCommunicator = new mangaRead();
         using (SpecifyNewEntryInfoForm sne = new SpecifyNewEntryInfoForm(ref interFormCommunicator))
         {
            if (sne.ShowDialog() == DialogResult.OK)
            {
               setEntryInfo = true;
            }
         }
      }
   }
}