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
    public partial class bookupdate_page : Form
    {
        public bookupdate_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookupdate_page_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_book frm2 = new add_book();
            this.Hide();
            frm2.Show();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            books_page frm2 = new books_page();
            this.Hide();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            change_book frm2 = new change_book();
            this.Hide();
            frm2.Show();
        }
    }
}
