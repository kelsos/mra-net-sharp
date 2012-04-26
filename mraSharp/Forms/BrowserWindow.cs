using System;
using System.Windows.Forms;
using mraNet.Classes;
using mraNet.Classes.Events;
using mraNet.Classes.Utilities;


namespace mraNet.Forms
{
    public partial class BrowserWindow : Form
    {
        private MessageFilter _mbfilter;

        public BrowserWindow()
        {
            InitializeComponent();
            InitializeEventHandlers();
            justReadButton.Enabled = false;
            InternalBrowser.ScriptErrorsSuppressed = true;
        }

        private void InitializeEventHandlers()
        {
            HandleCreated += WebFormHandleCreated;
            HandleDestroyed += WebFormHandleDestroyed;
            Activated += WebFormActivated;
            Deactivate += WebFormDeactivate;
            InternalBrowser.Navigated += HandleWebKitBrowserNavigated;
        }

        private void HandleWebKitBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            statusLabel.Text = InternalBrowser.StatusText;
            navigationUrlBox.Text = InternalBrowser.Url.ToString();
        }

        private void SetTitle(string newTitle)
        {
            Text = newTitle;
        }

        private void WebFormHandleCreated(object sender, EventArgs e)
        {
            Communicator.Instance.WebDataAvailable += HandleWebDataEvent;
            EventHandler backevent = BackToolStripButtonClick;
            EventHandler forwardevent = ForwardToolStripButtonClick;
            _mbfilter = new MessageFilter(this, ref backevent, ref forwardevent);
        }

        private void HandleWebDataEvent(object sender, WebDataArgs e)
        {
            SetTitle(e.Message);
            if (e.NavigateUrl!=null)
                Navigate(e.NavigateUrl);
            switch (e.Source)
            {
                case "News":
                    justReadButton.Enabled = false;
                    break;
                case "Web":
                    justReadButton.Enabled = true;
                    break;
            }
        }

        private void WebFormHandleDestroyed(object sender, EventArgs e)
        {
            Communicator.Instance.WebDataAvailable -= HandleWebDataEvent;
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
            if (InternalBrowser.CanGoBack)
                InternalBrowser.GoBack();
        }

        private void ForwardToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (InternalBrowser.CanGoForward)
                {
                    InternalBrowser.GoForward();
                }
                else
                {
                    SendKeys.Send("{RIGHT}");
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorLogger("error.txt", ex.ToString());
            }
        }

        private void ReloadToolStripButtonClick(object sender, EventArgs e)
        {
            InternalBrowser.Refresh();
        }

        /// <summary>
        /// Navigates to the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        private void Navigate(string url)
        {
            InternalBrowser.Navigate(url);
            navigationUrlBox.Text = url;
        }

        private void HandleChapterFinishedButtonClick(object sender, EventArgs e)
        {
            Communicator.Instance.OnChapterFinished(sender,e);
        }

        private void WebFormFormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void HandleStatusLabelMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                Clipboard.SetText(statusLabel.Text);
            }
        }

        private void BrowserWindowLoad(object sender, EventArgs e)
        {

        }

        private void NavigateButtonClick(object sender, EventArgs e)
        {
            InternalBrowser.Navigate(navigationUrlBox.Text);
        }

        private void NavigationUrlBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='\r')
            {
                InternalBrowser.Navigate(navigationUrlBox.Text);    
            }
        }

        private void UpdateUrlButtonClick(object sender, EventArgs e)
        {
            
        }

    }
}