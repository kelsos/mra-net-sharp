namespace mraNet.Forms
{
	partial class BrowserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserWindow));
            this.webNavigation = new System.Windows.Forms.ToolStrip();
            this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reloadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.justReadButton = new System.Windows.Forms.ToolStripButton();
            this.navigationUrlBox = new System.Windows.Forms.ToolStripTextBox();
            this.navigateButton = new System.Windows.Forms.ToolStripButton();
            this.updateUrlButton = new System.Windows.Forms.ToolStripButton();
            this.webStatus = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.browserPanel = new System.Windows.Forms.Panel();
            this.InternalBrowser = new System.Windows.Forms.WebBrowser();
            this.webNavigation.SuspendLayout();
            this.webStatus.SuspendLayout();
            this.browserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webNavigation
            // 
            this.webNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripButton,
            this.forwardToolStripButton,
            this.reloadToolStripButton,
            this.justReadButton,
            this.navigationUrlBox,
            this.navigateButton,
            this.updateUrlButton});
            this.webNavigation.Location = new System.Drawing.Point(0, 0);
            this.webNavigation.Name = "webNavigation";
            this.webNavigation.Size = new System.Drawing.Size(766, 25);
            this.webNavigation.TabIndex = 1;
            this.webNavigation.Text = "toolStrip1";
            // 
            // backToolStripButton
            // 
            this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backToolStripButton.Image = global::mraNet.Properties.Resources.navigation_180;
            this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backToolStripButton.Name = "backToolStripButton";
            this.backToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.backToolStripButton.Text = "Back";
            this.backToolStripButton.Click += new System.EventHandler(this.BackToolStripButtonClick);
            // 
            // forwardToolStripButton
            // 
            this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardToolStripButton.Image = global::mraNet.Properties.Resources.navigation;
            this.forwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardToolStripButton.Name = "forwardToolStripButton";
            this.forwardToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.forwardToolStripButton.Text = "Forward";
            this.forwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButtonClick);
            // 
            // reloadToolStripButton
            // 
            this.reloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadToolStripButton.Image = global::mraNet.Properties.Resources.arrow_circle_double;
            this.reloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadToolStripButton.Name = "reloadToolStripButton";
            this.reloadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.reloadToolStripButton.Text = "Reload Page";
            this.reloadToolStripButton.Click += new System.EventHandler(this.ReloadToolStripButtonClick);
            // 
            // justReadButton
            // 
            this.justReadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.justReadButton.Image = global::mraNet.Properties.Resources.calendar_day;
            this.justReadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.justReadButton.Name = "justReadButton";
            this.justReadButton.Size = new System.Drawing.Size(23, 22);
            this.justReadButton.Text = "Just Read A Chapter";
            this.justReadButton.Click += new System.EventHandler(this.HandleChapterFinishedButtonClick);
            // 
            // navigationUrlBox
            // 
            this.navigationUrlBox.Name = "navigationUrlBox";
            this.navigationUrlBox.Size = new System.Drawing.Size(600, 25);
            this.navigationUrlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NavigationUrlBoxKeyPress);
            // 
            // navigateButton
            // 
            this.navigateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.navigateButton.Image = ((System.Drawing.Image)(resources.GetObject("navigateButton.Image")));
            this.navigateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.navigateButton.Name = "navigateButton";
            this.navigateButton.Size = new System.Drawing.Size(23, 22);
            this.navigateButton.Text = "Navigate";
            this.navigateButton.Click += new System.EventHandler(this.NavigateButtonClick);
            // 
            // updateUrlButton
            // 
            this.updateUrlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateUrlButton.Image = ((System.Drawing.Image)(resources.GetObject("updateUrlButton.Image")));
            this.updateUrlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateUrlButton.Name = "updateUrlButton";
            this.updateUrlButton.Size = new System.Drawing.Size(23, 20);
            this.updateUrlButton.Text = "Update Url";
            this.updateUrlButton.Click += new System.EventHandler(this.UpdateUrlButtonClick);
            // 
            // webStatus
            // 
            this.webStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.webStatus.Location = new System.Drawing.Point(0, 454);
            this.webStatus.Name = "webStatus";
            this.webStatus.Size = new System.Drawing.Size(766, 22);
            this.webStatus.TabIndex = 2;
            this.webStatus.Text = "Status Bar";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 17);
            this.statusLabel.Text = "Status";
            this.statusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleStatusLabelMouseDown);
            // 
            // browserPanel
            // 
            this.browserPanel.Controls.Add(this.InternalBrowser);
            this.browserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPanel.Location = new System.Drawing.Point(0, 25);
            this.browserPanel.Name = "browserPanel";
            this.browserPanel.Size = new System.Drawing.Size(766, 429);
            this.browserPanel.TabIndex = 3;
            // 
            // InternalBrowser
            // 
            this.InternalBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InternalBrowser.Location = new System.Drawing.Point(0, 0);
            this.InternalBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.InternalBrowser.Name = "InternalBrowser";
            this.InternalBrowser.Size = new System.Drawing.Size(766, 429);
            this.InternalBrowser.TabIndex = 0;
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 476);
            this.Controls.Add(this.browserPanel);
            this.Controls.Add(this.webStatus);
            this.Controls.Add(this.webNavigation);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "BrowserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WebForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebFormFormClosing);
            this.Load += new System.EventHandler(this.BrowserWindowLoad);
            this.webNavigation.ResumeLayout(false);
            this.webNavigation.PerformLayout();
            this.webStatus.ResumeLayout(false);
            this.webStatus.PerformLayout();
            this.browserPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip webNavigation;
		private System.Windows.Forms.StatusStrip webStatus;
		private System.Windows.Forms.ToolStripButton backToolStripButton;
		private System.Windows.Forms.ToolStripButton forwardToolStripButton;
		private System.Windows.Forms.ToolStripButton reloadToolStripButton;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripButton justReadButton;
        private System.Windows.Forms.Panel browserPanel;
        private System.Windows.Forms.WebBrowser InternalBrowser;
        private System.Windows.Forms.ToolStripTextBox navigationUrlBox;
        private System.Windows.Forms.ToolStripButton navigateButton;
        private System.Windows.Forms.ToolStripButton updateUrlButton;
	}
}