namespace Aufnahmetest
{
    partial class TEST
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
            this.conMenStr_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.postionVerändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachObenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachUntenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.change_Name_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.change_Path_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenStr_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conMenStr_1
            // 
            this.conMenStr_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändernToolStripMenuItem,
            this.change_Path_conMenStr_1,
            this.change_Name_conMenStr_1,
            this.delete_conMenStr_1,
            this.postionVerändernToolStripMenuItem});
            this.conMenStr_1.Name = "contextMenuStrip1";
            this.conMenStr_1.Size = new System.Drawing.Size(187, 136);
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ändernToolStripMenuItem.Text = "Ändern";
            // 
            // delete_conMenStr_1
            // 
            this.delete_conMenStr_1.Name = "delete_conMenStr_1";
            this.delete_conMenStr_1.Size = new System.Drawing.Size(186, 22);
            this.delete_conMenStr_1.Text = "Löschen";
            this.delete_conMenStr_1.Click += new System.EventHandler(this.delete_conMenStr_1_Click);
            // 
            // postionVerändernToolStripMenuItem
            // 
            this.postionVerändernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachObenToolStripMenuItem,
            this.nachUntenToolStripMenuItem});
            this.postionVerändernToolStripMenuItem.Name = "postionVerändernToolStripMenuItem";
            this.postionVerändernToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.postionVerändernToolStripMenuItem.Text = "Postion verändern";
            // 
            // nachObenToolStripMenuItem
            // 
            this.nachObenToolStripMenuItem.Name = "nachObenToolStripMenuItem";
            this.nachObenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nachObenToolStripMenuItem.Text = "nach oben";
            // 
            // nachUntenToolStripMenuItem
            // 
            this.nachUntenToolStripMenuItem.Name = "nachUntenToolStripMenuItem";
            this.nachUntenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nachUntenToolStripMenuItem.Text = "nach unten";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 153);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(899, 285);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 6;
            // 
            // change_Name_conMenStr_1
            // 
            this.change_Name_conMenStr_1.Name = "change_Name_conMenStr_1";
            this.change_Name_conMenStr_1.Size = new System.Drawing.Size(186, 22);
            this.change_Name_conMenStr_1.Text = "Anzeigename ändern";
            this.change_Name_conMenStr_1.Click += new System.EventHandler(this.change_Name_conMenStr_1_Click);
            // 
            // change_Path_conMenStr_1
            // 
            this.change_Path_conMenStr_1.Name = "change_Path_conMenStr_1";
            this.change_Path_conMenStr_1.Size = new System.Drawing.Size(186, 22);
            this.change_Path_conMenStr_1.Text = "Pfad ändern";
            this.change_Path_conMenStr_1.Click += new System.EventHandler(this.change_Path_conMenStr_1_Click);
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "TEST";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            this.Resize += new System.EventHandler(this.TEST_Resize);
            this.conMenStr_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip conMenStr_1;
        private System.Windows.Forms.ToolStripMenuItem delete_conMenStr_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem postionVerändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachObenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachUntenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem change_Path_conMenStr_1;
        private System.Windows.Forms.ToolStripMenuItem change_Name_conMenStr_1;
    }
}