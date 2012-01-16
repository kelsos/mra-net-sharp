﻿namespace mraNet.Forms
{
    partial class ApplicationWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mangaGridTabPage = new System.Windows.Forms.TabPage();
            this.mangaListDataGridView = new System.Windows.Forms.DataGridView();
            this.wikipediaTabPage = new System.Windows.Forms.TabPage();
            this.wikiPanel = new System.Windows.Forms.Panel();
            this.browserNavBar = new System.Windows.Forms.ToolStrip();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wReloadtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mangaCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.mangaNoteGroupBox = new System.Windows.Forms.GroupBox();
            this.mangaNoteTextBox = new System.Windows.Forms.TextBox();
            this.mangaDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.mangaDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToBrowserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.justReadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayFinishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rssSubscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMangaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rssTickerGroupBox = new System.Windows.Forms.GroupBox();
            this.rssLinkLabel = new System.Windows.Forms.Label();
            this.rssDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.rssTitleLabel = new System.Windows.Forms.Label();
            this.restoreOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backupSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rssFetchingThread = new System.ComponentModel.BackgroundWorker();
            this.newsFeedTickTimer = new System.Windows.Forms.Timer(this.components);
            this.rssCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTabControl.SuspendLayout();
            this.mangaGridTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaListDataGridView)).BeginInit();
            this.wikipediaTabPage.SuspendLayout();
            this.browserNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).BeginInit();
            this.mangaNoteGroupBox.SuspendLayout();
            this.mangaDescriptionGroupBox.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.rssTickerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.mangaGridTabPage);
            this.mainTabControl.Controls.Add(this.wikipediaTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(178, 80);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(714, 452);
            this.mainTabControl.TabIndex = 0;
            // 
            // mangaGridTabPage
            // 
            this.mangaGridTabPage.Controls.Add(this.mangaListDataGridView);
            this.mangaGridTabPage.Location = new System.Drawing.Point(4, 22);
            this.mangaGridTabPage.Name = "mangaGridTabPage";
            this.mangaGridTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mangaGridTabPage.Size = new System.Drawing.Size(706, 426);
            this.mangaGridTabPage.TabIndex = 0;
            this.mangaGridTabPage.Text = "Manga List";
            this.mangaGridTabPage.UseVisualStyleBackColor = true;
            // 
            // mangaListDataGridView
            // 
            this.mangaListDataGridView.AllowUserToAddRows = false;
            this.mangaListDataGridView.AllowUserToDeleteRows = false;
            this.mangaListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mangaListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mangaListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mangaListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mangaListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.mangaListDataGridView.MultiSelect = false;
            this.mangaListDataGridView.Name = "mangaListDataGridView";
            this.mangaListDataGridView.ReadOnly = true;
            this.mangaListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mangaListDataGridView.Size = new System.Drawing.Size(700, 420);
            this.mangaListDataGridView.TabIndex = 0;
            this.mangaListDataGridView.SelectionChanged += new System.EventHandler(this.HandleMangaListDataGridViewSelectionChanged);
            // 
            // wikipediaTabPage
            // 
            this.wikipediaTabPage.Controls.Add(this.wikiPanel);
            this.wikipediaTabPage.Controls.Add(this.browserNavBar);
            this.wikipediaTabPage.Location = new System.Drawing.Point(4, 22);
            this.wikipediaTabPage.Name = "wikipediaTabPage";
            this.wikipediaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.wikipediaTabPage.Size = new System.Drawing.Size(706, 426);
            this.wikipediaTabPage.TabIndex = 1;
            this.wikipediaTabPage.Text = "Wikipedia (en)";
            this.wikipediaTabPage.UseVisualStyleBackColor = true;
            this.wikipediaTabPage.Enter += new System.EventHandler(this.HandleWikipediaTabPageEnter);
            // 
            // wikiPanel
            // 
            this.wikiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wikiPanel.Location = new System.Drawing.Point(3, 28);
            this.wikiPanel.Name = "wikiPanel";
            this.wikiPanel.Size = new System.Drawing.Size(700, 395);
            this.wikiPanel.TabIndex = 1;
            // 
            // browserNavBar
            // 
            this.browserNavBar.BackColor = System.Drawing.Color.White;
            this.browserNavBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.browserNavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripButton,
            this.forwardToolStripButton,
            this.wReloadtoolStripButton});
            this.browserNavBar.Location = new System.Drawing.Point(3, 3);
            this.browserNavBar.Name = "browserNavBar";
            this.browserNavBar.Size = new System.Drawing.Size(700, 25);
            this.browserNavBar.TabIndex = 0;
            this.browserNavBar.Text = "Navigation Bar";
            this.browserNavBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.HandleBrowserNavBarItemClicked);
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripButton.Image = global::mraNet.Properties.Resources.navigation_180;
            this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.backToolStripButton.Text = "Back";
            // 
            // forwardToolStripButton
            // 
            this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardToolStripButton.Image = global::mraNet.Properties.Resources.navigation;
            this.forwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardToolStripButton.Name = "forwardToolStripButton";
            this.forwardToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.forwardToolStripButton.Text = "Forward";
            // 
            // wReloadtoolStripButton
            // 
            this.wReloadtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wReloadtoolStripButton.Image = global::mraNet.Properties.Resources.arrow_circle_double;
            this.wReloadtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wReloadtoolStripButton.Name = "wReloadtoolStripButton";
            this.wReloadtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.wReloadtoolStripButton.Text = "Reload";
            // 
            // mangaCoverPictureBox
            // 
            this.mangaCoverPictureBox.Location = new System.Drawing.Point(12, 82);
            this.mangaCoverPictureBox.Name = "mangaCoverPictureBox";
            this.mangaCoverPictureBox.Size = new System.Drawing.Size(160, 248);
            this.mangaCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mangaCoverPictureBox.TabIndex = 3;
            this.mangaCoverPictureBox.TabStop = false;
            // 
            // mangaNoteGroupBox
            // 
            this.mangaNoteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.mangaNoteGroupBox.Controls.Add(this.mangaNoteTextBox);
            this.mangaNoteGroupBox.Location = new System.Drawing.Point(12, 336);
            this.mangaNoteGroupBox.Name = "mangaNoteGroupBox";
            this.mangaNoteGroupBox.Size = new System.Drawing.Size(160, 196);
            this.mangaNoteGroupBox.TabIndex = 4;
            this.mangaNoteGroupBox.TabStop = false;
            this.mangaNoteGroupBox.Text = "Personal Note";
            // 
            // mangaNoteTextBox
            // 
            this.mangaNoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mangaNoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mangaNoteTextBox.Location = new System.Drawing.Point(3, 18);
            this.mangaNoteTextBox.Multiline = true;
            this.mangaNoteTextBox.Name = "mangaNoteTextBox";
            this.mangaNoteTextBox.ReadOnly = true;
            this.mangaNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mangaNoteTextBox.Size = new System.Drawing.Size(154, 175);
            this.mangaNoteTextBox.TabIndex = 1;
            // 
            // mangaDescriptionGroupBox
            // 
            this.mangaDescriptionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mangaDescriptionGroupBox.Controls.Add(this.mangaDescriptionTextBox);
            this.mangaDescriptionGroupBox.Location = new System.Drawing.Point(397, 538);
            this.mangaDescriptionGroupBox.Name = "mangaDescriptionGroupBox";
            this.mangaDescriptionGroupBox.Size = new System.Drawing.Size(495, 137);
            this.mangaDescriptionGroupBox.TabIndex = 5;
            this.mangaDescriptionGroupBox.TabStop = false;
            this.mangaDescriptionGroupBox.Text = "Manga Description";
            // 
            // mangaDescriptionTextBox
            // 
            this.mangaDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mangaDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mangaDescriptionTextBox.Location = new System.Drawing.Point(3, 18);
            this.mangaDescriptionTextBox.Multiline = true;
            this.mangaDescriptionTextBox.Name = "mangaDescriptionTextBox";
            this.mangaDescriptionTextBox.ReadOnly = true;
            this.mangaDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mangaDescriptionTextBox.Size = new System.Drawing.Size(489, 116);
            this.mangaDescriptionTextBox.TabIndex = 1;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToBrowserToolStripButton,
            this.justReadToolStripButton,
            this.reloadToolStripButton,
            this.searchToolStripTextBox});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(904, 55);
            this.mainToolStrip.TabIndex = 6;
            this.mainToolStrip.Text = "Main Toolstrip";
            // 
            // openToBrowserToolStripButton
            // 
            this.openToBrowserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToBrowserToolStripButton.Image = global::mraNet.Properties.Resources.globe_48;
            this.openToBrowserToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToBrowserToolStripButton.Name = "openToBrowserToolStripButton";
            this.openToBrowserToolStripButton.Size = new System.Drawing.Size(52, 52);
            this.openToBrowserToolStripButton.Text = "Open to Browser";
            this.openToBrowserToolStripButton.ToolTipText = "Opens the manga url to the browser.";
            this.openToBrowserToolStripButton.Click += new System.EventHandler(this.HandleOpenToBrowserToolStripButtonClick);
            // 
            // justReadToolStripButton
            // 
            this.justReadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.justReadToolStripButton.Image = global::mraNet.Properties.Resources.calendar_48;
            this.justReadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.justReadToolStripButton.Name = "justReadToolStripButton";
            this.justReadToolStripButton.Size = new System.Drawing.Size(52, 52);
            this.justReadToolStripButton.Text = "I Just read a chapter!";
            this.justReadToolStripButton.Click += new System.EventHandler(this.HandleJustReadToolStripButtonClick);
            // 
            // reloadToolStripButton
            // 
            this.reloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadToolStripButton.Image = global::mraNet.Properties.Resources.reload_48;
            this.reloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadToolStripButton.Name = "reloadToolStripButton";
            this.reloadToolStripButton.Size = new System.Drawing.Size(52, 52);
            this.reloadToolStripButton.Text = "Reload The List!";
            this.reloadToolStripButton.Click += new System.EventHandler(this.HandleReloadToolStripButtonClick);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchToolStripTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchToolStripTextBox.Margin = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(100, 55);
            this.searchToolStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleSearchToolStripTextBoxKeyUp);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(904, 24);
            this.mainMenuStrip.TabIndex = 7;
            this.mainMenuStrip.Text = "Main Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.HandleBackupToolStripMenuItemClick);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.HandleRestoreToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.HandleClearToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(110, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.HandleQuitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayFinishedToolStripMenuItem,
            this.rssSubscriptionsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // displayFinishedToolStripMenuItem
            // 
            this.displayFinishedToolStripMenuItem.CheckOnClick = true;
            this.displayFinishedToolStripMenuItem.Name = "displayFinishedToolStripMenuItem";
            this.displayFinishedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.displayFinishedToolStripMenuItem.Text = "Display Finished";
            this.displayFinishedToolStripMenuItem.Click += new System.EventHandler(this.HandleDisplayFinishedToolStripMenuItemClick);
            // 
            // rssSubscriptionsToolStripMenuItem
            // 
            this.rssSubscriptionsToolStripMenuItem.Name = "rssSubscriptionsToolStripMenuItem";
            this.rssSubscriptionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rssSubscriptionsToolStripMenuItem.Text = "Subscription Manager";
            this.rssSubscriptionsToolStripMenuItem.Click += new System.EventHandler(this.HandleNewsSubscriptionsToolStripMenuItemClick);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.addMangaToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.HandleStatisticsToolStripMenuItemClick);
            // 
            // addMangaToolStripMenuItem
            // 
            this.addMangaToolStripMenuItem.Name = "addMangaToolStripMenuItem";
            this.addMangaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.addMangaToolStripMenuItem.Text = "Add Manga";
            this.addMangaToolStripMenuItem.Click += new System.EventHandler(this.HandleAddMangaToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // changeLogToolStripMenuItem
            // 
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.changeLogToolStripMenuItem.Text = "Change Log";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(135, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.statusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 678);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(904, 22);
            this.mainStatusStrip.TabIndex = 8;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // rssTickerGroupBox
            // 
            this.rssTickerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rssTickerGroupBox.Controls.Add(this.rssLinkLabel);
            this.rssTickerGroupBox.Controls.Add(this.rssDescriptionTextBox);
            this.rssTickerGroupBox.Controls.Add(this.rssTitleLabel);
            this.rssTickerGroupBox.Location = new System.Drawing.Point(12, 538);
            this.rssTickerGroupBox.Name = "rssTickerGroupBox";
            this.rssTickerGroupBox.Size = new System.Drawing.Size(379, 137);
            this.rssTickerGroupBox.TabIndex = 9;
            this.rssTickerGroupBox.TabStop = false;
            this.rssTickerGroupBox.Text = "RSS Ticker";
            // 
            // rssLinkLabel
            // 
            this.rssLinkLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rssLinkLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rssLinkLabel.Location = new System.Drawing.Point(6, 121);
            this.rssLinkLabel.Name = "rssLinkLabel";
            this.rssLinkLabel.Size = new System.Drawing.Size(367, 13);
            this.rssLinkLabel.TabIndex = 3;
            this.rssLinkLabel.Text = "RssLink";
            this.rssLinkLabel.Click += new System.EventHandler(this.HandleNewsTickerLinkLabelClick);
            this.rssLinkLabel.MouseEnter += new System.EventHandler(this.RssLinkLabelMouseEnter);
            this.rssLinkLabel.MouseLeave += new System.EventHandler(this.RssLinkLabelMouseLeave);
            // 
            // rssDescriptionTextBox
            // 
            this.rssDescriptionTextBox.Location = new System.Drawing.Point(9, 33);
            this.rssDescriptionTextBox.Multiline = true;
            this.rssDescriptionTextBox.Name = "rssDescriptionTextBox";
            this.rssDescriptionTextBox.ReadOnly = true;
            this.rssDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rssDescriptionTextBox.Size = new System.Drawing.Size(364, 85);
            this.rssDescriptionTextBox.TabIndex = 2;
            // 
            // rssTitleLabel
            // 
            this.rssTitleLabel.Location = new System.Drawing.Point(6, 16);
            this.rssTitleLabel.Name = "rssTitleLabel";
            this.rssTitleLabel.Size = new System.Drawing.Size(367, 14);
            this.rssTitleLabel.TabIndex = 1;
            this.rssTitleLabel.Text = "RssTitle";
            // 
            // restoreOpenFileDialog
            // 
            this.restoreOpenFileDialog.Filter = "xml|*.xml";
            // 
            // backupSaveFileDialog
            // 
            this.backupSaveFileDialog.DefaultExt = "xml|*.xml";
            // 
            // rssFetchingThread
            // 
            this.rssFetchingThread.WorkerReportsProgress = true;
            this.rssFetchingThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RssFetchingThreadDoWork);
            this.rssFetchingThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RssFetchingThreadRunWorkerCompleted);
            // 
            // newsFeedTickTimer
            // 
            this.newsFeedTickTimer.Interval = 8000;
            this.newsFeedTickTimer.Tick += new System.EventHandler(this.HandleNewsTickerTimerTick);
            // 
            // rssCheckTimer
            // 
            this.rssCheckTimer.Interval = 15000;
            this.rssCheckTimer.Tick += new System.EventHandler(this.HandleNewsFeedCheckTimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 700);
            this.Controls.Add(this.rssTickerGroupBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mangaDescriptionGroupBox);
            this.Controls.Add(this.mangaNoteGroupBox);
            this.Controls.Add(this.mangaCoverPictureBox);
            this.Controls.Add(this.mainTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Manga Reading Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleMainFormFormClosing);
            this.Load += new System.EventHandler(this.HandleMainFormLoad);
            this.mainTabControl.ResumeLayout(false);
            this.mangaGridTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mangaListDataGridView)).EndInit();
            this.wikipediaTabPage.ResumeLayout(false);
            this.wikipediaTabPage.PerformLayout();
            this.browserNavBar.ResumeLayout(false);
            this.browserNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).EndInit();
            this.mangaNoteGroupBox.ResumeLayout(false);
            this.mangaNoteGroupBox.PerformLayout();
            this.mangaDescriptionGroupBox.ResumeLayout(false);
            this.mangaDescriptionGroupBox.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.rssTickerGroupBox.ResumeLayout(false);
            this.rssTickerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mangaGridTabPage;
        private System.Windows.Forms.TabPage wikipediaTabPage;
		  private System.Windows.Forms.DataGridView mangaListDataGridView;
        private System.Windows.Forms.PictureBox mangaCoverPictureBox;
        private System.Windows.Forms.GroupBox mangaNoteGroupBox;
        private System.Windows.Forms.GroupBox mangaDescriptionGroupBox;
        private System.Windows.Forms.TextBox mangaNoteTextBox;
        private System.Windows.Forms.TextBox mangaDescriptionTextBox;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
		  private System.Windows.Forms.GroupBox rssTickerGroupBox;
        private System.Windows.Forms.ToolStripButton openToBrowserToolStripButton;
        private System.Windows.Forms.ToolStripButton justReadToolStripButton;
		  private System.Windows.Forms.ToolStripButton reloadToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		  private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		  private System.Windows.Forms.ToolStrip browserNavBar;
		  private System.Windows.Forms.ToolStripButton backToolStripButton;
		  private System.Windows.Forms.ToolStripButton forwardToolStripButton;
		  private System.Windows.Forms.ToolStripButton wReloadtoolStripButton;
		  private System.Windows.Forms.Panel wikiPanel;

		  private System.Windows.Forms.Label rssLinkLabel;
		  private System.Windows.Forms.TextBox rssDescriptionTextBox;
		  private System.Windows.Forms.Label rssTitleLabel;
		  private System.Windows.Forms.OpenFileDialog restoreOpenFileDialog;
		  private System.Windows.Forms.SaveFileDialog backupSaveFileDialog;
		  private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
		  private System.ComponentModel.BackgroundWorker rssFetchingThread;
          private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		  private System.Windows.Forms.Timer newsFeedTickTimer;
		  private System.Windows.Forms.Timer rssCheckTimer;
		  private System.Windows.Forms.ToolStripMenuItem addMangaToolStripMenuItem;
		  private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
		  private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem displayFinishedToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem rssSubscriptionsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

    }
}
