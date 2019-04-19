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

            Eingelesene_Fragen.ReadXml("Test" + Start_Screen.pressed_Button.Tag.ToString() + ".xml");

            Fragenkatalog_OV();

            answers = new Button[] { Btn_Answer_1, Btn_Answer_2, Btn_Answer_3, Btn_Answer_4 };
        }

       /* private void Btn_Answer1_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer1.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer1.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer1.DisplayRectangle.Height - 5;

                using (Graphics gr = Btn_Answer1.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer1.Font.FontFamily, i))
                        {
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Height > lbl_hgt) || (text_size.Width > lbl_wid))
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
                            using (Font test_font = new Font(Btn_Answer1.Font.FontFamily, i))
                            {
                                SizeF text_size = gr.MeasureString(txt, test_font);
                                if ((text_size.Width) > lbl_wid*2 || (text_size.Height > (lbl_hgt / 2.5)))
                                {
                                    best_size = i - 1;
                                    break;
                                }
                            }
                        }
                    }
                   
                }

                Btn_Answer1.Font = new Font(Btn_Answer1.Font.FontFamily, best_size);
            }
        }

        private void Btn_Answer2_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer2.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer2.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer2.DisplayRectangle.Height - 13;

                using (Graphics gr = Btn_Answer2.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer2.Font.FontFamily, i))
                        {
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Height > lbl_hgt) || (text_size.Width > lbl_wid))
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
                            using (Font test_font = new Font(Btn_Answer2.Font.FontFamily, i))
                            {
                                SizeF text_size = gr.MeasureString(txt, test_font);
                                if ((text_size.Width / 2) > lbl_wid || (text_size.Height > (lbl_hgt / 2)))
                                {
                                    best_size = i - 1;
                                    break;
                                }
                            }
                        }
                    }

                }

                Btn_Answer2.Font = new Font(Btn_Answer2.Font.FontFamily, best_size);
            }
        }

        private void Btn_Answer3_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer3.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer3.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer3.DisplayRectangle.Height - 13;

                using (Graphics gr = Btn_Answer3.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer3.Font.FontFamily, i))
                        {
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Height > lbl_hgt) || (text_size.Width > lbl_wid))
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
                            using (Font test_font = new Font(Btn_Answer3.Font.FontFamily, i))
                            {
                                SizeF text_size = gr.MeasureString(txt, test_font);
                                if ((text_size.Width / 2) > lbl_wid || (text_size.Height > (lbl_hgt / 2)))
                                {
                                    best_size = i - 1;
                                    break;
                                }
                            }
                        }
                    }

                }

                Btn_Answer3.Font = new Font(Btn_Answer3.Font.FontFamily, best_size);
            }
        }

        private void Btn_Answer4_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer4.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer4.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer4.DisplayRectangle.Height - 13;

                using (Graphics gr = Btn_Answer4.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer4.Font.FontFamily, i))
                        {
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Height > lbl_hgt) || (text_size.Width > lbl_wid))
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
                            using (Font test_font = new Font(Btn_Answer4.Font.FontFamily, i))
                            {
                                SizeF text_size = gr.MeasureString(txt, test_font);
                                if ((text_size.Width / 2) > lbl_wid || (text_size.Height > (lbl_hgt / 2)))
                                {
                                    best_size = i - 1;
                                    break;
                                }
                            }
                        }
                    }

                }

                Btn_Answer4.Font = new Font(Btn_Answer4.Font.FontFamily, best_size);
            }
        }*/

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
                Hintergrundfarbe("");
                (sender as Button).BackColor = Color.White;

                given_Answer = (sender as Button);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (!Start_was_pressed)
            {
                Start_Sequenz();
                Start_was_pressed = true;
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
                    Hintergrundfarbe("Clear");
                    write_Question();
                    write_Answers();
                    tmr_Frage.Start();
                }

            }
            else
            {
                int Anzahl_richtiger_Fragen = 0;
                int Anzahl_skipped_Fragen = 0;
                this.Close();
                using (StreamWriter sw = File.CreateText("Test.Txt"))
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
            }
            
        }

        void Hintergrundfarbe(string x)
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
            Btn_Start.Text = "Reset";

            tmr_Frage.Start();
        }

        void Reset()
        {
            lbl_Aufgaben_Gebiet.Text = "";
            lbl_Question.Text = "";
            Disable_and_clear_Ans_Buttons();

            Btn_Next.Enabled = false;
            Next_was_pressed = false;
            Ende = false;
            Hintergrundfarbe("Clear");
            given_Answer = null;
            current_Q = 1;

            Btn_Start.Text = "Start";

            Btn_Next.Text = "Next";

            Zeit_pro_Frage = 0;
        }

        void Disable_Ans_Buttons()
        {
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (current_Q > Fragenkatalog.Length || Ende == true)
            {
                skip_mode();
                tmr_Frage.Start();
            }
            else
            {
                Hintergrundfarbe("Clear");
                write_Question();
                write_Answers();
                Next_was_pressed = false;
                tmr_Frage.Start();
            }
        }

        private void Btn_skip_Click(object sender, EventArgs e)
        {

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
                Fragenkatalog[i][0] = new string[3];
                Fragenkatalog[i][1] = new string[4];
                Fragenkatalog[i][2] = new string[2];

                Fragenkatalog[i][0][0] = dt.Rows[i]["Themengebiet"].ToString();
                Fragenkatalog[i][0][1] = dt.Rows[i]["Frage"].ToString();
                Fragenkatalog[i][0][2] = dt.Rows[i]["Nummer"].ToString();
                Fragenkatalog[i][1][0] = dt.Rows[i]["Antwort1"].ToString();
                Fragenkatalog[i][1][1] = dt.Rows[i]["Antwort2"].ToString();
                Fragenkatalog[i][1][2] = dt.Rows[i]["Antwort3"].ToString();
                Fragenkatalog[i][1][3] = dt.Rows[i]["Antwort4"].ToString();
            }
        }

    }
}
