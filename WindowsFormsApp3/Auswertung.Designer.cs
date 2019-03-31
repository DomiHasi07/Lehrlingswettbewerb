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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Fragenauswertung = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btn_Prozent = new System.Windows.Forms.Button();
            this.rich_Fragen = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Kat = new System.Windows.Forms.Button();
            this.chart_Kat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Kat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_Fragenauswertung
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Fragenauswertung.ChartAreas.Add(chartArea1);
            this.chart_Fragenauswertung.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Fragenauswertung.Legends.Add(legend1);
            this.chart_Fragenauswertung.Location = new System.Drawing.Point(3, 3);
            this.chart_Fragenauswertung.Name = "chart_Fragenauswertung";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "alle_Antworten";
            this.chart_Fragenauswertung.Series.Add(series1);
            this.chart_Fragenauswertung.Size = new System.Drawing.Size(431, 320);
            this.chart_Fragenauswertung.TabIndex = 0;
            this.chart_Fragenauswertung.Text = "chart1";
            this.chart_Fragenauswertung.Click += new System.EventHandler(this.chart_Fragenauswertung_Click);
            // 
            // Btn_Prozent
            // 
            this.Btn_Prozent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Prozent.Location = new System.Drawing.Point(3, 329);
            this.Btn_Prozent.Name = "Btn_Prozent";
            this.Btn_Prozent.Size = new System.Drawing.Size(431, 24);
            this.Btn_Prozent.TabIndex = 1;
            this.Btn_Prozent.Text = "% / Ganzzahl";
            this.Btn_Prozent.UseVisualStyleBackColor = true;
            this.Btn_Prozent.Click += new System.EventHandler(this.Prozentwechsler_Click);
            // 
            // rich_Fragen
            // 
            this.rich_Fragen.BackColor = System.Drawing.Color.White;
            this.rich_Fragen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_Fragen.Location = new System.Drawing.Point(0, 0);
            this.rich_Fragen.Name = "rich_Fragen";
            this.rich_Fragen.ReadOnly = true;
            this.rich_Fragen.Size = new System.Drawing.Size(871, 713);
            this.rich_Fragen.TabIndex = 0;
            this.rich_Fragen.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(437, 713);
            this.splitContainer2.SplitterDistance = 356;
            this.splitContainer2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chart_Fragenauswertung, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Prozent, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Kat, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chart_Kat, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 353);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Btn_Kat
            // 
            this.Btn_Kat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Kat.Location = new System.Drawing.Point(3, 326);
            this.Btn_Kat.Name = "Btn_Kat";
            this.Btn_Kat.Size = new System.Drawing.Size(431, 24);
            this.Btn_Kat.TabIndex = 2;
            this.Btn_Kat.Text = "Falsche/Richtige Antworten";
            this.Btn_Kat.UseVisualStyleBackColor = true;
            // 
            // chart_Kat
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Kat.ChartAreas.Add(chartArea2);
            this.chart_Kat.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_Kat.Legends.Add(legend2);
            this.chart_Kat.Location = new System.Drawing.Point(3, 3);
            this.chart_Kat.Name = "chart_Kat";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "richtig";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "falsch";
            this.chart_Kat.Series.Add(series2);
            this.chart_Kat.Series.Add(series3);
            this.chart_Kat.Size = new System.Drawing.Size(431, 317);
            this.chart_Kat.TabIndex = 3;
            this.chart_Kat.Text = "chart1";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(12, 12);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.rich_Fragen);
            this.splitContainer3.Size = new System.Drawing.Size(1312, 713);
            this.splitContainer3.SplitterDistance = 437;
            this.splitContainer3.TabIndex = 5;
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 737);
            this.Controls.Add(this.splitContainer3);
            this.Name = "Auswertung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ric";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Kat)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fragenauswertung;
        private System.Windows.Forms.Button Btn_Prozent;
        private System.Windows.Forms.RichTextBox rich_Fragen;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Btn_Kat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Kat;
    }
}