using System;
using System.Globalization;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using mraSharp.Classes;
using mraSharp.Properties;

namespace mraSharp.Forms
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
        private void SubscriptionManagerFormLoad(object sender, EventArgs e)
        {
            subscriptionUrlComboBox.DataSource = DatabaseWrapper.LoadSubscriptions();
            keepInDatabaseForTextBox.Text = Settings.Default.keepInDatabaseFor.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Handles the Click event of the removeSubButton control. (Removes the selected value of the subscriptionUrlComboBox form the database).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void RemoveSubButtonClick(object sender, EventArgs e)
        {
            try
            {
                DatabaseWrapper.RemoveNewsSubscription(subscriptionUrlComboBox.Text);
                subscriptionUrlComboBox.DataSource = DatabaseWrapper.LoadSubscriptions();
                //GetChannelName();
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the addSubButton control. (Adds the rssSubTextBox Text to the database table that represents the subscriptions).
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AddSubButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (rssSubTextBox.Text.Length > 0)
                {
                    if (!String.IsNullOrEmpty(CheckRssChannel(rssSubTextBox.Text)))
                    {
                        DatabaseWrapper.InsertNewsSubscription(rssSubTextBox.Text, CheckRssChannel(rssSubTextBox.Text));
                        rssSubTextBox.Text = null;
                        subscriptionUrlComboBox.DataSource = DatabaseWrapper.LoadSubscriptions();
                    }
                    else
                    {
                        MessageBox.Show(Resources.SubscriptionManagerForm_AddSubButtonClick_Couldn_t_get_Channel_Info,
                                        Resources.SubscriptionManagerForm_AddSubButtonClick_Information,
                                        MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.SubscriptionManagerForm_AddSubButtonClick_Cannot_insert_empty_field_,
                                    Resources.SubscriptionManagerForm_AddSubButtonClick_Information,
                                    MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        /// <summary>
        /// On the click event of importButton the function loads the RSS subscription URLs from the specified file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ImportButtonClick(object sender, EventArgs e)
        {
            FileOperations.RssSubscriptionImporter("rss.txt");
        }

        /// <summary>
        /// On the click event of the exportButton the function exports the RSS subscriptions to the specified file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ExportPopupClick(object sender, EventArgs e)
        {
            FileOperations.RssSubscriptionExporter("rss.txt");
        }


        private static string CheckRssChannel(string subscriptionUrl)
        {
            try
            {
                var myRequest = WebRequest.Create(subscriptionUrl);
                var myResponse = myRequest.GetResponse();
                var rssStream = myResponse.GetResponseStream();
                var rssChannel = new XmlDocument();
                if (rssStream != null) rssChannel.Load(rssStream);
                var channelName = rssChannel.SelectSingleNode("rss/channel/title");
                if (channelName != null) return channelName.InnerText;
            }
            catch (Exception ex)
            {
                ErrorMessageBox.Show(ex.Message, ex.ToString());
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
            return null;
        }

        private void SubscriptionUrlComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            channelTitleTextBox.Text = !String.IsNullOrEmpty(subscriptionUrlComboBox.Text) ? DatabaseWrapper.GetNewsSubscriptionChannelName(subscriptionUrlComboBox.Text) : "";
        }

        private void SubscriptionManagerFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void KeepInDatabaseForTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            //TODO: Validation of the text box.
            Settings.Default.keepInDatabaseFor = Convert.ToInt32(keepInDatabaseForTextBox.Text);
        }
    }
}