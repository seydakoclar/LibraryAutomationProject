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
    public partial class coming_books : Form
    {
        public coming_books()
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox6.Text == "" || Convert.ToDateTime(dateTimePicker1.Text) == DateTime.Now)
                    MessageBox.Show("You have to fill Name, Author, Number, Language and Date fields.");
                else
                {
                    SqlCommand cmd = new SqlCommand("dbo.Add_Coming_Books", baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                    cmd.Parameters["@name"].Value = textBox1.Text;

                    cmd.Parameters.Add("@author", SqlDbType.NVarChar);
                    cmd.Parameters["@author"].Value = textBox2.Text;

                    cmd.Parameters.Add("@publisher", SqlDbType.NVarChar);
                    cmd.Parameters["@publisher"].Value = textBox3.Text;

                    cmd.Parameters.Add("@publishyear", SqlDbType.Int);
                    cmd.Parameters["@publishyear"].Value = Convert.ToInt32(textBox4.Text);

                    cmd.Parameters.Add("@language", SqlDbType.Text);
                    cmd.Parameters["@language"].Value = textBox8.Text;

                    cmd.Parameters.Add("@page", SqlDbType.Int);
                    cmd.Parameters["@page"].Value = Convert.ToInt32(textBox5.Text);

                    cmd.Parameters.Add("@number", SqlDbType.Int);
                    cmd.Parameters["@number"].Value = Convert.ToInt32(textBox6.Text);

                    cmd.Parameters.Add("@date", SqlDbType.DateTime);
                    cmd.Parameters["@date"].Value = dateTimePicker1.Text;

                    cmd.Parameters.Add("@exp", SqlDbType.Text);
                    cmd.Parameters["@exp"].Value = textBox7.Text;

                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();

                    MessageBox.Show("Book is added to Coming Books List.");
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
            members_page form = new members_page();
            this.Hide();
            form.Show();
        }
    }
}
