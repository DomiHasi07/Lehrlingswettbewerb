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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Fragenauswertung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Prozentwechsler = new System.Windows.Forms.Button();
            this.rich_Fragen = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Fragenauswertung
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Fragenauswertung.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Fragenauswertung.Legends.Add(legend2);
            this.chart_Fragenauswertung.Location = new System.Drawing.Point(12, 12);
            this.chart_Fragenauswertung.Name = "chart_Fragenauswertung";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "alle_Antworten";
            this.chart_Fragenauswertung.Series.Add(series2);
            this.chart_Fragenauswertung.Size = new System.Drawing.Size(419, 344);
            this.chart_Fragenauswertung.TabIndex = 0;
            this.chart_Fragenauswertung.Text = "chart1";
            this.chart_Fragenauswertung.Click += new System.EventHandler(this.chart_Fragenauswertung_Click);
            // 
            // Prozentwechsler
            // 
            this.Prozentwechsler.Location = new System.Drawing.Point(336, 333);
            this.Prozentwechsler.Name = "Prozentwechsler";
            this.Prozentwechsler.Size = new System.Drawing.Size(95, 23);
            this.Prozentwechsler.TabIndex = 1;
            this.Prozentwechsler.Text = "% / Ganzzahl";
            this.Prozentwechsler.UseVisualStyleBackColor = true;
            this.Prozentwechsler.Click += new System.EventHandler(this.Prozentwechsler_Click);
            // 
            // rich_Fragen
            // 
            this.rich_Fragen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rich_Fragen.Location = new System.Drawing.Point(459, 12);
            this.rich_Fragen.Name = "rich_Fragen";
            this.rich_Fragen.Size = new System.Drawing.Size(292, 344);
            this.rich_Fragen.TabIndex = 2;
            this.rich_Fragen.Text = "";
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 370);
            this.Controls.Add(this.rich_Fragen);
            this.Controls.Add(this.Prozentwechsler);
            this.Controls.Add(this.chart_Fragenauswertung);
            this.Name = "Auswertung";
            this.Text = "ric";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fragenauswertung;
        private System.Windows.Forms.Button Prozentwechsler;
        private System.Windows.Forms.RichTextBox rich_Fragen;
    }
}