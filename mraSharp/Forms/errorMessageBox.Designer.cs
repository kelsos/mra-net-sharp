namespace mraSharp.Forms
{
   partial class ErrorMessageBox
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
			this.errorDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.copyToClipboardButton = new System.Windows.Forms.Button();
			this.closeMessageBoxButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// errorDescriptionTextBox
			// 
			this.errorDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.errorDescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.errorDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.errorDescriptionTextBox.Location = new System.Drawing.Point(12, 12);
			this.errorDescriptionTextBox.Multiline = true;
			this.errorDescriptionTextBox.Name = "errorDescriptionTextBox";
			this.errorDescriptionTextBox.ReadOnly = true;
			this.errorDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.errorDescriptionTextBox.Size = new System.Drawing.Size(360, 95);
			this.errorDescriptionTextBox.TabIndex = 0;
			// 
			// copyToClipboardButton
			// 
			this.copyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.copyToClipboardButton.Location = new System.Drawing.Point(12, 113);
			this.copyToClipboardButton.Name = "copyToClipboardButton";
			this.copyToClipboardButton.Size = new System.Drawing.Size(75, 23);
			this.copyToClipboardButton.TabIndex = 1;
			this.copyToClipboardButton.Text = "Copy";
			this.copyToClipboardButton.UseVisualStyleBackColor = true;
			this.copyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButtonClick);
			// 
			// closeMessageBoxButton
			// 
			this.closeMessageBoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.closeMessageBoxButton.Location = new System.Drawing.Point(93, 113);
			this.closeMessageBoxButton.Name = "closeMessageBoxButton";
			this.closeMessageBoxButton.Size = new System.Drawing.Size(75, 23);
			this.closeMessageBoxButton.TabIndex = 2;
			this.closeMessageBoxButton.Text = "Close";
			this.closeMessageBoxButton.UseVisualStyleBackColor = true;
			this.closeMessageBoxButton.Click += new System.EventHandler(this.CloseMessageBoxButtonClick);
			// 
			// errorMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 148);
			this.Controls.Add(this.closeMessageBoxButton);
			this.Controls.Add(this.copyToClipboardButton);
			this.Controls.Add(this.errorDescriptionTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ErrorMessageBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "errorMessageBox";
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox errorDescriptionTextBox;
      private System.Windows.Forms.Button copyToClipboardButton;
      private System.Windows.Forms.Button closeMessageBoxButton;
   }
}