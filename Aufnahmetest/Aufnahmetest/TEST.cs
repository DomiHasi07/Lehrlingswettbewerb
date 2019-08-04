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
                    split.BorderStyle = BorderStyle.Fixed3D;
                    split.Dock = System.Windows.Forms.DockStyle.Fill; 
                    split.MaximumSize = new System.Drawing.Size(0, 30); 
                    split.MinimumSize = new System.Drawing.Size(150, 0);

                    panel_1.ColumnCount = 2;
                    panel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                    panel_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    panel_1.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel_1.RowCount = 1;
                    panel_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

                    label_1.AutoSize = true;
                    label_1.Dock = System.Windows.Forms.DockStyle.Fill;
                    label_1.Text = "Anzeigename:";
                    label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    label_2.AutoSize = true;
                    label_2.BackColor = System.Drawing.Color.White;
                    label_2.Dock = System.Windows.Forms.DockStyle.Fill;
                    label_2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
                    label_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    label_2.Text = temp_name;

                    panel_1.Controls.Add(label_1, 0, 0);
                    panel_1.Controls.Add(label_2, 1, 0);

                    panel_2.ColumnCount = 2;
                    panel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
                    panel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    panel_2.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel_2.RowCount = 1;
                    panel_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

                    label_3.AutoSize = true;
                    label_3.Dock = System.Windows.Forms.DockStyle.Fill;
                    label_3.Text = "Dateipfad:";
                    label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    label_4.AutoSize = true;
                    label_4.BackColor = System.Drawing.Color.White;
                    label_4.Dock = System.Windows.Forms.DockStyle.Fill;
                    label_4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
                    label_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    label_4.Text = temp_path;

                    panel_2.Controls.Add(label_3, 0, 0);
                    panel_2.Controls.Add(label_4, 1, 0);

                    split.Panel1.Controls.Add(panel_1);
                    split.Panel2.Controls.Add(panel_2);

                    splitContainers.Add(split);

                    Size Textsize = TextRenderer.MeasureText(temp_name, label_2.Font);
                    split.Panel1MinSize = label_1.Width + 15 + Textsize.Width;

                    flowLayoutPanel2.Controls.Add(split);

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
            flowLayoutPanel2.Controls.Remove(find_owner(sender));
        }

        private Control find_owner (object sender)
        {
            Control source = ((ContextMenuStrip) (sender as ToolStripItem).Owner as ContextMenuStrip).SourceControl;
            return source;
        }

        private void TEST_Resize(object sender, EventArgs e)
        {
            if(splitContainers.Count > 0)
            {
                change_size_split();
                for (int i = 0; i < splitContainers.Count; i++)
                {
                    splitContainers[i].SplitterDistance = cur_SpDist[i];
                }
            }
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
            splitContainers.ForEach(x => x.MinimumSize = new System.Drawing.Size(flowLayoutPanel2.Width - 6, 30));   
        }

        private void change_Name_conMenStr_1_Click(object sender, EventArgs e)
        { 
            SplitContainer split = (SplitContainer)find_owner(sender);
            TableLayoutPanel tbl_lay = (TableLayoutPanel)split.Panel1.Controls[0];
            Label label = (Label)tbl_lay.Controls[1];

            myform temp_Form = new myform();

            temp_Form.Text = "Name ändern";
            temp_Form.Name = "change_Name";

            TableLayoutPanel temp_tbl = new TableLayoutPanel();

            temp_tbl.ColumnCount = 2;
            temp_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            temp_tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            temp_tbl.RowCount = 3;
            temp_tbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));

            temp_tbl.Controls.Add(new Button() { Text = "Übernehmen", Name = "Btn_Ok", Dock = System.Windows.Forms.DockStyle.Fill }, 0, 2);
            temp_tbl.Controls.Add(new Button() { Text = "Abrechen", Name = "Btn_Cancel", Dock = System.Windows.Forms.DockStyle.Fill }, 1, 2);
            temp_tbl.Controls.Add(new TextBox() { Text = label.Text, Name = "tBx_Name", Dock = System.Windows.Forms.DockStyle.Fill }, 0, 1);
            temp_tbl.Controls.Add(new Label() { Text = "neuer Anzeigename", Name = "lbl_Name",
                Dock = System.Windows.Forms.DockStyle.Fill,TextAlign = System.Drawing.ContentAlignment.MiddleCenter }, 0, 0);
            temp_tbl.SetColumnSpan(temp_tbl.Controls[3], 2);
            temp_tbl.SetColumnSpan(temp_tbl.Controls[2], 2);
            temp_tbl.Controls["Btn_Ok"].Click += sub_form_1_Btn_Ok_Click;
            temp_tbl.Controls["Btn_Cancel"].Click += sub_form_1_Btn_Cancel_Click;
            temp_Form.Controls.Add(temp_tbl);

            var result = temp_Form.ShowDialog();
            if(result == DialogResult.OK)
            {
                label.Text = temp_Form.Return_Value1;
                Size Textsize = TextRenderer.MeasureText(label.Text, label.Font);
                split.Panel1MinSize = tbl_lay.Controls[0].Width + 18 + Textsize.Width;
                split.SplitterDistance = split.Panel1MinSize;
            }

        }

        private void sub_form_1_Btn_Ok_Click(object sender, EventArgs e)
        {
            TableLayoutPanel temp = (TableLayoutPanel) (sender as Button).Parent;
            myform sub_form = (myform)temp.Parent;
            sub_form.Return_Value1 = temp.Controls[2].Text;
            sub_form.DialogResult = DialogResult.OK;
            sub_form.Close();
        }

        private void sub_form_1_Btn_Cancel_Click(object sender, EventArgs e)
        {
            TableLayoutPanel temp = (TableLayoutPanel)(sender as Button).Parent;
            myform sub_form = (myform)temp.Parent;
            sub_form.DialogResult = DialogResult.Cancel;
            sub_form.Close();
        }

        private void change_Path_conMenStr_1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(openFileDialog1.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    SplitContainer split = (SplitContainer)find_owner(sender);
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
    }
}
