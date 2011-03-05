using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mraSharp
{
	public partial class SubscriptionManagerForm : Form
	{
		public SubscriptionManagerForm()
		{
			InitializeComponent();
		}

		private void rssSubscriptionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.rssSubscriptionsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dataStoreDataSet);
		}

		private void SubscriptionManagerForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataStoreDataSet.rssSubscriptions' table. You can move, or remove it, as needed.
			this.rssSubscriptionsTableAdapter.Fill(this.dataStoreDataSet.rssSubscriptions);
		}

		private void removeSubButton_Click(object sender, EventArgs e)
		{
			try
			{
				DatabaseOperations.removeRssSubscription(rssUrlComboBox.Text);
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
			this.rssSubscriptionsTableAdapter.Fill(this.dataStoreDataSet.rssSubscriptions);
		}

		private void addSubButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (rssSubTextBox.Text.Length > 0)
				{
					DatabaseOperations.insertRssSubscription(rssSubTextBox.Text);
					rssSubTextBox.Text = null;
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
			this.rssSubscriptionsTableAdapter.Fill(this.dataStoreDataSet.rssSubscriptions);
		}

		private void importButton_Click(object sender, EventArgs e)
		{

		}

		private void exportPopup_Click(object sender, EventArgs e)
		{

		}

	}
}
