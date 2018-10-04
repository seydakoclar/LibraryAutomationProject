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
    public partial class bookscoming_page : Form
    {
        public bookscoming_page()
        {
            InitializeComponent();
        }

        private void backb_Click(object sender, EventArgs e)
        {
            books_page form1 = new books_page();
            this.Hide();
            form1.Show();
        }

        private void bookscoming_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.List_Book_Coming' table. You can move, or remove it, as needed.
            this.list_Book_ComingTableAdapter.Fill(this.libraryDataSet2.List_Book_Coming);

        }

        private void bookscoming_page_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet21.List_Book_Coming' table. You can move, or remove it, as needed.
            this.list_Book_ComingTableAdapter1.Fill(this.libraryDataSet21.List_Book_Coming);

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            books_page form1 = new books_page();
            this.Hide();
            form1.Show();
        }
    }
}
