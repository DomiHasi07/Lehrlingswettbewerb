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
            this.Prozentwechsler = new System.Windows.Forms.Button();
            this.rich_Fragen = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_Fragenauswertung
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Fragenauswertung.ChartAreas.Add(chartArea1);
            this.chart_Fragenauswertung.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Fragenauswertung.Legends.Add(legend1);
            this.chart_Fragenauswertung.Location = new System.Drawing.Point(0, 0);
            this.chart_Fragenauswertung.Name = "chart_Fragenauswertung";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "alle_Antworten";
            this.chart_Fragenauswertung.Series.Add(series1);
            this.chart_Fragenauswertung.Size = new System.Drawing.Size(246, 323);
            this.chart_Fragenauswertung.TabIndex = 0;
            this.chart_Fragenauswertung.Text = "chart1";
            this.chart_Fragenauswertung.Click += new System.EventHandler(this.chart_Fragenauswertung_Click);
            // 
            // Prozentwechsler
            // 
            this.Prozentwechsler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Prozentwechsler.Location = new System.Drawing.Point(0, 323);
            this.Prozentwechsler.Name = "Prozentwechsler";
            this.Prozentwechsler.Size = new System.Drawing.Size(246, 23);
            this.Prozentwechsler.TabIndex = 1;
            this.Prozentwechsler.Text = "% / Ganzzahl";
            this.Prozentwechsler.UseVisualStyleBackColor = true;
            this.Prozentwechsler.Click += new System.EventHandler(this.Prozentwechsler_Click);
            // 
            // rich_Fragen
            // 
            this.rich_Fragen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_Fragen.Location = new System.Drawing.Point(0, 0);
            this.rich_Fragen.Name = "rich_Fragen";
            this.rich_Fragen.Size = new System.Drawing.Size(489, 346);
            this.rich_Fragen.TabIndex = 2;
            this.rich_Fragen.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart_Fragenauswertung);
            this.splitContainer1.Panel1.Controls.Add(this.Prozentwechsler);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rich_Fragen);
            this.splitContainer1.Size = new System.Drawing.Size(739, 346);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 3;
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 370);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Auswertung";
            this.Text = "ric";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fragenauswertung;
        private System.Windows.Forms.Button Prozentwechsler;
        private System.Windows.Forms.RichTextBox rich_Fragen;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}