namespace mraSharp
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
			this.rssUrlComboBox = new System.Windows.Forms.ComboBox();
			this.rssSubGroupBox = new System.Windows.Forms.GroupBox();
			this.exportPopup = new System.Windows.Forms.Button();
			this.importButton = new System.Windows.Forms.Button();
			this.addSubButton = new System.Windows.Forms.Button();
			this.removeSubButton = new System.Windows.Forms.Button();
			this.rssSubTextBox = new System.Windows.Forms.TextBox();
			this.channelTitleTextBox = new System.Windows.Forms.TextBox();
			this.rssSubGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// rssUrlComboBox
			// 
			this.rssUrlComboBox.DisplayMember = "rssUrl";
			this.rssUrlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.rssUrlComboBox.FormattingEnabled = true;
			this.rssUrlComboBox.Location = new System.Drawing.Point(6, 49);
			this.rssUrlComboBox.Name = "rssUrlComboBox";
			this.rssUrlComboBox.Size = new System.Drawing.Size(367, 21);
			this.rssUrlComboBox.TabIndex = 2;
			this.rssUrlComboBox.SelectedIndexChanged += new System.EventHandler(this.rssUrlComboBox_SelectedIndexChanged);
			// 
			// rssSubGroupBox
			// 
			this.rssSubGroupBox.Controls.Add(this.channelTitleTextBox);
			this.rssSubGroupBox.Controls.Add(this.exportPopup);
			this.rssSubGroupBox.Controls.Add(this.importButton);
			this.rssSubGroupBox.Controls.Add(this.addSubButton);
			this.rssSubGroupBox.Controls.Add(this.removeSubButton);
			this.rssSubGroupBox.Controls.Add(this.rssSubTextBox);
			this.rssSubGroupBox.Controls.Add(this.rssUrlComboBox);
			this.rssSubGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.rssSubGroupBox.Location = new System.Drawing.Point(12, 12);
			this.rssSubGroupBox.Name = "rssSubGroupBox";
			this.rssSubGroupBox.Size = new System.Drawing.Size(464, 137);
			this.rssSubGroupBox.TabIndex = 3;
			this.rssSubGroupBox.TabStop = false;
			this.rssSubGroupBox.Text = "Subscriptions";
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
			this.exportPopup.Click += new System.EventHandler(this.exportPopup_Click);
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
			this.importButton.Click += new System.EventHandler(this.importButton_Click);
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
			this.addSubButton.Click += new System.EventHandler(this.addSubButton_Click);
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
			this.removeSubButton.Click += new System.EventHandler(this.removeSubButton_Click);
			// 
			// rssSubTextBox
			// 
			this.rssSubTextBox.Location = new System.Drawing.Point(6, 76);
			this.rssSubTextBox.Name = "rssSubTextBox";
			this.rssSubTextBox.Size = new System.Drawing.Size(367, 22);
			this.rssSubTextBox.TabIndex = 3;
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
			this.Load += new System.EventHandler(this.SubscriptionManagerForm_Load);
			this.rssSubGroupBox.ResumeLayout(false);
			this.rssSubGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox rssUrlComboBox;
		private System.Windows.Forms.GroupBox rssSubGroupBox;
		private System.Windows.Forms.Button exportPopup;
		private System.Windows.Forms.Button importButton;
		private System.Windows.Forms.Button addSubButton;
		private System.Windows.Forms.Button removeSubButton;
		private System.Windows.Forms.TextBox rssSubTextBox;
		private System.Windows.Forms.TextBox channelTitleTextBox;
	}
}