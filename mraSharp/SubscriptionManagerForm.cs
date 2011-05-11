using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;

namespace mraSharp
{
	public partial class SubscriptionManagerForm : Form
	{
		public SubscriptionManagerForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the Load event of the SubscriptionManagerForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void SubscriptionManagerForm_Load(object sender, EventArgs e)
		{
			loadSubscriptions();
		}

		/// <summary>
		/// Handles the Click event of the removeSubButton control. (Removes the selected value of the RssUrlComboBox form the database).
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void removeSubButton_Click(object sender, EventArgs e)
		{
			try
			{
				DatabaseOperations.removeRssSubscription(rssUrlComboBox.Text);
				loadSubscriptions();
				getChannelName();
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		/// <summary>
		/// Handles the Click event of the addSubButton control. (Adds the rssSubTextBox Text to the database table that represents the subscriptions).
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void addSubButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (rssSubTextBox.Text.Length > 0)
				{
					if (!String.IsNullOrEmpty(checkRssChannel(rssSubTextBox.Text)))
					{
						DatabaseOperations.insertRssSubscription(rssSubTextBox.Text, checkRssChannel(rssSubTextBox.Text));
						rssSubTextBox.Text = null;
						loadSubscriptions();
					}
					else
					{
						MessageBox.Show("Couldn't get Channel Info", "Information", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Cannot insert empty field!", "Information", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		/// <summary>
		/// On the click event of importButton the function loads the RSS subscription URLs from the specified file.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void importButton_Click(object sender, EventArgs e)
		{
			FileOperations.rssSubscriptionImporter("rss.txt");
		}

		/// <summary>
		/// On the click event of the exportButton the function exports the RSS subscriptions to the specified file.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void exportPopup_Click(object sender, EventArgs e)
		{
			FileOperations.rssSubscriptionExporter("rss.txt");
		}

		/// <summary>
		/// Loads the Rss Subscriptions (URLs) from the database.
		/// </summary>
		private void loadSubscriptions()
		{
			try
			{
				Mds db = new Mds(Properties.Settings.Default.DbConnection);
				rssUrlComboBox.DataSource = from url in db.Rss_Subscriptions
													 select url.RssURL;
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		private string checkRssChannel(string rssURL)
		{
			try
			{

				WebRequest myRequest = WebRequest.Create(rssURL);
				WebResponse myResponse = myRequest.GetResponse();
				Stream rssStream = myResponse.GetResponseStream();
				XmlDocument rssChannel = new XmlDocument();
				rssChannel.Load(rssStream);
				XmlNode channelName = rssChannel.SelectSingleNode("rss/channel/title");
				return channelName.InnerText;
			}
			catch (Exception ex)
			{
				errorMessageBox.Show(ex.Message.ToString(), ex.ToString());
				Logger.errorLogger("error.txt", ex.ToString());
				return "";
			}
		}

		private void rssUrlComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			getChannelName();
		}

		private void getChannelName()
		{
			using (Mds db = new Mds(Properties.Settings.Default.DbConnection))
			{
				if (!String.IsNullOrEmpty(rssUrlComboBox.Text))
				{
					string channelName = (from data in db.Rss_Subscriptions
												 where data.RssURL == rssUrlComboBox.Text
												 select data.RssChannelName).SingleOrDefault();
					channelTitleTextBox.Text = channelName;
				}
				else
				{
					channelTitleTextBox.Text = "";
				}
			}
		}
	}
}