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
            this.TextBox_Auswertung = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_Fragen_wiederholen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Answer_4 = new System.Windows.Forms.Button();
            this.Btn_Answer_1 = new System.Windows.Forms.Button();
            this.Btn_Answer_3 = new System.Windows.Forms.Button();
            this.Btn_Answer_2 = new System.Windows.Forms.Button();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.richAufgaben_Gebiet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_Frage = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Auswertung
            // 
            this.TextBox_Auswertung.BackColor = System.Drawing.Color.White;
            this.TextBox_Auswertung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Auswertung.Enabled = false;
            this.TextBox_Auswertung.Location = new System.Drawing.Point(214, 51);
            this.TextBox_Auswertung.Multiline = true;
            this.TextBox_Auswertung.Name = "TextBox_Auswertung";
            this.TextBox_Auswertung.ReadOnly = true;
            this.TextBox_Auswertung.Size = new System.Drawing.Size(276, 43);
            this.TextBox_Auswertung.TabIndex = 29;
            // 
            // Next
            // 
            this.Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(496, 51);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(207, 43);
            this.Next.TabIndex = 28;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start.Location = new System.Drawing.Point(3, 51);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(205, 43);
            this.Start.TabIndex = 27;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_Fragen_wiederholen
            // 
            this.Btn_Fragen_wiederholen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Fragen_wiederholen.Location = new System.Drawing.Point(496, 3);
            this.Btn_Fragen_wiederholen.Name = "Btn_Fragen_wiederholen";
            this.Btn_Fragen_wiederholen.Size = new System.Drawing.Size(207, 42);
            this.Btn_Fragen_wiederholen.TabIndex = 40;
            this.Btn_Fragen_wiederholen.Text = "Falsche Fragen wiederholen";
            this.Btn_Fragen_wiederholen.UseVisualStyleBackColor = true;
            this.Btn_Fragen_wiederholen.Visible = false;
            this.Btn_Fragen_wiederholen.Click += new System.EventHandler(this.Btn_Fragen_wiederholen_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Answer_4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Answer_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Answer_3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Answer_2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Question, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 112);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 155);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // Btn_Answer_4
            // 
            this.Btn_Answer_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_4.Enabled = false;
            this.Btn_Answer_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_4.Location = new System.Drawing.Point(357, 105);
            this.Btn_Answer_4.Name = "Btn_Answer_4";
            this.Btn_Answer_4.Size = new System.Drawing.Size(349, 47);
            this.Btn_Answer_4.TabIndex = 45;
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
            this.Btn_Answer_1.Size = new System.Drawing.Size(348, 46);
            this.Btn_Answer_1.TabIndex = 43;
            this.Btn_Answer_1.UseVisualStyleBackColor = true;
            this.Btn_Answer_1.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_3
            // 
            this.Btn_Answer_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_3.Enabled = false;
            this.Btn_Answer_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_3.Location = new System.Drawing.Point(357, 53);
            this.Btn_Answer_3.Name = "Btn_Answer_3";
            this.Btn_Answer_3.Size = new System.Drawing.Size(349, 46);
            this.Btn_Answer_3.TabIndex = 44;
            this.Btn_Answer_3.UseVisualStyleBackColor = true;
            this.Btn_Answer_3.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // Btn_Answer_2
            // 
            this.Btn_Answer_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Answer_2.Enabled = false;
            this.Btn_Answer_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Answer_2.Location = new System.Drawing.Point(3, 105);
            this.Btn_Answer_2.Name = "Btn_Answer_2";
            this.Btn_Answer_2.Size = new System.Drawing.Size(348, 47);
            this.Btn_Answer_2.TabIndex = 43;
            this.Btn_Answer_2.UseVisualStyleBackColor = true;
            this.Btn_Answer_2.Click += new System.EventHandler(this.Answer_Button_Click);
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_Question, 2);
            this.lbl_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(3, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(703, 50);
            this.lbl_Question.TabIndex = 46;
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Question.Click += new System.EventHandler(this.lbl_Question_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.richAufgaben_Gebiet, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBox_Auswertung, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Fragen_wiederholen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Next, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.Start, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 97);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // richAufgaben_Gebiet
            // 
            this.richAufgaben_Gebiet.AutoSize = true;
            this.richAufgaben_Gebiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richAufgaben_Gebiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richAufgaben_Gebiet.Location = new System.Drawing.Point(214, 0);
            this.richAufgaben_Gebiet.Name = "richAufgaben_Gebiet";
            this.richAufgaben_Gebiet.Size = new System.Drawing.Size(276, 48);
            this.richAufgaben_Gebiet.TabIndex = 43;
            this.richAufgaben_Gebiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 279);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(746, 318);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Auswertung;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Fragen_wiederholen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Answer_1;
        private System.Windows.Forms.Button Btn_Answer_2;
        private System.Windows.Forms.Button Btn_Answer_3;
        private System.Windows.Forms.Button Btn_Answer_4;
        private System.Windows.Forms.Label richAufgaben_Gebiet;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Timer tmr_Frage;
    }
}