using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AcNO;
        private void populate()
        {
            con.Open();
            string query = "SELECT * from tblTransaction2 where AccNum='" + Acc + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            datagdridview.DataSource = ds.Tables[0];


            con.Close();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            populate();
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
