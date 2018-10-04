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
    public partial class agenda_page : Form
    {
        public agenda_page()
        {
            InitializeComponent();
        }
        appointment_page newMDIChild = new appointment_page();
        mycalendar newMDIChild1 = new mycalendar();
        private void myCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild.form_active == false)
            {
                newMDIChild = new appointment_page();
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        private void makeAnAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild1.form_active1 == false)
            {
                newMDIChild1 = new mycalendar();
                newMDIChild1.MdiParent = this;
                newMDIChild1.Show();
            }
        }
    }
}
