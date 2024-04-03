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
        private void txtAccNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or a control key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Discard the key if it's not a digit or a control key
            }
        }

        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //int balance = 0;    
            if (txtName.Text == "" || txtAccNo.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtPIN.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into tblAccount2 values('" + txtAccNo.Text + "', '" + txtName.Text + "' , '" + dateTimePicker1.Value.Date + "' , '" + txtPhone.Text + "' ,'" + txtAddress.Text + "' , '" + cmbEdu.SelectedItem.ToString() + "' , " + txtPIN.Text + " ,'" + txtBalance.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
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

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
            // Check if the text length exceeds 4 digits
            if (txtAccNo.Text.Length > 4)
            {
                // Trim the text to 4 digits
                txtAccNo.Text = txtAccNo.Text.Substring(0, 4);
            }
        }

        private void txtAccNo_Leave(object sender, EventArgs e)
        {
            // Check if the text length is less than 4 digits
            if (txtAccNo.Text.Length < 4)
            {
                MessageBox.Show("Account number must be a 4-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccNo.Focus();
            }
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            if (txtPIN.Text.Length > 4)
            {
                // Trim the text to 4 digits
                txtPIN.Text = txtPIN.Text.Substring(0, 4);
            }
        }


        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 8)
            {
                // Trim the text to 8 digits
                txtPhone.Text = txtPhone.Text.Substring(0, 8);
            }
        }
        


    }
}
