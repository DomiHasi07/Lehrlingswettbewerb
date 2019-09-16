using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;
using System.Runtime.InteropServices;
using Aufnahmetest;
using System.Xml;

namespace WindowsFormsApp3
{
    public partial class Start_Screen : Form
    {

        public static Button pressed_Button;
        public static string txt_Name;
        bool button_pressed = false;
        int Themen = 0;
        bool finished = false;
        bool Admin = false;
       
        DataSet tempDS = new DataSet();
        DataSet Settings = new DataSet();

        List<Auswertung> Auswertung_Fragen = new List<Auswertung>();

        public class Auswertung
        {
            public int Anzahl_falsche { get; set; }
            public int Anzahl_Fragen { get; set; }
            public int Anzahl_richtige { get; set; }
            public int Anzahl_skipped { get; set; }
            public string Themengebiet { get; set; }
        }

        public Start_Screen()
        {
            InitializeComponent();

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);


            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                this.ControlBox = false;
                this.Size = new Size(685, 245);
            }
            else
            {
                Btn_Settings.Visible = true;
                Admin = true;
                //Admin
            }


            if (!File.Exists(@"settings.xml"))
            {
                if (MessageBox.Show("Datei Settings konnte nicht gefunden werden. Wollen Sie eine erstellen?" + "\n" + "(ohne Settings Datei kann das Programm nicht gestartet werden)", "Settings Datei nicht gefunden", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

                    Frm_Test sub_frm = new Frm_Test();
                    var result = sub_frm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Buttons_hinzu();
                    }
                    else
                    {
                        MessageBox.Show("Es wurde eine Settings Datei erstellt, sie enthält aber keine Fragebögen. " + "\n" +
                            "Um Fragebögen hinzuzufügen starten Sie das Programm bitte als Administrator neu und drücken Sie dann den Einstellungen Button");
                        this.ControlBox = true;
                    }

                }
                else
                {
                    this.Close();
                    System.Environment.Exit(1);
                    Application.Exit();
                }
            }
            else
            {
                Buttons_hinzu();
            }

            flowP_1.Enabled = false;
            Btn_Start.Enabled = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {
        }

        private void Auswahl_getroffen(object sender, EventArgs e)
        {
            Button_Farbe();
            (sender as Button).BackColor = Color.White;
            pressed_Button = (sender as Button);
            button_pressed = true;
            Btn_Start.Enabled = true;
        }

        private void Button_Farbe()
        {
            foreach (Button button in flowP_1.Controls)
            {
                if(button.BackColor!= SystemColors.ControlDarkDark)
                    button.BackColor = SystemColors.ControlLight;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (!finished)
            {
                if (!button_pressed)
                {
                    return;
                }
                else
                {
                    if (Themen < flowP_1.Controls.Count)
                    {
                        TBx_Name.ReadOnly = true;
                        txt_Name = TBx_Name.Text.Replace(" ","_");
                        pressed_Button.Enabled = false;
                        pressed_Button.BackColor = SystemColors.ControlDarkDark;
                        Main mainForm = new Main();
                        if(!Admin)
                        {
                            mainForm.ControlBox = false;
                        }
                        this.Hide();
                        mainForm.ShowDialog();
                        Auswertung_Fragen.Add(new Auswertung
                        {
                            Anzahl_falsche = mainForm.return_falsche,
                            Anzahl_Fragen = mainForm.return_Anzahl,
                            Anzahl_richtige = mainForm.return_richtige,
                            Anzahl_skipped = mainForm.return_skipped,
                            Themengebiet = pressed_Button.Text
                        });
                        this.Show();
                        Themen++;
                        if (Themen < flowP_1.Controls.Count -1)
                        {
                            button_pressed = false;
                            Btn_Start.Enabled = false;
                        }
                        else if (Themen == flowP_1.Controls.Count -1)
                        {
                            foreach (Button button in flowP_1.Controls)
                            {
                                if (button.Enabled)
                                {
                                    pressed_Button = button;
                                    button.Focus();
                                    button.BackColor = SystemColors.ControlLight;
                                }
                            }
                        }
                        else if (Themen == flowP_1.Controls.Count)
                        {
                            Btn_Start.Text = "Beenden";
                            pressed_Button = null;
                            finished = true;
                        }
                    }
                }
            }
            else
            {
                string temp_path = @"Ergebnisse\" + DateTime.Today.ToString("ddMMyyyy") + "_" + Start_Screen.txt_Name + "_Endergebnis.Txt";
                if (File.Exists(temp_path))
                {
                    File.SetAttributes(temp_path, FileAttributes.Normal);
                    File.Delete(temp_path);
                }
                using (StreamWriter sw = File.CreateText(temp_path))
                {
                    Boolean weiter = false;
                    int j = 0;
                    int insgesamt_richtige = 0;
                    int insgesamt_Fragen = 0;
                    int Länge_text = 0;
                    foreach (var Auswertung in Auswertung_Fragen)
                    {
                        StringBuilder temp_str = new StringBuilder();
                        int nextTabStop;
                        nextTabStop = (Auswertung.Themengebiet.Length + 8) / 8 * 8;
                        if (nextTabStop > Länge_text)
                        {
                            Länge_text = nextTabStop;
                        }
                    }
                    for (int i = 0;i<Auswertung_Fragen.Count;i++)
                    {
                        sw.Write(Auswertung_Fragen[i].Themengebiet);
                        weiter = false;
                        j = 0;
                        while (!weiter)
                        {
                            sw.Write("\t");
                            j++;
                            if (Auswertung_Fragen[i].Themengebiet.Length + j*8 >= Länge_text)
                            {
                                weiter = true;
                            }
                            
                        }
                        sw.Write(Auswertung_Fragen[i].Anzahl_richtige + "/" + Auswertung_Fragen[i].Anzahl_Fragen);
                        sw.WriteLine();
                        sw.WriteLine();
                        insgesamt_Fragen = insgesamt_Fragen + Auswertung_Fragen[i].Anzahl_Fragen;
                        insgesamt_richtige = insgesamt_richtige + Auswertung_Fragen[i].Anzahl_richtige;
                    }
                    weiter = false;
                    j = 0;
                    sw.Write("Gesamt");
                    while (!weiter)
                    {
                        sw.Write("\t");
                        j++;
                        if(6+j*8 >= Länge_text)
                            weiter = true;
                    }
                    sw.Write(insgesamt_richtige + "/" + insgesamt_Fragen);
                    sw.WriteLine();

                    weiter = false;
                    j = 0;
                    while (!weiter)
                    {
                        sw.Write("-");
                        j++;
                        string temp_str = insgesamt_Fragen + "/" + insgesamt_richtige;
                        if (j >= Länge_text + temp_str.Length)
                            weiter = true;
                    }
                }
                File.SetAttributes(temp_path, File.GetAttributes(temp_path) | FileAttributes.ReadOnly);
                this.Close();
            }
        }

        private void tB_Name_TextChanged(object sender, EventArgs e)
        {
            if(TBx_Name.TextLength > 0)
            {
                flowP_1.Enabled = true;
            }
            else
            {
                Button_Farbe();
                flowP_1.Enabled = false;
                Btn_Start.Enabled = false;
            }
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        { 
            Frm_Test sub_frm = new Frm_Test();
            var result = sub_frm.ShowDialog();
            if(result == DialogResult.OK)
            {
                Buttons_hinzu();
            }
        }

        private void Buttons_hinzu()
        {
            string temp_name;
            string temp_file;
            string temp_Zeit;
            int anz_buttons;
            flowP_1.Controls.Clear();
            Settings.Clear();
            Settings.ReadXml(@"Settings.xml");

            anz_buttons = Int32.Parse(Settings.Tables[0].Rows[0][3].ToString());


            if(anz_buttons == 0 && !Admin)
            {
                MessageBox.Show("In der Settings Datei sind keine Fragebögen definiert." + "\n" + "Bitte starten Sie das Programm als Admin neu, um Fragebögen hinzufügen zu können","Fehler: Keine Fragen definiert");
                this.ControlBox = true;
            }
            
            for (int i = 0; i < anz_buttons; i++)
            {
                temp_name = Settings.Tables[0].Rows[i + 1][0].ToString();
                temp_file = Settings.Tables[0].Rows[i + 1][1].ToString();
                temp_Zeit = Settings.Tables[0].Rows[i + 1][2].ToString();

                Button btn = new Button
                {
                    Text = temp_name,
                    Tag = temp_file + "-_-_-" + temp_Zeit,
                    Size = new Size(140, 62)
                };
                btn.Click += new System.EventHandler(Auswahl_getroffen);
                if (i%2 != 0)
                {
                    flowP_1.SetFlowBreak(btn, true);
                }
                

                flowP_1.Controls.Add(btn);
            }



        }

        private void flowP_1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
