namespace CarajRestfulApp.Forms
{
    partial class FrmUpdateCar
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
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.txtMinLicenceAge = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhotoUrl = new System.Windows.Forms.TextBox();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.txtSeatCount = new System.Windows.Forms.TextBox();
            this.txtTrunkVolume = new System.Windows.Forms.TextBox();
            this.txtAirbagCount = new System.Windows.Forms.TextBox();
            this.txtCarKm = new System.Windows.Forms.TextBox();
            this.txtMaxKm = new System.Windows.Forms.TextBox();
            this.txtMinCustomerAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.btnAracSec = new System.Windows.Forms.Button();
            this.dgwCars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(549, 236);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(189, 180);
            this.btnUpdateCar.TabIndex = 77;
            this.btnUpdateCar.Text = "UPDATE CAR";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_ClickAsync);
            // 
            // txtMinLicenceAge
            // 
            this.txtMinLicenceAge.Location = new System.Drawing.Point(198, 394);
            this.txtMinLicenceAge.Name = "txtMinLicenceAge";
            this.txtMinLicenceAge.Size = new System.Drawing.Size(100, 22);
            this.txtMinLicenceAge.TabIndex = 76;
            this.txtMinLicenceAge.TextChanged += new System.EventHandler(this.txtMinLicenceAge_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 75;
            this.label12.Text = "Min Licence Age";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtPhotoUrl
            // 
            this.txtPhotoUrl.Location = new System.Drawing.Point(418, 392);
            this.txtPhotoUrl.Name = "txtPhotoUrl";
            this.txtPhotoUrl.Size = new System.Drawing.Size(100, 22);
            this.txtPhotoUrl.TabIndex = 74;
            this.txtPhotoUrl.TextChanged += new System.EventHandler(this.txtPhotoUrl_TextChanged);
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(418, 364);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(100, 22);
            this.txtRentPrice.TabIndex = 73;
            this.txtRentPrice.TextChanged += new System.EventHandler(this.txtRentPrice_TextChanged);
            // 
            // txtSeatCount
            // 
            this.txtSeatCount.Location = new System.Drawing.Point(418, 336);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.Size = new System.Drawing.Size(100, 22);
            this.txtSeatCount.TabIndex = 72;
            this.txtSeatCount.TextChanged += new System.EventHandler(this.txtSeatCount_TextChanged);
            // 
            // txtTrunkVolume
            // 
            this.txtTrunkVolume.Location = new System.Drawing.Point(418, 308);
            this.txtTrunkVolume.Name = "txtTrunkVolume";
            this.txtTrunkVolume.Size = new System.Drawing.Size(100, 22);
            this.txtTrunkVolume.TabIndex = 71;
            this.txtTrunkVolume.TextChanged += new System.EventHandler(this.txtTrunkVolume_TextChanged);
            // 
            // txtAirbagCount
            // 
            this.txtAirbagCount.Location = new System.Drawing.Point(418, 280);
            this.txtAirbagCount.Name = "txtAirbagCount";
            this.txtAirbagCount.Size = new System.Drawing.Size(100, 22);
            this.txtAirbagCount.TabIndex = 70;
            this.txtAirbagCount.TextChanged += new System.EventHandler(this.txtAirbagCount_TextChanged);
            // 
            // txtCarKm
            // 
            this.txtCarKm.Location = new System.Drawing.Point(418, 254);
            this.txtCarKm.Name = "txtCarKm";
            this.txtCarKm.Size = new System.Drawing.Size(100, 22);
            this.txtCarKm.TabIndex = 69;
            this.txtCarKm.TextChanged += new System.EventHandler(this.txtCarKm_TextChanged);
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Location = new System.Drawing.Point(198, 366);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(100, 22);
            this.txtMaxKm.TabIndex = 68;
            this.txtMaxKm.TextChanged += new System.EventHandler(this.txtMaxKm_TextChanged);
            // 
            // txtMinCustomerAge
            // 
            this.txtMinCustomerAge.Location = new System.Drawing.Point(198, 338);
            this.txtMinCustomerAge.Name = "txtMinCustomerAge";
            this.txtMinCustomerAge.Size = new System.Drawing.Size(100, 22);
            this.txtMinCustomerAge.TabIndex = 67;
            this.txtMinCustomerAge.TextChanged += new System.EventHandler(this.txtMinCustomerAge_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 66;
            this.label11.Text = "Photo URL";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 65;
            this.label10.Text = "Rent Price";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Seat Count";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Trunk Volume";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "AirBag Count";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Car KM";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "MAX Km Per Day";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Min Cus. Age";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Brand";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Car ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(198, 310);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 55;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(198, 282);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 54;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(198, 254);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(100, 22);
            this.txtCarId.TabIndex = 53;
            this.txtCarId.TextChanged += new System.EventHandler(this.txtCarId_TextChanged);
            // 
            // btnAracSec
            // 
            this.btnAracSec.Location = new System.Drawing.Point(549, 34);
            this.btnAracSec.Name = "btnAracSec";
            this.btnAracSec.Size = new System.Drawing.Size(189, 180);
            this.btnAracSec.TabIndex = 52;
            this.btnAracSec.Text = "SELECT CAR";
            this.btnAracSec.UseVisualStyleBackColor = true;
            this.btnAracSec.Click += new System.EventHandler(this.btnAracSec_Click);
            // 
            // dgwCars
            // 
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(63, 34);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.RowTemplate.Height = 24;
            this.dgwCars.Size = new System.Drawing.Size(455, 180);
            this.dgwCars.TabIndex = 51;
            this.dgwCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCars_CellContentClick);
            // 
            // FrmUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.txtMinLicenceAge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPhotoUrl);
            this.Controls.Add(this.txtRentPrice);
            this.Controls.Add(this.txtSeatCount);
            this.Controls.Add(this.txtTrunkVolume);
            this.Controls.Add(this.txtAirbagCount);
            this.Controls.Add(this.txtCarKm);
            this.Controls.Add(this.txtMaxKm);
            this.Controls.Add(this.txtMinCustomerAge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.btnAracSec);
            this.Controls.Add(this.dgwCars);
            this.Name = "FrmUpdateCar";
            this.Text = "FrmUpdateCar";
            this.Load += new System.EventHandler(this.FrmUpdateCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.TextBox txtMinLicenceAge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPhotoUrl;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.TextBox txtSeatCount;
        private System.Windows.Forms.TextBox txtTrunkVolume;
        private System.Windows.Forms.TextBox txtAirbagCount;
        private System.Windows.Forms.TextBox txtCarKm;
        private System.Windows.Forms.TextBox txtMaxKm;
        private System.Windows.Forms.TextBox txtMinCustomerAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Button btnAracSec;
        private System.Windows.Forms.DataGridView dgwCars;
    }
}