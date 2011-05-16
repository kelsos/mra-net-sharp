namespace mangaDatabaseEditor
{
	partial class GenresForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label genreIDLabel;
			System.Windows.Forms.Label genreNameLabel;
			this.genreInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.genreInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.genreInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.genreIDTextBox = new System.Windows.Forms.TextBox();
			this.genreNameTextBox = new System.Windows.Forms.TextBox();
			this.searchGroupBox = new System.Windows.Forms.GroupBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.browseAllButton = new System.Windows.Forms.Button();
			genreIDLabel = new System.Windows.Forms.Label();
			genreNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.genreInfoBindingNavigator)).BeginInit();
			this.genreInfoBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.genreInfoBindingSource)).BeginInit();
			this.searchGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// genreIDLabel
			// 
			genreIDLabel.AutoSize = true;
			genreIDLabel.Location = new System.Drawing.Point(6, 24);
			genreIDLabel.Name = "genreIDLabel";
			genreIDLabel.Size = new System.Drawing.Size(21, 13);
			genreIDLabel.TabIndex = 1;
			genreIDLabel.Text = "ID:";
			// 
			// genreNameLabel
			// 
			genreNameLabel.AutoSize = true;
			genreNameLabel.Location = new System.Drawing.Point(6, 52);
			genreNameLabel.Name = "genreNameLabel";
			genreNameLabel.Size = new System.Drawing.Size(41, 13);
			genreNameLabel.TabIndex = 3;
			genreNameLabel.Text = "Genre:";
			// 
			// genreInfoBindingNavigator
			// 
			this.genreInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.genreInfoBindingNavigator.BackColor = System.Drawing.Color.White;
			this.genreInfoBindingNavigator.BindingSource = this.genreInfoBindingSource;
			this.genreInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.genreInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.genreInfoBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.genreInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.genreInfoBindingNavigatorSaveItem});
			this.genreInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.genreInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.genreInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.genreInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.genreInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.genreInfoBindingNavigator.Name = "genreInfoBindingNavigator";
			this.genreInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.genreInfoBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.genreInfoBindingNavigator.TabIndex = 0;
			this.genreInfoBindingNavigator.Text = "Genre Navigator";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = global::mangaDatabaseEditor.Properties.Resources.plus;
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// genreInfoBindingSource
			// 
			this.genreInfoBindingSource.DataSource = typeof(mangaDatabaseEditor.M_genreInfo);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = global::mangaDatabaseEditor.Properties.Resources.crossScript;
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = global::mangaDatabaseEditor.Properties.Resources.controlStop180;
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = global::mangaDatabaseEditor.Properties.Resources.control180;
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = global::mangaDatabaseEditor.Properties.Resources.control;
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = global::mangaDatabaseEditor.Properties.Resources.controlStop;
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// genreInfoBindingNavigatorSaveItem
			// 
			this.genreInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.genreInfoBindingNavigatorSaveItem.Image = global::mangaDatabaseEditor.Properties.Resources.diskPencil;
			this.genreInfoBindingNavigatorSaveItem.Name = "genreInfoBindingNavigatorSaveItem";
			this.genreInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.genreInfoBindingNavigatorSaveItem.Text = "Save Data";
			this.genreInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.genreInfoBindingNavigatorSaveItem_Click);
			// 
			// genreIDTextBox
			// 
			this.genreIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreInfoBindingSource, "genreID", true));
			this.genreIDTextBox.Location = new System.Drawing.Point(66, 21);
			this.genreIDTextBox.Name = "genreIDTextBox";
			this.genreIDTextBox.ReadOnly = true;
			this.genreIDTextBox.Size = new System.Drawing.Size(182, 22);
			this.genreIDTextBox.TabIndex = 2;
			// 
			// genreNameTextBox
			// 
			this.genreNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreInfoBindingSource, "genreName", true));
			this.genreNameTextBox.Location = new System.Drawing.Point(66, 49);
			this.genreNameTextBox.Name = "genreNameTextBox";
			this.genreNameTextBox.Size = new System.Drawing.Size(182, 22);
			this.genreNameTextBox.TabIndex = 4;
			// 
			// searchGroupBox
			// 
			this.searchGroupBox.Controls.Add(this.searchButton);
			this.searchGroupBox.Controls.Add(this.searchTextBox);
			this.searchGroupBox.Location = new System.Drawing.Point(12, 116);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.Size = new System.Drawing.Size(254, 56);
			this.searchGroupBox.TabIndex = 5;
			this.searchGroupBox.TabStop = false;
			this.searchGroupBox.Text = "Search Genre:";
			// 
			// searchButton
			// 
			this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.searchButton.Image = global::mangaDatabaseEditor.Properties.Resources.magnifier;
			this.searchButton.Location = new System.Drawing.Point(228, 21);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(22, 22);
			this.searchButton.TabIndex = 1;
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(9, 21);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(213, 22);
			this.searchTextBox.TabIndex = 0;
			this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.genreIDTextBox);
			this.groupBox1.Controls.Add(genreIDLabel);
			this.groupBox1.Controls.Add(genreNameLabel);
			this.groupBox1.Controls.Add(this.genreNameTextBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(254, 82);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Genres:";
			// 
			// browseAllButton
			// 
			this.browseAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.browseAllButton.Location = new System.Drawing.Point(12, 180);
			this.browseAllButton.Name = "browseAllButton";
			this.browseAllButton.Size = new System.Drawing.Size(108, 23);
			this.browseAllButton.TabIndex = 7;
			this.browseAllButton.Text = "Browse All Entries";
			this.browseAllButton.UseVisualStyleBackColor = true;
			this.browseAllButton.Click += new System.EventHandler(this.browseAllButton_Click);
			// 
			// GenresForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(278, 215);
			this.Controls.Add(this.browseAllButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.genreInfoBindingNavigator);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "GenresForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Genre Editor";
			this.Load += new System.EventHandler(this.GenresForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.genreInfoBindingNavigator)).EndInit();
			this.genreInfoBindingNavigator.ResumeLayout(false);
			this.genreInfoBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.genreInfoBindingSource)).EndInit();
			this.searchGroupBox.ResumeLayout(false);
			this.searchGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource genreInfoBindingSource;
		private System.Windows.Forms.BindingNavigator genreInfoBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton genreInfoBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox genreIDTextBox;
		private System.Windows.Forms.TextBox genreNameTextBox;
		private System.Windows.Forms.GroupBox searchGroupBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button browseAllButton;
	}
}