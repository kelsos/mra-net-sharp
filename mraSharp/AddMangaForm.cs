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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               //If display added manga checkbox is checked it will return every single manga in the list.
               if (displayAddedManga == true)
               {
                  mangaListComboBox.DataSource = from mangas in db.mangaInfos
                                                 select mangas.mangaTitle;
               }
               //Else it will return only the mangas not in the reading list.
               else
               {
                  mangaListComboBox.DataSource = (from mg in db.mangaInfos
                                                  select mg.mangaTitle).Except(from mangas in db.mangaInfos
                                                                               where (from manga in db.mangaReadingLists
                                                                                      select manga.mangaID).Contains(mangas.mangaID)
                                                                               select mangas.mangaTitle);
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.mangaInfos
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.mangaID).SingleOrDefault();

                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);

                  var image = (from current in db.mangaInfos
                               where current.mangaID == mID
                               select current.mangaCover).Single();
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.mangaInfos
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.mangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);

                  var description = (from current in db.mangaInfos
                                     where current.mangaID == mID
                                     select current.mangaDescription).SingleOrDefault();
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.mangaInfos
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.mangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);

                  var authors = from current in db.mangaAuthors
                                join author in db.authorTables
                                on current.authorID equals author.authorID
                                where current.mangaID == mID
                                select author.authorFullName;
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  var year = (from entry in db.mangaInfos
                              where entry.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                              select entry.dateOfPublish).SingleOrDefault();

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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  var pubID = (from entry in db.mangaInfos
                               where entry.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                               select entry.publisherID).SingleOrDefault();
                  if (pubID != null)
                  {
                     var publisherName = (from entry in db.publisherInfos
                                          where entry.publisherID == (int)pubID
                                          select entry.publisherName).SingleOrDefault();
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  var mStat = (from entry in db.mangaInfos
                               where entry.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                               select entry.mangaStatus).SingleOrDefault();
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               genresListBox.DataSource =
                   from mg in db.mangaGenres
                   where mg.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                   select mg.genreInfo.genreName;
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               authorsListBox.DataSource =
                  from auth in db.mangaAuthors
                  where auth.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                  select auth.authorTable.authorFullName;
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
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListComboBox.Text != null)
               {
                  //var mID = (from current in db.mangaInfos
                  //           where current.mangaTitle == mangaListComboBox.Text
                  //           select current.mangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID(mangaListComboBox.Text);
                  if (setEntryInfo == false)
                  {
                     mangaReadingList mRL = new mangaReadingList
                     {
                        mangaID = mID,
                        mangaNote = "",
                        mangaDateRead = DateTime.Now,
                        mangaStartingChapter = 1,
                        mangaCurrentChapter = 1,
                        mangaReadingFinished = false,
                        mangaURL = ""
                     };
                     db.mangaReadingLists.InsertOnSubmit(mRL);
                  }
                  else
                  {
                     mangaReadingList mRL = new mangaReadingList
                     {
                        mangaID = mID,
                        mangaNote = interFormCommunicator.PersonalNote,
                        mangaDateRead = interFormCommunicator.LastRead,
                        mangaStartingChapter = interFormCommunicator.StartingChapter,
                        mangaCurrentChapter = interFormCommunicator.CurrentChapter,
                        mangaReadingFinished = interFormCommunicator.FinishedReading,
                        mangaURL = interFormCommunicator.OnlineURL
                     };
                     db.mangaReadingLists.InsertOnSubmit(mRL);
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