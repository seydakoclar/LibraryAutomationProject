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
    public partial class listallbooks_page : Form
    {
        public listallbooks_page()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        private void exitb_Click(object sender, EventArgs e)
        {
            books_page form1 = new books_page();
            this.Hide();
            form1.Show();
        }

        private void listallbooks_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.List_All_Books' table. You can move, or remove it, as needed.
            this.list_All_BooksTableAdapter.Fill(this.libraryDataSet1.List_All_Books);

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand cmd = new SqlCommand("dbo.List_All_Books", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
