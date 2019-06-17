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
            this.change_Name_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.change_Path_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenStr_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conMenStr_1
            // 
            this.conMenStr_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändernToolStripMenuItem,
            this.change_Name_conMenStr_1,
            this.change_Path_conMenStr_1,
            this.delete_conMenStr_1});
            this.conMenStr_1.Name = "contextMenuStrip1";
            this.conMenStr_1.Size = new System.Drawing.Size(147, 92);
            // 
            // change_Name_conMenStr_1
            // 
            this.change_Name_conMenStr_1.Name = "change_Name_conMenStr_1";
            this.change_Name_conMenStr_1.Size = new System.Drawing.Size(146, 22);
            this.change_Name_conMenStr_1.Text = "Name ändern";
            this.change_Name_conMenStr_1.Click += new System.EventHandler(this.change_Name_conMenStr_1_Click);
            // 
            // change_Path_conMenStr_1
            // 
            this.change_Path_conMenStr_1.Name = "change_Path_conMenStr_1";
            this.change_Path_conMenStr_1.Size = new System.Drawing.Size(146, 22);
            this.change_Path_conMenStr_1.Text = "Pfad ändern";
            this.change_Path_conMenStr_1.Click += new System.EventHandler(this.change_Path_conMenStr_1_Click);
            // 
            // delete_conMenStr_1
            // 
            this.delete_conMenStr_1.Name = "delete_conMenStr_1";
            this.delete_conMenStr_1.Size = new System.Drawing.Size(146, 22);
            this.delete_conMenStr_1.Text = "Löschen";
            this.delete_conMenStr_1.Click += new System.EventHandler(this.delete_conMenStr_1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 153);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(717, 285);
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
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ändernToolStripMenuItem.Text = "Ändern";
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "TEST";
            this.Text = "TEST";
            this.conMenStr_1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip conMenStr_1;
        private System.Windows.Forms.ToolStripMenuItem change_Name_conMenStr_1;
        private System.Windows.Forms.ToolStripMenuItem change_Path_conMenStr_1;
        private System.Windows.Forms.ToolStripMenuItem delete_conMenStr_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
    }
}