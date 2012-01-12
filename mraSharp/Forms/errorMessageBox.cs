using System;
using System.Windows.Forms;

namespace mraSharp.Forms
{
    public partial class ErrorMessageBox : Form
    {
        private static ErrorMessageBox _erMb;

        public ErrorMessageBox()
        {
            InitializeComponent();
        }

        public static void Show(string windowTitle, string errorString)
        {
            _erMb = new ErrorMessageBox {Text = windowTitle, errorDescriptionTextBox = {Text = errorString}};
            _erMb.ShowDialog();
        }

        private void CloseMessageBoxButtonClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CopyToClipboardButtonClick(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(errorDescriptionTextBox.Text);
        }
    }
}