namespace WindowsFormsApp3
{
    partial class Beenden
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
            this.Btn_CloseProgramm = new System.Windows.Forms.Button();
            this.btn_Auswertung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_CloseProgramm
            // 
            this.Btn_CloseProgramm.Location = new System.Drawing.Point(138, 39);
            this.Btn_CloseProgramm.Name = "Btn_CloseProgramm";
            this.Btn_CloseProgramm.Size = new System.Drawing.Size(120, 30);
            this.Btn_CloseProgramm.TabIndex = 0;
            this.Btn_CloseProgramm.Text = "Programm beenden";
            this.Btn_CloseProgramm.UseVisualStyleBackColor = true;
            this.Btn_CloseProgramm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Auswertung
            // 
            this.btn_Auswertung.Location = new System.Drawing.Point(12, 39);
            this.btn_Auswertung.Name = "btn_Auswertung";
            this.btn_Auswertung.Size = new System.Drawing.Size(120, 30);
            this.btn_Auswertung.TabIndex = 1;
            this.btn_Auswertung.Text = "Auswerten";
            this.btn_Auswertung.UseVisualStyleBackColor = true;
            this.btn_Auswertung.Click += new System.EventHandler(this.btn_Auswertung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Möchten Sie die Fragen auswerten oder Beenden?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Beenden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 81);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Auswertung);
            this.Controls.Add(this.Btn_CloseProgramm);
            this.Name = "Beenden";
            this.Text = "Beenden";
            this.Load += new System.EventHandler(this.Auswertung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CloseProgramm;
        private System.Windows.Forms.Button btn_Auswertung;
        private System.Windows.Forms.Label label1;
    }
}