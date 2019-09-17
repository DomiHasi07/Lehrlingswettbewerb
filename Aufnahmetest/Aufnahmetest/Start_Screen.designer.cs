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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowP_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.tbl_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Main
            // 
            this.tbl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Main.ColumnCount = 2;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Main.Controls.Add(this.TBx_Name, 0, 1);
            this.tbl_Main.Controls.Add(this.panel1, 0, 2);
            this.tbl_Main.Controls.Add(this.Btn_Start, 1, 2);
            this.tbl_Main.Controls.Add(this.pictureBox1, 0, 0);
            this.tbl_Main.Location = new System.Drawing.Point(12, 12);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 3;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.Size = new System.Drawing.Size(1050, 605);
            this.tbl_Main.TabIndex = 1;
            // 
            // TBx_Name
            // 
            this.tbl_Main.SetColumnSpan(this.TBx_Name, 2);
            this.TBx_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_Name.Location = new System.Drawing.Point(7, 223);
            this.TBx_Name.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.TBx_Name.Name = "TBx_Name";
            this.TBx_Name.Size = new System.Drawing.Size(1039, 47);
            this.TBx_Name.TabIndex = 2;
            this.TBx_Name.Text = "Bitte Name eingeben";
            this.TBx_Name.TextChanged += new System.EventHandler(this.tB_Name_TextChanged);
            this.TBx_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBx_Name_KeyDown);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flowP_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 324);
            this.panel1.TabIndex = 3;
            // 
            // flowP_1
            // 
            this.flowP_1.AutoSize = true;
            this.flowP_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowP_1.Location = new System.Drawing.Point(0, 0);
            this.flowP_1.MinimumSize = new System.Drawing.Size(314, 137);
            this.flowP_1.Name = "flowP_1";
            this.flowP_1.Size = new System.Drawing.Size(519, 137);
            this.flowP_1.TabIndex = 4;
            this.flowP_1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowP_1_Paint);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Start.Location = new System.Drawing.Point(528, 281);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(519, 318);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbl_Main.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 214);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Settings.BackgroundImage")));
            this.Btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Settings.Location = new System.Drawing.Point(1065, 15);
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
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.Btn_Settings);
            this.Controls.Add(this.tbl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_Screen_FormClosing);
            this.Load += new System.EventHandler(this.Start_Screen_Load);
            this.tbl_Main.ResumeLayout(false);
            this.tbl_Main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowP_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}