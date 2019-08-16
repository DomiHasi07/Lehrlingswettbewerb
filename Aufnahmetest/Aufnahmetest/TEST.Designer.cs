namespace Aufnahmetest
{
    partial class Frm_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Test));
            this.conMenStr_1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfadändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postionVerändernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachObenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nachUntenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_conMenStr_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.conMenStr_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // conMenStr_1
            // 
            this.conMenStr_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändernToolStripMenuItem,
            this.postionVerändernToolStripMenuItem,
            this.delete_conMenStr_1});
            this.conMenStr_1.Name = "contextMenuStrip1";
            this.conMenStr_1.Size = new System.Drawing.Size(174, 70);
            this.conMenStr_1.Opening += new System.ComponentModel.CancelEventHandler(this.conMenStr_1_Opening);
            // 
            // ändernToolStripMenuItem
            // 
            this.ändernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pfadändernToolStripMenuItem,
            this.anzeigenameToolStripMenuItem});
            this.ändernToolStripMenuItem.Name = "ändernToolStripMenuItem";
            this.ändernToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ändernToolStripMenuItem.Text = "Ändern";
            // 
            // pfadändernToolStripMenuItem
            // 
            this.pfadändernToolStripMenuItem.Name = "pfadändernToolStripMenuItem";
            this.pfadändernToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pfadändernToolStripMenuItem.Text = "Pfad";
            this.pfadändernToolStripMenuItem.Click += new System.EventHandler(this.change_Path_conMenStr_1_Click);
            // 
            // anzeigenameToolStripMenuItem
            // 
            this.anzeigenameToolStripMenuItem.Name = "anzeigenameToolStripMenuItem";
            this.anzeigenameToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.anzeigenameToolStripMenuItem.Text = "Anzeigename";
            this.anzeigenameToolStripMenuItem.Click += new System.EventHandler(this.change_Name_conMenStr_1_Click);
            // 
            // postionVerändernToolStripMenuItem
            // 
            this.postionVerändernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nachObenToolStripMenuItem,
            this.nachUntenToolStripMenuItem});
            this.postionVerändernToolStripMenuItem.Name = "postionVerändernToolStripMenuItem";
            this.postionVerändernToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.postionVerändernToolStripMenuItem.Text = "Position verändern";
            // 
            // nachObenToolStripMenuItem
            // 
            this.nachObenToolStripMenuItem.Name = "nachObenToolStripMenuItem";
            this.nachObenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nachObenToolStripMenuItem.Text = "nach oben";
            this.nachObenToolStripMenuItem.Click += new System.EventHandler(this.nachObenToolStripMenuItem_Click);
            // 
            // nachUntenToolStripMenuItem
            // 
            this.nachUntenToolStripMenuItem.Name = "nachUntenToolStripMenuItem";
            this.nachUntenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.nachUntenToolStripMenuItem.Text = "nach unten";
            this.nachUntenToolStripMenuItem.Click += new System.EventHandler(this.nachUntenToolStripMenuItem_Click);
            // 
            // delete_conMenStr_1
            // 
            this.delete_conMenStr_1.Name = "delete_conMenStr_1";
            this.delete_conMenStr_1.Size = new System.Drawing.Size(173, 22);
            this.delete_conMenStr_1.Text = "Entfernen";
            this.delete_conMenStr_1.Click += new System.EventHandler(this.delete_conMenStr_1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(900, 191);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(392, 12);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(140, 30);
            this.Btn_Add.TabIndex = 5;
            this.Btn_Add.Text = "Fragebogen hinzufügen";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(626, 255);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(140, 30);
            this.Btn_Ok.TabIndex = 7;
            this.Btn_Ok.Text = "Änderungen übernehmen";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(772, 255);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(140, 30);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Änderungen verwerfen";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(924, 297);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.flowLayoutPanel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 336);
            this.Name = "Frm_Test";
            this.Text = "TEST";
            this.Load += new System.EventHandler(this.TEST_Load);
            this.ResizeBegin += new System.EventHandler(this.TEST_ResizeBegin);
            this.Resize += new System.EventHandler(this.TEST_Resize);
            this.conMenStr_1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ContextMenuStrip conMenStr_1;
        private System.Windows.Forms.ToolStripMenuItem delete_conMenStr_1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postionVerändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachObenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nachUntenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pfadändernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigenameToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}