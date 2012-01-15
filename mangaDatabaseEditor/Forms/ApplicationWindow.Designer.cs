namespace mangaDbEditor.Forms
{
	partial class MainForm
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
            System.Windows.Forms.Label mangaTitleLabel;
            System.Windows.Forms.Label authorFullNameLabel1;
            System.Windows.Forms.Label publisherNameLabel1;
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabManga = new System.Windows.Forms.TabPage();
            this.databaseEditorStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tableLoadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.currentTableLoadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.dateOfPublicationGroupBox = new System.Windows.Forms.GroupBox();
            this.dateOfPublishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.mangaDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.mangaInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.mangaTitleTextBox = new System.Windows.Forms.TextBox();
            this.publisherGroupBox = new System.Windows.Forms.GroupBox();
            this.removePublisherButton = new System.Windows.Forms.Button();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.mangaPublisherNameTextBox = new System.Windows.Forms.TextBox();
            this.mangaAuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.removeAuthorButton = new System.Windows.Forms.Button();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.authorsComboBox = new System.Windows.Forms.ComboBox();
            this.authorsNameListBox = new System.Windows.Forms.ListBox();
            this.mangaGenresGroupBox = new System.Windows.Forms.GroupBox();
            this.genreNameListBox = new System.Windows.Forms.ListBox();
            this.removeGenreButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.genreNameComboBox = new System.Windows.Forms.ComboBox();
            this.publicationStatusGroupbox = new System.Windows.Forms.GroupBox();
            this.mangaStatusComboBox = new System.Windows.Forms.ComboBox();
            this.searchMangaGroupBox = new System.Windows.Forms.GroupBox();
            this.browseAllMangaEntriesbutton = new System.Windows.Forms.Button();
            this.searchMangaButton = new System.Windows.Forms.Button();
            this.searchMangaTextBox = new System.Windows.Forms.TextBox();
            this.buttonImageLoad = new System.Windows.Forms.Button();
            this.mangaCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.tabAuthor = new System.Windows.Forms.TabPage();
            this.searchByAuthorNameGroupBox = new System.Windows.Forms.GroupBox();
            this.browseAllAuthorEntriesButton = new System.Windows.Forms.Button();
            this.authorSearchButton = new System.Windows.Forms.Button();
            this.authorSearchTextBox = new System.Windows.Forms.TextBox();
            this.authorWebsiteGroupBox = new System.Windows.Forms.GroupBox();
            this.authorWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.authorDateOFBirthGroupBox = new System.Windows.Forms.GroupBox();
            this.authorDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.authorCountryGroupBox = new System.Windows.Forms.GroupBox();
            this.authorCountryOfOriginTextBox = new System.Windows.Forms.TextBox();
            this.authorInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.authorFullNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPublisher = new System.Windows.Forms.TabPage();
            this.publisherNoteGroupBox = new System.Windows.Forms.GroupBox();
            this.publisherNoteTextBox = new System.Windows.Forms.TextBox();
            this.publisherWebsiteGroupBox = new System.Windows.Forms.GroupBox();
            this.publisherWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.publisherCountryGroupBox = new System.Windows.Forms.GroupBox();
            this.publisherCountryTextBox = new System.Windows.Forms.TextBox();
            this.searchPublisherGroupBox = new System.Windows.Forms.GroupBox();
            this.browseAllPublisherEntriesButton = new System.Windows.Forms.Button();
            this.searchPublisherButton = new System.Windows.Forms.Button();
            this.searchPublisherTextBox = new System.Windows.Forms.TextBox();
            this.publisherInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.publisherNameTextBox = new System.Windows.Forms.TextBox();
            this.MangaInfoNavigator = new System.Windows.Forms.ToolStrip();
            this.MangaInfoNavigatorFirst = new System.Windows.Forms.ToolStripButton();
            this.MangaInfoNavigatorPrevious = new System.Windows.Forms.ToolStripButton();
            this.MangaInfoNavigatorSepOne = new System.Windows.Forms.ToolStripSeparator();
            this.MangaInfoNavigatorCurrent = new System.Windows.Forms.ToolStripTextBox();
            this.MangaInfoNavigatorTotal = new System.Windows.Forms.ToolStripLabel();
            this.MangaInfoNavigatorSepTwo = new System.Windows.Forms.ToolStripSeparator();
            this.MangaInfoNavigatorNext = new System.Windows.Forms.ToolStripButton();
            this.MangaInfoNavigatorLast = new System.Windows.Forms.ToolStripButton();
            this.MangaInfoNavigatorSepThree = new System.Windows.Forms.ToolStripSeparator();
            this.MangaInfoNavigatorNew = new System.Windows.Forms.ToolStripButton();
            this.MangaInfoNavigatorDelete = new System.Windows.Forms.ToolStripButton();
            this.MangaInfoNavigatorSave = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importDatabaseOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExportDatabaseSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            mangaTitleLabel = new System.Windows.Forms.Label();
            authorFullNameLabel1 = new System.Windows.Forms.Label();
            publisherNameLabel1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabManga.SuspendLayout();
            this.databaseEditorStatusStrip.SuspendLayout();
            this.dateOfPublicationGroupBox.SuspendLayout();
            this.descriptionGroupBox.SuspendLayout();
            this.mangaInfoGroupBox.SuspendLayout();
            this.publisherGroupBox.SuspendLayout();
            this.mangaAuthorGroupBox.SuspendLayout();
            this.mangaGenresGroupBox.SuspendLayout();
            this.publicationStatusGroupbox.SuspendLayout();
            this.searchMangaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).BeginInit();
            this.tabAuthor.SuspendLayout();
            this.searchByAuthorNameGroupBox.SuspendLayout();
            this.authorWebsiteGroupBox.SuspendLayout();
            this.authorDateOFBirthGroupBox.SuspendLayout();
            this.authorCountryGroupBox.SuspendLayout();
            this.authorInfoGroupBox.SuspendLayout();
            this.tabPublisher.SuspendLayout();
            this.publisherNoteGroupBox.SuspendLayout();
            this.publisherWebsiteGroupBox.SuspendLayout();
            this.publisherCountryGroupBox.SuspendLayout();
            this.searchPublisherGroupBox.SuspendLayout();
            this.publisherInfoGroupBox.SuspendLayout();
            this.MangaInfoNavigator.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mangaTitleLabel
            // 
            mangaTitleLabel.AutoSize = true;
            mangaTitleLabel.Location = new System.Drawing.Point(6, 18);
            mangaTitleLabel.Name = "mangaTitleLabel";
            mangaTitleLabel.Size = new System.Drawing.Size(31, 13);
            mangaTitleLabel.TabIndex = 3;
            mangaTitleLabel.Text = "Title:";
            // 
            // authorFullNameLabel1
            // 
            authorFullNameLabel1.AutoSize = true;
            authorFullNameLabel1.Location = new System.Drawing.Point(6, 18);
            authorFullNameLabel1.Name = "authorFullNameLabel1";
            authorFullNameLabel1.Size = new System.Drawing.Size(61, 13);
            authorFullNameLabel1.TabIndex = 2;
            authorFullNameLabel1.Text = "Full Name:";
            // 
            // publisherNameLabel1
            // 
            publisherNameLabel1.AutoSize = true;
            publisherNameLabel1.Location = new System.Drawing.Point(6, 21);
            publisherNameLabel1.Name = "publisherNameLabel1";
            publisherNameLabel1.Size = new System.Drawing.Size(39, 13);
            publisherNameLabel1.TabIndex = 2;
            publisherNameLabel1.Text = "Name:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabManga);
            this.tabControl.Controls.Add(this.tabAuthor);
            this.tabControl.Controls.Add(this.tabPublisher);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 640);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
            // 
            // tabManga
            // 
            this.tabManga.AutoScroll = true;
            this.tabManga.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabManga.Controls.Add(this.databaseEditorStatusStrip);
            this.tabManga.Controls.Add(this.dateOfPublicationGroupBox);
            this.tabManga.Controls.Add(this.descriptionGroupBox);
            this.tabManga.Controls.Add(this.mangaInfoGroupBox);
            this.tabManga.Controls.Add(this.publisherGroupBox);
            this.tabManga.Controls.Add(this.mangaAuthorGroupBox);
            this.tabManga.Controls.Add(this.mangaGenresGroupBox);
            this.tabManga.Controls.Add(this.publicationStatusGroupbox);
            this.tabManga.Controls.Add(this.searchMangaGroupBox);
            this.tabManga.Controls.Add(this.buttonImageLoad);
            this.tabManga.Controls.Add(this.mangaCoverPictureBox);
            this.tabManga.Location = new System.Drawing.Point(4, 22);
            this.tabManga.Name = "tabManga";
            this.tabManga.Padding = new System.Windows.Forms.Padding(3);
            this.tabManga.Size = new System.Drawing.Size(476, 614);
            this.tabManga.TabIndex = 0;
            this.tabManga.Text = "Manga";
            // 
            // databaseEditorStatusStrip
            // 
            this.databaseEditorStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableLoadProgress,
            this.currentTableLoadProgress});
            this.databaseEditorStatusStrip.Location = new System.Drawing.Point(3, 589);
            this.databaseEditorStatusStrip.Name = "databaseEditorStatusStrip";
            this.databaseEditorStatusStrip.Size = new System.Drawing.Size(470, 22);
            this.databaseEditorStatusStrip.TabIndex = 34;
            this.databaseEditorStatusStrip.Text = "statusStrip1";
            // 
            // tableLoadProgress
            // 
            this.tableLoadProgress.Name = "tableLoadProgress";
            this.tableLoadProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // currentTableLoadProgress
            // 
            this.currentTableLoadProgress.Name = "currentTableLoadProgress";
            this.currentTableLoadProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // dateOfPublicationGroupBox
            // 
            this.dateOfPublicationGroupBox.Controls.Add(this.dateOfPublishDateTimePicker);
            this.dateOfPublicationGroupBox.Location = new System.Drawing.Point(8, 525);
            this.dateOfPublicationGroupBox.Name = "dateOfPublicationGroupBox";
            this.dateOfPublicationGroupBox.Size = new System.Drawing.Size(294, 56);
            this.dateOfPublicationGroupBox.TabIndex = 33;
            this.dateOfPublicationGroupBox.TabStop = false;
            this.dateOfPublicationGroupBox.Text = "Date Of Publication";
            // 
            // dateOfPublishDateTimePicker
            // 
            this.dateOfPublishDateTimePicker.CustomFormat = "yyyy";
            this.dateOfPublishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfPublishDateTimePicker.Location = new System.Drawing.Point(6, 21);
            this.dateOfPublishDateTimePicker.Name = "dateOfPublishDateTimePicker";
            this.dateOfPublishDateTimePicker.Size = new System.Drawing.Size(270, 22);
            this.dateOfPublishDateTimePicker.TabIndex = 18;
            // 
            // descriptionGroupBox
            // 
            this.descriptionGroupBox.Controls.Add(this.mangaDescriptionTextBox);
            this.descriptionGroupBox.Location = new System.Drawing.Point(8, 324);
            this.descriptionGroupBox.Name = "descriptionGroupBox";
            this.descriptionGroupBox.Size = new System.Drawing.Size(294, 195);
            this.descriptionGroupBox.TabIndex = 32;
            this.descriptionGroupBox.TabStop = false;
            this.descriptionGroupBox.Text = "Description";
            // 
            // mangaDescriptionTextBox
            // 
            this.mangaDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mangaDescriptionTextBox.Location = new System.Drawing.Point(3, 18);
            this.mangaDescriptionTextBox.Multiline = true;
            this.mangaDescriptionTextBox.Name = "mangaDescriptionTextBox";
            this.mangaDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mangaDescriptionTextBox.Size = new System.Drawing.Size(288, 174);
            this.mangaDescriptionTextBox.TabIndex = 16;
            // 
            // mangaInfoGroupBox
            // 
            this.mangaInfoGroupBox.Controls.Add(this.mangaTitleTextBox);
            this.mangaInfoGroupBox.Controls.Add(mangaTitleLabel);
            this.mangaInfoGroupBox.Location = new System.Drawing.Point(8, 6);
            this.mangaInfoGroupBox.Name = "mangaInfoGroupBox";
            this.mangaInfoGroupBox.Size = new System.Drawing.Size(294, 65);
            this.mangaInfoGroupBox.TabIndex = 31;
            this.mangaInfoGroupBox.TabStop = false;
            this.mangaInfoGroupBox.Text = "Manga Info";
            // 
            // mangaTitleTextBox
            // 
            this.mangaTitleTextBox.Location = new System.Drawing.Point(6, 34);
            this.mangaTitleTextBox.Name = "mangaTitleTextBox";
            this.mangaTitleTextBox.Size = new System.Drawing.Size(268, 22);
            this.mangaTitleTextBox.TabIndex = 4;
            // 
            // publisherGroupBox
            // 
            this.publisherGroupBox.Controls.Add(this.removePublisherButton);
            this.publisherGroupBox.Controls.Add(this.addPublisherButton);
            this.publisherGroupBox.Controls.Add(this.publisherComboBox);
            this.publisherGroupBox.Controls.Add(this.mangaPublisherNameTextBox);
            this.publisherGroupBox.Enabled = false;
            this.publisherGroupBox.Location = new System.Drawing.Point(8, 234);
            this.publisherGroupBox.Name = "publisherGroupBox";
            this.publisherGroupBox.Size = new System.Drawing.Size(294, 84);
            this.publisherGroupBox.TabIndex = 30;
            this.publisherGroupBox.TabStop = false;
            this.publisherGroupBox.Text = "Publisher";
            // 
            // removePublisherButton
            // 
            this.removePublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removePublisherButton.Image = global::mangaDbEditor.Properties.Resources.minus;
            this.removePublisherButton.Location = new System.Drawing.Point(253, 49);
            this.removePublisherButton.Name = "removePublisherButton";
            this.removePublisherButton.Size = new System.Drawing.Size(21, 21);
            this.removePublisherButton.TabIndex = 30;
            this.removePublisherButton.UseVisualStyleBackColor = true;
            this.removePublisherButton.Click += new System.EventHandler(this.RemovePublisherButtonClick);
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPublisherButton.Image = global::mangaDbEditor.Properties.Resources.plus;
            this.addPublisherButton.Location = new System.Drawing.Point(226, 49);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(21, 21);
            this.addPublisherButton.TabIndex = 30;
            this.addPublisherButton.UseVisualStyleBackColor = true;
            this.addPublisherButton.Click += new System.EventHandler(this.AddPublisherButtonClick);
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(6, 49);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(214, 21);
            this.publisherComboBox.TabIndex = 31;
            // 
            // mangaPublisherNameTextBox
            // 
            this.mangaPublisherNameTextBox.Location = new System.Drawing.Point(6, 21);
            this.mangaPublisherNameTextBox.Name = "mangaPublisherNameTextBox";
            this.mangaPublisherNameTextBox.Size = new System.Drawing.Size(268, 22);
            this.mangaPublisherNameTextBox.TabIndex = 24;
            // 
            // mangaAuthorGroupBox
            // 
            this.mangaAuthorGroupBox.Controls.Add(this.removeAuthorButton);
            this.mangaAuthorGroupBox.Controls.Add(this.addAuthorButton);
            this.mangaAuthorGroupBox.Controls.Add(this.authorsComboBox);
            this.mangaAuthorGroupBox.Controls.Add(this.authorsNameListBox);
            this.mangaAuthorGroupBox.Enabled = false;
            this.mangaAuthorGroupBox.Location = new System.Drawing.Point(8, 77);
            this.mangaAuthorGroupBox.Name = "mangaAuthorGroupBox";
            this.mangaAuthorGroupBox.Size = new System.Drawing.Size(294, 151);
            this.mangaAuthorGroupBox.TabIndex = 29;
            this.mangaAuthorGroupBox.TabStop = false;
            this.mangaAuthorGroupBox.Text = "Author(s)";
            // 
            // removeAuthorButton
            // 
            this.removeAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeAuthorButton.Image = global::mangaDbEditor.Properties.Resources.minus;
            this.removeAuthorButton.Location = new System.Drawing.Point(253, 124);
            this.removeAuthorButton.Name = "removeAuthorButton";
            this.removeAuthorButton.Size = new System.Drawing.Size(21, 21);
            this.removeAuthorButton.TabIndex = 30;
            this.removeAuthorButton.UseVisualStyleBackColor = true;
            this.removeAuthorButton.Click += new System.EventHandler(this.RemoveAuthorButtonClick);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAuthorButton.Image = global::mangaDbEditor.Properties.Resources.plus;
            this.addAuthorButton.Location = new System.Drawing.Point(226, 124);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(21, 21);
            this.addAuthorButton.TabIndex = 30;
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.AddAuthorButtonClick);
            // 
            // authorsComboBox
            // 
            this.authorsComboBox.FormattingEnabled = true;
            this.authorsComboBox.Location = new System.Drawing.Point(6, 124);
            this.authorsComboBox.Name = "authorsComboBox";
            this.authorsComboBox.Size = new System.Drawing.Size(214, 21);
            this.authorsComboBox.TabIndex = 24;
            // 
            // authorsNameListBox
            // 
            this.authorsNameListBox.FormattingEnabled = true;
            this.authorsNameListBox.Location = new System.Drawing.Point(6, 21);
            this.authorsNameListBox.Name = "authorsNameListBox";
            this.authorsNameListBox.Size = new System.Drawing.Size(268, 95);
            this.authorsNameListBox.TabIndex = 23;
            // 
            // mangaGenresGroupBox
            // 
            this.mangaGenresGroupBox.Controls.Add(this.genreNameListBox);
            this.mangaGenresGroupBox.Controls.Add(this.removeGenreButton);
            this.mangaGenresGroupBox.Controls.Add(this.addGenreButton);
            this.mangaGenresGroupBox.Controls.Add(this.genreNameComboBox);
            this.mangaGenresGroupBox.Enabled = false;
            this.mangaGenresGroupBox.Location = new System.Drawing.Point(308, 271);
            this.mangaGenresGroupBox.Name = "mangaGenresGroupBox";
            this.mangaGenresGroupBox.Size = new System.Drawing.Size(160, 153);
            this.mangaGenresGroupBox.TabIndex = 28;
            this.mangaGenresGroupBox.TabStop = false;
            this.mangaGenresGroupBox.Text = "Genres";
            // 
            // genreNameListBox
            // 
            this.genreNameListBox.FormattingEnabled = true;
            this.genreNameListBox.Location = new System.Drawing.Point(6, 21);
            this.genreNameListBox.Name = "genreNameListBox";
            this.genreNameListBox.Size = new System.Drawing.Size(148, 95);
            this.genreNameListBox.TabIndex = 29;
            // 
            // removeGenreButton
            // 
            this.removeGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeGenreButton.Image = global::mangaDbEditor.Properties.Resources.minus;
            this.removeGenreButton.Location = new System.Drawing.Point(133, 121);
            this.removeGenreButton.Name = "removeGenreButton";
            this.removeGenreButton.Size = new System.Drawing.Size(21, 21);
            this.removeGenreButton.TabIndex = 28;
            this.removeGenreButton.UseVisualStyleBackColor = true;
            this.removeGenreButton.Click += new System.EventHandler(this.RemoveGenreButtonClick);
            // 
            // addGenreButton
            // 
            this.addGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addGenreButton.Image = global::mangaDbEditor.Properties.Resources.plus;
            this.addGenreButton.Location = new System.Drawing.Point(105, 122);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(21, 21);
            this.addGenreButton.TabIndex = 27;
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.AddGenreButtonClick);
            // 
            // genreNameComboBox
            // 
            this.genreNameComboBox.FormattingEnabled = true;
            this.genreNameComboBox.Location = new System.Drawing.Point(6, 122);
            this.genreNameComboBox.Name = "genreNameComboBox";
            this.genreNameComboBox.Size = new System.Drawing.Size(93, 21);
            this.genreNameComboBox.TabIndex = 26;
            // 
            // publicationStatusGroupbox
            // 
            this.publicationStatusGroupbox.Controls.Add(this.mangaStatusComboBox);
            this.publicationStatusGroupbox.Location = new System.Drawing.Point(308, 430);
            this.publicationStatusGroupbox.Name = "publicationStatusGroupbox";
            this.publicationStatusGroupbox.Size = new System.Drawing.Size(160, 55);
            this.publicationStatusGroupbox.TabIndex = 27;
            this.publicationStatusGroupbox.TabStop = false;
            this.publicationStatusGroupbox.Text = "Publication Status";
            // 
            // mangaStatusComboBox
            // 
            this.mangaStatusComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.mangaStatusComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mangaStatusComboBox.FormattingEnabled = true;
            this.mangaStatusComboBox.Items.AddRange(new object[] {
            "Ongoing",
            "Complete",
            "Hiatus"});
            this.mangaStatusComboBox.Location = new System.Drawing.Point(6, 21);
            this.mangaStatusComboBox.Name = "mangaStatusComboBox";
            this.mangaStatusComboBox.Size = new System.Drawing.Size(148, 21);
            this.mangaStatusComboBox.TabIndex = 14;
            // 
            // searchMangaGroupBox
            // 
            this.searchMangaGroupBox.Controls.Add(this.browseAllMangaEntriesbutton);
            this.searchMangaGroupBox.Controls.Add(this.searchMangaButton);
            this.searchMangaGroupBox.Controls.Add(this.searchMangaTextBox);
            this.searchMangaGroupBox.Location = new System.Drawing.Point(308, 491);
            this.searchMangaGroupBox.Name = "searchMangaGroupBox";
            this.searchMangaGroupBox.Size = new System.Drawing.Size(160, 90);
            this.searchMangaGroupBox.TabIndex = 26;
            this.searchMangaGroupBox.TabStop = false;
            this.searchMangaGroupBox.Text = "Search Manga by Title:";
            // 
            // browseAllMangaEntriesbutton
            // 
            this.browseAllMangaEntriesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAllMangaEntriesbutton.Location = new System.Drawing.Point(35, 49);
            this.browseAllMangaEntriesbutton.Name = "browseAllMangaEntriesbutton";
            this.browseAllMangaEntriesbutton.Size = new System.Drawing.Size(119, 23);
            this.browseAllMangaEntriesbutton.TabIndex = 2;
            this.browseAllMangaEntriesbutton.Text = "Browse All Entries";
            this.browseAllMangaEntriesbutton.UseVisualStyleBackColor = true;
            // 
            // searchMangaButton
            // 
            this.searchMangaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchMangaButton.Image = global::mangaDbEditor.Properties.Resources.magnifier;
            this.searchMangaButton.Location = new System.Drawing.Point(6, 49);
            this.searchMangaButton.Name = "searchMangaButton";
            this.searchMangaButton.Size = new System.Drawing.Size(23, 23);
            this.searchMangaButton.TabIndex = 1;
            this.searchMangaButton.UseVisualStyleBackColor = true;
            // 
            // searchMangaTextBox
            // 
            this.searchMangaTextBox.Location = new System.Drawing.Point(6, 21);
            this.searchMangaTextBox.Name = "searchMangaTextBox";
            this.searchMangaTextBox.Size = new System.Drawing.Size(148, 22);
            this.searchMangaTextBox.TabIndex = 0;
            // 
            // buttonImageLoad
            // 
            this.buttonImageLoad.Enabled = false;
            this.buttonImageLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonImageLoad.Location = new System.Drawing.Point(308, 242);
            this.buttonImageLoad.Name = "buttonImageLoad";
            this.buttonImageLoad.Size = new System.Drawing.Size(160, 23);
            this.buttonImageLoad.TabIndex = 19;
            this.buttonImageLoad.Text = "Add Cover Image";
            this.buttonImageLoad.UseVisualStyleBackColor = true;
            this.buttonImageLoad.Click += new System.EventHandler(this.ButtonImageLoadClick);
            // 
            // mangaCoverPictureBox
            // 
            this.mangaCoverPictureBox.Location = new System.Drawing.Point(308, 6);
            this.mangaCoverPictureBox.Name = "mangaCoverPictureBox";
            this.mangaCoverPictureBox.Size = new System.Drawing.Size(160, 230);
            this.mangaCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mangaCoverPictureBox.TabIndex = 12;
            this.mangaCoverPictureBox.TabStop = false;
            // 
            // tabAuthor
            // 
            this.tabAuthor.AutoScroll = true;
            this.tabAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAuthor.Controls.Add(this.searchByAuthorNameGroupBox);
            this.tabAuthor.Controls.Add(this.authorWebsiteGroupBox);
            this.tabAuthor.Controls.Add(this.authorDateOFBirthGroupBox);
            this.tabAuthor.Controls.Add(this.authorCountryGroupBox);
            this.tabAuthor.Controls.Add(this.authorInfoGroupBox);
            this.tabAuthor.Location = new System.Drawing.Point(4, 22);
            this.tabAuthor.Name = "tabAuthor";
            this.tabAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthor.Size = new System.Drawing.Size(476, 614);
            this.tabAuthor.TabIndex = 1;
            this.tabAuthor.Text = "Author";
            // 
            // searchByAuthorNameGroupBox
            // 
            this.searchByAuthorNameGroupBox.Controls.Add(this.browseAllAuthorEntriesButton);
            this.searchByAuthorNameGroupBox.Controls.Add(this.authorSearchButton);
            this.searchByAuthorNameGroupBox.Controls.Add(this.authorSearchTextBox);
            this.searchByAuthorNameGroupBox.Location = new System.Drawing.Point(308, 6);
            this.searchByAuthorNameGroupBox.Name = "searchByAuthorNameGroupBox";
            this.searchByAuthorNameGroupBox.Size = new System.Drawing.Size(160, 75);
            this.searchByAuthorNameGroupBox.TabIndex = 27;
            this.searchByAuthorNameGroupBox.TabStop = false;
            this.searchByAuthorNameGroupBox.Text = "Search Author by Name";
            // 
            // browseAllAuthorEntriesButton
            // 
            this.browseAllAuthorEntriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAllAuthorEntriesButton.Location = new System.Drawing.Point(35, 49);
            this.browseAllAuthorEntriesButton.Name = "browseAllAuthorEntriesButton";
            this.browseAllAuthorEntriesButton.Size = new System.Drawing.Size(119, 23);
            this.browseAllAuthorEntriesButton.TabIndex = 2;
            this.browseAllAuthorEntriesButton.Text = "Browse All Entries";
            this.browseAllAuthorEntriesButton.UseVisualStyleBackColor = true;
            // 
            // authorSearchButton
            // 
            this.authorSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authorSearchButton.Image = global::mangaDbEditor.Properties.Resources.magnifier;
            this.authorSearchButton.Location = new System.Drawing.Point(6, 49);
            this.authorSearchButton.Name = "authorSearchButton";
            this.authorSearchButton.Size = new System.Drawing.Size(23, 23);
            this.authorSearchButton.TabIndex = 1;
            this.authorSearchButton.UseVisualStyleBackColor = true;
            // 
            // authorSearchTextBox
            // 
            this.authorSearchTextBox.Location = new System.Drawing.Point(6, 21);
            this.authorSearchTextBox.Name = "authorSearchTextBox";
            this.authorSearchTextBox.Size = new System.Drawing.Size(148, 22);
            this.authorSearchTextBox.TabIndex = 0;
            // 
            // authorWebsiteGroupBox
            // 
            this.authorWebsiteGroupBox.Controls.Add(this.authorWebsiteTextBox);
            this.authorWebsiteGroupBox.Location = new System.Drawing.Point(8, 206);
            this.authorWebsiteGroupBox.Name = "authorWebsiteGroupBox";
            this.authorWebsiteGroupBox.Size = new System.Drawing.Size(460, 53);
            this.authorWebsiteGroupBox.TabIndex = 14;
            this.authorWebsiteGroupBox.TabStop = false;
            this.authorWebsiteGroupBox.Text = "Website";
            // 
            // authorWebsiteTextBox
            // 
            this.authorWebsiteTextBox.Location = new System.Drawing.Point(6, 21);
            this.authorWebsiteTextBox.Name = "authorWebsiteTextBox";
            this.authorWebsiteTextBox.Size = new System.Drawing.Size(437, 22);
            this.authorWebsiteTextBox.TabIndex = 9;
            // 
            // authorDateOFBirthGroupBox
            // 
            this.authorDateOFBirthGroupBox.Controls.Add(this.authorDateOfBirthDateTimePicker);
            this.authorDateOFBirthGroupBox.Location = new System.Drawing.Point(8, 146);
            this.authorDateOFBirthGroupBox.Name = "authorDateOFBirthGroupBox";
            this.authorDateOFBirthGroupBox.Size = new System.Drawing.Size(460, 54);
            this.authorDateOFBirthGroupBox.TabIndex = 13;
            this.authorDateOFBirthGroupBox.TabStop = false;
            this.authorDateOFBirthGroupBox.Text = "Birthday";
            // 
            // authorDateOfBirthDateTimePicker
            // 
            this.authorDateOfBirthDateTimePicker.Location = new System.Drawing.Point(6, 21);
            this.authorDateOfBirthDateTimePicker.Name = "authorDateOfBirthDateTimePicker";
            this.authorDateOfBirthDateTimePicker.Size = new System.Drawing.Size(437, 22);
            this.authorDateOfBirthDateTimePicker.TabIndex = 7;
            // 
            // authorCountryGroupBox
            // 
            this.authorCountryGroupBox.Controls.Add(this.authorCountryOfOriginTextBox);
            this.authorCountryGroupBox.Location = new System.Drawing.Point(8, 88);
            this.authorCountryGroupBox.Name = "authorCountryGroupBox";
            this.authorCountryGroupBox.Size = new System.Drawing.Size(460, 52);
            this.authorCountryGroupBox.TabIndex = 12;
            this.authorCountryGroupBox.TabStop = false;
            this.authorCountryGroupBox.Text = "Country";
            // 
            // authorCountryOfOriginTextBox
            // 
            this.authorCountryOfOriginTextBox.Location = new System.Drawing.Point(6, 21);
            this.authorCountryOfOriginTextBox.Name = "authorCountryOfOriginTextBox";
            this.authorCountryOfOriginTextBox.Size = new System.Drawing.Size(437, 22);
            this.authorCountryOfOriginTextBox.TabIndex = 5;
            // 
            // authorInfoGroupBox
            // 
            this.authorInfoGroupBox.Controls.Add(this.authorFullNameTextBox);
            this.authorInfoGroupBox.Controls.Add(authorFullNameLabel1);
            this.authorInfoGroupBox.Location = new System.Drawing.Point(8, 6);
            this.authorInfoGroupBox.Name = "authorInfoGroupBox";
            this.authorInfoGroupBox.Size = new System.Drawing.Size(295, 75);
            this.authorInfoGroupBox.TabIndex = 11;
            this.authorInfoGroupBox.TabStop = false;
            this.authorInfoGroupBox.Text = "Author Info";
            // 
            // authorFullNameTextBox
            // 
            this.authorFullNameTextBox.Location = new System.Drawing.Point(6, 34);
            this.authorFullNameTextBox.Name = "authorFullNameTextBox";
            this.authorFullNameTextBox.Size = new System.Drawing.Size(283, 22);
            this.authorFullNameTextBox.TabIndex = 3;
            // 
            // tabPublisher
            // 
            this.tabPublisher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPublisher.Controls.Add(this.publisherNoteGroupBox);
            this.tabPublisher.Controls.Add(this.publisherWebsiteGroupBox);
            this.tabPublisher.Controls.Add(this.publisherCountryGroupBox);
            this.tabPublisher.Controls.Add(this.searchPublisherGroupBox);
            this.tabPublisher.Controls.Add(this.publisherInfoGroupBox);
            this.tabPublisher.Location = new System.Drawing.Point(4, 22);
            this.tabPublisher.Name = "tabPublisher";
            this.tabPublisher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPublisher.Size = new System.Drawing.Size(476, 614);
            this.tabPublisher.TabIndex = 2;
            this.tabPublisher.Text = "Publisher";
            // 
            // publisherNoteGroupBox
            // 
            this.publisherNoteGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.publisherNoteGroupBox.Controls.Add(this.publisherNoteTextBox);
            this.publisherNoteGroupBox.Location = new System.Drawing.Point(8, 207);
            this.publisherNoteGroupBox.Name = "publisherNoteGroupBox";
            this.publisherNoteGroupBox.Size = new System.Drawing.Size(460, 399);
            this.publisherNoteGroupBox.TabIndex = 31;
            this.publisherNoteGroupBox.TabStop = false;
            this.publisherNoteGroupBox.Text = "Note";
            // 
            // publisherNoteTextBox
            // 
            this.publisherNoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publisherNoteTextBox.Location = new System.Drawing.Point(3, 18);
            this.publisherNoteTextBox.Multiline = true;
            this.publisherNoteTextBox.Name = "publisherNoteTextBox";
            this.publisherNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.publisherNoteTextBox.Size = new System.Drawing.Size(454, 378);
            this.publisherNoteTextBox.TabIndex = 9;
            // 
            // publisherWebsiteGroupBox
            // 
            this.publisherWebsiteGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.publisherWebsiteGroupBox.Controls.Add(this.publisherWebsiteTextBox);
            this.publisherWebsiteGroupBox.Location = new System.Drawing.Point(8, 149);
            this.publisherWebsiteGroupBox.Name = "publisherWebsiteGroupBox";
            this.publisherWebsiteGroupBox.Size = new System.Drawing.Size(460, 52);
            this.publisherWebsiteGroupBox.TabIndex = 30;
            this.publisherWebsiteGroupBox.TabStop = false;
            this.publisherWebsiteGroupBox.Text = "Website";
            // 
            // publisherWebsiteTextBox
            // 
            this.publisherWebsiteTextBox.Location = new System.Drawing.Point(6, 21);
            this.publisherWebsiteTextBox.Name = "publisherWebsiteTextBox";
            this.publisherWebsiteTextBox.Size = new System.Drawing.Size(437, 22);
            this.publisherWebsiteTextBox.TabIndex = 7;
            // 
            // publisherCountryGroupBox
            // 
            this.publisherCountryGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.publisherCountryGroupBox.Controls.Add(this.publisherCountryTextBox);
            this.publisherCountryGroupBox.Location = new System.Drawing.Point(8, 88);
            this.publisherCountryGroupBox.Name = "publisherCountryGroupBox";
            this.publisherCountryGroupBox.Size = new System.Drawing.Size(460, 55);
            this.publisherCountryGroupBox.TabIndex = 29;
            this.publisherCountryGroupBox.TabStop = false;
            this.publisherCountryGroupBox.Text = "Country";
            // 
            // publisherCountryTextBox
            // 
            this.publisherCountryTextBox.Location = new System.Drawing.Point(6, 21);
            this.publisherCountryTextBox.Name = "publisherCountryTextBox";
            this.publisherCountryTextBox.Size = new System.Drawing.Size(437, 22);
            this.publisherCountryTextBox.TabIndex = 5;
            // 
            // searchPublisherGroupBox
            // 
            this.searchPublisherGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchPublisherGroupBox.Controls.Add(this.browseAllPublisherEntriesButton);
            this.searchPublisherGroupBox.Controls.Add(this.searchPublisherButton);
            this.searchPublisherGroupBox.Controls.Add(this.searchPublisherTextBox);
            this.searchPublisherGroupBox.Location = new System.Drawing.Point(308, 6);
            this.searchPublisherGroupBox.Name = "searchPublisherGroupBox";
            this.searchPublisherGroupBox.Size = new System.Drawing.Size(160, 75);
            this.searchPublisherGroupBox.TabIndex = 28;
            this.searchPublisherGroupBox.TabStop = false;
            this.searchPublisherGroupBox.Text = "Search Publisher by Name";
            // 
            // browseAllPublisherEntriesButton
            // 
            this.browseAllPublisherEntriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAllPublisherEntriesButton.Location = new System.Drawing.Point(35, 49);
            this.browseAllPublisherEntriesButton.Name = "browseAllPublisherEntriesButton";
            this.browseAllPublisherEntriesButton.Size = new System.Drawing.Size(119, 23);
            this.browseAllPublisherEntriesButton.TabIndex = 2;
            this.browseAllPublisherEntriesButton.Text = "Browse All Entries";
            this.browseAllPublisherEntriesButton.UseVisualStyleBackColor = true;
            // 
            // searchPublisherButton
            // 
            this.searchPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchPublisherButton.Image = global::mangaDbEditor.Properties.Resources.magnifier;
            this.searchPublisherButton.Location = new System.Drawing.Point(6, 49);
            this.searchPublisherButton.Name = "searchPublisherButton";
            this.searchPublisherButton.Size = new System.Drawing.Size(23, 23);
            this.searchPublisherButton.TabIndex = 1;
            this.searchPublisherButton.UseVisualStyleBackColor = true;
            // 
            // searchPublisherTextBox
            // 
            this.searchPublisherTextBox.Location = new System.Drawing.Point(6, 21);
            this.searchPublisherTextBox.Name = "searchPublisherTextBox";
            this.searchPublisherTextBox.Size = new System.Drawing.Size(148, 22);
            this.searchPublisherTextBox.TabIndex = 0;
            // 
            // publisherInfoGroupBox
            // 
            this.publisherInfoGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.publisherInfoGroupBox.Controls.Add(this.publisherNameTextBox);
            this.publisherInfoGroupBox.Controls.Add(publisherNameLabel1);
            this.publisherInfoGroupBox.Location = new System.Drawing.Point(8, 6);
            this.publisherInfoGroupBox.Name = "publisherInfoGroupBox";
            this.publisherInfoGroupBox.Size = new System.Drawing.Size(295, 75);
            this.publisherInfoGroupBox.TabIndex = 12;
            this.publisherInfoGroupBox.TabStop = false;
            this.publisherInfoGroupBox.Text = "Publisher Info";
            // 
            // publisherNameTextBox
            // 
            this.publisherNameTextBox.Location = new System.Drawing.Point(6, 37);
            this.publisherNameTextBox.Name = "publisherNameTextBox";
            this.publisherNameTextBox.Size = new System.Drawing.Size(283, 22);
            this.publisherNameTextBox.TabIndex = 3;
            // 
            // MangaInfoNavigator
            // 
            this.MangaInfoNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MangaInfoNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MangaInfoNavigatorFirst,
            this.MangaInfoNavigatorPrevious,
            this.MangaInfoNavigatorSepOne,
            this.MangaInfoNavigatorCurrent,
            this.MangaInfoNavigatorTotal,
            this.MangaInfoNavigatorSepTwo,
            this.MangaInfoNavigatorNext,
            this.MangaInfoNavigatorLast,
            this.MangaInfoNavigatorSepThree,
            this.MangaInfoNavigatorNew,
            this.MangaInfoNavigatorDelete,
            this.MangaInfoNavigatorSave});
            this.MangaInfoNavigator.Location = new System.Drawing.Point(0, 24);
            this.MangaInfoNavigator.Name = "MangaInfoNavigator";
            this.MangaInfoNavigator.Size = new System.Drawing.Size(484, 25);
            this.MangaInfoNavigator.TabIndex = 35;
            // 
            // MangaInfoNavigatorFirst
            // 
            this.MangaInfoNavigatorFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorFirst.Image = global::mangaDbEditor.Properties.Resources.controlStop180;
            this.MangaInfoNavigatorFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorFirst.Name = "MangaInfoNavigatorFirst";
            this.MangaInfoNavigatorFirst.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorFirst.Text = "toolStripButton1";
            this.MangaInfoNavigatorFirst.Click += new System.EventHandler(this.HandleMangaInfoNavigatorFirstClick);
            // 
            // MangaInfoNavigatorPrevious
            // 
            this.MangaInfoNavigatorPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorPrevious.Image = global::mangaDbEditor.Properties.Resources.control180;
            this.MangaInfoNavigatorPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorPrevious.Name = "MangaInfoNavigatorPrevious";
            this.MangaInfoNavigatorPrevious.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorPrevious.Text = "toolStripButton2";
            this.MangaInfoNavigatorPrevious.Click += new System.EventHandler(this.HandleMangaInfoNavigatorPreviousClick);
            // 
            // MangaInfoNavigatorSepOne
            // 
            this.MangaInfoNavigatorSepOne.Name = "MangaInfoNavigatorSepOne";
            this.MangaInfoNavigatorSepOne.Size = new System.Drawing.Size(6, 25);
            // 
            // MangaInfoNavigatorCurrent
            // 
            this.MangaInfoNavigatorCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MangaInfoNavigatorCurrent.Name = "MangaInfoNavigatorCurrent";
            this.MangaInfoNavigatorCurrent.Size = new System.Drawing.Size(50, 25);
            this.MangaInfoNavigatorCurrent.TextChanged += new System.EventHandler(this.MangaInfoNavigatorCurrentTextChanged);
            // 
            // MangaInfoNavigatorTotal
            // 
            this.MangaInfoNavigatorTotal.Name = "MangaInfoNavigatorTotal";
            this.MangaInfoNavigatorTotal.Size = new System.Drawing.Size(35, 22);
            this.MangaInfoNavigatorTotal.Text = "of {0}";
            // 
            // MangaInfoNavigatorSepTwo
            // 
            this.MangaInfoNavigatorSepTwo.Name = "MangaInfoNavigatorSepTwo";
            this.MangaInfoNavigatorSepTwo.Size = new System.Drawing.Size(6, 25);
            // 
            // MangaInfoNavigatorNext
            // 
            this.MangaInfoNavigatorNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorNext.Image = global::mangaDbEditor.Properties.Resources.control;
            this.MangaInfoNavigatorNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorNext.Name = "MangaInfoNavigatorNext";
            this.MangaInfoNavigatorNext.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorNext.Text = "toolStripButton3";
            this.MangaInfoNavigatorNext.Click += new System.EventHandler(this.HandleMangaInfoNavigatorNextClick);
            // 
            // MangaInfoNavigatorLast
            // 
            this.MangaInfoNavigatorLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorLast.Image = global::mangaDbEditor.Properties.Resources.controlStop;
            this.MangaInfoNavigatorLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorLast.Name = "MangaInfoNavigatorLast";
            this.MangaInfoNavigatorLast.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorLast.Text = "toolStripButton4";
            this.MangaInfoNavigatorLast.Click += new System.EventHandler(this.HandleMangaInfoNavigatorLastClick);
            // 
            // MangaInfoNavigatorSepThree
            // 
            this.MangaInfoNavigatorSepThree.Name = "MangaInfoNavigatorSepThree";
            this.MangaInfoNavigatorSepThree.Size = new System.Drawing.Size(6, 25);
            // 
            // MangaInfoNavigatorNew
            // 
            this.MangaInfoNavigatorNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorNew.Image = global::mangaDbEditor.Properties.Resources.plus;
            this.MangaInfoNavigatorNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorNew.Name = "MangaInfoNavigatorNew";
            this.MangaInfoNavigatorNew.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorNew.Text = "toolStripButton5";
            this.MangaInfoNavigatorNew.Click += new System.EventHandler(this.HandleMangaInfoNavigatorNewClick);
            // 
            // MangaInfoNavigatorDelete
            // 
            this.MangaInfoNavigatorDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorDelete.Image = global::mangaDbEditor.Properties.Resources.crossScript;
            this.MangaInfoNavigatorDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorDelete.Name = "MangaInfoNavigatorDelete";
            this.MangaInfoNavigatorDelete.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorDelete.Text = "toolStripButton6";
            // 
            // MangaInfoNavigatorSave
            // 
            this.MangaInfoNavigatorSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MangaInfoNavigatorSave.Image = global::mangaDbEditor.Properties.Resources.diskPencil;
            this.MangaInfoNavigatorSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MangaInfoNavigatorSave.Name = "MangaInfoNavigatorSave";
            this.MangaInfoNavigatorSave.Size = new System.Drawing.Size(23, 22);
            this.MangaInfoNavigatorSave.Text = "toolStripButton7";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(484, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportDatabaseToolStripMenuItem,
            this.importDatabaseToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exportDatabaseToolStripMenuItem.Text = "Export Database";
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ExportDatabaseToolStripMenuItemClick);
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importDatabaseToolStripMenuItem.Text = "Import Database";
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ImportDatabaseToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genresToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.GenresToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "JPG files|*.jpg|PNG files|*.png|All files|.*.";
            // 
            // importDatabaseOpenFileDialog
            // 
            this.importDatabaseOpenFileDialog.Filter = "XML Files|*.xml";
            // 
            // ExportDatabaseSaveFileDialog
            // 
            this.ExportDatabaseSaveFileDialog.Filter = "XML files|*.xml";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 689);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.MangaInfoNavigator);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Manga Database Editor";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tabControl.ResumeLayout(false);
            this.tabManga.ResumeLayout(false);
            this.tabManga.PerformLayout();
            this.databaseEditorStatusStrip.ResumeLayout(false);
            this.databaseEditorStatusStrip.PerformLayout();
            this.dateOfPublicationGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.ResumeLayout(false);
            this.descriptionGroupBox.PerformLayout();
            this.mangaInfoGroupBox.ResumeLayout(false);
            this.mangaInfoGroupBox.PerformLayout();
            this.publisherGroupBox.ResumeLayout(false);
            this.publisherGroupBox.PerformLayout();
            this.mangaAuthorGroupBox.ResumeLayout(false);
            this.mangaGenresGroupBox.ResumeLayout(false);
            this.publicationStatusGroupbox.ResumeLayout(false);
            this.searchMangaGroupBox.ResumeLayout(false);
            this.searchMangaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).EndInit();
            this.tabAuthor.ResumeLayout(false);
            this.searchByAuthorNameGroupBox.ResumeLayout(false);
            this.searchByAuthorNameGroupBox.PerformLayout();
            this.authorWebsiteGroupBox.ResumeLayout(false);
            this.authorWebsiteGroupBox.PerformLayout();
            this.authorDateOFBirthGroupBox.ResumeLayout(false);
            this.authorCountryGroupBox.ResumeLayout(false);
            this.authorCountryGroupBox.PerformLayout();
            this.authorInfoGroupBox.ResumeLayout(false);
            this.authorInfoGroupBox.PerformLayout();
            this.tabPublisher.ResumeLayout(false);
            this.publisherNoteGroupBox.ResumeLayout(false);
            this.publisherNoteGroupBox.PerformLayout();
            this.publisherWebsiteGroupBox.ResumeLayout(false);
            this.publisherWebsiteGroupBox.PerformLayout();
            this.publisherCountryGroupBox.ResumeLayout(false);
            this.publisherCountryGroupBox.PerformLayout();
            this.searchPublisherGroupBox.ResumeLayout(false);
            this.searchPublisherGroupBox.PerformLayout();
            this.publisherInfoGroupBox.ResumeLayout(false);
            this.publisherInfoGroupBox.PerformLayout();
            this.MangaInfoNavigator.ResumeLayout(false);
            this.MangaInfoNavigator.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabManga;
        private System.Windows.Forms.DateTimePicker dateOfPublishDateTimePicker;
		private System.Windows.Forms.TextBox mangaDescriptionTextBox;
		private System.Windows.Forms.ComboBox mangaStatusComboBox;
        private System.Windows.Forms.PictureBox mangaCoverPictureBox;
        private System.Windows.Forms.TextBox mangaTitleTextBox;
		private System.Windows.Forms.TabPage tabAuthor;
		private System.Windows.Forms.TabPage tabPublisher;
        private System.Windows.Forms.Button buttonImageLoad;
		private System.Windows.Forms.TextBox authorWebsiteTextBox;
		private System.Windows.Forms.DateTimePicker authorDateOfBirthDateTimePicker;
		private System.Windows.Forms.TextBox authorCountryOfOriginTextBox;
        private System.Windows.Forms.TextBox authorFullNameTextBox;
        private System.Windows.Forms.TextBox publisherNoteTextBox;
		private System.Windows.Forms.TextBox publisherWebsiteTextBox;
		private System.Windows.Forms.TextBox publisherCountryTextBox;
        private System.Windows.Forms.TextBox publisherNameTextBox;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openImageFileDialog;
		private System.Windows.Forms.TextBox mangaPublisherNameTextBox;
		private System.Windows.Forms.ListBox authorsNameListBox;
		private System.Windows.Forms.GroupBox publicationStatusGroupbox;
		private System.Windows.Forms.GroupBox searchMangaGroupBox;
		private System.Windows.Forms.Button browseAllMangaEntriesbutton;
		private System.Windows.Forms.Button searchMangaButton;
        private System.Windows.Forms.TextBox searchMangaTextBox;
		private System.Windows.Forms.GroupBox mangaGenresGroupBox;
		private System.Windows.Forms.Button removeGenreButton;
		private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.ComboBox genreNameComboBox;
		private System.Windows.Forms.ListBox genreNameListBox;
		private System.Windows.Forms.GroupBox mangaAuthorGroupBox;
		private System.Windows.Forms.Button removeAuthorButton;
		private System.Windows.Forms.Button addAuthorButton;
		private System.Windows.Forms.ComboBox authorsComboBox;
		private System.Windows.Forms.GroupBox publisherGroupBox;
		private System.Windows.Forms.GroupBox descriptionGroupBox;
		private System.Windows.Forms.GroupBox mangaInfoGroupBox;
		private System.Windows.Forms.Button removePublisherButton;
		private System.Windows.Forms.Button addPublisherButton;
        private System.Windows.Forms.ComboBox publisherComboBox;
		private System.Windows.Forms.GroupBox dateOfPublicationGroupBox;
		private System.Windows.Forms.GroupBox searchByAuthorNameGroupBox;
		private System.Windows.Forms.Button browseAllAuthorEntriesButton;
		private System.Windows.Forms.Button authorSearchButton;
		private System.Windows.Forms.TextBox authorSearchTextBox;
		private System.Windows.Forms.GroupBox authorWebsiteGroupBox;
		private System.Windows.Forms.GroupBox authorDateOFBirthGroupBox;
		private System.Windows.Forms.GroupBox authorCountryGroupBox;
		private System.Windows.Forms.GroupBox authorInfoGroupBox;
		private System.Windows.Forms.GroupBox publisherInfoGroupBox;
		private System.Windows.Forms.GroupBox publisherNoteGroupBox;
		private System.Windows.Forms.GroupBox publisherWebsiteGroupBox;
		private System.Windows.Forms.GroupBox publisherCountryGroupBox;
		private System.Windows.Forms.GroupBox searchPublisherGroupBox;
		private System.Windows.Forms.Button browseAllPublisherEntriesButton;
		private System.Windows.Forms.Button searchPublisherButton;
		private System.Windows.Forms.TextBox searchPublisherTextBox;
		private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.StatusStrip databaseEditorStatusStrip;
		private System.Windows.Forms.ToolStripProgressBar tableLoadProgress;
		private System.Windows.Forms.ToolStripProgressBar currentTableLoadProgress;
        private System.Windows.Forms.OpenFileDialog importDatabaseOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ExportDatabaseSaveFileDialog;
        private System.Windows.Forms.ToolStrip MangaInfoNavigator;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorFirst;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorPrevious;
        private System.Windows.Forms.ToolStripSeparator MangaInfoNavigatorSepOne;
        private System.Windows.Forms.ToolStripTextBox MangaInfoNavigatorCurrent;
        private System.Windows.Forms.ToolStripLabel MangaInfoNavigatorTotal;
        private System.Windows.Forms.ToolStripSeparator MangaInfoNavigatorSepTwo;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorNext;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorLast;
        private System.Windows.Forms.ToolStripSeparator MangaInfoNavigatorSepThree;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorNew;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorDelete;
        private System.Windows.Forms.ToolStripButton MangaInfoNavigatorSave;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
	}
}

