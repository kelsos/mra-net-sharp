namespace mraNet.Forms
{
    partial class SettingWindows
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
            this.errorLogLocationTextBox = new System.Windows.Forms.TextBox();
            this.errorLogGroupBox = new System.Windows.Forms.GroupBox();
            this.openSaveLocationDialogButton = new System.Windows.Forms.Button();
            this.BrowserSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.internalBrowserRadioButton = new System.Windows.Forms.RadioButton();
            this.externalBrowserRadioButton = new System.Windows.Forms.RadioButton();
            this.errorLogGroupBox.SuspendLayout();
            this.BrowserSelectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorLogLocationTextBox
            // 
            this.errorLogLocationTextBox.Location = new System.Drawing.Point(6, 19);
            this.errorLogLocationTextBox.Name = "errorLogLocationTextBox";
            this.errorLogLocationTextBox.Size = new System.Drawing.Size(215, 20);
            this.errorLogLocationTextBox.TabIndex = 0;
            // 
            // errorLogGroupBox
            // 
            this.errorLogGroupBox.Controls.Add(this.openSaveLocationDialogButton);
            this.errorLogGroupBox.Controls.Add(this.errorLogLocationTextBox);
            this.errorLogGroupBox.Location = new System.Drawing.Point(12, 12);
            this.errorLogGroupBox.Name = "errorLogGroupBox";
            this.errorLogGroupBox.Size = new System.Drawing.Size(254, 53);
            this.errorLogGroupBox.TabIndex = 1;
            this.errorLogGroupBox.TabStop = false;
            this.errorLogGroupBox.Text = "Error log save location";
            // 
            // openSaveLocationDialogButton
            // 
            this.openSaveLocationDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openSaveLocationDialogButton.Location = new System.Drawing.Point(227, 19);
            this.openSaveLocationDialogButton.Name = "openSaveLocationDialogButton";
            this.openSaveLocationDialogButton.Size = new System.Drawing.Size(21, 20);
            this.openSaveLocationDialogButton.TabIndex = 2;
            this.openSaveLocationDialogButton.Text = "...";
            this.openSaveLocationDialogButton.UseVisualStyleBackColor = true;
            // 
            // BrowserSelectionGroupBox
            // 
            this.BrowserSelectionGroupBox.Controls.Add(this.externalBrowserRadioButton);
            this.BrowserSelectionGroupBox.Controls.Add(this.internalBrowserRadioButton);
            this.BrowserSelectionGroupBox.Location = new System.Drawing.Point(12, 71);
            this.BrowserSelectionGroupBox.Name = "BrowserSelectionGroupBox";
            this.BrowserSelectionGroupBox.Size = new System.Drawing.Size(107, 65);
            this.BrowserSelectionGroupBox.TabIndex = 2;
            this.BrowserSelectionGroupBox.TabStop = false;
            this.BrowserSelectionGroupBox.Text = "Browser Selection";
            // 
            // internalBrowserRadioButton
            // 
            this.internalBrowserRadioButton.AutoSize = true;
            this.internalBrowserRadioButton.Location = new System.Drawing.Point(6, 19);
            this.internalBrowserRadioButton.Name = "internalBrowserRadioButton";
            this.internalBrowserRadioButton.Size = new System.Drawing.Size(60, 17);
            this.internalBrowserRadioButton.TabIndex = 3;
            this.internalBrowserRadioButton.TabStop = true;
            this.internalBrowserRadioButton.Text = "Internal";
            this.internalBrowserRadioButton.UseVisualStyleBackColor = true;
            // 
            // externalBrowserRadioButton
            // 
            this.externalBrowserRadioButton.AutoSize = true;
            this.externalBrowserRadioButton.Location = new System.Drawing.Point(6, 38);
            this.externalBrowserRadioButton.Name = "externalBrowserRadioButton";
            this.externalBrowserRadioButton.Size = new System.Drawing.Size(63, 17);
            this.externalBrowserRadioButton.TabIndex = 3;
            this.externalBrowserRadioButton.TabStop = true;
            this.externalBrowserRadioButton.Text = "External";
            this.externalBrowserRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 262);
            this.Controls.Add(this.BrowserSelectionGroupBox);
            this.Controls.Add(this.errorLogGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.errorLogGroupBox.ResumeLayout(false);
            this.errorLogGroupBox.PerformLayout();
            this.BrowserSelectionGroupBox.ResumeLayout(false);
            this.BrowserSelectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox errorLogLocationTextBox;
        private System.Windows.Forms.GroupBox errorLogGroupBox;
        private System.Windows.Forms.Button openSaveLocationDialogButton;
        private System.Windows.Forms.GroupBox BrowserSelectionGroupBox;
        private System.Windows.Forms.RadioButton externalBrowserRadioButton;
        private System.Windows.Forms.RadioButton internalBrowserRadioButton;
    }
}