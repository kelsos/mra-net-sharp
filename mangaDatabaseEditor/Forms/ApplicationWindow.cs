using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using mangaDbEditor.Classes;
using mangaDbEditor.Classes.Data;
using mangaDbEditor.Properties;

namespace mangaDbEditor.Forms
{
	public partial class MainForm : Form
	{
	    private string _activeTab;
	    private MangaInfo _mangaInfo;
		public MainForm()
		{
			InitializeComponent();
		}

	    private void GetMangaDataForSpecificManga()
	    {
	        _mangaInfo = DatabaseWrapper.Instance.GetMangaInfoElement(int.Parse(MangaInfoNavigatorCurrent.Text));
	        mangaTitleTextBox.Text = _mangaInfo.Title;

            if (_mangaInfo.PublicationDate != null)
                dateOfPublishDateTimePicker.Value = (DateTime) _mangaInfo.PublicationDate;
	        mangaStatusComboBox.Text = _mangaInfo.PublicationStatus;
	        mangaDescriptionTextBox.Text = _mangaInfo.Description;
            mangaCoverPictureBox.Image = DatabaseWrapper.Instance.GetMangaCover(int.Parse(MangaInfoNavigatorCurrent.Text));
            authorsNameListBox.DataSource = DatabaseWrapper.Instance.GetAuthorsList(int.Parse(MangaInfoNavigatorCurrent.Text));
            genreNameListBox.DataSource = DatabaseWrapper.Instance.GetGenresList(int.Parse(MangaInfoNavigatorCurrent.Text));
            mangaPublisherNameTextBox.Text = DatabaseWrapper.Instance.GetPublisherName(int.Parse(MangaInfoNavigatorCurrent.Text));
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
            MangaInfoNavigatorCurrent.Text = "1";
		    GetMangaDataForSpecificManga();
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
		    //ImageToDatabaseLoader(ImageToByteArray(ImageSizeToStandard(mangaCoverPictureBox.Image)));
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
                    GetMangaDataForSpecificManga();
                    break;
                case "author":
		            break;
                case "publisher":
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
                MangaInfoNavigatorCurrent.Text = (int.Parse(MangaInfoNavigatorCurrent.Text) + 1).ToString();
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
                MangaInfoNavigatorCurrent.Text = (int.Parse(MangaInfoNavigatorCurrent.Text) - 1).ToString();
            }    
        }

        private void HandleMangaInfoNavigatorFirstClick(object sender, EventArgs e)
        {
            MangaInfoNavigatorCurrent.Text = "1";
        }

        private void HandleMangaInfoNavigatorLastClick(object sender, EventArgs e)
        {
            MangaInfoNavigatorCurrent.Text =
                int.Parse(MangaInfoNavigatorTotal.Text.Replace(Resources.MainForm_RefreshMangaData_of_, "")).ToString(CultureInfo.InvariantCulture);
        }

        private void TabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabManga)
            {
                _activeTab = "manga";
            }
            else if (tabControl.SelectedTab == tabAuthor)
            {
                _activeTab = "author";
            }
            else if (tabControl.SelectedTab == tabPublisher)
            {
                _activeTab = "publisher";
            }
        }
	}
}

