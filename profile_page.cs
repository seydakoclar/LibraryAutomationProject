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
    public partial class profile_page : Form
    {
        public profile_page()
        {
            InitializeComponent();
        }
        
        edit_profile newMDIChild1 = new edit_profile();
        profile_info newMDIChild = new profile_info();
        see_borrowed newMDIChild2 = new see_borrowed();
        endmembership newMDIChild3 = new endmembership();

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild1.form_active==false)
            {
                newMDIChild1 = new edit_profile();
                newMDIChild1.MdiParent = this;
                newMDIChild1.Show();
            }
        }

        private void profile_page_Load(object sender, EventArgs e)
        {
        }

        private void seeMyProfileInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild.form_active1 == false)
            {
                newMDIChild = new profile_info();
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        private void seeBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild2.form_active2 == false)
            {
                newMDIChild2 = new see_borrowed();
                newMDIChild2.MdiParent = this;
                newMDIChild2.Show();
            }
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild3.form_active3 == false)
            {
                newMDIChild3 = new endmembership();
                newMDIChild3.MdiParent = this;
                newMDIChild3.Show();
            }
        }
    }
}
