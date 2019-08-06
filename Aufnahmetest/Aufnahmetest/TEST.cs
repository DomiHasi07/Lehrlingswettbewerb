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
using System.Security.Principal;

namespace Aufnahmetest
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        public partial class myform : Form
        {
            public string Return_Value1 { get; set; }
        }

        List<SplitContainer> splitContainers;
        List<Int32> cur_SpDist = new List<int>();
        private Control conMenu_Source;

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
            lbl.Margin =  new Padding(3);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string temp_name = "";
            string temp_path = "";

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(openFileDialog1.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    temp_path = openFileDialog1.FileName;
                    temp_name = Path.GetFileNameWithoutExtension(temp_path).Replace('_',' ');

                    SplitContainer split = new SplitContainer();
                    TableLayoutPanel panel_1 = new TableLayoutPanel();
                    TableLayoutPanel panel_2 = new TableLayoutPanel();
                    Label label_1 = new Label();
                    Label label_2 = new Label();
                    Label label_3 = new Label();
                    Label label_4 = new Label();

                    split.ContextMenuStrip = conMenStr_1;
                    split.BorderStyle = BorderStyle.FixedSingle;
                    split.Dock = DockStyle.Fill; 
                    split.MaximumSize = new Size(0, 30); 
                    split.MinimumSize = new Size(150, 0);
                    split.BackColor = Color.Gainsboro;
                    split.IsSplitterFixed = true;

                    panel_1.ColumnCount = 2;
                    panel_1.ColumnStyles.Add(new ColumnStyle());
                    panel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    panel_1.Dock = DockStyle.Fill;
                    panel_1.RowCount = 1;
                    panel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                    label_1.AutoSize = true;
                    label_1.Dock = DockStyle.Fill;
                    label_1.Text = "Anzeigename:";
                    label_1.TextAlign = ContentAlignment.MiddleCenter;
                    label_1.BackColor = Color.Gainsboro;
                    label_1.Margin = new Padding(0, 0, 0, 0);

                    label_2.AutoSize = true;
                    label_2.BackColor = Color.White;
                    label_2.Dock = DockStyle.Fill;
                    label_2.Margin = new Padding(3, 0, 0, 0);
                    label_2.TextAlign = ContentAlignment.MiddleLeft;
                    label_2.Text = temp_name;

                    panel_1.Controls.Add(label_1, 0, 0);
                    panel_1.Controls.Add(label_2, 1, 0);

                    panel_2.ColumnCount = 2;
                    panel_2.ColumnStyles.Add(new ColumnStyle());
                    panel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    panel_2.Dock = DockStyle.Fill;
                    panel_2.RowCount = 1;
                    panel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

                    label_3.AutoSize = true;
                    label_3.Dock = DockStyle.Fill;
                    label_3.Text = "Dateipfad:";
                    label_3.TextAlign = ContentAlignment.MiddleCenter;
                    label_3.BackColor = Color.Gainsboro;
                    label_3.Margin = new Padding(0, 0, 0, 0);

                    label_4.AutoSize = true;
                    label_4.BackColor = Color.White;
                    label_4.Dock = DockStyle.Fill;
                    label_4.Margin = new Padding(3, 0, 0, 0);
                    label_4.TextAlign = ContentAlignment.MiddleLeft;
                    label_4.Text = temp_path;

                    panel_2.Controls.Add(label_3, 0, 0);
                    panel_2.Controls.Add(label_4, 1, 0);

                    split.Panel1.Controls.Add(panel_1);
                    split.Panel2.Controls.Add(panel_2);

                    Size Textsize = TextRenderer.MeasureText(temp_name, label_2.Font);
                    split.Panel1MinSize = label_1.Width + 6 + Textsize.Width;

                    flowLayoutPanel2.Controls.Add(split);

                    splitContainers.Clear();
                    for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++)
                    {
                        splitContainers.Add((SplitContainer)flowLayoutPanel2.Controls[i]);
                    }

                    change_size_split();

                    splitContainers[splitContainers.Count - 1].SplitterDistance = splitContainers[splitContainers.Count - 1].Panel1MinSize;

                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void delete_conMenStr_1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Remove(conMenStr_1.SourceControl);
            splitContainers.Clear();
            if(flowLayoutPanel2.Controls.Count != 0)
            {
                for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++)
                {
                    splitContainers.Add((SplitContainer)flowLayoutPanel2.Controls[i]);
                }
            }
        }

        private void TEST_Resize(object sender, EventArgs e)
        {
            try
            {
                if (splitContainers.Count > 0)
                {
                    change_size_split();
                    for (int i = 0; i < splitContainers.Count; i++)
                    {
                        splitContainers[i].SplitterDistance = cur_SpDist[i];
                    }
                }
            }
            catch { }
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            splitContainers = new List<SplitContainer>();
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                textBox1.Text = "kein Admin";
            }
            else
            {
                textBox1.Text = "Admin";
            }
        }

        private void change_size_split()
        {
            splitContainers.ForEach(x => x.MinimumSize = new Size(flowLayoutPanel2.Width - 6, 30));   
        }

        private void Sub_Form_1_KeyDown(object sender, KeyEventArgs e)
        {
            TableLayoutPanel temp = (TableLayoutPanel)(sender as TextBox).Parent;
            myform sub_form = (myform)temp.Parent;
            if (e.KeyCode == Keys.Enter)
            {
                sub_form.Return_Value1 = temp.Controls[2].Text;
                sub_form.DialogResult = DialogResult.OK;
                sub_form.Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                sub_form.DialogResult = DialogResult.Cancel;
                sub_form.Close();
            }
        }

        private void Sub_Form_1_Load(object sender, EventArgs e)
        {
            myform sub_form = (myform)sender;
            sub_form.SetDesktopLocation(Cursor.Position.X - 421/2, Cursor.Position.Y-132/2);
            sub_form.Controls["Tbl_1"].Controls["tBx_Name"].Select();
        }

        private void sub_form_1_Btn_Ok_Click(object sender, EventArgs e)
        {
            TableLayoutPanel temp = (TableLayoutPanel) (sender as Button).Parent;
            myform sub_form = (myform)temp.Parent;
            sub_form.Return_Value1 = temp.Controls[2].Text.Trim();
            sub_form.DialogResult = DialogResult.OK;
            sub_form.Close();
        }

        private void sub_form_1_Btn_Cancel_Click(object sender, EventArgs e)
        {
            myform sub_form = (myform)((TableLayoutPanel)(sender as Button).Parent).Parent;
            sub_form.DialogResult = DialogResult.Cancel;
            sub_form.Close();
        }

        private void TEST_ResizeBegin(object sender, EventArgs e)
        {
            if(splitContainers.Count >0 )
            {
                if (cur_SpDist.Count > 0)
                    cur_SpDist.Clear();

                for (int i = 0; i < splitContainers.Count; i++)
                {
                    cur_SpDist.Add(splitContainers[i].SplitterDistance);
                }
            }
        }

        private void nachUntenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.SetChildIndex(conMenu_Source, flowLayoutPanel2.Controls.GetChildIndex(conMenu_Source)+1);
        }

        private void nachObenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.SetChildIndex(conMenu_Source, flowLayoutPanel2.Controls.GetChildIndex(conMenu_Source) - 1);
        }

        private void conMenStr_1_Opening(object sender, CancelEventArgs e)
        {
            ((ContextMenuStrip)sender).Items[1].Enabled = true;
            ((ToolStripMenuItem)((ContextMenuStrip)sender).Items[1]).DropDown.Items[0].Enabled = true;
            ((ToolStripMenuItem)((ContextMenuStrip)sender).Items[1]).DropDown.Items[1].Enabled = true;

            conMenu_Source = ((ContextMenuStrip)sender).SourceControl;
            if(flowLayoutPanel2.Controls.Count==1)
            {
               ((ContextMenuStrip)sender).Items[1].Enabled = false;
            }
            else if(flowLayoutPanel2.Controls.GetChildIndex(conMenu_Source)==0)
            {
                ((ToolStripMenuItem)((ContextMenuStrip)sender).Items[1]).DropDown.Items[0].Enabled = false;
            }
            else if (flowLayoutPanel2.Controls.GetChildIndex(conMenu_Source) == flowLayoutPanel2.Controls.Count -1)
            {
                ((ToolStripMenuItem)((ContextMenuStrip)sender).Items[1]).DropDown.Items[1].Enabled = false;
            }


        }

        private void change_Path_conMenStr_1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(openFileDialog1.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    SplitContainer split = (SplitContainer)conMenu_Source;
                    TableLayoutPanel tbl_lay = (TableLayoutPanel)split.Panel2.Controls[0];
                    Label label = (Label)tbl_lay.Controls[1];
                    label.Text = openFileDialog1.FileName;

                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void change_Name_conMenStr_1_Click(object sender, EventArgs e)
        {
            SplitContainer split = (SplitContainer)conMenu_Source;
            TableLayoutPanel tbl_lay = (TableLayoutPanel)split.Panel1.Controls[0];
            Label label = (Label)tbl_lay.Controls[1];

            myform temp_Form = new myform();

            temp_Form.Text = "Name ändern";
            temp_Form.Name = "change_Name";
            temp_Form.Size = new Size(421, 132);
            temp_Form.Load += Sub_Form_1_Load;

            temp_Form.FormBorderStyle = FormBorderStyle.FixedSingle;

            TableLayoutPanel temp_tbl = new TableLayoutPanel();

            temp_tbl.Location = new Point(3, 0);
            temp_tbl.Size = new Size(400, 90);
            temp_tbl.ColumnCount = 2;
            temp_tbl.Name = "Tbl_1";
            temp_tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            temp_tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            temp_tbl.RowCount = 3;
            temp_tbl.RowStyles.Add(new RowStyle(SizeType.AutoSize, 40F));
            temp_tbl.RowStyles.Add(new RowStyle(SizeType.AutoSize, 40F));
            temp_tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));

            temp_tbl.Controls.Add(new Button() { Text = "Übernehmen", Name = "Btn_Ok", Dock = DockStyle.Fill, Size = new Size(50, 20) }, 0, 2);
            temp_tbl.Controls.Add(new Button() { Text = "Abrechen", Name = "Btn_Cancel", Dock = DockStyle.Fill, Size = new Size(50, 20) }, 1, 2);
            temp_tbl.Controls.Add(new TextBox() { Text = label.Text, Name = "tBx_Name", Dock = DockStyle.Fill }, 0, 1);
            temp_tbl.Controls.Add(new Label()
            {
                Text = "Anzeigename",
                Name = "lbl_Name",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            }, 0, 0);
            temp_tbl.Controls["lbl_Name"].Margin = new Padding(3, 3, 3, 0);
            temp_tbl.Controls["tBx_Name"].Margin = new Padding(3, 0, 3, 3);
            temp_tbl.Controls["Btn_Ok"].Click += sub_form_1_Btn_Ok_Click;
            temp_tbl.Controls["Btn_Cancel"].Click += sub_form_1_Btn_Cancel_Click;

            temp_tbl.SetColumnSpan(temp_tbl.Controls[3], 2);
            temp_tbl.SetColumnSpan(temp_tbl.Controls[2], 2);

            temp_tbl.Controls["tBx_Name"].KeyDown += Sub_Form_1_KeyDown;

            temp_Form.Controls.Add(temp_tbl);

            var result = temp_Form.ShowDialog();
            if (result == DialogResult.OK)
            {
                label.Text = temp_Form.Return_Value1;
                Size Textsize = TextRenderer.MeasureText(label.Text, label.Font);
                split.Panel1MinSize = tbl_lay.Controls[0].Width + 6 + Textsize.Width;
                split.SplitterDistance = split.Panel1MinSize;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
