using System;
using System.Windows.Forms;
using mraNet.Classes.Events;

namespace mraNet.Forms
{
    public partial class UrlEditorWindow : Form
    {
        public UrlEditorWindow()
        {
            InitializeComponent();
            urlBox.Text = Communicator.Instance.URL;
        }

        private void HandleCancelButtonClick(object sender, EventArgs e)
        {
            Communicator.Instance.URL = string.Empty;
            Close();
        }

        private void HandleSaveButtonClick(object sender, EventArgs e)
        {
            Communicator.Instance.URL = urlBox.Text;
            Close();
        }
    }
}
