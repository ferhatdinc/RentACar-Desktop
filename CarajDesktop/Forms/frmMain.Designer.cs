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
            this.yöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonİstekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rezerasyonDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiİşlemleriToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1382, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // yöneticiİşlemleriToolStripMenuItem
            // 
            this.yöneticiİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerasyonDetaylarıToolStripMenuItem,
            this.rezervasyonİstekleriToolStripMenuItem,
            this.rezervasyonYapToolStripMenuItem,
            this.araçİşlemleriToolStripMenuItem});
            this.yöneticiİşlemleriToolStripMenuItem.Name = "yöneticiİşlemleriToolStripMenuItem";
            this.yöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.yöneticiİşlemleriToolStripMenuItem.Text = "Yönetici İşlemleri";
            // 
            // rezervasyonİstekleriToolStripMenuItem
            // 
            this.rezervasyonİstekleriToolStripMenuItem.Name = "rezervasyonİstekleriToolStripMenuItem";
            this.rezervasyonİstekleriToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.rezervasyonİstekleriToolStripMenuItem.Text = "Rezervasyon İstekleri";
            // 
            // rezervasyonYapToolStripMenuItem
            // 
            this.rezervasyonYapToolStripMenuItem.Name = "rezervasyonYapToolStripMenuItem";
            this.rezervasyonYapToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.rezervasyonYapToolStripMenuItem.Text = "Rezervasyon Yap";
            this.rezervasyonYapToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonYapToolStripMenuItem_Click);
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.silToolStripMenuItem.Text = "Sil ";
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.AutoSize = false;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
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
            // rezerasyonDetaylarıToolStripMenuItem
            // 
            this.rezerasyonDetaylarıToolStripMenuItem.Name = "rezerasyonDetaylarıToolStripMenuItem";
            this.rezerasyonDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.rezerasyonDetaylarıToolStripMenuItem.Text = "Rezerasyon Detayları";
            this.rezerasyonDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.rezerasyonDetaylarıToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem rezervasyonİstekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezerasyonDetaylarıToolStripMenuItem;
    }
}



