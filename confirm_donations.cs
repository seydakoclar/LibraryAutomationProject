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
    public partial class confirm_donations : Form
    {
        public confirm_donations()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void confirm_donations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet71.See_Confirm_Donations' table. You can move, or remove it, as needed.
            this.see_Confirm_DonationsTableAdapter.Fill(this.libraryDataSet71.See_Confirm_Donations);
            // TODO: This line of code loads data into the 'libraryDataSet7.See_Confirm_Donations' table. You can move, or remove it, as needed.
            this.see_Confirm_DonationsTableAdapter.Fill(this.libraryDataSet7.See_Confirm_Donations);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand cmd = new SqlCommand("dbo.See_Confirm_Donations", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            dataGridView1.DataSource = dt;
            bDIDDataGridViewTextBoxColumn.ReadOnly = true;
            bMIDDataGridViewTextBoxColumn.ReadOnly = true;
            bNameDataGridViewTextBoxColumn.ReadOnly = true;
            authorDataGridViewTextBoxColumn.ReadOnly = true;
            publisherDataGridViewTextBoxColumn.ReadOnly = true;
            publishYearDataGridViewTextBoxColumn.ReadOnly = true;
            bPageDataGridViewTextBoxColumn.ReadOnly = true;
            bLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            explanationDataGridViewTextBoxColumn.ReadOnly = true;
            numberDataGridViewTextBoxColumn.ReadOnly = true;
            baglanti.Close();

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            members_page form = new members_page();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                var updatedindex = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string index = updatedindex.OwningColumn.DataPropertyName.ToString();

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Confirm_Donations", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                cmd.Parameters["@memberid"].Value = User_Info.userid;

                cmd.Parameters.Add("@bdid", SqlDbType.NVarChar);
                cmd.Parameters["@bdid"].Value = value;

                cmd.Parameters.Add("@index", SqlDbType.NVarChar);
                cmd.Parameters["@index"].Value = index;

                SqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (index == "Con")
                    MessageBox.Show("Donation is confirmed");
                if (index == "Rec")
                    MessageBox.Show("Donation received");

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
