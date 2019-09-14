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
        Button[] buttons;
        DataSet Settings = new DataSet();

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


            //buttons = new Button[] { Btn_1, Btn_2, Btn_3, Btn_4 };
            //tbl_Buttons.Enabled = false;
            Btn_Start.Enabled = false;
            
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
                    if (Themen < 4)
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
                        this.Show();
                        Themen++;
                        if (Themen < 3)
                        {
                            button_pressed = false;
                            Btn_Start.Enabled = false;
                        }
                        else if (Themen == 3)
                        {
                            foreach (Button button in buttons)
                            {
                                if (button.Enabled)
                                {
                                    pressed_Button = button;
                                    button.Focus();
                                    button.BackColor = SystemColors.ControlLight;
                                }
                            }
                        }
                        else if (Themen == 4)
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
                this.Close();
            }
        }

        private void tB_Name_TextChanged(object sender, EventArgs e)
        {
            if(TBx_Name.TextLength > 0)
            {
                //tbl_Buttons.Enabled = true;
            }
            else
            {
                Button_Farbe();
                //tbl_Buttons.Enabled = false;
                Btn_Start.Enabled = false;
            }
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        { 
            Frm_Test sub_frm = new Frm_Test();
            var result = sub_frm.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }

        private void Buttons_hinzu()
        {
            string temp_name;
            string temp_file;
            int anz_buttons;
            Settings.ReadXml(@"Settings.xml");

            anz_buttons = Int32.Parse(Settings.Tables[0].Rows[0][2].ToString());


            if(anz_buttons == 0 && !Admin)
            {
                MessageBox.Show("In der Settings Datei sind keine Fragebögen definiert." + "\n" + "Bitte starten Sie das Programm als Admin neu, um Fragebögen hinzufügen zu können","Fehler: Keine Fragen definiert");
                this.ControlBox = true;
            }
            
            for (int i = 0; i < anz_buttons; i++)
            {
                temp_name = Settings.Tables[0].Rows[i + 1][0].ToString();
                temp_file = Settings.Tables[0].Rows[i + 1][1].ToString();

                Button btn = new Button();
                btn.Text = temp_name;
                btn.Tag = temp_file;
                btn.Size = new Size(100, 100);
                btn.Click += new System.EventHandler(Auswahl_getroffen);

                flowP_1.Controls.Add(btn);
            }


        }
    }
}
