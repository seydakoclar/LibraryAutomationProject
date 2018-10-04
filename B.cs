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
    public partial class B : Form
    {
        public B()
        {
            InitializeComponent();
        }
        public bool form_active5 = false;
        public DateTime value;

        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        public class MasaGrup
        {
            public string Bolum1 { get; set; }
            public string Bolum2 { get; set; }
            public string Bolum3 { get; set; }
            public string Bolum4 { get; set; }
            public string Bolum5 { get; set; }
            public string Bolum6 { get; set; }
            public string Bolum7 { get; set; }
            public string Bolum8 { get; set; }
            public string Bolum9 { get; set; }
            public string Bolum910 { get; set; }
            public string Bolum911 { get; set; }
            public string Bolum912 { get; set; }
            public string Bolum913 { get; set; }
            public string Bolum914 { get; set; }
        }
        class Masalar
        {
            public string MasaAdi { get; set; }
            public Int16 MasaBolum { get; set; }

        }

        private void B_Load(object sender, EventArgs e)
        {
            form_active5 = true;

            List<MasaGrup> masaSiraList = new List<MasaGrup>();

            List<Masalar> masaList = new List<Masalar>();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand cmd = new SqlCommand("select * from Seats where Seats LIKE 'B%'", baglanti);

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                var tb = new DataTable();
                tb.Load(dr);

                foreach (DataRow item in tb.Rows)
                {
                    Masalar masaDetail = new Masalar();
                    masaDetail.MasaAdi = item.ItemArray[0].ToString();
                    masaDetail.MasaBolum = Convert.ToInt16(item.ItemArray[1]);
                    masaList.Add(masaDetail);

                }
            }
            dataGridView1.ReadOnly = false;
            int i = 0;
            foreach (var item in masaList)
            {
                i++;
                MasaGrup detail = new MasaGrup();

                if (i == 9 && (masaSiraList.Count == 1 || masaSiraList.Count == 2))
                {
                    i = 0;
                    masaSiraList.Add(detail);
                    i++;
                }
                else if (i == 13)
                {
                    i = 0;
                    masaSiraList.Add(detail);
                    i++;
                }

                if (masaSiraList.Count % 4 == 0 && masaSiraList.Count != 0)
                {
                    masaSiraList.Add(new MasaGrup());
                }
                
                if (masaSiraList.Count == 0)
                {
                    masaSiraList.Add(detail);
                }

                if (item.MasaBolum == 1)
                {
                    detail.Bolum1 = item.MasaAdi;
                }
                if (item.MasaBolum == 2)
                {
                    detail.Bolum2 = item.MasaAdi;
                }
                if (item.MasaBolum == 3)
                {
                    detail.Bolum3 = item.MasaAdi;
                }
                if (item.MasaBolum == 4)
                {
                    detail.Bolum4 = item.MasaAdi;
                }
                if (item.MasaBolum == 6)
                {
                    detail.Bolum6 = item.MasaAdi;
                }
                if (item.MasaBolum == 7)
                {
                    detail.Bolum7 = item.MasaAdi;
                }
                if (item.MasaBolum == 8)
                {
                    detail.Bolum8 = item.MasaAdi;
                }
                if (item.MasaBolum == 9)
                {
                    detail.Bolum9 = item.MasaAdi;
                }
                if (item.MasaBolum == 11)
                {
                    detail.Bolum911 = item.MasaAdi;
                }
                if (item.MasaBolum == 12)
                {
                    detail.Bolum912 = item.MasaAdi;
                }
                if (item.MasaBolum == 13)
                {
                    detail.Bolum913 = item.MasaAdi;
                }
                if (item.MasaBolum == 14)
                {
                    detail.Bolum914 = item.MasaAdi;
                }
               
                var data = (from r in masaSiraList select r).LastOrDefault();
                data.Bolum1 = detail.Bolum1 == null ? data.Bolum1 : detail.Bolum1;
                data.Bolum2 = detail.Bolum2 == null ? data.Bolum2 : detail.Bolum2;
                data.Bolum3 = detail.Bolum3 == null ? data.Bolum3 : detail.Bolum3;
                data.Bolum4 = detail.Bolum4 == null ? data.Bolum4 : detail.Bolum4;
                data.Bolum5 = detail.Bolum5 == null ? data.Bolum5 : detail.Bolum5;
                data.Bolum6 = detail.Bolum6 == null ? data.Bolum6 : detail.Bolum6;
                data.Bolum7 = detail.Bolum7 == null ? data.Bolum7 : detail.Bolum7;
                data.Bolum8 = detail.Bolum8 == null ? data.Bolum8 : detail.Bolum8;
                data.Bolum9 = detail.Bolum9 == null ? data.Bolum9 : detail.Bolum9;
                data.Bolum910 = detail.Bolum910 == null ? data.Bolum910 : detail.Bolum910;
                data.Bolum911 = detail.Bolum911 == null ? data.Bolum911 : detail.Bolum911;
                data.Bolum912 = detail.Bolum912 == null ? data.Bolum912 : detail.Bolum912;
                data.Bolum913 = detail.Bolum913 == null ? data.Bolum913 : detail.Bolum913;
                data.Bolum914 = detail.Bolum914 == null ? data.Bolum914 : detail.Bolum914;
                
            }

            dataGridView1.DataSource = masaSiraList;

            for (int k = 1; k < dataGridView1.Rows.Count; k++)
            {
                if (k % 4 == 0)
                {
                    dataGridView1.Rows[k - 1].Cells[0].Value = null;
                }
            }
            for (int k = 1; k <= dataGridView1.Rows.Count; k++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (dataGridView1.Rows[k - 1].Cells[j].Value != null)
                    {
                        dataGridView1.Rows[k - 1].Cells[j].Style.BackColor = Color.DarkOliveGreen;
                        dataGridView1.Rows[k - 1].Cells[j].Style.ForeColor = Color.White;
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_active5 = false;
            this.Hide();
        }

        private void enabling()
        {
            for (int k = 1; k <= dataGridView1.Rows.Count; k++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (dataGridView1.Rows[k - 1].Cells[j].Style.BackColor == Color.Red)
                    {
                        dataGridView1.Rows[k - 1].Cells[j].Style.BackColor = Color.DarkOliveGreen;
                    }
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                enabling();
                value = Convert.ToDateTime(listBox2.SelectedItem);

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd4 = new SqlCommand("dbo.Get_Full_B", baglanti);
                cmd4.CommandType = CommandType.StoredProcedure;

                cmd4.Parameters.Add("@mytime", SqlDbType.DateTime);
                cmd4.Parameters["@mytime"].Value = value;

                SqlDataReader dr = cmd4.ExecuteReader();

                List<Masalar> masa = new List<Masalar>();
                while (dr.Read())
                {
                    Masalar data = new Masalar();

                    data.MasaBolum = Convert.ToInt16(dr[1]);
                    data.MasaAdi = dr[0].ToString();
                    masa.Add(data);
                }

                foreach (Masalar item in masa)
                {
                    for (int k = 1; k <= dataGridView1.Rows.Count; k++)
                    {
                        if (dataGridView1.Rows[k - 1].Cells[item.MasaBolum - 1].Value != null && dataGridView1.Rows[k - 1].Cells[item.MasaBolum - 1].Value.ToString() == item.MasaAdi)
                        {
                            dataGridView1.Rows[k - 1].Cells[item.MasaBolum - 1].Style.BackColor = Color.Red;
                        }
                    }
                }
                baglanti.Close();
                dataGridView1.ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Hatası Oluştu");
            }
            catch (Exception ex)
            {
                if (listBox2.SelectedItem.ToString() == "")
                    MessageBox.Show("You should choose a valid time.");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd2 = new SqlCommand("dbo.Check_Valid_App", baglanti);
                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.Add("@time", SqlDbType.DateTime);
                cmd2.Parameters["@time"].Value = value;

                cmd2.Parameters.Add("@memberid", SqlDbType.NVarChar);
                cmd2.Parameters["@memberid"].Value = User_Info.userid;

                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
                {
                    MessageBox.Show("This place has been taken. Please select another.");
                }
                else
                {
                    if (dr2.Read() && dr2["result"].ToString() == "1")
                    {
                        MessageBox.Show("You cannot make any appointment. It may be because of two reasons :\n1. Your capacity might be full\n2. You have already an appointment in this hour.");
                        dr2.Close();
                    }
                    else
                    {
                        dr2.Close();

                        SqlCommand cmd3 = new SqlCommand("dbo.Make_Appointment", baglanti);
                        cmd3.CommandType = CommandType.StoredProcedure;

                        cmd3.Parameters.Add("@time", SqlDbType.DateTime);
                        cmd3.Parameters["@time"].Value = value;

                        cmd3.Parameters.Add("@memberid", SqlDbType.NVarChar);
                        cmd3.Parameters["@memberid"].Value = User_Info.userid;

                        cmd3.Parameters.Add("@place", SqlDbType.NVarChar);
                        cmd3.Parameters["@place"].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                        SqlDataReader dr = cmd3.ExecuteReader();

                        MessageBox.Show("Appointment has been generated. Have a good day.");

                        baglanti.Close();

                        this.form_active5 = false;
                        this.Hide();


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

        private void B_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_active5 = false;
        }
    }
}
