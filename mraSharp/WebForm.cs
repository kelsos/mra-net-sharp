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
	public partial class WebForm : Form
	{
		public WebForm()
		{
			InitializeComponent();
		}

		private void backToolStripButton_Click(object sender, EventArgs e)
		{
			geckoReader.GoBack();
		}

		private void forwardToolStripButton_Click(object sender, EventArgs e)
		{
			geckoReader.GoForward();
		}

		private void reloadToolStripButton_Click(object sender, EventArgs e)
		{
			geckoReader.Reload();
		}
		/// <summary>
		/// Navigates to the specified URL.
		/// </summary>
		/// <param name="URL">The URL.</param>
		public void Navigate(string URL)
		{
			geckoReader.Navigate(URL);
		}

		private void geckoReader_Navigated(object sender, Skybound.Gecko.GeckoNavigatedEventArgs e)
		{
			statusLabel.Text = geckoReader.Url.ToString();
		}
	}
}
