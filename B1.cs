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
    public partial class B1 : Form
    {
        public B1()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        public bool form_active3 = false;
        public DateTime value;

        private void B_Load(object sender, EventArgs e)
        {
            form_active3 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_active3 = false;
            this.Hide();
        }

        private void B_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_active3 = false;
        }

        private void enabling()
        {
            B1.Enabled = true; B1.BackColor = Color.SaddleBrown;
            B2.Enabled = true; B2.BackColor = Color.SaddleBrown;
            B3.Enabled = true; B3.BackColor = Color.SaddleBrown;
            B4.Enabled = true; B4.BackColor = Color.SaddleBrown;
            B5.Enabled = true; B5.BackColor = Color.SaddleBrown;
            B6.Enabled = true; B6.BackColor = Color.SaddleBrown;
            B7.Enabled = true; B7.BackColor = Color.SaddleBrown;
            B8.Enabled = true; B8.BackColor = Color.SaddleBrown;
            B9.Enabled = true; B9.BackColor = Color.SaddleBrown;
            B10.Enabled = true; B10.BackColor = Color.SaddleBrown;
            B11.Enabled = true; B11.BackColor = Color.SaddleBrown;
            B12.Enabled = true; B12.BackColor = Color.SaddleBrown;
            B13.Enabled = true; B13.BackColor = Color.SaddleBrown;
            B14.Enabled = true; B14.BackColor = Color.SaddleBrown;
            B15.Enabled = true; B15.BackColor = Color.SaddleBrown;
            B16.Enabled = true; B16.BackColor = Color.SaddleBrown;
            B17.Enabled = true; B17.BackColor = Color.SaddleBrown;
            B18.Enabled = true; B18.BackColor = Color.SaddleBrown;
            B19.Enabled = true; B19.BackColor = Color.SaddleBrown;
            B20.Enabled = true; B20.BackColor = Color.SaddleBrown;
            B21.Enabled = true; B21.BackColor = Color.SaddleBrown;
            B22.Enabled = true; B22.BackColor = Color.SaddleBrown;
            B23.Enabled = true; B23.BackColor = Color.SaddleBrown;
            B24.Enabled = true; B24.BackColor = Color.SaddleBrown;
            B25.Enabled = true; B25.BackColor = Color.SaddleBrown;
            B26.Enabled = true; B26.BackColor = Color.SaddleBrown;
            B27.Enabled = true; B27.BackColor = Color.SaddleBrown;
            B28.Enabled = true; B28.BackColor = Color.SaddleBrown;
            B29.Enabled = true; B29.BackColor = Color.SaddleBrown;
            B30.Enabled = true; B30.BackColor = Color.SaddleBrown;
            B31.Enabled = true; B31.BackColor = Color.SaddleBrown;
            B32.Enabled = true; B32.BackColor = Color.SaddleBrown;
            B33.Enabled = true; B33.BackColor = Color.SaddleBrown;
            B34.Enabled = true; B34.BackColor = Color.SaddleBrown;
            B35.Enabled = true; B35.BackColor = Color.SaddleBrown;
            B36.Enabled = true; B36.BackColor = Color.SaddleBrown;
            B37.Enabled = true; B37.BackColor = Color.SaddleBrown;
            B38.Enabled = true; B38.BackColor = Color.SaddleBrown;
            B39.Enabled = true; B39.BackColor = Color.SaddleBrown;
            B40.Enabled = true; B40.BackColor = Color.SaddleBrown;
            B41.Enabled = true; B41.BackColor = Color.SaddleBrown;
            B42.Enabled = true; B42.BackColor = Color.SaddleBrown;
            B43.Enabled = true; B43.BackColor = Color.SaddleBrown;
            B44.Enabled = true; B44.BackColor = Color.SaddleBrown;
            B45.Enabled = true; B45.BackColor = Color.SaddleBrown;
            B46.Enabled = true; B46.BackColor = Color.SaddleBrown;
            B47.Enabled = true; B47.BackColor = Color.SaddleBrown;
            B48.Enabled = true; B48.BackColor = Color.SaddleBrown;
            B49.Enabled = true; B49.BackColor = Color.SaddleBrown;
            B50.Enabled = true; B50.BackColor = Color.SaddleBrown;
            B51.Enabled = true; B51.BackColor = Color.SaddleBrown;
            B52.Enabled = true; B52.BackColor = Color.SaddleBrown;
            B53.Enabled = true; B53.BackColor = Color.SaddleBrown;
            B54.Enabled = true; B54.BackColor = Color.SaddleBrown;
            B55.Enabled = true; B55.BackColor = Color.SaddleBrown;
            B56.Enabled = true; B56.BackColor = Color.SaddleBrown;
            B57.Enabled = true; B57.BackColor = Color.SaddleBrown;
            B58.Enabled = true; B58.BackColor = Color.SaddleBrown;
            B59.Enabled = true; B59.BackColor = Color.SaddleBrown;
            B60.Enabled = true; B60.BackColor = Color.SaddleBrown;
            B61.Enabled = true; B61.BackColor = Color.SaddleBrown;
            B62.Enabled = true; B62.BackColor = Color.SaddleBrown;
            B63.Enabled = true; B63.BackColor = Color.SaddleBrown;
            B64.Enabled = true; B64.BackColor = Color.SaddleBrown;
            B65.Enabled = true; B65.BackColor = Color.SaddleBrown;
            B66.Enabled = true; B66.BackColor = Color.SaddleBrown;
            B67.Enabled = true; B67.BackColor = Color.SaddleBrown;
            B68.Enabled = true; B68.BackColor = Color.SaddleBrown;
            B69.Enabled = true; B69.BackColor = Color.SaddleBrown;
            B70.Enabled = true; B70.BackColor = Color.SaddleBrown;
            B71.Enabled = true; B71.BackColor = Color.SaddleBrown;
            B72.Enabled = true; B72.BackColor = Color.SaddleBrown;
            B73.Enabled = true; B73.BackColor = Color.SaddleBrown;
            B74.Enabled = true; B74.BackColor = Color.SaddleBrown;
            B75.Enabled = true; B75.BackColor = Color.SaddleBrown;
            B76.Enabled = true; B76.BackColor = Color.SaddleBrown;
            B77.Enabled = true; B77.BackColor = Color.SaddleBrown;
            B78.Enabled = true; B78.BackColor = Color.SaddleBrown;
            B79.Enabled = true; B79.BackColor = Color.SaddleBrown;
            B80.Enabled = true; B80.BackColor = Color.SaddleBrown;
            B81.Enabled = true; B81.BackColor = Color.SaddleBrown;
            B82.Enabled = true; B82.BackColor = Color.SaddleBrown;
            B83.Enabled = true; B83.BackColor = Color.SaddleBrown;
            B84.Enabled = true; B84.BackColor = Color.SaddleBrown;
            B85.Enabled = true; B85.BackColor = Color.SaddleBrown;
            B86.Enabled = true; B86.BackColor = Color.SaddleBrown;
            B87.Enabled = true; B87.BackColor = Color.SaddleBrown;
            B88.Enabled = true; B88.BackColor = Color.SaddleBrown;
            B89.Enabled = true; B89.BackColor = Color.SaddleBrown;
            B90.Enabled = true; B90.BackColor = Color.SaddleBrown;
            B91.Enabled = true; B91.BackColor = Color.SaddleBrown;
            B92.Enabled = true; B92.BackColor = Color.SaddleBrown;
            B93.Enabled = true; B93.BackColor = Color.SaddleBrown;
            B94.Enabled = true; B94.BackColor = Color.SaddleBrown;
            B95.Enabled = true; B95.BackColor = Color.SaddleBrown;
            B96.Enabled = true; B96.BackColor = Color.SaddleBrown;
            B97.Enabled = true; B97.BackColor = Color.SaddleBrown;
            B98.Enabled = true; B98.BackColor = Color.SaddleBrown;
            B99.Enabled = true; B99.BackColor = Color.SaddleBrown;
            B100.Enabled = true; B100.BackColor = Color.SaddleBrown;
        }

        private void ifs(string place_name)
        {

            if (place_name == "B1") { B1.Enabled = false; B1.BackColor = Color.Red; }
            if (place_name == "B2") { B2.Enabled = false; B2.BackColor = Color.Red; }
            if (place_name == "B3") { B3.Enabled = false; B3.BackColor = Color.Red; }
            if (place_name == "B4") { B4.Enabled = false; B4.BackColor = Color.Red; }
            if (place_name == "B5") { B5.Enabled = false; B5.BackColor = Color.Red; }
            if (place_name == "B6") { B6.Enabled = false; B6.BackColor = Color.Red; }
            if (place_name == "B7") { B7.Enabled = false; B7.BackColor = Color.Red; }
            if (place_name == "B8") { B8.Enabled = false; B8.BackColor = Color.Red; }
            if (place_name == "B9") { B9.Enabled = false; B9.BackColor = Color.Red; }
            if (place_name == "B10") { B10.Enabled = false; B10.BackColor = Color.Red; }
            if (place_name == "B11") { B11.Enabled = false; B11.BackColor = Color.Red; }
            if (place_name == "B12") { B12.Enabled = false; B12.BackColor = Color.Red; }
            if (place_name == "B13") { B13.Enabled = false; B13.BackColor = Color.Red; }
            if (place_name == "B14") { B14.Enabled = false; B14.BackColor = Color.Red; }
            if (place_name == "B15") { B15.Enabled = false; B15.BackColor = Color.Red; }
            if (place_name == "B16") { B16.Enabled = false; B16.BackColor = Color.Red; }
            if (place_name == "B17") { B17.Enabled = false; B17.BackColor = Color.Red; }
            if (place_name == "B18") { B18.Enabled = false; B18.BackColor = Color.Red; }
            if (place_name == "B19") { B19.Enabled = false; B19.BackColor = Color.Red; }
            if (place_name == "B20") { B20.Enabled = false; B20.BackColor = Color.Red; }
            if (place_name == "B21") { B21.Enabled = false; B21.BackColor = Color.Red; }
            if (place_name == "B22") { B22.Enabled = false; B22.BackColor = Color.Red; }
            if (place_name == "B23") { B23.Enabled = false; B23.BackColor = Color.Red; }
            if (place_name == "B24") { B24.Enabled = false; B24.BackColor = Color.Red; }
            if (place_name == "B25") { B25.Enabled = false; B25.BackColor = Color.Red; }
            if (place_name == "B26") { B26.Enabled = false; B26.BackColor = Color.Red; }
            if (place_name == "B27") { B27.Enabled = false; B27.BackColor = Color.Red; }
            if (place_name == "B28") { B28.Enabled = false; B28.BackColor = Color.Red; }
            if (place_name == "B29") { B29.Enabled = false; B29.BackColor = Color.Red; }
            if (place_name == "B30") { B30.Enabled = false; B30.BackColor = Color.Red; }
            if (place_name == "B31") { B31.Enabled = false; B31.BackColor = Color.Red; }
            if (place_name == "B32") { B32.Enabled = false; B32.BackColor = Color.Red; }
            if (place_name == "B33") { B33.Enabled = false; B33.BackColor = Color.Red; }
            if (place_name == "B34") { B34.Enabled = false; B34.BackColor = Color.Red; }
            if (place_name == "B35") { B35.Enabled = false; B35.BackColor = Color.Red; }
            if (place_name == "B36") { B36.Enabled = false; B36.BackColor = Color.Red; }
            if (place_name == "B37") { B37.Enabled = false; B37.BackColor = Color.Red; }
            if (place_name == "B38") { B38.Enabled = false; B38.BackColor = Color.Red; }
            if (place_name == "B39") { B39.Enabled = false; B39.BackColor = Color.Red; }
            if (place_name == "B40") { B40.Enabled = false; B40.BackColor = Color.Red; }
            if (place_name == "B41") { B41.Enabled = false; B41.BackColor = Color.Red; }
            if (place_name == "B42") { B42.Enabled = false; B42.BackColor = Color.Red; }
            if (place_name == "B43") { B43.Enabled = false; B43.BackColor = Color.Red; }
            if (place_name == "B44") { B44.Enabled = false; B44.BackColor = Color.Red; }
            if (place_name == "B45") { B45.Enabled = false; B45.BackColor = Color.Red; }
            if (place_name == "B46") { B46.Enabled = false; B46.BackColor = Color.Red; }
            if (place_name == "B47") { B47.Enabled = false; B47.BackColor = Color.Red; }
            if (place_name == "B48") { B48.Enabled = false; B48.BackColor = Color.Red; }
            if (place_name == "B49") { B49.Enabled = false; B49.BackColor = Color.Red; }
            if (place_name == "B50") { B50.Enabled = false; B50.BackColor = Color.Red; }
            if (place_name == "B51") { B51.Enabled = false; B51.BackColor = Color.Red; }
            if (place_name == "B52") { B52.Enabled = false; B52.BackColor = Color.Red; }
            if (place_name == "B53") { B53.Enabled = false; B53.BackColor = Color.Red; }
            if (place_name == "B54") { B54.Enabled = false; B54.BackColor = Color.Red; }
            if (place_name == "B55") { B55.Enabled = false; B55.BackColor = Color.Red; }
            if (place_name == "B56") { B56.Enabled = false; B56.BackColor = Color.Red; }
            if (place_name == "B57") { B57.Enabled = false; B57.BackColor = Color.Red; }
            if (place_name == "B58") { B58.Enabled = false; B58.BackColor = Color.Red; }
            if (place_name == "B59") { B59.Enabled = false; B59.BackColor = Color.Red; }
            if (place_name == "B60") { B60.Enabled = false; B60.BackColor = Color.Red; }
            if (place_name == "B61") { B61.Enabled = false; B61.BackColor = Color.Red; }
            if (place_name == "B62") { B62.Enabled = false; B62.BackColor = Color.Red; }
            if (place_name == "B63") { B63.Enabled = false; B63.BackColor = Color.Red; }
            if (place_name == "B64") { B64.Enabled = false; B64.BackColor = Color.Red; }
            if (place_name == "B65") { B65.Enabled = false; B65.BackColor = Color.Red; }
            if (place_name == "B66") { B66.Enabled = false; B66.BackColor = Color.Red; }
            if (place_name == "B67") { B67.Enabled = false; B67.BackColor = Color.Red; }
            if (place_name == "B68") { B68.Enabled = false; B68.BackColor = Color.Red; }
            if (place_name == "B69") { B69.Enabled = false; B69.BackColor = Color.Red; }
            if (place_name == "B70") { B70.Enabled = false; B70.BackColor = Color.Red; }
            if (place_name == "B71") { B71.Enabled = false; B71.BackColor = Color.Red; }
            if (place_name == "B72") { B72.Enabled = false; B72.BackColor = Color.Red; }
            if (place_name == "B73") { B73.Enabled = false; B73.BackColor = Color.Red; }
            if (place_name == "B74") { B74.Enabled = false; B74.BackColor = Color.Red; }
            if (place_name == "B75") { B75.Enabled = false; B75.BackColor = Color.Red; }
            if (place_name == "B76") { B76.Enabled = false; B76.BackColor = Color.Red; }
            if (place_name == "B77") { B77.Enabled = false; B77.BackColor = Color.Red; }
            if (place_name == "B78") { B78.Enabled = false; B78.BackColor = Color.Red; }
            if (place_name == "B79") { B79.Enabled = false; B79.BackColor = Color.Red; }
            if (place_name == "B80") { B80.Enabled = false; B80.BackColor = Color.Red; }
            if (place_name == "B81") { B81.Enabled = false; B81.BackColor = Color.Red; }
            if (place_name == "B82") { B82.Enabled = false; B82.BackColor = Color.Red; }
            if (place_name == "B83") { B83.Enabled = false; B83.BackColor = Color.Red; }
            if (place_name == "B84") { B84.Enabled = false; B84.BackColor = Color.Red; }
            if (place_name == "B85") { B85.Enabled = false; B85.BackColor = Color.Red; }
            if (place_name == "B86") { B86.Enabled = false; B86.BackColor = Color.Red; }
            if (place_name == "B87") { B87.Enabled = false; B87.BackColor = Color.Red; }
            if (place_name == "B88") { B88.Enabled = false; B88.BackColor = Color.Red; }
            if (place_name == "B89") { B89.Enabled = false; B89.BackColor = Color.Red; }
            if (place_name == "B90") { B90.Enabled = false; B90.BackColor = Color.Red; }
            if (place_name == "B91") { B91.Enabled = false; B91.BackColor = Color.Red; }
            if (place_name == "B92") { B92.Enabled = false; B92.BackColor = Color.Red; }
            if (place_name == "B93") { B93.Enabled = false; B93.BackColor = Color.Red; }
            if (place_name == "B94") { B94.Enabled = false; B94.BackColor = Color.Red; }
            if (place_name == "B95") { B95.Enabled = false; B95.BackColor = Color.Red; }
            if (place_name == "B96") { B96.Enabled = false; B96.BackColor = Color.Red; }
            if (place_name == "B97") { B97.Enabled = false; B97.BackColor = Color.Red; }
            if (place_name == "B98") { B98.Enabled = false; B98.BackColor = Color.Red; }
            if (place_name == "B99") { B99.Enabled = false; B99.BackColor = Color.Red; }
            if (place_name == "B100") { B100.Enabled = false; B100.BackColor = Color.Red; }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                enabling();
                value = Convert.ToDateTime(listBox1.SelectedItem);

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Get_Full_B", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@mytime", SqlDbType.DateTime);
                cmd.Parameters["@mytime"].Value = value;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string place_name = dr.GetString(0);
                    ifs(place_name);
                }
                baglanti.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Hatası Oluştu");
            }
            catch (Exception ex)
            {
                if (listBox1.SelectedItem.ToString() == "")
                    MessageBox.Show("You should choose a valid time.");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void main_handler(string e)
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

                if (dr2.Read() && dr2["result"].ToString() == "1")
                {
                    MessageBox.Show("You cannot make any appointment. It may be because of two reasons :\n1. Your capacity might be full\n2. You have already an appointment in this hour.");
                    dr2.Close();
                }
                else
                {
                    dr2.Close();

                    SqlCommand cmd = new SqlCommand("dbo.Make_Appointment", baglanti);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@time", SqlDbType.DateTime);
                    cmd.Parameters["@time"].Value = value;

                    cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                    cmd.Parameters["@memberid"].Value = User_Info.userid;

                    cmd.Parameters.Add("@place", SqlDbType.NVarChar);
                    cmd.Parameters["@place"].Value = e;

                    SqlDataReader dr = cmd.ExecuteReader();

                    baglanti.Close();

                    this.form_active3 = false;
                    this.Hide();


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

        private void B1_Click(object sender, EventArgs e) { main_handler("B1"); }
        private void B2_Click(object sender, EventArgs e) { main_handler("B2"); }
        private void B3_Click(object sender, EventArgs e) { main_handler("B3"); }
        private void B4_Click(object sender, EventArgs e) { main_handler("B4"); }
        private void B5_Click(object sender, EventArgs e) { main_handler("B5"); }
        private void B6_Click(object sender, EventArgs e) { main_handler("B6"); }
        private void B7_Click(object sender, EventArgs e) { main_handler("B7"); }
        private void A8_Click(object sender, EventArgs e) { main_handler("A8"); }
        private void A9_Click(object sender, EventArgs e) { main_handler("A9"); }
        private void B10_Click(object sender, EventArgs e) { main_handler("B10"); }
        private void B11_Click(object sender, EventArgs e) { main_handler("B11"); }
        private void B12_Click(object sender, EventArgs e) { main_handler("B12"); }
        private void B13_Click(object sender, EventArgs e) { main_handler("B13"); }
        private void B14_Click(object sender, EventArgs e) { main_handler("B14"); }
        private void B15_Click(object sender, EventArgs e) { main_handler("B15"); }
        private void B16_Click(object sender, EventArgs e) { main_handler("B16"); }
        private void B17_Click(object sender, EventArgs e) { main_handler("B17"); }
        private void B18_Click(object sender, EventArgs e) { main_handler("B18"); }
        private void B19_Click(object sender, EventArgs e) { main_handler("B19"); }
        private void B20_Click(object sender, EventArgs e) { main_handler("B20"); }
        private void B21_Click(object sender, EventArgs e) { main_handler("B21"); }
        private void B22_Click(object sender, EventArgs e) { main_handler("B22"); }
        private void B23_Click(object sender, EventArgs e) { main_handler("B23"); }
        private void B24_Click(object sender, EventArgs e) { main_handler("B24"); }
        private void B25_Click(object sender, EventArgs e) { main_handler("B25"); }
        private void B26_Click(object sender, EventArgs e) { main_handler("B26"); }
        private void B27_Click(object sender, EventArgs e) { main_handler("B27"); }
        private void B28_Click(object sender, EventArgs e) { main_handler("B28"); }
        private void B29_Click(object sender, EventArgs e) { main_handler("B29"); }
        private void B30_Click(object sender, EventArgs e) { main_handler("B30"); }
        private void B31_Click(object sender, EventArgs e) { main_handler("B31"); }
        private void B32_Click(object sender, EventArgs e) { main_handler("B32"); }
        private void B33_Click(object sender, EventArgs e) { main_handler("B33"); }
        private void B34_Click(object sender, EventArgs e) { main_handler("B34"); }
        private void B35_Click(object sender, EventArgs e) { main_handler("B35"); }
        private void B36_Click(object sender, EventArgs e) { main_handler("B36"); }
        private void B37_Click(object sender, EventArgs e) { main_handler("B37"); }
        private void B38_Click(object sender, EventArgs e) { main_handler("B38"); }
        private void B39_Click(object sender, EventArgs e) { main_handler("B39"); }
        private void B40_Click(object sender, EventArgs e) { main_handler("B40"); }
        private void B41_Click(object sender, EventArgs e) { main_handler("B41"); }
        private void B42_Click(object sender, EventArgs e) { main_handler("B42"); }
        private void B43_Click(object sender, EventArgs e) { main_handler("B43"); }
        private void B44_Click(object sender, EventArgs e) { main_handler("B44"); }
        private void B45_Click(object sender, EventArgs e) { main_handler("B45"); }
        private void B46_Click(object sender, EventArgs e) { main_handler("B46"); }
        private void B47_Click(object sender, EventArgs e) { main_handler("B47"); }
        private void B48_Click(object sender, EventArgs e) { main_handler("B48"); }
        private void B49_Click(object sender, EventArgs e) { main_handler("B49"); }
        private void B50_Click(object sender, EventArgs e) { main_handler("B50"); }
        private void B51_Click(object sender, EventArgs e) { main_handler("B51"); }
        private void B52_Click(object sender, EventArgs e) { main_handler("B52"); }
        private void B53_Click(object sender, EventArgs e) { main_handler("B53"); }
        private void B54_Click(object sender, EventArgs e) { main_handler("B54"); }
        private void B55_Click(object sender, EventArgs e) { main_handler("B55"); }
        private void B56_Click(object sender, EventArgs e) { main_handler("B56"); }
        private void B57_Click(object sender, EventArgs e) { main_handler("B57"); }
        private void B58_Click(object sender, EventArgs e) { main_handler("B58"); }
        private void B59_Click(object sender, EventArgs e) { main_handler("B59"); }
        private void B60_Click(object sender, EventArgs e) { main_handler("B60"); }
        private void B61_Click(object sender, EventArgs e) { main_handler("B61"); }
        private void B62_Click(object sender, EventArgs e) { main_handler("B62"); }
        private void B63_Click(object sender, EventArgs e) { main_handler("B63"); }
        private void B64_Click(object sender, EventArgs e) { main_handler("B64"); }
        private void B65_Click(object sender, EventArgs e) { main_handler("B65"); }
        private void B66_Click(object sender, EventArgs e) { main_handler("B66"); }
        private void B67_Click(object sender, EventArgs e) { main_handler("B67"); }
        private void B68_Click(object sender, EventArgs e) { main_handler("B68"); }
        private void B69_Click(object sender, EventArgs e) { main_handler("B69"); }
        private void B70_Click(object sender, EventArgs e) { main_handler("B70"); }
        private void B71_Click(object sender, EventArgs e) { main_handler("B71"); }
        private void B72_Click(object sender, EventArgs e) { main_handler("B72"); }
        private void B73_Click(object sender, EventArgs e) { main_handler("B73"); }
        private void B74_Click(object sender, EventArgs e) { main_handler("B74"); }
        private void B75_Click(object sender, EventArgs e) { main_handler("B75"); }
        private void B76_Click(object sender, EventArgs e) { main_handler("B76"); }
        private void B77_Click(object sender, EventArgs e) { main_handler("B77"); }
        private void B78_Click(object sender, EventArgs e) { main_handler("B78"); }
        private void B79_Click(object sender, EventArgs e) { main_handler("B79"); }
        private void B80_Click(object sender, EventArgs e) { main_handler("B80"); }
        private void B81_Click(object sender, EventArgs e) { main_handler("B81"); }
        private void B82_Click(object sender, EventArgs e) { main_handler("B82"); }
        private void B83_Click(object sender, EventArgs e) { main_handler("B83"); }
        private void B84_Click(object sender, EventArgs e) { main_handler("B84"); }
        private void B85_Click(object sender, EventArgs e) { main_handler("B85"); }
        private void B86_Click(object sender, EventArgs e) { main_handler("B86"); }
        private void B87_Click(object sender, EventArgs e) { main_handler("B87"); }
        private void B88_Click(object sender, EventArgs e) { main_handler("B88"); }
        private void B89_Click(object sender, EventArgs e) { main_handler("B89"); }
        private void B90_Click(object sender, EventArgs e) { main_handler("B90"); }
        private void B91_Click(object sender, EventArgs e) { main_handler("B91"); }
        private void B92_Click(object sender, EventArgs e) { main_handler("B92"); }
        private void B93_Click(object sender, EventArgs e) { main_handler("B93"); }
        private void B94_Click(object sender, EventArgs e) { main_handler("B94"); }
        private void B95_Click(object sender, EventArgs e) { main_handler("B95"); }
        private void B96_Click(object sender, EventArgs e) { main_handler("B96"); }
        private void B97_Click(object sender, EventArgs e) { main_handler("B97"); }
        private void B98_Click(object sender, EventArgs e) { main_handler("B98"); }
        private void B99_Click(object sender, EventArgs e) { main_handler("B99"); }
        private void B100_Click(object sender, EventArgs e) { main_handler("B100"); }
       
    }
}
