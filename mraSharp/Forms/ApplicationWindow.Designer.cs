namespace mraNet.Forms
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
            this.DataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openUrlEditorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangaCoverPictureBox = new System.Windows.Forms.PictureBox();
            this.mangaDescriptionTextBox = new System.Windows.Forms.TextBox();
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
            this.GoToPreviousNewsItemButton = new System.Windows.Forms.Button();
            this.GoToNextNewsItemButton = new System.Windows.Forms.Button();
            this.rssLinkLabel = new System.Windows.Forms.Label();
            this.rssDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.rssTitleLabel = new System.Windows.Forms.Label();
            this.restoreOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backupSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rssFetchingThread = new System.ComponentModel.BackgroundWorker();
            this.newsFeedTickTimer = new System.Windows.Forms.Timer(this.components);
            this.rssCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.mangaListCombo = new System.Windows.Forms.ComboBox();
            this.mangaTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startingChapterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentChapterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastReadLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.DataGridContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.rssTickerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridContextMenu
            // 
            this.DataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openUrlEditorMenuItem});
            this.DataGridContextMenu.Name = "DataGridContextMenu";
            this.DataGridContextMenu.Size = new System.Drawing.Size(156, 26);
            // 
            // openUrlEditorMenuItem
            // 
            this.openUrlEditorMenuItem.Name = "openUrlEditorMenuItem";
            this.openUrlEditorMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openUrlEditorMenuItem.Text = "Open Url Editor";
            this.openUrlEditorMenuItem.Click += new System.EventHandler(this.HandleOpenUrlEditorMenuItemClick);
            // 
            // mangaCoverPictureBox
            // 
            this.mangaCoverPictureBox.Location = new System.Drawing.Point(12, 125);
            this.mangaCoverPictureBox.Name = "mangaCoverPictureBox";
            this.mangaCoverPictureBox.Size = new System.Drawing.Size(218, 303);
            this.mangaCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mangaCoverPictureBox.TabIndex = 3;
            this.mangaCoverPictureBox.TabStop = false;
            // 
            // mangaDescriptionTextBox
            // 
            this.mangaDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mangaDescriptionTextBox.Location = new System.Drawing.Point(243, 185);
            this.mangaDescriptionTextBox.Multiline = true;
            this.mangaDescriptionTextBox.Name = "mangaDescriptionTextBox";
            this.mangaDescriptionTextBox.ReadOnly = true;
            this.mangaDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mangaDescriptionTextBox.Size = new System.Drawing.Size(649, 118);
            this.mangaDescriptionTextBox.TabIndex = 1;
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
            this.rssTickerGroupBox.Controls.Add(this.GoToPreviousNewsItemButton);
            this.rssTickerGroupBox.Controls.Add(this.GoToNextNewsItemButton);
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
            // GoToPreviousNewsItemButton
            // 
            this.GoToPreviousNewsItemButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.GoToPreviousNewsItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPreviousNewsItemButton.Location = new System.Drawing.Point(320, 16);
            this.GoToPreviousNewsItemButton.Name = "GoToPreviousNewsItemButton";
            this.GoToPreviousNewsItemButton.Size = new System.Drawing.Size(24, 23);
            this.GoToPreviousNewsItemButton.TabIndex = 6;
            this.GoToPreviousNewsItemButton.Text = "<";
            this.GoToPreviousNewsItemButton.UseVisualStyleBackColor = true;
            this.GoToPreviousNewsItemButton.Click += new System.EventHandler(this.HandleGoToPreviousNewsItemButtonClick);
            // 
            // GoToNextNewsItemButton
            // 
            this.GoToNextNewsItemButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.GoToNextNewsItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToNextNewsItemButton.Location = new System.Drawing.Point(344, 16);
            this.GoToNextNewsItemButton.Name = "GoToNextNewsItemButton";
            this.GoToNextNewsItemButton.Size = new System.Drawing.Size(24, 23);
            this.GoToNextNewsItemButton.TabIndex = 5;
            this.GoToNextNewsItemButton.Text = ">";
            this.GoToNextNewsItemButton.UseVisualStyleBackColor = true;
            this.GoToNextNewsItemButton.Click += new System.EventHandler(this.HandleGoToNextNewsItemButtonClick);
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
            this.rssDescriptionTextBox.Location = new System.Drawing.Point(9, 40);
            this.rssDescriptionTextBox.Multiline = true;
            this.rssDescriptionTextBox.Name = "rssDescriptionTextBox";
            this.rssDescriptionTextBox.ReadOnly = true;
            this.rssDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rssDescriptionTextBox.Size = new System.Drawing.Size(359, 78);
            this.rssDescriptionTextBox.TabIndex = 2;
            // 
            // rssTitleLabel
            // 
            this.rssTitleLabel.Location = new System.Drawing.Point(8, 24);
            this.rssTitleLabel.Name = "rssTitleLabel";
            this.rssTitleLabel.Size = new System.Drawing.Size(312, 14);
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
            // mangaListCombo
            // 
            this.mangaListCombo.FormattingEnabled = true;
            this.mangaListCombo.Location = new System.Drawing.Point(13, 84);
            this.mangaListCombo.Name = "mangaListCombo";
            this.mangaListCombo.Size = new System.Drawing.Size(251, 21);
            this.mangaListCombo.TabIndex = 10;
            this.mangaListCombo.SelectedIndexChanged += new System.EventHandler(this.MangaListComboSelectedIndexChanged);
            // 
            // mangaTitleLabel
            // 
            this.mangaTitleLabel.AutoSize = true;
            this.mangaTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mangaTitleLabel.Location = new System.Drawing.Point(236, 125);
            this.mangaTitleLabel.Name = "mangaTitleLabel";
            this.mangaTitleLabel.Size = new System.Drawing.Size(171, 37);
            this.mangaTitleLabel.TabIndex = 11;
            this.mangaTitleLabel.Text = "Manga Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(243, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "From ";
            // 
            // startingChapterLabel
            // 
            this.startingChapterLabel.AutoSize = true;
            this.startingChapterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.startingChapterLabel.Location = new System.Drawing.Point(291, 310);
            this.startingChapterLabel.Name = "startingChapterLabel";
            this.startingChapterLabel.Size = new System.Drawing.Size(41, 20);
            this.startingChapterLabel.TabIndex = 13;
            this.startingChapterLabel.Text = "2222";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(338, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "to";
            // 
            // currentChapterLabel
            // 
            this.currentChapterLabel.AutoSize = true;
            this.currentChapterLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.currentChapterLabel.Location = new System.Drawing.Point(367, 310);
            this.currentChapterLabel.Name = "currentChapterLabel";
            this.currentChapterLabel.Size = new System.Drawing.Size(41, 20);
            this.currentChapterLabel.TabIndex = 15;
            this.currentChapterLabel.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(243, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Unread since";
            // 
            // lastReadLabel
            // 
            this.lastReadLabel.AutoSize = true;
            this.lastReadLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastReadLabel.Location = new System.Drawing.Point(347, 330);
            this.lastReadLabel.Name = "lastReadLabel";
            this.lastReadLabel.Size = new System.Drawing.Size(85, 20);
            this.lastReadLabel.TabIndex = 17;
            this.lastReadLabel.Text = "22/12/2013";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ApplicationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastReadLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentChapterLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startingChapterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mangaDescriptionTextBox);
            this.Controls.Add(this.mangaTitleLabel);
            this.Controls.Add(this.mangaListCombo);
            this.Controls.Add(this.rssTickerGroupBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mangaCoverPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "ApplicationWindow";
            this.Text = "Manga Reading Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleMainFormFormClosing);
            this.Load += new System.EventHandler(this.HandleMainFormLoad);
            this.DataGridContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).EndInit();
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

        private System.Windows.Forms.PictureBox mangaCoverPictureBox;
        private System.Windows.Forms.TextBox mangaDescriptionTextBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.GroupBox rssTickerGroupBox;
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

		  private System.Windows.Forms.Label rssLinkLabel;
		  private System.Windows.Forms.TextBox rssDescriptionTextBox;
		  private System.Windows.Forms.Label rssTitleLabel;
		  private System.Windows.Forms.OpenFileDialog restoreOpenFileDialog;
          private System.Windows.Forms.SaveFileDialog backupSaveFileDialog;
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
          private System.Windows.Forms.Button GoToPreviousNewsItemButton;
          private System.Windows.Forms.Button GoToNextNewsItemButton;
          private System.Windows.Forms.ContextMenuStrip DataGridContextMenu;
          private System.Windows.Forms.ToolStripMenuItem openUrlEditorMenuItem;
          private System.Windows.Forms.ComboBox mangaListCombo;
          private System.Windows.Forms.Label mangaTitleLabel;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label startingChapterLabel;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label currentChapterLabel;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label lastReadLabel;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.Button button3;

    }
}

