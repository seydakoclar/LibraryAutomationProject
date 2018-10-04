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
    public partial class add_book : Form
    {
        public add_book()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
                    MessageBox.Show("You did not fill the required fields. This way you cannot add a book. Please check informations again.");
                else
                {
                    SqlCommand cmd = new SqlCommand("dbo.Add_Book", baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                    cmd.Parameters["@name"].Value = textBox1.Text;

                    cmd.Parameters.Add("@author", SqlDbType.NVarChar);
                    cmd.Parameters["@author"].Value = textBox2.Text;

                    cmd.Parameters.Add("@publisher", SqlDbType.NVarChar);
                    cmd.Parameters["@publisher"].Value = textBox3.Text;

                    cmd.Parameters.Add("@language", SqlDbType.NVarChar);
                    cmd.Parameters["@language"].Value = textBox4.Text;

                    cmd.Parameters.Add("@page", SqlDbType.NVarChar);
                    cmd.Parameters["@page"].Value = textBox8.Text;

                    cmd.Parameters.Add("@publishyear", SqlDbType.NVarChar);
                    cmd.Parameters["@publishyear"].Value = publishyearbox.Text;

                    cmd.Parameters.Add("@exp", SqlDbType.Text);
                    cmd.Parameters["@exp"].Value = textBox5.Text;

                    cmd.Parameters.Add("@number", SqlDbType.Int);
                    cmd.Parameters["@number"].Value = Convert.ToInt32(textBox6.Text);

                    SqlDataReader dr = cmd.ExecuteReader();

                    MessageBox.Show("In case of any mistakes please check the record again and be sure that it is correct", "Book has been added.");
                    
                    baglanti.Close();
                }
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

        private void exitb_Click(object sender, EventArgs e)
        {
            bookupdate_page frm2 = new bookupdate_page();
            this.Hide();
            frm2.Show();
        }
    }
}
