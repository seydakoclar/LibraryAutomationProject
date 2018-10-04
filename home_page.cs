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
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void home_page_Load(object sender, EventArgs e)
        {
            if (User_Info.type=="Others" || User_Info.type == "Student" || User_Info.type == "Instructor")
            {
                depositb.Visible = false;
                membersb.Visible = false;
            }
            else
            {
                membersb.Visible = true;
                depositb.Visible = true;
            }
              
        }

        private void booksb_Click(object sender, EventArgs e)
        {
            books_page frm2 = new books_page();
            frm2.Show();
        }

        private void depositb_Click(object sender, EventArgs e)
        {
            borrow_page frm2 = new borrow_page();
            frm2.Show();
        }

        private void membersb_Click(object sender, EventArgs e)
        {
            members_page form1 = new members_page();
            form1.Show();
        }

        private void statisticsb_Click(object sender, EventArgs e)
        {
            try
            {
                int book_count, borrow_count;
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Show_Statistics_Books", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlCommand cmd2 = new SqlCommand("dbo.Show_Statistics_Borrow", baglanti);
                cmd2.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                book_count = Convert.ToInt32(dr["kitap"]);
                dr.Close();

                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                borrow_count = Convert.ToInt32(dr2["emanet"]);
                dr2.Close();

                MessageBox.Show("There are "+book_count+" books in our library\nCurrently "+ borrow_count +" books are borrowed" ,"The statistics can be seen below.");
                baglanti.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Hatası Oluştu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profileb_Click(object sender, EventArgs e)
        {
            profile_page form1 = new profile_page();
            form1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            agenda_page form1 = new agenda_page();
            form1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
