using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace mraSharp
{
   public partial class MainForm : Form
   {
      private int myCounter;
      private bool internetIsUp;

      public MainForm()
      {
         InitializeComponent();

         //Initialization of GeckoFX
         Skybound.Gecko.Xpcom.Initialize(Application.StartupPath.ToString() + "\\xulrunner\\");
         geckoWiki.HandleCreated += new EventHandler(geckoWiki_HandleCreated);// creates a new event handler for the HandleCreated event of GeckoWiki
         myCounter = 0;
         rssCheckTimer.Enabled = false;
         rssTickTimer.Enabled = false;

         //checks if network is up
         System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged += networkAvailabilityChanged_handler;
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         loadDatagrid();
         mangaListDataGridView.AutoGenerateColumns = false;
         networkRssChecker();
      }

      /// <summary>
      /// Checks if the computer has an active internet connection and if it has it enables the rssTicker.
      /// </summary>
      private void networkRssChecker()
      {
         try
         {
            internetIsUp = NetworkOperations.isInternetUp();
            rssCheckTimer.Enabled = internetIsUp;
            rssTickTimer.Enabled = internetIsUp;

            if (!internetIsUp)
            {
               statusLabel.Text = "No Internet Connection Available";
               rssTickerGroupBox.Hide();
               mangaDescriptionGroupBox.Bounds = new Rectangle(mangaNoteGroupBox.Left, mangaDescriptionGroupBox.Top, mangaDescriptionGroupBox.Right - mangaNoteGroupBox.Left, mangaDescriptionGroupBox.Height);
               openToBrowserToolStripButton.Enabled = false;

               //TODO: check on how to hide a tab page from a tab control.
               wikipediaTabPage.Hide();
            }
            else
            {
               rssTitleLabel.Text = "";
               rssDescriptionTextBox.Text = "";
               rssLinkLabel.Text = "";
               if (!rssTickerGroupBox.Visible)
               {
                  rssTickerGroupBox.Show();
                  //TODO: keep the default mangaDescriptionGroupBox.Bounds in a variable and actually restore them if the Rss ticker is hidden and the internet connection is restored.
                  mangaDescriptionGroupBox.Bounds = new Rectangle();
                  openToBrowserToolStripButton.Enabled = true;
                  wikipediaTabPage.Show();
               }

               rssFetchingThread.RunWorkerAsync();
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      private void networkAvailabilityChanged_handler(object sender, EventArgs e)
      {
         networkRssChecker();
      }

      private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Do you want to clear the database?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
         {
            DatabaseOperations.clearDatabase();
            if (restoreOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
               FileOperations.readingListFromXML(restoreOpenFileDialog.FileName);
            }
         }
      }

      private void backupToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (backupSaveFileDialog.ShowDialog() == DialogResult.OK)
         {
            FileOperations.readingListToXML(backupSaveFileDialog.FileName);
         }
      }

      private void quitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void clearToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (MessageBox.Show("Are you sure to clear the database?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
         {
            DatabaseOperations.clearDatabase();
         }
      }

      private List<newsStorage> newsList = new List<newsStorage>();

      private void rssTicker()
      {
         try
         {
            int newsItemsCount = newsList.Count();

            if (newsItemsCount > myCounter)
            {
               rssTitleLabel.Text = newsList[myCounter].rssTitle;
               rssLinkLabel.Text = newsList[myCounter].rssLink;
               rssDescriptionTextBox.Text = newsList[myCounter].rssDescription;
               myCounter += 1;
            }
            else
            {
               myCounter = 0;
               rssTitleLabel.Text = newsList[myCounter].rssTitle;
               rssLinkLabel.Text = newsList[myCounter].rssLink;
               rssDescriptionTextBox.Text = newsList[myCounter].rssDescription;
               myCounter += 1;
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      private void rssFetcher()
      {
         try
         {
            dataLinqSqlDataContext db = new dataLinqSqlDataContext();
            var rssSubs = from subs in db.rssSubscriptions
                          select subs.rssUrl;

            foreach (var channel in rssSubs)
            {
               ArrayList result = RssManager.processNewsFeed(channel);
               foreach (RssNewsItem newsItem in result)
               {
                  string title = newsItem.Title;
                  title = title.Replace("'", "");
                  title = title.Trim();

                  var newsFilter = from line in db.newsStorages
                                   where line.rssTitle == title
                                   select line;

                  if (newsFilter.Count() == 0)
                  {
                     newsStorage ne = new newsStorage
                     {
                        rssTitle = title,
                        rssLink = newsItem.Link,
                        rssDescription = RegularExpressions.htmlTagRemover(newsItem.Description),
                        rssDateAquired = DateTime.Now
                     };
                     db.newsStorages.InsertOnSubmit(ne);
                     db.SubmitChanges();
                  }
               }
            }
            newsList = (from news in db.newsStorages
                        select news).ToList();
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      /// <summary>
      /// This method represents the action of reading a chapter. It sets the date last read of the selected manga to the current Date
      /// (when the method was called) and increases the last chapter by one.
      /// </summary>
      private void justReadAChapter()
      {
         try
         {
            dataLinqSqlDataContext db = new dataLinqSqlDataContext();
            //var mID = (from current in db.mangaInfos
            //where current.mangaTitle == (string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value
            //select current.mangaID).Single();
            int mID = DatabaseOperations.getMangaID((string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
            var manga = (from current in db.mangaReadingLists
                         where current.mangaID == mID
                         select current).Single();
            manga.mangaCurrentChapter += 1;
            manga.mangaDateRead = DateTime.Now;
            db.SubmitChanges();

            //Updates the DataGridView to reflect on the changes made to the database
            mangaListDataGridView.CurrentRow.Cells["lastReadDataGridViewTextBoxColumn"].Value = DateTime.Now;
            mangaListDataGridView.CurrentRow.Cells["currentChapterDataGridViewTextBoxColumn"].Value = Convert.ToDouble(mangaListDataGridView.CurrentRow.Cells["currentChapterDataGridViewTextBoxColumn"].Value) + 1;

         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }
      private void justReadToolStripButton_Click(object sender, EventArgs e)
      {
         justReadAChapter();
      }

      private void searchToolStripTextBox_KeyUp(object sender, KeyEventArgs e)
      {
         try
         {
            dataLinqSqlDataContext db = new dataLinqSqlDataContext();
            dataGridBindingSource.DataSource = from read in db.mangaReadingLists
                                               join mangas in db.mangaInfos
                                               on read.mangaID equals mangas.mangaID
                                               where mangas.mangaTitle.Contains(searchToolStripTextBox.Text)
                                               select new mangaRead(mangas.mangaTitle, read.mangaStartingChapter, read.mangaCurrentChapter, read.mangaDateRead, read.mangaURL, read.mangaReadingFinished);

         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      private void browserNavBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {
         if (e.ClickedItem == backToolStripButton)
         {
            geckoWiki.GoBack();
         }
         else if (e.ClickedItem == forwardToolStripButton)
         {
            geckoWiki.GoForward();
         }
         else if (e.ClickedItem == wReloadtoolStripButton)
         {
            geckoWiki.Reload();
         }
      }

      /// <summary>
      /// Handles the Enter event of the wikipediaTabPage control. (Fires every time except the first time you enter the wikiTab)
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void wikipediaTabPage_Enter(object sender, EventArgs e)
      {
         int currentSelectedRow;
         if (!(mangaListDataGridView.Rows.Count == 0))
         {
            currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
            string navigationURL = "http://en.wikipedia.org/w/index.php?search=" + RegularExpressions.whiteSpaceToUrlEncoding(mangaListDataGridView[0, currentSelectedRow].Value.ToString()) + "&go=Go";
            try
            {
               geckoWiki.Parent = geckoPanel;
               geckoWiki.CreateControl();
               Application.DoEvents();

               //Doesn't work the first time (handle must be created)

               if (geckoWiki.IsHandleCreated)
               {
                  geckoWiki.Navigate(navigationURL);
               }
            }
            catch (Exception ex)
            {
               errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
               Logger.errorLogger("error.txt", ex.ToString());
            }
         }
      }

      /// <summary>
      /// Handles the HandleCreated event of the geckoWiki control. (Fires when you first enter the wiki tab (after the handle is created)
      /// </summary>
      /// <param name="sender">The source of the event.</param>
      /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
      private void geckoWiki_HandleCreated(object sender, EventArgs e)
      {
         int currentSelectedRow;
         if (!(mangaListDataGridView.Rows.Count == 0))
         {
            currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
            string navigationURL = "http://en.wikipedia.org/w/index.php?search=" + RegularExpressions.whiteSpaceToUrlEncoding(mangaListDataGridView[0, currentSelectedRow].Value.ToString()) + "&go=Go";
            try
            {
               geckoWiki.Parent = geckoPanel;
               geckoWiki.CreateControl();
               Application.DoEvents();

               //Doesn't work the first time (handle must be created)

               if (geckoWiki.IsHandleCreated)
               {
                  geckoWiki.Navigate(navigationURL);
               }
            }
            catch (Exception ex)
            {
               errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
               Logger.errorLogger("error.txt", ex.ToString());
            }
         }
      }

      private void openToBrowserToolStripButton_Click(object sender, EventArgs e)
      {
         try
         {
            WebForm web = new WebForm();
            {
               web.Show();
               if (!(mangaListDataGridView.Rows.Count == 0))
               {
                  int currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
                  string mangaURL = mangaListDataGridView[4, currentSelectedRow].Value.ToString();
                  if (!String.IsNullOrEmpty(mangaURL))
                  {
                     web.Navigate(mangaURL);
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

      private void reloadToolStripButton_Click(object sender, EventArgs e)
      {
         loadDatagrid();
      }

      private void editoToolStripButton_Click(object sender, EventArgs e)
      {
      }

      private void rssSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (SubscriptionManagerForm manager = new SubscriptionManagerForm())
         {
            manager.ShowDialog();
         }
      }

      private void editorToolStripMenuItem_Click(object sender, EventArgs e)
      {
      }

      private void rssCheckTimer_Tick(object sender, EventArgs e)
      {
         rssFetchingThread.RunWorkerAsync();
      }

      private void rssTickTimer_Tick(object sender, EventArgs e)
      {
         rssTicker();
      }

      private void rssLinkLabel_Click(object sender, EventArgs e)
      {
         using (WebForm web = new WebForm())
         {
            web.Show();
            web.Navigate(rssLinkLabel.Text);
         }
      }

      private void rssLinkLabel_MouseEnter(object sender, EventArgs e)
      {
         rssLinkLabel.ForeColor = Color.Blue;
      }

      private void rssLinkLabel_MouseLeave(object sender, EventArgs e)
      {
         rssLinkLabel.ForeColor = Color.RoyalBlue;
      }

      private void rssFetchingThread_DoWork(object sender, DoWorkEventArgs e)
      {
         rssFetcher();
         DatabaseOperations.oldRssRemover(5);
      }

      private void rssFetchingThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
      {
         rssTickTimer.Enabled = true;
      }

      private void loadingText()
      {
      }

      private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (StatisticsForm stats = new StatisticsForm())
         {
            stats.ShowDialog();
         }
      }

      #region Linq to SQL data functions

      private void loadDatagrid()
      {
         try
         {
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               dataGridBindingSource.DataSource = from read in db.mangaReadingLists
                                                  join mangas in db.mangaInfos
                                                  on read.mangaID equals mangas.mangaID
                                                  select new mangaRead(mangas.mangaTitle, read.mangaStartingChapter, read.mangaCurrentChapter, read.mangaDateRead, read.mangaURL, read.mangaReadingFinished);
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      private void loadCurrentImage()
      {
         try
         {
            using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
            {
               if (mangaListDataGridView.CurrentRow != null)
               {
                  //var mID = (from current in db.mangaInfos
                  //           where current.mangaTitle == (string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value
                  //           select current.mangaID).SingleOrDefault();
                  int mID = DatabaseOperations.getMangaID((string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
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

      private void loadCurrentDescription()
      {
         try
         {
            if (mangaListDataGridView.CurrentRow != null)
            {
               using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
               {
                  //var mID = (from current in db.mangaInfos
                  //           where current.mangaTitle == (string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value
                  //           select current.mangaID).Single();
                  int mID = DatabaseOperations.getMangaID((string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
                  var description = (from current in db.mangaInfos
                                     where current.mangaID == mID
                                     select current.mangaDescription).SingleOrDefault();
                  mangaDescriptionTextBox.Text = description;
               }
            }
         }
         catch (Exception ex)
         {
            errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
            Logger.errorLogger("error.txt", ex.ToString());
         }
      }

      #endregion Linq to SQL data functions

      private void mangaListDataGridView_SelectionChanged(object sender, EventArgs e)
      {
         loadCurrentImage();
         loadCurrentDescription();
      }

      private void addMangaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         using (AddMangaForm amf = new AddMangaForm())
         {
            amf.ShowDialog();
            loadDatagrid();
         }
      }
   }
}