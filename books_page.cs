using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class books_page : Form
    {
        public books_page()
        {
            InitializeComponent();
        }

        private void booksdonate_Click(object sender, EventArgs e)
        {
            bookdonate_page frm2 = new bookdonate_page();
            this.Hide();
            frm2.Show();

        }

        private void updatebooklistb_Click(object sender, EventArgs e)
        {
            bookupdate_page form1 = new bookupdate_page();
            this.Hide();
            form1.Show();
        }

        private void bookscoming_Click(object sender, EventArgs e)
        {
            bookscoming_page form1 = new bookscoming_page();
            this.Hide();
            form1.Show();
        }

        private void searchbooks_Click(object sender, EventArgs e)
        {
            searchbook_page form1 = new searchbook_page();
            this.Hide();
            form1.Show();
            MessageBox.Show("If you cannot find the book that you are looking for please check the Books on the Way page.");
        }

        private void listallbooks_Click(object sender, EventArgs e)
        {
            listallbooks_page form1 = new listallbooks_page();
            this.Hide();
            form1.Show();
        }

        private void books_page_Load(object sender, EventArgs e)
        {
            if (User_Info.type == "Others" || User_Info.type == "Student" || User_Info.type == "Instructor")
            {
                updatebooklistb.Visible = false;
            }
            else
            {
                updatebooklistb.Visible = true;
            }
        }
    }
}
