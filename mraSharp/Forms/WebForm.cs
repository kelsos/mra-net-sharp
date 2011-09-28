using System;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
	public partial class WebForm : Form
	{
		private MessageFilter _mbfilter;
		private readonly MainForm _form;

		public WebForm()
		{
			InitializeComponent();
			HandleCreated += WebFormHandleCreated;
			HandleDestroyed += WebFormHandleDestroyed;
			Activated += WebFormActivated;
			Deactivate += WebFormDeactivate;
			justReadButton.Enabled = false;
			_form = null;
		}

		public WebForm(MainForm form)
		{
			InitializeComponent();
			HandleCreated += WebFormHandleCreated;
			HandleDestroyed += WebFormHandleDestroyed;
			Activated += WebFormActivated;
			Deactivate += WebFormDeactivate;
			_form = form;
			justReadButton.Enabled = true;
		}

		public void SetTitle(string newTitle)
		{
			Text = newTitle;
		}

		private void WebFormHandleCreated(object sender, EventArgs e)
		{
			EventHandler backevent = BackToolStripButtonClick;
			EventHandler forwardevent = ForwardToolStripButtonClick;
			_mbfilter = new MessageFilter(this, ref backevent, ref forwardevent);
		}

		private void WebFormHandleDestroyed(object sender, EventArgs e)
		{
			_mbfilter = null;
		}

		private void WebFormActivated(object sender, EventArgs e)
		{
			Application.AddMessageFilter(_mbfilter);
		}

		private void WebFormDeactivate(object sender, EventArgs e)
		{
			Application.RemoveMessageFilter(_mbfilter);
		}

		private void BackToolStripButtonClick(object sender, EventArgs e)
		{
			if (geckoReader.CanGoBack)
				geckoReader.GoBack();
		}

		private void ForwardToolStripButtonClick(object sender, EventArgs e)
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
				Logger.ErrorLogger("error.txt", ex.ToString());
			}
		}

		private void ReloadToolStripButtonClick(object sender, EventArgs e)
		{
			geckoReader.Reload();
		}

		/// <summary>
		/// Navigates to the specified URL.
		/// </summary>
		/// <param name="url">The URL.</param>
		public void Navigate(string url)
		{
			geckoReader.Navigate(url);
		}

		private void GeckoReaderNavigated(object sender, Skybound.Gecko.GeckoNavigatedEventArgs e)
		{
			statusLabel.Text = geckoReader.Url.ToString();
		}

		private void JustReadButtonClick(object sender, EventArgs e)
		{
			_form.JustReadAChapter();
		}

		private void WebFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (_form != null)
			{
				_form.WebFormClosed();
			}
		}
	}
}