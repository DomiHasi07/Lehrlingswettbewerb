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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_File = new System.Windows.Forms.Button();
            this.tbl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb1.Location = new System.Drawing.Point(3, 44);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(204, 36);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Fragen können überspringen werden";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.SystemColors.Control;
            this.tbl_Main.SetColumnSpan(this.Btn_Start, 2);
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Start.Enabled = false;
            this.Btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Start.Location = new System.Drawing.Point(3, 3);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(414, 35);
            this.Btn_Start.TabIndex = 2;
            this.Btn_Start.Text = "Quiz  starten";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btn_File
            // 
            this.Btn_File.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_File.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_File.Location = new System.Drawing.Point(213, 44);
            this.Btn_File.Name = "Btn_File";
            this.Btn_File.Size = new System.Drawing.Size(204, 36);
            this.Btn_File.TabIndex = 3;
            this.Btn_File.Text = "Fragenkatalog auswählen";
            this.Btn_File.UseVisualStyleBackColor = true;
            this.Btn_File.Click += new System.EventHandler(this.Btn_File_Click);
            // 
            // tbl_Main
            // 
            this.tbl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Main.ColumnCount = 2;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.Controls.Add(this.Btn_File, 1, 1);
            this.tbl_Main.Controls.Add(this.Btn_Start, 0, 0);
            this.tbl_Main.Controls.Add(this.cb1, 0, 1);
            this.tbl_Main.Location = new System.Drawing.Point(12, 12);
            this.tbl_Main.MinimumSize = new System.Drawing.Size(420, 80);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 2;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Main.Size = new System.Drawing.Size(420, 83);
            this.tbl_Main.TabIndex = 4;
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 111);
            this.Controls.Add(this.tbl_Main);
            this.MinimumSize = new System.Drawing.Size(460, 150);
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Screen";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.tbl_Main.ResumeLayout(false);
            this.tbl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_File;
        private System.Windows.Forms.TableLayoutPanel tbl_Main;
    }
}