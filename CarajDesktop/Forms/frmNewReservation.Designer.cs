namespace CarajDesktop.Forms
{
    partial class frmNewReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewReservation));
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.tpBitis = new System.Windows.Forms.DateTimePicker();
            this.tpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cbAracId = new System.Windows.Forms.ComboBox();
            this.cbMusteriId = new System.Windows.Forms.ComboBox();
            this.txtBitişKM = new System.Windows.Forms.TextBox();
            this.txtBaslangicKM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Location = new System.Drawing.Point(15, 206);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(348, 40);
            this.btnRezervasyonYap.TabIndex = 21;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(89, 178);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(273, 22);
            this.txtTutar.TabIndex = 32;
            // 
            // tpBitis
            // 
            this.tpBitis.Location = new System.Drawing.Point(90, 94);
            this.tpBitis.Name = "tpBitis";
            this.tpBitis.Size = new System.Drawing.Size(273, 22);
            this.tpBitis.TabIndex = 31;
            // 
            // tpBaslangic
            // 
            this.tpBaslangic.Location = new System.Drawing.Point(89, 66);
            this.tpBaslangic.Name = "tpBaslangic";
            this.tpBaslangic.Size = new System.Drawing.Size(273, 22);
            this.tpBaslangic.TabIndex = 30;
            // 
            // cbAracId
            // 
            this.cbAracId.FormattingEnabled = true;
            this.cbAracId.Location = new System.Drawing.Point(89, 36);
            this.cbAracId.Name = "cbAracId";
            this.cbAracId.Size = new System.Drawing.Size(273, 24);
            this.cbAracId.TabIndex = 29;
            // 
            // cbMusteriId
            // 
            this.cbMusteriId.FormattingEnabled = true;
            this.cbMusteriId.Location = new System.Drawing.Point(89, 6);
            this.cbMusteriId.Name = "cbMusteriId";
            this.cbMusteriId.Size = new System.Drawing.Size(273, 24);
            this.cbMusteriId.TabIndex = 28;
            // 
            // txtBitişKM
            // 
            this.txtBitişKM.Location = new System.Drawing.Point(89, 150);
            this.txtBitişKM.Name = "txtBitişKM";
            this.txtBitişKM.Size = new System.Drawing.Size(273, 22);
            this.txtBitişKM.TabIndex = 27;
            // 
            // txtBaslangicKM
            // 
            this.txtBaslangicKM.Location = new System.Drawing.Point(90, 122);
            this.txtBaslangicKM.Name = "txtBaslangicKM";
            this.txtBaslangicKM.Size = new System.Drawing.Size(273, 22);
            this.txtBaslangicKM.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(39, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(31, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bit. KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(25, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Baş. KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(47, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Bitiş";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Başlangıç";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Arac ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Musteri ID";
            // 
            // frmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.tpBitis);
            this.Controls.Add(this.tpBaslangic);
            this.Controls.Add(this.cbAracId);
            this.Controls.Add(this.cbMusteriId);
            this.Controls.Add(this.txtBitişKM);
            this.Controls.Add(this.txtBaslangicKM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmNewReservation";
            this.Text = "New Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.DateTimePicker tpBitis;
        private System.Windows.Forms.DateTimePicker tpBaslangic;
        private System.Windows.Forms.ComboBox cbAracId;
        private System.Windows.Forms.ComboBox cbMusteriId;
        private System.Windows.Forms.TextBox txtBitişKM;
        private System.Windows.Forms.TextBox txtBaslangicKM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}