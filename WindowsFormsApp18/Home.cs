using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance bal =new Balance();
            this.Hide();
            bal.Show();
        }

        private void btnFastCash_Click(object sender, EventArgs e)
        {
            btn2000 fc = new btn2000();
            this.Hide();
            fc.Show();
        }

        private void btnChngePin_Click(object sender, EventArgs e)
        {
            ChangePIN cp = new ChangePIN();
            cp.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withd = new Withdraw();
            withd.Show();
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Transaction trns = new Transaction();
            trns.Show();
            this.Hide();
        }

        private void lblacno_Click(object sender, EventArgs e)
        {

        }
        public static String AcNO;

        private void Home_Load(object sender, EventArgs e)
        {
            lblacno.Text = "Account Number :" + Login.AcNO;
        }
    }
}
