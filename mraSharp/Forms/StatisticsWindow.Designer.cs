namespace mraNet.Forms
{
	partial class StatisticsWindow
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
         this.numberOfMangasReadTextBox = new System.Windows.Forms.TextBox();
         this.numberOfChaptersReadTextBox = new System.Windows.Forms.TextBox();
         this.numberOfMangasFinishedTextBox = new System.Windows.Forms.TextBox();
         this.dateILastReadTextBox = new System.Windows.Forms.TextBox();
         this.daysSinceTextBox = new System.Windows.Forms.TextBox();
         this.numOfMangasReadTextBox = new System.Windows.Forms.GroupBox();
         this.numOfChaptersReadGroupBox = new System.Windows.Forms.GroupBox();
         this.numOfFinishedMangasGroupBox = new System.Windows.Forms.GroupBox();
         this.dateILastReadGroupBox = new System.Windows.Forms.GroupBox();
         this.daysSinceGroupBox = new System.Windows.Forms.GroupBox();
         this.numOfMangasReadTextBox.SuspendLayout();
         this.numOfChaptersReadGroupBox.SuspendLayout();
         this.numOfFinishedMangasGroupBox.SuspendLayout();
         this.dateILastReadGroupBox.SuspendLayout();
         this.daysSinceGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // numberOfMangasReadTextBox
         // 
         this.numberOfMangasReadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.numberOfMangasReadTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.numberOfMangasReadTextBox.Location = new System.Drawing.Point(3, 18);
         this.numberOfMangasReadTextBox.Name = "numberOfMangasReadTextBox";
         this.numberOfMangasReadTextBox.ReadOnly = true;
         this.numberOfMangasReadTextBox.Size = new System.Drawing.Size(194, 15);
         this.numberOfMangasReadTextBox.TabIndex = 0;
         // 
         // numberOfChaptersReadTextBox
         // 
         this.numberOfChaptersReadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.numberOfChaptersReadTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.numberOfChaptersReadTextBox.Location = new System.Drawing.Point(3, 18);
         this.numberOfChaptersReadTextBox.Name = "numberOfChaptersReadTextBox";
         this.numberOfChaptersReadTextBox.ReadOnly = true;
         this.numberOfChaptersReadTextBox.Size = new System.Drawing.Size(194, 15);
         this.numberOfChaptersReadTextBox.TabIndex = 1;
         // 
         // numberOfMangasFinishedTextBox
         // 
         this.numberOfMangasFinishedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.numberOfMangasFinishedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.numberOfMangasFinishedTextBox.Location = new System.Drawing.Point(3, 18);
         this.numberOfMangasFinishedTextBox.Name = "numberOfMangasFinishedTextBox";
         this.numberOfMangasFinishedTextBox.ReadOnly = true;
         this.numberOfMangasFinishedTextBox.Size = new System.Drawing.Size(194, 15);
         this.numberOfMangasFinishedTextBox.TabIndex = 2;
         // 
         // dateILastReadTextBox
         // 
         this.dateILastReadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dateILastReadTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dateILastReadTextBox.Location = new System.Drawing.Point(3, 18);
         this.dateILastReadTextBox.Name = "dateILastReadTextBox";
         this.dateILastReadTextBox.ReadOnly = true;
         this.dateILastReadTextBox.Size = new System.Drawing.Size(194, 15);
         this.dateILastReadTextBox.TabIndex = 3;
         // 
         // daysSinceTextBox
         // 
         this.daysSinceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.daysSinceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.daysSinceTextBox.Location = new System.Drawing.Point(3, 18);
         this.daysSinceTextBox.Name = "daysSinceTextBox";
         this.daysSinceTextBox.ReadOnly = true;
         this.daysSinceTextBox.Size = new System.Drawing.Size(194, 15);
         this.daysSinceTextBox.TabIndex = 4;
         // 
         // numOfMangasReadTextBox
         // 
         this.numOfMangasReadTextBox.Controls.Add(this.numberOfMangasReadTextBox);
         this.numOfMangasReadTextBox.Location = new System.Drawing.Point(12, 12);
         this.numOfMangasReadTextBox.Name = "numOfMangasReadTextBox";
         this.numOfMangasReadTextBox.Size = new System.Drawing.Size(200, 44);
         this.numOfMangasReadTextBox.TabIndex = 10;
         this.numOfMangasReadTextBox.TabStop = false;
         this.numOfMangasReadTextBox.Text = "Number of Mangas Read";
         // 
         // numOfChaptersReadGroupBox
         // 
         this.numOfChaptersReadGroupBox.Controls.Add(this.numberOfChaptersReadTextBox);
         this.numOfChaptersReadGroupBox.Location = new System.Drawing.Point(12, 62);
         this.numOfChaptersReadGroupBox.Name = "numOfChaptersReadGroupBox";
         this.numOfChaptersReadGroupBox.Size = new System.Drawing.Size(200, 42);
         this.numOfChaptersReadGroupBox.TabIndex = 11;
         this.numOfChaptersReadGroupBox.TabStop = false;
         this.numOfChaptersReadGroupBox.Text = "Number Of Chapters Read";
         // 
         // numOfFinishedMangasGroupBox
         // 
         this.numOfFinishedMangasGroupBox.Controls.Add(this.numberOfMangasFinishedTextBox);
         this.numOfFinishedMangasGroupBox.Location = new System.Drawing.Point(12, 110);
         this.numOfFinishedMangasGroupBox.Name = "numOfFinishedMangasGroupBox";
         this.numOfFinishedMangasGroupBox.Size = new System.Drawing.Size(200, 44);
         this.numOfFinishedMangasGroupBox.TabIndex = 11;
         this.numOfFinishedMangasGroupBox.TabStop = false;
         this.numOfFinishedMangasGroupBox.Text = "Number of Finished Mangas";
         // 
         // dateILastReadGroupBox
         // 
         this.dateILastReadGroupBox.Controls.Add(this.dateILastReadTextBox);
         this.dateILastReadGroupBox.Location = new System.Drawing.Point(12, 160);
         this.dateILastReadGroupBox.Name = "dateILastReadGroupBox";
         this.dateILastReadGroupBox.Size = new System.Drawing.Size(200, 44);
         this.dateILastReadGroupBox.TabIndex = 12;
         this.dateILastReadGroupBox.TabStop = false;
         this.dateILastReadGroupBox.Text = "Date I Last Read";
         // 
         // daysSinceGroupBox
         // 
         this.daysSinceGroupBox.Controls.Add(this.daysSinceTextBox);
         this.daysSinceGroupBox.Location = new System.Drawing.Point(12, 210);
         this.daysSinceGroupBox.Name = "daysSinceGroupBox";
         this.daysSinceGroupBox.Size = new System.Drawing.Size(200, 44);
         this.daysSinceGroupBox.TabIndex = 13;
         this.daysSinceGroupBox.TabStop = false;
         this.daysSinceGroupBox.Text = "Days Since";
         // 
         // StatisticsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(227, 271);
         this.Controls.Add(this.daysSinceGroupBox);
         this.Controls.Add(this.dateILastReadGroupBox);
         this.Controls.Add(this.numOfFinishedMangasGroupBox);
         this.Controls.Add(this.numOfChaptersReadGroupBox);
         this.Controls.Add(this.numOfMangasReadTextBox);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Name = "StatisticsForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Statistics";
         this.numOfMangasReadTextBox.ResumeLayout(false);
         this.numOfMangasReadTextBox.PerformLayout();
         this.numOfChaptersReadGroupBox.ResumeLayout(false);
         this.numOfChaptersReadGroupBox.PerformLayout();
         this.numOfFinishedMangasGroupBox.ResumeLayout(false);
         this.numOfFinishedMangasGroupBox.PerformLayout();
         this.dateILastReadGroupBox.ResumeLayout(false);
         this.dateILastReadGroupBox.PerformLayout();
         this.daysSinceGroupBox.ResumeLayout(false);
         this.daysSinceGroupBox.PerformLayout();
         this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox numberOfMangasReadTextBox;
		private System.Windows.Forms.TextBox numberOfChaptersReadTextBox;
		private System.Windows.Forms.TextBox numberOfMangasFinishedTextBox;
		private System.Windows.Forms.TextBox dateILastReadTextBox;
      private System.Windows.Forms.TextBox daysSinceTextBox;
      private System.Windows.Forms.GroupBox numOfMangasReadTextBox;
      private System.Windows.Forms.GroupBox numOfChaptersReadGroupBox;
      private System.Windows.Forms.GroupBox numOfFinishedMangasGroupBox;
      private System.Windows.Forms.GroupBox dateILastReadGroupBox;
      private System.Windows.Forms.GroupBox daysSinceGroupBox;
	}
}