namespace WindowsFormsApp3
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.tmr_Auswertung = new System.Windows.Forms.Timer(this.components);
            this.tbl_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Answer_4 = new System.Windows.Forms.Button();
            this.Btn_Answer_1 = new System.Windows.Forms.Button();
            this.Btn_Answer_3 = new System.Windows.Forms.Button();
            this.Btn_Answer_2 = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.Tbl_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Aufgaben_Gebiet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_Frage = new System.Windows.Forms.Timer(this.components);
            this.tbL_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pBx_1 = new System.Windows.Forms.PictureBox();
            this.tbl_Buttons.SuspendLayout();
            this.Tbl_Menu.SuspendLayout();
            this.tbL_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Next
            // 
            this.Btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Next.Enabled = false;
            this.Btn_Next.Location = new System.Drawing.Point(479, 3);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(199, 43);
            this.Btn_Next.TabIndex = 28;
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Start.Location = new System.Drawing.Point(3, 3);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(198, 43);
            this.Btn_Start.TabIndex = 27;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // tbl_Buttons
            // 
            this.tbl_Buttons.ColumnCount = 2;
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Controls.Add(this.Btn_Answer_4, 2, 2);
            this.tbl_Buttons.Controls.Add(this.Btn_Answer_1, 0, 1);
            this.tbl_Buttons.Controls.Add(this.Btn_Answer_3, 1, 1);
            this.tbl_Buttons.Controls.Add(this.Btn_Answer_2, 0, 2);
            this.tbl_Buttons.Controls.Add(this.lbl_Question, 0, 0);
            this.tbl_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Buttons.Location = new System.Drawing.Point(3, 58);
            this.tbl_Buttons.Name = "tbl_Buttons";
            this.tbl_Buttons.RowCount = 3;
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Buttons.Size = new System.Drawing.Size(681, 191);
            this.tbl_Buttons.TabIndex = 41;
            // 
            // Btn_Answer_4
            // 
            this.Btn_Answer_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_4.Enabled = false;
            this.Btn_Answer_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_4.Location = new System.Drawing.Point(343, 123);
            this.Btn_Answer_4.Name = "Btn_Answer_4";
            this.Btn_Answer_4.Size = new System.Drawing.Size(335, 65);
            this.Btn_Answer_4.TabIndex = 45;
            this.Btn_Answer_4.Tag = "3";
            this.Btn_Answer_4.UseVisualStyleBackColor = true;
            this.Btn_Answer_4.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_1
            // 
            this.Btn_Answer_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_1.Enabled = false;
            this.Btn_Answer_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_1.Location = new System.Drawing.Point(3, 53);
            this.Btn_Answer_1.Name = "Btn_Answer_1";
            this.Btn_Answer_1.Size = new System.Drawing.Size(334, 64);
            this.Btn_Answer_1.TabIndex = 43;
            this.Btn_Answer_1.Tag = "0";
            this.Btn_Answer_1.UseVisualStyleBackColor = true;
            this.Btn_Answer_1.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_3
            // 
            this.Btn_Answer_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_3.Enabled = false;
            this.Btn_Answer_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_3.Location = new System.Drawing.Point(343, 53);
            this.Btn_Answer_3.Name = "Btn_Answer_3";
            this.Btn_Answer_3.Size = new System.Drawing.Size(335, 64);
            this.Btn_Answer_3.TabIndex = 44;
            this.Btn_Answer_3.Tag = "2";
            this.Btn_Answer_3.UseVisualStyleBackColor = true;
            this.Btn_Answer_3.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_2
            // 
            this.Btn_Answer_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_2.Enabled = false;
            this.Btn_Answer_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_2.Location = new System.Drawing.Point(3, 123);
            this.Btn_Answer_2.Name = "Btn_Answer_2";
            this.Btn_Answer_2.Size = new System.Drawing.Size(334, 65);
            this.Btn_Answer_2.TabIndex = 43;
            this.Btn_Answer_2.Tag = "1";
            this.Btn_Answer_2.UseVisualStyleBackColor = true;
            this.Btn_Answer_2.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.tbl_Buttons.SetColumnSpan(this.lbl_Question, 2);
            this.lbl_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(3, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(675, 50);
            this.lbl_Question.TabIndex = 46;
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbl_Menu
            // 
            this.Tbl_Menu.ColumnCount = 3;
            this.Tbl_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Tbl_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.Tbl_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Tbl_Menu.Controls.Add(this.lbl_Aufgaben_Gebiet, 1, 0);
            this.Tbl_Menu.Controls.Add(this.Btn_Next, 2, 0);
            this.Tbl_Menu.Controls.Add(this.Btn_Start, 0, 0);
            this.Tbl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_Menu.Location = new System.Drawing.Point(3, 3);
            this.Tbl_Menu.Name = "Tbl_Menu";
            this.Tbl_Menu.RowCount = 1;
            this.Tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.Tbl_Menu.Size = new System.Drawing.Size(681, 49);
            this.Tbl_Menu.TabIndex = 42;
            // 
            // lbl_Aufgaben_Gebiet
            // 
            this.lbl_Aufgaben_Gebiet.AutoSize = true;
            this.lbl_Aufgaben_Gebiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Aufgaben_Gebiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Aufgaben_Gebiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aufgaben_Gebiet.Location = new System.Drawing.Point(207, 4);
            this.lbl_Aufgaben_Gebiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbl_Aufgaben_Gebiet.Name = "lbl_Aufgaben_Gebiet";
            this.lbl_Aufgaben_Gebiet.Size = new System.Drawing.Size(266, 41);
            this.lbl_Aufgaben_Gebiet.TabIndex = 43;
            this.lbl_Aufgaben_Gebiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Aufgaben_Gebiet.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 39;
            // 
            // tmr_Frage
            // 
            this.tmr_Frage.Tick += new System.EventHandler(this.tmr_Frage_Tick);
            // 
            // tbL_Main
            // 
            this.tbL_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbL_Main.ColumnCount = 2;
            this.tbL_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbL_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbL_Main.Controls.Add(this.pBx_1, 1, 0);
            this.tbL_Main.Controls.Add(this.Tbl_Menu, 0, 0);
            this.tbL_Main.Controls.Add(this.tbl_Buttons, 0, 1);
            this.tbL_Main.Location = new System.Drawing.Point(12, 12);
            this.tbL_Main.Name = "tbL_Main";
            this.tbL_Main.RowCount = 2;
            this.tbL_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tbL_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbL_Main.Size = new System.Drawing.Size(707, 252);
            this.tbL_Main.TabIndex = 44;
            // 
            // pBx_1
            // 
            this.pBx_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBx_1.Enabled = false;
            this.pBx_1.Location = new System.Drawing.Point(690, 3);
            this.pBx_1.Name = "pBx_1";
            this.tbL_Main.SetRowSpan(this.pBx_1, 2);
            this.pBx_1.Size = new System.Drawing.Size(14, 246);
            this.pBx_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBx_1.TabIndex = 45;
            this.pBx_1.TabStop = false;
            this.pBx_1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 279);
            this.Controls.Add(this.tbL_Main);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tbl_Buttons.ResumeLayout(false);
            this.tbl_Buttons.PerformLayout();
            this.Tbl_Menu.ResumeLayout(false);
            this.Tbl_Menu.PerformLayout();
            this.tbL_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBx_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Timer tmr_Auswertung;
        private System.Windows.Forms.TableLayoutPanel tbl_Buttons;
        private System.Windows.Forms.TableLayoutPanel Tbl_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Answer_1;
        private System.Windows.Forms.Button Btn_Answer_2;
        private System.Windows.Forms.Button Btn_Answer_3;
        private System.Windows.Forms.Button Btn_Answer_4;
        private System.Windows.Forms.Label lbl_Aufgaben_Gebiet;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Timer tmr_Frage;
        private System.Windows.Forms.TableLayoutPanel tbL_Main;
        private System.Windows.Forms.PictureBox pBx_1;
    }
}