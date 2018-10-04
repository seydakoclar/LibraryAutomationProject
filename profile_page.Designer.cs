namespace Library
{
    partial class profile_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile_page));
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seeMyProfileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.CheckOnClick = true;
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.editProfileToolStripMenuItem.Text = "Edit My Profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // seeBorrowedBooksToolStripMenuItem
            // 
            this.seeBorrowedBooksToolStripMenuItem.Name = "seeBorrowedBooksToolStripMenuItem";
            this.seeBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.seeBorrowedBooksToolStripMenuItem.Text = "See Borrowed Books";
            this.seeBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.seeBorrowedBooksToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.endToolStripMenuItem.Text = "End My Membership";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeMyProfileInfoToolStripMenuItem,
            this.editProfileToolStripMenuItem,
            this.seeBorrowedBooksToolStripMenuItem,
            this.endToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seeMyProfileInfoToolStripMenuItem
            // 
            this.seeMyProfileInfoToolStripMenuItem.Name = "seeMyProfileInfoToolStripMenuItem";
            this.seeMyProfileInfoToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.seeMyProfileInfoToolStripMenuItem.Text = "See My Profile Info";
            this.seeMyProfileInfoToolStripMenuItem.Click += new System.EventHandler(this.seeMyProfileInfoToolStripMenuItem_Click);
            // 
            // profile_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(570, 426);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "profile_page";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.profile_page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeBorrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seeMyProfileInfoToolStripMenuItem;
    }
}