using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace mraSharp
{
	public partial class AddMangaForm : Form
	{
		public AddMangaForm()
		{
			InitializeComponent();
		}

		private void AddMangaForm_Load(object sender, EventArgs e)
		{
			populateMangaListComboBox();
		}

		#region Linq to SQL

		private void populateMangaListComboBox()
		{
			using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
			{
				mangaListComboBox.DataSource = from mangas in db.mangaInfos
														 select mangas.mangaTitle;
			}
		}

		private void getMangaCover()
		{
			using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
			{
				if (mangaListComboBox.Text != null)
				{
					var mID = (from current in db.mangaInfos
								  where current.mangaTitle == mangaListComboBox.Text
								  select current.mangaID).SingleOrDefault();

					var image = (from current in db.mangaInfos
									 where current.mangaID == mID
									 select current.mangaCover).Single();
					byte[] imageByte = (byte[])image.ToArray();

					mangaCoverPictureBox.Image = Image.FromStream(new MemoryStream(imageByte));
				}
			}
		}

		private void getMangaDescription()
		{
			using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
			{
				if (mangaListComboBox.Text != null)
				{
					var mID = (from current in db.mangaInfos
								  where current.mangaTitle == mangaListComboBox.Text
								  select current.mangaID).SingleOrDefault();

					var description = (from current in db.mangaInfos
											 where current.mangaID == mID
											 select current.mangaDescription).SingleOrDefault();
               descriptionTextBox.Text = description;
				}
			}
		}

		private void getAuthors()
		{
			using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
			{
				if (mangaListComboBox.Text != null)
				{
					var mID = (from current in db.mangaInfos
								  where current.mangaTitle == mangaListComboBox.Text
								  select current.mangaID).SingleOrDefault();

					var authors = from current in db.mangaAuthors
									  join author in db.authorTables
									  on current.authorID equals author.authorID
									  where current.mangaID == mID
									  select author.authorFullName;
				}
			}
		}

      private void getYearOfFirstPublish()
      {
         using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
         {
            if (mangaListComboBox.Text != null)
            {
               var year = (from entry in db.mangaInfos
                           where entry.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                           select entry.dateOfPublish).SingleOrDefault();
               yearTextBox.Text = year.ToString();
            }
         }
      }

      private void getPublisherName()
      {
         using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
         {
            if (mangaListComboBox.Text != null)
            {
               var pubID = (from entry in db.mangaInfos
                                  where entry.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                                  select entry.publisherID).SingleOrDefault();

               var publisherName = (from entry in db.publisherInfos
                                    where entry.publisherID == (int)pubID
                                    select entry.publisherName).SingleOrDefault();
               publisherTextBox.Text = publisherName;
            }
         }
      }

      private void getMangaStatus()
      {
         using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
         {
            if (mangaListComboBox.Text != null)
            {
               var mStat = (from entry in db.mangaInfos
                            where entry.mangaID == DatabaseOperations.getMangaID(mangaListComboBox.Text)
                            select entry.mangaStatus).SingleOrDefault();
               statusTextBox.Text = mStat;
            }
         }
      }
		#endregion

		private void mangaListComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			getMangaCover();
			mangaTitleTextBox.Text = mangaListComboBox.Text;
         getMangaDescription();
         getYearOfFirstPublish();
         getPublisherName();
         getMangaStatus();
		}

		private void addToReadingListButton_Click(object sender, EventArgs e)
		{
			using (dataLinqSqlDataContext db = new dataLinqSqlDataContext())
			{
				if (mangaListComboBox.Text != null)
				{
					var mID = (from current in db.mangaInfos
								  where current.mangaTitle == mangaListComboBox.Text
								  select current.mangaID).SingleOrDefault();
					mangaReadingList mR = new mangaReadingList
					{
						mangaID = mID,
						mangaNote = "",
						mangaDateRead = DateTime.Now,
						mangaStartingChapter = 1,
						mangaCurrentChapter = 1,
						mangaReadingFinished = false,
						mangaURL = ""
					};
					db.mangaReadingLists.InsertOnSubmit(mR);
					db.SubmitChanges();
				}
			}
		}
	}
}
