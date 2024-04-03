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

namespace WindowsFormsApp18
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //int balance = 0;    
            if ( txtName.Text == "" || txtAccNo.Text == "" || txtPhone.Text== "" || txtAddress.Text == "" || txtPIN.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                try 
                { 
                    con.Open();
                    string query = "insert into tblAccount2 values('" + txtAccNo.Text + "', '" + txtName.Text + "' , '" + dateTimePicker1.Value.Date + "' , '" + txtPhone.Text + "' ,'" + txtAddress.Text + "' , '" + cmbEdu.SelectedItem.ToString() + "' , " + txtPIN.Text + " ,'"+txtBalance.Text+ "' )";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }
                catch ( Exception ex )
                {
                    MessageBox.Show(ex.Message);
               
                }
                
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
