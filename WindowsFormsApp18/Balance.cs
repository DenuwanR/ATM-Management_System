﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");

        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from tblAccount2 where AccNum = '" + lblAcno.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblbal.Text = "Rs. "+dt.Rows[0][0].ToString();
            con.Close();
        }
        
        private void Balance_Load(object sender, EventArgs e)
        {
            lblAcno.Text = Login.AcNO;
            getbalance();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public static String AcNO;
        private void lblAcno_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the default print app
                Process.Start("print");

                // Display "Please Wait" message box
                MessageBox.Show("Please Wait It's on the Way..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Delay for two seconds
                await Task.Delay(1200);

                // Display "Take your printout" message box
                MessageBox.Show("Take Your Printout", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error opening print app: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}