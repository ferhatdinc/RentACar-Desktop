namespace CarajRestfulApp.Forms
{
    partial class FrmNewReservation
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
            this.BtnReservationRequest = new System.Windows.Forms.Button();
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.dgwCarList = new System.Windows.Forms.DataGridView();
            this.BtnDoReservations = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tpDateLast = new System.Windows.Forms.DateTimePicker();
            this.tpDateFirst = new System.Windows.Forms.DateTimePicker();
            this.txtLastKM = new System.Windows.Forms.TextBox();
            this.txtFirsrKM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnReservationRequest
            // 
            this.BtnReservationRequest.Location = new System.Drawing.Point(587, 301);
            this.BtnReservationRequest.Name = "BtnReservationRequest";
            this.BtnReservationRequest.Size = new System.Drawing.Size(167, 48);
            this.BtnReservationRequest.TabIndex = 55;
            this.BtnReservationRequest.Text = "İstekleri Görüntüle";
            this.BtnReservationRequest.UseVisualStyleBackColor = true;
            this.BtnReservationRequest.Click += new System.EventHandler(this.BtnReservationRequest_Click);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(357, 301);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(224, 48);
            this.btnSelectCar.TabIndex = 54;
            this.btnSelectCar.Text = "Araç Seç";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.btnSelectCar_Click);
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(136, 131);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(214, 22);
            this.txtCarId.TabIndex = 53;
            this.txtCarId.Text = "5";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(136, 101);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(214, 22);
            this.txtCustomerId.TabIndex = 52;
            this.txtCustomerId.Text = "3";
            // 
            // dgwCarList
            // 
            this.dgwCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarList.Location = new System.Drawing.Point(357, 101);
            this.dgwCarList.Name = "dgwCarList";
            this.dgwCarList.RowTemplate.Height = 24;
            this.dgwCarList.Size = new System.Drawing.Size(397, 192);
            this.dgwCarList.TabIndex = 51;
            // 
            // BtnDoReservations
            // 
            this.BtnDoReservations.Location = new System.Drawing.Point(62, 301);
            this.BtnDoReservations.Name = "BtnDoReservations";
            this.BtnDoReservations.Size = new System.Drawing.Size(289, 48);
            this.BtnDoReservations.TabIndex = 41;
            this.BtnDoReservations.Text = "Do Reservations";
            this.BtnDoReservations.UseVisualStyleBackColor = true;
            this.BtnDoReservations.Click += new System.EventHandler(this.BtnDoReservations_ClickAsync);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(136, 273);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(214, 22);
            this.txtAmount.TabIndex = 50;
            // 
            // tpDateLast
            // 
            this.tpDateLast.Location = new System.Drawing.Point(137, 189);
            this.tpDateLast.Name = "tpDateLast";
            this.tpDateLast.Size = new System.Drawing.Size(214, 22);
            this.tpDateLast.TabIndex = 49;
            this.tpDateLast.ValueChanged += new System.EventHandler(this.tpDateLast_ValueChanged);
            // 
            // tpDateFirst
            // 
            this.tpDateFirst.Location = new System.Drawing.Point(136, 161);
            this.tpDateFirst.Name = "tpDateFirst";
            this.tpDateFirst.Size = new System.Drawing.Size(214, 22);
            this.tpDateFirst.TabIndex = 48;
            // 
            // txtLastKM
            // 
            this.txtLastKM.Location = new System.Drawing.Point(136, 245);
            this.txtLastKM.Name = "txtLastKM";
            this.txtLastKM.Size = new System.Drawing.Size(214, 22);
            this.txtLastKM.TabIndex = 47;
            this.txtLastKM.Text = "33000";
            // 
            // txtFirsrKM
            // 
            this.txtFirsrKM.Location = new System.Drawing.Point(137, 217);
            this.txtFirsrKM.Name = "txtFirsrKM";
            this.txtFirsrKM.Size = new System.Drawing.Size(214, 22);
            this.txtFirsrKM.TabIndex = 46;
            this.txtFirsrKM.Text = "30000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(79, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(76, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 44;
            this.label8.Tag = "d";
            this.label8.Text = "Last KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(72, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "First KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(64, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Last Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(63, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "First Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(76, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Car ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Customer ID";
            // 
            // FrmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReservationRequest);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.dgwCarList);
            this.Controls.Add(this.BtnDoReservations);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.tpDateLast);
            this.Controls.Add(this.tpDateFirst);
            this.Controls.Add(this.txtLastKM);
            this.Controls.Add(this.txtFirsrKM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewReservation";
            this.Text = "FrmNewReservation";
            this.Load += new System.EventHandler(this.FrmNewReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReservationRequest;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.DataGridView dgwCarList;
        private System.Windows.Forms.Button BtnDoReservations;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker tpDateLast;
        private System.Windows.Forms.DateTimePicker tpDateFirst;
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