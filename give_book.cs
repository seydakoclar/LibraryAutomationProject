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
    public partial class give_book : Form
    {
        public give_book()
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

                SqlCommand cmd = new SqlCommand("dbo.Give_Book", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlCommand cmd2 = new SqlCommand("dbo.Check_User_Borrow", baglanti);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add("@tckimlikno", SqlDbType.NVarChar);
                cmd2.Parameters["@tckimlikno"].Value = textBox1.Text;

                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (textBox1.Text != "" && textBox2.Text != "")
                {

                    if (dr2.Read() && (dr2["result"].ToString()) == "1")
                    {
                        cmd.Parameters.Add("@tckimlikno", SqlDbType.NVarChar);
                        cmd.Parameters["@tckimlikno"].Value = textBox1.Text;

                        cmd.Parameters.Add("@bookid", SqlDbType.NVarChar);
                        cmd.Parameters["@bookid"].Value = textBox2.Text;

                        cmd.Parameters.Add("@startdate", SqlDbType.DateTime);
                        cmd.Parameters["@startdate"].Value = dateTimePicker1.Text;

                        cmd.Parameters.Add("@enddate", SqlDbType.DateTime);
                        cmd.Parameters["@enddate"].Value = dateTimePicker2.Text;

                        cmd.Parameters.Add("@notes", SqlDbType.Text);
                        cmd.Parameters["@notes"].Value = textBox5.Text;

                        dr2.Close();

                        SqlDataReader dr = cmd.ExecuteReader();

                        dr.Read();
                        if(dr["BookCurrentCount"].ToString() =="0")
                            MessageBox.Show("Borrow record cannot be generated.\n"+dr["BookNumber"].ToString()+ "books of this ID are contained in our library. However all of them are borrowed.","Fail!");
                        else
                            MessageBox.Show("Borrow process is successful.\n"+dr["BookNumber"].ToString()+" books of this ID are contained in our library.\nCurrently "+ dr["BookCurrentCount"].ToString()+" books are available", "Success!");
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("This person has already borrowed 5 books, therefore cannot borrow one more until deliver at least one of them. Please inform him/her.");
                        baglanti.Close();
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("You must fill the required fields(TC Kimlik, BookID).");
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
    }
}
