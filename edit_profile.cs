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
    public partial class edit_profile : Form
    {
        public edit_profile()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        public bool form_active = false;
        
        private void deneme_Load(object sender, EventArgs e)
        {
            label9.Text = "Your Membership Start Date is  " + User_Info.startdate.ToLongDateString();
            form_active = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox6.Text == "" && textBox5.Text == "")
                {
                    MessageBox.Show("You have to fill at least one field.");
                }
                else
                {
                    if (textBox3.Text == User_Info.password)
                    {
                        if (textBox4.Text == textBox2.Text)
                        {
                            SqlCommand cmd = new SqlCommand("dbo.Edit_User", baglanti);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                            cmd.Parameters["@memberid"].Value = User_Info.userid;

                            cmd.Parameters.Add("@username", SqlDbType.NVarChar);
                            cmd.Parameters["@username"].Value = textBox1.Text;

                            cmd.Parameters.Add("@oldpass", SqlDbType.NVarChar);
                            cmd.Parameters["@oldpass"].Value = User_Info.password;

                            cmd.Parameters.Add("@newpass", SqlDbType.NVarChar);
                            cmd.Parameters["@newpass"].Value = textBox2.Text;

                            cmd.Parameters.Add("@phone", SqlDbType.NVarChar);
                            cmd.Parameters["@phone"].Value = textBox5.Text;

                            cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                            cmd.Parameters["@email"].Value = textBox6.Text;

                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read() && dr["result"].ToString() == "1")
                            {
                                MessageBox.Show("Process is successful. Your profile has been updated.");
                                if(textBox2.Text!="")
                                    User_Info.password = textBox2.Text;
                                if (textBox1.Text != "")
                                    User_Info.username = textBox1.Text;
                                if (textBox5.Text != "")
                                    User_Info.phone = textBox5.Text;
                                if (textBox6.Text != "")
                                    User_Info.email = textBox6.Text;
                            }
                            else
                                MessageBox.Show("Someting has gone wrong. Please try again.");

                            baglanti.Close();
                        }
                        else
                        {
                            MessageBox.Show("You entered the new password wrong. Please try again.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You entered your password wrong. Please try again.");
                    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            form_active = false;
            this.Hide();
        }

        private void edit_profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_active = false;
        }
    }
}
