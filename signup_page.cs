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
    public partial class signup_page : Form
    {
        public signup_page()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void d_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signup2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                if (textBox2.Text != textBox3.Text)
                    MessageBox.Show("Passwords did not match!");
                else if(tckimlikbox.Text == "" || namebox.Text == "" || textBox1.Text=="" || textBox3.Text=="" || textBox2.Text=="" || emailbox.Text =="" || typebox.SelectedText =="")
                    MessageBox.Show("You have to fill the fields.");
                else
                {
                    SqlCommand cmd = new SqlCommand("dbo.Check_User", baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                    cmd.Parameters["@id"].Value = tckimlikbox.Text;

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                    cmd.Parameters["@name"].Value = namebox.Text;

                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar);
                    cmd.Parameters["@phone"].Value = maskedTextBox1.Text;

                    cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                    cmd.Parameters["@email"].Value = emailbox.Text;

                    cmd.Parameters.Add("@type", SqlDbType.NVarChar);
                    cmd.Parameters["@type"].Value = typebox.Text;

                    cmd.Parameters.Add("@username", SqlDbType.NVarChar);
                    cmd.Parameters["@username"].Value = textBox1.Text.Trim();

                    cmd.Parameters.Add("@password", SqlDbType.NVarChar);
                    cmd.Parameters["@password"].Value = textBox2.Text.Trim();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        if (dr["result"].ToString() == "0")
                        {
                            MessageBox.Show("This TC Kimlik is being used by another user. Please check your TC Kimlik again");
                        }
                        else
                        {
                            MessageBox.Show("User account has been generated. Welcome!");

                            User_Info.userid = tckimlikbox.Text.Trim();
                            User_Info.name = namebox.Text.Trim();
                            User_Info.email = emailbox.Text.Trim();
                            User_Info.type = typebox.Text.Trim();
                            User_Info.startdate = DateTime.Now;
                            User_Info.username = textBox1.Text.Trim();
                            User_Info.password = textBox2.Text.Trim();

                            home_page form1 = new home_page();
                            this.Hide();
                            form1.Show();
                        }
                    }
                    baglanti.Close();
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Error!" + hata.Message.ToString());
            }

            
        }

        private void signup_page_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
