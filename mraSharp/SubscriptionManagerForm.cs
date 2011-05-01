using System;
using System.Linq;
using System.Windows.Forms;

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
					DatabaseOperations.insertRssSubscription(rssSubTextBox.Text);
					rssSubTextBox.Text = null;
					loadSubscriptions();
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
	}
}