namespace WindowsFormsApp3
{
    partial class Start_Screen
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
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.CmB_1 = new System.Windows.Forms.ComboBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(12, 41);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(200, 17);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Fragen können überspringen werden";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // CmB_1
            // 
            this.CmB_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmB_1.FormattingEnabled = true;
            this.CmB_1.Location = new System.Drawing.Point(12, 10);
            this.CmB_1.Name = "CmB_1";
            this.CmB_1.Size = new System.Drawing.Size(292, 21);
            this.CmB_1.TabIndex = 1;
            this.CmB_1.SelectedIndexChanged += new System.EventHandler(this.CmB_1_SelectedIndexChanged);
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Start.Enabled = false;
            this.Btn_Start.Location = new System.Drawing.Point(229, 37);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Quiz  starten";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 75);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.CmB_1);
            this.Controls.Add(this.cb1);
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Screen";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.ComboBox CmB_1;
        private System.Windows.Forms.Button Btn_Start;
    }
}