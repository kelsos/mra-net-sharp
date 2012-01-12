namespace mraSharp.Forms
{
	partial class SubscriptionManagerForm
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
            this.subscriptionUrlComboBox = new System.Windows.Forms.ComboBox();
            this.rssSubGroupBox = new System.Windows.Forms.GroupBox();
            this.channelTitleTextBox = new System.Windows.Forms.TextBox();
            this.exportPopup = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.addSubButton = new System.Windows.Forms.Button();
            this.removeSubButton = new System.Windows.Forms.Button();
            this.rssSubTextBox = new System.Windows.Forms.TextBox();
            this.keepInDatabaseForLabel = new System.Windows.Forms.Label();
            this.keepInDatabaseForTextBox = new System.Windows.Forms.TextBox();
            this.rssSubGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // subscriptionUrlComboBox
            // 
            this.subscriptionUrlComboBox.DisplayMember = "SUBSCRIPTION_URL";
            this.subscriptionUrlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionUrlComboBox.FormattingEnabled = true;
            this.subscriptionUrlComboBox.Location = new System.Drawing.Point(6, 49);
            this.subscriptionUrlComboBox.Name = "subscriptionUrlComboBox";
            this.subscriptionUrlComboBox.Size = new System.Drawing.Size(367, 21);
            this.subscriptionUrlComboBox.TabIndex = 2;
            this.subscriptionUrlComboBox.SelectedIndexChanged += new System.EventHandler(this.SubscriptionUrlComboBoxSelectedIndexChanged);
            // 
            // rssSubGroupBox
            // 
            this.rssSubGroupBox.Controls.Add(this.keepInDatabaseForTextBox);
            this.rssSubGroupBox.Controls.Add(this.keepInDatabaseForLabel);
            this.rssSubGroupBox.Controls.Add(this.channelTitleTextBox);
            this.rssSubGroupBox.Controls.Add(this.exportPopup);
            this.rssSubGroupBox.Controls.Add(this.importButton);
            this.rssSubGroupBox.Controls.Add(this.addSubButton);
            this.rssSubGroupBox.Controls.Add(this.removeSubButton);
            this.rssSubGroupBox.Controls.Add(this.rssSubTextBox);
            this.rssSubGroupBox.Controls.Add(this.subscriptionUrlComboBox);
            this.rssSubGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rssSubGroupBox.Location = new System.Drawing.Point(12, 12);
            this.rssSubGroupBox.Name = "rssSubGroupBox";
            this.rssSubGroupBox.Size = new System.Drawing.Size(464, 137);
            this.rssSubGroupBox.TabIndex = 3;
            this.rssSubGroupBox.TabStop = false;
            this.rssSubGroupBox.Text = "Subscriptions";
            // 
            // channelTitleTextBox
            // 
            this.channelTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelTitleTextBox.Location = new System.Drawing.Point(6, 21);
            this.channelTitleTextBox.Name = "channelTitleTextBox";
            this.channelTitleTextBox.ReadOnly = true;
            this.channelTitleTextBox.Size = new System.Drawing.Size(184, 22);
            this.channelTitleTextBox.TabIndex = 8;
            // 
            // exportPopup
            // 
            this.exportPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportPopup.Location = new System.Drawing.Point(87, 104);
            this.exportPopup.Name = "exportPopup";
            this.exportPopup.Size = new System.Drawing.Size(75, 23);
            this.exportPopup.TabIndex = 7;
            this.exportPopup.Text = "Export";
            this.exportPopup.UseVisualStyleBackColor = true;
            this.exportPopup.Click += new System.EventHandler(this.ExportPopupClick);
            // 
            // importButton
            // 
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.importButton.Location = new System.Drawing.Point(6, 104);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportButtonClick);
            // 
            // addSubButton
            // 
            this.addSubButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSubButton.Location = new System.Drawing.Point(379, 76);
            this.addSubButton.Name = "addSubButton";
            this.addSubButton.Size = new System.Drawing.Size(75, 22);
            this.addSubButton.TabIndex = 5;
            this.addSubButton.Text = "Add";
            this.addSubButton.UseVisualStyleBackColor = true;
            this.addSubButton.Click += new System.EventHandler(this.AddSubButtonClick);
            // 
            // removeSubButton
            // 
            this.removeSubButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeSubButton.Location = new System.Drawing.Point(379, 49);
            this.removeSubButton.Name = "removeSubButton";
            this.removeSubButton.Size = new System.Drawing.Size(75, 21);
            this.removeSubButton.TabIndex = 4;
            this.removeSubButton.Text = "Remove";
            this.removeSubButton.UseVisualStyleBackColor = true;
            this.removeSubButton.Click += new System.EventHandler(this.RemoveSubButtonClick);
            // 
            // rssSubTextBox
            // 
            this.rssSubTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rssSubTextBox.Location = new System.Drawing.Point(6, 76);
            this.rssSubTextBox.Name = "rssSubTextBox";
            this.rssSubTextBox.Size = new System.Drawing.Size(367, 22);
            this.rssSubTextBox.TabIndex = 3;
            // 
            // keepInDatabaseForLabel
            // 
            this.keepInDatabaseForLabel.AutoSize = true;
            this.keepInDatabaseForLabel.Location = new System.Drawing.Point(196, 23);
            this.keepInDatabaseForLabel.Name = "keepInDatabaseForLabel";
            this.keepInDatabaseForLabel.Size = new System.Drawing.Size(148, 13);
            this.keepInDatabaseForLabel.TabIndex = 9;
            this.keepInDatabaseForLabel.Text = "Keep in database for: (days)";
            // 
            // keepInDatabaseForTextBox
            // 
            this.keepInDatabaseForTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keepInDatabaseForTextBox.Location = new System.Drawing.Point(346, 20);
            this.keepInDatabaseForTextBox.Name = "keepInDatabaseForTextBox";
            this.keepInDatabaseForTextBox.Size = new System.Drawing.Size(108, 22);
            this.keepInDatabaseForTextBox.TabIndex = 10;
            this.keepInDatabaseForTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeepInDatabaseForTextBoxKeyUp);
            // 
            // SubscriptionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 163);
            this.Controls.Add(this.rssSubGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SubscriptionManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Subscription Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubscriptionManagerFormFormClosing);
            this.Load += new System.EventHandler(this.SubscriptionManagerFormLoad);
            this.rssSubGroupBox.ResumeLayout(false);
            this.rssSubGroupBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox subscriptionUrlComboBox;
		private System.Windows.Forms.GroupBox rssSubGroupBox;
		private System.Windows.Forms.Button exportPopup;
		private System.Windows.Forms.Button importButton;
		private System.Windows.Forms.Button addSubButton;
		private System.Windows.Forms.Button removeSubButton;
		private System.Windows.Forms.TextBox rssSubTextBox;
		private System.Windows.Forms.TextBox channelTitleTextBox;
        private System.Windows.Forms.Label keepInDatabaseForLabel;
        private System.Windows.Forms.TextBox keepInDatabaseForTextBox;
	}
}