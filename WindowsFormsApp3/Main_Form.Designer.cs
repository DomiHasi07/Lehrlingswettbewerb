namespace WindowsFormsApp3
{
    partial class Main_Frm
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
            this.TextBox_Auswertung = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.tmr_Auswertung = new System.Windows.Forms.Timer(this.components);
            this.Btn_Fragen_wiederholen = new System.Windows.Forms.Button();
            this.tbl_1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Answer_4 = new System.Windows.Forms.Button();
            this.Btn_Answer_1 = new System.Windows.Forms.Button();
            this.Btn_Answer_3 = new System.Windows.Forms.Button();
            this.Btn_Answer_2 = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Aufgaben_Gebiet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_Frage = new System.Windows.Forms.Timer(this.components);
            this.pBx_1 = new System.Windows.Forms.PictureBox();
            this.tbl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_1)).BeginInit();
            this.tbl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Auswertung
            // 
            this.TextBox_Auswertung.BackColor = System.Drawing.Color.White;
            this.TextBox_Auswertung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Auswertung.Enabled = false;
            this.TextBox_Auswertung.Location = new System.Drawing.Point(141, 45);
            this.TextBox_Auswertung.Multiline = true;
            this.TextBox_Auswertung.Name = "TextBox_Auswertung";
            this.TextBox_Auswertung.ReadOnly = true;
            this.TextBox_Auswertung.Size = new System.Drawing.Size(178, 36);
            this.TextBox_Auswertung.TabIndex = 29;
            // 
            // Next
            // 
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(325, 45);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(133, 36);
            this.Next.TabIndex = 28;
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start.Location = new System.Drawing.Point(3, 45);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(132, 36);
            this.Start.TabIndex = 27;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // tmr_Auswertung
            // 
            this.tmr_Auswertung.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Fragen_wiederholen
            // 
            this.Btn_Fragen_wiederholen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Fragen_wiederholen.Location = new System.Drawing.Point(325, 3);
            this.Btn_Fragen_wiederholen.Name = "Btn_Fragen_wiederholen";
            this.Btn_Fragen_wiederholen.Size = new System.Drawing.Size(133, 36);
            this.Btn_Fragen_wiederholen.TabIndex = 40;
            this.Btn_Fragen_wiederholen.Text = "Falsche Fragen wiederholen";
            this.Btn_Fragen_wiederholen.UseVisualStyleBackColor = true;
            this.Btn_Fragen_wiederholen.Visible = false;
            this.Btn_Fragen_wiederholen.Click += new System.EventHandler(this.Btn_Fragen_wiederholen_Click);
            // 
            // tbl_1
            // 
            this.tbl_1.ColumnCount = 2;
            this.tbl_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_1.Controls.Add(this.Btn_Answer_4, 2, 2);
            this.tbl_1.Controls.Add(this.Btn_Answer_1, 0, 1);
            this.tbl_1.Controls.Add(this.Btn_Answer_3, 1, 1);
            this.tbl_1.Controls.Add(this.Btn_Answer_2, 0, 2);
            this.tbl_1.Controls.Add(this.lbl_Question, 0, 0);
            this.tbl_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_1.Location = new System.Drawing.Point(3, 93);
            this.tbl_1.Name = "tbl_1";
            this.tbl_1.RowCount = 3;
            this.tbl_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_1.Size = new System.Drawing.Size(461, 159);
            this.tbl_1.TabIndex = 41;
            // 
            // Btn_Answer_4
            // 
            this.Btn_Answer_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Answer_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_4.Enabled = false;
            this.Btn_Answer_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_4.Location = new System.Drawing.Point(233, 107);
            this.Btn_Answer_4.Name = "Btn_Answer_4";
            this.Btn_Answer_4.Size = new System.Drawing.Size(225, 49);
            this.Btn_Answer_4.TabIndex = 45;
            this.Btn_Answer_4.UseVisualStyleBackColor = true;
            this.Btn_Answer_4.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_1
            // 
            this.Btn_Answer_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Answer_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_1.Enabled = false;
            this.Btn_Answer_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_1.Location = new System.Drawing.Point(3, 53);
            this.Btn_Answer_1.Name = "Btn_Answer_1";
            this.Btn_Answer_1.Size = new System.Drawing.Size(224, 48);
            this.Btn_Answer_1.TabIndex = 43;
            this.Btn_Answer_1.UseVisualStyleBackColor = true;
            this.Btn_Answer_1.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_3
            // 
            this.Btn_Answer_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Answer_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_3.Enabled = false;
            this.Btn_Answer_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_3.Location = new System.Drawing.Point(233, 53);
            this.Btn_Answer_3.Name = "Btn_Answer_3";
            this.Btn_Answer_3.Size = new System.Drawing.Size(225, 48);
            this.Btn_Answer_3.TabIndex = 44;
            this.Btn_Answer_3.UseVisualStyleBackColor = true;
            this.Btn_Answer_3.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_2
            // 
            this.Btn_Answer_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Answer_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_2.Enabled = false;
            this.Btn_Answer_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_2.Location = new System.Drawing.Point(3, 107);
            this.Btn_Answer_2.Name = "Btn_Answer_2";
            this.Btn_Answer_2.Size = new System.Drawing.Size(224, 49);
            this.Btn_Answer_2.TabIndex = 43;
            this.Btn_Answer_2.UseVisualStyleBackColor = true;
            this.Btn_Answer_2.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.tbl_1.SetColumnSpan(this.lbl_Question, 2);
            this.lbl_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(3, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(455, 50);
            this.lbl_Question.TabIndex = 46;
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Aufgaben_Gebiet, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_Auswertung, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Fragen_wiederholen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Next, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Start, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 84);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // lbl_Aufgaben_Gebiet
            // 
            this.lbl_Aufgaben_Gebiet.AutoSize = true;
            this.lbl_Aufgaben_Gebiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Aufgaben_Gebiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aufgaben_Gebiet.Location = new System.Drawing.Point(141, 0);
            this.lbl_Aufgaben_Gebiet.Name = "lbl_Aufgaben_Gebiet";
            this.lbl_Aufgaben_Gebiet.Size = new System.Drawing.Size(178, 42);
            this.lbl_Aufgaben_Gebiet.TabIndex = 43;
            this.lbl_Aufgaben_Gebiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pBx_1
            // 
            this.pBx_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBx_1.Enabled = false;
            this.pBx_1.Location = new System.Drawing.Point(470, 3);
            this.pBx_1.Name = "pBx_1";
            this.tbl_Main.SetRowSpan(this.pBx_1, 2);
            this.pBx_1.Size = new System.Drawing.Size(233, 249);
            this.pBx_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBx_1.TabIndex = 43;
            this.pBx_1.TabStop = false;
            this.pBx_1.Visible = false;
            // 
            // tbl_Main
            // 
            this.tbl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Main.ColumnCount = 2;
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_Main.Controls.Add(this.pBx_1, 1, 0);
            this.tbl_Main.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tbl_Main.Controls.Add(this.tbl_1, 0, 1);
            this.tbl_Main.Location = new System.Drawing.Point(12, 12);
            this.tbl_Main.Name = "tbl_Main";
            this.tbl_Main.RowCount = 2;
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tbl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Main.Size = new System.Drawing.Size(706, 255);
            this.tbl_Main.TabIndex = 44;
            // 
            // Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 279);
            this.Controls.Add(this.tbl_Main);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(746, 318);
            this.Name = "Main_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.tbl_1.ResumeLayout(false);
            this.tbl_1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_1)).EndInit();
            this.tbl_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Auswertung;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer tmr_Auswertung;
        private System.Windows.Forms.Button Btn_Fragen_wiederholen;
        private System.Windows.Forms.TableLayoutPanel tbl_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Answer_1;
        private System.Windows.Forms.Button Btn_Answer_2;
        private System.Windows.Forms.Button Btn_Answer_3;
        private System.Windows.Forms.Button Btn_Answer_4;
        private System.Windows.Forms.Label lbl_Aufgaben_Gebiet;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Timer tmr_Frage;
        private System.Windows.Forms.PictureBox pBx_1;
        private System.Windows.Forms.TableLayoutPanel tbl_Main;
    }
}