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
    public partial class endmembership : Form
    {
        public endmembership()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        public bool form_active3 = false;

        private void button2_Click(object sender, EventArgs e)
        {
            form_active3 = false;
            this.Hide();
        }

        private void endmembership_Load(object sender, EventArgs e)
        {
            form_active3 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.End_Membership", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                cmd.Parameters["@memberid"].Value = User_Info.userid;
                
                SqlDataReader dr = cmd.ExecuteReader();

                MessageBox.Show("Your membership has ended. Thank you for choosing us. Have a great day.");
                Application.Exit();
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
