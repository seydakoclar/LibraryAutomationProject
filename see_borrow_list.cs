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
    public partial class see_borrow_list : Form
    {
        public see_borrow_list()
        {
            InitializeComponent();
        }

        private void see_borrow_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet3.See_Borrow_List' table. You can move, or remove it, as needed.
            this.see_Borrow_ListTableAdapter.Fill(this.libraryDataSet3.See_Borrow_List);

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            borrow_page form1 = new borrow_page();
            this.Hide();
            form1.Show();
        }
    }
}
