namespace mraSharp
{
	partial class StatisticsForm
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
			this.numberOfMangasReadLabel = new System.Windows.Forms.Label();
			this.numberOfChaptersReadLabel = new System.Windows.Forms.Label();
			this.numberOfMangasFinishedLabel = new System.Windows.Forms.Label();
			this.dateILastReadLabel = new System.Windows.Forms.Label();
			this.daysSinceLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// numberOfMangasReadTextBox
			// 
			this.numberOfMangasReadTextBox.Location = new System.Drawing.Point(220, 35);
			this.numberOfMangasReadTextBox.Name = "numberOfMangasReadTextBox";
			this.numberOfMangasReadTextBox.ReadOnly = true;
			this.numberOfMangasReadTextBox.Size = new System.Drawing.Size(195, 22);
			this.numberOfMangasReadTextBox.TabIndex = 0;
			// 
			// numberOfChaptersReadTextBox
			// 
			this.numberOfChaptersReadTextBox.Location = new System.Drawing.Point(220, 63);
			this.numberOfChaptersReadTextBox.Name = "numberOfChaptersReadTextBox";
			this.numberOfChaptersReadTextBox.ReadOnly = true;
			this.numberOfChaptersReadTextBox.Size = new System.Drawing.Size(195, 22);
			this.numberOfChaptersReadTextBox.TabIndex = 1;
			// 
			// numberOfMangasFinishedTextBox
			// 
			this.numberOfMangasFinishedTextBox.Location = new System.Drawing.Point(220, 91);
			this.numberOfMangasFinishedTextBox.Name = "numberOfMangasFinishedTextBox";
			this.numberOfMangasFinishedTextBox.ReadOnly = true;
			this.numberOfMangasFinishedTextBox.Size = new System.Drawing.Size(195, 22);
			this.numberOfMangasFinishedTextBox.TabIndex = 2;
			// 
			// dateILastReadTextBox
			// 
			this.dateILastReadTextBox.Location = new System.Drawing.Point(220, 119);
			this.dateILastReadTextBox.Name = "dateILastReadTextBox";
			this.dateILastReadTextBox.ReadOnly = true;
			this.dateILastReadTextBox.Size = new System.Drawing.Size(195, 22);
			this.dateILastReadTextBox.TabIndex = 3;
			// 
			// daysSinceTextBox
			// 
			this.daysSinceTextBox.Location = new System.Drawing.Point(220, 147);
			this.daysSinceTextBox.Name = "daysSinceTextBox";
			this.daysSinceTextBox.ReadOnly = true;
			this.daysSinceTextBox.Size = new System.Drawing.Size(195, 22);
			this.daysSinceTextBox.TabIndex = 4;
			// 
			// numberOfMangasReadLabel
			// 
			this.numberOfMangasReadLabel.AutoSize = true;
			this.numberOfMangasReadLabel.Location = new System.Drawing.Point(12, 38);
			this.numberOfMangasReadLabel.Name = "numberOfMangasReadLabel";
			this.numberOfMangasReadLabel.Size = new System.Drawing.Size(138, 13);
			this.numberOfMangasReadLabel.TabIndex = 5;
			this.numberOfMangasReadLabel.Text = "Number of Mangas Read:";
			// 
			// numberOfChaptersReadLabel
			// 
			this.numberOfChaptersReadLabel.AutoSize = true;
			this.numberOfChaptersReadLabel.Location = new System.Drawing.Point(12, 66);
			this.numberOfChaptersReadLabel.Name = "numberOfChaptersReadLabel";
			this.numberOfChaptersReadLabel.Size = new System.Drawing.Size(143, 13);
			this.numberOfChaptersReadLabel.TabIndex = 6;
			this.numberOfChaptersReadLabel.Text = "Number of Chapters Read:";
			// 
			// numberOfMangasFinishedLabel
			// 
			this.numberOfMangasFinishedLabel.AutoSize = true;
			this.numberOfMangasFinishedLabel.Location = new System.Drawing.Point(12, 94);
			this.numberOfMangasFinishedLabel.Name = "numberOfMangasFinishedLabel";
			this.numberOfMangasFinishedLabel.Size = new System.Drawing.Size(156, 13);
			this.numberOfMangasFinishedLabel.TabIndex = 7;
			this.numberOfMangasFinishedLabel.Text = "Number of Mangas Finished:";
			// 
			// dateILastReadLabel
			// 
			this.dateILastReadLabel.AutoSize = true;
			this.dateILastReadLabel.Location = new System.Drawing.Point(12, 122);
			this.dateILastReadLabel.Name = "dateILastReadLabel";
			this.dateILastReadLabel.Size = new System.Drawing.Size(92, 13);
			this.dateILastReadLabel.TabIndex = 8;
			this.dateILastReadLabel.Text = "Date I Last Read:";
			// 
			// daysSinceLabel
			// 
			this.daysSinceLabel.AutoSize = true;
			this.daysSinceLabel.Location = new System.Drawing.Point(12, 150);
			this.daysSinceLabel.Name = "daysSinceLabel";
			this.daysSinceLabel.Size = new System.Drawing.Size(64, 13);
			this.daysSinceLabel.TabIndex = 9;
			this.daysSinceLabel.Text = "Days Since:";
			// 
			// StatisticsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 211);
			this.Controls.Add(this.daysSinceLabel);
			this.Controls.Add(this.dateILastReadLabel);
			this.Controls.Add(this.numberOfMangasFinishedLabel);
			this.Controls.Add(this.numberOfChaptersReadLabel);
			this.Controls.Add(this.numberOfMangasReadLabel);
			this.Controls.Add(this.daysSinceTextBox);
			this.Controls.Add(this.dateILastReadTextBox);
			this.Controls.Add(this.numberOfMangasFinishedTextBox);
			this.Controls.Add(this.numberOfChaptersReadTextBox);
			this.Controls.Add(this.numberOfMangasReadTextBox);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "StatisticsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Statistics";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numberOfMangasReadTextBox;
		private System.Windows.Forms.TextBox numberOfChaptersReadTextBox;
		private System.Windows.Forms.TextBox numberOfMangasFinishedTextBox;
		private System.Windows.Forms.TextBox dateILastReadTextBox;
		private System.Windows.Forms.TextBox daysSinceTextBox;
		private System.Windows.Forms.Label numberOfMangasReadLabel;
		private System.Windows.Forms.Label numberOfChaptersReadLabel;
		private System.Windows.Forms.Label numberOfMangasFinishedLabel;
		private System.Windows.Forms.Label dateILastReadLabel;
		private System.Windows.Forms.Label daysSinceLabel;
	}
}