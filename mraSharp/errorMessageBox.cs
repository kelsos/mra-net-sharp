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
   public partial class errorMessageBox : Form
   {
      private static errorMessageBox erMb;
      
      public errorMessageBox()
      {
         InitializeComponent();
      }

      public static void Show(string windowTitle, string errorString)
      {
         erMb = new errorMessageBox();
         erMb.Text = windowTitle;
         erMb.errorDescriptionTextBox.Text = errorString;
         erMb.ShowDialog();
      }

      private void closeMessageBoxButton_Click(object sender, EventArgs e)
      {
         erMb.Dispose();
      }

      private void copyToClipboardButton_Click(object sender, EventArgs e)
      {
         Clipboard.SetDataObject(errorDescriptionTextBox.Text);
      }
   }
}
