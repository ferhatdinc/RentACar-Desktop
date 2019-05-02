namespace CarajDesktop.Forms
{
    partial class frmDeleteCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteCar));
            this.dgwCarList = new System.Windows.Forms.DataGridView();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCarList
            // 
            this.dgwCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCarList.Location = new System.Drawing.Point(22, 37);
            this.dgwCarList.Name = "dgwCarList";
            this.dgwCarList.RowTemplate.Height = 24;
            this.dgwCarList.Size = new System.Drawing.Size(1156, 226);
            this.dgwCarList.TabIndex = 0;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(585, 269);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(360, 99);
            this.btnDeleteCar.TabIndex = 1;
            this.btnDeleteCar.Text = "Sil";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // frmDeleteCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.dgwCarList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteCar";
            this.Text = "Delete Car";
            this.Load += new System.EventHandler(this.frmDeleteCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCarList;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}