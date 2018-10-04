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
    public partial class profile_info : Form
    {
        public profile_info()
        {
            InitializeComponent();
        }
        public bool form_active1 = false;

        private void profile_info_Load(object sender, EventArgs e)
        {
            form_active1 = true;
            label1.Text = User_Info.name;
            label2.Text = User_Info.username;
            label3.Text = User_Info.phone;
            label4.Text = User_Info.email;
            label5.Text = User_Info.type;
            label12.Text = User_Info.startdate.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_active1 = false;
            this.Hide();
        }

        private void profile_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_active1 = false;
        }
    }
}
