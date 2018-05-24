namespace WindowsFormsApp3
{
    partial class Auswertung
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
            this.chart_Fragenauswertung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Fragenauswertung
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Fragenauswertung.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Fragenauswertung.Legends.Add(legend1);
            this.chart_Fragenauswertung.Location = new System.Drawing.Point(12, 12);
            this.chart_Fragenauswertung.Name = "chart_Fragenauswertung";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "alle_Antworten";
            this.chart_Fragenauswertung.Series.Add(series1);
            this.chart_Fragenauswertung.Size = new System.Drawing.Size(419, 344);
            this.chart_Fragenauswertung.TabIndex = 0;
            this.chart_Fragenauswertung.Text = "chart1";
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart_Fragenauswertung);
            this.Name = "Auswertung";
            this.Text = "Auswertung";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fragenauswertung;
    }
}