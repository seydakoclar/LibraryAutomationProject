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
    public partial class searchbook_page : Form
    {
        public searchbook_page()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void searchbook_page_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            books_page frm2 = new books_page();
            this.Hide();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Search_Book", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                cmd.Parameters["@name"].Value = textBox1.Text;

                cmd.Parameters.Add("@author", SqlDbType.NVarChar);
                cmd.Parameters["@author"].Value = textBox2.Text;

                cmd.Parameters.Add("@publisher", SqlDbType.NVarChar);
                cmd.Parameters["@publisher"].Value = textBox3.Text;

                cmd.Parameters.Add("@language", SqlDbType.NVarChar);
                cmd.Parameters["@language"].Value = textBox4.Text;

                cmd.Parameters.Add("@publishyear", SqlDbType.NVarChar);
                cmd.Parameters["@publishyear"].Value = publishyearbox.Text;

                DataTable dt = new DataTable();

                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                    MessageBox.Show("You must fill at least one field.");
                else
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    dataGridView1.DataSource = dt;
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
