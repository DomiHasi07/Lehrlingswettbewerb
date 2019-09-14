using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Principal;

namespace WindowsFormsApp3

{
    public partial class Main : Form
    {
        
        Font currentFont = new Font(FontFamily.GenericSansSerif, 10);
        int current_Q = 1;
        float Zeit_pro_Frage = 0;
        int[] Zufallsantworten = new int[4];
        DataSet Eingelesene_Fragen = new DataSet();
        Button[] answers;
        Button given_Answer;
        int zus_höhe = 0;

        Random rnd = new Random();

        bool Start_was_pressed = false;
        bool Next_was_pressed = false;
        bool skip_question_mode = false;
        bool Ende = false;

        public static string[][][] Fragenkatalog;
        string[][][] answered_Qestions;
        

        public Main()
        {
            InitializeComponent();
            string temp_path = @"Fragebogen\" + Start_Screen.pressed_Button.Tag.ToString();
            Eingelesene_Fragen.ReadXml(temp_path);

            Fragenkatalog_OV();

            answers = new Button[] { Btn_Answer_1, Btn_Answer_2, Btn_Answer_3, Btn_Answer_4 };

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);


            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                this.ControlBox = false;
            }

        }

        private void Lbl_Question_TextChanged(object sender, EventArgs e)
        {
            string txt = lbl_Question.Text;
            if(txt.Length>0)
            {
                int best_size = 100;
                int lbl_wid = lbl_Question.DisplayRectangle.Width - 3;
                int lbl_hgt = lbl_Question.DisplayRectangle.Height - 3;

                using (Graphics gr = lbl_Question.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(lbl_Question.Font.FontFamily, i))
                        {
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if((text_size.Height>lbl_hgt)||( text_size.Width > lbl_wid))
                            {
                                best_size = i - 1;
                                break;
                            }
                            
                        }
                    }
                    if (best_size < 12)
                    {
                        for (int i = 1; i <= 100; i++)
                        {
                            using (Font test_font = new Font(lbl_Question.Font.FontFamily, i))
                            {
                                SizeF text_size = gr.MeasureString(txt, test_font);
                                if ((text_size.Width/2)>lbl_wid||(text_size.Height > (lbl_hgt / 2)))
                                {
                                    best_size = i - 1;
                                    break;
                                }
                            }
                        }
                    }
                    
                }

                lbl_Question.Font = new Font(lbl_Question.Font.FontFamily, best_size);
            }
        }

        private void Answer_Button_Click(object sender, EventArgs e)
        {
            if (!Next_was_pressed)
            {              
                Hintergrundfarbe();
                if((sender as Button)!=given_Answer)
                {
                    (sender as Button).BackColor = Color.White;
                    given_Answer = (sender as Button);
                    Btn_Next.Text = "Antwort geben";
                }
                else
                {
                    given_Answer = null;
                    Btn_Next.Text = "Frage überspringen";
                }
               
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!Start_was_pressed)
            {
                Start_Sequenz();
                Start_was_pressed = true;
                Btn_Start.Enabled = false;
            }
            else
            {
                Reset();
                Fragenkatalog_OV();
                Start_was_pressed = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(!Ende)
            {
                tmr_Frage.Stop();
                Disable_Ans_Buttons();
                Fragenauswertung();

                current_Q++;

                if (current_Q > Fragenkatalog.Length)
                {
                    skip_mode();
                    if (!Ende)
                        tmr_Frage.Start();
                }
                else
                {
                    Hintergrundfarbe();
                    write_Question();
                    write_Answers();
                    tmr_Frage.Start();
                    Btn_Next.Text = "Frage überspringen";
                }

            }
            else
            {
                int Anzahl_richtiger_Fragen = 0;
                int Anzahl_skipped_Fragen = 0;
                this.Close();
                string temp_path = @"Ergebnisse\"+ DateTime.Today.ToString("ddMMyyyy") + "_" + Start_Screen.txt_Name + "_" + Start_Screen.pressed_Button.Tag.ToString() +  ".Txt";
                if(File.Exists(temp_path))
                {
                    File.SetAttributes(temp_path, FileAttributes.Normal);
                    File.Delete(temp_path);
                }
                using (StreamWriter sw = File.CreateText(temp_path))
                {
                    for(int i = 1;i<Fragenkatalog.Length+1;i++)
                    {
                        if(Fragenkatalog[i-1][2][0]=="right")
                        {
                            sw.WriteLine("Frage " + i + " wurde richtig beantwortet");
                            Anzahl_richtiger_Fragen++;
                        }
                        else if(Fragenkatalog[i-1][2][0]=="skipped")
                        {
                            sw.WriteLine("Frage " + i  + " wurde übersprungen");
                            Anzahl_skipped_Fragen++;
                        }
                        else
                        {
                            sw.WriteLine("Frage " + i + " wurde falsch beantwortet");
                        }
                    }
                    sw.WriteLine("");
                    if(Anzahl_richtiger_Fragen==Fragenkatalog.Length)
                    {
                        sw.WriteLine("Alle Fragen wurden richtig beantwortet");
                    }
                    else if(Anzahl_richtiger_Fragen == 0)
                    {
                        sw.WriteLine("Keine Frage wurde richtig beantwortet");
                    }
                    else
                    {
                        if (Anzahl_richtiger_Fragen == 1)
                            sw.WriteLine(Anzahl_richtiger_Fragen + " von " + Fragenkatalog.Length + " Fragen wurde richtig beantwortet");
                        else
                            sw.WriteLine(Anzahl_richtiger_Fragen + " von " + Fragenkatalog.Length + " Fragen wurden richtig beantwortet");
                        if (Anzahl_skipped_Fragen == 1)
                            sw.WriteLine(Anzahl_skipped_Fragen + " Frage wurde übersprungen");
                        else if (Anzahl_skipped_Fragen > 1)
                            sw.WriteLine(Anzahl_skipped_Fragen + " Fragen wurden übersprungen");
                        else if (Anzahl_skipped_Fragen == 0)
                            sw.WriteLine("Es wurde keine Frage übersprungen");
                    }
                   
                }
                File.SetAttributes(temp_path, File.GetAttributes(temp_path) | FileAttributes.ReadOnly);
            }
            
        }

        void Hintergrundfarbe()
        {
            for (int i = 0; i < 4; i++)
            {
                answers[i].BackColor = Color.Gainsboro;
            }
        }
        
        void write_Question()
        {
            lbl_Aufgaben_Gebiet.Text = Fragenkatalog[current_Q-1][0][0] +" "+ Fragenkatalog[current_Q-1][0][2] + " Frage: " + current_Q + " / " + Fragenkatalog.Length;
            lbl_Question.Text = Fragenkatalog[current_Q-1][0][1];
            if (Fragenkatalog[current_Q - 1][0][3] != "")
            {
                try
                {
                    string temp_path = @"Bilder\" + Fragenkatalog[current_Q-1][0][3];
                    Bitmap temp_file = new Bitmap(temp_path);

                    pBx_1.Visible = true;
                    pBx_1.Enabled = true;

                    if (pBx_1.Image != null)
                    {
                        this.MinimumSize = new Size(746, 318);
                        this.Width = this.Width + (temp_file.Width - pBx_1.Width);
                        this.Height = this.Height - zus_höhe;
                    }
                    else
                    {
                        this.Width = this.Width + temp_file.Width + 6;
                    }
                    if (temp_file.Height > this.Height)
                    {
                        zus_höhe = temp_file.Height - this.Height;
                        this.Height = temp_file.Height;
                        pBx_1.Height = temp_file.Height;
                    }

                    pBx_1.Width = temp_file.Width;
                    pBx_1.Image = temp_file;
                    this.MinimumSize = new Size(this.Width, this.Height);
                }
                catch
                {

                }
            }
            else
            {
                if (pBx_1.Image != null)
                {
                    this.MinimumSize = new Size(746, 318);
                    this.Width = this.Width - pBx_1.Width - 6;
                    this.Height = this.Height - zus_höhe;
                    pBx_1.Visible = false;
                    pBx_1.Enabled = false;
                    pBx_1.Image = null;
                }
            }
            this.CenterToScreen();
        }

        void write_Answers()
        {
            Array.Clear(Zufallsantworten, 0, Zufallsantworten.Length);
            Zufallsantworten = Zufallszahlen_generieren(4);
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
                answers[i].Text = Fragenkatalog[current_Q-1][1][Zufallsantworten[i]];
                answers[i].ForeColor = Color.Black;
            }
        }

        void Disable_and_clear_Ans_Buttons()
        {
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
                answers[i].Text = "";
            }
        }

        void Start_Sequenz()
        {
            write_Question();
            Enable_Ans_Buttons();
            write_Answers();

            Btn_Next.Enabled = true;

            Btn_Next.Text = "Frage überspringen";

            tmr_Frage.Start();
        }

        void Reset()
        {
            lbl_Aufgaben_Gebiet.Text = "";
            lbl_Question.Text = "";
            Btn_Next.Text = "";
            Disable_and_clear_Ans_Buttons();

            Btn_Next.Enabled = false;
            Next_was_pressed = false;
            Ende = false;
            Hintergrundfarbe();
            given_Answer = null;
            current_Q = 1;

            Btn_Start.Text = "Start";

            Zeit_pro_Frage = 0;
        }

        void Disable_Ans_Buttons()
        {
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
            }

        }

        void Enable_Ans_Buttons()
        {
            for (int i = 0; i < 3; i++)
            {
                answers[i].Enabled = true;
                answers[i].ForeColor = Color.Black;
            }
            lbl_Aufgaben_Gebiet.Visible = true;
        }

        bool Fragenauswertung()
        {
            Int32 given_answer_ID;

            if (given_Answer != null)
            {
                given_answer_ID = Int32.Parse(given_Answer.Tag.ToString());
                if (given_answer_ID == Array.IndexOf(Zufallsantworten, 0))
                {
                    Fragenkatalog[current_Q - 1][2][0] = "right";
                }
                else
                {
                    Fragenkatalog[current_Q - 1][2][0] = Zufallsantworten[given_answer_ID].ToString();
                }
            }
            else
            {
                Fragenkatalog[current_Q - 1][2][0] = "skipped";               
            }
            given_Answer = null;

            Fragenkatalog[current_Q - 1][2][1] = (Zeit_pro_Frage / 10).ToString("0.0");
            Zeit_pro_Frage = 0;

            return Fragenkatalog[current_Q - 1][2][0] != "skipped";
        }

        void skip_mode()
        {
            string[][][] skipped_Questions;

            int j = 0;
            int x = 0;
            int y = 0;

            for (int i = 0; i < Fragenkatalog.Length; i++)
            {
                if (Fragenkatalog[i][2][0] != "skipped")
                    j++;
            }

            if (skip_question_mode == false)
            {
                if(j<Fragenkatalog.Length)
                {
                    answered_Qestions = new string[j][][];
                    skipped_Questions = new string[Fragenkatalog.Length - j][][];

                    for (int i = 0; i < Fragenkatalog.Length; i++)
                    {
                        if (Fragenkatalog[i][2][0] != "skipped")
                        {
                            answered_Qestions[x] = Fragenkatalog[i];
                            x++;
                        }
                    }

                    for (int i = 0; i < Fragenkatalog.Length; i++)
                    {
                        if (Fragenkatalog[i][2][0] == "skipped")
                        {
                            skipped_Questions[y] = Fragenkatalog[i];
                            y++;
                        }
                    }

                    skip_question_mode = true;

                    Fragenkatalog = skipped_Questions;
                    Reset();
                    Start_Sequenz();
                }
                else
                {
                    skip_question_mode = false;
                    Ende = true;
                    Btn_Next.Text = "Beenden";
                    this.MinimumSize = new Size(746, 318);
                    this.Width = this.Width - pBx_1.Width - 6;
                    this.Height = this.Height - zus_höhe;
                    this.CenterToScreen();
                    pBx_1.Visible = false;
                    pBx_1.Enabled = false;
                    pBx_1.Image = null;
                }
            }
            else
            {
                string[][][] temp = new string[Fragenkatalog.Length + answered_Qestions.Length][][];

                for (int i = 0; i < answered_Qestions.Length; i++)
                {
                    temp[x] = answered_Qestions[i];
                    x++;
                }

                for (int i = 0; i < Fragenkatalog.Length; i++)
                {
                    temp[x] = Fragenkatalog[i];
                    x++;
                }

                Fragenkatalog = temp;
                skip_question_mode = false;
                Ende = true;
                Btn_Next.Text = "Beenden";
                this.MinimumSize = new Size(746, 318);
                this.Width = this.Width - pBx_1.Width - 6;
                this.Height = this.Height - zus_höhe;
                this.CenterToScreen();
                pBx_1.Visible = false;
                pBx_1.Enabled = false;
                pBx_1.Image = null;
            }
        }

        private void tmr_Frage_Tick(object sender, EventArgs e)
        {
            Zeit_pro_Frage++;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmr_Frage.Stop();
        }

        int[] Zufallszahlen_generieren(int how_many_numbers)
        {
            int[] Zufallszahlen = new int[how_many_numbers];
            List<int> possible = Enumerable.Range(0, how_many_numbers).ToList();
            for (int i = 0; i < how_many_numbers; i++)
            {
                int index = rnd.Next(0, possible.Count);
                Zufallszahlen[i] = (possible[index]);
                possible.RemoveAt(index);
            }
            return Zufallszahlen;
        }

        void Fragenkatalog_OV()
        {
            DataTable dt = new DataTable();
            dt = Eingelesene_Fragen.Tables[0];
            dt.DefaultView.Sort = "Nummer ASC";
            dt = dt.DefaultView.ToTable();


            Fragenkatalog = new string[dt.Rows.Count][][];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Fragenkatalog[i] = new string[3][];
                Fragenkatalog[i][0] = new string[4];
                Fragenkatalog[i][1] = new string[4];
                Fragenkatalog[i][2] = new string[2];

                Fragenkatalog[i][0][0] = dt.Rows[i]["Themengebiet"].ToString();
                Fragenkatalog[i][0][1] = dt.Rows[i]["Frage"].ToString();
                Fragenkatalog[i][0][2] = dt.Rows[i]["Nummer"].ToString();
                Fragenkatalog[i][0][3] = dt.Rows[i]["Bild"].ToString();
                Fragenkatalog[i][1][0] = dt.Rows[i]["RichtigeAntwort"].ToString();
                Fragenkatalog[i][1][1] = dt.Rows[i]["Antwort2"].ToString();
                Fragenkatalog[i][1][2] = dt.Rows[i]["Antwort3"].ToString();
                Fragenkatalog[i][1][3] = dt.Rows[i]["Antwort4"].ToString();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
