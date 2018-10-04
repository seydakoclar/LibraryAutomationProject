using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class bookdonate_page : Form
    {
        private Label bookname;
        private TextBox authorbox;
        private Label bookauthor;
        private Label bookpublishyear;
        private TextBox pagebox;
        private Label bookpage;
        private TextBox languagebox;
        private Label booklanguage;
        private TextBox publisherbox;
        private Label bookpublisher;
        private NumericUpDown publishyearbox;
        private Label notes;
        private TextBox textBox1;
        private Button exitb;
        private Button donateb;
        private Label gobackl;
        private Label donatel;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox namebox;

        public bookdonate_page()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookdonate_page));
            this.bookname = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.authorbox = new System.Windows.Forms.TextBox();
            this.bookauthor = new System.Windows.Forms.Label();
            this.bookpublishyear = new System.Windows.Forms.Label();
            this.pagebox = new System.Windows.Forms.TextBox();
            this.bookpage = new System.Windows.Forms.Label();
            this.languagebox = new System.Windows.Forms.TextBox();
            this.booklanguage = new System.Windows.Forms.Label();
            this.publisherbox = new System.Windows.Forms.TextBox();
            this.bookpublisher = new System.Windows.Forms.Label();
            this.publishyearbox = new System.Windows.Forms.NumericUpDown();
            this.notes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exitb = new System.Windows.Forms.Button();
            this.donateb = new System.Windows.Forms.Button();
            this.gobackl = new System.Windows.Forms.Label();
            this.donatel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.publishyearbox)).BeginInit();
            this.SuspendLayout();
            // 
            // bookname
            // 
            this.bookname.AutoSize = true;
            this.bookname.Location = new System.Drawing.Point(53, 46);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(35, 13);
            this.bookname.TabIndex = 1;
            this.bookname.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(92, 43);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(157, 20);
            this.namebox.TabIndex = 2;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // authorbox
            // 
            this.authorbox.Location = new System.Drawing.Point(92, 96);
            this.authorbox.Name = "authorbox";
            this.authorbox.Size = new System.Drawing.Size(157, 20);
            this.authorbox.TabIndex = 4;
            // 
            // bookauthor
            // 
            this.bookauthor.AutoSize = true;
            this.bookauthor.Location = new System.Drawing.Point(50, 99);
            this.bookauthor.Name = "bookauthor";
            this.bookauthor.Size = new System.Drawing.Size(38, 13);
            this.bookauthor.TabIndex = 3;
            this.bookauthor.Text = "Author";
            this.bookauthor.Click += new System.EventHandler(this.label1_Click);
            // 
            // bookpublishyear
            // 
            this.bookpublishyear.AutoSize = true;
            this.bookpublishyear.Location = new System.Drawing.Point(23, 151);
            this.bookpublishyear.Name = "bookpublishyear";
            this.bookpublishyear.Size = new System.Drawing.Size(66, 13);
            this.bookpublishyear.TabIndex = 5;
            this.bookpublishyear.Text = "Publish Year";
            // 
            // pagebox
            // 
            this.pagebox.Location = new System.Drawing.Point(383, 43);
            this.pagebox.Name = "pagebox";
            this.pagebox.Size = new System.Drawing.Size(157, 20);
            this.pagebox.TabIndex = 14;
            this.pagebox.TextChanged += new System.EventHandler(this.pagebox_TextChanged);
            // 
            // bookpage
            // 
            this.bookpage.AutoSize = true;
            this.bookpage.Location = new System.Drawing.Point(348, 46);
            this.bookpage.Name = "bookpage";
            this.bookpage.Size = new System.Drawing.Size(32, 13);
            this.bookpage.TabIndex = 7;
            this.bookpage.Text = "Page";
            this.bookpage.Click += new System.EventHandler(this.bookpage_Click);
            // 
            // languagebox
            // 
            this.languagebox.Location = new System.Drawing.Point(383, 91);
            this.languagebox.Name = "languagebox";
            this.languagebox.Size = new System.Drawing.Size(157, 20);
            this.languagebox.TabIndex = 15;
            // 
            // booklanguage
            // 
            this.booklanguage.AutoSize = true;
            this.booklanguage.Location = new System.Drawing.Point(325, 94);
            this.booklanguage.Name = "booklanguage";
            this.booklanguage.Size = new System.Drawing.Size(55, 13);
            this.booklanguage.TabIndex = 9;
            this.booklanguage.Text = "Language";
            // 
            // publisherbox
            // 
            this.publisherbox.Location = new System.Drawing.Point(383, 143);
            this.publisherbox.Name = "publisherbox";
            this.publisherbox.Size = new System.Drawing.Size(157, 20);
            this.publisherbox.TabIndex = 16;
            // 
            // bookpublisher
            // 
            this.bookpublisher.AutoSize = true;
            this.bookpublisher.Location = new System.Drawing.Point(329, 146);
            this.bookpublisher.Name = "bookpublisher";
            this.bookpublisher.Size = new System.Drawing.Size(50, 13);
            this.bookpublisher.TabIndex = 11;
            this.bookpublisher.Text = "Publisher";
            // 
            // publishyearbox
            // 
            this.publishyearbox.Location = new System.Drawing.Point(92, 149);
            this.publishyearbox.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.publishyearbox.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.publishyearbox.Name = "publishyearbox";
            this.publishyearbox.Size = new System.Drawing.Size(157, 20);
            this.publishyearbox.TabIndex = 13;
            this.publishyearbox.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.publishyearbox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(44, 235);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(384, 13);
            this.notes.TabIndex = 14;
            this.notes.Text = "Please write down your notes about the book that you want to donate this library";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 20);
            this.textBox1.TabIndex = 18;
            // 
            // exitb
            // 
            this.exitb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitb.BackgroundImage")));
            this.exitb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitb.Location = new System.Drawing.Point(332, 304);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(102, 100);
            this.exitb.TabIndex = 20;
            this.exitb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // donateb
            // 
            this.donateb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("donateb.BackgroundImage")));
            this.donateb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donateb.Location = new System.Drawing.Point(150, 304);
            this.donateb.Name = "donateb";
            this.donateb.Size = new System.Drawing.Size(102, 100);
            this.donateb.TabIndex = 19;
            this.donateb.UseVisualStyleBackColor = true;
            this.donateb.Click += new System.EventHandler(this.donateb_Click);
            // 
            // gobackl
            // 
            this.gobackl.AutoSize = true;
            this.gobackl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gobackl.Location = new System.Drawing.Point(350, 408);
            this.gobackl.Name = "gobackl";
            this.gobackl.Size = new System.Drawing.Size(67, 16);
            this.gobackl.TabIndex = 19;
            this.gobackl.Text = "Go Back";
            this.gobackl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // donatel
            // 
            this.donatel.AutoSize = true;
            this.donatel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donatel.Location = new System.Drawing.Point(172, 408);
            this.donatel.Name = "donatel";
            this.donatel.Size = new System.Drawing.Size(58, 16);
            this.donatel.TabIndex = 20;
            this.donatel.Text = "Donate";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "How many of them";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name, Author, Language, Number parts must be filled. Others are optional.";
            // 
            // bookdonate_page
            // 
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(596, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.donatel);
            this.Controls.Add(this.gobackl);
            this.Controls.Add(this.donateb);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.publishyearbox);
            this.Controls.Add(this.publisherbox);
            this.Controls.Add(this.bookpublisher);
            this.Controls.Add(this.languagebox);
            this.Controls.Add(this.booklanguage);
            this.Controls.Add(this.pagebox);
            this.Controls.Add(this.bookpage);
            this.Controls.Add(this.bookpublishyear);
            this.Controls.Add(this.authorbox);
            this.Controls.Add(this.bookauthor);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.bookname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookdonate_page";
            this.Text = "Book Donation";
            this.Load += new System.EventHandler(this.bookdonate_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publishyearbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookpage_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void donateb_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();


                SqlCommand cmd = new SqlCommand("dbo.Donate_Book", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                if (namebox.Text == "" || authorbox.Text == "" || languagebox.Text == "" || textBox2.Text == "")
                    MessageBox.Show("You did not fill the required fields. This way you cannot donate a book. Please check informations again.");
                else
                {
                    cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                    cmd.Parameters["@memberid"].Value = User_Info.userid;

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                    cmd.Parameters["@name"].Value = namebox.Text;

                    cmd.Parameters.Add("@author", SqlDbType.NVarChar);
                    cmd.Parameters["@author"].Value = authorbox.Text;

                    cmd.Parameters.Add("@publishyear", SqlDbType.NVarChar);
                    cmd.Parameters["@publishyear"].Value = publishyearbox.Text;

                    cmd.Parameters.Add("@page", SqlDbType.NVarChar);
                    cmd.Parameters["@page"].Value = pagebox.Text;

                    cmd.Parameters.Add("@language", SqlDbType.NVarChar);
                    cmd.Parameters["@language"].Value = languagebox.Text;

                    cmd.Parameters.Add("@publisher", SqlDbType.NVarChar);
                    cmd.Parameters["@publisher"].Value = publisherbox.Text;

                    cmd.Parameters.Add("@exp", SqlDbType.Text);
                    cmd.Parameters["@exp"].Value = textBox1.Text;

                    cmd.Parameters.Add("@number", SqlDbType.Text);
                    cmd.Parameters["@number"].Value = textBox2.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    MessageBox.Show("Your donation request has been received. When it is confirmed the system will send you an E-mail.");

                    baglanti.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Hatası Oluştu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            books_page frm2 = new books_page();
            this.Hide();
            frm2.Show();

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pagebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookdonate_page_Load(object sender, EventArgs e)
        {

        }
    }
}
