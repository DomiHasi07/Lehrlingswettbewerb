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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Screen));
            this.tbl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.TBx_Name = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.tbl_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.tbl_Main.SuspendLayout();
            this.tbl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Main
            // 
            this.tbl_Main.ColumnCount = 2;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.Controls.Add(this.TBx_Name, 0, 0);
            this.tbl_Main.Controls.Add(this.Btn_Start, 1, 1);
            this.tbl_Main.Controls.Add(this.tbl_Buttons, 0, 1);
            this.tbl_Main.Location = new System.Drawing.Point(12, 12);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 2;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.Size = new System.Drawing.Size(640, 183);
            this.tbl_Main.TabIndex = 1;
            // 
            // TBx_Name
            // 
            this.tbl_Main.SetColumnSpan(this.TBx_Name, 2);
            this.TBx_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Name.Location = new System.Drawing.Point(7, 3);
            this.TBx_Name.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.TBx_Name.Name = "TBx_Name";
            this.TBx_Name.Size = new System.Drawing.Size(629, 29);
            this.TBx_Name.TabIndex = 2;
            this.TBx_Name.TextChanged += new System.EventHandler(this.tB_Name_TextChanged);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Start.Location = new System.Drawing.Point(323, 46);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(314, 131);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // tbl_Buttons
            // 
            this.tbl_Buttons.ColumnCount = 2;
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Controls.Add(this.Btn_1, 0, 0);
            this.tbl_Buttons.Controls.Add(this.Btn_2, 1, 0);
            this.tbl_Buttons.Controls.Add(this.Btn_4, 1, 1);
            this.tbl_Buttons.Controls.Add(this.Btn_3, 0, 1);
            this.tbl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Buttons.Location = new System.Drawing.Point(3, 43);
            this.tbl_Buttons.Name = "tbl_Buttons";
            this.tbl_Buttons.RowCount = 2;
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Size = new System.Drawing.Size(314, 137);
            this.tbl_Buttons.TabIndex = 4;
            // 
            // Btn_1
            // 
            this.Btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_1.Location = new System.Drawing.Point(3, 3);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(151, 62);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Tag = "Allgemeines_Wissen";
            this.Btn_1.Text = "Allgemeines Wissen";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // Btn_2
            // 
            this.Btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_2.Location = new System.Drawing.Point(160, 3);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(151, 62);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Tag = "Rechnen";
            this.Btn_2.Text = "Rechnen";
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
            this.Btn_4.Tag = "Pysikalisches_Wissen";
            this.Btn_4.Text = "Pysikalisches Wissen";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // Btn_3
            // 
            this.Btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_3.Location = new System.Drawing.Point(3, 71);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(151, 63);
            this.Btn_3.TabIndex = 1;
            this.Btn_3.Tag = "Technisches_Wissen";
            this.Btn_3.Text = "Technisches Wissen";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Auswahl_getroffen);
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Settings.BackgroundImage")));
            this.Btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Settings.Location = new System.Drawing.Point(655, 15);
            this.Btn_Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(30, 29);
            this.Btn_Settings.TabIndex = 2;
            this.Btn_Settings.UseVisualStyleBackColor = true;
            this.Btn_Settings.Visible = false;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Start_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 206);
            this.Controls.Add(this.Btn_Settings);
            this.Controls.Add(this.tbl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Screen";
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.tbl_Main.ResumeLayout(false);
            this.tbl_Main.PerformLayout();
            this.tbl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Btn_1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tbl_Main;
        private System.Windows.Forms.TextBox TBx_Name;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Settings;
        private System.Windows.Forms.TableLayoutPanel tbl_Buttons;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_3;
    }
}