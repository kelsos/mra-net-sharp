using System;
using System.Windows.Forms;
using mraNet.Classes;
using WebKit;
using mraNet.Classes.Events;
using mraNet.Classes.Utilities;

#if DOTNET4
using WebKit.JSCore;
#endif

namespace mraNet.Forms
{
    public partial class BrowserWindow : Form
    {
        private MessageFilter _mbfilter;
        private WebKitBrowser _webKitBrowser;

        public BrowserWindow()
        {
            InitializeComponent();
            InitializeWebkitBrowser();
            InitializeEventHandlers();
            justReadButton.Enabled = false;
        }

        private void InitializeEventHandlers()
        {
            HandleCreated += WebFormHandleCreated;
            HandleDestroyed += WebFormHandleDestroyed;
            Activated += WebFormActivated;
            Deactivate += WebFormDeactivate;
            _webKitBrowser.Navigated += HandleWebKitBrowserNavigated;
        }

        private void InitializeWebkitBrowser()
        {
            _webKitBrowser = new WebKitBrowser();
            browserPanel.Controls.Add(_webKitBrowser);
            _webKitBrowser.Dock = DockStyle.Fill;
            _webKitBrowser.Top = 10;
        }

        private void HandleWebKitBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            statusLabel.Text = _webKitBrowser.Url.ToString();
        }

        public void SetTitle(string newTitle)
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
            if (e.Source == "News")
                justReadButton.Enabled = false;
            else if (e.Source == "Web")
                justReadButton.Enabled = true;
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
            if (_webKitBrowser.CanGoBack)
                _webKitBrowser.GoBack();
        }

        private void ForwardToolStripButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (_webKitBrowser.CanGoForward)
                {
                    _webKitBrowser.GoForward();
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
            _webKitBrowser.Reload();
        }

        /// <summary>
        /// Navigates to the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        public void Navigate(string url)
        {
            _webKitBrowser.Navigate(url);
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

    }
}