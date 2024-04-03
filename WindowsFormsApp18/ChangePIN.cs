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
    public partial class ChangePIN : Form
    {
        public ChangePIN()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F81GNF66;Initial Catalog=ATMdb;Integrated Security=True");
        string Acc = Login.AcNO;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            if (txtOldPin.Text == "" || txtNewPin.Text == "" || txtCnfrmPin.Text == "")
            {
                MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtOldPin.Text == txtNewPin.Text && txtOldPin.Text == txtCnfrmPin.Text)
            {
                MessageBox.Show("Old and new pins cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNewPin.Text != txtCnfrmPin.Text)
            {
                MessageBox.Show("Invalid PIN Confirmation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();


                    string retrieveQuery = "SELECT PIN FROM tblAccount2 WHERE AccNum='" + Acc + "'";
                    SqlCommand retrieveCmd = new SqlCommand(retrieveQuery, con);
                    string currentPin = retrieveCmd.ExecuteScalar().ToString();

                    if (currentPin == txtOldPin.Text)
                    {

                        string updateQuery = "UPDATE tblAccount2 SET PIN='" + txtNewPin.Text + "' WHERE AccNum='" + Acc + "'";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("PIN Changed Successfully");
                        con.Close();
                        Login log = new Login();
                        log.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect current PIN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtNewPin_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPin.Text.Length > 4)
            {
                // Trim the text to 4 digits
                txtNewPin.Text = txtNewPin.Text.Substring(0, 4);
            }
        }

        private void txtOldPin_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPin.Text.Length > 4)
            {
                // Trim the text to 4 digits
                txtOldPin.Text = txtOldPin.Text.Substring(0, 4);
            }
        }

        private void txtCnfrmPin_TextChanged(object sender, EventArgs e)
        {
            if (txtCnfrmPin.Text.Length > 4)
            {
                // Trim the text to 4 digits
                txtCnfrmPin.Text = txtCnfrmPin.Text.Substring(0, 4);
            }
        }
    }
}
