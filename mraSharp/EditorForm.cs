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

		/// <summary>
		/// Handles the Click event of the mangaListBindingNavigatorSaveItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void mangaListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.mangaListBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dataStoreDataSet);
		}

		/// <summary>
		/// Handles the Load event of the EditorForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void EditorForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataStoreDataSet.mangaList' table. You can move, or remove it, as needed.
			this.mangaListTableAdapter.Fill(this.dataStoreDataSet.mangaList);

		}

		/// <summary>
		/// Image to byte array convertion. The function gets an Image and converts it to a byte array which it returns.
		/// </summary>
		/// <param name="myImage">My image.</param>
		/// <returns></returns>
		private byte[] ImageToByteArray(System.Drawing.Image myImage)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				return ms.ToArray();
			}
		}

		/// <summary>
		/// Handles the Click event of the openAndCommit control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void openAndCommit_Click(object sender, EventArgs e)
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
	}
}
