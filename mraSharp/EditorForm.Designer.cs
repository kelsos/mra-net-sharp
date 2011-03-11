namespace mraSharp
{
	partial class EditorForm
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
			System.Windows.Forms.Label startingChapterLabel;
			System.Windows.Forms.Label currentChapterLabel;
			System.Windows.Forms.Label dateReadLabel;
			System.Windows.Forms.Label onlineURLLabel;
			System.Windows.Forms.Label isFinishedLabel;
			System.Windows.Forms.Label mangaDescriptionLabel;
			System.Windows.Forms.Label mangaNoteLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
			this.dataStoreDataSet = new mraSharp.DataStoreDataSet();
			this.mangaListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mangaListTableAdapter = new mraSharp.DataStoreDataSetTableAdapters.mangaListTableAdapter();
			this.tableAdapterManager = new mraSharp.DataStoreDataSetTableAdapters.TableAdapterManager();
			this.mangaListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mangaListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.mangaTitleTextBox = new System.Windows.Forms.TextBox();
			this.startingChapterTextBox = new System.Windows.Forms.TextBox();
			this.currentChapterTextBox = new System.Windows.Forms.TextBox();
			this.dateReadDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.onlineURLTextBox = new System.Windows.Forms.TextBox();
			this.isFinishedCheckBox = new System.Windows.Forms.CheckBox();
			this.mangaDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.mangaNoteTextBox = new System.Windows.Forms.TextBox();
			this.mangaCoverPictureBox = new System.Windows.Forms.PictureBox();
			this.imageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.openAndCommitButton = new System.Windows.Forms.Button();
			mangaTitleLabel = new System.Windows.Forms.Label();
			startingChapterLabel = new System.Windows.Forms.Label();
			currentChapterLabel = new System.Windows.Forms.Label();
			dateReadLabel = new System.Windows.Forms.Label();
			onlineURLLabel = new System.Windows.Forms.Label();
			isFinishedLabel = new System.Windows.Forms.Label();
			mangaDescriptionLabel = new System.Windows.Forms.Label();
			mangaNoteLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataStoreDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mangaListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mangaListBindingNavigator)).BeginInit();
			this.mangaListBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// mangaTitleLabel
			// 
			mangaTitleLabel.AutoSize = true;
			mangaTitleLabel.Location = new System.Drawing.Point(12, 38);
			mangaTitleLabel.Name = "mangaTitleLabel";
			mangaTitleLabel.Size = new System.Drawing.Size(70, 13);
			mangaTitleLabel.TabIndex = 1;
			mangaTitleLabel.Text = "Manga Title:";
			// 
			// startingChapterLabel
			// 
			startingChapterLabel.AutoSize = true;
			startingChapterLabel.Location = new System.Drawing.Point(12, 66);
			startingChapterLabel.Name = "startingChapterLabel";
			startingChapterLabel.Size = new System.Drawing.Size(95, 13);
			startingChapterLabel.TabIndex = 3;
			startingChapterLabel.Text = "Starting Chapter:";
			// 
			// currentChapterLabel
			// 
			currentChapterLabel.AutoSize = true;
			currentChapterLabel.Location = new System.Drawing.Point(12, 94);
			currentChapterLabel.Name = "currentChapterLabel";
			currentChapterLabel.Size = new System.Drawing.Size(93, 13);
			currentChapterLabel.TabIndex = 5;
			currentChapterLabel.Text = "Current Chapter:";
			// 
			// dateReadLabel
			// 
			dateReadLabel.AutoSize = true;
			dateReadLabel.Location = new System.Drawing.Point(12, 122);
			dateReadLabel.Name = "dateReadLabel";
			dateReadLabel.Size = new System.Drawing.Size(63, 13);
			dateReadLabel.TabIndex = 7;
			dateReadLabel.Text = "Date Read:";
			// 
			// onlineURLLabel
			// 
			onlineURLLabel.AutoSize = true;
			onlineURLLabel.Location = new System.Drawing.Point(12, 150);
			onlineURLLabel.Name = "onlineURLLabel";
			onlineURLLabel.Size = new System.Drawing.Size(68, 13);
			onlineURLLabel.TabIndex = 9;
			onlineURLLabel.Text = "Online URL:";
			// 
			// isFinishedLabel
			// 
			isFinishedLabel.AutoSize = true;
			isFinishedLabel.Location = new System.Drawing.Point(12, 180);
			isFinishedLabel.Name = "isFinishedLabel";
			isFinishedLabel.Size = new System.Drawing.Size(75, 13);
			isFinishedLabel.TabIndex = 11;
			isFinishedLabel.Text = "Is it Finished:";
			// 
			// mangaDescriptionLabel
			// 
			mangaDescriptionLabel.AutoSize = true;
			mangaDescriptionLabel.Location = new System.Drawing.Point(12, 225);
			mangaDescriptionLabel.Name = "mangaDescriptionLabel";
			mangaDescriptionLabel.Size = new System.Drawing.Size(108, 13);
			mangaDescriptionLabel.TabIndex = 13;
			mangaDescriptionLabel.Text = "Manga Description:";
			// 
			// mangaNoteLabel
			// 
			mangaNoteLabel.AutoSize = true;
			mangaNoteLabel.Location = new System.Drawing.Point(12, 334);
			mangaNoteLabel.Name = "mangaNoteLabel";
			mangaNoteLabel.Size = new System.Drawing.Size(79, 13);
			mangaNoteLabel.TabIndex = 15;
			mangaNoteLabel.Text = "Personal Note";
			// 
			// dataStoreDataSet
			// 
			this.dataStoreDataSet.DataSetName = "DataStoreDataSet";
			this.dataStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// mangaListBindingSource
			// 
			this.mangaListBindingSource.DataMember = "mangaList";
			this.mangaListBindingSource.DataSource = this.dataStoreDataSet;
			// 
			// mangaListTableAdapter
			// 
			this.mangaListTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.mangaListTableAdapter = this.mangaListTableAdapter;
			this.tableAdapterManager.newsStorageTableAdapter = null;
			this.tableAdapterManager.rssSubscriptionsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = mraSharp.DataStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// mangaListBindingNavigator
			// 
			this.mangaListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.mangaListBindingNavigator.BindingSource = this.mangaListBindingSource;
			this.mangaListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.mangaListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.mangaListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mangaListBindingNavigatorSaveItem});
			this.mangaListBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.mangaListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.mangaListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.mangaListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.mangaListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.mangaListBindingNavigator.Name = "mangaListBindingNavigator";
			this.mangaListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.mangaListBindingNavigator.Size = new System.Drawing.Size(565, 25);
			this.mangaListBindingNavigator.TabIndex = 0;
			this.mangaListBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// mangaListBindingNavigatorSaveItem
			// 
			this.mangaListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.mangaListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mangaListBindingNavigatorSaveItem.Image")));
			this.mangaListBindingNavigatorSaveItem.Name = "mangaListBindingNavigatorSaveItem";
			this.mangaListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.mangaListBindingNavigatorSaveItem.Text = "Save Data";
			this.mangaListBindingNavigatorSaveItem.Click += new System.EventHandler(this.mangaListBindingNavigatorSaveItem_Click);
			// 
			// mangaTitleTextBox
			// 
			this.mangaTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaListBindingSource, "mangaTitle", true));
			this.mangaTitleTextBox.Location = new System.Drawing.Point(163, 35);
			this.mangaTitleTextBox.Name = "mangaTitleTextBox";
			this.mangaTitleTextBox.Size = new System.Drawing.Size(224, 22);
			this.mangaTitleTextBox.TabIndex = 2;
			// 
			// startingChapterTextBox
			// 
			this.startingChapterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaListBindingSource, "startingChapter", true));
			this.startingChapterTextBox.Location = new System.Drawing.Point(163, 63);
			this.startingChapterTextBox.Name = "startingChapterTextBox";
			this.startingChapterTextBox.Size = new System.Drawing.Size(224, 22);
			this.startingChapterTextBox.TabIndex = 4;
			// 
			// currentChapterTextBox
			// 
			this.currentChapterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaListBindingSource, "currentChapter", true));
			this.currentChapterTextBox.Location = new System.Drawing.Point(163, 91);
			this.currentChapterTextBox.Name = "currentChapterTextBox";
			this.currentChapterTextBox.Size = new System.Drawing.Size(224, 22);
			this.currentChapterTextBox.TabIndex = 6;
			// 
			// dateReadDateTimePicker
			// 
			this.dateReadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mangaListBindingSource, "dateRead", true));
			this.dateReadDateTimePicker.Location = new System.Drawing.Point(163, 119);
			this.dateReadDateTimePicker.Name = "dateReadDateTimePicker";
			this.dateReadDateTimePicker.Size = new System.Drawing.Size(224, 22);
			this.dateReadDateTimePicker.TabIndex = 8;
			// 
			// onlineURLTextBox
			// 
			this.onlineURLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaListBindingSource, "onlineURL", true));
			this.onlineURLTextBox.Location = new System.Drawing.Point(163, 147);
			this.onlineURLTextBox.Name = "onlineURLTextBox";
			this.onlineURLTextBox.Size = new System.Drawing.Size(224, 22);
			this.onlineURLTextBox.TabIndex = 10;
			// 
			// isFinishedCheckBox
			// 
			this.isFinishedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mangaListBindingSource, "isFinished", true));
			this.isFinishedCheckBox.Location = new System.Drawing.Point(163, 175);
			this.isFinishedCheckBox.Name = "isFinishedCheckBox";
			this.isFinishedCheckBox.Size = new System.Drawing.Size(104, 24);
			this.isFinishedCheckBox.TabIndex = 12;
			this.isFinishedCheckBox.Text = "Yes/No";
			this.isFinishedCheckBox.UseVisualStyleBackColor = true;
			// 
			// mangaDescriptionTextBox
			// 
			this.mangaDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaListBindingSource, "mangaDescription", true));
			this.mangaDescriptionTextBox.Location = new System.Drawing.Point(15, 241);
			this.mangaDescriptionTextBox.Multiline = true;
			this.mangaDescriptionTextBox.Name = "mangaDescriptionTextBox";
			this.mangaDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mangaDescriptionTextBox.Size = new System.Drawing.Size(358, 90);
			this.mangaDescriptionTextBox.TabIndex = 14;
			// 
			// mangaNoteTextBox
			// 
			this.mangaNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaListBindingSource, "mangaNote", true));
			this.mangaNoteTextBox.Location = new System.Drawing.Point(12, 350);
			this.mangaNoteTextBox.Multiline = true;
			this.mangaNoteTextBox.Name = "mangaNoteTextBox";
			this.mangaNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mangaNoteTextBox.Size = new System.Drawing.Size(361, 94);
			this.mangaNoteTextBox.TabIndex = 16;
			// 
			// mangaCoverPictureBox
			// 
			this.mangaCoverPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mangaCoverPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mangaListBindingSource, "mangaCover", true));
			this.mangaCoverPictureBox.Location = new System.Drawing.Point(393, 35);
			this.mangaCoverPictureBox.Name = "mangaCoverPictureBox";
			this.mangaCoverPictureBox.Size = new System.Drawing.Size(160, 250);
			this.mangaCoverPictureBox.TabIndex = 18;
			this.mangaCoverPictureBox.TabStop = false;
			// 
			// imageOpenFileDialog
			// 
			this.imageOpenFileDialog.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|All files|*.*";
			// 
			// openAndCommitButton
			// 
			this.openAndCommitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.openAndCommitButton.Location = new System.Drawing.Point(393, 292);
			this.openAndCommitButton.Name = "openAndCommitButton";
			this.openAndCommitButton.Size = new System.Drawing.Size(160, 39);
			this.openAndCommitButton.TabIndex = 19;
			this.openAndCommitButton.Text = "Open and commit Icon";
			this.openAndCommitButton.UseVisualStyleBackColor = true;
			this.openAndCommitButton.Click += new System.EventHandler(this.openAndCommit_Click);
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 456);
			this.Controls.Add(this.openAndCommitButton);
			this.Controls.Add(this.mangaCoverPictureBox);
			this.Controls.Add(mangaNoteLabel);
			this.Controls.Add(this.mangaNoteTextBox);
			this.Controls.Add(mangaDescriptionLabel);
			this.Controls.Add(this.mangaDescriptionTextBox);
			this.Controls.Add(isFinishedLabel);
			this.Controls.Add(this.isFinishedCheckBox);
			this.Controls.Add(onlineURLLabel);
			this.Controls.Add(this.onlineURLTextBox);
			this.Controls.Add(dateReadLabel);
			this.Controls.Add(this.dateReadDateTimePicker);
			this.Controls.Add(currentChapterLabel);
			this.Controls.Add(this.currentChapterTextBox);
			this.Controls.Add(startingChapterLabel);
			this.Controls.Add(this.startingChapterTextBox);
			this.Controls.Add(mangaTitleLabel);
			this.Controls.Add(this.mangaTitleTextBox);
			this.Controls.Add(this.mangaListBindingNavigator);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Editor";
			this.Load += new System.EventHandler(this.EditorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataStoreDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mangaListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mangaListBindingNavigator)).EndInit();
			this.mangaListBindingNavigator.ResumeLayout(false);
			this.mangaListBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataStoreDataSet dataStoreDataSet;
		private System.Windows.Forms.BindingSource mangaListBindingSource;
		private DataStoreDataSetTableAdapters.mangaListTableAdapter mangaListTableAdapter;
		private DataStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator mangaListBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton mangaListBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox mangaTitleTextBox;
		private System.Windows.Forms.TextBox startingChapterTextBox;
		private System.Windows.Forms.TextBox currentChapterTextBox;
		private System.Windows.Forms.DateTimePicker dateReadDateTimePicker;
		private System.Windows.Forms.TextBox onlineURLTextBox;
		private System.Windows.Forms.CheckBox isFinishedCheckBox;
		private System.Windows.Forms.TextBox mangaDescriptionTextBox;
		private System.Windows.Forms.TextBox mangaNoteTextBox;
		private System.Windows.Forms.PictureBox mangaCoverPictureBox;
		private System.Windows.Forms.OpenFileDialog imageOpenFileDialog;
		private System.Windows.Forms.Button openAndCommitButton;
	}
}