namespace WindowsFormsApp3
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Aufgaben_Gebiet = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.TextBox();
            this.Auswahl_Text_Größe = new System.Windows.Forms.ComboBox();
            this.Btn_Text_bigger = new System.Windows.Forms.Button();
            this.text_size = new System.Windows.Forms.Label();
            this.Btn_Text_smaller = new System.Windows.Forms.Button();
            this.Btn_Answer4 = new System.Windows.Forms.Button();
            this.Btn_Answer3 = new System.Windows.Forms.Button();
            this.Btn_Answer2 = new System.Windows.Forms.Button();
            this.Btn_Answer1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(107, 100);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(95, 35);
            this.Next.TabIndex = 28;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 100);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 35);
            this.Start.TabIndex = 27;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Aufgaben_Gebiet
            // 
            this.Aufgaben_Gebiet.Location = new System.Drawing.Point(12, 141);
            this.Aufgaben_Gebiet.MaximumSize = new System.Drawing.Size(190, 40);
            this.Aufgaben_Gebiet.MinimumSize = new System.Drawing.Size(190, 20);
            this.Aufgaben_Gebiet.Multiline = true;
            this.Aufgaben_Gebiet.Name = "Aufgaben_Gebiet";
            this.Aufgaben_Gebiet.ReadOnly = true;
            this.Aufgaben_Gebiet.Size = new System.Drawing.Size(190, 20);
            this.Aufgaben_Gebiet.TabIndex = 26;
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(12, 167);
            this.Question.MinimumSize = new System.Drawing.Size(190, 20);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(190, 20);
            this.Question.TabIndex = 25;
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged_1);
            // 
            // Auswahl_Text_Größe
            // 
            this.Auswahl_Text_Größe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Auswahl_Text_Größe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auswahl_Text_Größe.FormattingEnabled = true;
            this.Auswahl_Text_Größe.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.Auswahl_Text_Größe.Location = new System.Drawing.Point(128, 51);
            this.Auswahl_Text_Größe.Name = "Auswahl_Text_Größe";
            this.Auswahl_Text_Größe.Size = new System.Drawing.Size(45, 26);
            this.Auswahl_Text_Größe.TabIndex = 24;
            this.Auswahl_Text_Größe.SelectedIndexChanged += new System.EventHandler(this.Auswahl_Text_Größe_SelectedIndexChanged);
            // 
            // Btn_Text_bigger
            // 
            this.Btn_Text_bigger.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Text_bigger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Text_bigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Text_bigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Text_bigger.Location = new System.Drawing.Point(85, 51);
            this.Btn_Text_bigger.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Text_bigger.Name = "Btn_Text_bigger";
            this.Btn_Text_bigger.Size = new System.Drawing.Size(30, 26);
            this.Btn_Text_bigger.TabIndex = 23;
            this.Btn_Text_bigger.UseVisualStyleBackColor = false;
            this.Btn_Text_bigger.Click += new System.EventHandler(this.Btn_Text_bigger_click);
            // 
            // text_size
            // 
            this.text_size.AutoSize = true;
            this.text_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_size.Location = new System.Drawing.Point(64, 32);
            this.text_size.Name = "text_size";
            this.text_size.Size = new System.Drawing.Size(80, 16);
            this.text_size.TabIndex = 22;
            this.text_size.Text = "Schriftgröße";
            // 
            // Btn_Text_smaller
            // 
            this.Btn_Text_smaller.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Text_smaller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Text_smaller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Text_smaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Text_smaller.Location = new System.Drawing.Point(43, 51);
            this.Btn_Text_smaller.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Text_smaller.Name = "Btn_Text_smaller";
            this.Btn_Text_smaller.Size = new System.Drawing.Size(30, 26);
            this.Btn_Text_smaller.TabIndex = 21;
            this.Btn_Text_smaller.UseVisualStyleBackColor = false;
            this.Btn_Text_smaller.Click += new System.EventHandler(this.Btn_Text_smaller_click);
            // 
            // Btn_Answer4
            // 
            this.Btn_Answer4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Answer4.Enabled = false;
            this.Btn_Answer4.Location = new System.Drawing.Point(12, 316);
            this.Btn_Answer4.MaximumSize = new System.Drawing.Size(0, 70);
            this.Btn_Answer4.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer4.Name = "Btn_Answer4";
            this.Btn_Answer4.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer4.TabIndex = 20;
            this.Btn_Answer4.UseVisualStyleBackColor = true;
            this.Btn_Answer4.Click += new System.EventHandler(this.Btn_Answer4_Click);
            // 
            // Btn_Answer3
            // 
            this.Btn_Answer3.AutoSize = true;
            this.Btn_Answer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Answer3.Enabled = false;
            this.Btn_Answer3.Location = new System.Drawing.Point(12, 275);
            this.Btn_Answer3.MaximumSize = new System.Drawing.Size(0, 70);
            this.Btn_Answer3.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer3.Name = "Btn_Answer3";
            this.Btn_Answer3.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer3.TabIndex = 19;
            this.Btn_Answer3.UseVisualStyleBackColor = true;
            this.Btn_Answer3.Click += new System.EventHandler(this.Btn_Answer3_Click_1);
            // 
            // Btn_Answer2
            // 
            this.Btn_Answer2.AutoSize = true;
            this.Btn_Answer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Answer2.Enabled = false;
            this.Btn_Answer2.Location = new System.Drawing.Point(12, 234);
            this.Btn_Answer2.MaximumSize = new System.Drawing.Size(0, 70);
            this.Btn_Answer2.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer2.Name = "Btn_Answer2";
            this.Btn_Answer2.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer2.TabIndex = 18;
            this.Btn_Answer2.UseVisualStyleBackColor = true;
            this.Btn_Answer2.Click += new System.EventHandler(this.Btn_Answer2_Click_1);
            // 
            // Btn_Answer1
            // 
            this.Btn_Answer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Answer1.AutoSize = true;
            this.Btn_Answer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Answer1.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Answer1.Enabled = false;
            this.Btn_Answer1.Location = new System.Drawing.Point(12, 193);
            this.Btn_Answer1.MaximumSize = new System.Drawing.Size(0, 70);
            this.Btn_Answer1.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer1.Name = "Btn_Answer1";
            this.Btn_Answer1.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer1.TabIndex = 17;
            this.Btn_Answer1.UseVisualStyleBackColor = false;
            this.Btn_Answer1.Click += new System.EventHandler(this.Btn_Answer1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(464, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Aufgaben_Gebiet);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Auswahl_Text_Größe);
            this.Controls.Add(this.Btn_Text_bigger);
            this.Controls.Add(this.text_size);
            this.Controls.Add(this.Btn_Text_smaller);
            this.Controls.Add(this.Btn_Answer4);
            this.Controls.Add(this.Btn_Answer3);
            this.Controls.Add(this.Btn_Answer2);
            this.Controls.Add(this.Btn_Answer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Aufgaben_Gebiet;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.ComboBox Auswahl_Text_Größe;
        private System.Windows.Forms.Button Btn_Text_bigger;
        private System.Windows.Forms.Label text_size;
        private System.Windows.Forms.Button Btn_Text_smaller;
        private System.Windows.Forms.Button Btn_Answer4;
        private System.Windows.Forms.Button Btn_Answer3;
        private System.Windows.Forms.Button Btn_Answer2;
        private System.Windows.Forms.Button Btn_Answer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}