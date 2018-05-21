namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Answer1 = new System.Windows.Forms.Button();
            this.Btn_Answer2 = new System.Windows.Forms.Button();
            this.Btn_Answer3 = new System.Windows.Forms.Button();
            this.Btn_Answer4 = new System.Windows.Forms.Button();
            this.text_size = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Button();
            this.Auswahl_Text_Größe = new System.Windows.Forms.ComboBox();
            this.Question = new System.Windows.Forms.TextBox();
            this.Aufgaben_Gebiet = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Answer1
            // 
            this.Btn_Answer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Answer1.AutoSize = true;
            this.Btn_Answer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Answer1.BackColor = System.Drawing.Color.Gainsboro;
            this.Btn_Answer1.Enabled = false;
            this.Btn_Answer1.Location = new System.Drawing.Point(70, 175);
            this.Btn_Answer1.MaximumSize = new System.Drawing.Size(0, 35);
            this.Btn_Answer1.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer1.Name = "Btn_Answer1";
            this.Btn_Answer1.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer1.TabIndex = 1;
            this.Btn_Answer1.UseVisualStyleBackColor = false;
            this.Btn_Answer1.Click += new System.EventHandler(this.Btn_Answer_1);
            // 
            // Btn_Answer2
            // 
            this.Btn_Answer2.AutoSize = true;
            this.Btn_Answer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Answer2.Enabled = false;
            this.Btn_Answer2.Location = new System.Drawing.Point(70, 216);
            this.Btn_Answer2.MaximumSize = new System.Drawing.Size(0, 35);
            this.Btn_Answer2.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer2.Name = "Btn_Answer2";
            this.Btn_Answer2.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer2.TabIndex = 2;
            this.Btn_Answer2.UseVisualStyleBackColor = true;
            this.Btn_Answer2.Click += new System.EventHandler(this.Btn_Answer2_Click);
            // 
            // Btn_Answer3
            // 
            this.Btn_Answer3.Enabled = false;
            this.Btn_Answer3.Location = new System.Drawing.Point(70, 257);
            this.Btn_Answer3.MaximumSize = new System.Drawing.Size(0, 35);
            this.Btn_Answer3.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer3.Name = "Btn_Answer3";
            this.Btn_Answer3.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer3.TabIndex = 3;
            this.Btn_Answer3.UseVisualStyleBackColor = true;
            this.Btn_Answer3.Click += new System.EventHandler(this.Btn_Answer3_Click);
            // 
            // Btn_Answer4
            // 
            this.Btn_Answer4.Enabled = false;
            this.Btn_Answer4.Location = new System.Drawing.Point(70, 298);
            this.Btn_Answer4.MaximumSize = new System.Drawing.Size(0, 35);
            this.Btn_Answer4.MinimumSize = new System.Drawing.Size(190, 35);
            this.Btn_Answer4.Name = "Btn_Answer4";
            this.Btn_Answer4.Size = new System.Drawing.Size(190, 35);
            this.Btn_Answer4.TabIndex = 4;
            this.Btn_Answer4.UseVisualStyleBackColor = true;
            this.Btn_Answer4.Click += new System.EventHandler(this.Btn_Answer4_Click);
            // 
            // text_size
            // 
            this.text_size.AutoSize = true;
            this.text_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_size.Location = new System.Drawing.Point(122, 14);
            this.text_size.Name = "text_size";
            this.text_size.Size = new System.Drawing.Size(80, 16);
            this.text_size.TabIndex = 7;
            this.text_size.Text = "Schriftgröße";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Text_bigger);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(101, 33);
            this.text.Margin = new System.Windows.Forms.Padding(0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(30, 26);
            this.text.TabIndex = 5;
            this.text.UseVisualStyleBackColor = false;
            this.text.Click += new System.EventHandler(this.Text_smaller);
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
            this.Auswahl_Text_Größe.Location = new System.Drawing.Point(186, 33);
            this.Auswahl_Text_Größe.Name = "Auswahl_Text_Größe";
            this.Auswahl_Text_Größe.Size = new System.Drawing.Size(45, 26);
            this.Auswahl_Text_Größe.TabIndex = 11;
            this.Auswahl_Text_Größe.SelectedIndexChanged += new System.EventHandler(this.Auswahl_Text_Göße);
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(70, 149);
            this.Question.MaximumSize = new System.Drawing.Size(190, 40);
            this.Question.MinimumSize = new System.Drawing.Size(190, 20);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Size = new System.Drawing.Size(190, 20);
            this.Question.TabIndex = 12;
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged);
            // 
            // Aufgaben_Gebiet
            // 
            this.Aufgaben_Gebiet.Location = new System.Drawing.Point(70, 123);
            this.Aufgaben_Gebiet.MaximumSize = new System.Drawing.Size(190, 40);
            this.Aufgaben_Gebiet.MinimumSize = new System.Drawing.Size(190, 20);
            this.Aufgaben_Gebiet.Multiline = true;
            this.Aufgaben_Gebiet.Name = "Aufgaben_Gebiet";
            this.Aufgaben_Gebiet.ReadOnly = true;
            this.Aufgaben_Gebiet.Size = new System.Drawing.Size(190, 20);
            this.Aufgaben_Gebiet.TabIndex = 13;
            this.Aufgaben_Gebiet.TextChanged += new System.EventHandler(this.Aufgaben_Gebiet_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(70, 82);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(95, 35);
            this.Start.TabIndex = 14;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(165, 82);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(95, 35);
            this.Next.TabIndex = 15;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Btn_Next);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 407);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Aufgaben_Gebiet);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Auswahl_Text_Größe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_size);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Btn_Answer4);
            this.Controls.Add(this.Btn_Answer3);
            this.Controls.Add(this.Btn_Answer2);
            this.Controls.Add(this.Btn_Answer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Answer1;
        private System.Windows.Forms.Button Btn_Answer2;
        private System.Windows.Forms.Button Btn_Answer3;
        private System.Windows.Forms.Button Btn_Answer4;
        private System.Windows.Forms.Button text;
        private System.Windows.Forms.Label text_size;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Auswahl_Text_Größe;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.TextBox Aufgaben_Gebiet;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox textBox1;
    }
}

