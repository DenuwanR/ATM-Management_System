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
using System.Xml.Linq;

namespace WindowsFormsApp18
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AcNO;
        private void addtransaction()
        {
            string trType = "Deposit";
            try
            {
                con.Open();
                string query = "insert into tblTransaction2 values('" + Acc + "', '" +trType + "' , '" + txtDepositA.Text + "' , '" +DateTime.Today.Date.ToString()+"' )";
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
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(txtDepositA.Text==""  || Convert.ToInt32(txtDepositA.Text) <=0)
            {
                MessageBox.Show("Invalid!! Enter the Amount to Deposit");
            }
            else
            {
                string Acc = Login.AcNO;
                try
                {
                    con.Open();
                    string query = "update tblAccount2 set Balance= Balance +" + txtDepositA.Text + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deposited");
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

        private void txtDepositA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
