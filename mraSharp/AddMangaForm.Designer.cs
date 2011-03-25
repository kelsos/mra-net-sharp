namespace mraSharp
{
   partial class AddMangaForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.Label mangaTitleLabel;
         System.Windows.Forms.Label mangaDecriptionLabel;
         System.Windows.Forms.Label mangaAuthorLabel;
         System.Windows.Forms.Label mangaDateOfPublishLabel;
         System.Windows.Forms.Label mangaStatusLabel;
         this.dataStoreDataSet = new mraSharp.DataStoreDataSet();
         this.mangaTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.mangaTableTableAdapter = new mraSharp.DataStoreDataSetTableAdapters.mangaTableTableAdapter();
         this.tableAdapterManager = new mraSharp.DataStoreDataSetTableAdapters.TableAdapterManager();
         this.mangaTitleComboBox = new System.Windows.Forms.ComboBox();
         this.mangaDecriptionTextBox = new System.Windows.Forms.TextBox();
         this.mangaAuthorTextBox = new System.Windows.Forms.TextBox();
         this.mangaDateOfPublishDateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.mangaStatusTextBox = new System.Windows.Forms.TextBox();
         this.mangaCoverImagePictureBox = new System.Windows.Forms.PictureBox();
         this.addToReadingListButton = new System.Windows.Forms.Button();
         mangaTitleLabel = new System.Windows.Forms.Label();
         mangaDecriptionLabel = new System.Windows.Forms.Label();
         mangaAuthorLabel = new System.Windows.Forms.Label();
         mangaDateOfPublishLabel = new System.Windows.Forms.Label();
         mangaStatusLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataStoreDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaTableBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaCoverImagePictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // dataStoreDataSet
         // 
         this.dataStoreDataSet.DataSetName = "DataStoreDataSet";
         this.dataStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // mangaTableBindingSource
         // 
         this.mangaTableBindingSource.DataMember = "mangaTable";
         this.mangaTableBindingSource.DataSource = this.dataStoreDataSet;
         // 
         // mangaTableTableAdapter
         // 
         this.mangaTableTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.mangaListTableAdapter = null;
         this.tableAdapterManager.mangaReadingListTableAdapter = null;
         this.tableAdapterManager.mangaTableTableAdapter = this.mangaTableTableAdapter;
         this.tableAdapterManager.newsStorageTableAdapter = null;
         this.tableAdapterManager.rssSubscriptionsTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = mraSharp.DataStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // mangaTitleLabel
         // 
         mangaTitleLabel.AutoSize = true;
         mangaTitleLabel.Location = new System.Drawing.Point(9, 9);
         mangaTitleLabel.Name = "mangaTitleLabel";
         mangaTitleLabel.Size = new System.Drawing.Size(66, 13);
         mangaTitleLabel.TabIndex = 0;
         mangaTitleLabel.Text = "Manga Title:";
         // 
         // mangaTitleComboBox
         // 
         this.mangaTitleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaTableBindingSource, "mangaTitle", true));
         this.mangaTitleComboBox.FormattingEnabled = true;
         this.mangaTitleComboBox.Location = new System.Drawing.Point(12, 25);
         this.mangaTitleComboBox.Name = "mangaTitleComboBox";
         this.mangaTitleComboBox.Size = new System.Drawing.Size(412, 21);
         this.mangaTitleComboBox.TabIndex = 1;
         // 
         // mangaDecriptionLabel
         // 
         mangaDecriptionLabel.AutoSize = true;
         mangaDecriptionLabel.Location = new System.Drawing.Point(9, 49);
         mangaDecriptionLabel.Name = "mangaDecriptionLabel";
         mangaDecriptionLabel.Size = new System.Drawing.Size(58, 13);
         mangaDecriptionLabel.TabIndex = 2;
         mangaDecriptionLabel.Text = "Decription:";
         // 
         // mangaDecriptionTextBox
         // 
         this.mangaDecriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaTableBindingSource, "mangaDecription", true));
         this.mangaDecriptionTextBox.Location = new System.Drawing.Point(12, 65);
         this.mangaDecriptionTextBox.Multiline = true;
         this.mangaDecriptionTextBox.Name = "mangaDecriptionTextBox";
         this.mangaDecriptionTextBox.ReadOnly = true;
         this.mangaDecriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.mangaDecriptionTextBox.Size = new System.Drawing.Size(412, 108);
         this.mangaDecriptionTextBox.TabIndex = 3;
         // 
         // mangaAuthorLabel
         // 
         mangaAuthorLabel.AutoSize = true;
         mangaAuthorLabel.Location = new System.Drawing.Point(9, 176);
         mangaAuthorLabel.Name = "mangaAuthorLabel";
         mangaAuthorLabel.Size = new System.Drawing.Size(41, 13);
         mangaAuthorLabel.TabIndex = 4;
         mangaAuthorLabel.Text = "Author:";
         // 
         // mangaAuthorTextBox
         // 
         this.mangaAuthorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaTableBindingSource, "mangaAuthor", true));
         this.mangaAuthorTextBox.Location = new System.Drawing.Point(12, 192);
         this.mangaAuthorTextBox.Name = "mangaAuthorTextBox";
         this.mangaAuthorTextBox.ReadOnly = true;
         this.mangaAuthorTextBox.Size = new System.Drawing.Size(412, 20);
         this.mangaAuthorTextBox.TabIndex = 5;
         // 
         // mangaDateOfPublishLabel
         // 
         mangaDateOfPublishLabel.AutoSize = true;
         mangaDateOfPublishLabel.Location = new System.Drawing.Point(9, 215);
         mangaDateOfPublishLabel.Name = "mangaDateOfPublishLabel";
         mangaDateOfPublishLabel.Size = new System.Drawing.Size(84, 13);
         mangaDateOfPublishLabel.TabIndex = 6;
         mangaDateOfPublishLabel.Text = "Date Of Publish:";
         // 
         // mangaDateOfPublishDateTimePicker
         // 
         this.mangaDateOfPublishDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mangaTableBindingSource, "mangaDateOfPublish", true));
         this.mangaDateOfPublishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.mangaDateOfPublishDateTimePicker.Location = new System.Drawing.Point(12, 231);
         this.mangaDateOfPublishDateTimePicker.Name = "mangaDateOfPublishDateTimePicker";
         this.mangaDateOfPublishDateTimePicker.Size = new System.Drawing.Size(412, 20);
         this.mangaDateOfPublishDateTimePicker.TabIndex = 7;
         // 
         // mangaStatusLabel
         // 
         mangaStatusLabel.AutoSize = true;
         mangaStatusLabel.Location = new System.Drawing.Point(12, 260);
         mangaStatusLabel.Name = "mangaStatusLabel";
         mangaStatusLabel.Size = new System.Drawing.Size(40, 13);
         mangaStatusLabel.TabIndex = 8;
         mangaStatusLabel.Text = "Status:";
         // 
         // mangaStatusTextBox
         // 
         this.mangaStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaTableBindingSource, "mangaStatus", true));
         this.mangaStatusTextBox.Location = new System.Drawing.Point(58, 257);
         this.mangaStatusTextBox.Name = "mangaStatusTextBox";
         this.mangaStatusTextBox.ReadOnly = true;
         this.mangaStatusTextBox.Size = new System.Drawing.Size(240, 20);
         this.mangaStatusTextBox.TabIndex = 9;
         // 
         // mangaCoverImagePictureBox
         // 
         this.mangaCoverImagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mangaTableBindingSource, "mangaCoverImage", true));
         this.mangaCoverImagePictureBox.Location = new System.Drawing.Point(430, 25);
         this.mangaCoverImagePictureBox.Name = "mangaCoverImagePictureBox";
         this.mangaCoverImagePictureBox.Size = new System.Drawing.Size(160, 230);
         this.mangaCoverImagePictureBox.TabIndex = 11;
         this.mangaCoverImagePictureBox.TabStop = false;
         // 
         // addToReadingListButton
         // 
         this.addToReadingListButton.Location = new System.Drawing.Point(304, 257);
         this.addToReadingListButton.Name = "addToReadingListButton";
         this.addToReadingListButton.Size = new System.Drawing.Size(120, 23);
         this.addToReadingListButton.TabIndex = 12;
         this.addToReadingListButton.Text = "Add to reading List";
         this.addToReadingListButton.UseVisualStyleBackColor = true;
         this.addToReadingListButton.Click += new System.EventHandler(this.addToReadingListButton_Click);
         // 
         // AddMangaForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(599, 289);
         this.Controls.Add(this.addToReadingListButton);
         this.Controls.Add(this.mangaCoverImagePictureBox);
         this.Controls.Add(mangaStatusLabel);
         this.Controls.Add(this.mangaStatusTextBox);
         this.Controls.Add(mangaDateOfPublishLabel);
         this.Controls.Add(this.mangaDateOfPublishDateTimePicker);
         this.Controls.Add(mangaAuthorLabel);
         this.Controls.Add(this.mangaAuthorTextBox);
         this.Controls.Add(mangaDecriptionLabel);
         this.Controls.Add(this.mangaDecriptionTextBox);
         this.Controls.Add(mangaTitleLabel);
         this.Controls.Add(this.mangaTitleComboBox);
         this.Name = "AddMangaForm";
         this.Text = "Add Manga";
         this.Load += new System.EventHandler(this.AddMangaForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataStoreDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaTableBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaCoverImagePictureBox)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DataStoreDataSet dataStoreDataSet;
      private System.Windows.Forms.BindingSource mangaTableBindingSource;
      private DataStoreDataSetTableAdapters.mangaTableTableAdapter mangaTableTableAdapter;
      private DataStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.ComboBox mangaTitleComboBox;
      private System.Windows.Forms.TextBox mangaDecriptionTextBox;
      private System.Windows.Forms.TextBox mangaAuthorTextBox;
      private System.Windows.Forms.DateTimePicker mangaDateOfPublishDateTimePicker;
      private System.Windows.Forms.TextBox mangaStatusTextBox;
      private System.Windows.Forms.PictureBox mangaCoverImagePictureBox;
      private System.Windows.Forms.Button addToReadingListButton;
   }
}