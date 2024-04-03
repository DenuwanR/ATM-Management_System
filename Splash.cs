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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            MyProgressbar.Value = starting;
            lblprogress.Text = "" + starting;
            if(MyProgressbar.Value == 100)
            {
                MyProgressbar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
       }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
