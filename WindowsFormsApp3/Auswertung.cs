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
        }
        bool Btn_Prozentwechsler_was_pressed = false;
        public static string[][][] return_Fragenkatalog;
        int richtige_Antworten, falsche_Antworten, Anzahl_Fragen;
        double Prozent_richtige_Antworten, Prozent_falsche_Antworten;


        private void Auswertung_Load(object sender, EventArgs e)
        {
            for(int i = 0;i < return_Fragenkatalog.Length; i++)
            {
                if(return_Fragenkatalog[i][2][0] == "1")
                {
                    richtige_Antworten++;
                }
                else
                {
                    falsche_Antworten++;
                }
            }

            Anzahl_Fragen = return_Fragenkatalog.Length;
            
            for(int i=0;i<return_Fragenkatalog.Length;i++)
            {
                if(return_Fragenkatalog[i][2][0]=="0")
                {
                    rich_Fragen.AppendText(return_Fragenkatalog[i][0][0].ToString());
                    rich_Fragen.AppendText(" " + return_Fragenkatalog[i][0][2].ToString()+Environment.NewLine);
                    rich_Fragen.AppendText(return_Fragenkatalog[i][0][1].ToString() + Environment.NewLine + Environment.NewLine);
                    rich_Fragen.AppendText(return_Fragenkatalog[i][1][0].ToString() + Environment.NewLine);
                    rich_Fragen.AppendText(return_Fragenkatalog[i][1][1].ToString() + Environment.NewLine);
                    rich_Fragen.AppendText(return_Fragenkatalog[i][1][2].ToString() + Environment.NewLine);
                    rich_Fragen.AppendText(return_Fragenkatalog[i][1][3].ToString() + Environment.NewLine + Environment.NewLine);
                }
            }


            Prozent_richtige_Antworten = (Convert.ToDouble(richtige_Antworten) / Convert.ToDouble(Anzahl_Fragen)) * 100;
            Prozent_falsche_Antworten = 100 - Prozent_richtige_Antworten;

            

            chart_Fragenauswertung.Series["alle_Antworten"].Points.Add(richtige_Antworten);
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Color = Color.LightGreen;
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].AxisLabel = "Antworten richtig";
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = richtige_Antworten.ToString();
            
            chart_Fragenauswertung.Series["alle_Antworten"].Points.Add(falsche_Antworten);
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Color = Color.Red;
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].AxisLabel = "Antworten falsch";
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = falsche_Antworten.ToString();

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
                if (richtige_Antworten != 1)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = richtige_Antworten + " Antworten richtig";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = richtige_Antworten + " Antwort richtig";
                }
                chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = richtige_Antworten.ToString();

                if (falsche_Antworten != 1)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = falsche_Antworten.ToString() + " Antworten falsch";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = falsche_Antworten.ToString() + " Antwort falsch";
                }
                chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = falsche_Antworten.ToString();

                Btn_Prozentwechsler_was_pressed = false;
            }
            else
            {
                if (Prozent_richtige_Antworten == 0)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = Prozent_richtige_Antworten +  "%     Antworten richtig";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = Prozent_richtige_Antworten.ToString("0") + "% Antworten richtig";

                }
                chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = Prozent_richtige_Antworten.ToString("0") + "%";

                if(Prozent_falsche_Antworten == 0)
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = Prozent_falsche_Antworten + "%     Antworten falsch";
                }
                else
                {
                    chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = Prozent_falsche_Antworten.ToString("0") + "% Antworten falsch";
                }
                chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = Prozent_falsche_Antworten.ToString("0") + " %";
                Btn_Prozentwechsler_was_pressed = true;
            }
        }
    }
}
