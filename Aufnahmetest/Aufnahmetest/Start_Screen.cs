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
        bool Name_eingeben = false;
       
        DataSet tempDS = new DataSet();
        DataSet Settings = new DataSet();

        List<Auswertung> Auswertung_Fragen = new List<Auswertung>();
        List<Schlüssel> Auflistung_Schlüssel = new List<Schlüssel>();

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MINIMIZE = 0xf120;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_SYSCOMMAND)
            {
                if (m.WParam.ToInt32() == SC_MINIMIZE || m.WParam.ToInt32() == 0xf020)
                {
                    m.Result = IntPtr.Zero;
                    return;
                }


                
                if (m.WParam.ToInt32() == 0xf060 && !finished)
                {
                    m.Result = IntPtr.Zero;
                    return;
                }
                else if(m.WParam.ToInt32() == 0xf060 && finished)
                {
                    Endergebnis();
                }
                
                
            }
            base.WndProc(ref m);
        }

        public class Auswertung
        {
            public int Anzahl_falsche { get; set; }
            public int Anzahl_Fragen { get; set; }
            public int Anzahl_richtige { get; set; }
            public int Anzahl_skipped { get; set; }
            public string Themengebiet { get; set; }
        }

        public class Schlüssel
        {
            public float untere_Begrenzung { get; set; }
            public float ober_Begrenzung { get; set; }
        }

        public Start_Screen()
        {

            InitializeComponent();

            Taskbar.Hide();


            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                this.Size = new Size(718, 306);
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
                        Writer.WriteStartElement("Schlüssel");
                        Writer.WriteElementString("nicht_geeignet","53");
                        Writer.WriteElementString("geeignet", "52&&56");
                        Writer.WriteElementString("durchschnittlich_geeignet", "55&&59");
                        Writer.WriteElementString("gut_geeignet", "58&&65");
                        Writer.WriteElementString("sehr_gut_geeignet","64");
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
            
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
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
                Endergebnis();
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
                    Size = new Size(446, 350),
                    Font = new Font(Font.Name, 20)
                };
                btn.Click += new System.EventHandler(Auswahl_getroffen);
                if (i%2 != 0)
                {
                    flowP_1.SetFlowBreak(btn, true);
                }
                flowP_1.Controls.Add(btn);
            }

            Btn_Start.Font = new Font(Btn_Start.Font.Name, 25);
        }

        private void flowP_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Endergebnis()
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
                float prozent_richtige;
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
                sw.WriteLine(Start_Screen.txt_Name + "\t" + DateTime.Today.ToString("dd.MM.yyyy"));
                sw.WriteLine();

                for (int i = 0; i < Auswertung_Fragen.Count; i++)
                {
                    sw.Write(Auswertung_Fragen[i].Themengebiet);
                    weiter = false;
                    j = 0;
                    while (!weiter)
                    {
                        sw.Write("\t");
                        j++;
                        if (Auswertung_Fragen[i].Themengebiet.Length + j * 8 >= Länge_text)
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
                while (!weiter)
                {
                    sw.Write("-");
                    j++;
                    string temp_str = insgesamt_Fragen + "/" + insgesamt_richtige;
                    if (j >= Länge_text + temp_str.Length)
                        weiter = true;
                }
                sw.WriteLine();
                sw.WriteLine();
                weiter = false;
                j = 0;
                sw.Write("Gesamt");
                while (!weiter)
                {
                    sw.Write("\t");
                    j++;
                    if (6 + j * 8 >= Länge_text)
                        weiter = true;
                }
                sw.Write(insgesamt_richtige + "/" + insgesamt_Fragen);
                sw.WriteLine();
                sw.WriteLine();
                sw.Write("Ergebnis:");
                weiter = false;
                j = 0;
                while(!weiter)
                {
                    sw.Write("\t");
                    j++;
                    if (9 + j * 8 >= Länge_text)
                        weiter = true;
                }
                prozent_richtige = (100/(float)insgesamt_Fragen)*(float)insgesamt_richtige;


                Settings.Clear();
                Settings.ReadXml(@"Settings.xml");

                Auflistung_Schlüssel.Clear();
                for (int i = 0;i<5;i++)
                {
                    string str_temp;
                    string[] arr_temp;
                    float untere;
                    float obere;

                    str_temp = Settings.Tables[1].Rows[0][i].ToString();
                    arr_temp = str_temp.Split('-');
                    untere = float.Parse(arr_temp[0]);
                    obere = float.Parse(arr_temp[1]);

                    Auflistung_Schlüssel.Add(new Schlüssel { untere_Begrenzung = untere, ober_Begrenzung = obere });
                }

                if(prozent_richtige < Auflistung_Schlüssel[0].ober_Begrenzung+1)
                {
                    sw.Write("nicht geeignet");
                }
                else if(prozent_richtige >= Auflistung_Schlüssel[1].untere_Begrenzung  && prozent_richtige <= Auflistung_Schlüssel[1].ober_Begrenzung+1)
                {
                    sw.Write("geeignet");
                }
                else if (prozent_richtige >= Auflistung_Schlüssel[2].untere_Begrenzung && prozent_richtige <= Auflistung_Schlüssel[2].ober_Begrenzung+1)
                {
                    sw.Write("durchschnittlich geeignet");
                }
                else if (prozent_richtige >= Auflistung_Schlüssel[3].untere_Begrenzung && prozent_richtige <= Auflistung_Schlüssel[3].ober_Begrenzung+1)
                {
                    sw.Write("gut geeignet");
                }
                else if (prozent_richtige >= Auflistung_Schlüssel[4].untere_Begrenzung)
                {
                    sw.Write("sehr gut geeignet");
                }
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine(Settings.Tables[1].Rows[0][0].ToString() + "\t nicht geeignet");
                sw.WriteLine(Settings.Tables[1].Rows[0][1].ToString() + "\t geeignet");
                sw.WriteLine(Settings.Tables[1].Rows[0][2].ToString() + "\t durchnschnittlich geeignet");
                sw.WriteLine(Settings.Tables[1].Rows[0][3].ToString() + "\t gut geeignet");
                sw.WriteLine(Settings.Tables[1].Rows[0][4].ToString() + "\t sehr gut geeignet");
            }
            File.SetAttributes(temp_path, File.GetAttributes(temp_path) | FileAttributes.ReadOnly);
            Taskbar.Show();
            this.Close();
        }

        private void Start_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Taskbar.Show();
        }

        private void TBx_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if(!Name_eingeben)
            {
                TBx_Name.Text = "";
                Name_eingeben = true;
            }
            
        }
    }
}
