using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float Text_Size = 10;
        Font currentFont = new Font(FontFamily.GenericSansSerif, 10);
        int Zufallszahl, current_Q = 1;
        int[] Zufallsfragen = new int[4];
        string right_Answer, given_Answer;
       
        Random rnd = new Random();

        bool Start_was_pressed = false;
        bool Next_was_pressed = false;

        string[][] Fragenkatalog =
        {
            new string[]
            {
                "Grundlagen EBT A26",
                "An welchen Eingang muss ein Signal anglegt werde, damit ein RS-Flip-Flop gesetzt wird?",
                "Set",
                "Reset",
                "Ausgang",
                "Clock"
            },

            new string[]
            {
                "Grundlagen EBT A27",
                "Was kann aus einer Diodenkennlinie entnommen werden?",
                "Sperrbereich, Durchbruchspannung, Durchlassspannung, Durchlassbereich",
                "Temperaturkoeffizient, Dotierung, Umgebungstemperatur, Sperrschichttemperatur",
                "Verlustleistung, maximaler Spitzenstrom, Durchlassstrom, Spitzenspannung",
                "Diodenkapazität, Schaltzeiten, Sperrstrom, Durchlassspannung"
            },
            
            new string[]
            {
                "Grundlagen EBT A28",
                "Transistoren können in drei unterschiedlichen Grundschaltungen betrieben werden. Nenn Sie die am häufigsten vewendete Grundschaltung!",
                "Ermitter-Grund-Schaltung",
                "Kollektor-Grund-Schaltung",
                "Basis-Schaltung",
                "Darlington-Schaltung"
            },
            new string[]
            {
                "Elektrische Geräte B1",
                "Warum ist der Kern bei einem Trafo aus einzenlen Blechen zusammengesetzt",
                "Damit die Wirbelstromverluste reduziert werden können",
                "Damit der Kern schwerer wird",
                "Damit die Soannung höher wird",
                "Damit der Spannungsabfall reduziert wird"
            }
        };
       
        public Form1()
        {
            InitializeComponent();
            Auswahl_Text_Größe.Text = Text_Size.ToString();
          
        }
        void write_Question()
        {
            Aufgaben_Gebiet.Text = Fragenkatalog[Zufallsfragen[current_Q] - 1][0];
            Question.Text = Fragenkatalog[Zufallsfragen[current_Q] - 1][1];
            right_Answer = Fragenkatalog[Zufallsfragen[current_Q] - 1][2];

            var answers = new[] { Btn_Answer1, Btn_Answer2, Btn_Answer3, Btn_Answer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
                answers[i].Text = Fragenkatalog[Zufallsfragen[current_Q] - 1][i + 2];
            }
            current_Q++;
        }
        void change_FontSize()
        {
            Auswahl_Text_Größe.Text = Text_Size.ToString();
            currentFont = new Font(Font.FontFamily, Text_Size);
            if (Text_Size < 15)
            {
                Question.Font = currentFont;
                Aufgaben_Gebiet.Font = currentFont;
            }
           
            Btn_Answer1.Font = currentFont;
            Btn_Answer2.Font = currentFont;
            Btn_Answer3.Font = currentFont;
            Btn_Answer4.Font = currentFont;
        }

        private void Text_smaller(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Text_bigger(object sender, EventArgs e)
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

       
        private void Auswahl_Text_Göße(object sender, EventArgs e)
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

        private void Question_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(Question.Text, Question.Font);
            Question.Width = size.Width;
            Question.Height = size.Height;
        }

        private void Aufgaben_Gebiet_TextChanged(object sender, EventArgs e)
        {

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
            }
        }

        private void Btn_Next(object sender, EventArgs e)
        {
            if (Next_was_pressed)
            {
                Btn_Color("Clear");
                Enable_Ans_Buttons();
                write_Question();
                if (current_Q == Fragenkatalog.Length)
                {
                    Next.Text = "Finish";
                }
                Next_was_pressed = false;
                
                
            }
            else
            { 
                if (given_Answer == right_Answer)
                {
                    textBox1.BackColor = Color.Green;
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
                Disable_Ans_Buttons();
                if (current_Q < Fragenkatalog.Length)
                    Next_was_pressed = true;

            }
                
        }

        private void Btn_Answer_1(object sender, EventArgs e)
        {
            Btn_Color(nameof(Btn_Answer1));

            given_Answer = Btn_Answer1.Text;
        }

        private void Btn_Answer2_Click(object sender, EventArgs e)
        {
            Btn_Color(nameof(Btn_Answer2));

            given_Answer = Btn_Answer2.Text;
        }

        private void Btn_Answer3_Click(object sender, EventArgs e)
        {
            Btn_Color(nameof(Btn_Answer3));

            given_Answer = Btn_Answer3.Text;
        }

        private void Btn_Answer4_Click(object sender, EventArgs e)
        {
            Btn_Color(nameof(Btn_Answer4));

            given_Answer = Btn_Answer4.Text;
        }

        
        void Start_Sequenz()
        {
            for (int i = 0; i < Fragenkatalog.Length; i++)
            {
                Zufallszahl = rnd.Next(1, Fragenkatalog.Length+1);
                if (!Zufallsfragen.Contains(Zufallszahl))
                    Zufallsfragen[i] = Zufallszahl;
                else
                    i--;
            }

            var answers = new[] { Btn_Answer1, Btn_Answer2, Btn_Answer3, Btn_Answer4 };
            Aufgaben_Gebiet.Text = Fragenkatalog[Zufallsfragen[0] - 1][0];
            Question.Text = Fragenkatalog[Zufallsfragen[0] - 1][1];

            right_Answer = Fragenkatalog[Zufallsfragen[0] - 1][2];

            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
                answers[i].Text = Fragenkatalog[Zufallsfragen[0] - 1][i + 2];
            }
            Next.Enabled = true;
            Start.Text = "Reset";
            
        }
        void Reset()
        {
            Aufgaben_Gebiet.Text = "";
            Question.Text = "";
            Disable_and_delete_Ans_Buttons();

            Next.Enabled = false;
            Next_was_pressed = false;
            Btn_Color("Clear");
            given_Answer = "";
            current_Q = 1;

            Array.Clear(Zufallsfragen, 0, Zufallsfragen.Length);
            Start.Text = "Start";
        }
        void Disable_Ans_Buttons()
        {
            var answers = new[] { Btn_Answer1, Btn_Answer2, Btn_Answer3, Btn_Answer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
            }

        }
        void Enable_Ans_Buttons()
        {
            var answers = new[] { Btn_Answer1, Btn_Answer2, Btn_Answer3, Btn_Answer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = true;
            }
        }
        void Disable_and_delete_Ans_Buttons()
        {
            var answers = new[] { Btn_Answer1, Btn_Answer2, Btn_Answer3, Btn_Answer4 };
            for (int i = 0; i < 4; i++)
            {
                answers[i].Enabled = false;
                answers[i].Text = "";
            }
        }
        void Btn_Color(string x)
        {
            switch (x)
            {
                case "Btn_Answer1":
                    Btn_Answer1.BackColor = Color.White;
                    Btn_Answer2.BackColor = Color.Gainsboro;
                    Btn_Answer3.BackColor = Color.Gainsboro;
                    Btn_Answer4.BackColor = Color.Gainsboro;
                    break;

                case "Btn_Answer2":
                    Btn_Answer1.BackColor = Color.Gainsboro;
                    Btn_Answer2.BackColor = Color.White;
                    Btn_Answer3.BackColor = Color.Gainsboro;
                    Btn_Answer4.BackColor = Color.Gainsboro;
                    break;

                case "Btn_Answer3":
                    Btn_Answer1.BackColor = Color.Gainsboro;
                    Btn_Answer2.BackColor = Color.Gainsboro;
                    Btn_Answer3.BackColor = Color.White;
                    Btn_Answer4.BackColor = Color.Gainsboro;
                    break;

                case "Btn_Answer4":
                    Btn_Answer1.BackColor = Color.Gainsboro;
                    Btn_Answer2.BackColor = Color.Gainsboro;
                    Btn_Answer3.BackColor = Color.Gainsboro;
                    Btn_Answer4.BackColor = Color.White;
                    break;
                case "Clear":
                    Btn_Answer1.BackColor = Color.Gainsboro;
                    Btn_Answer2.BackColor = Color.Gainsboro;
                    Btn_Answer3.BackColor = Color.Gainsboro;
                    Btn_Answer4.BackColor = Color.Gainsboro;
                    textBox1.BackColor = Color.White;
                    break;

            }
        }
    }
}
