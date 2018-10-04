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
    public partial class take_book : Form
    {
        public take_book()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void exitb_Click(object sender, EventArgs e)
        {
            borrow_page frm2 = new borrow_page();
            this.Hide();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Take_Book", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@tckimlikno", SqlDbType.NVarChar);
                cmd.Parameters["@tckimlikno"].Value = textBox1.Text;

                cmd.Parameters.Add("@bookid", SqlDbType.NVarChar);
                cmd.Parameters["@bookid"].Value = textBox2.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                
                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    dr.Read();
                    if(dr.RecordsAffected != 0 && dr.RecordsAffected != -1)
                        MessageBox.Show("Book has been taken and records have been fixed.\n"+dr["BookCurrentCount"].ToString() + " books of this ID are now available in the library.","Success!");
                    else
                        MessageBox.Show("There is no such record. Please be sure the informations are correct.");

                }
                else
                   MessageBox.Show("You must fill the required fields.");
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
    }
}
