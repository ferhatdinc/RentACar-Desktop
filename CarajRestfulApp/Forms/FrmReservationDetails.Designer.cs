namespace CarajRestfulApp.Forms
{
    partial class FrmReservationDetails
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
            this.dgwRezervtions = new System.Windows.Forms.DataGridView();
            this.btnReservationsList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervtions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwRezervtions
            // 
            this.dgwRezervtions.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwRezervtions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgwRezervtions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRezervtions.Location = new System.Drawing.Point(36, 12);
            this.dgwRezervtions.Name = "dgwRezervtions";
            this.dgwRezervtions.RowTemplate.Height = 24;
            this.dgwRezervtions.Size = new System.Drawing.Size(776, 201);
            this.dgwRezervtions.TabIndex = 5;
            // 
            // btnReservationsList
            // 
            this.btnReservationsList.Location = new System.Drawing.Point(298, 219);
            this.btnReservationsList.Name = "btnReservationsList";
            this.btnReservationsList.Size = new System.Drawing.Size(248, 92);
            this.btnReservationsList.TabIndex = 4;
            this.btnReservationsList.Text = "Reservations List";
            this.btnReservationsList.UseVisualStyleBackColor = true;
            this.btnReservationsList.Click += new System.EventHandler(this.btnReservationsList_Click);
            // 
            // FrmReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 329);
            this.Controls.Add(this.dgwRezervtions);
            this.Controls.Add(this.btnReservationsList);
            this.Name = "FrmReservationDetails";
            this.Text = "FrmReservationDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervtions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRezervtions;
        private System.Windows.Forms.Button btnReservationsList;
    }
}