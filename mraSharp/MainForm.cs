using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;


namespace mraSharp
{
	public partial class MainForm : Form
	{
		private int myCounter;
		private bool internetIsUp;
		private bool isWebFormOpen;
		WebForm web;

		public MainForm()
		{
			InitializeComponent();

			//Initialization of GeckoFX
			Skybound.Gecko.Xpcom.Initialize(Application.StartupPath.ToString() + "\\xulrunner\\");
			geckoWiki.HandleCreated += new EventHandler(geckoWiki_HandleCreated);// creates a new event handler for the HandleCreated event of GeckoWiki
			myCounter = 0;
			rssCheckTimer.Enabled = false;
			rssTickTimer.Enabled = false;
			isWebFormOpen = false;
			statusLabel.Text = "";

			//Gets the current checkstate from the Application Settings
			if (Properties.Settings.Default.displayFinished)
			{
				displayFinishedToolStripMenuItem.CheckState = CheckState.Checked;
			}
			else
			{
				displayFinishedToolStripMenuItem.CheckState = CheckState.Unchecked;
			}
			//checks if network is up
			System.Net.NetworkInformation.NetworkChange.NetworkAvailabilityChanged += networkAvailabilityChanged_handler;
		}

		#region Rss and Network functions and Event Handlers

        private void rssStatusChecker()
        {
            internetIsUp = NetworkOperations.isInternetUp();
            if (!internetIsUp)
            {
                if (areThereFeedsInTheDatabase())
                {
                    using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
                        newsList = (from news in db.Rss_NewsStorage
                                    select news).ToList();

                    rssTickTimer.Enabled = true;
                    rssCheckTimer.Enabled = false;
                    statusLabel.Text = "No Internet Connection Available";
                }
                else
                {
                    rssTitleLabel.Text = "";
                    rssDescriptionTextBox.Text = "";
                    rssLinkLabel.Text = "";
                    statusLabel.Text = "No Internet Connection Available";
                    //TODO: HIde when connection is not available.
                    //rssTickerGroupBox.Hide();
                    //mangaDescriptionGroupBox.Bounds = new Rectangle(mangaNoteGroupBox.Left, mangaDescriptionGroupBox.Top, mangaDescriptionGroupBox.Right - mangaNoteGroupBox.Left, mangaDescriptionGroupBox.Height);
                    //openToBrowserToolStripButton.Enabled = false;
                }
            }
            else
            {
                rssTitleLabel.Text = "";
                rssDescriptionTextBox.Text = "";
                rssLinkLabel.Text = "";
                rssCheckTimer.Enabled = true;
                //Start Fetcher.
                //rssFetchingThread.RunWorkerAsync();
            }
        }

        private bool areThereFeedsInTheDatabase()
        {
            using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
            {
                var rssFeedData = from data in db.Rss_NewsStorage
                                  select data;

                if (rssFeedData.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

		private List<Rss_NewsStorage> newsList = new List<Rss_NewsStorage>();
		//TODO: Work on the RSS Ticker. Lack of internet connection plus Rss Already in the database.
		private void rssTicker()
		{
			try
			{
				int newsItemsCount = newsList.Count();
				if (newsItemsCount > 0)
				{
					if (newsItemsCount > myCounter)
					{
						rssTitleLabel.Text = newsList[myCounter].NewsTitle;
						rssLinkLabel.Text = newsList[myCounter].NewsLink;
						rssDescriptionTextBox.Text = newsList[myCounter].NewsDescription;
						myCounter += 1;
					}
					else
					{
						myCounter = 0;
						rssTitleLabel.Text = newsList[myCounter].NewsTitle;
						rssLinkLabel.Text = newsList[myCounter].NewsLink;
						rssDescriptionTextBox.Text = newsList[myCounter].NewsDescription;
						myCounter += 1;
					}
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
				Mds db = new Mds(Properties.Settings.Default.DbConnection);
				//Mds db = new Mds(Properties.Settings.Default.DbConnection);
				var rssSubs = from subs in db.Rss_Subscriptions
								  select subs.RssURL;

				foreach (var channel in rssSubs)
				{
					ArrayList result = RssManager.processNewsFeed(channel);
					foreach (RssNewsItem newsItem in result)
					{
						string title = newsItem.Title;
						title = title.Replace("'", "");
						title = title.Trim();

						var newsFilter = from line in db.Rss_NewsStorage
											  where line.NewsTitle == title
											  select line;
						//TODO: Add implementation for the RSS to keep info about the Publication Date.
						if (newsFilter.Count() == 0)
						{
							Rss_NewsStorage ne = new Rss_NewsStorage
							{
								NewsTitle = title,
								NewsLink = newsItem.Link,
								NewsDescription = RegularExpressions.htmlTagRemover(newsItem.Description),
								NewsDateAquired = DateTime.Now
							};
							db.Rss_NewsStorage.InsertOnSubmit(ne);
							db.SubmitChanges();
						}
					}
				}
				newsList = (from news in db.Rss_NewsStorage
								select news).ToList();
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		private void rssSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SubscriptionManagerForm manager = new SubscriptionManagerForm())
			{
				manager.ShowDialog();
                rssStatusChecker();
			}
		}

		private void rssCheckTimer_Tick(object sender, EventArgs e)
		{
			if (internetIsUp)
			{
				rssFetchingThread.RunWorkerAsync();
			}
			else
			{
				statusLabel.Text = "Internet Connection [N/A]: Cannot Fetch RSS feeds.";
			}
		}

		private void rssTickTimer_Tick(object sender, EventArgs e)
		{
			rssTicker();
		}

		private void rssLinkLabel_Click(object sender, EventArgs e)
		{
			WebForm web = new WebForm();
			web.Show();
			web.Navigate(rssLinkLabel.Text);
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
			DatabaseOperations.oldRssRemover(Properties.Settings.Default.keepInDatabaseFor);
		}

		private void rssFetchingThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			rssTickTimer.Enabled = true;
		}

		#endregion Rss and Network functions and Event Handlers

		#region application functions

		/// <summary>
		/// This method represents the action of reading a chapter. It sets the date last read of the selected manga to the current Date
		/// (when the method was called) and increases the last chapter by one.
		/// </summary>
		public void justReadAChapter()
		{
			try
			{
				//TODO: Add a check for an empty List.
				using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
				{
					int mID = DatabaseOperations.getMangaID((string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
					var manga = (from current in db.Mr_readingList
									 where current.MangaID == mID
									 select current).Single();
					manga.Mr_CurrentChapter += 1;
					manga.Mr_LastRead = DateTime.Now;
					db.SubmitChanges();
				}

				//Updates the DataGridView to reflect on the changes made to the database
				mangaListDataGridView.CurrentRow.Cells["lastReadDataGridViewTextBoxColumn"].Value = DateTime.Now;
				mangaListDataGridView.CurrentRow.Cells["currentChapterDataGridViewTextBoxColumn"].Value = Convert.ToDouble(mangaListDataGridView.CurrentRow.Cells["currentChapterDataGridViewTextBoxColumn"].Value) + 1;
				if (isWebFormOpen)
				{
					int currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
					web.setTitle("Manga: " + mangaListDataGridView[0, currentSelectedRow].Value.ToString() + " - Current Chapter: " + mangaListDataGridView[2, currentSelectedRow].Value.ToString() + " - Last Read: " + mangaListDataGridView[3, currentSelectedRow].Value.ToString());
				}
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		delegate void progressChangedInvoker(int maxProgress, int currentProgress);

		public void progressChanged(int maxProgress, int currentProgress)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new progressChangedInvoker(progressChanged), maxProgress, currentProgress);
			}
			else
			{
				statusProgressBar.Maximum = maxProgress;
				statusProgressBar.Value = currentProgress;
			}
		}

		public void webFormClosed()
		{
			isWebFormOpen = false;
		}

		#endregion application functions

		#region Data Loading Functions

		delegate void loadDataGridDelegate();

		public void loadDatagrid()
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new loadDataGridDelegate(loadDatagrid));
			}
			else
			{
				try
				{
					using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
					{
						if (Properties.Settings.Default.displayFinished)
						{
							dataGridBindingSource.DataSource = from read in db.Mr_readingList
																		  join mangas in db.M_mangaInfo
																		  on read.MangaID equals mangas.MangaID
																		  orderby mangas.MangaTitle
																		  select new mangaRead(mangas.MangaTitle, read.Mr_StartingChapter, read.Mr_CurrentChapter, read.Mr_LastRead, read.Mr_OnlineURL, read.Mr_IsReadingFinished);
						}
						else
						{
							dataGridBindingSource.DataSource = from read in db.Mr_readingList
																		  join mangas in db.M_mangaInfo
																		  on read.MangaID equals mangas.MangaID
																		  where read.Mr_IsReadingFinished == false
																		  orderby mangas.MangaTitle
																		  select new mangaRead(mangas.MangaTitle, read.Mr_StartingChapter, read.Mr_CurrentChapter, read.Mr_LastRead, read.Mr_OnlineURL, read.Mr_IsReadingFinished);
						}
					}
				}
				catch (Exception ex)
				{
					errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
					Logger.errorLogger("error.txt", ex.ToString());
				}
			}
		}

		private void loadCurrentImage()
		{
			try
			{
				using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
				{
					if (mangaListDataGridView.CurrentRow != null)
					{
						int mID = DatabaseOperations.getMangaID((string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
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

		private void loadCurrentDescription()
		{
			try
			{
				if (mangaListDataGridView.CurrentRow != null)
				{
					using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
					{
						int mID = DatabaseOperations.getMangaID((string)mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
						var description = (from current in db.M_mangaInfo
												 where current.MangaID == mID
												 select current.MangaDescription).SingleOrDefault();
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

		#endregion Data Loading Functions

		#region Event Handlers

		private void MainForm_Load(object sender, EventArgs e)
		{
			loadDatagrid();
			mangaListDataGridView.AutoGenerateColumns = false;
            rssStatusChecker();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
            if (MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

		}

		private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to clear the reading List?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DatabaseOperations.clearTheReadingList();
				if (restoreOpenFileDialog.ShowDialog() == DialogResult.OK)
				{
					Thread readFromXML = new Thread(new ParameterizedThreadStart(FileOperations.readingListFromXML));
					readFromXML.Start(new dataPasser(this, restoreOpenFileDialog.FileName));
					//loadDatagrid();
				}
			}
		}

		private void displayFinishedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.displayFinished = !Properties.Settings.Default.displayFinished;
			if (!Properties.Settings.Default.displayFinished)
			{
				mangaListDataGridView.Columns["finishedReadingDataGridViewTextBoxColumn"].Visible = false;
			}
			else
			{
				mangaListDataGridView.Columns["finishedReadingDataGridViewTextBoxColumn"].Visible = true;
			}
			loadDatagrid();
		}

		private void addMangaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (AddMangaForm amf = new AddMangaForm())
			{
				amf.ShowDialog();
				loadDatagrid();
			}
		}

		private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (StatisticsForm stats = new StatisticsForm())
			{
				stats.ShowDialog();
			}
		}

		private void networkAvailabilityChanged_handler(object sender, EventArgs e)
		{
            rssStatusChecker();
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
				DatabaseOperations.clearTheReadingList();
			}
		}

		private void mangaListDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			loadCurrentImage();
			loadCurrentDescription();
		}

		private void justReadToolStripButton_Click(object sender, EventArgs e)
		{
			justReadAChapter();
		}

		private void searchToolStripTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
				{
					if (Properties.Settings.Default.displayFinished)
					{
						dataGridBindingSource.DataSource = from read in db.Mr_readingList
																	  join mangas in db.M_mangaInfo
																	  on read.MangaID equals mangas.MangaID
																	  where mangas.MangaTitle.Contains(searchToolStripTextBox.Text)
																	  select new mangaRead(mangas.MangaTitle, read.Mr_StartingChapter, read.Mr_CurrentChapter, read.Mr_LastRead, read.Mr_OnlineURL, read.Mr_IsReadingFinished);
					}
					else
					{
						dataGridBindingSource.DataSource = from read in db.Mr_readingList
																	  join mangas in db.M_mangaInfo
																	  on read.MangaID equals mangas.MangaID
																	  where mangas.MangaTitle.Contains(searchToolStripTextBox.Text) && read.Mr_IsReadingFinished == false
																	  select new mangaRead(mangas.MangaTitle, read.Mr_StartingChapter, read.Mr_CurrentChapter, read.Mr_LastRead, read.Mr_OnlineURL, read.Mr_IsReadingFinished);
					}
				}
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
				if (!isWebFormOpen)
				{
					web = new WebForm(this);
					web.Show();
					isWebFormOpen = true;
				}
				if (!(mangaListDataGridView.Rows.Count == 0))
				{
					int currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
					string mangaURL = mangaListDataGridView[4, currentSelectedRow].Value.ToString();
					if (!String.IsNullOrEmpty(mangaURL))
					{
						web.Navigate(mangaURL);
						web.setTitle("Manga: " + mangaListDataGridView[0, currentSelectedRow].Value.ToString() + " - Current Chapter: " + mangaListDataGridView[2, currentSelectedRow].Value.ToString() + " - Last Read: " + mangaListDataGridView[3, currentSelectedRow].Value.ToString());
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

		#endregion Event Handlers
	}
}