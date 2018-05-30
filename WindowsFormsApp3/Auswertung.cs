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
        public static int return_Anzahl_Fragen;
        public static int return_richtige_Antworten;
        public static string[][][] return_Fragenkatalog;
        public static int[] return_falschBeantworteteFragen;

        private void Auswertung_Load(object sender, EventArgs e)
        {
            int falsche_Antworten = return_Anzahl_Fragen - return_richtige_Antworten;
            double Prozent_richtige_Antworten, Prozent_falsche_Antworten;
            Array.Sort(return_falschBeantworteteFragen);
            for(int i=0;i<return_falschBeantworteteFragen.Length;i++)
            {
                rich_Fragen.AppendText(return_Fragenkatalog[return_falschBeantworteteFragen[i]][0][0].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(return_Fragenkatalog[return_falschBeantworteteFragen[i]][0][1].ToString() + Environment.NewLine + Environment.NewLine);
                rich_Fragen.AppendText(return_Fragenkatalog[return_falschBeantworteteFragen[i]][1][0].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(return_Fragenkatalog[return_falschBeantworteteFragen[i]][1][1].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(return_Fragenkatalog[return_falschBeantworteteFragen[i]][1][2].ToString() + Environment.NewLine);
                rich_Fragen.AppendText(return_Fragenkatalog[return_falschBeantworteteFragen[i]][1][3].ToString() + Environment.NewLine + Environment.NewLine);
            }

            Prozent_falsche_Antworten = (Convert.ToDouble(falsche_Antworten) / Convert.ToDouble(return_Anzahl_Fragen)) * 100;
            Prozent_richtige_Antworten = (Convert.ToDouble(return_richtige_Antworten) / Convert.ToDouble(return_Anzahl_Fragen)) * 100;

            chart_Fragenauswertung.Series["alle_Antworten"].Points.Add(return_richtige_Antworten);
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Color = Color.LightGreen;
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].AxisLabel = "Antworten richtig";
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = return_richtige_Antworten.ToString() + " Antworten richtig";
            chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = return_richtige_Antworten.ToString();

            chart_Fragenauswertung.Series["alle_Antworten"].Points.Add(falsche_Antworten);
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Color = Color.Red;
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].AxisLabel = "Antworten falsch";
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = falsche_Antworten.ToString() + " Antworten falsch";
            chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = falsche_Antworten.ToString();

            

        }
        private void Prozentwechsler_Click(object sender, EventArgs e)
        {

            int falsche_Antworten = return_Anzahl_Fragen - return_richtige_Antworten;
            double Prozent_richtige_Antworten, Prozent_falsche_Antworten;

            Prozent_falsche_Antworten = (Convert.ToDouble(falsche_Antworten) / Convert.ToDouble(return_Anzahl_Fragen)) * 100;
            Prozent_richtige_Antworten = (Convert.ToDouble(return_richtige_Antworten) / Convert.ToDouble(return_Anzahl_Fragen)) * 100;

            if (Btn_Prozentwechsler_was_pressed)
            {
                chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = return_richtige_Antworten + " Antworten richtig";
                chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = return_richtige_Antworten.ToString();
                chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = falsche_Antworten.ToString() + " Antworten falsch";
                chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = falsche_Antworten.ToString();
                Btn_Prozentwechsler_was_pressed = false;
            }
            else
            {
                chart_Fragenauswertung.Series["alle_Antworten"].Points[0].LegendText = Prozent_richtige_Antworten + "% Antworten richtig";
                chart_Fragenauswertung.Series["alle_Antworten"].Points[0].Label = Prozent_richtige_Antworten.ToString() + "%";
                chart_Fragenauswertung.Series["alle_Antworten"].Points[1].LegendText = Prozent_falsche_Antworten + "% Antworten falsch";
                chart_Fragenauswertung.Series["alle_Antworten"].Points[1].Label = Prozent_falsche_Antworten.ToString() + " %";
                Btn_Prozentwechsler_was_pressed = true;
            }

        }

        private void chart_Fragenauswertung_Click(object sender, EventArgs e)
        {

        }
    }
}
