namespace OOP_2_2_Music_Player_EF
{
    partial class FormMain
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PlayerControlsPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ArtistsLabel = new System.Windows.Forms.Label();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.SongsLabel = new System.Windows.Forms.Label();
            this.PlaylistsLabel = new System.Windows.Forms.Label();
            this.YourLibraryLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.ByLabel = new System.Windows.Forms.Label();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.YearSongsCountLabel = new System.Windows.Forms.Label();
            this.ArtistNameLabel = new System.Windows.Forms.Label();
            this.MainNameLabel = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(854, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(94, 22);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlayerControlsPanel
            // 
            this.PlayerControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerControlsPanel.Location = new System.Drawing.Point(0, 625);
            this.PlayerControlsPanel.Name = "PlayerControlsPanel";
            this.PlayerControlsPanel.Size = new System.Drawing.Size(1173, 101);
            this.PlayerControlsPanel.TabIndex = 1;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.LeftPanel.Controls.Add(this.ArtistsLabel);
            this.LeftPanel.Controls.Add(this.AlbumsLabel);
            this.LeftPanel.Controls.Add(this.SongsLabel);
            this.LeftPanel.Controls.Add(this.PlaylistsLabel);
            this.LeftPanel.Controls.Add(this.YourLibraryLabel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(217, 625);
            this.LeftPanel.TabIndex = 2;
            // 
            // ArtistsLabel
            // 
            this.ArtistsLabel.AutoSize = true;
            this.ArtistsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArtistsLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArtistsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.ArtistsLabel.Location = new System.Drawing.Point(12, 103);
            this.ArtistsLabel.Name = "ArtistsLabel";
            this.ArtistsLabel.Size = new System.Drawing.Size(55, 20);
            this.ArtistsLabel.TabIndex = 4;
            this.ArtistsLabel.Text = "Artists";
            this.ArtistsLabel.MouseEnter += new System.EventHandler(this.ArtistsLabel_MouseEnter);
            this.ArtistsLabel.MouseLeave += new System.EventHandler(this.ArtistsLabel_MouseLeave);
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlbumsLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.AlbumsLabel.Location = new System.Drawing.Point(12, 73);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(65, 20);
            this.AlbumsLabel.TabIndex = 3;
            this.AlbumsLabel.Text = "Albums";
            this.AlbumsLabel.MouseEnter += new System.EventHandler(this.AlbumsLabel_MouseEnter);
            this.AlbumsLabel.MouseLeave += new System.EventHandler(this.AlbumsLabel_MouseLeave);
            // 
            // SongsLabel
            // 
            this.SongsLabel.AutoSize = true;
            this.SongsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SongsLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SongsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.SongsLabel.Location = new System.Drawing.Point(12, 43);
            this.SongsLabel.Name = "SongsLabel";
            this.SongsLabel.Size = new System.Drawing.Size(54, 20);
            this.SongsLabel.TabIndex = 2;
            this.SongsLabel.Text = "Songs";
            this.SongsLabel.MouseEnter += new System.EventHandler(this.SongsLabel_MouseEnter);
            this.SongsLabel.MouseLeave += new System.EventHandler(this.SongsLabel_MouseLeave);
            // 
            // PlaylistsLabel
            // 
            this.PlaylistsLabel.AutoSize = true;
            this.PlaylistsLabel.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaylistsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.PlaylistsLabel.Location = new System.Drawing.Point(13, 159);
            this.PlaylistsLabel.Name = "PlaylistsLabel";
            this.PlaylistsLabel.Size = new System.Drawing.Size(65, 15);
            this.PlaylistsLabel.TabIndex = 1;
            this.PlaylistsLabel.Text = "PLAYLISTS";
            // 
            // YourLibraryLabel
            // 
            this.YourLibraryLabel.AutoSize = true;
            this.YourLibraryLabel.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YourLibraryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.YourLibraryLabel.Location = new System.Drawing.Point(13, 17);
            this.YourLibraryLabel.Name = "YourLibraryLabel";
            this.YourLibraryLabel.Size = new System.Drawing.Size(91, 15);
            this.YourLibraryLabel.TabIndex = 0;
            this.YourLibraryLabel.Text = "YOUR LIBRARY";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MainNameLabel);
            this.TopPanel.Controls.Add(this.ArtistNameLabel);
            this.TopPanel.Controls.Add(this.YearSongsCountLabel);
            this.TopPanel.Controls.Add(this.TypeLabel);
            this.TopPanel.Controls.Add(this.mainImage);
            this.TopPanel.Controls.Add(this.ByLabel);
            this.TopPanel.Controls.Add(this.UsernameLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(217, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(956, 216);
            this.TopPanel.TabIndex = 3;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(44)))));
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(217, 216);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(956, 409);
            this.CenterPanel.TabIndex = 4;
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.ByLabel.Location = new System.Drawing.Point(204, 124);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(28, 20);
            this.ByLabel.TabIndex = 1;
            this.ByLabel.Text = "By";
            // 
            // mainImage
            // 
            this.mainImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainImage.Location = new System.Drawing.Point(27, 28);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(160, 160);
            this.mainImage.TabIndex = 2;
            this.mainImage.TabStop = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.TypeLabel.Location = new System.Drawing.Point(204, 49);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(53, 16);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "ALBUM";
            // 
            // YearSongsCountLabel
            // 
            this.YearSongsCountLabel.AutoSize = true;
            this.YearSongsCountLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.YearSongsCountLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.YearSongsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(174)))));
            this.YearSongsCountLabel.Location = new System.Drawing.Point(203, 149);
            this.YearSongsCountLabel.Name = "YearSongsCountLabel";
            this.YearSongsCountLabel.Size = new System.Drawing.Size(112, 20);
            this.YearSongsCountLabel.TabIndex = 4;
            this.YearSongsCountLabel.Text = "2017 • 14 songs";
            // 
            // ArtistNameLabel
            // 
            this.ArtistNameLabel.AutoSize = true;
            this.ArtistNameLabel.Font = new System.Drawing.Font("Montserrat Medium", 10F);
            this.ArtistNameLabel.ForeColor = System.Drawing.Color.White;
            this.ArtistNameLabel.Location = new System.Drawing.Point(228, 124);
            this.ArtistNameLabel.Name = "ArtistNameLabel";
            this.ArtistNameLabel.Size = new System.Drawing.Size(124, 20);
            this.ArtistNameLabel.TabIndex = 5;
            this.ArtistNameLabel.Text = "Kendrick Lamar";
            // 
            // MainNameLabel
            // 
            this.MainNameLabel.AutoSize = true;
            this.MainNameLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainNameLabel.ForeColor = System.Drawing.Color.White;
            this.MainNameLabel.Location = new System.Drawing.Point(199, 63);
            this.MainNameLabel.Name = "MainNameLabel";
            this.MainNameLabel.Size = new System.Drawing.Size(420, 52);
            this.MainNameLabel.TabIndex = 6;
            this.MainNameLabel.Text = "To Pimp A Butterfly";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1173, 726);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.PlayerControlsPanel);
            this.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormMain";
            this.Text = "Music Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel PlayerControlsPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label SongsLabel;
        private System.Windows.Forms.Label PlaylistsLabel;
        private System.Windows.Forms.Label YourLibraryLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Label ArtistsLabel;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.Label ByLabel;
        private System.Windows.Forms.Label MainNameLabel;
        private System.Windows.Forms.Label ArtistNameLabel;
        private System.Windows.Forms.Label YearSongsCountLabel;
        private System.Windows.Forms.Label TypeLabel;
    }
}