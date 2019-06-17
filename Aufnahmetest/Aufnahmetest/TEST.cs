using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aufnahmetest
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            /*
            Button button = new Button();
            button.Text = "TEST";
            button.Click += new System.EventHandler(this.Farbe);
            flowLayoutPanel1.Controls.Add(button);
            Label lbl = new Label();
            lbl.Text = "Test" + flowLayoutPanel2.Controls.Count;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.ContextMenuStrip = contextMenuStrip1;
            lbl.Tag = flowLayoutPanel2.Controls.Count;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Margin =  new System.Windows.Forms.Padding(3);
            flowLayoutPanel2.Controls.Add(lbl);
            */
        }

        private void Btn_Remve_Click(object sender, EventArgs e)
        {
            /*
            if (flowLayoutPanel1.Controls.Count > 0)
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            */
        }

        private void Farbe(object sender, EventArgs e)
        {
            /*
            foreach (Button Btn in flowLayoutPanel1.Controls)
            {
                Btn.BackColor = SystemColors.ControlLight;
            }
            (sender as Button).BackColor = Color.White;
            */
        }

        private void change_Path_conMenStr_1_Click(object sender, EventArgs e)
        {
            Control lbl = find_owner(sender);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(openFileDialog1.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    string Name = lbl.Text.Split('|').First().Trim().Replace('_',' ');
                    lbl.Text = Name + " | " + openFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp_name = "";
            string temp_path = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(openFileDialog1.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    temp_path = openFileDialog1.FileName;
                    temp_name = Path.GetFileNameWithoutExtension(temp_path).Replace('_',' ');

                    Label lbl = new Label();
                    lbl.Text = temp_name + " | " + temp_path;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.ContextMenuStrip = conMenStr_1;
                    lbl.Tag = temp_name;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Margin = new System.Windows.Forms.Padding(3);
                    lbl.AutoSize = true;
                    lbl.Dock = DockStyle.Fill;
                    lbl.Font = new Font(lbl.Font.FontFamily, 14);
                    flowLayoutPanel2.Controls.Add(lbl);

                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void change_Name_conMenStr_1_Click(object sender, EventArgs e)
        {
            Control lbl = find_owner(sender);
            string Path = lbl.Text.Split('|').Last().Trim();
            lbl.Text = "Hallo | " + Path;
            lbl.Tag = "Hallo";

        }

        private void delete_conMenStr_1_Click(object sender, EventArgs e)
        {         
            flowLayoutPanel2.Controls.Remove(find_owner(sender));
        }

        private Control find_owner (object sender)
        {
            ContextMenuStrip owner = (sender as ToolStripItem).Owner as ContextMenuStrip;
            Control source = owner.SourceControl;
            return source;
        }
    }
}
