using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AcNO;
        int bal;

        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from tblAccount2 where AccNum = '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblBal .Text = "Rs. " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }



        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (txtWithdA.Text == "" )
            {
                MessageBox.Show("Enter the Amount to Withdraw", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt32(txtWithdA.Text) <=0)
            {
                MessageBox.Show("Invalid Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtWithdA.Text) > bal)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -" + txtWithdA.Text + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch(Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                
                
                }
            }
        }
        private void addtransaction()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + txtWithdA.Text + "' , '" + DateTime.Today.Date.ToString() + "' )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
                Login log = new Login();
                log.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void lblBal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtWithdA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
