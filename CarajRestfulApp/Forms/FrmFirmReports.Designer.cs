namespace CarajRestfulApp.Forms
{
    partial class FrmFirmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chrtIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtCars = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtKM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtAverageCarKM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAverageCarKM)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtIncome
            // 
            chartArea5.Name = "ChartArea1";
            this.chrtIncome.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrtIncome.Legends.Add(legend5);
            this.chrtIncome.Location = new System.Drawing.Point(12, 12);
            this.chrtIncome.Name = "chrtIncome";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Gelir";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Gider";
            this.chrtIncome.Series.Add(series6);
            this.chrtIncome.Series.Add(series7);
            this.chrtIncome.Size = new System.Drawing.Size(636, 271);
            this.chrtIncome.TabIndex = 0;
            this.chrtIncome.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title5.ForeColor = System.Drawing.Color.Maroon;
            title5.Name = "Title1";
            title5.Text = "Montly Income Statement";
            this.chrtIncome.Titles.Add(title5);
            // 
            // chrtCars
            // 
            chartArea6.Name = "ChartArea1";
            this.chrtCars.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrtCars.Legends.Add(legend6);
            this.chrtCars.Location = new System.Drawing.Point(12, 289);
            this.chrtCars.Name = "chrtCars";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Cars";
            this.chrtCars.Series.Add(series8);
            this.chrtCars.Size = new System.Drawing.Size(636, 407);
            this.chrtCars.TabIndex = 1;
            this.chrtCars.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title6.ForeColor = System.Drawing.Color.Maroon;
            title6.Name = "Title1";
            title6.Text = "Montly Car Trace";
            this.chrtCars.Titles.Add(title6);
            // 
            // chrtKM
            // 
            chartArea7.Name = "ChartArea1";
            this.chrtKM.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chrtKM.Legends.Add(legend7);
            this.chrtKM.Location = new System.Drawing.Point(654, 12);
            this.chrtKM.Name = "chrtKM";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.Legend = "Legend1";
            series9.Name = "Cars";
            this.chrtKM.Series.Add(series9);
            this.chrtKM.Size = new System.Drawing.Size(719, 378);
            this.chrtKM.TabIndex = 2;
            this.chrtKM.Text = "chart1";
            title7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title7.ForeColor = System.Drawing.Color.Maroon;
            title7.Name = "Title1";
            title7.Text = "monthly Car Exceed KM";
            this.chrtKM.Titles.Add(title7);
            // 
            // chrtAverageCarKM
            // 
            chartArea8.Name = "ChartArea1";
            this.chrtAverageCarKM.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chrtAverageCarKM.Legends.Add(legend8);
            this.chrtAverageCarKM.Location = new System.Drawing.Point(654, 396);
            this.chrtAverageCarKM.Name = "chrtAverageCarKM";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "CarKM";
            this.chrtAverageCarKM.Series.Add(series10);
            this.chrtAverageCarKM.Size = new System.Drawing.Size(719, 300);
            this.chrtAverageCarKM.TabIndex = 3;
            this.chrtAverageCarKM.Text = "chart1";
            title8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title8.ForeColor = System.Drawing.Color.Maroon;
            title8.Name = "Title1";
            title8.Text = "Daily Car Trace KM";
            this.chrtAverageCarKM.Titles.Add(title8);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Agustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.comboBox1.Location = new System.Drawing.Point(1230, 496);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmFirmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 738);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chrtAverageCarKM);
            this.Controls.Add(this.chrtKM);
            this.Controls.Add(this.chrtCars);
            this.Controls.Add(this.chrtIncome);
            this.Name = "FrmFirmReports";
            this.Text = "FrmFirmReports";
            this.Load += new System.EventHandler(this.FrmFirmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAverageCarKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCars;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtKM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAverageCarKM;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}