using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace oldFormatImporter
{
	public partial class oldMangaDataLoader : Form
	{
		public oldMangaDataLoader()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (openXmlFileDialog.ShowDialog() == DialogResult.OK)
				{
					DataClasses1DataContext mdb = new DataClasses1DataContext();
					loadProgressBar.Value = 0;
					XDocument xmDoc = XDocument.Load(openXmlFileDialog.FileName);

					var xmlData = from data in xmDoc.Descendants("mangaList")
									  select new
									  {
										  Title = (string)data.Element("mangaTitle").Value,
										  Description = (string)data.Element("mangaDescription").Value,
										  Cover = data.Element("mangaCover").Value,
										  FinishedStatus = (string)data.Element("isFinished") ?? "false"

									  };
					loadProgressBar.Maximum = xmlData.Count();
					foreach (var line in xmlData)
					{
						mangaInfo mI = new mangaInfo
						{
							mangaTitle = line.Title,
							mangaDescription = line.Description,
							mangaCover = sqlBinaryImage(imageSizeToStandard(Base64ToImage(line.Cover))),
							mangaStatus = getStatus(line.FinishedStatus)

						};
						mdb.mangaInfos.InsertOnSubmit(mI);
						mdb.SubmitChanges();


						loadProgressBar.Value += 1;
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public Image Base64ToImage(string base64String)
		{
			// Convert Base64 String to byte[]
			byte[] imageBytes = Convert.FromBase64String(base64String);
			MemoryStream ms = new MemoryStream(imageBytes, 0,
			  imageBytes.Length);

			// Convert byte[] to Image
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = Image.FromStream(ms, true);
			return image;
		}

		/// <summary>
		/// Get an Image in whatever Resolution and converts it to the closest to 160w*230h.
		/// </summary>
		/// <param name="sourceImage">The source image.</param>
		/// <returns>The resized Image</returns>
		private static Image imageSizeToStandard(Image sourceImage)
		{
			int sourceWidth = sourceImage.Width;
			int sourceHeight = sourceImage.Height;

			float nPercent = 0;
			float nPercentW = 0;
			float nPercentH = 0;

			nPercentW = ((float)160 / (float)sourceWidth);
			nPercentH = ((float)230 / (float)sourceHeight);

			if (nPercentH < nPercentW)
				nPercent = nPercentH;
			else
				nPercent = nPercentW;

			int destWidth = (int)(sourceWidth * nPercent);
			int destHeight = (int)(sourceHeight * nPercent);

			Bitmap bmp = new Bitmap(destWidth, destHeight);
			Graphics graph = Graphics.FromImage((Image)bmp);
			graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

			graph.DrawImage(sourceImage, 0, 0, destWidth, destHeight);
			graph.Dispose();

			return (Image)bmp;
		}

		public System.Data.Linq.Binary sqlBinaryImage(Image myImage)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				return new System.Data.Linq.Binary(ms.ToArray());
			}
		}

		private void loadUserDataButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (openXmlFileDialog.ShowDialog() == DialogResult.OK)
				{
					DataClasses1DataContext mdb = new DataClasses1DataContext();
					loadProgressBar.Value = 0;
					XDocument xmDoc = XDocument.Load(openXmlFileDialog.FileName);

					var xmlData = from data in xmDoc.Descendants("mangaList")
									  select new
									  {
										  MangaTitle = (string)data.Element("mangaTitle"),
										  StartingChapter = (string)data.Element("startingChapter") ?? "1",
										  CurrentChapter = (string)data.Element("currentChapter") ?? "1" ,
										  DateLastRead = (string)data.Element("dateRead") ?? "01-01-2000",
										  OnLineURL = (string)data.Element("onlineURL") ?? "",
										  Finished = (string)data.Element("isFinished") ?? "false"
									  };
					loadProgressBar.Maximum = xmlData.Count();

					foreach (var line in xmlData)
					{
						mangaReadingList mR = new mangaReadingList()
						{
							mangaID = getMangaID(line.MangaTitle),
							mangaStartingChapter = Convert.ToInt32(line.StartingChapter),
							mangaCurrentChapter = Convert.ToInt32(line.CurrentChapter),
							mangaDateRead = DateTime.Parse(line.DateLastRead),
							mangaURL = line.OnLineURL,
							mangaReadingFinished = getStatusBool(line.Finished)
						};

						mdb.mangaReadingLists.InsertOnSubmit(mR);
						mdb.SubmitChanges();
						loadProgressBar.Value += 1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private string getStatus(string value)
		{
			if (value == "true")
			{
				return "Complete";
			}
			else
			{
				return "Ongoing";
			}
		}
		private bool getStatusBool(string value)
		{
			if (value == "true")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private int getMangaID(string mangaTitle)
		{
			DataClasses1DataContext mdE = new DataClasses1DataContext();
			var mangaID = (from manga in mdE.mangaInfos
								  where manga.mangaTitle == mangaTitle
								  select manga.mangaID).Single();
			return mangaID;
		}
	}
}
