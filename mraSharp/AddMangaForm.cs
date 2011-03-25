using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mraSharp
{
   public partial class AddMangaForm : Form
   {
      public AddMangaForm()
      {
         InitializeComponent();
      }

      private void mangaTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.mangaTableBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.dataStoreDataSet);

      }

      private void AddMangaForm_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'dataStoreDataSet.mangaTable' table. You can move, or remove it, as needed.
         this.mangaTableTableAdapter.Fill(this.dataStoreDataSet.mangaTable);

      }

      private void addToReadingListButton_Click(object sender, EventArgs e)
      {

      }
   }
}
