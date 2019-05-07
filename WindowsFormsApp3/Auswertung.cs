using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Auswertung : Form
    {
        public Auswertung()
        {
            InitializeComponent();
            this.MouseWheel += Auswertung_MouseWheel;
        }

        private void Auswertung_MouseWheel(object sender, MouseEventArgs e)
        {
            rich_Fragen.Focus();
        }

        bool Btn_Prozentwechsler_was_pressed = false;
        public static string[][][] Fragen;
                                                                                                                                    /*
                                                                                                                                     * Fragen[i][0][0] = Kat ausgeschrieben
                                                                                                                                     * Fragen[i][0][1] = Frage
                                                                                                                                     * Fragen[i][0][2] = Fragennummer
                                                                                                                                     * Fragen[i][1][0] = richtige Antwort
                                                                                                                                     * Fragen[i][1][1] = 2. Antwort
                                                                                                                                     * Fragen[i][1][2] = 3. Antwort
                                                                                                                                     * Fragen[i][1][3] = 4. Antwort
                                                                                                                                     * Fragen[i][2][0] = gegebene Antwort
                                                                                                                                     * Fragen[i][2][1] = Zeit pro Frage
                                                                                                                                     */
        string[][] Kat_Arr;
        int richtige_Antworten, falsche_Antworten, Anzahl_Fragen, Anzahl_Kat;
        double Prozent_richtige_Antworten, Prozent_falsche_Antworten;
        float Zeit_alle_Fragen;

        
        private void Auswertung_Load(object sender, EventArgs e)
        {
            Fragen = Main_Frm.Fragenkatalog;

            for(int i = 0;i < Fragen.Length; i++)
            {
                if(Fragen[i][2][0] == "right")
                {
                    richtige_Antworten++;
                }
                else
                {
                    falsche_Antworten++;
                }
                Zeit_alle_Fragen = Zeit_alle_Fragen + float.Parse(Fragen[i][2][1]);
            }

            Anzahl_Kat = zählen_Kat();

            Kat_Arr = Kat_Arr_füllen(Anzahl_Kat);

            Anzahl_Fragen = Fragen.Length;

            rich_Fragen.AppendText("Zeit für alle Fragen " + Minuten_sekunden(Zeit_alle_Fragen));

            neue_Zeile(1);

            rich_Fragen.AppendText("Durchschnittliche Zeit pro Frage: " + Minuten_sekunden(Zeit_alle_Fragen/Anzahl_Fragen));

            neue_Zeile(2);

            for (int i = 0; i < Fragen.Length; i++)
            {
                rich_Fragen.AppendText(Fragen[i][0][0].ToString());
                rich_Fragen.AppendText(" " + Fragen[i][0][2].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(Fragen[i][0][1].ToString() + Environment.NewLine + Environment.NewLine);
                rich_Fragen.AppendText(Fragen[i][1][0].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(Fragen[i][1][1].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(Fragen[i][1][2].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(Fragen[i][1][3].ToString() + Environment.NewLine + Environment.NewLine);
                rich_Fragen.AppendText("Zeit für Frage: " + Minuten_sekunden(float.Parse(Fragen[i][2][1])));
                neue_Zeile(3);

                string temp_Frage = Fragen[i][0][0] +" "+ Fragen[i][0][2];
                string temp_Antwort = "";
                Color temp_Color;

                if (Fragen[i][2][0] != "right")
                {     
                    if (Fragen[i][2][0] != "skipped")
                    {
                        temp_Antwort = Fragen[i][1][Int32.Parse(Fragen[i][2][0])];
                    }

                    temp_Color = Color.Red;
                }
                else
                {
                    temp_Antwort = Fragen[i][1][0];
                    temp_Color = Color.Green;
                }

                Text_einfärben(temp_Frage, temp_Antwort, temp_Color);
            }

            Prozent_richtige_Antworten = (Convert.ToDouble(richtige_Antworten) / Convert.ToDouble(Anzahl_Fragen)) * 100;
            Prozent_falsche_Antworten = 100 - Prozent_richtige_Antworten;

            chart_Fragenauswertung.Series["alle_Antworten"].Points.Add(richtige_Antworten);
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Color = Color.LightGreen;
           
            chart_Fragenauswertung.Series["alle_Antworten"].Points.Add(falsche_Antworten);
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Color = Color.Red;

            for (int i = 0; i < Kat_Arr.Length; i++)
            {
                chart_Kat.Series[0].Points.AddXY(Kat_Arr[i][1], Int16.Parse(Kat_Arr[i][3]));
                chart_Kat.Series[1].Points.AddXY(Kat_Arr[i][1], Int16.Parse(Kat_Arr[i][4]));

            }

            chart_Kat.Series[0].Color = Color.LightGreen;
            chart_Kat.Series[1].Color = Color.Red;

            Vollzahl_Prozente();
        }

        private void chart_Fragenauswertung_Click(object sender, EventArgs e)
        {

        }

        private void Prozentwechsler_Click(object sender, EventArgs e)
        {
            Vollzahl_Prozente();
            
        }

        private void Vollzahl_Prozente()
        {

            if (Btn_Prozentwechsler_was_pressed)
            {
                if(richtige_Antworten == 1)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = richtige_Antworten + " Antwort richtig";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = richtige_Antworten + " Antworten richtig";
                }
                
                if(falsche_Antworten == 1)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = falsche_Antworten.ToString() + " Antwort falsch";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = falsche_Antworten.ToString() + " Antworten falsch";
                }

                if(richtige_Antworten == 0 || falsche_Antworten == 0)
                {
                    if(richtige_Antworten == 0)
                    {
                        chart_Fragenauswertung.Series["alle_Antworten"].Points[0].AxisLabel = "";
                        chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = "";
                        chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = falsche_Antworten.ToString();
                    }
                    else
                    {
                        chart_Fragenauswertung.Series["alle_Antworten"].Points[1].AxisLabel = "";
                        chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = "";
                        chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = richtige_Antworten.ToString();
                    }
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = richtige_Antworten.ToString();
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = falsche_Antworten.ToString();
                }

                Btn_Prozentwechsler_was_pressed = false;
            }
            else
            {
                if (Prozent_richtige_Antworten == 0)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = Prozent_richtige_Antworten +  "%     Antworten richtig";
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].AxisLabel = "";
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = "";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = Prozent_richtige_Antworten.ToString("0") + "% Antworten richtig";
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = Prozent_richtige_Antworten.ToString("0") + "%";

                }

                if(Prozent_falsche_Antworten == 0)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = Prozent_falsche_Antworten + "%     Antworten falsch";
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].AxisLabel = "";
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = "";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = Prozent_falsche_Antworten.ToString("0") + "% Antworten falsch";
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = Prozent_falsche_Antworten.ToString("0") + " %";
                }
                
                Btn_Prozentwechsler_was_pressed = true;
            }
        }

        private void Text_einfärben(string Frage, string Antwort, Color Farbe)
        {
            int Position = rich_Fragen.Find(Frage,RichTextBoxFinds.MatchCase);
            rich_Fragen.Select(Position, Frage.Length);
            rich_Fragen.SelectionColor = Farbe;

            if (Antwort != "")
            {
                Position = rich_Fragen.Find(Antwort, RichTextBoxFinds.MatchCase);
                rich_Fragen.Select(Position,Antwort.Length);
                rich_Fragen.SelectionColor = Farbe;
            }
            rich_Fragen.DeselectAll();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void neue_Zeile(int Anzahl)
        {
            for (int i = 0; i < Anzahl; i++)
            {
                rich_Fragen.AppendText(Environment.NewLine);
            }
        }

        private string Minuten_sekunden(float Zeit)
        {
            string txt;
            if(Zeit > 59)
            {
                TimeSpan t = TimeSpan.FromSeconds(Zeit);
                txt = t.ToString(@"mm\:ss") + " Minuten";
            }
            else
            {
                txt = Zeit.ToString("0.0") + " Sekunden";
            }
            return txt;
        }

        private int zählen_Kat()
        {
            string temp_Kat = "";
            int temp_Anz = 0;

            for (int i = 0; i < Fragen.Length; i++)
            {
                if (temp_Kat != Fragen[i][0][2].Substring(0, 1))
                {
                    temp_Kat = Fragen[i][0][2].Substring(0, 1);
                    temp_Anz++;
                }
            }
            return temp_Anz;
        }

        private string[][] Kat_Arr_füllen(int x)
        {
            string temp_Kat = "";
            string[][] temp_Arr = new string[x][];
                                                                                                                /*
                                                                                                                 * temp_Arr[i][0] = Kat Kürzel
                                                                                                                 * temp_Arr[i][1] = Kat_Ausgeschrieben
                                                                                                                 * temp_Arr[i][2] = wieviele Fragen die Kat hat
                                                                                                                 * temp_Arr[i][3] = wieviele Fragen richtig beantwortet worden sind
                                                                                                                 * temp_Arr[i][4] = wieviele Fragen falsch beantwortet worden sind
                                                                                                                 */
            int j = 0, temp_Anz = 0, richtige_Fragen = 0;


            for (int i = 0; i < Fragen.Length; i++)
            {
                if (temp_Kat != Fragen[i][0][2].Substring(0, 1))
                {
                    temp_Kat = Fragen[i][0][2].Substring(0, 1);
                    temp_Arr[j] = new string[5];
                    temp_Arr[j][0] = temp_Kat;
                    temp_Arr[j][1] = Fragen[i][0][0];

                    if (j > 0)
                    {
                        temp_Arr[j - 1][2] = temp_Anz.ToString();
                        temp_Arr[j - 1][3] = richtige_Fragen.ToString();
                        temp_Arr[j - 1][4] = (temp_Anz - richtige_Fragen).ToString();
                    }
                    temp_Anz = 0;
                    richtige_Fragen = 0;
                    j++;
                }
                temp_Anz++;
                if(Fragen[i][2][0]=="right")
                {
                    richtige_Fragen++;
                }
            }

            temp_Arr[j - 1][2] = (temp_Anz).ToString();
            temp_Arr[j - 1][3] = richtige_Fragen.ToString();
            temp_Arr[j - 1][4] = (temp_Anz - richtige_Fragen).ToString();
            return temp_Arr;
        }
    }
}
