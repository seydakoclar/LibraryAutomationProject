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
    public partial class borrow_page : Form
    {
        public borrow_page()
        {
            InitializeComponent();
        }

        private void deposit_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            give_book frm2 = new give_book();
            this.Hide();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            take_book frm2 = new take_book();
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            see_borrow_list frm2 = new see_borrow_list();
            this.Hide();
            frm2.Show();
        }
    }
}
