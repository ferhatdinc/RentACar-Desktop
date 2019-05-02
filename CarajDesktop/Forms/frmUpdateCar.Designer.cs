namespace CarajDesktop.Forms
{
    partial class frmUpdateCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateCar));
            this.dgwCars = new System.Windows.Forms.DataGridView();
            this.btnAracSec = new System.Windows.Forms.Button();
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
            this.btnUpdateCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCars
            // 
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(12, 12);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.RowTemplate.Height = 24;
            this.dgwCars.Size = new System.Drawing.Size(455, 180);
            this.dgwCars.TabIndex = 0;
            // 
            // btnAracSec
            // 
            this.btnAracSec.Location = new System.Drawing.Point(498, 12);
            this.btnAracSec.Name = "btnAracSec";
            this.btnAracSec.Size = new System.Drawing.Size(189, 180);
            this.btnAracSec.TabIndex = 1;
            this.btnAracSec.Text = "SELECT CAR";
            this.btnAracSec.UseVisualStyleBackColor = true;
            this.btnAracSec.Click += new System.EventHandler(this.btnAracSec_Click);
            // 
            // txtMinLicenceAge
            // 
            this.txtMinLicenceAge.Location = new System.Drawing.Point(147, 372);
            this.txtMinLicenceAge.Name = "txtMinLicenceAge";
            this.txtMinLicenceAge.Size = new System.Drawing.Size(100, 22);
            this.txtMinLicenceAge.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Min Licence Age";
            // 
            // txtPhotoUrl
            // 
            this.txtPhotoUrl.Location = new System.Drawing.Point(367, 370);
            this.txtPhotoUrl.Name = "txtPhotoUrl";
            this.txtPhotoUrl.Size = new System.Drawing.Size(100, 22);
            this.txtPhotoUrl.TabIndex = 47;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(367, 342);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(100, 22);
            this.txtRentPrice.TabIndex = 46;
            // 
            // txtSeatCount
            // 
            this.txtSeatCount.Location = new System.Drawing.Point(367, 314);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.Size = new System.Drawing.Size(100, 22);
            this.txtSeatCount.TabIndex = 45;
            // 
            // txtTrunkVolume
            // 
            this.txtTrunkVolume.Location = new System.Drawing.Point(367, 286);
            this.txtTrunkVolume.Name = "txtTrunkVolume";
            this.txtTrunkVolume.Size = new System.Drawing.Size(100, 22);
            this.txtTrunkVolume.TabIndex = 44;
            // 
            // txtAirbagCount
            // 
            this.txtAirbagCount.Location = new System.Drawing.Point(367, 258);
            this.txtAirbagCount.Name = "txtAirbagCount";
            this.txtAirbagCount.Size = new System.Drawing.Size(100, 22);
            this.txtAirbagCount.TabIndex = 43;
            // 
            // txtCarKm
            // 
            this.txtCarKm.Location = new System.Drawing.Point(367, 232);
            this.txtCarKm.Name = "txtCarKm";
            this.txtCarKm.Size = new System.Drawing.Size(100, 22);
            this.txtCarKm.TabIndex = 42;
            // 
            // txtMaxKm
            // 
            this.txtMaxKm.Location = new System.Drawing.Point(147, 344);
            this.txtMaxKm.Name = "txtMaxKm";
            this.txtMaxKm.Size = new System.Drawing.Size(100, 22);
            this.txtMaxKm.TabIndex = 41;
            // 
            // txtMinCustomerAge
            // 
            this.txtMinCustomerAge.Location = new System.Drawing.Point(147, 316);
            this.txtMinCustomerAge.Name = "txtMinCustomerAge";
            this.txtMinCustomerAge.Size = new System.Drawing.Size(100, 22);
            this.txtMinCustomerAge.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Photo URL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Rent Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Seat Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(265, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Trunk Volume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "AirBag Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Car KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "MAX Km Per Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Min Cus. Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Car ID";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(147, 288);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 28;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(147, 260);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 27;
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(147, 232);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(100, 22);
            this.txtCarId.TabIndex = 26;
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(498, 214);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(189, 180);
            this.btnUpdateCar.TabIndex = 50;
            this.btnUpdateCar.Text = "UPDATE CAR";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // frmUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateCar";
            this.Text = "Update Car";
            this.Load += new System.EventHandler(this.frmUpdateCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCars;
        private System.Windows.Forms.Button btnAracSec;
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
        private System.Windows.Forms.Button btnUpdateCar;
    }
}