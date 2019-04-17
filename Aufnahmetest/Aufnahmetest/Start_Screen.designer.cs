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
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.tbl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.tbl_Buttons.SuspendLayout();
            this.tbl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Buttons
            // 
            this.tbl_Buttons.ColumnCount = 2;
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Controls.Add(this.Btn_1, 0, 0);
            this.tbl_Buttons.Controls.Add(this.Btn_3, 0, 1);
            this.tbl_Buttons.Controls.Add(this.Btn_2, 1, 0);
            this.tbl_Buttons.Controls.Add(this.Btn_4, 1, 1);
            this.tbl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Buttons.Location = new System.Drawing.Point(3, 43);
            this.tbl_Buttons.Name = "tbl_Buttons";
            this.tbl_Buttons.RowCount = 2;
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_Buttons.Size = new System.Drawing.Size(314, 137);
            this.tbl_Buttons.TabIndex = 0;
            // 
            // Btn_1
            // 
            this.Btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_1.Location = new System.Drawing.Point(3, 3);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(151, 62);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Tag = "1";
            this.Btn_1.Text = "button1";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // Btn_3
            // 
            this.Btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_3.Location = new System.Drawing.Point(3, 71);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(151, 63);
            this.Btn_3.TabIndex = 1;
            this.Btn_3.Tag = "3";
            this.Btn_3.Text = "button3";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // Btn_2
            // 
            this.Btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_2.Location = new System.Drawing.Point(160, 3);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(151, 62);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Tag = "2";
            this.Btn_2.Text = "button2";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // Btn_4
            // 
            this.Btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_4.Location = new System.Drawing.Point(160, 71);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(151, 63);
            this.Btn_4.TabIndex = 2;
            this.Btn_4.Tag = "4";
            this.Btn_4.Text = "button4";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // tbl_Main
            // 
            this.tbl_Main.ColumnCount = 2;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.Controls.Add(this.tB_Name, 0, 0);
            this.tbl_Main.Controls.Add(this.tbl_Buttons, 0, 1);
            this.tbl_Main.Controls.Add(this.Btn_Start, 1, 1);
            this.tbl_Main.Location = new System.Drawing.Point(12, 12);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 2;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.Size = new System.Drawing.Size(640, 183);
            this.tbl_Main.TabIndex = 1;
            // 
            // tB_Name
            // 
            this.tbl_Main.SetColumnSpan(this.tB_Name, 2);
            this.tB_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Name.Location = new System.Drawing.Point(7, 3);
            this.tB_Name.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(629, 29);
            this.tB_Name.TabIndex = 2;
            this.tB_Name.TextChanged += new System.EventHandler(this.tB_Name_TextChanged);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Start.Location = new System.Drawing.Point(323, 46);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(314, 131);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "button1";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 204);
            this.Controls.Add(this.tbl_Main);
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Screen";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.tbl_Buttons.ResumeLayout(false);
            this.tbl_Main.ResumeLayout(false);
            this.tbl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_Buttons;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.TableLayoutPanel tbl_Main;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Button Btn_Start;
    }
}