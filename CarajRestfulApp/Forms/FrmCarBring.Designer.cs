namespace CarajRestfulApp.Forms
{
    partial class FrmCarBring
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
            this.dgwRezervationDetails = new System.Windows.Forms.DataGridView();
            this.btnKayitSec = new System.Windows.Forms.Button();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtEndingKM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarBring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRezervationDetails
            // 
            this.dgwRezervationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRezervationDetails.Location = new System.Drawing.Point(243, 12);
            this.dgwRezervationDetails.Name = "dgwRezervationDetails";
            this.dgwRezervationDetails.RowTemplate.Height = 24;
            this.dgwRezervationDetails.Size = new System.Drawing.Size(697, 150);
            this.dgwRezervationDetails.TabIndex = 0;
            // 
            // btnKayitSec
            // 
            this.btnKayitSec.Location = new System.Drawing.Point(243, 169);
            this.btnKayitSec.Name = "btnKayitSec";
            this.btnKayitSec.Size = new System.Drawing.Size(697, 51);
            this.btnKayitSec.TabIndex = 1;
            this.btnKayitSec.Text = "Kayıt Seç";
            this.btnKayitSec.UseVisualStyleBackColor = true;
            this.btnKayitSec.Click += new System.EventHandler(this.btnKayitSec_Click);
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(103, 12);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(134, 22);
            this.txtCarID.TabIndex = 2;
            // 
            // txtEndingKM
            // 
            this.txtEndingKM.Location = new System.Drawing.Point(103, 40);
            this.txtEndingKM.Name = "txtEndingKM";
            this.txtEndingKM.Size = new System.Drawing.Size(134, 22);
            this.txtEndingKM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ending KM";
            // 
            // btnCarBring
            // 
            this.btnCarBring.Location = new System.Drawing.Point(15, 65);
            this.btnCarBring.Name = "btnCarBring";
            this.btnCarBring.Size = new System.Drawing.Size(222, 34);
            this.btnCarBring.TabIndex = 6;
            this.btnCarBring.Text = "Bring Back";
            this.btnCarBring.UseVisualStyleBackColor = true;
            this.btnCarBring.Click += new System.EventHandler(this.btnCarBring_ClickAsync);
            // 
            // FrmCarBring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 249);
            this.Controls.Add(this.btnCarBring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndingKM);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.btnKayitSec);
            this.Controls.Add(this.dgwRezervationDetails);
            this.Name = "FrmCarBring";
            this.Text = "FrmCarBring";
            this.Load += new System.EventHandler(this.FrmCarBring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervationDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRezervationDetails;
        private System.Windows.Forms.Button btnKayitSec;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtEndingKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarBring;
    }
}