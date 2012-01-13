using System;
using System.Drawing;
using System.Windows.Forms;
using mraSharp.Classes;

namespace mraSharp.Forms
{
    public partial class SpecifyNewEntryInfoForm : Form
    {
        private ReadItem _readItem;
        private int _startingChapter;
        private int _currentChapter;
        private bool _startChapterValueIsValid;
        private bool _currentChapterValueIsValid;

        public SpecifyNewEntryInfoForm()
        {
            InitializeComponent();
            setStartingChapterTextBox.KeyUp += HandleSetStartingChapterTextBoxValidate;
            setCurrentChapterTextBox.KeyUp += HandleSetCurrentChapterTextBoxValidate;
            _startChapterValueIsValid = true;
            _currentChapterValueIsValid = true;
        }

        private void ChapterBoxesValidator()
        {
            if(_startChapterValueIsValid&&_currentChapterValueIsValid)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void HandleSetStartingChapterTextBoxValidate(object sender, EventArgs e)
        {
            if (!int.TryParse(setStartingChapterTextBox.Text, out _startingChapter))
            {
                using (var g = chapterGroupBox.CreateGraphics())
                {
                    Image wrongEntry = Properties.Resources.exclamation_red;
                    g.DrawImage(wrongEntry, (chapterGroupBox.Width/2) - 18, (chapterGroupBox.Height/2) - 4, 16, 16);
                }
                _startChapterValueIsValid = false;
            }
            else
            {
                using (var g = chapterGroupBox.CreateGraphics())
                {
                    var rec = new Rectangle((chapterGroupBox.Width/2) - 18, (chapterGroupBox.Height/2) - 4, 16, 16);
                    g.FillRectangle(new SolidBrush(chapterGroupBox.BackColor), rec);
                }
                _startChapterValueIsValid = true;
            }
            ChapterBoxesValidator();
        }

        private void HandleSetCurrentChapterTextBoxValidate(object sender, EventArgs e)
        {
            if (!int.TryParse(setCurrentChapterTextBox.Text, out _currentChapter))
            {
                using (var g = chapterGroupBox.CreateGraphics())
                {
                    Image wrongEntry = Properties.Resources.exclamation_red;
                    g.DrawImage(wrongEntry, chapterGroupBox.Width - 22, (chapterGroupBox.Height/2) - 4, 16, 16);
                }
                _currentChapterValueIsValid = false;
            }
            else
            {
                using (var g = chapterGroupBox.CreateGraphics())
                {
                    var rec = new Rectangle(chapterGroupBox.Width - 22, (chapterGroupBox.Height/2) - 4, 16, 16);
                    g.FillRectangle(new SolidBrush(chapterGroupBox.BackColor), rec);
                }
                _currentChapterValueIsValid = true;
            }
            ChapterBoxesValidator();
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            _readItem.StartingChapter = _startingChapter;
            _readItem.CurrentChapter = Convert.ToInt16(setCurrentChapterTextBox.Text);
            _readItem.LastRead = DateTime.Parse(setDateLastReadDateTimePicker.Text);
            _readItem.OnlineUrl = setOnlineURLTextbox.Text;
            _readItem.FinishedReading = finishedReadingCheckBox.Checked;
            _readItem.PersonalNote = personalNoteTextBox.Text;
            _readItem.Title = null;
            
            Communicator.Instance.SetReadItem(_readItem);
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            _readItem = Communicator.Instance.GetReadItem() ?? new ReadItem();
            if (_readItem == null)
            {
                _currentChapter = _startingChapter = 1;
                setCurrentChapterTextBox.Text = setStartingChapterTextBox.Text = @"1";
            }
            else
            {
                setCurrentChapterTextBox.Text = _readItem.CurrentChapter.ToString();
                setStartingChapterTextBox.Text = _readItem.StartingChapter.ToString();
                if (_readItem.LastRead != null) setDateLastReadDateTimePicker.Value = (DateTime) _readItem.LastRead;
                setOnlineURLTextbox.Text = _readItem.OnlineUrl;
                personalNoteTextBox.Text = _readItem.PersonalNote;
                if (_readItem.FinishedReading != null)
                    finishedReadingCheckBox.Checked = (bool) _readItem.FinishedReading;
            }
        }
    }
}