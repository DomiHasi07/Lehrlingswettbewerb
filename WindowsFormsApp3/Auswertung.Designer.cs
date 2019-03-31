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
            this.chart_Kat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Splt_Main_Panel = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Kat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Splt_Main_Panel)).BeginInit();
            this.Splt_Main_Panel.Panel1.SuspendLayout();
            this.Splt_Main_Panel.Panel2.SuspendLayout();
            this.Splt_Main_Panel.SuspendLayout();
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
            this.rich_Fragen.Size = new System.Drawing.Size(870, 713);
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
            this.splitContainer2.Panel2.Controls.Add(this.chart_Kat);
            this.splitContainer2.Size = new System.Drawing.Size(437, 713);
            this.splitContainer2.SplitterDistance = 356;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
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
            // chart_Kat
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Kat.ChartAreas.Add(chartArea2);
            this.chart_Kat.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_Kat.Legends.Add(legend2);
            this.chart_Kat.Location = new System.Drawing.Point(0, 0);
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
            this.chart_Kat.Size = new System.Drawing.Size(437, 352);
            this.chart_Kat.TabIndex = 3;
            this.chart_Kat.Text = "chart1";
            // 
            // Splt_Main_Panel
            // 
            this.Splt_Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Splt_Main_Panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Splt_Main_Panel.Location = new System.Drawing.Point(12, 12);
            this.Splt_Main_Panel.Name = "Splt_Main_Panel";
            // 
            // Splt_Main_Panel.Panel1
            // 
            this.Splt_Main_Panel.Panel1.Controls.Add(this.splitContainer2);
            // 
            // Splt_Main_Panel.Panel2
            // 
            this.Splt_Main_Panel.Panel2.Controls.Add(this.rich_Fragen);
            this.Splt_Main_Panel.Size = new System.Drawing.Size(1312, 713);
            this.Splt_Main_Panel.SplitterDistance = 437;
            this.Splt_Main_Panel.SplitterWidth = 5;
            this.Splt_Main_Panel.TabIndex = 5;
            // 
            // Auswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 737);
            this.Controls.Add(this.Splt_Main_Panel);
            this.Name = "Auswertung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auswertung";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Fragenauswertung)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Kat)).EndInit();
            this.Splt_Main_Panel.Panel1.ResumeLayout(false);
            this.Splt_Main_Panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splt_Main_Panel)).EndInit();
            this.Splt_Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Fragenauswertung;
        private System.Windows.Forms.Button Btn_Prozent;
        private System.Windows.Forms.RichTextBox rich_Fragen;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer Splt_Main_Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Kat;
    }
}