namespace CarajDesktop.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationRequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginToolStripMenuItem,
            this.yöneticiİşlemleriToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.AutoSize = false;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.LoginToolStripMenuItem.Text = "Login";
            this.LoginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // yöneticiİşlemleriToolStripMenuItem
            // 
            this.yöneticiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReservationDetailsToolStripMenuItem,
            this.ReservationRequestsToolStripMenuItem,
            this.DoReservationsToolStripMenuItem,
            this.CarOperationsToolStripMenuItem});
            this.yöneticiİşlemleriToolStripMenuItem.Name = "yöneticiİşlemleriToolStripMenuItem";
            this.yöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.yöneticiİşlemleriToolStripMenuItem.Text = "Admin Operations";
            // 
            // ReservationDetailsToolStripMenuItem
            // 
            this.ReservationDetailsToolStripMenuItem.Name = "ReservationDetailsToolStripMenuItem";
            this.ReservationDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ReservationDetailsToolStripMenuItem.Text = "Reservation Details";
            this.ReservationDetailsToolStripMenuItem.Click += new System.EventHandler(this.ReservationDetailsToolStripMenuItem_Click);
            // 
            // ReservationRequestsToolStripMenuItem
            // 
            this.ReservationRequestsToolStripMenuItem.Name = "ReservationRequestsToolStripMenuItem";
            this.ReservationRequestsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ReservationRequestsToolStripMenuItem.Text = "Reservation Requests";
            this.ReservationRequestsToolStripMenuItem.Click += new System.EventHandler(this.ReservationRequestsToolStripMenuItem_Click);
            // 
            // DoReservationsToolStripMenuItem
            // 
            this.DoReservationsToolStripMenuItem.Name = "DoReservationsToolStripMenuItem";
            this.DoReservationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DoReservationsToolStripMenuItem.Text = "Do Reservation";
            this.DoReservationsToolStripMenuItem.Click += new System.EventHandler(this.DoReservationsToolStripMenuItem_Click);
            // 
            // CarOperationsToolStripMenuItem
            // 
            this.CarOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.CarOperationsToolStripMenuItem.Name = "CarOperationsToolStripMenuItem";
            this.CarOperationsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CarOperationsToolStripMenuItem.Text = "Car Operations";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ekleToolStripMenuItem.Text = "Add";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.EkleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.silToolStripMenuItem.Text = "Delete";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.SilToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.güncelleToolStripMenuItem.Text = "Update";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.GüncelleToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 531);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1382, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 553);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem yöneticiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservationRequestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservationDetailsToolStripMenuItem;
    }
}



