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
    public partial class btn2000 : Form
    {
        public btn2000()
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
            lblBal.Text = "Rs. " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fastcash_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void lblBal_Click(object sender, EventArgs e)
        {

        }
        private void addtransaction1()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + 100 + "' , '" + DateTime.Today.Date.ToString() + "' )";
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
        private void addtransaction2()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + 500 + "' , '" + DateTime.Today.Date.ToString() + "' )";
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
        private void addtransaction3()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + 1000 + "' , '" + DateTime.Today.Date.ToString() + "' )";
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
        private void addtransaction4()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + 2000 + "' , '" + DateTime.Today.Date.ToString() + "' )";
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
        private void addtransaction5()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + 5000 + "' , '" + DateTime.Today.Date.ToString() + "' )";
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

        private void addtransaction6()
        {
            string trType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" + trType + "' , '" + 10000 + "' , '" + DateTime.Today.Date.ToString() + "' )";
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





        private void btn100_Click(object sender, EventArgs e)
        {
            if (bal<100)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -100"  + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -1000" + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -5000" + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction5();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -500" + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -2000" + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction4();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Insufficient Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance -10000" + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Withdrawed  ");
                    con.Close();
                    addtransaction6();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }
            }
        }
    }
}
