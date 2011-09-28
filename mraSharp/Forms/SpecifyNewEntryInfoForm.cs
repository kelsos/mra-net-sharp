using System;
using System.Drawing;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
	public partial class SpecifyNewEntryInfoForm : Form
	{
		public SpecifyNewEntryInfoForm()
		{
			InitializeComponent();
		}

		private MangaRead mR;
		private double _startingChapter;
		private double _currentChapter;

		public SpecifyNewEntryInfoForm(ref MangaRead mRe)
		{
			InitializeComponent();

			mR = mRe;
			_currentChapter = _startingChapter = 1;
			setCurrentChapterTextBox.Text = setStartingChapterTextBox.Text = @"1";

			setStartingChapterTextBox.KeyUp += SetStartingChapterTextBoxValidate;
			setCurrentChapterTextBox.KeyUp += SetCurrentChapterTextBoxValidate;
		}

		private void SetStartingChapterTextBoxValidate(object sender, EventArgs e)
		{
			if (!double.TryParse(setStartingChapterTextBox.Text, out _startingChapter))
			{
				using (var g = chapterGroupBox.CreateGraphics())
				{
					Image wrongEntry = Properties.Resources.exclamation_red;
					g.DrawImage(wrongEntry, (chapterGroupBox.Width / 2) - 18, (chapterGroupBox.Height / 2) - 4, 16, 16);
				}
			}
			else
			{
				using (var g = chapterGroupBox.CreateGraphics())
				{
					var rec = new Rectangle((chapterGroupBox.Width / 2) - 18, (chapterGroupBox.Height / 2) - 4, 16, 16);
					g.FillRectangle(new SolidBrush(chapterGroupBox.BackColor), rec);
				}
			}
		}

		private void SetCurrentChapterTextBoxValidate(object sender, EventArgs e)
		{
			if (!double.TryParse(setCurrentChapterTextBox.Text, out _currentChapter))
			{
				using (var g = chapterGroupBox.CreateGraphics())
				{
					Image wrongEntry = Properties.Resources.exclamation_red;
					g.DrawImage(wrongEntry, chapterGroupBox.Width - 22, (chapterGroupBox.Height / 2) - 4, 16, 16);
				}
			}
			else
			{
				using (var g = chapterGroupBox.CreateGraphics())
				{
					var rec = new Rectangle(chapterGroupBox.Width - 22, (chapterGroupBox.Height / 2) - 4, 16, 16);
					g.FillRectangle(new SolidBrush(chapterGroupBox.BackColor), rec);
				}
			}
		}

		private void SaveButtonClick(object sender, EventArgs e)
		{
			//TODO: Field value validation.
			mR.StartingChapter = _startingChapter;
			mR.CurrentChapter = Convert.ToDouble(setCurrentChapterTextBox.Text);
			mR.LastRead = DateTime.Parse(setDateLastReadDateTimePicker.Text);
			mR.OnlineURL = setOnlineURLTextbox.Text;
			mR.FinishedReading = finishedReadingCheckBox.Checked;
			mR.PersonalNote = personalNoteTextBox.Text;
			mR.Title = null;
		}

/*
		private void DrawErrorImage()
		{
			Graphics g = this.CreateGraphics();
			Image wrongEntry = Properties.Resources.exclamation_red;
			g.DrawImage(wrongEntry, new Rectangle(setStartingChapterTextBox.Left, setStartingChapterTextBox.Top, wrongEntry.Width, wrongEntry.Height));
		}
*/
	}
}