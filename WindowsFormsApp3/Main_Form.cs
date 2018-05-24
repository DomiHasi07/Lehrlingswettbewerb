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
    

    public partial class Test : Form
    {
        float Text_Size = 10;
        int maxZeichen = 190;
        string tempQuestion;
        Font currentFont = new Font(FontFamily.GenericSansSerif, 10);
        int Zufallszahl, current_Q = 1;
        int[] Zufallsfragen;
        int[] Zufallsantworten = new int[4];
        string right_Answer, given_Answer;
        int CountOfRightAnswers;

        Random rnd = new Random();

        bool Start_was_pressed = false;
        bool Next_was_pressed = false;

        string[][][] Fragenkatalog =
        {
            new string[][]
            {
                new string[]
                {
                    "Grundlagen EBT A26",
                    "An welchen Eingang muss ein Signal anglegt werde, damit ein RS-Flip-Flop gesetzt wird?",
                },
                new string[]
                {
                    "Set",
                    "Reset",
                    "Ausgang",
                    "Clock"
                }
            },
            new string[][]
            {
                new string[]
                {
                    "Grundlagen EBT A27",
                    "Was kann aus einer Diodenkennlinie entnommen werden?"
                },
                new string[]
                {
                    "Sperrbereich, Durchbruchspannung, Durchlassspannung, Durchlassbereich",
                    "Temperaturkoeffizient, Dotierung, Umgeb    ungstemperatur, Sperrschichttemperatur",
                    "Verlustleistung, maximaler Spitzenstrom, Durchlassstrom, Spitzenspannung",
                    "Diodenkapazität, Schaltzeiten, Sperrstrom, Durchlassspannung"
                }
            },
            new string[][]
            {
                new string[]
                {
                     "Grundlagen EBT A28",
                     "Transistoren können in drei unterschiedlichen Grundschaltungen betrieben werden. Nenn Sie die am häufigsten vewendete Grundschaltung!"
                },
                new string[]
                {
                    "Ermitter-Grund-Schaltung",
                    "Kollektor-Grund-Schaltung",
                    "Basis-Schaltung",
                    "Darlington-Schaltung"
                }
            },
            new string[][]
            {
                new string[]
                {
                     "Elektrische Geräte B1",
                     "Warum ist der Kern bei einem Trafo aus einzenlen Blechen zusammengesetzt"
                },
                new string[]
                {
                    "Damit die Wirbelstromverluste reduziert werden können",
                    "Damit der Kern schwerer wird",
                    "Damit die Spannung höher wird",
                    "Damit der Spannungsabfall reduziert wird"
                }
            },
            new string[][]
            {
                new string[]
                {
                     "Elektrische Geräte B2",
                     "Bei einem Drehstromtransformator befindet sich auf jedem der drei Kernschenkel je eine Ober- und eine Unterspannungswicklung. Wie können die Wicklungen geschaltet werden?"
                },
                new string[]
                {
                    "Ober- und Unterspannungswicklung jeder Phase sind durch Isolationsmaterial auf einem Schenkel voneinander getrennt.",
                    "Ober- und Unterspannungswicklung jeder Phase sind jeweils antiparallel voneinander geschaltet.",
                    "Ober- und Unterspannungswicklung jeder Phase sind parallel auf dem Joch geschalten.",
                    "Ober- und Unterspannungswicklung jeder Phase sind durch Isolationsmaterial in Serie geschalten."
                }
            }
        };
        public Test()
        {
            InitializeComponent();
            Auswahl_Text_Größe.Text = Text_Size.ToString();
        }

        private void Answer_Button_Click(object sender, EventArgs e)
        {
            switch ((sender as RichTextBox).Name)
            {
                case "richAnswer1":
                    Hintergrundfarbe("Antwort1");
                    given_Answer = richAnswer1.Text;
                    break;

                case "richAnswer2":
                    Hintergrundfarbe("Antwort2");
                    given_Answer = richAnswer2.Text;
                    break;

                case "richAnswer3":
                    Hintergrundfarbe("Antwort3");
                    given_Answer = richAnswer3.Text;
                    break;

                case "richAnswer4":
                    Hintergrundfarbe("Antwort4");
                    given_Answer = richAnswer4.Text;
                    break;

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richAnswer1.Click += Answer_Button_Click;
            richAnswer2.Click += Answer_Button_Click;
            richAnswer3.Click += Answer_Button_Click;
            richAnswer4.Click += Answer_Button_Click;

            richAnswer1.SelectionAlignment = HorizontalAlignment.Center;
            richAnswer2.SelectionAlignment = HorizontalAlignment.Center;
            richAnswer3.SelectionAlignment = HorizontalAlignment.Center;
            richAnswer4.SelectionAlignment = HorizontalAlignment.Center;
            richQuestion.SelectionAlignment = HorizontalAlignment.Center;
            richAufgaben_Gebiet.SelectionAlignment = HorizontalAlignment.Center;
           
            richAnswer1.Enter += RichBox_Enter;
            richAnswer2.Enter += RichBox_Enter;
            richAnswer3.Enter += RichBox_Enter;
            richAnswer4.Enter += RichBox_Enter;
            richAufgaben_Gebiet.Enter += RichBox_Enter;
            richQuestion.Enter += RichBox_Enter;

            richAnswer1.Leave += RichBox_Leave;
            richAnswer2.Leave += RichBox_Leave;
            richAnswer3.Leave += RichBox_Leave;
            richAnswer4.Leave += RichBox_Leave;
            richAufgaben_Gebiet.Leave += RichBox_Leave;
            richQuestion.Leave += RichBox_Leave;

            richAnswer1.MouseEnter += Answer_Button_MouseEnter;
            richAnswer2.MouseEnter += Answer_Button_MouseEnter;
            richAnswer3.MouseEnter += Answer_Button_MouseEnter;
            richAnswer4.MouseEnter += Answer_Button_MouseEnter;

            richAnswer4.MouseLeave += Answer_Button_MouseLeave;
            richAnswer1.MouseLeave += Answer_Button_MouseLeave;
            richAnswer2.MouseLeave += Answer_Button_MouseLeave;
            richAnswer3.MouseLeave += Answer_Button_MouseLeave;
        }

        private void Answer_Button_MouseLeave(object sender, EventArgs e)
        {
            switch ((sender as RichTextBox).Name)
            {
                case "richAnswer1":
                    if (richAnswer1.BackColor != Color.White)
                        richAnswer1.BackColor = Color.Gainsboro;
                    break;

                case "richAnswer2":
                    if (richAnswer2.BackColor != Color.White)
                        richAnswer2.BackColor = Color.Gainsboro;
                    break;

                case "richAnswer3":
                    if (richAnswer3.BackColor != Color.White)
                        richAnswer3.BackColor = Color.Gainsboro;
                    break;

                case "richAnswer4":
                    if (richAnswer4.BackColor != Color.White)
                        richAnswer4.BackColor = Color.Gainsboro;
                    break;
            }
            
           
        }

        private void Answer_Button_MouseEnter(object sender, EventArgs e)
        {
            switch ((sender as RichTextBox).Name)
            {
                case "richAnswer1":
                    if (richAnswer1.BackColor != Color.White)
                        richAnswer1.BackColor = SystemColors.GradientInactiveCaption;
                    break;

                case "richAnswer2":
                    if (richAnswer2.BackColor != Color.White)
                        richAnswer2.BackColor = SystemColors.GradientInactiveCaption;
                    break;

                case "richAnswer3":
                    if (richAnswer3.BackColor != Color.White)
                        richAnswer3.BackColor = SystemColors.GradientInactiveCaption;
                    break;

                case "richAnswer4":
                    if (richAnswer4.BackColor != Color.White)
                        richAnswer4.BackColor = SystemColors.GradientInactiveCaption;
                    break;
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

        private void Btn_Text_smaller_click(object sender, EventArgs e)
        {
            if (Text_Size > 5)
            {
                try
                {
                    Text_Size -= 1;
                    change_FontSize();
                }
                catch
                {

                }
            }
        }

        private void Btn_Text_bigger_click(object sender, EventArgs e)
        {
            if (Text_Size < 20)
            {
                try
                {
                    Text_Size += 1;
                    change_FontSize();
                }
                catch
                {

                }
            }
        }

        private void Auswahl_Text_Größe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Text_Size = float.Parse(Auswahl_Text_Größe.Text);
                change_FontSize();
            }
            catch
            {

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
                Start_was_pressed = false;
                Next.Text = "Next";
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Next_was_pressed)   //nächste Frage anzeigen
            {
                if (current_Q > Fragenkatalog.Length)
                    Endauswertung();
                else
                {
                    Hintergrundfarbe("Clear");
                    Enable_Ans_Buttons();
                    write_Question();
                    write_Answers();
                    Next_was_pressed = false;
                }
            }
            else            //Einloggen der Antworten
            {
                Fragenauswertung();
                Disable_Ans_Buttons();
                Next_was_pressed = true;
                if (current_Q == Fragenkatalog.Length)
                {
                    Next.Text = "Fragen auswerten";
                }
                current_Q++;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        void Hintergrundfarbe(string x)
        {
            switch (x)
            {
                case "Antwort1":
                    richAnswer1.BackColor = Color.White;
                    richAnswer2.BackColor = Color.Gainsboro;
                    richAnswer3.BackColor = Color.Gainsboro;
                    richAnswer4.BackColor = Color.Gainsboro;
                    break;

                case "Antwort2":
                    richAnswer1.BackColor = Color.Gainsboro;
                    richAnswer2.BackColor = Color.White;
                    richAnswer3.BackColor = Color.Gainsboro;
                    richAnswer4.BackColor = Color.Gainsboro;
                    break;

                case "Antwort3":
                    richAnswer1.BackColor = Color.Gainsboro;
                    richAnswer2.BackColor = Color.Gainsboro;
                    richAnswer3.BackColor = Color.White;
                    richAnswer4.BackColor = Color.Gainsboro;
                    break;

                case "Antwort4":
                    richAnswer1.BackColor = Color.Gainsboro;
                    richAnswer2.BackColor = Color.Gainsboro;
                    richAnswer3.BackColor = Color.Gainsboro;
                    richAnswer4.BackColor = Color.White;
                    break;

                case "Clear":
                    richAnswer1.BackColor = Color.Gainsboro;
                    richAnswer2.BackColor = Color.Gainsboro;
                    richAnswer3.BackColor = Color.Gainsboro;
                    richAnswer4.BackColor = Color.Gainsboro;
                    TextBox_Auswertung.BackColor = Color.White;
                    break;

                case "Startfarbe":
                    richAnswer1.BackColor = Color.Gainsboro;
                    richAnswer2.BackColor = Color.Gainsboro;
                    richAnswer3.BackColor = Color.Gainsboro;
                    richAnswer4.BackColor = Color.Gainsboro;
                    break;

            }
        }
        
        void Textkürzen(string str)
        {
           
            SizeF size = TextRenderer.MeasureText(str, new Font("Microsoft Sans Serif", Text_Size));
            //nt stringBreite = Int32.Parse(size.ToString());
            //retString = str.Substring(0, 190);
            //MessageBox.Show(size.ToString());
        }

        void write_Question()
        {
            richAufgaben_Gebiet.Text = Fragenkatalog[Zufallsfragen[current_Q-1]][0][0] + " Frage: " + current_Q + " / " + Fragenkatalog.Length;
            richQuestion.Text = Fragenkatalog[Zufallsfragen[current_Q-1]][0][1];
            right_Answer = Fragenkatalog[Zufallsfragen[current_Q-1]][1][0];
        }

        void write_Answers()
        {
            for (int i = 0; i < 4; i++)
            {
                Zufallszahl = rnd.Next(1, 5);
                if (!Zufallsantworten.Contains(Zufallszahl))
                    Zufallsantworten[i] = Zufallszahl;
                else
                    i--;
            }

            var answers = new[] { richAnswer1, richAnswer2, richAnswer3, richAnswer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
                answers[i].Text = Fragenkatalog[Zufallsfragen[current_Q-1]][1][Zufallsantworten[i] - 1];
            }
            Array.Clear(Zufallsantworten, 0, Zufallsantworten.Length);
            
        }

        void change_FontSize()
        {
            Auswahl_Text_Größe.Text = Text_Size.ToString();
            currentFont = new Font(Font.FontFamily, Text_Size);
            
            richAnswer1.Font = currentFont;
            richAnswer2.Font = currentFont;
            richAnswer3.Font = currentFont;
            richAnswer4.Font = currentFont;
            richQuestion.Font = currentFont;
            richAufgaben_Gebiet.Font = currentFont;
        }

        void Disable_and_delete_Ans_Buttons()
        {
            var answers = new[] { richAnswer1, richAnswer2, richAnswer3, richAnswer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
                answers[i].Text = "";
            }
        }

        void Start_Sequenz()
        {
            Zufallsfragen = new int[Fragenkatalog.Length];

            for (int i = 0; i < Fragenkatalog.Length; i++)
            {
                Zufallszahl = rnd.Next(1, Fragenkatalog.Length + 1);
                if (!Zufallsfragen.Contains(Zufallszahl))
                    Zufallsfragen[i] = Zufallszahl;
                else
                    i--;
            }
            for (int i = 0; i < Zufallsfragen.Length; i++)
            {
                Zufallsfragen[i] = Zufallsfragen[i] - 1;
            }
           

            write_Question();
            Enable_Ans_Buttons();
            write_Answers();

            Next.Enabled = true;
            Start.Text = "Reset";

        }

        void Reset()
        {
            richAufgaben_Gebiet.Text = "";
            richQuestion.Text = "";
            Disable_and_delete_Ans_Buttons();

            Next.Enabled = false;
            Next_was_pressed = false;
            Hintergrundfarbe("Clear");
            given_Answer = "";
            current_Q = 1;

            Array.Clear(Zufallsfragen, 0, Zufallsfragen.Length);
            Start.Text = "Start";

            CountOfRightAnswers = 0;
            TextBox_Auswertung.Text = "";

        }

        private void richAnswer1_TextChanged(object sender, EventArgs e)
        {
        }

        void Disable_Ans_Buttons()
        {
            var answers = new[] { richAnswer1, richAnswer2, richAnswer3, richAnswer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
            }

        }

        void Enable_Ans_Buttons()
        {
            var answers = new[] { richAnswer1, richAnswer2, richAnswer3, richAnswer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
            }
        }

        void Fragenauswertung()
        {
            if (given_Answer == right_Answer)
            {
                TextBox_Auswertung.BackColor = Color.Green;
                CountOfRightAnswers++;
            }
            else
            {
                TextBox_Auswertung.BackColor = Color.Red;
            }
        }

        void Endauswertung()
        {
            using (var form = new Beenden())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string val = form.ReturnValue1;

                    if (val=="Auswertung")
                    {

                        Auswertung.return_richtige_Antworten = CountOfRightAnswers;
                        Auswertung.return_Anzahl_Fragen = current_Q-1;

                        this.Visible = false;
                        Auswertung Auswertung_Dialog = new Auswertung();
                        Auswertung_Dialog.ShowDialog();
                        this.Visible = true;
                    }
                    else if(val == "Beenden")
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    
                }
            }
        }

        
    }

}
