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
         this.searchGroupBox = new System.Windows.Forms.GroupBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.searchParametersCB = new System.Windows.Forms.ComboBox();
         this.searchByLabel = new System.Windows.Forms.Label();
         this.mangaCoverPictureBox = new System.Windows.Forms.PictureBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.mangaTitleTextBox = new System.Windows.Forms.TextBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.listBox2 = new System.Windows.Forms.ListBox();
         this.mangaListComboBox = new System.Windows.Forms.ComboBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.addToReadingListButton = new System.Windows.Forms.Button();
         this.publisherTextBox = new System.Windows.Forms.TextBox();
         this.yearTextBox = new System.Windows.Forms.TextBox();
         this.statusTextBox = new System.Windows.Forms.TextBox();
         this.publisherGroupBox = new System.Windows.Forms.GroupBox();
         this.statusGroupBox = new System.Windows.Forms.GroupBox();
         this.yearGroupBox = new System.Windows.Forms.GroupBox();
         this.descriptionGroupBox = new System.Windows.Forms.GroupBox();
         this.descriptionTextBox = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.searchGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.publisherGroupBox.SuspendLayout();
         this.statusGroupBox.SuspendLayout();
         this.yearGroupBox.SuspendLayout();
         this.descriptionGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // searchGroupBox
         // 
         this.searchGroupBox.Controls.Add(this.textBox1);
         this.searchGroupBox.Controls.Add(this.searchParametersCB);
         this.searchGroupBox.Controls.Add(this.searchByLabel);
         this.searchGroupBox.Location = new System.Drawing.Point(12, 12);
         this.searchGroupBox.Name = "searchGroupBox";
         this.searchGroupBox.Size = new System.Drawing.Size(203, 71);
         this.searchGroupBox.TabIndex = 0;
         this.searchGroupBox.TabStop = false;
         this.searchGroupBox.Text = "Search";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(9, 40);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(185, 22);
         this.textBox1.TabIndex = 2;
         // 
         // searchParametersCB
         // 
         this.searchParametersCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.searchParametersCB.FormattingEnabled = true;
         this.searchParametersCB.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Publisher",
            "Genre",
            "Status",
            "Year"});
         this.searchParametersCB.Location = new System.Drawing.Point(71, 13);
         this.searchParametersCB.Name = "searchParametersCB";
         this.searchParametersCB.Size = new System.Drawing.Size(123, 21);
         this.searchParametersCB.TabIndex = 1;
         // 
         // searchByLabel
         // 
         this.searchByLabel.AutoSize = true;
         this.searchByLabel.Location = new System.Drawing.Point(6, 16);
         this.searchByLabel.Name = "searchByLabel";
         this.searchByLabel.Size = new System.Drawing.Size(59, 13);
         this.searchByLabel.TabIndex = 0;
         this.searchByLabel.Text = "Search By:";
         // 
         // mangaCoverPictureBox
         // 
         this.mangaCoverPictureBox.Location = new System.Drawing.Point(12, 89);
         this.mangaCoverPictureBox.Name = "mangaCoverPictureBox";
         this.mangaCoverPictureBox.Size = new System.Drawing.Size(160, 230);
         this.mangaCoverPictureBox.TabIndex = 1;
         this.mangaCoverPictureBox.TabStop = false;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.mangaTitleTextBox);
         this.groupBox1.Location = new System.Drawing.Point(178, 89);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(311, 43);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Title";
         // 
         // mangaTitleTextBox
         // 
         this.mangaTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.mangaTitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mangaTitleTextBox.Location = new System.Drawing.Point(3, 16);
         this.mangaTitleTextBox.Name = "mangaTitleTextBox";
         this.mangaTitleTextBox.ReadOnly = true;
         this.mangaTitleTextBox.Size = new System.Drawing.Size(305, 15);
         this.mangaTitleTextBox.TabIndex = 0;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.listBox1);
         this.groupBox2.Location = new System.Drawing.Point(178, 138);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(158, 181);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Author(s)";
         // 
         // listBox1
         // 
         this.listBox1.BackColor = System.Drawing.SystemColors.Control;
         this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBox1.FormattingEnabled = true;
         this.listBox1.Location = new System.Drawing.Point(3, 18);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(152, 160);
         this.listBox1.TabIndex = 0;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.listBox2);
         this.groupBox3.Location = new System.Drawing.Point(342, 138);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(147, 181);
         this.groupBox3.TabIndex = 4;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Genres";
         // 
         // listBox2
         // 
         this.listBox2.BackColor = System.Drawing.SystemColors.Control;
         this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBox2.FormattingEnabled = true;
         this.listBox2.Location = new System.Drawing.Point(3, 18);
         this.listBox2.Name = "listBox2";
         this.listBox2.Size = new System.Drawing.Size(141, 160);
         this.listBox2.TabIndex = 0;
         // 
         // mangaListComboBox
         // 
         this.mangaListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.mangaListComboBox.FormattingEnabled = true;
         this.mangaListComboBox.Location = new System.Drawing.Point(6, 13);
         this.mangaListComboBox.Name = "mangaListComboBox";
         this.mangaListComboBox.Size = new System.Drawing.Size(256, 21);
         this.mangaListComboBox.TabIndex = 5;
         this.mangaListComboBox.SelectedIndexChanged += new System.EventHandler(this.mangaListComboBox_SelectedIndexChanged);
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.checkBox1);
         this.groupBox4.Controls.Add(this.mangaListComboBox);
         this.groupBox4.Location = new System.Drawing.Point(221, 12);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(268, 71);
         this.groupBox4.TabIndex = 6;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Mangas";
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Location = new System.Drawing.Point(6, 42);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(182, 17);
         this.checkBox1.TabIndex = 6;
         this.checkBox1.Text = "Display Manga Already In My List";
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // addToReadingListButton
         // 
         this.addToReadingListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.addToReadingListButton.Location = new System.Drawing.Point(12, 500);
         this.addToReadingListButton.Name = "addToReadingListButton";
         this.addToReadingListButton.Size = new System.Drawing.Size(125, 23);
         this.addToReadingListButton.TabIndex = 7;
         this.addToReadingListButton.Text = "Add To Reading List";
         this.addToReadingListButton.UseVisualStyleBackColor = true;
         this.addToReadingListButton.Click += new System.EventHandler(this.addToReadingListButton_Click);
         // 
         // publisherTextBox
         // 
         this.publisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.publisherTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.publisherTextBox.Location = new System.Drawing.Point(3, 18);
         this.publisherTextBox.Name = "publisherTextBox";
         this.publisherTextBox.ReadOnly = true;
         this.publisherTextBox.Size = new System.Drawing.Size(197, 15);
         this.publisherTextBox.TabIndex = 8;
         // 
         // yearTextBox
         // 
         this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.yearTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.yearTextBox.Location = new System.Drawing.Point(3, 18);
         this.yearTextBox.Name = "yearTextBox";
         this.yearTextBox.ReadOnly = true;
         this.yearTextBox.Size = new System.Drawing.Size(109, 15);
         this.yearTextBox.TabIndex = 9;
         // 
         // statusTextBox
         // 
         this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.statusTextBox.Location = new System.Drawing.Point(3, 18);
         this.statusTextBox.Name = "statusTextBox";
         this.statusTextBox.ReadOnly = true;
         this.statusTextBox.Size = new System.Drawing.Size(141, 15);
         this.statusTextBox.TabIndex = 10;
         // 
         // publisherGroupBox
         // 
         this.publisherGroupBox.Controls.Add(this.publisherTextBox);
         this.publisherGroupBox.Location = new System.Drawing.Point(12, 325);
         this.publisherGroupBox.Name = "publisherGroupBox";
         this.publisherGroupBox.Size = new System.Drawing.Size(203, 44);
         this.publisherGroupBox.TabIndex = 11;
         this.publisherGroupBox.TabStop = false;
         this.publisherGroupBox.Text = "Publisher";
         // 
         // statusGroupBox
         // 
         this.statusGroupBox.Controls.Add(this.statusTextBox);
         this.statusGroupBox.Location = new System.Drawing.Point(342, 325);
         this.statusGroupBox.Name = "statusGroupBox";
         this.statusGroupBox.Size = new System.Drawing.Size(147, 44);
         this.statusGroupBox.TabIndex = 12;
         this.statusGroupBox.TabStop = false;
         this.statusGroupBox.Text = "Status";
         // 
         // yearGroupBox
         // 
         this.yearGroupBox.Controls.Add(this.yearTextBox);
         this.yearGroupBox.Location = new System.Drawing.Point(221, 325);
         this.yearGroupBox.Name = "yearGroupBox";
         this.yearGroupBox.Size = new System.Drawing.Size(115, 44);
         this.yearGroupBox.TabIndex = 13;
         this.yearGroupBox.TabStop = false;
         this.yearGroupBox.Text = "Year";
         // 
         // descriptionGroupBox
         // 
         this.descriptionGroupBox.Controls.Add(this.descriptionTextBox);
         this.descriptionGroupBox.Location = new System.Drawing.Point(12, 375);
         this.descriptionGroupBox.Name = "descriptionGroupBox";
         this.descriptionGroupBox.Size = new System.Drawing.Size(477, 119);
         this.descriptionGroupBox.TabIndex = 14;
         this.descriptionGroupBox.TabStop = false;
         this.descriptionGroupBox.Text = "Description";
         // 
         // descriptionTextBox
         // 
         this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.descriptionTextBox.Location = new System.Drawing.Point(3, 18);
         this.descriptionTextBox.Multiline = true;
         this.descriptionTextBox.Name = "descriptionTextBox";
         this.descriptionTextBox.ReadOnly = true;
         this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.descriptionTextBox.Size = new System.Drawing.Size(471, 98);
         this.descriptionTextBox.TabIndex = 0;
         // 
         // button1
         // 
         this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.button1.Location = new System.Drawing.Point(143, 500);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(105, 23);
         this.button1.TabIndex = 15;
         this.button1.Text = "Non Default Add";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // AddMangaForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(498, 531);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.descriptionGroupBox);
         this.Controls.Add(this.yearGroupBox);
         this.Controls.Add(this.statusGroupBox);
         this.Controls.Add(this.publisherGroupBox);
         this.Controls.Add(this.addToReadingListButton);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.mangaCoverPictureBox);
         this.Controls.Add(this.searchGroupBox);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "AddMangaForm";
         this.Text = "AddMangaForm";
         this.Load += new System.EventHandler(this.AddMangaForm_Load);
         this.searchGroupBox.ResumeLayout(false);
         this.searchGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.mangaCoverPictureBox)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.publisherGroupBox.ResumeLayout(false);
         this.publisherGroupBox.PerformLayout();
         this.statusGroupBox.ResumeLayout(false);
         this.statusGroupBox.PerformLayout();
         this.yearGroupBox.ResumeLayout(false);
         this.yearGroupBox.PerformLayout();
         this.descriptionGroupBox.ResumeLayout(false);
         this.descriptionGroupBox.PerformLayout();
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox searchGroupBox;
		private System.Windows.Forms.ComboBox searchParametersCB;
		private System.Windows.Forms.Label searchByLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox mangaCoverPictureBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox mangaTitleTextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ComboBox mangaListComboBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button addToReadingListButton;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox publisherTextBox;
		private System.Windows.Forms.TextBox yearTextBox;
		private System.Windows.Forms.TextBox statusTextBox;
      private System.Windows.Forms.GroupBox publisherGroupBox;
      private System.Windows.Forms.GroupBox statusGroupBox;
      private System.Windows.Forms.GroupBox yearGroupBox;
      private System.Windows.Forms.GroupBox descriptionGroupBox;
      private System.Windows.Forms.TextBox descriptionTextBox;
      private System.Windows.Forms.Button button1;
	}
}