namespace Library
{
    partial class books_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(books_page));
            this.listallbooks = new System.Windows.Forms.Button();
            this.booksdonate = new System.Windows.Forms.Button();
            this.searchbooks = new System.Windows.Forms.Button();
            this.bookscoming = new System.Windows.Forms.Button();
            this.updatebooklistb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listallbooks
            // 
            this.listallbooks.BackColor = System.Drawing.Color.LemonChiffon;
            this.listallbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listallbooks.Location = new System.Drawing.Point(41, 31);
            this.listallbooks.Name = "listallbooks";
            this.listallbooks.Size = new System.Drawing.Size(101, 50);
            this.listallbooks.TabIndex = 0;
            this.listallbooks.Text = "List All Books";
            this.listallbooks.UseVisualStyleBackColor = false;
            this.listallbooks.Click += new System.EventHandler(this.listallbooks_Click);
            // 
            // booksdonate
            // 
            this.booksdonate.BackColor = System.Drawing.Color.LemonChiffon;
            this.booksdonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.booksdonate.Location = new System.Drawing.Point(158, 106);
            this.booksdonate.Name = "booksdonate";
            this.booksdonate.Size = new System.Drawing.Size(101, 50);
            this.booksdonate.TabIndex = 4;
            this.booksdonate.Text = "Donate Book";
            this.booksdonate.UseVisualStyleBackColor = false;
            this.booksdonate.Click += new System.EventHandler(this.booksdonate_Click);
            // 
            // searchbooks
            // 
            this.searchbooks.BackColor = System.Drawing.Color.LemonChiffon;
            this.searchbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchbooks.Location = new System.Drawing.Point(41, 185);
            this.searchbooks.Name = "searchbooks";
            this.searchbooks.Size = new System.Drawing.Size(101, 50);
            this.searchbooks.TabIndex = 5;
            this.searchbooks.Text = "Search Book";
            this.searchbooks.UseVisualStyleBackColor = false;
            this.searchbooks.Click += new System.EventHandler(this.searchbooks_Click);
            // 
            // bookscoming
            // 
            this.bookscoming.BackColor = System.Drawing.Color.LemonChiffon;
            this.bookscoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookscoming.Location = new System.Drawing.Point(158, 261);
            this.bookscoming.Name = "bookscoming";
            this.bookscoming.Size = new System.Drawing.Size(101, 50);
            this.bookscoming.TabIndex = 6;
            this.bookscoming.Text = "Books on the Way";
            this.bookscoming.UseVisualStyleBackColor = false;
            this.bookscoming.Click += new System.EventHandler(this.bookscoming_Click);
            // 
            // updatebooklistb
            // 
            this.updatebooklistb.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatebooklistb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatebooklistb.Location = new System.Drawing.Point(41, 333);
            this.updatebooklistb.Name = "updatebooklistb";
            this.updatebooklistb.Size = new System.Drawing.Size(101, 50);
            this.updatebooklistb.TabIndex = 7;
            this.updatebooklistb.Text = "Update Books List";
            this.updatebooklistb.UseVisualStyleBackColor = false;
            this.updatebooklistb.Click += new System.EventHandler(this.updatebooklistb_Click);
            // 
            // books_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.updatebooklistb);
            this.Controls.Add(this.bookscoming);
            this.Controls.Add(this.searchbooks);
            this.Controls.Add(this.booksdonate);
            this.Controls.Add(this.listallbooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "books_page";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.books_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listallbooks;
        private System.Windows.Forms.Button booksdonate;
        private System.Windows.Forms.Button searchbooks;
        private System.Windows.Forms.Button bookscoming;
        private System.Windows.Forms.Button updatebooklistb;
    }
}