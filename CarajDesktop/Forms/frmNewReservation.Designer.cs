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
            this.btnDoReservations = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tpDateLast = new System.Windows.Forms.DateTimePicker();
            this.tpDateFirst = new System.Windows.Forms.DateTimePicker();
            this.cbCarID = new System.Windows.Forms.ComboBox();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.txtLastKM = new System.Windows.Forms.TextBox();
            this.txtFirsrKM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoReservations
            // 
            this.btnDoReservations.Location = new System.Drawing.Point(15, 206);
            this.btnDoReservations.Name = "btnDoReservations";
            this.btnDoReservations.Size = new System.Drawing.Size(348, 40);
            this.btnDoReservations.TabIndex = 21;
            this.btnDoReservations.Text = "Do Reservations";
            this.btnDoReservations.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(89, 178);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(273, 22);
            this.txtAmount.TabIndex = 32;
            // 
            // tpDateLast
            // 
            this.tpDateLast.Location = new System.Drawing.Point(90, 94);
            this.tpDateLast.Name = "tpDateLast";
            this.tpDateLast.Size = new System.Drawing.Size(273, 22);
            this.tpDateLast.TabIndex = 31;
            // 
            // tpDateFirst
            // 
            this.tpDateFirst.Location = new System.Drawing.Point(89, 66);
            this.tpDateFirst.Name = "tpDateFirst";
            this.tpDateFirst.Size = new System.Drawing.Size(273, 22);
            this.tpDateFirst.TabIndex = 30;
            // 
            // cbCarID
            // 
            this.cbCarID.FormattingEnabled = true;
            this.cbCarID.Location = new System.Drawing.Point(89, 36);
            this.cbCarID.Name = "cbCarID";
            this.cbCarID.Size = new System.Drawing.Size(273, 24);
            this.cbCarID.TabIndex = 29;
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(89, 6);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(273, 24);
            this.cbCustomerID.TabIndex = 28;
            // 
            // txtLastKM
            // 
            this.txtLastKM.Location = new System.Drawing.Point(89, 150);
            this.txtLastKM.Name = "txtLastKM";
            this.txtLastKM.Size = new System.Drawing.Size(273, 22);
            this.txtLastKM.TabIndex = 27;
            // 
            // txtFirsrKM
            // 
            this.txtFirsrKM.Location = new System.Drawing.Point(90, 122);
            this.txtFirsrKM.Name = "txtFirsrKM";
            this.txtFirsrKM.Size = new System.Drawing.Size(273, 22);
            this.txtFirsrKM.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(32, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(29, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 24;
            this.label8.Tag = "d";
            this.label8.Text = "Last KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(25, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "First KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Last Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "First Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(29, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Car ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer ID";
            // 
            // frmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.btnDoReservations);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.tpDateLast);
            this.Controls.Add(this.tpDateFirst);
            this.Controls.Add(this.cbCarID);
            this.Controls.Add(this.cbCustomerID);
            this.Controls.Add(this.txtLastKM);
            this.Controls.Add(this.txtFirsrKM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewReservation";
            this.Tag = "";
            this.Text = "New Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoReservations;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker tpDateLast;
        private System.Windows.Forms.DateTimePicker tpDateFirst;
        private System.Windows.Forms.ComboBox cbCarID;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.TextBox txtLastKM;
        private System.Windows.Forms.TextBox txtFirsrKM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}