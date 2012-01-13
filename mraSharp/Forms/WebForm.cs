using System;
using System.Windows.Forms;
using mraSharp.Classes;
using WebKit;

#if DOTNET4
using WebKit.JSCore;
#endif

namespace mraSharp.Forms
{
    public partial class WebForm : Form
    {
        private MessageFilter _mbfilter;
        private readonly MainForm _form;
        private readonly WebKitBrowser _webKitBrowser;

        public WebForm()
        {
            InitializeComponent();
            HandleCreated += WebFormHandleCreated;
            HandleDestroyed += WebFormHandleDestroyed;
            Activated += WebFormActivated;
            Deactivate += WebFormDeactivate;
            justReadButton.Enabled = false;
            _form = null;
            _webKitBrowser = new WebKitBrowser();
            browserPanel.Controls.Add(_webKitBrowser);
            _webKitBrowser.Dock = DockStyle.Fill;
            _webKitBrowser.Navigated += WebKitBrowserNavigated;
            _webKitBrowser.Top = 10;
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
            _webKitBrowser = new WebKitBrowser();
            browserPanel.Controls.Add(_webKitBrowser);
            _webKitBrowser.Dock = DockStyle.Fill;
            _webKitBrowser.Top = 10;


            _webKitBrowser.Navigated += WebKitBrowserNavigated;
        }

        private void WebKitBrowserNavigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            statusLabel.Text = _webKitBrowser.Url.ToString();
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

        private void JustReadButtonClick(object sender, EventArgs e)
        {
            _form.ChapterFinished();
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