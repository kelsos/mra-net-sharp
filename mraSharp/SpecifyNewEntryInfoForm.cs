using System;
using System.Drawing;
using System.Windows.Forms;

namespace mraSharp
{
	public partial class SpecifyNewEntryInfoForm : Form
	{
		public SpecifyNewEntryInfoForm()
		{
			InitializeComponent();
		}

		private mangaRead mR;
		private double startingChapter;
		private double currentChapter;

		public SpecifyNewEntryInfoForm(ref mangaRead mRe)
		{
			InitializeComponent();

			mR = mRe;
			currentChapter = startingChapter = 1;
			setCurrentChapterTextBox.Text = setStartingChapterTextBox.Text = "1";

			setStartingChapterTextBox.KeyUp += new KeyEventHandler(setStartingChapterTextBox_Validate);
			setCurrentChapterTextBox.KeyUp += new KeyEventHandler(setCurrentChapterTextBox_Validate);
		}

		private void setStartingChapterTextBox_Validate(object sender, EventArgs e)
		{
			if (!double.TryParse(setStartingChapterTextBox.Text, out startingChapter))
			{
				using (Graphics g = chapterGroupBox.CreateGraphics())
				{
					Image wrongEntry = Properties.Resources.exclamation_red;
					g.DrawImage(wrongEntry, (chapterGroupBox.Width / 2) - 18, (chapterGroupBox.Height / 2) - 4, 16, 16);
				}
			}
			else
			{
				using (Graphics g = chapterGroupBox.CreateGraphics())
				{
					Rectangle rec = new Rectangle((chapterGroupBox.Width / 2) - 18, (chapterGroupBox.Height / 2) - 4, 16, 16);
					g.FillRectangle(new SolidBrush(chapterGroupBox.BackColor), rec);
				}
			}
		}

		private void setCurrentChapterTextBox_Validate(object sender, EventArgs e)
		{
			if (!double.TryParse(setCurrentChapterTextBox.Text, out currentChapter))
			{
				using (Graphics g = chapterGroupBox.CreateGraphics())
				{
					Image wrongEntry = Properties.Resources.exclamation_red;
					g.DrawImage(wrongEntry, chapterGroupBox.Width - 22, (chapterGroupBox.Height / 2) - 4, 16, 16);
				}
			}
			else
			{
				using (Graphics g = chapterGroupBox.CreateGraphics())
				{
					Rectangle rec = new Rectangle(chapterGroupBox.Width - 22, (chapterGroupBox.Height / 2) - 4, 16, 16);
					g.FillRectangle(new SolidBrush(chapterGroupBox.BackColor), rec);
				}
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			//TODO: Field value validation.
			mR.StartingChapter = startingChapter;
			mR.CurrentChapter = Convert.ToDouble(setCurrentChapterTextBox.Text);
			mR.LastRead = DateTime.Parse(setDateLastReadDateTimePicker.Text);
			mR.OnlineURL = setOnlineURLTextbox.Text;
			mR.FinishedReading = finishedReadingCheckBox.Checked;
			mR.PersonalNote = personalNoteTextBox.Text;
			mR.Title = null;
		}

		private void drawErrorImage()
		{
			Graphics g = this.CreateGraphics();
			Image wrongEntry = Properties.Resources.exclamation_red;
			g.DrawImage(wrongEntry, new Rectangle(setStartingChapterTextBox.Left, setStartingChapterTextBox.Top, wrongEntry.Width, wrongEntry.Height));
		}
	}
}