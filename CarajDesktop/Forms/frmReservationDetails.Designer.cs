namespace CarajDesktop.Forms
{
    partial class frmReservationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationDetails));
            this.dgwRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.btnRezervasyonDetayi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRezervasyonlar
            // 
            this.dgwRezervasyonlar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwRezervasyonlar.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgwRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRezervasyonlar.Location = new System.Drawing.Point(12, 12);
            this.dgwRezervasyonlar.Name = "dgwRezervasyonlar";
            this.dgwRezervasyonlar.RowTemplate.Height = 24;
            this.dgwRezervasyonlar.Size = new System.Drawing.Size(776, 201);
            this.dgwRezervasyonlar.TabIndex = 3;
            // 
            // btnRezervasyonDetayi
            // 
            this.btnRezervasyonDetayi.Location = new System.Drawing.Point(276, 219);
            this.btnRezervasyonDetayi.Name = "btnRezervasyonDetayi";
            this.btnRezervasyonDetayi.Size = new System.Drawing.Size(248, 92);
            this.btnRezervasyonDetayi.TabIndex = 2;
            this.btnRezervasyonDetayi.Text = "Rezervasyonları Listele";
            this.btnRezervasyonDetayi.UseVisualStyleBackColor = true;
            // 
            // frmReservationDetails
            // 
            this.AcceptButton = this.btnRezervasyonDetayi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.dgwRezervasyonlar);
            this.Controls.Add(this.btnRezervasyonDetayi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReservationDetails";
            this.Text = "Reservation Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRezervasyonlar;
        private System.Windows.Forms.Button btnRezervasyonDetayi;
    }
}