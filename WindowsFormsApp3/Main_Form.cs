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

namespace WindowsFormsApp3
{
    

    public partial class Main : Form
    {
        Font currentFont = new Font(FontFamily.GenericSansSerif, 10);
        int current_Q = 1;
        float Zeit_pro_Frage = 0;
        int[] Zufallsfragen, falsche_Antworten_Postion;
        int[] Zufallsantworten = new int[4];
        string right_Answer, given_Answer;
        DataSet Eingelesene_Fragen = new DataSet();
        Button[] answers;
        private Bitmap MyImage;

        Random rnd = new Random();

        bool Start_was_pressed = false;
        bool Next_was_pressed = false;
        bool skip_question_mode = false;
        bool Ende = false;

        bool skip_enabled;

        public static string[][][] Fragenkatalog;
        string[][][] answered_Qestions;
        

        public Main()
        {
            InitializeComponent();

            Eingelesene_Fragen.ReadXml(Start_Screen.filepath);
            skip_enabled = Start_Screen.cb1_status;

            Fragenkatalog_OV();

            answers = new Button[] { Btn_Answer_1, Btn_Answer_2, Btn_Answer_3, Btn_Answer_4 };

            int Anzahl_Kat = 0;
            string Kat = "";

            for (int i = 0; i < Fragenkatalog.Length; i++)
            {
                if (Kat != Fragenkatalog[i][0][2].Substring(0, 1))
                {
                    Kat = Fragenkatalog[i][0][2].Substring(0, 1);
                    Anzahl_Kat++;
                }
            }

            
            pBx_1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Btn_Answer1_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer_1.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer_1.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer_1.DisplayRectangle.Height - 5;

                using (Graphics gr = Btn_Answer_1.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer_1.Font.FontFamily, i))
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
                            using (Font test_font = new Font(Btn_Answer_1.Font.FontFamily, i))
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

                Btn_Answer_1.Font = new Font(Btn_Answer_1.Font.FontFamily, best_size);
            }
        }

        private void Btn_Answer2_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer_2.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer_2.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer_2.DisplayRectangle.Height - 13;

                using (Graphics gr = Btn_Answer_2.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer_2.Font.FontFamily, i))
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
                            using (Font test_font = new Font(Btn_Answer_2.Font.FontFamily, i))
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

                Btn_Answer_2.Font = new Font(Btn_Answer_2.Font.FontFamily, best_size);
            }
        }

        private void Btn_Answer3_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer_3.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer_3.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer_3.DisplayRectangle.Height - 13;

                using (Graphics gr = Btn_Answer_3.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer_3.Font.FontFamily, i))
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
                            using (Font test_font = new Font(Btn_Answer_3.Font.FontFamily, i))
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

                Btn_Answer_3.Font = new Font(Btn_Answer_3.Font.FontFamily, best_size);
            }
        }

        private void Btn_Answer4_TextChanged(object sender, EventArgs e)
        {
            string txt = Btn_Answer_4.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;
                int lbl_wid = Btn_Answer_4.DisplayRectangle.Width - 13;
                int lbl_hgt = Btn_Answer_4.DisplayRectangle.Height - 13;

                using (Graphics gr = Btn_Answer_4.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(Btn_Answer_4.Font.FontFamily, i))
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
                            using (Font test_font = new Font(Btn_Answer_4.Font.FontFamily, i))
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

                Btn_Answer_4.Font = new Font(Btn_Answer_4.Font.FontFamily, best_size);
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
                Hintergrundfarbe("");
                (sender as Button).BackColor = Color.White;
                

                given_Answer = (sender as Button).Name;
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
                tmr_Auswertung.Stop();
                Reset();
                Fragenkatalog_OV();
                Start_was_pressed = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Next_was_pressed)   //nächste Frage anzeigen
            {
                tmr_Auswertung.Stop();
                
                if (current_Q > Fragenkatalog.Length || Ende == true)
                {
                    if(skip_enabled)
                    {
                        skip_mode();
                        tmr_Frage.Start();
                    }
                    else
                    {
                        Endauswertung_Prozent();
                    }
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
            else          //Einloggen der Antworten
            {
                tmr_Frage.Stop();
                Disable_Ans_Buttons();
                if (Fragenauswertung())
                {
                    if (current_Q >= Fragenkatalog.Length)
                    {
                        if (skip_enabled)
                        {
                            int j = 0;
                            for (int i = 0; i < Fragenkatalog.Length; i++)
                            {
                                if (Fragenkatalog[i][2][0] == "skipped")
                                    j++;
                            }
                            if (j == 0)
                            {
                                Next.Text = "Fragen auswerten";
                            }
                        }
                        else
                        {
                            Next.Text = "Fragen auswerten";
                        }
                    }
                    Next_was_pressed = true;
                    tmr_Auswertung.Interval = 20000;
                    tmr_Auswertung.Start();
                    current_Q++;
                }
                else
                {
                    current_Q++;
                    tmr_Auswertung.Stop();

                    if (current_Q > Fragenkatalog.Length || Ende == true)
                    {
                        if (skip_enabled)
                        {
                            skip_mode();
                            tmr_Frage.Start();
                        }
                        else
                        {
                            Endauswertung_Prozent();
                        }
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
            }
        }

        void Hintergrundfarbe(string x)
        {
            for (int i = 0; i < 4; i++)
            {
                answers[i].BackColor = Color.Gainsboro;
            }
            if(x == "Clear")
            {
                TextBox_Auswertung.BackColor = Color.White;
            }
        }
        
        void write_Question()
        {
            lbl_Aufgaben_Gebiet.Text = Fragenkatalog[Zufallsfragen[current_Q-1]][0][0] +" "+ Fragenkatalog[Zufallsfragen[current_Q-1]][0][2] + " Frage: " + current_Q + " / " + Fragenkatalog.Length;
            lbl_Question.Text = Fragenkatalog[Zufallsfragen[current_Q-1]][0][1];
            right_Answer = Fragenkatalog[Zufallsfragen[current_Q-1]][1][0];
            if(Fragenkatalog[Zufallsfragen[current_Q-1]][0][3] != "")
            {
                pBx_1.Image = new Bitmap(@"Bilder\" + Fragenkatalog[Zufallsfragen[current_Q - 1]][0][3]);
            }
            else
            {
                pBx_1.Image = null;
                Main.ActiveForm.Width = tbl_1.Width + 40;
            }
        }

        void write_Answers()
        {

            Array.Clear(Zufallsantworten, 0, Zufallsantworten.Length);
            Zufallsantworten = Zufallszahlen_generieren(4);
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
                if (!Fragenkatalog[Zufallsfragen[current_Q - 1]][1][Zufallsantworten[i]].EndsWith(".jpg"))
                {
                    answers[i].Text = Fragenkatalog[Zufallsfragen[current_Q - 1]][1][Zufallsantworten[i]];
                    answers[i].BackgroundImage = null;
                }
                else
                {
                    answers[i].Text = "";
                    answers[i].BackgroundImage = MyImage;
                    
                }
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
            falsche_Antworten_Postion = new int[Fragenkatalog.Length];
            Zufallsfragen = Zufallszahlen_generieren(Fragenkatalog.Length);

            write_Question();
            Enable_Ans_Buttons();
            write_Answers();

            Next.Enabled = true;
            Start.Text = "Reset";

            tmr_Frage.Start();
        }

        void Reset()
        {
            lbl_Aufgaben_Gebiet.Text = "";
            lbl_Question.Text = "";
            Disable_and_clear_Ans_Buttons();

            Next.Enabled = false;
            Next_was_pressed = false;
            Ende = false;
            Hintergrundfarbe("Clear");
            given_Answer = "";
            current_Q = 1;

            Array.Clear(Zufallsfragen, 0, Zufallsfragen.Length);
            Start.Text = "Start";

            TextBox_Auswertung.Text = "";
            Next.Text = "Next";

            Btn_Fragen_wiederholen.Visible = false;
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
            tmr_Auswertung.Stop();
            if (current_Q > Fragenkatalog.Length || Ende == true)
            {
                if (skip_enabled)
                {
                    skip_mode();
                    tmr_Frage.Start();
                }
                else
                {
                    Endauswertung_Prozent();
                }
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

        private void Btn_Fragen_wiederholen_Click(object sender, EventArgs e)
        {
            falsche_Fragen_ueben();
        }

        void Enable_Ans_Buttons()
        {
            for (int i = 0; i < 3; i++)
            {
                answers[i].Enabled = true;
                answers[i].ForeColor = Color.Black;
            }
        }

        bool Fragenauswertung()
        {
            Int32 given_answer_ID;

            if (given_Answer != null && given_Answer != "")
            {
                String[] Temp = given_Answer.Split('_');
                given_answer_ID = Int32.Parse(Temp[2]) - 1;
                if (given_answer_ID == Array.IndexOf(Zufallsantworten, 0))
                {
                    Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] = "right";
                    TextBox_Auswertung.BackColor = Color.Green;
                }
                else
                {
                    Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] = Zufallsantworten[given_answer_ID].ToString();
                    TextBox_Auswertung.BackColor = Color.Red;
                }
            }
            else
            {
                Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] = "skipped";               
                if(!skip_enabled)
                TextBox_Auswertung.BackColor = Color.Red;             
            }
            given_Answer = "";

            Fragenkatalog[Zufallsfragen[current_Q - 1]][2][1] = (Zeit_pro_Frage / 10).ToString("0.0");
            Zeit_pro_Frage = 0;

            if (!(Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] == "skipped" && skip_enabled))
            {
                for (int i = 0; i < 4; i++)
                {
                    answers[i].BackColor = Color.IndianRed;
                    answers[i].ForeColor = Color.White;
                }

                answers[Array.IndexOf(Zufallsantworten, 0)].BackColor = Color.Green;
            }
            
            return !(Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] == "skipped" && skip_enabled);



        }

        void Endauswertung_Prozent()
        {
            using (var form = new Beenden())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.ReturnValue1;

                    switch (val)
                    {
                        case "Auswertung":

                            this.Visible = false;
                            Auswertung Auswertung_Dialog = new Auswertung();
                            Auswertung_Dialog.ShowDialog();
                            this.Visible = true;

                            Btn_Fragen_wiederholen.Visible = true;
                            break;

                        case "Beenden":
                            this.Close();
                            break;

                        case "Restart":
                            Reset();
                            Fragenkatalog_OV();
                            Start_Sequenz();
                            break;
                    }
                }
            }
        }

        void falsche_Fragen_ueben()
        {
            int Anzahl_falsche_Fragen = 0, j = 0;
            string[][][] Fragenkatalog_neu;

            for (int i = 0;i<Fragenkatalog.Length;i++)
            {
                if(Fragenkatalog[i][2][0] != "right")
                {
                    Anzahl_falsche_Fragen++;
                }
            }
            if (Anzahl_falsche_Fragen > 0)
            {
                Fragenkatalog_neu = new string[Anzahl_falsche_Fragen][][];

                for (int i = 0; i < Fragenkatalog.Length; i++)
                {
                    if (Fragenkatalog[i][2][0] != "right")
                    {
                        Fragenkatalog_neu[j] = new string[3][];
                        Fragenkatalog_neu[j][0] = new string[4];
                        Fragenkatalog_neu[j][1] = new string[4];
                        Fragenkatalog_neu[j][2] = new string[2];


                        Fragenkatalog_neu[j][0][0] = Fragenkatalog[i][0][0];
                        Fragenkatalog_neu[j][0][1] = Fragenkatalog[i][0][1];
                        Fragenkatalog_neu[j][0][2] = Fragenkatalog[i][0][2];
                        Fragenkatalog_neu[j][0][3] = Fragenkatalog[i][0][3];
                        Fragenkatalog_neu[j][1][0] = Fragenkatalog[i][1][0];
                        Fragenkatalog_neu[j][1][1] = Fragenkatalog[i][1][1];
                        Fragenkatalog_neu[j][1][2] = Fragenkatalog[i][1][2];
                        Fragenkatalog_neu[j][1][3] = Fragenkatalog[i][1][3];

                        j++;
                    }
                }
                Fragenkatalog = Fragenkatalog_neu;
            }
            else
            {
                MessageBox.Show("Du hast alle Fragen richtig beantwortet. Das Programm wird neugestartet", "Neustart");
                Fragenkatalog_OV();
            }
            Reset();
            Start_Sequenz();
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

            skipped_Questions = new string[Fragenkatalog.Length - j][][];
            for (int i = 0; i < Fragenkatalog.Length; i++)
            {
                if (Fragenkatalog[i][2][0] == "skipped")
                {
                    skipped_Questions[y] = Fragenkatalog[i];
                    y++;
                }
            }

            if (skip_question_mode == false)
            {
                answered_Qestions = new string[j][][];

                for (int i = 0; i < Fragenkatalog.Length; i++)
                {
                    if (Fragenkatalog[i][2][0] != "skipped")
                    {
                        answered_Qestions[x] = Fragenkatalog[i];
                        x++;
                    }
                }
                skip_question_mode = true;
            }
            else
            {
                string[][][] temp = new string[j + answered_Qestions.Length][][];

                for (int i = 0; i < answered_Qestions.Length; i++)
                {
                    temp[x] = answered_Qestions[i];
                    x++;
                }

                for (int i = 0; i < Fragenkatalog.Length; i++)
                {
                    if (Fragenkatalog[i][2][0] != "skipped")
                    {
                        temp[x] = Fragenkatalog[i];
                        x++;
                    }
                }
                answered_Qestions = temp;
            }

            if (skipped_Questions.Length > 0)
            {
                Fragenkatalog = skipped_Questions;
                Reset();
                Start_Sequenz();
            }
            else
            {
                Fragenkatalog = answered_Qestions;
                skip_question_mode = false;
                Ende = true;
                Endauswertung_Prozent();
            }
        }

        private void tmr_Frage_Tick(object sender, EventArgs e)
        {
            Zeit_pro_Frage++;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
           
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
       
    }
}
