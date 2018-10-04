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
    public partial class appointment_page : Form
    {
        public appointment_page()
        {
            InitializeComponent();
        }
        public bool form_active = false;
        A newA = new A();
        B newB = new B();

        private void button4_Click(object sender, EventArgs e)
        {
            form_active = false;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This place is not opened for appointment.");
        }

        private void appointment_page_Load(object sender, EventArgs e)
        {
            form_active = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (newA.form_active4 == false)
            {
                newA = new A();
                newA.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newB.form_active5 == false)
            {
                newB = new B();
                newB.Show();
            }
        }
    }
}
