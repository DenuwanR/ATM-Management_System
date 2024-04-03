namespace WindowsFormsApp18
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnFastCash = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChngePin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBalance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTransactions = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnWithdraw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblacno = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 86);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(148, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your Transaction Option";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeposit
            // 
            this.btnDeposit.ActiveBorderThickness = 1;
            this.btnDeposit.ActiveCornerRadius = 20;
            this.btnDeposit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeposit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeposit.BackgroundImage")));
            this.btnDeposit.ButtonText = "Deposit";
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.IdleBorderThickness = 1;
            this.btnDeposit.IdleCornerRadius = 20;
            this.btnDeposit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeposit.IdleForecolor = System.Drawing.Color.White;
            this.btnDeposit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeposit.Location = new System.Drawing.Point(117, 151);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(189, 47);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnFastCash
            // 
            this.btnFastCash.ActiveBorderThickness = 1;
            this.btnFastCash.ActiveCornerRadius = 20;
            this.btnFastCash.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFastCash.ActiveForecolor = System.Drawing.Color.White;
            this.btnFastCash.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFastCash.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFastCash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFastCash.BackgroundImage")));
            this.btnFastCash.ButtonText = "Fast Cash";
            this.btnFastCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFastCash.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCash.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFastCash.IdleBorderThickness = 1;
            this.btnFastCash.IdleCornerRadius = 20;
            this.btnFastCash.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFastCash.IdleForecolor = System.Drawing.Color.White;
            this.btnFastCash.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFastCash.Location = new System.Drawing.Point(117, 237);
            this.btnFastCash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(189, 47);
            this.btnFastCash.TabIndex = 9;
            this.btnFastCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click);
            // 
            // btnChngePin
            // 
            this.btnChngePin.ActiveBorderThickness = 1;
            this.btnChngePin.ActiveCornerRadius = 20;
            this.btnChngePin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnChngePin.ActiveForecolor = System.Drawing.Color.White;
            this.btnChngePin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnChngePin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChngePin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChngePin.BackgroundImage")));
            this.btnChngePin.ButtonText = "Change PIN";
            this.btnChngePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChngePin.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChngePin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnChngePin.IdleBorderThickness = 1;
            this.btnChngePin.IdleCornerRadius = 20;
            this.btnChngePin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChngePin.IdleForecolor = System.Drawing.Color.White;
            this.btnChngePin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChngePin.Location = new System.Drawing.Point(117, 324);
            this.btnChngePin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChngePin.Name = "btnChngePin";
            this.btnChngePin.Size = new System.Drawing.Size(189, 47);
            this.btnChngePin.TabIndex = 10;
            this.btnChngePin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChngePin.Click += new System.EventHandler(this.btnChngePin_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.ActiveBorderThickness = 1;
            this.btnBalance.ActiveCornerRadius = 20;
            this.btnBalance.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBalance.ActiveForecolor = System.Drawing.Color.White;
            this.btnBalance.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBalance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBalance.BackgroundImage")));
            this.btnBalance.ButtonText = "Balance";
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalance.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBalance.IdleBorderThickness = 1;
            this.btnBalance.IdleCornerRadius = 20;
            this.btnBalance.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBalance.IdleForecolor = System.Drawing.Color.White;
            this.btnBalance.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBalance.Location = new System.Drawing.Point(486, 324);
            this.btnBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(189, 47);
            this.btnBalance.TabIndex = 13;
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.ActiveBorderThickness = 1;
            this.btnTransactions.ActiveCornerRadius = 20;
            this.btnTransactions.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTransactions.ActiveForecolor = System.Drawing.Color.White;
            this.btnTransactions.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTransactions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTransactions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransactions.BackgroundImage")));
            this.btnTransactions.ButtonText = "Transactions";
            this.btnTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactions.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTransactions.IdleBorderThickness = 1;
            this.btnTransactions.IdleCornerRadius = 20;
            this.btnTransactions.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTransactions.IdleForecolor = System.Drawing.Color.White;
            this.btnTransactions.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTransactions.Location = new System.Drawing.Point(486, 237);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(189, 47);
            this.btnTransactions.TabIndex = 12;
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.ActiveBorderThickness = 1;
            this.btnWithdraw.ActiveCornerRadius = 20;
            this.btnWithdraw.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnWithdraw.ActiveForecolor = System.Drawing.Color.White;
            this.btnWithdraw.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWithdraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.BackgroundImage")));
            this.btnWithdraw.ButtonText = "Cash Withdraw";
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnWithdraw.IdleBorderThickness = 1;
            this.btnWithdraw.IdleCornerRadius = 20;
            this.btnWithdraw.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWithdraw.IdleForecolor = System.Drawing.Color.White;
            this.btnWithdraw.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWithdraw.Location = new System.Drawing.Point(486, 151);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(189, 47);
            this.btnWithdraw.TabIndex = 11;
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 10);
            this.panel2.TabIndex = 14;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "X";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(729, 1);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(51, 53);
            this.bunifuThinButton21.TabIndex = 56;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ActiveBorderThickness = 1;
            this.btnLogout.ActiveCornerRadius = 20;
            this.btnLogout.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogout.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.IdleBorderThickness = 1;
            this.btnLogout.IdleCornerRadius = 20;
            this.btnLogout.IdleFillColor = System.Drawing.Color.White;
            this.btnLogout.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Location = new System.Drawing.Point(302, 403);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(166, 43);
            this.btnLogout.TabIndex = 54;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblacno
            // 
            this.lblacno.AutoSize = true;
            this.lblacno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblacno.Location = new System.Drawing.Point(265, 101);
            this.lblacno.Name = "lblacno";
            this.lblacno.Size = new System.Drawing.Size(64, 24);
            this.lblacno.TabIndex = 55;
            this.lblacno.Text = "Ac NO";
            this.lblacno.Click += new System.EventHandler(this.lblacno_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 481);
            this.Controls.Add(this.lblacno);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnChngePin);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeposit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFastCash;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChngePin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBalance;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTransactions;
        private Bunifu.Framework.UI.BunifuThinButton2 btnWithdraw;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogout;
        private System.Windows.Forms.Label lblacno;
    }
}