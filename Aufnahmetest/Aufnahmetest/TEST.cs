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
using System.Xml;
using System.Configuration;

namespace Aufnahmetest
{
    public partial class Frm_Test : Form
    {

        public Frm_Test()
        {
            InitializeComponent();
        }

        public partial class myform : Form
        {
            public string Return_Value1 { get; set; }
        }

        public class Fragebogen
        {
            public String Name { get; set; }
            public String Pfad { get; set; }
            public String Zeit { get; set; }
           
        }


        List<SplitContainer> splitContainers;
        List<Int32> cur_SpDist = new List<int>();
        private Control conMenu_Source;
        public static DataSet Settings = new DataSet();
        List<Fragebogen> changed_Fragebögen = new List<Fragebogen>();
        List<Fragebogen> org_Fragebögen = new List<Fragebogen>();


        private void button1_Click(object sender, EventArgs e)
        {
            string temp_name = "";
            string temp_path = "";
            string temp_zeit = "10";

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(openFileDialog1.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    temp_path = Path.GetFileName(openFileDialog1.FileName);
                    temp_name = Path.GetFileNameWithoutExtension(openFileDialog1.FileName).Replace('_', ' ');

                    Neues_Label_hinzu(temp_name, temp_path,temp_zeit);
                    check_nach_Änderung();
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
            change_size_split();
            check_nach_Änderung();
        }

        private void TEST_Resize(object sender, EventArgs e)
        {
            change_size_split();
            Btn_Ok.Location = new Point(this.Width - 314, this.Height - 81);
            Btn_Cancel.Location = new Point(this.Width - 168, this.Height - 81);
            tbl_1.Location = new Point((this.Width / 2) - (tbl_1.Width / 2), tbl_1.Location.Y);
            try
            {
                if (splitContainers.Count > 0)
                {
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
            string temp_name, temp_path, temp_Zeit;
            int anz_label = 0;

            splitContainers = new List<SplitContainer>();

            
            if(!File.Exists(@"settings.xml"))
            {
                if(MessageBox.Show("Datei Settings konnte nicht gefunden werden. Wollen Sie eine erstellen?", "Settings Datei nicht gefunden", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    using (FileStream filestream = new FileStream("Settings.xml", FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(filestream))
                    using (XmlTextWriter Writer = new XmlTextWriter(sw))
                    {
                        Writer.Formatting = Formatting.Indented;
                        Writer.Indentation = 4;
                        Writer.WriteStartElement("Settings");
                        Writer.WriteStartElement("Daten");
                        Writer.WriteElementString("Anzeige_Name", "");
                        Writer.WriteElementString("Dateipfad", "");
                        Writer.WriteElementString("Zeit", "");
                        Writer.WriteElementString("Anzahl_Fragebögen", "0");
                        Writer.WriteEndElement();
                        Writer.WriteEndElement();
                    }
                    Settings.ReadXml(@"settings.xml");
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                Settings.ReadXml(@"settings.xml");

                anz_label = Int32.Parse(Settings.Tables[0].Rows[0][3].ToString());
                org_Fragebögen.Clear();

                for (int i = 0; i < anz_label; i++)
                {
                    temp_name = Settings.Tables[0].Rows[i + 1][0].ToString();
                    temp_path = Settings.Tables[0].Rows[i + 1][1].ToString();
                    temp_Zeit = Settings.Tables[0].Rows[i + 1][2].ToString();

                    org_Fragebögen.Add(new Fragebogen { Name = temp_name, Pfad = temp_path, Zeit = temp_Zeit });
                    Neues_Label_hinzu(temp_name, temp_path,temp_Zeit);
                }
                check_nach_Änderung();
            }
        }

        private void change_size_split()
        {
            if(flowLayoutPanel2.VerticalScroll.Visible)
            {
                splitContainers.ForEach(x => x.MinimumSize = new Size(flowLayoutPanel2.Width - 30, 30));
                splitContainers.ForEach(x => x.Margin = new Padding(3, 3, 0, 3));
                flowLayoutPanel2.Controls[flowLayoutPanel2.Controls.Count - 1].Margin = new Padding(3, 3, 0, 12);
            }
            else
            {
                splitContainers.ForEach(x => x.MinimumSize = new Size(flowLayoutPanel2.Width - 16, 30));
            }
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
            check_nach_Änderung();
        }

        private void nachObenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.SetChildIndex(conMenu_Source, flowLayoutPanel2.Controls.GetChildIndex(conMenu_Source) - 1);
            check_nach_Änderung();
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
                    label.Text = Path.GetFileName(openFileDialog1.FileName);
                    check_nach_Änderung();
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
                check_nach_Änderung();
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            Settings.Tables[0].Rows[0][3] = changed_Fragebögen.Count;
            for (int i = 0; i < changed_Fragebögen.Count; i++)
            {
                if(i+1 < Settings.Tables[0].Rows.Count)
                {
                    Settings.Tables[0].Rows[i + 1][0] = changed_Fragebögen[i].Name;
                    Settings.Tables[0].Rows[i + 1][1] = changed_Fragebögen[i].Pfad;
                    Settings.Tables[0].Rows[i + 1][2] = changed_Fragebögen[i].Zeit;
                }
                else
                {
                    DataRow rw = Settings.Tables[0].NewRow();
                    rw[0] = changed_Fragebögen[i].Name;
                    rw[1] = changed_Fragebögen[i].Pfad;
                    rw[2] = changed_Fragebögen[i].Zeit;
                    rw[3] = "";

                    Settings.Tables[0].Rows.Add(rw);
                }
            }
            Boolean weiter = false;
            if (Settings.Tables[0].Rows.Count > changed_Fragebögen.Count + 1)
            {
                while (!weiter)
                {
                    Settings.Tables[0].Rows.RemoveAt(Settings.Tables[0].Rows.Count - 1);
                    if (Settings.Tables[0].Rows.Count == changed_Fragebögen.Count + 1)
                        weiter = true;
                }
                
            }
                
            Settings.WriteXml(@"settings.xml");
            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Neues_Label_hinzu(string Name,string Filepath, string Zeit)
        {
            SplitContainer split = new SplitContainer();
            TableLayoutPanel panel_1 = new TableLayoutPanel();
            TableLayoutPanel panel_2 = new TableLayoutPanel();
            Label label_1 = new Label();
            Label label_2 = new Label();
            Label label_3 = new Label();
            Label label_4 = new Label();
            Label label_5 = new Label();
            Label label_6 = new Label();

            split.ContextMenuStrip = conMenStr_1;
            split.BorderStyle = BorderStyle.FixedSingle;
            split.Dock = DockStyle.Fill;
            split.MaximumSize = new Size(0, 30);
            split.MinimumSize = new Size(130, 0);
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
            label_2.Text = Name;

            panel_1.Controls.Add(label_1, 0, 0);
            panel_1.Controls.Add(label_2, 1, 0);

            panel_2.ColumnCount = 4;
            panel_2.ColumnStyles.Add(new ColumnStyle());
            panel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            panel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panel_2.Dock = DockStyle.Fill;
            panel_2.RowCount = 1;
            panel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            label_3.AutoSize = true;
            label_3.Dock = DockStyle.Fill;
            label_3.Text = "Dateiname:";
            label_3.TextAlign = ContentAlignment.MiddleCenter;
            label_3.BackColor = Color.Gainsboro;
            label_3.Margin = new Padding(0, 0, 0, 0);

            label_4.AutoSize = true;
            label_4.BackColor = Color.White;
            label_4.Dock = DockStyle.Fill;
            label_4.Margin = new Padding(3, 0, 0, 0);
            label_4.TextAlign = ContentAlignment.MiddleLeft;
            label_4.Text = Filepath;

            label_5.Size = new Size(20, 20);
            label_5.Dock = DockStyle.Fill;
            label_5.Text = "Zeit:";
            label_5.TextAlign = ContentAlignment.MiddleCenter;
            label_5.BackColor = Color.Gainsboro;
            label_5.Margin = new Padding(0, 0, 0, 0);

            label_6.AutoSize = true;
            label_6.BackColor = Color.White;
            label_6.Dock = DockStyle.Fill;
            label_6.Margin = new Padding(3, 0, 0, 0);
            label_6.TextAlign = ContentAlignment.MiddleLeft;
            label_6.Text = Zeit;

            panel_2.Controls.Add(label_3, 0, 0);
            panel_2.Controls.Add(label_4, 1, 0);
            panel_2.Controls.Add(label_5, 2, 0);
            panel_2.Controls.Add(label_6, 3, 0);

            split.Panel1.Controls.Add(panel_1);
            split.Panel2.Controls.Add(panel_2);

            Size Textsize = TextRenderer.MeasureText(Name, label_2.Font);
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

        private void check_nach_Änderung()
        {
            string temp_name;
            string temp_path;
            string temp_zeit;
            changed_Fragebögen.Clear();
            for(int i = 0;i<flowLayoutPanel2.Controls.Count;i++)
            {
                temp_name = flowLayoutPanel2.Controls[i].Controls[0].Controls[0].Controls[1].Text;
                temp_path = flowLayoutPanel2.Controls[i].Controls[1].Controls[0].Controls[1].Text;
                temp_zeit = flowLayoutPanel2.Controls[i].Controls[1].Controls[0].Controls[3].Text;
                changed_Fragebögen.Add(new Fragebogen { Name = temp_name, Pfad = temp_path,Zeit=temp_zeit } );
            }

            Btn_Ok.Enabled = false;
            if(changed_Fragebögen.Count != org_Fragebögen.Count)
            {
                Btn_Ok.Enabled = true;
                return;
            }
            else
            {
                for(int i = 0;i<org_Fragebögen.Count;i++)
                {
                    if((org_Fragebögen[i].Name != changed_Fragebögen[i].Name)||(org_Fragebögen[i].Pfad != changed_Fragebögen[i].Pfad)|| (org_Fragebögen[i].Zeit != changed_Fragebögen[i].Zeit))
                    {
                        Btn_Ok.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void zeitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitContainer split = (SplitContainer)conMenu_Source;
            TableLayoutPanel tbl_lay = (TableLayoutPanel)split.Panel2.Controls[0];
            Label label = (Label)tbl_lay.Controls[3];

            myform temp_Form = new myform();

            temp_Form.Text = "Zeit ändern";
            temp_Form.Name = "change_Time";
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
                Text = "Zeit",
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
                check_nach_Änderung();
            }
        }

        private void Btn_Schlüssel_Click(object sender, EventArgs e)
        {
            Frm_Einstellung_Schlüssel frm = new Frm_Einstellung_Schlüssel();
            frm.Show();
        }
    }
}
