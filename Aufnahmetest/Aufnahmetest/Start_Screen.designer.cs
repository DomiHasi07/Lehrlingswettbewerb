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
            this.tbl_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.tbl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Buttons
            // 
            this.tbl_Buttons.ColumnCount = 2;
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Controls.Add(this.textBox1, 0, 0);
            this.tbl_Buttons.Controls.Add(this.Btn_1, 0, 1);
            this.tbl_Buttons.Controls.Add(this.Btn_3, 0, 2);
            this.tbl_Buttons.Controls.Add(this.Btn_2, 1, 1);
            this.tbl_Buttons.Controls.Add(this.Btn_4, 1, 2);
            this.tbl_Buttons.Location = new System.Drawing.Point(12, 12);
            this.tbl_Buttons.Name = "tbl_Buttons";
            this.tbl_Buttons.RowCount = 3;
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Size = new System.Drawing.Size(250, 165);
            this.tbl_Buttons.TabIndex = 0;
            // 
            // textBox1
            // 
            this.tbl_Buttons.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btn_1
            // 
            this.Btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_1.Location = new System.Drawing.Point(3, 33);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(119, 61);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Text = "button1";
            this.Btn_1.UseVisualStyleBackColor = true;
            // 
            // Btn_3
            // 
            this.Btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_3.Location = new System.Drawing.Point(3, 100);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(119, 62);
            this.Btn_3.TabIndex = 1;
            this.Btn_3.Text = "button3";
            this.Btn_3.UseVisualStyleBackColor = true;
            // 
            // Btn_2
            // 
            this.Btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_2.Location = new System.Drawing.Point(128, 33);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(119, 61);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Text = "button2";
            this.Btn_2.UseVisualStyleBackColor = true;
            // 
            // Btn_4
            // 
            this.Btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_4.Location = new System.Drawing.Point(128, 100);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(119, 62);
            this.Btn_4.TabIndex = 2;
            this.Btn_4.Text = "button4";
            this.Btn_4.UseVisualStyleBackColor = true;
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 252);
            this.Controls.Add(this.tbl_Buttons);
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Screen";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.tbl_Buttons.ResumeLayout(false);
            this.tbl_Buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_Buttons;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.TextBox textBox1;
    }
}