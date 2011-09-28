namespace mraSharp.Forms
{
	partial class WebForm
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
			this.geckoReader = new Skybound.Gecko.GeckoWebBrowser();
			this.webNavigation = new System.Windows.Forms.ToolStrip();
			this.backToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.forwardToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.reloadToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.justReadButton = new System.Windows.Forms.ToolStripButton();
			this.webStatus = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.webNavigation.SuspendLayout();
			this.webStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// geckoReader
			// 
			this.geckoReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.geckoReader.Location = new System.Drawing.Point(0, 28);
			this.geckoReader.Name = "geckoReader";
			this.geckoReader.Size = new System.Drawing.Size(766, 423);
			this.geckoReader.TabIndex = 0;
			this.geckoReader.Navigated += new Skybound.Gecko.GeckoNavigatedEventHandler(this.GeckoReaderNavigated);
			// 
			// webNavigation
			// 
			this.webNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripButton,
            this.forwardToolStripButton,
            this.reloadToolStripButton,
            this.justReadButton});
			this.webNavigation.Location = new System.Drawing.Point(0, 0);
			this.webNavigation.Name = "webNavigation";
			this.webNavigation.Size = new System.Drawing.Size(766, 25);
			this.webNavigation.TabIndex = 1;
			this.webNavigation.Text = "toolStrip1";
			// 
			// backToolStripButton
			// 
			this.backToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.backToolStripButton.Image = global::mraSharp.Properties.Resources.navigation_180;
			this.backToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.backToolStripButton.Name = "backToolStripButton";
			this.backToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.backToolStripButton.Text = "Back";
			this.backToolStripButton.Click += new System.EventHandler(this.BackToolStripButtonClick);
			// 
			// forwardToolStripButton
			// 
			this.forwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.forwardToolStripButton.Image = global::mraSharp.Properties.Resources.navigation;
			this.forwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.forwardToolStripButton.Name = "forwardToolStripButton";
			this.forwardToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.forwardToolStripButton.Text = "Forward";
			this.forwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButtonClick);
			// 
			// reloadToolStripButton
			// 
			this.reloadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.reloadToolStripButton.Image = global::mraSharp.Properties.Resources.arrow_circle_double;
			this.reloadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.reloadToolStripButton.Name = "reloadToolStripButton";
			this.reloadToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.reloadToolStripButton.Text = "Reload Page";
			this.reloadToolStripButton.Click += new System.EventHandler(this.ReloadToolStripButtonClick);
			// 
			// justReadButton
			// 
			this.justReadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.justReadButton.Image = global::mraSharp.Properties.Resources.calendar_day;
			this.justReadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.justReadButton.Name = "justReadButton";
			this.justReadButton.Size = new System.Drawing.Size(23, 22);
			this.justReadButton.Text = "Just Read A Chapter";
			this.justReadButton.Click += new System.EventHandler(this.JustReadButtonClick);
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
			this.statusLabel.Size = new System.Drawing.Size(39, 17);
			this.statusLabel.Text = "Status";
			// 
			// WebForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 476);
			this.Controls.Add(this.webStatus);
			this.Controls.Add(this.webNavigation);
			this.Controls.Add(this.geckoReader);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.Name = "WebForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WebForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebFormFormClosing);
			this.webNavigation.ResumeLayout(false);
			this.webNavigation.PerformLayout();
			this.webStatus.ResumeLayout(false);
			this.webStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Skybound.Gecko.GeckoWebBrowser geckoReader;
		private System.Windows.Forms.ToolStrip webNavigation;
		private System.Windows.Forms.StatusStrip webStatus;
		private System.Windows.Forms.ToolStripButton backToolStripButton;
		private System.Windows.Forms.ToolStripButton forwardToolStripButton;
		private System.Windows.Forms.ToolStripButton reloadToolStripButton;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripButton justReadButton;
	}
}