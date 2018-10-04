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
    public partial class librarylogin : Form
    {
        public librarylogin()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void libraryform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Login_User", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.NVarChar);
                cmd.Parameters["@username"].Value = textBox1.Text;

                cmd.Parameters.Add("@password", SqlDbType.NVarChar);
                cmd.Parameters["@password"].Value = textBox2.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (string.IsNullOrEmpty(dr["MembershipEndDate"].ToString()))
                    {
                        User_Info.userid = dr["MemberID"].ToString();
                        User_Info.name = dr["MemberName"].ToString();
                        User_Info.email = dr["MemberEmail"].ToString();
                        User_Info.type = dr["MembershipType"].ToString();
                        User_Info.startdate = Convert.ToDateTime(dr["MembershipStartDate"]);
                        User_Info.username = dr["MemberUsername"].ToString();
                        User_Info.password = dr["MemberPassword"].ToString();

                        if (!string.IsNullOrEmpty(dr["MemberCellPhone"].ToString()))
                        {
                            User_Info.phone = dr["MemberCellPhone"].ToString();
                        }

                        home_page form1 = new home_page();
                        this.Hide();
                        form1.Show();
                    }
                    else
                        MessageBox.Show("This user ended his/her membership. You cannot login through this user.");
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Password or Username. Please try again.");
                    
                }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            signup_page frm2 = new signup_page();
            this.Hide();
            frm2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
