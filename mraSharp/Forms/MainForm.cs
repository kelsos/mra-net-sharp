using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using mraSharp.Classes;
using mraSharp.Properties;
using WebKit;

namespace mraSharp.Forms
{
    public partial class MainForm : Form
    {
        private int _myCounter;
        private bool _internetIsUp;
        private bool _isWebFormOpen;
        private WebForm _web;
        private readonly WebKitBrowser _wikiWebKitBrowser;

        public MainForm()
        {
            InitializeComponent();

            _myCounter = 0;
            rssCheckTimer.Enabled = false;
            rssTickTimer.Enabled = false;
            _isWebFormOpen = false;
            statusLabel.Text = "";

            //Gets the current check state from the Application Settings
            displayFinishedToolStripMenuItem.CheckState = Settings.Default.displayFinished
                                                              ? CheckState.Checked
                                                              : CheckState.Unchecked;
            //checks if network is up
            System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged += HandleNetworkAddressChangedHandler;
            _wikiWebKitBrowser = new WebKitBrowser {Visible = true};
            wikiPanel.Controls.Add(_wikiWebKitBrowser);
            _wikiWebKitBrowser.Dock = DockStyle.Fill;
            _wikiWebKitBrowser.AllowDownloads = false;
        }

        private void RssStatusChecker()
        {
            _internetIsUp = NetworkOperations.IsInternetUp();
            if (!_internetIsUp)
            {
                if (DatabaseWrapper.FeedDataExistInTheDatabase())
                {
                    rssTickTimer.Enabled = true;
                    rssCheckTimer.Enabled = false;
                    statusLabel.Text = Resources.MainForm_RssStatusChecker_No_Internet_Connection_Available;
                }
                else
                {
                    rssTitleLabel.Text = "";
                    rssDescriptionTextBox.Text = "";
                    rssLinkLabel.Text = "";
                    statusLabel.Text = Resources.MainForm_RssStatusChecker_No_Internet_Connection_Available;
                    rssTickTimer.Enabled = false;
                    rssCheckTimer.Enabled = false;
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
                rssFetchingThread.RunWorkerAsync();
            }
        }


        private List<NewsItem> _newsList = new List<NewsItem>();
        //TODO: Work on the RSS Ticker. Lack of Internet connection plus Rss Already in the database.
        private void RssTicker()
        {
            _newsList = DatabaseWrapper.GetNewsItemList();
            try
            {
                var newsItemsCount = _newsList.Count();
                if (newsItemsCount > 0)
                {
                    if (newsItemsCount > _myCounter)
                    {
                        rssTitleLabel.Text = _newsList[_myCounter].Title;
                        rssLinkLabel.Text = _newsList[_myCounter].Link;
                        rssDescriptionTextBox.Text = _newsList[_myCounter].Description;
                        _myCounter += 1;
                    }
                    else
                    {
                        _myCounter = 0;
                        rssTitleLabel.Text = _newsList[_myCounter].Title;
                        rssLinkLabel.Text = _newsList[_myCounter].Link;
                        rssDescriptionTextBox.Text = _newsList[_myCounter].Description;
                        _myCounter += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }


        private void HandleNewsSubscriptionsToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (SubscriptionManagerForm manager = new SubscriptionManagerForm())
            {
                manager.ShowDialog();
                RssStatusChecker();
            }
        }

        private void HandleNewsFeedCheckTimerTick(object sender, EventArgs e)
        {
            if (_internetIsUp && !rssFetchingThread.IsBusy)
            {
                rssFetchingThread.RunWorkerAsync();
            }
            else
            {
                statusLabel.Text =
                    Resources.MainForm_RssCheckTimerTick_Internet_Connection__N_A___Cannot_Fetch_RSS_feeds_;
            }
        }

        private void HandleNewsTickerTimerTick(object sender, EventArgs e)
        {
            RssTicker();
        }

        private void HandleNewsTickerLinkLabelClick(object sender, EventArgs e)
        {
            var web = new WebForm();
            web.Show();
            web.Navigate(rssLinkLabel.Text);
        }

        private void RssLinkLabelMouseEnter(object sender, EventArgs e)
        {
            rssLinkLabel.ForeColor = Color.Blue;
        }

        private void RssLinkLabelMouseLeave(object sender, EventArgs e)
        {
            rssLinkLabel.ForeColor = Color.RoyalBlue;
        }

        private void RssFetchingThreadDoWork(object sender, DoWorkEventArgs e)
        {
            DatabaseWrapper.NewsItemsRetriever();
            DatabaseWrapper.CleanNewsOlderThan(Settings.Default.keepInDatabaseFor);
        }

        private void RssFetchingThreadRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rssTickTimer.Enabled = true;
        }

        /// <summary>
        /// This method represents the action of reading a chapter. It sets the date last read of the selected manga to the current Date
        /// (when the method was called) and increases the last chapter by one.
        /// </summary>
        public void ChapterFinished()
        {
            try
            {
                if (mangaListDataGridView.CurrentRow == null)
                    return;
                DatabaseWrapper.ChapterFinished(
                    (string) mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);

                if (mangaListDataGridView.CurrentRow == null)
                    return;

                mangaListDataGridView.CurrentRow.Cells["Last Time Read"].Value = DateTime.Now;
                mangaListDataGridView.CurrentRow.Cells["Current\nChapter"].Value =
                    Convert.ToDouble(
                        mangaListDataGridView.CurrentRow.Cells["Current\nChapter"].Value) + 1;
                if (_isWebFormOpen)
                {
                    var currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
                    _web.SetTitle(string.Format("Manga: {0} - Current Chapter: {1} - Last Read: {2}",
                                                mangaListDataGridView[0, currentSelectedRow].Value,
                                                mangaListDataGridView[2, currentSelectedRow].Value,
                                                mangaListDataGridView[3, currentSelectedRow].Value));
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        private delegate void ProgressChangedInvoker(int maxProgress, int currentProgress);

        public void ProgressChanged(int maxProgress, int currentProgress)
        {
            if (InvokeRequired)
            {
                Invoke(new ProgressChangedInvoker(ProgressChanged), maxProgress, currentProgress);
            }
            else
            {
                statusProgressBar.Maximum = maxProgress;
                statusProgressBar.Value = currentProgress;
            }
        }

        public void WebFormClosed()
        {
            _isWebFormOpen = false;
        }

        private delegate void LoadDataGridDelegate();

        public void LoadDatagrid()
        {
            if (InvokeRequired)
            {
                Invoke(new LoadDataGridDelegate(LoadDatagrid));
            }
            else
            {
                mangaListDataGridView.DataSource = DatabaseWrapper.GetReadingData(Settings.Default.displayFinished);
            }
        }

        private void LoadCurrentImage()
        {
            if (mangaListDataGridView.CurrentRow == null)
                return;
            mangaCoverPictureBox.Image = DatabaseWrapper.GetMangaCover(
                (string) mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
        }

        private void LoadCurrentDescription()
        {
            if (mangaListDataGridView.CurrentRow == null)
                return;

            mangaDescriptionTextBox.Text = DatabaseWrapper.GetMangaDescriptions(
                (string) mangaListDataGridView[0, mangaListDataGridView.CurrentRow.Index].Value);
        }

        private void HandleMainFormLoad(object sender, EventArgs e)
        {
            LoadDatagrid();
            mangaListDataGridView.AutoGenerateColumns = false;
            RssStatusChecker();
        }

        private void HandleMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            if (
                MessageBox.Show(Resources.MainForm_MainFormFormClosing_Are_you_sure_you_want_to_close_the_application_,
                                Resources.MainForm_MainFormFormClosing_Confirmation, MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void HandleRestoreToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Resources.MainForm_RestoreToolStripMenuItemClick_Are_you_sure_you_want_to_clear_the_reading_List_,
                Resources.MainForm_ClearToolStripMenuItemClick_Question, MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            DatabaseWrapper.ClearTheReadingList();
            if (restoreOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            Thread readFromXml = new Thread(IoWrapper.ReadingListFromXml);
            readFromXml.Start(new DataPasser(this, restoreOpenFileDialog.FileName));
            LoadDatagrid();
        }

        private void HandleDisplayFinishedToolStripMenuItemClick(object sender, EventArgs e)
        {
            Settings.Default.displayFinished = !Settings.Default.displayFinished;
            var dataGridViewColumn = mangaListDataGridView.Columns["finishedReadingDataGridViewTextBoxColumn"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.Visible = Settings.Default.displayFinished;
            LoadDatagrid();
        }

        private void HandleAddMangaToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var amf = new AddMangaForm())
            {
                amf.ShowDialog();
                LoadDatagrid();
            }
        }

        private void HandleStatisticsToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var stats = new StatisticsForm())
            {
                stats.ShowDialog();
            }
        }

        private void HandleNetworkAddressChangedHandler(object sender, EventArgs e)
        {
            RssStatusChecker();
        }

        private void HandleBackupToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (backupSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                IoWrapper.ReadingListToXml(backupSaveFileDialog.FileName);
            }
        }

        private void HandleQuitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HandleClearToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(Resources.MainForm_ClearToolStripMenuItemClick_Are_you_sure_to_clear_the_database_,
                                Resources.MainForm_ClearToolStripMenuItemClick_Question, MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                DatabaseWrapper.ClearTheReadingList();
            }
        }

        private void HandleMangaListDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            LoadCurrentImage();
            LoadCurrentDescription();
        }

        private void HandleJustReadToolStripButtonClick(object sender, EventArgs e)
        {
            ChapterFinished();
        }

        private void HandleSearchToolStripTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            mangaListDataGridView.DataSource = DatabaseWrapper.GetMatchingManga(searchToolStripTextBox.Text);
        }

        private void HandleBrowserNavBarItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == backToolStripButton)
            {
                _wikiWebKitBrowser.GoBack();
            }
            else if (e.ClickedItem == forwardToolStripButton)
            {
                _wikiWebKitBrowser.GoForward();
            }
            else if (e.ClickedItem == wReloadtoolStripButton)
            {
                _wikiWebKitBrowser.Reload();
            }
        }

        /// <summary>
        /// Handles the Enter event of the wikipediaTabPage control. (Fires every time except the first time you enter the wikiTab)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void HandleWikipediaTabPageEnter(object sender, EventArgs e)
        {
            if (mangaListDataGridView.Rows.Count == 0) return;
            if (mangaListDataGridView.CurrentRow == null) return;
            var currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
            var navigationUrl = string.Format("http://en.wikipedia.org/w/index.php?search={0}&go=Go",
                                              RegularExpressions.WhiteSpaceToUrlEncoding(
                                                  mangaListDataGridView[0, currentSelectedRow].Value.ToString()));
            try
            {
                _wikiWebKitBrowser.Navigate(navigationUrl);
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        private void HandleOpenToBrowserToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (!_isWebFormOpen)
                {
                    _web = new WebForm(this);
                    _web.Show();
                    _isWebFormOpen = true;
                }
                if (mangaListDataGridView.Rows.Count != 0)
                {
                    if (mangaListDataGridView.CurrentRow != null)
                    {
                        var currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
                        var mangaUrl = mangaListDataGridView[3, currentSelectedRow].Value.ToString();
                        if (!String.IsNullOrEmpty(mangaUrl))
                        {
                            _web.Navigate(mangaUrl);
                            _web.SetTitle(string.Format("Manga: {0} - Current Chapter: {1} - Last Read: {2}",
                                                        mangaListDataGridView[0, currentSelectedRow].Value,
                                                        mangaListDataGridView[2, currentSelectedRow].Value,
                                                        mangaListDataGridView[3, currentSelectedRow].Value));
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

        private void HandleReloadToolStripButtonClick(object sender, EventArgs e)
        {
            LoadDatagrid();
        }
    }
}