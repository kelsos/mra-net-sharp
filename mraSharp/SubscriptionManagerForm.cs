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
		/// Handles the Click event of the removeSubButton control.
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
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		/// <summary>
		/// Handles the Click event of the addSubButton control.
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
				Logger.errorLogger("error.txt", ex.ToString());
			}
		}

		/// <summary>
		/// Handles the Click event of the importButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void importButton_Click(object sender, EventArgs e)
		{
			FileOperations.rssSubscriptionImporter("rss.txt");
		}

		/// <summary>
		/// Handles the Click event of the exportPopup control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void exportPopup_Click(object sender, EventArgs e)
		{
			FileOperations.rssSubscriptionExporter("rss.txt");
		}

		private void loadSubscriptions()
		{
			dataLinqSqlDataContext db = new dataLinqSqlDataContext();
			rssUrlComboBox.DataSource = from url in db.rssSubscriptions
												 select url;
		}
	}
}