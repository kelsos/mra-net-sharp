using System.Windows.Forms;
using System;

namespace mraSharp
{
   public partial class SpecifyNewEntryInfoForm : Form
   {
      public SpecifyNewEntryInfoForm()
      {
         InitializeComponent();
      }

      private mangaRead mR;
      public SpecifyNewEntryInfoForm(ref mangaRead mRe)
      {
         InitializeComponent();
         mR = mRe;
      }
      private void saveButton_Click(object sender, System.EventArgs e)
      {
         //TODO: field value validation
         mR.StartingChapter = Convert.ToDouble(setStartingChapterTextBox.Text);
         mR.CurrentChapter = Convert.ToDouble(setCurrentChapterTextBox.Text);
         mR.LastRead = DateTime.Parse(setDateLastReadDateTimePicker.Text);
         mR.OnlineURL = setOnlineURLTextbox.Text;
         mR.FinishedReading = finishedReadingCheckBox.Checked;
         mR.PersonalNote = personalNoteTextBox.Text;
         mR.Title = null;
      }
   }
}