using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using mangaDbEditor.Classes;
using mangaDbEditor.Classes.Data;
using mangaDbEditor.Classes.Utilities;
using mangaDbEditor.Properties;

namespace mangaDbEditor.Forms
{
	public partial class MainForm : Form
	{
	    private string _activeTab;
	    private MangaInfo _mangaInfo;
	    private AuthorInfo _authorInfo;
	    private PublisherInfo _publisherInfo;
		public MainForm()
		{
			InitializeComponent();
		}

	    private void GetMangaDataForSpecificManga(int mangaId)
	    {
            _mangaInfo = DatabaseWrapper.Instance.GetMangaInfoElement(mangaId);
	        mangaTitleTextBox.Text = _mangaInfo.Title;

            if (_mangaInfo.PublicationDate != null)
                dateOfPublishDateTimePicker.Value = (DateTime) _mangaInfo.PublicationDate;
	        mangaStatusComboBox.Text = _mangaInfo.PublicationStatus;
	        mangaDescriptionTextBox.Text = _mangaInfo.Description;
            mangaCoverPictureBox.Image = DatabaseWrapper.Instance.GetMangaCover(mangaId);
            authorsNameListBox.DataSource = DatabaseWrapper.Instance.GetAuthorsList(mangaId);
            genreNameListBox.DataSource = DatabaseWrapper.Instance.GetGenresList(mangaId);
            mangaPublisherNameTextBox.Text = DatabaseWrapper.Instance.GetPublisherName(mangaId);
	        authorsComboBox.DataSource = DatabaseWrapper.Instance.GetNonSelectedAuthors(mangaId);
	        genreNameComboBox.DataSource = DatabaseWrapper.Instance.GetNonSelectedGenresList(mangaId);
	    }

        private void GetAuthorDataForSpecificAuthor(int authorId)
        {
            _authorInfo = DatabaseWrapper.Instance.GetAuthorInfoElement(authorId);
            authorFullNameTextBox.Text = _authorInfo.Name;
            authorCountryOfOriginTextBox.Text = _authorInfo.Country;
            authorWebsiteTextBox.Text = _authorInfo.Website;
            if (_authorInfo.Birthday != null) authorDateOfBirthDateTimePicker.Value = (DateTime) _authorInfo.Birthday;
        }

        private void GetPublisherDataForSpecificPublisher(int publisherId)
        {
            _publisherInfo = DatabaseWrapper.Instance.GetPublisherInfoElement(publisherId);
            publisherNameTextBox.Text = _publisherInfo.Name;
            publisherCountryTextBox.Text = _publisherInfo.Country;
            publisherNoteTextBox.Text = _publisherInfo.Note;
            publisherWebsiteTextBox.Text = _publisherInfo.Website;
        }

		private void HandleNewEntry()
		{
			if (MangaInfoNavigatorCurrent.Text != null && MangaInfoNavigatorCurrent.Text != Resources.MainForm_CheckIfEntryExists__0)
			{
				mangaAuthorGroupBox.Enabled = true;
				publisherGroupBox.Enabled = true;
				mangaGenresGroupBox.Enabled = true;
				buttonImageLoad.Enabled = true;
			}
			else
			{
				mangaAuthorGroupBox.Enabled = false;
				publisherGroupBox.Enabled = false;
				mangaGenresGroupBox.Enabled = false;
				buttonImageLoad.Enabled = false;
			}
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
		    _activeTab = "manga";
            MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetMangaInfoNumberOfElements();
            MangaInfoNavigatorCurrent.Text = Resources.Decimal_One_String;
		    GetMangaDataForSpecificManga(int.Parse(MangaInfoNavigatorCurrent.Text));
			HandleNewEntry();
		}

		private void GenresToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (var gF = new GenresForm())
			{
				gF.ShowDialog();
			}
		}

		private void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			using (var ab = new AboutForm())
			{
				ab.ShowDialog();
			}
		}

		private void ButtonImageLoadClick(object sender, EventArgs e)
		{
		    if (openImageFileDialog.ShowDialog() != DialogResult.OK) return;
		    mangaCoverPictureBox.Image = Image.FromFile(openImageFileDialog.FileName);
            DatabaseWrapper.Instance.SetMangaCover(int.Parse(MangaInfoNavigatorCurrent.Text), ImageUtil.Resize(mangaCoverPictureBox.Image));
		}

		private void AddGenreButtonClick(object sender, EventArgs e)
		{
		}

		private void RemoveGenreButtonClick(object sender, EventArgs e)
		{
		}

		private void AddAuthorButtonClick(object sender, EventArgs e)
		{
		}

		private void RemoveAuthorButtonClick(object sender, EventArgs e)
		{
		}

		private void AddPublisherButtonClick(object sender, EventArgs e)
		{
		}

		private void RemovePublisherButtonClick(object sender, EventArgs e)
		{
		}

		private void MangaInfoNavigatorCurrentTextChanged(object sender, EventArgs e)
		{
		    switch (_activeTab)
		    {
                case "manga":
                    MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetMangaInfoNumberOfElements();
                    GetMangaDataForSpecificManga(int.Parse(MangaInfoNavigatorCurrent.Text));
                    break;
                case "author":
                    MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetAuthorInfoNumberOfElements();
		            GetAuthorDataForSpecificAuthor(int.Parse(MangaInfoNavigatorCurrent.Text));
                    break;
                case "publisher":
                    MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetPublisherInfoNumberOfElements();
		            GetPublisherDataForSpecificPublisher(int.Parse(MangaInfoNavigatorCurrent.Text));
                    break;
		    }
		    
		}

		private void ExportDatabaseToolStripMenuItemClick(object sender, EventArgs e)
		{
            //TODO: Not null & more checks.
            if (ExportDatabaseSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
               // DatabaseInfoExporter(ExportDatabaseSaveFileDialog.FileName);
            }
		}

		private void ImportDatabaseToolStripMenuItemClick(object sender, EventArgs e)
		{
            if (importDatabaseOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
              //  DatabaseInfoImporter(importDatabaseOpenFileDialog.FileName);
            }
		}

        private void HandleMangaInfoNavigatorNextClick(object sender, EventArgs e)
        {
            if(int.Parse(MangaInfoNavigatorCurrent.Text)<int.Parse(MangaInfoNavigatorTotal.Text.Replace(Resources.MainForm_RefreshMangaData_of_,"")))
            {
                MangaInfoNavigatorCurrent.Text = (int.Parse(MangaInfoNavigatorCurrent.Text) + 1).ToString(CultureInfo.InvariantCulture);
            }      
        }

        private void HandleMangaInfoNavigatorNewClick(object sender, EventArgs e)
        {
            //When the user tries to insert a new entry in the database the following statements select the first value "Ongoing" as default.
            mangaStatusComboBox.SelectedIndex = -1;
            mangaStatusComboBox.SelectedIndex = 0;
        }

        private void HandleMangaInfoNavigatorPreviousClick(object sender, EventArgs e)
        {
            if (int.Parse(MangaInfoNavigatorCurrent.Text) > 1)
            {
                MangaInfoNavigatorCurrent.Text = (int.Parse(MangaInfoNavigatorCurrent.Text) - 1).ToString(CultureInfo.InvariantCulture);
            }    
        }

        private void HandleMangaInfoNavigatorFirstClick(object sender, EventArgs e)
        {
            MangaInfoNavigatorCurrent.Text = Resources.Decimal_One_String;
        }

        private void HandleMangaInfoNavigatorLastClick(object sender, EventArgs e)
        {
            MangaInfoNavigatorCurrent.Text =
                int.Parse(MangaInfoNavigatorTotal.Text.Replace(Resources.MainForm_RefreshMangaData_of_, "")).ToString(CultureInfo.InvariantCulture);
        }

        private void HandleTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabManga)
            {
                _activeTab = "manga";
                MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetMangaInfoNumberOfElements();
                MangaInfoNavigatorCurrent.Text = DatabaseWrapper.Instance.GetMangaInfoNumberOfElements()> 0 ? "1" : Resources.MainForm_CheckIfEntryExists__0;
                GetMangaDataForSpecificManga(int.Parse(MangaInfoNavigatorCurrent.Text));
            }
            else if (tabControl.SelectedTab == tabAuthor)
            {
                _activeTab = "author";
                MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetAuthorInfoNumberOfElements();
                MangaInfoNavigatorCurrent.Text = DatabaseWrapper.Instance.GetAuthorInfoNumberOfElements()>0 ? "1" : Resources.MainForm_CheckIfEntryExists__0;
                GetAuthorDataForSpecificAuthor(int.Parse(MangaInfoNavigatorCurrent.Text));
            }
            else if (tabControl.SelectedTab == tabPublisher)
            {
                _activeTab = "publisher";
                MangaInfoNavigatorTotal.Text = Resources.MainForm_RefreshMangaData_of_ + DatabaseWrapper.Instance.GetPublisherInfoNumberOfElements();
                MangaInfoNavigatorCurrent.Text = DatabaseWrapper.Instance.GetPublisherInfoNumberOfElements() > 0 ? "1" : Resources.MainForm_CheckIfEntryExists__0;
                GetPublisherDataForSpecificPublisher(int.Parse(MangaInfoNavigatorCurrent.Text));
            }
        }

	}
}

