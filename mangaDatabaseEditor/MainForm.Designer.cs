namespace mangaDatabaseEditor
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
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.Label mangaIDLabel;
         System.Windows.Forms.Label mangaTitleLabel;
         System.Windows.Forms.Label authorIDLabel;
         System.Windows.Forms.Label authorFullNameLabel1;
         System.Windows.Forms.Label publisherIDLabel;
         System.Windows.Forms.Label publisherNameLabel1;
         this.tabControl = new System.Windows.Forms.TabControl();
         this.tabManga = new System.Windows.Forms.TabPage();
         this.dateOfPublicationGroupBox = new System.Windows.Forms.GroupBox();
         this.dateOfPublishDateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.mangaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
         this.mangaDescriptionTextBox = new System.Windows.Forms.TextBox();
         this.mangaInfoGroupBox = new System.Windows.Forms.GroupBox();
         this.mangaIDTextBox = new System.Windows.Forms.TextBox();
         this.mangaTitleTextBox = new System.Windows.Forms.TextBox();
         this.publisherGroupBox = new System.Windows.Forms.GroupBox();
         this.removePublisherButton = new System.Windows.Forms.Button();
         this.addPublisherButton = new System.Windows.Forms.Button();
         this.publisherComboBox = new System.Windows.Forms.ComboBox();
         this.publisherNameTextBox1 = new System.Windows.Forms.TextBox();
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
         this.mangaInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.mangaInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.tabAuthor = new System.Windows.Forms.TabPage();
         this.searchByAuthorNameGroupBox = new System.Windows.Forms.GroupBox();
         this.browseAllAuthorEntriesButton = new System.Windows.Forms.Button();
         this.authorSearchButton = new System.Windows.Forms.Button();
         this.authorSearchTextBox = new System.Windows.Forms.TextBox();
         this.authorWebsiteGroupBox = new System.Windows.Forms.GroupBox();
         this.authorWebsiteTextBox = new System.Windows.Forms.TextBox();
         this.authorTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.authorDateOFBirthGroupBox = new System.Windows.Forms.GroupBox();
         this.authorDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
         this.authorCountryGroupBox = new System.Windows.Forms.GroupBox();
         this.authorCountryOfOriginTextBox = new System.Windows.Forms.TextBox();
         this.authorInfoGroupBox = new System.Windows.Forms.GroupBox();
         this.authorFullNameTextBox = new System.Windows.Forms.TextBox();
         this.authorIDTextBox = new System.Windows.Forms.TextBox();
         this.authorTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.authorTableBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.authorTableBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.authorTableBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.authorTableBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.authorTableBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.authorTableBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.authorTableBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.authorTableBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.authorTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.tabPublisher = new System.Windows.Forms.TabPage();
         this.publisherNoteGroupBox = new System.Windows.Forms.GroupBox();
         this.publisherNoteTextBox = new System.Windows.Forms.TextBox();
         this.publisherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
         this.publisherIDTextBox = new System.Windows.Forms.TextBox();
         this.publisherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.publisherInfoBindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.publisherInfoBindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
         this.publisherInfoBindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
         this.publisherInfoBindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
         this.publisherInfoBindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
         this.publisherInfoBindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
         this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
         this.publisherInfoBindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
         this.publisherInfoBindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
         this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
         this.publisherInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.genreInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.mangaAuthorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.addAuthorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.mangaGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.mangaInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         mangaIDLabel = new System.Windows.Forms.Label();
         mangaTitleLabel = new System.Windows.Forms.Label();
         authorIDLabel = new System.Windows.Forms.Label();
         authorFullNameLabel1 = new System.Windows.Forms.Label();
         publisherIDLabel = new System.Windows.Forms.Label();
         publisherNameLabel1 = new System.Windows.Forms.Label();
         this.tabControl.SuspendLayout();
         this.tabManga.SuspendLayout();
         this.dateOfPublicationGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.mangaInfoBindingSource)).BeginInit();
         this.descriptionGroupBox.SuspendLayout();
         this.mangaInfoGroupBox.SuspendLayout();
         this.publisherGroupBox.SuspendLayout();
         this.mangaAuthorGroupBox.SuspendLayout();
         this.mangaGenresGroupBox.SuspendLayout();
         this.publicationStatusGroupbox.SuspendLayout();
         this.searchMangaGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaInfoBindingNavigator)).BeginInit();
         this.mangaInfoBindingNavigator.SuspendLayout();
         this.tabAuthor.SuspendLayout();
         this.searchByAuthorNameGroupBox.SuspendLayout();
         this.authorWebsiteGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorTableBindingSource)).BeginInit();
         this.authorDateOFBirthGroupBox.SuspendLayout();
         this.authorCountryGroupBox.SuspendLayout();
         this.authorInfoGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorTableBindingNavigator)).BeginInit();
         this.authorTableBindingNavigator.SuspendLayout();
         this.tabPublisher.SuspendLayout();
         this.publisherNoteGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.publisherInfoBindingSource)).BeginInit();
         this.publisherWebsiteGroupBox.SuspendLayout();
         this.publisherCountryGroupBox.SuspendLayout();
         this.searchPublisherGroupBox.SuspendLayout();
         this.publisherInfoGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.publisherBindingNavigator)).BeginInit();
         this.publisherBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.genreInfoBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaAuthorsBindingSource)).BeginInit();
         this.mainMenuStrip.SuspendLayout();
         this.addAuthorContextMenu.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.mangaGenresBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaInfoBindingSource1)).BeginInit();
         this.SuspendLayout();
         // 
         // mangaIDLabel
         // 
         mangaIDLabel.AutoSize = true;
         mangaIDLabel.Location = new System.Drawing.Point(132, 23);
         mangaIDLabel.Name = "mangaIDLabel";
         mangaIDLabel.Size = new System.Drawing.Size(21, 13);
         mangaIDLabel.TabIndex = 0;
         mangaIDLabel.Text = "ID:";
         // 
         // mangaTitleLabel
         // 
         mangaTitleLabel.AutoSize = true;
         mangaTitleLabel.Location = new System.Drawing.Point(6, 32);
         mangaTitleLabel.Name = "mangaTitleLabel";
         mangaTitleLabel.Size = new System.Drawing.Size(31, 13);
         mangaTitleLabel.TabIndex = 3;
         mangaTitleLabel.Text = "Title:";
         // 
         // authorIDLabel
         // 
         authorIDLabel.AutoSize = true;
         authorIDLabel.Location = new System.Drawing.Point(132, 23);
         authorIDLabel.Name = "authorIDLabel";
         authorIDLabel.Size = new System.Drawing.Size(21, 13);
         authorIDLabel.TabIndex = 0;
         authorIDLabel.Text = "ID:";
         // 
         // authorFullNameLabel1
         // 
         authorFullNameLabel1.AutoSize = true;
         authorFullNameLabel1.Location = new System.Drawing.Point(6, 32);
         authorFullNameLabel1.Name = "authorFullNameLabel1";
         authorFullNameLabel1.Size = new System.Drawing.Size(61, 13);
         authorFullNameLabel1.TabIndex = 2;
         authorFullNameLabel1.Text = "Full Name:";
         // 
         // publisherIDLabel
         // 
         publisherIDLabel.AutoSize = true;
         publisherIDLabel.Location = new System.Drawing.Point(132, 23);
         publisherIDLabel.Name = "publisherIDLabel";
         publisherIDLabel.Size = new System.Drawing.Size(21, 13);
         publisherIDLabel.TabIndex = 0;
         publisherIDLabel.Text = "ID:";
         // 
         // publisherNameLabel1
         // 
         publisherNameLabel1.AutoSize = true;
         publisherNameLabel1.Location = new System.Drawing.Point(6, 32);
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
         this.tabControl.Location = new System.Drawing.Point(0, 24);
         this.tabControl.Name = "tabControl";
         this.tabControl.SelectedIndex = 0;
         this.tabControl.Size = new System.Drawing.Size(484, 646);
         this.tabControl.TabIndex = 0;
         // 
         // tabManga
         // 
         this.tabManga.AutoScroll = true;
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
         this.tabManga.Controls.Add(this.mangaInfoBindingNavigator);
         this.tabManga.Location = new System.Drawing.Point(4, 22);
         this.tabManga.Name = "tabManga";
         this.tabManga.Padding = new System.Windows.Forms.Padding(3);
         this.tabManga.Size = new System.Drawing.Size(476, 620);
         this.tabManga.TabIndex = 0;
         this.tabManga.Text = "Manga";
         this.tabManga.UseVisualStyleBackColor = true;
         // 
         // dateOfPublicationGroupBox
         // 
         this.dateOfPublicationGroupBox.Controls.Add(this.dateOfPublishDateTimePicker);
         this.dateOfPublicationGroupBox.Location = new System.Drawing.Point(8, 550);
         this.dateOfPublicationGroupBox.Name = "dateOfPublicationGroupBox";
         this.dateOfPublicationGroupBox.Size = new System.Drawing.Size(283, 56);
         this.dateOfPublicationGroupBox.TabIndex = 33;
         this.dateOfPublicationGroupBox.TabStop = false;
         this.dateOfPublicationGroupBox.Text = "Date Of Publication";
         // 
         // dateOfPublishDateTimePicker
         // 
         this.dateOfPublishDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mangaInfoBindingSource, "dateOfPublish", true));
         this.dateOfPublishDateTimePicker.Location = new System.Drawing.Point(6, 21);
         this.dateOfPublishDateTimePicker.Name = "dateOfPublishDateTimePicker";
         this.dateOfPublishDateTimePicker.Size = new System.Drawing.Size(270, 22);
         this.dateOfPublishDateTimePicker.TabIndex = 18;
         // 
         // mangaInfoBindingSource
         // 
         this.mangaInfoBindingSource.DataSource = typeof(mangaDatabaseEditor.mangaInfo);
         this.mangaInfoBindingSource.CurrentChanged += new System.EventHandler(this.mangaInfoBindingSource_CurrentChanged);
         // 
         // descriptionGroupBox
         // 
         this.descriptionGroupBox.Controls.Add(this.mangaDescriptionTextBox);
         this.descriptionGroupBox.Location = new System.Drawing.Point(8, 349);
         this.descriptionGroupBox.Name = "descriptionGroupBox";
         this.descriptionGroupBox.Size = new System.Drawing.Size(283, 195);
         this.descriptionGroupBox.TabIndex = 32;
         this.descriptionGroupBox.TabStop = false;
         this.descriptionGroupBox.Text = "Description";
         // 
         // mangaDescriptionTextBox
         // 
         this.mangaDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.mangaDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaInfoBindingSource, "mangaDescription", true));
         this.mangaDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mangaDescriptionTextBox.Location = new System.Drawing.Point(3, 16);
         this.mangaDescriptionTextBox.Multiline = true;
         this.mangaDescriptionTextBox.Name = "mangaDescriptionTextBox";
         this.mangaDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.mangaDescriptionTextBox.Size = new System.Drawing.Size(277, 176);
         this.mangaDescriptionTextBox.TabIndex = 16;
         // 
         // mangaInfoGroupBox
         // 
         this.mangaInfoGroupBox.Controls.Add(this.mangaIDTextBox);
         this.mangaInfoGroupBox.Controls.Add(this.mangaTitleTextBox);
         this.mangaInfoGroupBox.Controls.Add(mangaIDLabel);
         this.mangaInfoGroupBox.Controls.Add(mangaTitleLabel);
         this.mangaInfoGroupBox.Location = new System.Drawing.Point(8, 31);
         this.mangaInfoGroupBox.Name = "mangaInfoGroupBox";
         this.mangaInfoGroupBox.Size = new System.Drawing.Size(283, 76);
         this.mangaInfoGroupBox.TabIndex = 31;
         this.mangaInfoGroupBox.TabStop = false;
         this.mangaInfoGroupBox.Text = "Manga Info";
         // 
         // mangaIDTextBox
         // 
         this.mangaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaInfoBindingSource, "mangaID", true));
         this.mangaIDTextBox.Location = new System.Drawing.Point(159, 20);
         this.mangaIDTextBox.Name = "mangaIDTextBox";
         this.mangaIDTextBox.ReadOnly = true;
         this.mangaIDTextBox.Size = new System.Drawing.Size(115, 22);
         this.mangaIDTextBox.TabIndex = 1;
         this.mangaIDTextBox.TextChanged += new System.EventHandler(this.mangaIDTextBox_TextChanged);
         // 
         // mangaTitleTextBox
         // 
         this.mangaTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaInfoBindingSource, "mangaTitle", true));
         this.mangaTitleTextBox.Location = new System.Drawing.Point(6, 48);
         this.mangaTitleTextBox.Name = "mangaTitleTextBox";
         this.mangaTitleTextBox.Size = new System.Drawing.Size(268, 22);
         this.mangaTitleTextBox.TabIndex = 4;
         // 
         // publisherGroupBox
         // 
         this.publisherGroupBox.Controls.Add(this.removePublisherButton);
         this.publisherGroupBox.Controls.Add(this.addPublisherButton);
         this.publisherGroupBox.Controls.Add(this.publisherComboBox);
         this.publisherGroupBox.Controls.Add(this.publisherNameTextBox1);
         this.publisherGroupBox.Enabled = false;
         this.publisherGroupBox.Location = new System.Drawing.Point(8, 259);
         this.publisherGroupBox.Name = "publisherGroupBox";
         this.publisherGroupBox.Size = new System.Drawing.Size(283, 84);
         this.publisherGroupBox.TabIndex = 30;
         this.publisherGroupBox.TabStop = false;
         this.publisherGroupBox.Text = "Publisher";
         // 
         // removePublisherButton
         // 
         this.removePublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.removePublisherButton.Image = global::mangaDatabaseEditor.Properties.Resources.minus;
         this.removePublisherButton.Location = new System.Drawing.Point(253, 49);
         this.removePublisherButton.Name = "removePublisherButton";
         this.removePublisherButton.Size = new System.Drawing.Size(21, 21);
         this.removePublisherButton.TabIndex = 30;
         this.removePublisherButton.UseVisualStyleBackColor = true;
         this.removePublisherButton.Click += new System.EventHandler(this.removePublisherButton_Click);
         // 
         // addPublisherButton
         // 
         this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.addPublisherButton.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
         this.addPublisherButton.Location = new System.Drawing.Point(226, 49);
         this.addPublisherButton.Name = "addPublisherButton";
         this.addPublisherButton.Size = new System.Drawing.Size(21, 21);
         this.addPublisherButton.TabIndex = 30;
         this.addPublisherButton.UseVisualStyleBackColor = true;
         this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
         // 
         // publisherComboBox
         // 
         this.publisherComboBox.FormattingEnabled = true;
         this.publisherComboBox.Location = new System.Drawing.Point(6, 49);
         this.publisherComboBox.Name = "publisherComboBox";
         this.publisherComboBox.Size = new System.Drawing.Size(214, 21);
         this.publisherComboBox.TabIndex = 31;
         // 
         // publisherNameTextBox1
         // 
         this.publisherNameTextBox1.Location = new System.Drawing.Point(6, 21);
         this.publisherNameTextBox1.Name = "publisherNameTextBox1";
         this.publisherNameTextBox1.Size = new System.Drawing.Size(268, 22);
         this.publisherNameTextBox1.TabIndex = 24;
         // 
         // mangaAuthorGroupBox
         // 
         this.mangaAuthorGroupBox.Controls.Add(this.removeAuthorButton);
         this.mangaAuthorGroupBox.Controls.Add(this.addAuthorButton);
         this.mangaAuthorGroupBox.Controls.Add(this.authorsComboBox);
         this.mangaAuthorGroupBox.Controls.Add(this.authorsNameListBox);
         this.mangaAuthorGroupBox.Enabled = false;
         this.mangaAuthorGroupBox.Location = new System.Drawing.Point(8, 113);
         this.mangaAuthorGroupBox.Name = "mangaAuthorGroupBox";
         this.mangaAuthorGroupBox.Size = new System.Drawing.Size(283, 140);
         this.mangaAuthorGroupBox.TabIndex = 29;
         this.mangaAuthorGroupBox.TabStop = false;
         this.mangaAuthorGroupBox.Text = "Author(s)";
         // 
         // removeAuthorButton
         // 
         this.removeAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.removeAuthorButton.Image = global::mangaDatabaseEditor.Properties.Resources.minus;
         this.removeAuthorButton.Location = new System.Drawing.Point(253, 109);
         this.removeAuthorButton.Name = "removeAuthorButton";
         this.removeAuthorButton.Size = new System.Drawing.Size(21, 21);
         this.removeAuthorButton.TabIndex = 30;
         this.removeAuthorButton.UseVisualStyleBackColor = true;
         this.removeAuthorButton.Click += new System.EventHandler(this.removeAuthorButton_Click);
         // 
         // addAuthorButton
         // 
         this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.addAuthorButton.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
         this.addAuthorButton.Location = new System.Drawing.Point(226, 109);
         this.addAuthorButton.Name = "addAuthorButton";
         this.addAuthorButton.Size = new System.Drawing.Size(21, 21);
         this.addAuthorButton.TabIndex = 30;
         this.addAuthorButton.UseVisualStyleBackColor = true;
         this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
         // 
         // authorsComboBox
         // 
         this.authorsComboBox.FormattingEnabled = true;
         this.authorsComboBox.Location = new System.Drawing.Point(6, 109);
         this.authorsComboBox.Name = "authorsComboBox";
         this.authorsComboBox.Size = new System.Drawing.Size(214, 21);
         this.authorsComboBox.TabIndex = 24;
         // 
         // authorsNameListBox
         // 
         this.authorsNameListBox.FormattingEnabled = true;
         this.authorsNameListBox.Location = new System.Drawing.Point(6, 21);
         this.authorsNameListBox.Name = "authorsNameListBox";
         this.authorsNameListBox.Size = new System.Drawing.Size(268, 82);
         this.authorsNameListBox.TabIndex = 23;
         // 
         // mangaGenresGroupBox
         // 
         this.mangaGenresGroupBox.Controls.Add(this.genreNameListBox);
         this.mangaGenresGroupBox.Controls.Add(this.removeGenreButton);
         this.mangaGenresGroupBox.Controls.Add(this.addGenreButton);
         this.mangaGenresGroupBox.Controls.Add(this.genreNameComboBox);
         this.mangaGenresGroupBox.Enabled = false;
         this.mangaGenresGroupBox.Location = new System.Drawing.Point(297, 296);
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
         this.removeGenreButton.Image = global::mangaDatabaseEditor.Properties.Resources.minus;
         this.removeGenreButton.Location = new System.Drawing.Point(133, 121);
         this.removeGenreButton.Name = "removeGenreButton";
         this.removeGenreButton.Size = new System.Drawing.Size(21, 21);
         this.removeGenreButton.TabIndex = 28;
         this.removeGenreButton.UseVisualStyleBackColor = true;
         this.removeGenreButton.Click += new System.EventHandler(this.removeGenreButton_Click);
         // 
         // addGenreButton
         // 
         this.addGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.addGenreButton.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
         this.addGenreButton.Location = new System.Drawing.Point(105, 122);
         this.addGenreButton.Name = "addGenreButton";
         this.addGenreButton.Size = new System.Drawing.Size(21, 21);
         this.addGenreButton.TabIndex = 27;
         this.addGenreButton.UseVisualStyleBackColor = true;
         this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
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
         this.publicationStatusGroupbox.Location = new System.Drawing.Point(297, 455);
         this.publicationStatusGroupbox.Name = "publicationStatusGroupbox";
         this.publicationStatusGroupbox.Size = new System.Drawing.Size(160, 55);
         this.publicationStatusGroupbox.TabIndex = 27;
         this.publicationStatusGroupbox.TabStop = false;
         this.publicationStatusGroupbox.Text = "Publication Status";
         // 
         // mangaStatusComboBox
         // 
         this.mangaStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mangaInfoBindingSource, "mangaStatus", true));
         this.mangaStatusComboBox.FormattingEnabled = true;
         this.mangaStatusComboBox.Items.AddRange(new object[] {
            "Ongoing",
            "Hiatus",
            "Complete"});
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
         this.searchMangaGroupBox.Location = new System.Drawing.Point(297, 516);
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
         this.searchMangaButton.Image = global::mangaDatabaseEditor.Properties.Resources.magnifier;
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
         this.buttonImageLoad.Location = new System.Drawing.Point(297, 267);
         this.buttonImageLoad.Name = "buttonImageLoad";
         this.buttonImageLoad.Size = new System.Drawing.Size(160, 23);
         this.buttonImageLoad.TabIndex = 19;
         this.buttonImageLoad.Text = "Add Cover Image";
         this.buttonImageLoad.UseVisualStyleBackColor = true;
         this.buttonImageLoad.Click += new System.EventHandler(this.buttonImageLoad_Click);
         // 
         // mangaCoverPictureBox
         // 
         this.mangaCoverPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.mangaInfoBindingSource, "mangaCover", true));
         this.mangaCoverPictureBox.Location = new System.Drawing.Point(297, 31);
         this.mangaCoverPictureBox.Name = "mangaCoverPictureBox";
         this.mangaCoverPictureBox.Size = new System.Drawing.Size(160, 230);
         this.mangaCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.mangaCoverPictureBox.TabIndex = 12;
         this.mangaCoverPictureBox.TabStop = false;
         // 
         // mangaInfoBindingNavigator
         // 
         this.mangaInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.mangaInfoBindingNavigator.BackColor = System.Drawing.Color.White;
         this.mangaInfoBindingNavigator.BindingSource = this.mangaInfoBindingSource;
         this.mangaInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.mangaInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.mangaInfoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.mangaInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mangaInfoBindingNavigatorSaveItem});
         this.mangaInfoBindingNavigator.Location = new System.Drawing.Point(3, 3);
         this.mangaInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.mangaInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.mangaInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.mangaInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.mangaInfoBindingNavigator.Name = "mangaInfoBindingNavigator";
         this.mangaInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.mangaInfoBindingNavigator.Size = new System.Drawing.Size(470, 25);
         this.mangaInfoBindingNavigator.TabIndex = 1;
         this.mangaInfoBindingNavigator.Text = "Manga Binding Navigator";
         // 
         // bindingNavigatorAddNewItem
         // 
         this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorAddNewItem.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
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
         this.bindingNavigatorDeleteItem.Image = global::mangaDatabaseEditor.Properties.Resources.cross_script;
         this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
         this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorDeleteItem.Text = "Delete";
         // 
         // bindingNavigatorMoveFirstItem
         // 
         this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveFirstItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_stop_180;
         this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
         this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // bindingNavigatorMovePreviousItem
         // 
         this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMovePreviousItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_180;
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
         this.bindingNavigatorMoveNextItem.Image = global::mangaDatabaseEditor.Properties.Resources.control;
         this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
         this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.bindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // bindingNavigatorMoveLastItem
         // 
         this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.bindingNavigatorMoveLastItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_stop;
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
         // mangaInfoBindingNavigatorSaveItem
         // 
         this.mangaInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.mangaInfoBindingNavigatorSaveItem.Image = global::mangaDatabaseEditor.Properties.Resources.disk__pencil;
         this.mangaInfoBindingNavigatorSaveItem.Name = "mangaInfoBindingNavigatorSaveItem";
         this.mangaInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.mangaInfoBindingNavigatorSaveItem.Text = "Save Data";
         this.mangaInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.mangaInfoBindingNavigatorSaveItem_Click);
         // 
         // tabAuthor
         // 
         this.tabAuthor.AutoScroll = true;
         this.tabAuthor.Controls.Add(this.searchByAuthorNameGroupBox);
         this.tabAuthor.Controls.Add(this.authorWebsiteGroupBox);
         this.tabAuthor.Controls.Add(this.authorDateOFBirthGroupBox);
         this.tabAuthor.Controls.Add(this.authorCountryGroupBox);
         this.tabAuthor.Controls.Add(this.authorInfoGroupBox);
         this.tabAuthor.Controls.Add(this.authorTableBindingNavigator);
         this.tabAuthor.Location = new System.Drawing.Point(4, 22);
         this.tabAuthor.Name = "tabAuthor";
         this.tabAuthor.Padding = new System.Windows.Forms.Padding(3);
         this.tabAuthor.Size = new System.Drawing.Size(476, 620);
         this.tabAuthor.TabIndex = 1;
         this.tabAuthor.Text = "Author";
         this.tabAuthor.UseVisualStyleBackColor = true;
         // 
         // searchByAuthorNameGroupBox
         // 
         this.searchByAuthorNameGroupBox.Controls.Add(this.browseAllAuthorEntriesButton);
         this.searchByAuthorNameGroupBox.Controls.Add(this.authorSearchButton);
         this.searchByAuthorNameGroupBox.Controls.Add(this.authorSearchTextBox);
         this.searchByAuthorNameGroupBox.Location = new System.Drawing.Point(297, 31);
         this.searchByAuthorNameGroupBox.Name = "searchByAuthorNameGroupBox";
         this.searchByAuthorNameGroupBox.Size = new System.Drawing.Size(160, 76);
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
         this.authorSearchButton.Image = global::mangaDatabaseEditor.Properties.Resources.magnifier;
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
         this.authorWebsiteGroupBox.Location = new System.Drawing.Point(8, 231);
         this.authorWebsiteGroupBox.Name = "authorWebsiteGroupBox";
         this.authorWebsiteGroupBox.Size = new System.Drawing.Size(449, 53);
         this.authorWebsiteGroupBox.TabIndex = 14;
         this.authorWebsiteGroupBox.TabStop = false;
         this.authorWebsiteGroupBox.Text = "Website";
         // 
         // authorWebsiteTextBox
         // 
         this.authorWebsiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorTableBindingSource, "authorWebsite", true));
         this.authorWebsiteTextBox.Location = new System.Drawing.Point(6, 21);
         this.authorWebsiteTextBox.Name = "authorWebsiteTextBox";
         this.authorWebsiteTextBox.Size = new System.Drawing.Size(437, 22);
         this.authorWebsiteTextBox.TabIndex = 9;
         // 
         // authorTableBindingSource
         // 
         this.authorTableBindingSource.DataSource = typeof(mangaDatabaseEditor.authorTable);
         // 
         // authorDateOFBirthGroupBox
         // 
         this.authorDateOFBirthGroupBox.Controls.Add(this.authorDateOfBirthDateTimePicker);
         this.authorDateOFBirthGroupBox.Location = new System.Drawing.Point(8, 171);
         this.authorDateOFBirthGroupBox.Name = "authorDateOFBirthGroupBox";
         this.authorDateOFBirthGroupBox.Size = new System.Drawing.Size(449, 54);
         this.authorDateOFBirthGroupBox.TabIndex = 13;
         this.authorDateOFBirthGroupBox.TabStop = false;
         this.authorDateOFBirthGroupBox.Text = "Birthday";
         // 
         // authorDateOfBirthDateTimePicker
         // 
         this.authorDateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorTableBindingSource, "authorDateOfBirth", true));
         this.authorDateOfBirthDateTimePicker.Location = new System.Drawing.Point(6, 21);
         this.authorDateOfBirthDateTimePicker.Name = "authorDateOfBirthDateTimePicker";
         this.authorDateOfBirthDateTimePicker.Size = new System.Drawing.Size(437, 22);
         this.authorDateOfBirthDateTimePicker.TabIndex = 7;
         // 
         // authorCountryGroupBox
         // 
         this.authorCountryGroupBox.Controls.Add(this.authorCountryOfOriginTextBox);
         this.authorCountryGroupBox.Location = new System.Drawing.Point(8, 113);
         this.authorCountryGroupBox.Name = "authorCountryGroupBox";
         this.authorCountryGroupBox.Size = new System.Drawing.Size(449, 52);
         this.authorCountryGroupBox.TabIndex = 12;
         this.authorCountryGroupBox.TabStop = false;
         this.authorCountryGroupBox.Text = "Country";
         // 
         // authorCountryOfOriginTextBox
         // 
         this.authorCountryOfOriginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorTableBindingSource, "authorCountryOfOrigin", true));
         this.authorCountryOfOriginTextBox.Location = new System.Drawing.Point(6, 21);
         this.authorCountryOfOriginTextBox.Name = "authorCountryOfOriginTextBox";
         this.authorCountryOfOriginTextBox.Size = new System.Drawing.Size(437, 22);
         this.authorCountryOfOriginTextBox.TabIndex = 5;
         // 
         // authorInfoGroupBox
         // 
         this.authorInfoGroupBox.Controls.Add(this.authorFullNameTextBox);
         this.authorInfoGroupBox.Controls.Add(authorFullNameLabel1);
         this.authorInfoGroupBox.Controls.Add(authorIDLabel);
         this.authorInfoGroupBox.Controls.Add(this.authorIDTextBox);
         this.authorInfoGroupBox.Location = new System.Drawing.Point(8, 31);
         this.authorInfoGroupBox.Name = "authorInfoGroupBox";
         this.authorInfoGroupBox.Size = new System.Drawing.Size(283, 76);
         this.authorInfoGroupBox.TabIndex = 11;
         this.authorInfoGroupBox.TabStop = false;
         this.authorInfoGroupBox.Text = "Author Info";
         // 
         // authorFullNameTextBox
         // 
         this.authorFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorTableBindingSource, "authorFullName", true));
         this.authorFullNameTextBox.Location = new System.Drawing.Point(6, 48);
         this.authorFullNameTextBox.Name = "authorFullNameTextBox";
         this.authorFullNameTextBox.Size = new System.Drawing.Size(268, 22);
         this.authorFullNameTextBox.TabIndex = 3;
         // 
         // authorIDTextBox
         // 
         this.authorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorTableBindingSource, "authorID", true));
         this.authorIDTextBox.Location = new System.Drawing.Point(159, 20);
         this.authorIDTextBox.Name = "authorIDTextBox";
         this.authorIDTextBox.ReadOnly = true;
         this.authorIDTextBox.Size = new System.Drawing.Size(115, 22);
         this.authorIDTextBox.TabIndex = 1;
         // 
         // authorTableBindingNavigator
         // 
         this.authorTableBindingNavigator.AddNewItem = this.authorTableBindingNavigatorAddNewItem;
         this.authorTableBindingNavigator.BackColor = System.Drawing.Color.White;
         this.authorTableBindingNavigator.BindingSource = this.authorTableBindingSource;
         this.authorTableBindingNavigator.CountItem = this.authorTableBindingNavigatorCountItem;
         this.authorTableBindingNavigator.DeleteItem = this.authorTableBindingNavigatorDeleteItem;
         this.authorTableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.authorTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorTableBindingNavigatorMoveFirstItem,
            this.authorTableBindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator3,
            this.authorTableBindingNavigatorPositionItem,
            this.authorTableBindingNavigatorCountItem,
            this.bindingNavigatorSeparator4,
            this.authorTableBindingNavigatorMoveNextItem,
            this.authorTableBindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator5,
            this.authorTableBindingNavigatorAddNewItem,
            this.authorTableBindingNavigatorDeleteItem,
            this.authorTableBindingNavigatorSaveItem});
         this.authorTableBindingNavigator.Location = new System.Drawing.Point(3, 3);
         this.authorTableBindingNavigator.MoveFirstItem = this.authorTableBindingNavigatorMoveFirstItem;
         this.authorTableBindingNavigator.MoveLastItem = this.authorTableBindingNavigatorMoveLastItem;
         this.authorTableBindingNavigator.MoveNextItem = this.authorTableBindingNavigatorMoveNextItem;
         this.authorTableBindingNavigator.MovePreviousItem = this.authorTableBindingNavigatorMovePreviousItem;
         this.authorTableBindingNavigator.Name = "authorTableBindingNavigator";
         this.authorTableBindingNavigator.PositionItem = this.authorTableBindingNavigatorPositionItem;
         this.authorTableBindingNavigator.Size = new System.Drawing.Size(470, 25);
         this.authorTableBindingNavigator.TabIndex = 10;
         this.authorTableBindingNavigator.Text = "Author Binding Navigator";
         this.authorTableBindingNavigator.Click += new System.EventHandler(this.authorTableBindingNavigatorSaveItem_Click);
         // 
         // authorTableBindingNavigatorAddNewItem
         // 
         this.authorTableBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorAddNewItem.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
         this.authorTableBindingNavigatorAddNewItem.Name = "authorTableBindingNavigatorAddNewItem";
         this.authorTableBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.authorTableBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorAddNewItem.Text = "Add new";
         // 
         // authorTableBindingNavigatorCountItem
         // 
         this.authorTableBindingNavigatorCountItem.Name = "authorTableBindingNavigatorCountItem";
         this.authorTableBindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.authorTableBindingNavigatorCountItem.Text = "of {0}";
         this.authorTableBindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // authorTableBindingNavigatorDeleteItem
         // 
         this.authorTableBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorDeleteItem.Image = global::mangaDatabaseEditor.Properties.Resources.cross_script;
         this.authorTableBindingNavigatorDeleteItem.Name = "authorTableBindingNavigatorDeleteItem";
         this.authorTableBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.authorTableBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorDeleteItem.Text = "Delete";
         // 
         // authorTableBindingNavigatorMoveFirstItem
         // 
         this.authorTableBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorMoveFirstItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_stop_180;
         this.authorTableBindingNavigatorMoveFirstItem.Name = "authorTableBindingNavigatorMoveFirstItem";
         this.authorTableBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.authorTableBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // authorTableBindingNavigatorMovePreviousItem
         // 
         this.authorTableBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorMovePreviousItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_180;
         this.authorTableBindingNavigatorMovePreviousItem.Name = "authorTableBindingNavigatorMovePreviousItem";
         this.authorTableBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.authorTableBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator3
         // 
         this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
         this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
         // 
         // authorTableBindingNavigatorPositionItem
         // 
         this.authorTableBindingNavigatorPositionItem.AccessibleName = "Position";
         this.authorTableBindingNavigatorPositionItem.AutoSize = false;
         this.authorTableBindingNavigatorPositionItem.Name = "authorTableBindingNavigatorPositionItem";
         this.authorTableBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.authorTableBindingNavigatorPositionItem.Text = "0";
         this.authorTableBindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator4
         // 
         this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
         this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
         // 
         // authorTableBindingNavigatorMoveNextItem
         // 
         this.authorTableBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorMoveNextItem.Image = global::mangaDatabaseEditor.Properties.Resources.control;
         this.authorTableBindingNavigatorMoveNextItem.Name = "authorTableBindingNavigatorMoveNextItem";
         this.authorTableBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.authorTableBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // authorTableBindingNavigatorMoveLastItem
         // 
         this.authorTableBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorMoveLastItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_stop;
         this.authorTableBindingNavigatorMoveLastItem.Name = "authorTableBindingNavigatorMoveLastItem";
         this.authorTableBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.authorTableBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator5
         // 
         this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
         this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
         // 
         // authorTableBindingNavigatorSaveItem
         // 
         this.authorTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.authorTableBindingNavigatorSaveItem.Image = global::mangaDatabaseEditor.Properties.Resources.disk__pencil;
         this.authorTableBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.authorTableBindingNavigatorSaveItem.Name = "authorTableBindingNavigatorSaveItem";
         this.authorTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.authorTableBindingNavigatorSaveItem.Text = "authorSaveToolStripButton";
         this.authorTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorTableBindingNavigatorSaveItem_Click);
         // 
         // tabPublisher
         // 
         this.tabPublisher.Controls.Add(this.publisherNoteGroupBox);
         this.tabPublisher.Controls.Add(this.publisherWebsiteGroupBox);
         this.tabPublisher.Controls.Add(this.publisherCountryGroupBox);
         this.tabPublisher.Controls.Add(this.searchPublisherGroupBox);
         this.tabPublisher.Controls.Add(this.publisherInfoGroupBox);
         this.tabPublisher.Controls.Add(this.publisherBindingNavigator);
         this.tabPublisher.Location = new System.Drawing.Point(4, 22);
         this.tabPublisher.Name = "tabPublisher";
         this.tabPublisher.Padding = new System.Windows.Forms.Padding(3);
         this.tabPublisher.Size = new System.Drawing.Size(476, 620);
         this.tabPublisher.TabIndex = 2;
         this.tabPublisher.Text = "Publisher";
         this.tabPublisher.UseVisualStyleBackColor = true;
         // 
         // publisherNoteGroupBox
         // 
         this.publisherNoteGroupBox.Controls.Add(this.publisherNoteTextBox);
         this.publisherNoteGroupBox.Location = new System.Drawing.Point(8, 232);
         this.publisherNoteGroupBox.Name = "publisherNoteGroupBox";
         this.publisherNoteGroupBox.Size = new System.Drawing.Size(449, 111);
         this.publisherNoteGroupBox.TabIndex = 31;
         this.publisherNoteGroupBox.TabStop = false;
         this.publisherNoteGroupBox.Text = "Note";
         // 
         // publisherNoteTextBox
         // 
         this.publisherNoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.publisherNoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherInfoBindingSource, "publisherNote", true));
         this.publisherNoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.publisherNoteTextBox.Location = new System.Drawing.Point(3, 16);
         this.publisherNoteTextBox.Multiline = true;
         this.publisherNoteTextBox.Name = "publisherNoteTextBox";
         this.publisherNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.publisherNoteTextBox.Size = new System.Drawing.Size(443, 92);
         this.publisherNoteTextBox.TabIndex = 9;
         // 
         // publisherInfoBindingSource
         // 
         this.publisherInfoBindingSource.DataSource = typeof(mangaDatabaseEditor.publisherInfo);
         // 
         // publisherWebsiteGroupBox
         // 
         this.publisherWebsiteGroupBox.Controls.Add(this.publisherWebsiteTextBox);
         this.publisherWebsiteGroupBox.Location = new System.Drawing.Point(8, 174);
         this.publisherWebsiteGroupBox.Name = "publisherWebsiteGroupBox";
         this.publisherWebsiteGroupBox.Size = new System.Drawing.Size(449, 52);
         this.publisherWebsiteGroupBox.TabIndex = 30;
         this.publisherWebsiteGroupBox.TabStop = false;
         this.publisherWebsiteGroupBox.Text = "Website";
         // 
         // publisherWebsiteTextBox
         // 
         this.publisherWebsiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherInfoBindingSource, "publisherWebsite", true));
         this.publisherWebsiteTextBox.Location = new System.Drawing.Point(6, 21);
         this.publisherWebsiteTextBox.Name = "publisherWebsiteTextBox";
         this.publisherWebsiteTextBox.Size = new System.Drawing.Size(437, 22);
         this.publisherWebsiteTextBox.TabIndex = 7;
         // 
         // publisherCountryGroupBox
         // 
         this.publisherCountryGroupBox.Controls.Add(this.publisherCountryTextBox);
         this.publisherCountryGroupBox.Location = new System.Drawing.Point(8, 113);
         this.publisherCountryGroupBox.Name = "publisherCountryGroupBox";
         this.publisherCountryGroupBox.Size = new System.Drawing.Size(449, 55);
         this.publisherCountryGroupBox.TabIndex = 29;
         this.publisherCountryGroupBox.TabStop = false;
         this.publisherCountryGroupBox.Text = "Country";
         // 
         // publisherCountryTextBox
         // 
         this.publisherCountryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherInfoBindingSource, "publisherCountry", true));
         this.publisherCountryTextBox.Location = new System.Drawing.Point(6, 21);
         this.publisherCountryTextBox.Name = "publisherCountryTextBox";
         this.publisherCountryTextBox.Size = new System.Drawing.Size(437, 22);
         this.publisherCountryTextBox.TabIndex = 5;
         // 
         // searchPublisherGroupBox
         // 
         this.searchPublisherGroupBox.Controls.Add(this.browseAllPublisherEntriesButton);
         this.searchPublisherGroupBox.Controls.Add(this.searchPublisherButton);
         this.searchPublisherGroupBox.Controls.Add(this.searchPublisherTextBox);
         this.searchPublisherGroupBox.Location = new System.Drawing.Point(297, 31);
         this.searchPublisherGroupBox.Name = "searchPublisherGroupBox";
         this.searchPublisherGroupBox.Size = new System.Drawing.Size(160, 76);
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
         this.searchPublisherButton.Image = global::mangaDatabaseEditor.Properties.Resources.magnifier;
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
         this.publisherInfoGroupBox.Controls.Add(this.publisherNameTextBox);
         this.publisherInfoGroupBox.Controls.Add(this.publisherIDTextBox);
         this.publisherInfoGroupBox.Controls.Add(publisherIDLabel);
         this.publisherInfoGroupBox.Controls.Add(publisherNameLabel1);
         this.publisherInfoGroupBox.Location = new System.Drawing.Point(8, 31);
         this.publisherInfoGroupBox.Name = "publisherInfoGroupBox";
         this.publisherInfoGroupBox.Size = new System.Drawing.Size(283, 76);
         this.publisherInfoGroupBox.TabIndex = 12;
         this.publisherInfoGroupBox.TabStop = false;
         this.publisherInfoGroupBox.Text = "Publisher Info";
         // 
         // publisherNameTextBox
         // 
         this.publisherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherInfoBindingSource, "publisherName", true));
         this.publisherNameTextBox.Location = new System.Drawing.Point(6, 48);
         this.publisherNameTextBox.Name = "publisherNameTextBox";
         this.publisherNameTextBox.Size = new System.Drawing.Size(268, 22);
         this.publisherNameTextBox.TabIndex = 3;
         // 
         // publisherIDTextBox
         // 
         this.publisherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publisherInfoBindingSource, "publisherID", true));
         this.publisherIDTextBox.Location = new System.Drawing.Point(159, 20);
         this.publisherIDTextBox.Name = "publisherIDTextBox";
         this.publisherIDTextBox.ReadOnly = true;
         this.publisherIDTextBox.Size = new System.Drawing.Size(115, 22);
         this.publisherIDTextBox.TabIndex = 1;
         // 
         // publisherBindingNavigator
         // 
         this.publisherBindingNavigator.AddNewItem = this.publisherInfoBindingNavigatorAddNewItem;
         this.publisherBindingNavigator.BackColor = System.Drawing.Color.White;
         this.publisherBindingNavigator.BindingSource = this.publisherInfoBindingSource;
         this.publisherBindingNavigator.CountItem = this.publisherInfoBindingNavigatorCountItem;
         this.publisherBindingNavigator.DeleteItem = this.publisherInfoBindingNavigatorDeleteItem;
         this.publisherBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
         this.publisherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publisherInfoBindingNavigatorMoveFirstItem,
            this.publisherInfoBindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator6,
            this.publisherInfoBindingNavigatorPositionItem,
            this.publisherInfoBindingNavigatorCountItem,
            this.bindingNavigatorSeparator7,
            this.publisherInfoBindingNavigatorMoveNextItem,
            this.publisherInfoBindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator8,
            this.publisherInfoBindingNavigatorAddNewItem,
            this.publisherInfoBindingNavigatorDeleteItem,
            this.publisherInfoBindingNavigatorSaveItem});
         this.publisherBindingNavigator.Location = new System.Drawing.Point(3, 3);
         this.publisherBindingNavigator.MoveFirstItem = this.publisherInfoBindingNavigatorMoveFirstItem;
         this.publisherBindingNavigator.MoveLastItem = this.publisherInfoBindingNavigatorMoveLastItem;
         this.publisherBindingNavigator.MoveNextItem = this.publisherInfoBindingNavigatorMoveNextItem;
         this.publisherBindingNavigator.MovePreviousItem = this.publisherInfoBindingNavigatorMovePreviousItem;
         this.publisherBindingNavigator.Name = "publisherBindingNavigator";
         this.publisherBindingNavigator.PositionItem = this.publisherInfoBindingNavigatorPositionItem;
         this.publisherBindingNavigator.Size = new System.Drawing.Size(470, 25);
         this.publisherBindingNavigator.TabIndex = 10;
         this.publisherBindingNavigator.Text = "Publisher Navigator";
         // 
         // publisherInfoBindingNavigatorAddNewItem
         // 
         this.publisherInfoBindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorAddNewItem.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
         this.publisherInfoBindingNavigatorAddNewItem.Name = "publisherInfoBindingNavigatorAddNewItem";
         this.publisherInfoBindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
         this.publisherInfoBindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorAddNewItem.Text = "Add new";
         // 
         // publisherInfoBindingNavigatorCountItem
         // 
         this.publisherInfoBindingNavigatorCountItem.Name = "publisherInfoBindingNavigatorCountItem";
         this.publisherInfoBindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
         this.publisherInfoBindingNavigatorCountItem.Text = "of {0}";
         this.publisherInfoBindingNavigatorCountItem.ToolTipText = "Total number of items";
         // 
         // publisherInfoBindingNavigatorDeleteItem
         // 
         this.publisherInfoBindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorDeleteItem.Image = global::mangaDatabaseEditor.Properties.Resources.cross_script;
         this.publisherInfoBindingNavigatorDeleteItem.Name = "publisherInfoBindingNavigatorDeleteItem";
         this.publisherInfoBindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
         this.publisherInfoBindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorDeleteItem.Text = "Delete";
         // 
         // publisherInfoBindingNavigatorMoveFirstItem
         // 
         this.publisherInfoBindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorMoveFirstItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_stop_180;
         this.publisherInfoBindingNavigatorMoveFirstItem.Name = "publisherInfoBindingNavigatorMoveFirstItem";
         this.publisherInfoBindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
         this.publisherInfoBindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorMoveFirstItem.Text = "Move first";
         // 
         // publisherInfoBindingNavigatorMovePreviousItem
         // 
         this.publisherInfoBindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorMovePreviousItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_180;
         this.publisherInfoBindingNavigatorMovePreviousItem.Name = "publisherInfoBindingNavigatorMovePreviousItem";
         this.publisherInfoBindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
         this.publisherInfoBindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorMovePreviousItem.Text = "Move previous";
         // 
         // bindingNavigatorSeparator6
         // 
         this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
         this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
         // 
         // publisherInfoBindingNavigatorPositionItem
         // 
         this.publisherInfoBindingNavigatorPositionItem.AccessibleName = "Position";
         this.publisherInfoBindingNavigatorPositionItem.AutoSize = false;
         this.publisherInfoBindingNavigatorPositionItem.Name = "publisherInfoBindingNavigatorPositionItem";
         this.publisherInfoBindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
         this.publisherInfoBindingNavigatorPositionItem.Text = "0";
         this.publisherInfoBindingNavigatorPositionItem.ToolTipText = "Current position";
         // 
         // bindingNavigatorSeparator7
         // 
         this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
         this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
         // 
         // publisherInfoBindingNavigatorMoveNextItem
         // 
         this.publisherInfoBindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorMoveNextItem.Image = global::mangaDatabaseEditor.Properties.Resources.control;
         this.publisherInfoBindingNavigatorMoveNextItem.Name = "publisherInfoBindingNavigatorMoveNextItem";
         this.publisherInfoBindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
         this.publisherInfoBindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorMoveNextItem.Text = "Move next";
         // 
         // publisherInfoBindingNavigatorMoveLastItem
         // 
         this.publisherInfoBindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorMoveLastItem.Image = global::mangaDatabaseEditor.Properties.Resources.control_stop;
         this.publisherInfoBindingNavigatorMoveLastItem.Name = "publisherInfoBindingNavigatorMoveLastItem";
         this.publisherInfoBindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
         this.publisherInfoBindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorMoveLastItem.Text = "Move last";
         // 
         // bindingNavigatorSeparator8
         // 
         this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
         this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
         // 
         // publisherInfoBindingNavigatorSaveItem
         // 
         this.publisherInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.publisherInfoBindingNavigatorSaveItem.Image = global::mangaDatabaseEditor.Properties.Resources.disk__pencil;
         this.publisherInfoBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.publisherInfoBindingNavigatorSaveItem.Name = "publisherInfoBindingNavigatorSaveItem";
         this.publisherInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
         this.publisherInfoBindingNavigatorSaveItem.Text = "toolStripButton1";
         this.publisherInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.publisherInfoBindingNavigatorSaveItem_Click);
         // 
         // genreInfoBindingSource
         // 
         this.genreInfoBindingSource.DataSource = typeof(mangaDatabaseEditor.genreInfo);
         // 
         // mangaAuthorsBindingSource
         // 
         this.mangaAuthorsBindingSource.DataMember = "mangaAuthors";
         this.mangaAuthorsBindingSource.DataSource = this.mangaInfoBindingSource;
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
         this.genresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.genresToolStripMenuItem.Text = "Genres";
         this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
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
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // openImageFileDialog
         // 
         this.openImageFileDialog.Filter = "JPG files|*.jpg|PNG files|.*png|All files|.*.";
         // 
         // addAuthorContextMenu
         // 
         this.addAuthorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
         this.addAuthorContextMenu.Name = "addAuthorContextMenu";
         this.addAuthorContextMenu.Size = new System.Drawing.Size(118, 48);
         // 
         // addToolStripMenuItem
         // 
         this.addToolStripMenuItem.Name = "addToolStripMenuItem";
         this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
         this.addToolStripMenuItem.Text = "Add";
         // 
         // removeToolStripMenuItem
         // 
         this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
         this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
         this.removeToolStripMenuItem.Text = "Remove";
         // 
         // mangaGenresBindingSource
         // 
         this.mangaGenresBindingSource.DataMember = "mangaGenres";
         this.mangaGenresBindingSource.DataSource = this.mangaInfoBindingSource;
         // 
         // mangaInfoBindingSource1
         // 
         this.mangaInfoBindingSource1.DataSource = typeof(mangaDatabaseEditor.mangaInfo);
         // 
         // exportDatabaseToolStripMenuItem
         // 
         this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
         this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.exportDatabaseToolStripMenuItem.Text = "Export Database";
         this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.exportDatabaseToolStripMenuItem_Click);
         // 
         // importDatabaseToolStripMenuItem
         // 
         this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
         this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.importDatabaseToolStripMenuItem.Text = "Import Database";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
         // 
         // quitToolStripMenuItem
         // 
         this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
         this.quitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
         this.quitToolStripMenuItem.Text = "Quit";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 670);
         this.Controls.Add(this.tabControl);
         this.Controls.Add(this.mainMenuStrip);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.MainMenuStrip = this.mainMenuStrip;
         this.Name = "MainForm";
         this.Text = "Manga Database Editor";
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.tabControl.ResumeLayout(false);
         this.tabManga.ResumeLayout(false);
         this.tabManga.PerformLayout();
         this.dateOfPublicationGroupBox.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.mangaInfoBindingSource)).EndInit();
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
         ((System.ComponentModel.ISupportInitialize)(this.mangaInfoBindingNavigator)).EndInit();
         this.mangaInfoBindingNavigator.ResumeLayout(false);
         this.mangaInfoBindingNavigator.PerformLayout();
         this.tabAuthor.ResumeLayout(false);
         this.tabAuthor.PerformLayout();
         this.searchByAuthorNameGroupBox.ResumeLayout(false);
         this.searchByAuthorNameGroupBox.PerformLayout();
         this.authorWebsiteGroupBox.ResumeLayout(false);
         this.authorWebsiteGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorTableBindingSource)).EndInit();
         this.authorDateOFBirthGroupBox.ResumeLayout(false);
         this.authorCountryGroupBox.ResumeLayout(false);
         this.authorCountryGroupBox.PerformLayout();
         this.authorInfoGroupBox.ResumeLayout(false);
         this.authorInfoGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.authorTableBindingNavigator)).EndInit();
         this.authorTableBindingNavigator.ResumeLayout(false);
         this.authorTableBindingNavigator.PerformLayout();
         this.tabPublisher.ResumeLayout(false);
         this.tabPublisher.PerformLayout();
         this.publisherNoteGroupBox.ResumeLayout(false);
         this.publisherNoteGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.publisherInfoBindingSource)).EndInit();
         this.publisherWebsiteGroupBox.ResumeLayout(false);
         this.publisherWebsiteGroupBox.PerformLayout();
         this.publisherCountryGroupBox.ResumeLayout(false);
         this.publisherCountryGroupBox.PerformLayout();
         this.searchPublisherGroupBox.ResumeLayout(false);
         this.searchPublisherGroupBox.PerformLayout();
         this.publisherInfoGroupBox.ResumeLayout(false);
         this.publisherInfoGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.publisherBindingNavigator)).EndInit();
         this.publisherBindingNavigator.ResumeLayout(false);
         this.publisherBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.genreInfoBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaAuthorsBindingSource)).EndInit();
         this.mainMenuStrip.ResumeLayout(false);
         this.mainMenuStrip.PerformLayout();
         this.addAuthorContextMenu.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.mangaGenresBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.mangaInfoBindingSource1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabManga;
		private System.Windows.Forms.DateTimePicker dateOfPublishDateTimePicker;
		private System.Windows.Forms.BindingSource mangaInfoBindingSource;
		private System.Windows.Forms.TextBox mangaDescriptionTextBox;
		private System.Windows.Forms.ComboBox mangaStatusComboBox;
		private System.Windows.Forms.PictureBox mangaCoverPictureBox;
		private System.Windows.Forms.BindingSource mangaAuthorsBindingSource;
		private System.Windows.Forms.BindingSource mangaGenresBindingSource;
		private System.Windows.Forms.TextBox mangaTitleTextBox;
		private System.Windows.Forms.BindingNavigator mangaInfoBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton mangaInfoBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox mangaIDTextBox;
		private System.Windows.Forms.TabPage tabAuthor;
		private System.Windows.Forms.TabPage tabPublisher;
		private System.Windows.Forms.Button buttonImageLoad;
		private System.Windows.Forms.BindingNavigator authorTableBindingNavigator;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorAddNewItem;
		private System.Windows.Forms.BindingSource authorTableBindingSource;
		private System.Windows.Forms.ToolStripLabel authorTableBindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
		private System.Windows.Forms.ToolStripTextBox authorTableBindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
		private System.Windows.Forms.ToolStripButton authorTableBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox authorWebsiteTextBox;
		private System.Windows.Forms.DateTimePicker authorDateOfBirthDateTimePicker;
		private System.Windows.Forms.TextBox authorCountryOfOriginTextBox;
		private System.Windows.Forms.TextBox authorFullNameTextBox;
		private System.Windows.Forms.TextBox authorIDTextBox;
		private System.Windows.Forms.TextBox publisherNoteTextBox;
		private System.Windows.Forms.BindingSource publisherInfoBindingSource;
		private System.Windows.Forms.TextBox publisherWebsiteTextBox;
		private System.Windows.Forms.TextBox publisherCountryTextBox;
		private System.Windows.Forms.TextBox publisherNameTextBox;
		private System.Windows.Forms.TextBox publisherIDTextBox;
		private System.Windows.Forms.BindingNavigator publisherBindingNavigator;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel publisherInfoBindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
		private System.Windows.Forms.ToolStripTextBox publisherInfoBindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
		private System.Windows.Forms.ToolStripButton publisherInfoBindingNavigatorSaveItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openImageFileDialog;
		private System.Windows.Forms.TextBox publisherNameTextBox1;
		private System.Windows.Forms.ListBox authorsNameListBox;
		private System.Windows.Forms.GroupBox publicationStatusGroupbox;
		private System.Windows.Forms.GroupBox searchMangaGroupBox;
		private System.Windows.Forms.Button browseAllMangaEntriesbutton;
		private System.Windows.Forms.Button searchMangaButton;
		private System.Windows.Forms.TextBox searchMangaTextBox;
		private System.Windows.Forms.ContextMenuStrip addAuthorContextMenu;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.GroupBox mangaGenresGroupBox;
		private System.Windows.Forms.Button removeGenreButton;
		private System.Windows.Forms.Button addGenreButton;
		private System.Windows.Forms.ComboBox genreNameComboBox;
		private System.Windows.Forms.BindingSource genreInfoBindingSource;
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
		private System.Windows.Forms.BindingSource mangaInfoBindingSource1;
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
	}
}

