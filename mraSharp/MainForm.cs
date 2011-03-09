using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace mraSharp
{
   public partial class MainForm : Form
   {
		private int myCounter = 0;

      public MainForm()
      {
         InitializeComponent();
         Skybound.Gecko.Xpcom.Initialize(Application.StartupPath.ToString() + "\\xulrunner\\");
			geckoWiki.HandleCreated += new EventHandler(geckoWiki_HandleCreated);// creates a new event handler for the HandleCreated event of GeckoWiki
			rssFetchingThread.RunWorkerAsync();
		}

      private void MainForm_Load(object sender, EventArgs e)
      {
			// TODO: This line of code loads data into the 'dataStoreDataSet.newsStorage' table. You can move, or remove it, as needed.
			this.newsStorageTableAdapter.Fill(this.dataStoreDataSet.newsStorage);
         // TODO: This line of code loads data into the 'dataStoreDataSet.mangaList' table. You can move, or remove it, as needed.
			this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);
      }

		private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to clear the database?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DatabaseOperations.clearDatabase();
				if (restoreOpenFileDialog.ShowDialog() == DialogResult.OK)
				{
					FileOperations.restoreMangaList(restoreOpenFileDialog.FileName,ref this.dataStoreDataSet);
					this.mangaListTableAdapter.Update(this.dataStoreDataSet.mangaList);
				}
				this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);
			}
		}

		private void backupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (backupSaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using(DataStoreDataSet backupDatasSet = new DataStoreDataSet())
				{
					this.mangaListTableAdapter.Fill(backupDatasSet.mangaList);
					FileOperations.backupMangaList(backupDatasSet, backupSaveFileDialog.FileName);
				}
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

		private void rssTicker()
		{
			this.newsStorageTableAdapter.Fill(this.dataStoreDataSet.newsStorage);
			int rowsNumber = dataStoreDataSet.newsStorage.Rows.Count;
			if (rowsNumber > myCounter)
			{
				rssTitleLabel.Text = dataStoreDataSet.newsStorage.Rows[myCounter].ItemArray[0].ToString();
				rssLinkLabel.Text = dataStoreDataSet.newsStorage.Rows[myCounter].ItemArray[1].ToString();
				rssDescriptionTextBox.Text = dataStoreDataSet.newsStorage.Rows[myCounter].ItemArray[2].ToString();
				myCounter += 1;
			}
			else
			{
				myCounter = 0;
				rssTitleLabel.Text = dataStoreDataSet.newsStorage.Rows[myCounter].ItemArray[0].ToString();
				rssLinkLabel.Text = dataStoreDataSet.newsStorage.Rows[myCounter].ItemArray[1].ToString();
				rssDescriptionTextBox.Text = dataStoreDataSet.newsStorage.Rows[myCounter].ItemArray[2].ToString();
				myCounter += 1;
			}
		}

		private void rssFetcher()
		{
			this.rssSubscriptionsTableAdapter.Fill(this.dataStoreDataSet.rssSubscriptions);

			try
			{
				foreach(DataStoreDataSet.rssSubscriptionsRow currentChannel in dataStoreDataSet.rssSubscriptions.Rows)
				{
					ArrayList result = RssManager.processNewsFeed(currentChannel.rssUrl);
					foreach(RssNewsItem currentNewsItem in result)
					{
						string title = currentNewsItem.Title;
						title = title.Replace("'", "");
						title = title.Trim();

						string filterExpression = "rssTitle = '" + title + "'";

						DataRow[] filteredNewsItems = dataStoreDataSet.newsStorage.Select(filterExpression);

						if (filteredNewsItems.Length == 0)
						{
							DataStoreDataSet.newsStorageRow newRow = dataStoreDataSet.newsStorage.NewnewsStorageRow();
							newRow.rssTitle = title;
							newRow.rssLink = currentNewsItem.Link;
							newRow.rssDescription = RegularExpressions.htmlTagRemover(currentNewsItem.Description);
							newRow.rssDateAquired = DateTime.Now;

							dataStoreDataSet.newsStorage.AddnewsStorageRow(newRow);
						}
					}
				}
				this.newsStorageTableAdapter.Update(this.dataStoreDataSet);
			}
			catch(Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}
		/// <summary>
		/// This method represents the action of reading a chapter. It sets the date last read of the selected manga to the current Date
		/// (when the method was called) and increases the last chapter by one.
		/// </summary>
		private void justReadAChapter()
		{
			int selectedRowIndex = mangaListDataGridView.CurrentRow.Index;
			string currentMangaTitle = mangaListDataGridView[0, selectedRowIndex].Value.ToString();

			DataStoreDataSet.mangaListRow rowToEdit = dataStoreDataSet.mangaList.FindBymangaTitle(currentMangaTitle);
			rowToEdit.dateRead = DateTime.Now;
			rowToEdit.currentChapter += 1;

			this.mangaListTableAdapter.Update(this.dataStoreDataSet.mangaList);
		}

		private void justReadToolStripButton_Click(object sender, EventArgs e)
		{
			justReadAChapter();
		}

		private void searchToolStripTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (searchToolStripTextBox.TextLength > 0)
				this.mangaListTableAdapter.FillBySearch(this.dataStoreDataSet.mangaList, "%" + searchToolStripTextBox + "%");
			else
				this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);
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
					MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
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
					MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
				}
			}
		}

		private void openToBrowserToolStripButton_Click(object sender, EventArgs e)
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

		private void reloadToolStripButton_Click(object sender, EventArgs e)
		{
			this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);
		}

		private void editoToolStripButton_Click(object sender, EventArgs e)
		{
			using(EditorForm editor = new EditorForm())
			{
				editor.ShowDialog();
			}
			this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);
		}

		private void rssSubscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(SubscriptionManagerForm manager = new SubscriptionManagerForm())
			{
				manager.ShowDialog();
			}
		}

		private void editorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using(EditorForm editor = new EditorForm())
			{
				editor.ShowDialog();
			}
			this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);
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
			using(StatisticsForm stats = new StatisticsForm())
			{
				stats.ShowDialog();
			}
		}
   }
}
