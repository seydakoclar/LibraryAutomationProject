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
    public partial class confirm_coming_books : Form
    {
        public confirm_coming_books()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void exitb_Click(object sender, EventArgs e)
        {
            members_page form = new members_page();
            this.Hide();
            form.Show();
        }

        private void confirm_coming_books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet81.List_Com_Books' table. You can move, or remove it, as needed.
            this.list_Com_BooksTableAdapter.Fill(this.libraryDataSet81.List_Com_Books);
            // TODO: This line of code loads data into the 'libraryDataSet8.List_Com_Books' table. You can move, or remove it, as needed.
            this.list_Com_BooksTableAdapter.Fill(this.libraryDataSet8.List_Com_Books);
            bCAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            bCDateDataGridViewTextBoxColumn.ReadOnly = true;
            bCExpDataGridViewTextBoxColumn.ReadOnly = true;
            bCLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            bCNameDataGridViewTextBoxColumn.ReadOnly = true;
            bCNumberDataGridViewTextBoxColumn.ReadOnly = true;
            bCPageDataGridViewTextBoxColumn.ReadOnly = true;
            bCPublisherDataGridViewTextBoxColumn.ReadOnly = true;
            bCPublishYearDataGridViewTextBoxColumn.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Confirm_Coming_Books", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@bcid", SqlDbType.Int);
                cmd.Parameters["@bcid"].Value = Convert.ToInt32(value);
                

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                MessageBox.Show("The book is confirmed and added to library.");
                
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
