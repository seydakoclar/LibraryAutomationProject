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
    public partial class list_members : Form
    {
        public list_members()
        {
            InitializeComponent();
        }

        private void list_members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet6.List_Members' table. You can move, or remove it, as needed.
            this.list_MembersTableAdapter.Fill(this.libraryDataSet6.List_Members);

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            members_page form = new members_page();
            this.Hide();
            form.Show();
        }
    }
}
