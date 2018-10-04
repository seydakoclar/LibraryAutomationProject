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
    public partial class change_book : Form
    {
        public change_book()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void button2_Click(object sender, EventArgs e)
        {
            bookupdate_page frm2 = new bookupdate_page();
            this.Hide();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Search_Book_Name", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                cmd.Parameters["@name"].Value = textBox1.Text;

                DataTable dt = new DataTable();

                if (textBox1.Text == "")
                    MessageBox.Show("You must fill the name field.");
                else
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    dataGridView1.DataSource = dt;
                    bookIDDataGridViewTextBoxColumn.ReadOnly = true;
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

       
        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    string value = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    string updatedvalue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
                    var updatedindex = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string index2 = updatedindex.OwningColumn.DataPropertyName.ToString();

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    SqlCommand cmd = new SqlCommand("dbo.Update_Book", baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@bookid", SqlDbType.NVarChar);
                    cmd.Parameters["@bookid"].Value = value;

                    cmd.Parameters.Add("@updatedvalue", SqlDbType.NVarChar);
                    cmd.Parameters["@updatedvalue"].Value = updatedvalue;

                    cmd.Parameters.Add("@index2", SqlDbType.NVarChar);
                    cmd.Parameters["@index2"].Value = index2;

                    SqlDataReader dr = cmd.ExecuteReader();

                    dr.Read();

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
}
