using System;
using System.Windows.Forms;

namespace mraSharp
{
	public partial class WebForm : Form
	{
		private MessageFilter _mbfilter;
		private MainForm _form;

		public WebForm()
		{
			InitializeComponent();
			this.HandleCreated += new EventHandler(webForm_HandleCreated);
			this.HandleDestroyed += new EventHandler(webForm_HandleDestroyed);
			this.Activated += new EventHandler(webForm_Activated);
			this.Deactivate += new EventHandler(webForm_Deactivate);
			justReadButton.Enabled = false;
			_form = null;
		}

		public WebForm(MainForm form)
		{
			InitializeComponent();
			this.HandleCreated += new EventHandler(webForm_HandleCreated);
			this.HandleDestroyed += new EventHandler(webForm_HandleDestroyed);
			this.Activated += new EventHandler(webForm_Activated);
			this.Deactivate += new EventHandler(webForm_Deactivate);
			_form = form;
			justReadButton.Enabled = true;
		}

		public void setTitle(string newTitle)
		{
			this.Text = newTitle;
		}

		private void webForm_HandleCreated(object sender, EventArgs e)
		{
			EventHandler backevent = new EventHandler(backToolStripButton_Click);
			EventHandler forwardevent = new EventHandler(forwardToolStripButton_Click);
			_mbfilter = new MessageFilter(this, ref backevent, ref forwardevent);
		}

		private void webForm_HandleDestroyed(object sender, EventArgs e)
		{
			_mbfilter = null;
		}

		private void webForm_Activated(object sender, EventArgs e)
		{
			Application.AddMessageFilter(_mbfilter);
		}

		private void webForm_Deactivate(object sender, EventArgs e)
		{
			Application.RemoveMessageFilter(_mbfilter);
		}

		private void backToolStripButton_Click(object sender, EventArgs e)
		{
			if (geckoReader.CanGoBack)
				geckoReader.GoBack();
		}

		private void forwardToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (geckoReader.CanGoForward)
					geckoReader.GoForward();
				else
					SendKeys.Send("{RIGHT}");
			}
			catch (Exception ex)
			{
				Logger.errorLogger("error.txt", ex.ToString());
			}
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

		private void justReadButton_Click(object sender, EventArgs e)
		{
			_form.justReadAChapter();
		}

		private void WebForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_form != null)
			{
				_form.webFormClosed();
			}
		}
	}
}