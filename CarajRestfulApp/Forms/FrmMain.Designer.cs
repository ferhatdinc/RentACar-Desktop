namespace CarajRestfulApp.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carBringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementMenuToolStripMenuItem
            // 
            this.managementMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationDetailsToolStripMenuItem,
            this.doReservationToolStripMenuItem,
            this.carOperationsToolStripMenuItem,
            this.firmReportsToolStripMenuItem});
            this.managementMenuToolStripMenuItem.Name = "managementMenuToolStripMenuItem";
            this.managementMenuToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.managementMenuToolStripMenuItem.Text = "Admin Operation";
            // 
            // reservationDetailsToolStripMenuItem
            // 
            this.reservationDetailsToolStripMenuItem.Name = "reservationDetailsToolStripMenuItem";
            this.reservationDetailsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.reservationDetailsToolStripMenuItem.Text = "Reservation Details";
            this.reservationDetailsToolStripMenuItem.Click += new System.EventHandler(this.ReservationDetailsToolStripMenuItem_Click);
            // 
            // doReservationToolStripMenuItem
            // 
            this.doReservationToolStripMenuItem.Name = "doReservationToolStripMenuItem";
            this.doReservationToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.doReservationToolStripMenuItem.Text = "Do Reservation";
            this.doReservationToolStripMenuItem.Click += new System.EventHandler(this.doReservationToolStripMenuItem_Click);
            // 
            // carOperationsToolStripMenuItem
            // 
            this.carOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.updateCarToolStripMenuItem,
            this.carBringToolStripMenuItem});
            this.carOperationsToolStripMenuItem.Name = "carOperationsToolStripMenuItem";
            this.carOperationsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.carOperationsToolStripMenuItem.Text = "Car Operations";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // updateCarToolStripMenuItem
            // 
            this.updateCarToolStripMenuItem.Name = "updateCarToolStripMenuItem";
            this.updateCarToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.updateCarToolStripMenuItem.Text = "Update Car";
            this.updateCarToolStripMenuItem.Click += new System.EventHandler(this.updateCarToolStripMenuItem_Click);
            // 
            // carBringToolStripMenuItem
            // 
            this.carBringToolStripMenuItem.Name = "carBringToolStripMenuItem";
            this.carBringToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.carBringToolStripMenuItem.Text = "Car Bring";
            this.carBringToolStripMenuItem.Click += new System.EventHandler(this.carBringToolStripMenuItem_Click);
            // 
            // firmReportsToolStripMenuItem
            // 
            this.firmReportsToolStripMenuItem.Name = "firmReportsToolStripMenuItem";
            this.firmReportsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.firmReportsToolStripMenuItem.Text = "Firm Reports";
            this.firmReportsToolStripMenuItem.Click += new System.EventHandler(this.firmReportsToolStripMenuItem_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbLogin.BackgroundImage = global::CarajRestfulApp.Properties.Resources.slide_1;
            this.gbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.Controls.Add(this.txtCompanyName);
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbLogin.Location = new System.Drawing.Point(40, 62);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(340, 190);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Company Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Company Name";
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Location = new System.Drawing.Point(32, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 47);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_ClickAsync);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 30);
            this.txtPassword.TabIndex = 6;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(150, 50);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(152, 30);
            this.txtCompanyName.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarajRestfulApp.Properties.Resources.slide_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 701);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ToolStripMenuItem reservationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carBringToolStripMenuItem;
    }
}



