namespace Library
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.booksb = new System.Windows.Forms.ToolStripButton();
            this.depositb = new System.Windows.Forms.ToolStripButton();
            this.membersb = new System.Windows.Forms.ToolStripButton();
            this.statisticsb = new System.Windows.Forms.ToolStripButton();
            this.profileb = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksb,
            this.depositb,
            this.membersb,
            this.statisticsb,
            this.toolStripButton2,
            this.profileb,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // booksb
            // 
            this.booksb.Image = ((System.Drawing.Image)(resources.GetObject("booksb.Image")));
            this.booksb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.booksb.Name = "booksb";
            this.booksb.Size = new System.Drawing.Size(43, 35);
            this.booksb.Text = "Books";
            this.booksb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.booksb.Click += new System.EventHandler(this.booksb_Click);
            // 
            // depositb
            // 
            this.depositb.Image = ((System.Drawing.Image)(resources.GetObject("depositb.Image")));
            this.depositb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.depositb.Name = "depositb";
            this.depositb.Size = new System.Drawing.Size(49, 35);
            this.depositb.Text = "Borrow";
            this.depositb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.depositb.Click += new System.EventHandler(this.depositb_Click);
            // 
            // membersb
            // 
            this.membersb.Image = ((System.Drawing.Image)(resources.GetObject("membersb.Image")));
            this.membersb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.membersb.Name = "membersb";
            this.membersb.Size = new System.Drawing.Size(61, 35);
            this.membersb.Text = "Members";
            this.membersb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.membersb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.membersb.Click += new System.EventHandler(this.membersb_Click);
            // 
            // statisticsb
            // 
            this.statisticsb.Image = ((System.Drawing.Image)(resources.GetObject("statisticsb.Image")));
            this.statisticsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statisticsb.Name = "statisticsb";
            this.statisticsb.Size = new System.Drawing.Size(57, 35);
            this.statisticsb.Text = "Statistics";
            this.statisticsb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.statisticsb.Click += new System.EventHandler(this.statisticsb_Click);
            // 
            // profileb
            // 
            this.profileb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileb.Image = ((System.Drawing.Image)(resources.GetObject("profileb.Image")));
            this.profileb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profileb.Name = "profileb";
            this.profileb.Size = new System.Drawing.Size(45, 35);
            this.profileb.Text = "Profile";
            this.profileb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.profileb.Click += new System.EventHandler(this.profileb_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 35);
            this.toolStripButton1.Text = "Agenda";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 35);
            this.toolStripButton2.Text = "Logout";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home_page";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.home_page_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton booksb;
        private System.Windows.Forms.ToolStripButton membersb;
        private System.Windows.Forms.ToolStripButton statisticsb;
        private System.Windows.Forms.ToolStripButton depositb;
        private System.Windows.Forms.ToolStripButton profileb;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}