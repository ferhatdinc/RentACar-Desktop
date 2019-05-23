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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chrtIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtCars = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtKM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtKM)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtIncome
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtIncome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtIncome.Legends.Add(legend1);
            this.chrtIncome.Location = new System.Drawing.Point(12, 12);
            this.chrtIncome.Name = "chrtIncome";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.chrtIncome.Series.Add(series1);
            this.chrtIncome.Series.Add(series2);
            this.chrtIncome.Size = new System.Drawing.Size(636, 271);
            this.chrtIncome.TabIndex = 0;
            this.chrtIncome.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.ForeColor = System.Drawing.Color.Maroon;
            title1.Name = "Title1";
            title1.Text = "Montly Income Statement";
            this.chrtIncome.Titles.Add(title1);
            // 
            // chrtCars
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtCars.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtCars.Legends.Add(legend2);
            this.chrtCars.Location = new System.Drawing.Point(12, 289);
            this.chrtCars.Name = "chrtCars";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Cars";
            this.chrtCars.Series.Add(series3);
            this.chrtCars.Size = new System.Drawing.Size(636, 271);
            this.chrtCars.TabIndex = 1;
            this.chrtCars.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title2.ForeColor = System.Drawing.Color.Maroon;
            title2.Name = "Title1";
            title2.Text = "Montly Car Trace";
            this.chrtCars.Titles.Add(title2);
            // 
            // chrtKM
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtKM.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtKM.Legends.Add(legend3);
            this.chrtKM.Location = new System.Drawing.Point(654, 12);
            this.chrtKM.Name = "chrtKM";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Cars";
            this.chrtKM.Series.Add(series4);
            this.chrtKM.Size = new System.Drawing.Size(719, 548);
            this.chrtKM.TabIndex = 2;
            this.chrtKM.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title3.ForeColor = System.Drawing.Color.Maroon;
            title3.Name = "Title1";
            title3.Text = "Montly Income Statement";
            this.chrtKM.Titles.Add(title3);
            // 
            // FrmFirmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 569);
            this.Controls.Add(this.chrtKM);
            this.Controls.Add(this.chrtCars);
            this.Controls.Add(this.chrtIncome);
            this.Name = "FrmFirmReports";
            this.Text = "FrmFirmReports";
            this.Load += new System.EventHandler(this.FrmFirmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtCars;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtKM;
    }
}