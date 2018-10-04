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
    public partial class A1 : Form
    {
        public A1()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        public bool form_active2 = false;
        public DateTime value;
 

        private void A_Load(object sender, EventArgs e)
        {
            form_active2 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_active2 = false;
            this.Hide();
        }

        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_active2 = false;
        }

        private void enabling()
        {
            A1.Enabled = true; A1.BackColor = Color.SaddleBrown;
            A2.Enabled = true; A2.BackColor = Color.SaddleBrown;
            A3.Enabled = true; A3.BackColor = Color.SaddleBrown;
            A4.Enabled = true; A4.BackColor = Color.SaddleBrown;
            A5.Enabled = true; A5.BackColor = Color.SaddleBrown;
            A6.Enabled = true; A6.BackColor = Color.SaddleBrown;
            A7.Enabled = true; A7.BackColor = Color.SaddleBrown;
            A8.Enabled = true; A8.BackColor = Color.SaddleBrown;
            A9.Enabled = true; A9.BackColor = Color.SaddleBrown;
            A10.Enabled = true; A10.BackColor = Color.SaddleBrown;
            A11.Enabled = true; A11.BackColor = Color.SaddleBrown;
            A12.Enabled = true; A12.BackColor = Color.SaddleBrown;
            A13.Enabled = true; A13.BackColor = Color.SaddleBrown;
            A14.Enabled = true; A14.BackColor = Color.SaddleBrown;
            A15.Enabled = true; A15.BackColor = Color.SaddleBrown;
            A16.Enabled = true; A16.BackColor = Color.SaddleBrown;
            A17.Enabled = true; A17.BackColor = Color.SaddleBrown;
            A18.Enabled = true; A18.BackColor = Color.SaddleBrown;
            A19.Enabled = true; A19.BackColor = Color.SaddleBrown;
            A20.Enabled = true; A20.BackColor = Color.SaddleBrown;
            A21.Enabled = true; A21.BackColor = Color.SaddleBrown;
            A22.Enabled = true; A22.BackColor = Color.SaddleBrown;
            A23.Enabled = true; A23.BackColor = Color.SaddleBrown;
            A24.Enabled = true; A24.BackColor = Color.SaddleBrown;
            A25.Enabled = true; A25.BackColor = Color.SaddleBrown;
            A26.Enabled = true; A26.BackColor = Color.SaddleBrown;
            A27.Enabled = true; A27.BackColor = Color.SaddleBrown;
            A28.Enabled = true; A28.BackColor = Color.SaddleBrown;
            A29.Enabled = true; A29.BackColor = Color.SaddleBrown;
            A30.Enabled = true; A30.BackColor = Color.SaddleBrown;
            A31.Enabled = true; A31.BackColor = Color.SaddleBrown;
            A32.Enabled = true; A32.BackColor = Color.SaddleBrown;
            A33.Enabled = true; A33.BackColor = Color.SaddleBrown;
            A34.Enabled = true; A34.BackColor = Color.SaddleBrown;
            A35.Enabled = true; A35.BackColor = Color.SaddleBrown;
            A36.Enabled = true; A36.BackColor = Color.SaddleBrown;
            A37.Enabled = true; A37.BackColor = Color.SaddleBrown;
            A38.Enabled = true; A38.BackColor = Color.SaddleBrown;
            A39.Enabled = true; A39.BackColor = Color.SaddleBrown;
            A40.Enabled = true; A40.BackColor = Color.SaddleBrown;
            A41.Enabled = true; A41.BackColor = Color.SaddleBrown;
            A42.Enabled = true; A42.BackColor = Color.SaddleBrown;
            A43.Enabled = true; A43.BackColor = Color.SaddleBrown;
            A44.Enabled = true; A44.BackColor = Color.SaddleBrown;
            A45.Enabled = true; A45.BackColor = Color.SaddleBrown;
            A46.Enabled = true; A46.BackColor = Color.SaddleBrown;
            A47.Enabled = true; A47.BackColor = Color.SaddleBrown;
            A48.Enabled = true; A48.BackColor = Color.SaddleBrown;
            A49.Enabled = true; A49.BackColor = Color.SaddleBrown;
            A50.Enabled = true; A50.BackColor = Color.SaddleBrown;
            A51.Enabled = true; A51.BackColor = Color.SaddleBrown;
            A52.Enabled = true; A52.BackColor = Color.SaddleBrown;
            A53.Enabled = true; A53.BackColor = Color.SaddleBrown;
            A54.Enabled = true; A54.BackColor = Color.SaddleBrown;
            A55.Enabled = true; A55.BackColor = Color.SaddleBrown;
            A56.Enabled = true; A56.BackColor = Color.SaddleBrown;
            A57.Enabled = true; A57.BackColor = Color.SaddleBrown;
            A58.Enabled = true; A58.BackColor = Color.SaddleBrown;
            A59.Enabled = true; A59.BackColor = Color.SaddleBrown;
            A60.Enabled = true; A60.BackColor = Color.SaddleBrown;
            A61.Enabled = true; A61.BackColor = Color.SaddleBrown;
            A62.Enabled = true; A62.BackColor = Color.SaddleBrown;
            A63.Enabled = true; A63.BackColor = Color.SaddleBrown;
            A64.Enabled = true; A64.BackColor = Color.SaddleBrown;
            A65.Enabled = true; A65.BackColor = Color.SaddleBrown;
            A66.Enabled = true; A66.BackColor = Color.SaddleBrown;
            A67.Enabled = true; A67.BackColor = Color.SaddleBrown;
            A68.Enabled = true; A68.BackColor = Color.SaddleBrown;
            A69.Enabled = true; A69.BackColor = Color.SaddleBrown;
            A70.Enabled = true; A70.BackColor = Color.SaddleBrown;
            A71.Enabled = true; A71.BackColor = Color.SaddleBrown;
            A72.Enabled = true; A72.BackColor = Color.SaddleBrown;
        }

        private void ifs(string place_name)
        {

            if (place_name == "A1"){ A1.Enabled = false; A1.BackColor = Color.Red;}
            if (place_name == "A2"){ A2.Enabled = false; A2.BackColor = Color.Red;}
            if (place_name == "A3"){ A3.Enabled = false; A3.BackColor = Color.Red;}
            if (place_name == "A4"){ A4.Enabled = false; A4.BackColor = Color.Red;}
            if (place_name == "A5"){ A5.Enabled = false; A5.BackColor = Color.Red;}
            if (place_name == "A6"){ A6.Enabled = false; A6.BackColor = Color.Red;}
            if (place_name == "A7"){ A7.Enabled = false; A7.BackColor = Color.Red;}
            if (place_name == "A8"){ A8.Enabled = false; A8.BackColor = Color.Red;}
            if (place_name == "A9"){ A9.Enabled = false; A9.BackColor = Color.Red;}
            if (place_name == "A10"){A10.Enabled = false; A10.BackColor = Color.Red;}
            if (place_name == "A11") { A11.Enabled = false; A11.BackColor = Color.Red; }
            if (place_name == "A12"){A12.Enabled = false;A12.BackColor = Color.Red;}
            if (place_name == "A13"){A13.Enabled = false;A13.BackColor = Color.Red;}
            if (place_name == "A14"){A14.Enabled = false;A14.BackColor = Color.Red;}
            if (place_name == "A15"){A15.Enabled = false;A15.BackColor = Color.Red;}
            if (place_name == "A16"){A16.Enabled = false;A16.BackColor = Color.Red;}
            if (place_name == "A17") { A17.Enabled = false; A17.BackColor = Color.Red; }
            if (place_name == "A18"){A18.Enabled = false;A18.BackColor = Color.Red;}
            if (place_name == "A19"){A19.Enabled = false;A19.BackColor = Color.Red;}
            if (place_name == "A20"){A20.Enabled = false;A20.BackColor = Color.Red;}
            if (place_name == "A21") { A21.Enabled = false; A21.BackColor = Color.Red; }
            if (place_name == "A22") { A22.Enabled = false; A22.BackColor = Color.Red; }
            if (place_name == "A23") { A23.Enabled = false; A23.BackColor = Color.Red; }
            if (place_name == "A24") { A24.Enabled = false; A24.BackColor = Color.Red; }
            if (place_name == "A25") { A25.Enabled = false; A25.BackColor = Color.Red; }
            if (place_name == "A26") { A26.Enabled = false; A26.BackColor = Color.Red; }
            if (place_name == "A27") { A27.Enabled = false; A27.BackColor = Color.Red; }
            if (place_name == "A28") { A28.Enabled = false; A28.BackColor = Color.Red; }
            if (place_name == "A29") { A29.Enabled = false; A29.BackColor = Color.Red; }
            if (place_name == "A30") { A30.Enabled = false; A30.BackColor = Color.Red; }
            if (place_name == "A31") { A31.Enabled = false; A31.BackColor = Color.Red; }
            if (place_name == "A32") { A32.Enabled = false; A32.BackColor = Color.Red; }
            if (place_name == "A33") { A33.Enabled = false; A33.BackColor = Color.Red; }
            if (place_name == "A34") { A34.Enabled = false; A34.BackColor = Color.Red; }
            if (place_name == "A35") { A35.Enabled = false; A35.BackColor = Color.Red; }
            if (place_name == "A36") { A36.Enabled = false; A36.BackColor = Color.Red; }
            if (place_name == "A37") { A37.Enabled = false; A37.BackColor = Color.Red; }
            if (place_name == "A38") { A38.Enabled = false; A38.BackColor = Color.Red; }
            if (place_name == "A39") { A39.Enabled = false; A39.BackColor = Color.Red; }
            if (place_name == "A40") { A40.Enabled = false; A40.BackColor = Color.Red; }
            if (place_name == "A41") { A41.Enabled = false; A41.BackColor = Color.Red; }
            if (place_name == "A42") { A42.Enabled = false; A42.BackColor = Color.Red; }
            if (place_name == "A43") { A43.Enabled = false; A43.BackColor = Color.Red; }
            if (place_name == "A44") { A44.Enabled = false; A44.BackColor = Color.Red; }
            if (place_name == "A45") { A45.Enabled = false; A45.BackColor = Color.Red; }
            if (place_name == "A46") { A46.Enabled = false; A46.BackColor = Color.Red; }
            if (place_name == "A47") { A47.Enabled = false; A47.BackColor = Color.Red; }
            if (place_name == "A48") { A48.Enabled = false; A48.BackColor = Color.Red; }
            if (place_name == "A49") { A49.Enabled = false; A49.BackColor = Color.Red; }
            if (place_name == "A50") { A50.Enabled = false; A50.BackColor = Color.Red; }
            if (place_name == "A51") { A51.Enabled = false; A51.BackColor = Color.Red; }
            if (place_name == "A52"){A52.Enabled = false;A52.BackColor = Color.Red;}
            if (place_name == "A53"){A53.Enabled = false;A53.BackColor = Color.Red;}
            if (place_name == "A54"){A54.Enabled = false;A54.BackColor = Color.Red;}
            if (place_name == "A55"){A55.Enabled = false;A55.BackColor = Color.Red;}
            if (place_name == "A56"){A56.Enabled = false;A56.BackColor = Color.Red;}
            if (place_name == "A57"){A57.Enabled = false;A57.BackColor = Color.Red;}
            if (place_name == "A58"){A58.Enabled = false;A58.BackColor = Color.Red;}
            if (place_name == "A59"){A59.Enabled = false;A59.BackColor = Color.Red;}
            if (place_name == "A60"){A60.Enabled = false;A60.BackColor = Color.Red;}
            if (place_name == "A61") { A61.Enabled = false; A61.BackColor = Color.Red; }
            if (place_name == "A62"){A62.Enabled = false;A62.BackColor = Color.Red;}
            if (place_name == "A63"){A63.Enabled = false;A63.BackColor = Color.Red;}
            if (place_name == "A64"){A64.Enabled = false;A64.BackColor = Color.Red;}
            if (place_name == "A65"){A65.Enabled = false;A65.BackColor = Color.Red;}
            if (place_name == "A66"){A66.Enabled = false;A66.BackColor = Color.Red;}
            if (place_name == "A67"){A67.Enabled = false;A67.BackColor = Color.Red;}
            if (place_name == "A68"){A68.Enabled = false;A68.BackColor = Color.Red;}
            if (place_name == "A69"){A69.Enabled = false;A69.BackColor = Color.Red;}
            if (place_name == "A70"){A70.Enabled = false;A70.BackColor = Color.Red;}
            if (place_name == "A71"){A71.Enabled = false;A71.BackColor = Color.Red;}
            if (place_name == "A72"){A72.Enabled = false;A72.BackColor = Color.Red;}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                enabling();
                value = Convert.ToDateTime(listBox1.SelectedItem);

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Get_Full_A", baglanti);
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

                    this.form_active2 = false;
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

        private void A1_Click(object sender, EventArgs e){ main_handler("A1"); }
        private void A2_Click(object sender, EventArgs e) { main_handler("A2"); }
        private void A3_Click(object sender, EventArgs e) { main_handler("A3"); }
        private void A4_Click(object sender, EventArgs e) { main_handler("A4"); }
        private void A5_Click(object sender, EventArgs e) { main_handler("A5"); }
        private void A6_Click(object sender, EventArgs e) { main_handler("A6"); }
        private void A7_Click(object sender, EventArgs e) { main_handler("A7"); }
        private void A8_Click(object sender, EventArgs e) { main_handler("A8"); }
        private void A9_Click(object sender, EventArgs e) { main_handler("A9"); }
        private void A10_Click(object sender, EventArgs e) { main_handler("A10"); }
        private void A11_Click(object sender, EventArgs e) { main_handler("A11"); }
        private void A12_Click(object sender, EventArgs e) { main_handler("A12"); }
        private void A13_Click(object sender, EventArgs e) { main_handler("A13"); }
        private void A14_Click(object sender, EventArgs e) { main_handler("A14"); }
        private void A15_Click(object sender, EventArgs e) { main_handler("A15"); }
        private void A16_Click(object sender, EventArgs e) { main_handler("A16"); }
        private void A17_Click(object sender, EventArgs e) { main_handler("A17"); }
        private void A18_Click(object sender, EventArgs e) { main_handler("A18"); }
        private void A19_Click(object sender, EventArgs e) { main_handler("A19"); }
        private void A20_Click(object sender, EventArgs e) { main_handler("A20"); }
        private void A21_Click(object sender, EventArgs e) { main_handler("A21"); }
        private void A22_Click(object sender, EventArgs e) { main_handler("A22"); }
        private void A23_Click(object sender, EventArgs e) { main_handler("A23"); }
        private void A24_Click(object sender, EventArgs e) { main_handler("A24"); }
        private void A25_Click(object sender, EventArgs e) { main_handler("A25"); }
        private void A26_Click(object sender, EventArgs e) { main_handler("A26"); }
        private void A27_Click(object sender, EventArgs e) { main_handler("A27"); }
        private void A28_Click(object sender, EventArgs e) { main_handler("A28"); }
        private void A29_Click(object sender, EventArgs e) { main_handler("A29"); }
        private void A30_Click(object sender, EventArgs e) { main_handler("A30"); }
        private void A31_Click(object sender, EventArgs e) { main_handler("A31"); }
        private void A32_Click(object sender, EventArgs e) { main_handler("A32"); }
        private void A33_Click(object sender, EventArgs e) { main_handler("A33"); }
        private void A34_Click(object sender, EventArgs e) { main_handler("A34"); }
        private void A35_Click(object sender, EventArgs e) { main_handler("A35"); }
        private void A36_Click(object sender, EventArgs e) { main_handler("A36"); }
        private void A37_Click(object sender, EventArgs e) { main_handler("A37"); }
        private void A38_Click(object sender, EventArgs e) { main_handler("A38"); }
        private void A39_Click(object sender, EventArgs e) { main_handler("A39"); }
        private void A40_Click(object sender, EventArgs e) { main_handler("A40"); }
        private void A41_Click(object sender, EventArgs e) { main_handler("A41"); }
        private void A42_Click(object sender, EventArgs e) { main_handler("A42"); }
        private void A43_Click(object sender, EventArgs e) { main_handler("A43"); }
        private void A44_Click(object sender, EventArgs e) { main_handler("A44"); }
        private void A45_Click(object sender, EventArgs e) { main_handler("A45"); }
        private void A46_Click(object sender, EventArgs e) { main_handler("A46"); }
        private void A47_Click(object sender, EventArgs e) { main_handler("A47"); }
        private void A48_Click(object sender, EventArgs e) { main_handler("A48"); }
        private void A49_Click(object sender, EventArgs e) { main_handler("A49"); }
        private void A50_Click(object sender, EventArgs e) { main_handler("A50"); }
        private void A51_Click(object sender, EventArgs e) { main_handler("A51"); }
        private void A52_Click(object sender, EventArgs e) { main_handler("A52"); }
        private void A53_Click(object sender, EventArgs e) { main_handler("A53"); }
        private void A54_Click(object sender, EventArgs e) { main_handler("A54"); }
        private void A55_Click(object sender, EventArgs e) { main_handler("A55"); }
        private void A56_Click(object sender, EventArgs e) { main_handler("A56"); }
        private void A57_Click(object sender, EventArgs e) { main_handler("A57"); }
        private void A58_Click(object sender, EventArgs e) { main_handler("A58"); }
        private void A59_Click(object sender, EventArgs e) { main_handler("A59"); }
        private void A60_Click(object sender, EventArgs e) { main_handler("A60"); }
        private void A61_Click(object sender, EventArgs e) { main_handler("A61"); }
        private void A62_Click(object sender, EventArgs e) { main_handler("A62"); }
        private void A63_Click(object sender, EventArgs e) { main_handler("A63"); }
        private void A64_Click(object sender, EventArgs e) { main_handler("A64"); }
        private void A65_Click(object sender, EventArgs e) { main_handler("A65"); }
        private void A66_Click(object sender, EventArgs e) { main_handler("A66"); }
        private void A67_Click(object sender, EventArgs e) { main_handler("A67"); }
        private void A68_Click(object sender, EventArgs e) { main_handler("A68"); }
        private void A69_Click(object sender, EventArgs e) { main_handler("A69"); }
        private void A70_Click(object sender, EventArgs e) { main_handler("A70"); }
        private void A71_Click(object sender, EventArgs e) { main_handler("A71"); }
        private void A72_Click(object sender, EventArgs e) { main_handler("A72"); }

    }
}
