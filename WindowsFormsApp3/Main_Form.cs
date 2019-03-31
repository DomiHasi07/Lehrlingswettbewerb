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

        Random rnd = new Random();

        bool Start_was_pressed = false;
        bool Next_was_pressed = false;

        public static string[][][] Fragenkatalog;

        public Main()
        {
            InitializeComponent();

            Eingelesene_Fragen.ReadXml(@"C:\Users\DomiHasi\Documents\Arbeit\Visual Studio\XML_Dateien\Test1.xml");

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
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += Test_Resize;
           /* lbl_Question.TextChanged += Lbl_Question_TextChanged;
            Btn_Answer1.TextChanged += Btn_Answer1_TextChanged;
            Btn_Answer2.TextChanged += Btn_Answer2_TextChanged;
            Btn_Answer3.TextChanged += Btn_Answer3_TextChanged;
            Btn_Answer4.TextChanged += Btn_Answer4_TextChanged;*/
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

        private void Test_Resize(object sender, EventArgs e)
        {
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

        private void RichBox_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void RichBox_Enter(object sender, EventArgs e)
        {
            label1.Focus();
            Cursor = Cursors.Arrow;
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
                timer1.Stop();
                Reset();
                Fragenkatalog_OV();
                Start_was_pressed = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Next_was_pressed)   //nächste Frage anzeigen
            {
                timer1.Stop();
                tmr_Frage.Start();

                if (current_Q > Fragenkatalog.Length)
                {
                    Endauswertung_Prozent();
                }
                else
                {
                    Hintergrundfarbe("Clear");
                    write_Question();
                    write_Answers();
                    Next_was_pressed = false;
                }
                
            }
            else            //Einloggen der Antworten
            {
                tmr_Frage.Stop();

                Fragenauswertung();
                Next_was_pressed = true;
                if (current_Q == Fragenkatalog.Length)
                {
                    Next.Text = "Fragen auswerten";
                }
                current_Q++;

                timer1.Interval = 4000;
                timer1.Start();
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
            richAufgaben_Gebiet.Text = Fragenkatalog[Zufallsfragen[current_Q-1]][0][0] +" "+ Fragenkatalog[Zufallsfragen[current_Q-1]][0][2] + " Frage: " + current_Q + " / " + Fragenkatalog.Length;
            lbl_Question.Text = Fragenkatalog[Zufallsfragen[current_Q-1]][0][1];
            right_Answer = Fragenkatalog[Zufallsfragen[current_Q-1]][1][0];
        }

        void write_Answers()
        {

            Array.Clear(Zufallsantworten, 0, Zufallsantworten.Length);
            Zufallsantworten = Zufallszahlen_generieren(4);
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
                answers[i].Text = Fragenkatalog[Zufallsfragen[current_Q-1]][1][Zufallsantworten[i]];
                answers[i].ForeColor = Color.Black;
            }
            
        }

        void Disable_and_delete_Ans_Buttons()
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
            richAufgaben_Gebiet.Text = "";
            lbl_Question.Text = "";
            Disable_and_delete_Ans_Buttons();

            Next.Enabled = false;
            Next_was_pressed = false;
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
            timer1.Stop();
            if (current_Q > Fragenkatalog.Length)
            {
                Endauswertung_Prozent();    
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

        private void lbl_Question_Click(object sender, EventArgs e)
        {
            
        }

        void Fragenauswertung()
        {
            Int32 given_answer_ID;

            if (given_Answer != null && given_Answer != "")
            {
                String[] Temp = given_Answer.Split('_');
                given_answer_ID = Int32.Parse(Temp[2]) - 1;
                if (given_answer_ID == Array.IndexOf(Zufallsantworten, 0))
                {
                    Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] = "11";
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
                Fragenkatalog[Zufallsfragen[current_Q - 1]][2][0] = "4";
                TextBox_Auswertung.BackColor = Color.Red;
            }
            given_Answer = "";

            Fragenkatalog[Zufallsfragen[current_Q - 1]][2][1] = (Zeit_pro_Frage / 10).ToString("0.0");
            Zeit_pro_Frage = 0;

            for (int i = 0; i < 4; i++)
            {
                answers[i].BackColor = Color.IndianRed;
                answers[i].ForeColor = Color.White;
            }
            answers[Array.IndexOf(Zufallsantworten, 0)].BackColor = Color.Green;

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
                            //Auswertung.return_Fragenkatalog = Fragenkatalog;

                            this.Visible = false;
                            Auswertung Auswertung_Dialog = new Auswertung();
                            Auswertung_Dialog.ShowDialog();
                            this.Visible = true;

                            Btn_Fragen_wiederholen.Visible = true;
                            break;

                        case "Beenden":
                            System.Windows.Forms.Application.Exit();
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
                if(Fragenkatalog[i][2][0] != "11")
                {
                    Anzahl_falsche_Fragen++;
                }
            }
            if (Anzahl_falsche_Fragen > 0)
            {
                Fragenkatalog_neu = new string[Anzahl_falsche_Fragen][][];

                for (int i = 0; i < Fragenkatalog.Length; i++)
                {
                    if (Fragenkatalog[i][2][0] != "11")
                    {
                        Fragenkatalog_neu[j] = new string[3][];
                        Fragenkatalog_neu[j][0] = new string[3];
                        Fragenkatalog_neu[j][1] = new string[4];
                        Fragenkatalog_neu[j][2] = new string[2];


                        Fragenkatalog_neu[j][0][0] = Fragenkatalog[i][0][0];
                        Fragenkatalog_neu[j][0][1] = Fragenkatalog[i][0][1];
                        Fragenkatalog_neu[j][0][2] = Fragenkatalog[i][0][2];
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

        private void tmr_Frage_Tick(object sender, EventArgs e)
        {
            Zeit_pro_Frage++;
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
