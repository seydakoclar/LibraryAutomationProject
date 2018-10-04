﻿using System;
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
    public partial class mycalendar : Form
    {
        public mycalendar()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-VJTR20V;Initial Catalog=Library;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);

        public bool form_active1 = false;

        private void mycalendar_Load(object sender, EventArgs e)
        {
            form_active1 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form_active1 = false;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Show_Appointment", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                cmd.Parameters["@memberid"].Value = User_Info.userid;

                DataTable dt = new DataTable();

               using (var da = new SqlDataAdapter(cmd))
               {
                    da.Fill(dt);
               }
               dataGridView1.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand cmd = new SqlCommand("dbo.Show_Past_Appointments", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@memberid", SqlDbType.NVarChar);
                cmd.Parameters["@memberid"].Value = User_Info.userid;

                DataTable dt = new DataTable();

                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                dataGridView1.DataSource = dt;
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
