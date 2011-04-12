namespace oldFormatImporter
{
	partial class oldMangaDataLoader
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
			this.loadProgressBar = new System.Windows.Forms.ProgressBar();
			this.loadButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.loadUserDataButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loadProgressBar
			// 
			this.loadProgressBar.Location = new System.Drawing.Point(12, 12);
			this.loadProgressBar.Name = "loadProgressBar";
			this.loadProgressBar.Size = new System.Drawing.Size(260, 23);
			this.loadProgressBar.TabIndex = 0;
			// 
			// loadButton
			// 
			this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadButton.Location = new System.Drawing.Point(12, 41);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(128, 23);
			this.loadButton.TabIndex = 1;
			this.loadButton.Text = "Load Manga Data";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// loadUserDataButton
			// 
			this.loadUserDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadUserDataButton.Location = new System.Drawing.Point(146, 41);
			this.loadUserDataButton.Name = "loadUserDataButton";
			this.loadUserDataButton.Size = new System.Drawing.Size(126, 23);
			this.loadUserDataButton.TabIndex = 2;
			this.loadUserDataButton.Text = "Load UserData";
			this.loadUserDataButton.UseVisualStyleBackColor = true;
			this.loadUserDataButton.Click += new System.EventHandler(this.loadUserDataButton_Click);
			// 
			// oldMangaDataLoader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 70);
			this.Controls.Add(this.loadUserDataButton);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.loadProgressBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "oldMangaDataLoader";
			this.Text = "Old Format MangaDataLoader";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar loadProgressBar;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button loadUserDataButton;
	}
}

