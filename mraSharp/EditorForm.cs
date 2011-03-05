using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace mraSharp
{
	public partial class EditorForm : Form
	{
		public EditorForm()
		{
			InitializeComponent();
		}

		private void mangaListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.mangaListBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dataStoreDataSet);

		}

		private void EditorForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataStoreDataSet.mangaList' table. You can move, or remove it, as needed.
			this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (imageOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (!String.IsNullOrEmpty(mangaTitleTextBox.Text))
				{
					mangaCoverPictureBox.Image = Image.FromFile(imageOpenFileDialog.FileName);
					byte[] imageByteArray = ImageToByteArray(mangaCoverPictureBox.Image);
					DatabaseOperations.imageToDatabaseLoader(imageByteArray, mangaTitleTextBox.Text);
				}
				else
				{
					MessageBox.Show("There is no entry to upload image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private byte[] ImageToByteArray(System.Drawing.Image myImage)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				return ms.ToArray();
			}
		}
	}
}
