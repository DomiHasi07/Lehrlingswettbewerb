namespace WindowsFormsApp3
{
    partial class Test
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
            this.Auswahl_Text_Größe = new System.Windows.Forms.ComboBox();
            this.Btn_Text_bigger = new System.Windows.Forms.Button();
            this.text_size = new System.Windows.Forms.Label();
            this.Btn_Text_smaller = new System.Windows.Forms.Button();
            this.richAnswer4 = new System.Windows.Forms.RichTextBox();
            this.richQuestion = new System.Windows.Forms.RichTextBox();
            this.richAufgaben_Gebiet = new System.Windows.Forms.RichTextBox();
            this.richAnswer3 = new System.Windows.Forms.RichTextBox();
            this.richAnswer2 = new System.Windows.Forms.RichTextBox();
            this.richAnswer1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(240, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 29;
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(546, 133);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(197, 48);
            this.Next.TabIndex = 28;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(37, 133);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(197, 48);
            this.Start.TabIndex = 27;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
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
            // richAnswer4
            // 
            this.richAnswer4.BackColor = System.Drawing.Color.Gainsboro;
            this.richAnswer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.richAnswer4.Enabled = false;
            this.richAnswer4.Location = new System.Drawing.Point(393, 279);
            this.richAnswer4.Name = "richAnswer4";
            this.richAnswer4.ReadOnly = true;
            this.richAnswer4.Size = new System.Drawing.Size(350, 40);
            this.richAnswer4.TabIndex = 30;
            this.richAnswer4.Text = "";
            this.richAnswer4.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richQuestion
            // 
            this.richQuestion.Location = new System.Drawing.Point(37, 187);
            this.richQuestion.Name = "richQuestion";
            this.richQuestion.ReadOnly = true;
            this.richQuestion.Size = new System.Drawing.Size(706, 40);
            this.richQuestion.TabIndex = 34;
            this.richQuestion.Text = "";
            // 
            // richAufgaben_Gebiet
            // 
            this.richAufgaben_Gebiet.Location = new System.Drawing.Point(240, 159);
            this.richAufgaben_Gebiet.Name = "richAufgaben_Gebiet";
            this.richAufgaben_Gebiet.ReadOnly = true;
            this.richAufgaben_Gebiet.Size = new System.Drawing.Size(300, 22);
            this.richAufgaben_Gebiet.TabIndex = 35;
            this.richAufgaben_Gebiet.Text = "";
            // 
            // richAnswer3
            // 
            this.richAnswer3.BackColor = System.Drawing.Color.Gainsboro;
            this.richAnswer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.richAnswer3.Enabled = false;
            this.richAnswer3.Location = new System.Drawing.Point(37, 279);
            this.richAnswer3.Name = "richAnswer3";
            this.richAnswer3.ReadOnly = true;
            this.richAnswer3.Size = new System.Drawing.Size(350, 40);
            this.richAnswer3.TabIndex = 36;
            this.richAnswer3.Text = "";
            // 
            // richAnswer2
            // 
            this.richAnswer2.BackColor = System.Drawing.Color.Gainsboro;
            this.richAnswer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richAnswer2.Enabled = false;
            this.richAnswer2.Location = new System.Drawing.Point(393, 233);
            this.richAnswer2.Name = "richAnswer2";
            this.richAnswer2.ReadOnly = true;
            this.richAnswer2.Size = new System.Drawing.Size(350, 40);
            this.richAnswer2.TabIndex = 37;
            this.richAnswer2.Text = "";
            // 
            // richAnswer1
            // 
            this.richAnswer1.BackColor = System.Drawing.Color.Gainsboro;
            this.richAnswer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richAnswer1.Enabled = false;
            this.richAnswer1.Location = new System.Drawing.Point(37, 233);
            this.richAnswer1.Name = "richAnswer1";
            this.richAnswer1.ReadOnly = true;
            this.richAnswer1.ShortcutsEnabled = false;
            this.richAnswer1.Size = new System.Drawing.Size(350, 40);
            this.richAnswer1.TabIndex = 38;
            this.richAnswer1.Text = "";
            this.richAnswer1.TextChanged += new System.EventHandler(this.richAnswer1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 39;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richAnswer1);
            this.Controls.Add(this.richAnswer2);
            this.Controls.Add(this.richAnswer3);
            this.Controls.Add(this.richAufgaben_Gebiet);
            this.Controls.Add(this.richQuestion);
            this.Controls.Add(this.richAnswer4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Auswahl_Text_Größe);
            this.Controls.Add(this.Btn_Text_bigger);
            this.Controls.Add(this.text_size);
            this.Controls.Add(this.Btn_Text_smaller);
            this.Name = "Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox Auswahl_Text_Größe;
        private System.Windows.Forms.Button Btn_Text_bigger;
        private System.Windows.Forms.Label text_size;
        private System.Windows.Forms.Button Btn_Text_smaller;
        private System.Windows.Forms.RichTextBox richAnswer4;
        private System.Windows.Forms.RichTextBox richQuestion;
        private System.Windows.Forms.RichTextBox richAufgaben_Gebiet;
        private System.Windows.Forms.RichTextBox richAnswer3;
        private System.Windows.Forms.RichTextBox richAnswer2;
        private System.Windows.Forms.RichTextBox richAnswer1;
        private System.Windows.Forms.Label label1;
    }
}