using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using mraNet.Classes;
using mraNet.Classes.Data;
using mraNet.Classes.Events;
using mraNet.Classes.Utilities;
using mraNet.Properties;

namespace mraNet.Forms
{
    public partial class ApplicationWindow : Form
    {
        private int _myCounter;
        private bool _internetIsUp;
        private BrowserWindow _web;

        public ApplicationWindow()
        {
            InitializeComponent();

            _myCounter = 1;
            rssCheckTimer.Enabled = false;
            newsFeedTickTimer.Enabled = false;
            statusLabel.Text = "";

            Gecko.Xpcom.Initialize(Application.StartupPath + "\\xulrunner\\");

            //Gets the current check state from the Application Settings
            displayFinishedToolStripMenuItem.CheckState = Settings.Default.displayFinished
                                                              ? CheckState.Checked
                                                              : CheckState.Unchecked;
            //checks if network is up
            System.Net.NetworkInformation.NetworkChange.NetworkAddressChanged += HandleNetworkAddressChangedHandler;
            Communicator.Instance.ChapterFinished += InstanceOnChapterFinished;

            //DataLoad
            Load+=ApplicationWindowLoad;
            
        }

        private void ApplicationWindowLoad(object sender, EventArgs e)
        {
            UpdateMangaList(DatabaseWrapper.GetReadingData(Settings.Default.displayFinished));
        }



        public void UpdateMangaList(List<string> mangaList)
        {
            mangaListCombo.DataSource = mangaList;
        }

        private void InstanceOnChapterFinished(object sender, EventArgs eventArgs)
        {
            ChapterFinished();
        }

        private void RssStatusChecker()
        {
            _internetIsUp = NetworkOperations.IsConnectivityAvailable();
            if (!_internetIsUp)
            {
                if (DatabaseWrapper.FeedDataExistInTheDatabase())
                {
                    newsFeedTickTimer.Enabled = true;
                    rssCheckTimer.Enabled = false;
                    statusLabel.Text = Resources.MainForm_RssStatusChecker_No_Internet_Connection_Available;
                }
                else
                {
                    rssTitleLabel.Text = "";
                    rssDescriptionTextBox.Text = "";
                    rssLinkLabel.Text = "";
                    statusLabel.Text = Resources.MainForm_RssStatusChecker_No_Internet_Connection_Available;
                    newsFeedTickTimer.Enabled = false;
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


        private List<NewsItem> _newsList;

        private void NewsTicker(string action)
        {
            if (_newsList == null)
                _newsList = DatabaseWrapper.GetNewsItemList();
            try
            {
                int newsItemsCount = _newsList.Count();
                if (newsItemsCount <= 0)
                    return;
                if (string.IsNullOrEmpty(action))
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
                else
                {
                    if (_myCounter > 0)
                    {
                        rssTitleLabel.Text = _newsList[_myCounter].Title;
                        rssLinkLabel.Text = _newsList[_myCounter].Link;
                        rssDescriptionTextBox.Text = _newsList[_myCounter].Description;
                        _myCounter -= 1;
                    }
                    else
                    {
                        _myCounter = newsItemsCount - 1;
                        rssTitleLabel.Text = _newsList[_myCounter].Title;
                        rssLinkLabel.Text = _newsList[_myCounter].Link;
                        rssDescriptionTextBox.Text = _newsList[_myCounter].Description;
                        _myCounter -= 1;
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
            NewsTicker(null);
        }

        private void HandleNewsTickerLinkLabelClick(object sender, EventArgs e)
        {
            if (!CheckIfOpen(_web))
            {
                _web = new BrowserWindow();
                _web.Show();
            }
            Communicator.Instance.OnWebDataAvailable(this,
                                                     new WebDataArgs(rssTitleLabel.Text + ": " + rssLinkLabel.Text,
                                                                     rssLinkLabel.Text, "News"));
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
            newsFeedTickTimer.Enabled = true;
        }

        /// <summary>
        /// This method represents the action of reading a chapter. It sets the date last read of the selected manga to the current Date
        /// (when the method was called) and increases the last chapter by one.
        /// </summary>
        private void ChapterFinished()
        {
            try
            {
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

        private delegate void LoadDataGridDelegate();

        private void LoadDatagrid()
        {
            if (InvokeRequired)
            {
                Invoke(new LoadDataGridDelegate(LoadDatagrid));
            }
            else
            {
            }
        }

        private void HandleMainFormLoad(object sender, EventArgs e)
        {
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
            DatabaseWrapper.ClearReadingList();
            if (restoreOpenFileDialog.ShowDialog() != DialogResult.OK) return;
            Thread readFromXml = new Thread(IoWrapper.ReadingListFromXml);
            readFromXml.Start(new DataPasser(this, restoreOpenFileDialog.FileName));
            LoadDatagrid();
        }

        private void HandleDisplayFinishedToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void HandleAddMangaToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var amf = new AddReadItemWindow())
            {
                amf.ShowDialog();
                LoadDatagrid();
            }
        }

        private void HandleStatisticsToolStripMenuItemClick(object sender, EventArgs e)
        {
            using (var stats = new StatisticsWindow())
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
                DatabaseWrapper.ClearReadingList();
            }
        }

        private void HandleJustReadToolStripButtonClick(object sender, EventArgs e)
        {
            ChapterFinished();
        }

        private void HandleSearchToolStripTextBoxKeyUp(object sender, KeyEventArgs e)
        {
        }


        private void HandleOpenToBrowserToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        private static bool CheckIfOpen(Form form)
        {
            return form != null && Application.OpenForms.Cast<Form>().Any(f => form == f);
        }

        private void HandleReloadToolStripButtonClick(object sender, EventArgs e)
        {
            LoadDatagrid();
        }

        private void HandleGoToPreviousNewsItemButtonClick(object sender, EventArgs e)
        {
            NewsTicker("NonNullorEmpty");
        }

        private void HandleGoToNextNewsItemButtonClick(object sender, EventArgs e)
        {
            NewsTicker(null);
        }

        private void HandleOpenUrlEditorMenuItemClick(object sender, EventArgs e)
        {
            //if (mangaListDataGridView.Rows.Count == 0) return;
            //if (mangaListDataGridView.CurrentRow == null) return;
            //int currentSelectedRow = mangaListDataGridView.CurrentRow.Index;
            //Communicator.Instance.URL = mangaListDataGridView[3, currentSelectedRow].Value.ToString();

            //UrlEditorWindow urlEditorWindow = new UrlEditorWindow();
            //urlEditorWindow.ShowDialog();

            //if (!string.IsNullOrEmpty(Communicator.Instance.URL))
            //{
            //    DatabaseWrapper.UpdateMangaUrl(mangaListDataGridView[0, currentSelectedRow].Value.ToString(), Communicator.Instance.URL);
            //    mangaListDataGridView[3, currentSelectedRow].Value = Communicator.Instance.URL;
            //}
        }

        private void MangaListComboSelectedIndexChanged(object sender, EventArgs e)
        {
            mangaCoverPictureBox.Image = DatabaseWrapper.GetMangaCover(mangaListCombo.Text);
            mangaTitleLabel.Text = mangaListCombo.Text;
            startingChapterLabel.Text = DatabaseWrapper.GetStartingChapter(mangaTitleLabel.Text).ToString(CultureInfo.InvariantCulture);
            currentChapterLabel.Text = DatabaseWrapper.GetCurrentChapter(mangaTitleLabel.Text).ToString(CultureInfo.InvariantCulture);
            lastReadLabel.Text = DatabaseWrapper.GetMangaLastRead(mangaTitleLabel.Text).ToString();
            mangaDescriptionTextBox.Text = DatabaseWrapper.GetMangaDescriptions(mangaTitleLabel.Text).ToString(CultureInfo.InvariantCulture);

        }
    }
}