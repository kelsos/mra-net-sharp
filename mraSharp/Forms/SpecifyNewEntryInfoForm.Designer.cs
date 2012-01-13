namespace mraSharp.Forms
{
   partial class SpecifyNewEntryInfoForm
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
          this.setStartingChapterTextBox = new System.Windows.Forms.TextBox();
          this.setCurrentChapterTextBox = new System.Windows.Forms.TextBox();
          this.setOnlineURLTextbox = new System.Windows.Forms.TextBox();
          this.setDateLastReadDateTimePicker = new System.Windows.Forms.DateTimePicker();
          this.finishedReadingCheckBox = new System.Windows.Forms.CheckBox();
          this.chapterGroupBox = new System.Windows.Forms.GroupBox();
          this.currentLabel = new System.Windows.Forms.Label();
          this.startingLabel = new System.Windows.Forms.Label();
          this.datenUrlGroupBox = new System.Windows.Forms.GroupBox();
          this.saveButton = new System.Windows.Forms.Button();
          this.cancelButton = new System.Windows.Forms.Button();
          this.personalNoteTextBox = new System.Windows.Forms.TextBox();
          this.personalNoteGroupBox = new System.Windows.Forms.GroupBox();
          this.chapterGroupBox.SuspendLayout();
          this.datenUrlGroupBox.SuspendLayout();
          this.personalNoteGroupBox.SuspendLayout();
          this.SuspendLayout();
          // 
          // setStartingChapterTextBox
          // 
          this.setStartingChapterTextBox.Location = new System.Drawing.Point(63, 21);
          this.setStartingChapterTextBox.Name = "setStartingChapterTextBox";
          this.setStartingChapterTextBox.Size = new System.Drawing.Size(100, 22);
          this.setStartingChapterTextBox.TabIndex = 0;
          // 
          // setCurrentChapterTextBox
          // 
          this.setCurrentChapterTextBox.Location = new System.Drawing.Point(239, 21);
          this.setCurrentChapterTextBox.Name = "setCurrentChapterTextBox";
          this.setCurrentChapterTextBox.Size = new System.Drawing.Size(100, 22);
          this.setCurrentChapterTextBox.TabIndex = 1;
          // 
          // setOnlineURLTextbox
          // 
          this.setOnlineURLTextbox.Location = new System.Drawing.Point(9, 49);
          this.setOnlineURLTextbox.Name = "setOnlineURLTextbox";
          this.setOnlineURLTextbox.Size = new System.Drawing.Size(348, 22);
          this.setOnlineURLTextbox.TabIndex = 2;
          // 
          // setDateLastReadDateTimePicker
          // 
          this.setDateLastReadDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
          this.setDateLastReadDateTimePicker.Location = new System.Drawing.Point(9, 21);
          this.setDateLastReadDateTimePicker.Name = "setDateLastReadDateTimePicker";
          this.setDateLastReadDateTimePicker.Size = new System.Drawing.Size(348, 22);
          this.setDateLastReadDateTimePicker.TabIndex = 3;
          // 
          // finishedReadingCheckBox
          // 
          this.finishedReadingCheckBox.AutoSize = true;
          this.finishedReadingCheckBox.Location = new System.Drawing.Point(12, 262);
          this.finishedReadingCheckBox.Name = "finishedReadingCheckBox";
          this.finishedReadingCheckBox.Size = new System.Drawing.Size(156, 17);
          this.finishedReadingCheckBox.TabIndex = 4;
          this.finishedReadingCheckBox.Text = "Did you finish reading it?";
          this.finishedReadingCheckBox.UseVisualStyleBackColor = true;
          // 
          // chapterGroupBox
          // 
          this.chapterGroupBox.Controls.Add(this.currentLabel);
          this.chapterGroupBox.Controls.Add(this.startingLabel);
          this.chapterGroupBox.Controls.Add(this.setStartingChapterTextBox);
          this.chapterGroupBox.Controls.Add(this.setCurrentChapterTextBox);
          this.chapterGroupBox.Location = new System.Drawing.Point(12, 12);
          this.chapterGroupBox.Name = "chapterGroupBox";
          this.chapterGroupBox.Size = new System.Drawing.Size(363, 56);
          this.chapterGroupBox.TabIndex = 5;
          this.chapterGroupBox.TabStop = false;
          this.chapterGroupBox.Text = "Chapters";
          // 
          // currentLabel
          // 
          this.currentLabel.AutoSize = true;
          this.currentLabel.Location = new System.Drawing.Point(184, 24);
          this.currentLabel.Name = "currentLabel";
          this.currentLabel.Size = new System.Drawing.Size(49, 13);
          this.currentLabel.TabIndex = 3;
          this.currentLabel.Text = "Current:";
          // 
          // startingLabel
          // 
          this.startingLabel.AutoSize = true;
          this.startingLabel.Location = new System.Drawing.Point(6, 24);
          this.startingLabel.Name = "startingLabel";
          this.startingLabel.Size = new System.Drawing.Size(51, 13);
          this.startingLabel.TabIndex = 2;
          this.startingLabel.Text = "Starting:";
          // 
          // datenUrlGroupBox
          // 
          this.datenUrlGroupBox.Controls.Add(this.setDateLastReadDateTimePicker);
          this.datenUrlGroupBox.Controls.Add(this.setOnlineURLTextbox);
          this.datenUrlGroupBox.Location = new System.Drawing.Point(12, 74);
          this.datenUrlGroupBox.Name = "datenUrlGroupBox";
          this.datenUrlGroupBox.Size = new System.Drawing.Size(363, 84);
          this.datenUrlGroupBox.TabIndex = 6;
          this.datenUrlGroupBox.TabStop = false;
          this.datenUrlGroupBox.Text = "Date and Online URL";
          // 
          // saveButton
          // 
          this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
          this.saveButton.Location = new System.Drawing.Point(12, 285);
          this.saveButton.Name = "saveButton";
          this.saveButton.Size = new System.Drawing.Size(75, 23);
          this.saveButton.TabIndex = 7;
          this.saveButton.Text = "Save";
          this.saveButton.UseVisualStyleBackColor = true;
          this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
          // 
          // cancelButton
          // 
          this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.cancelButton.Location = new System.Drawing.Point(93, 285);
          this.cancelButton.Name = "cancelButton";
          this.cancelButton.Size = new System.Drawing.Size(75, 23);
          this.cancelButton.TabIndex = 8;
          this.cancelButton.Text = "Cancel";
          this.cancelButton.UseVisualStyleBackColor = true;
          // 
          // personalNoteTextBox
          // 
          this.personalNoteTextBox.BackColor = System.Drawing.SystemColors.Window;
          this.personalNoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
          this.personalNoteTextBox.Location = new System.Drawing.Point(3, 18);
          this.personalNoteTextBox.Multiline = true;
          this.personalNoteTextBox.Name = "personalNoteTextBox";
          this.personalNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
          this.personalNoteTextBox.Size = new System.Drawing.Size(357, 71);
          this.personalNoteTextBox.TabIndex = 9;
          // 
          // personalNoteGroupBox
          // 
          this.personalNoteGroupBox.BackColor = System.Drawing.SystemColors.Control;
          this.personalNoteGroupBox.Controls.Add(this.personalNoteTextBox);
          this.personalNoteGroupBox.Location = new System.Drawing.Point(12, 164);
          this.personalNoteGroupBox.Name = "personalNoteGroupBox";
          this.personalNoteGroupBox.Size = new System.Drawing.Size(363, 92);
          this.personalNoteGroupBox.TabIndex = 10;
          this.personalNoteGroupBox.TabStop = false;
          this.personalNoteGroupBox.Text = "Personal Note";
          // 
          // SpecifyNewEntryInfoForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(387, 316);
          this.Controls.Add(this.personalNoteGroupBox);
          this.Controls.Add(this.cancelButton);
          this.Controls.Add(this.saveButton);
          this.Controls.Add(this.datenUrlGroupBox);
          this.Controls.Add(this.chapterGroupBox);
          this.Controls.Add(this.finishedReadingCheckBox);
          this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
          this.Name = "SpecifyNewEntryInfoForm";
          this.Text = "Specify New Entry Info";
          this.Load += new System.EventHandler(this.HandleFormLoad);
          this.chapterGroupBox.ResumeLayout(false);
          this.chapterGroupBox.PerformLayout();
          this.datenUrlGroupBox.ResumeLayout(false);
          this.datenUrlGroupBox.PerformLayout();
          this.personalNoteGroupBox.ResumeLayout(false);
          this.personalNoteGroupBox.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox setStartingChapterTextBox;
      private System.Windows.Forms.TextBox setCurrentChapterTextBox;
      private System.Windows.Forms.TextBox setOnlineURLTextbox;
      private System.Windows.Forms.DateTimePicker setDateLastReadDateTimePicker;
      private System.Windows.Forms.CheckBox finishedReadingCheckBox;
      private System.Windows.Forms.GroupBox chapterGroupBox;
      private System.Windows.Forms.Label currentLabel;
      private System.Windows.Forms.Label startingLabel;
      private System.Windows.Forms.GroupBox datenUrlGroupBox;
      private System.Windows.Forms.Button saveButton;
      private System.Windows.Forms.Button cancelButton;
      private System.Windows.Forms.TextBox personalNoteTextBox;
      private System.Windows.Forms.GroupBox personalNoteGroupBox;
   }
}