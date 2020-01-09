using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufnahmetest
{
    public partial class Frm_Einstellung_Schlüssel : Form
    {
        private DataSet Settings = new DataSet();
        private bool after_Start = false;

        public Frm_Einstellung_Schlüssel()
        {
            InitializeComponent();
            Settings.ReadXml(@"Settings.xml");

            string data;
            for (int i =0;i<5;i++)
            {
                data = Settings.Tables["Schlüssel"].Rows[0][i].ToString();
                string[] arr_data = data.Split('-');
                switch(i)
                {
                    case 0:
                        this.Controls[0].Controls["TxB_6"].Text = arr_data[1];
                        break;
                    case 1:
                    case 2:
                    case 3:
                        this.Controls[0].Controls["TxB_" + (i + 1).ToString()].Text = arr_data[0];
                        this.Controls[0].Controls["TxB_" + (i + 6).ToString()].Text = arr_data[1];
                        break;
                    case 4:
                        this.Controls[0].Controls["TxB_5"].Text = arr_data[0];
                        break;
                }
            }
            after_Start = true;
        }

        private void Frm_Einstellung_Schlüssel_Load(object sender, EventArgs e)
        {

        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<3;i++)
            {
                NumericUpDown linke_box = (NumericUpDown)tableLayoutPanel1.GetControlFromPosition(1, i + 2);
                NumericUpDown rechte_box = (NumericUpDown)tableLayoutPanel1.GetControlFromPosition(3, i + 2);
                Label Zeile = (Label)tableLayoutPanel1.GetControlFromPosition(0, i + 2);
                if(linke_box.Value >= rechte_box.Value)
                {
                    MessageBox.Show("Fehler in Zeile \"" + Zeile.Text.ToUpper() + "\":\tDer Wert in der linken Box muss kleiner sein als der in der Rechten");
                    return;
                }
            }

            for (int i = 0;i<5; i++)
            {
                if(i>0 && i<4)
                    Settings.Tables[1].Rows[0][i] = this.Controls[0].Controls["TxB_" + (i+1).ToString()].Text + "-" + this.Controls[0].Controls["TxB_" + (i+6).ToString()].Text;
                else if(i==0)
                    Settings.Tables[1].Rows[0][i] = "0-" + this.Controls[0].Controls["TxB_" + (i + 6).ToString()].Text;
                else if(i==4)
                    Settings.Tables[1].Rows[0][i] = this.Controls[0].Controls["TxB_" + (i + 1).ToString()].Text + "-100";
            }
            Settings.WriteXml(@"Settings.xml");
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Num_ValueChanged(object sender, EventArgs e)
        {
            
            if (after_Start)
            {
                int Position_Button = int.Parse(((Control)sender).Tag.ToString());
                if (Position_Button < 6)
                {
                    ((NumericUpDown)this.Controls[0].Controls["TxB_" + (Position_Button + 4).ToString()]).Value = ((NumericUpDown)sender).Value - 1;
                }
                else if (Position_Button > 5)
                {
                    ((NumericUpDown)this.Controls[0].Controls["TxB_" + (Position_Button - 4).ToString()]).Value = ((NumericUpDown)sender).Value + 1;
                }

                if(cBx_1.Checked)
                {
                    switch (Position_Button)
                    {
                        case 9:
                            if (Numeric_Value_vergl(4, 9))
                            {
                                Numeric_Value_ändern(4);
                                goto case 4;
                            }
                            else if (Numeric_Value_vergl(9, 5))
                            {
                                Numeric_Value_ändern(5, false);
                                break;
                            }
                            else
                            {
                                break;
                            }
                        case 4:
                            if (Numeric_Value_vergl(4, 8))
                            {
                                Numeric_Value_ändern(8);
                                goto case 8;
                            }
                            else if (Numeric_Value_vergl(4, 9))
                            {
                                Numeric_Value_ändern(9, false);
                                goto case 9;
                            }
                            else
                            {
                                break;
                            }
                        case 8:
                            if (Numeric_Value_vergl(8, 3))
                            {
                                Numeric_Value_ändern(3);
                                goto case 3;
                            }
                            else if (Numeric_Value_vergl(8, 4))
                            {
                                Numeric_Value_ändern(4, false);
                                goto case 4;
                            }
                            else
                            {
                                break;
                            }
                        case 3:
                            if (Numeric_Value_vergl(3, 7))
                            {
                                Numeric_Value_ändern(7);
                                goto case 7;
                            }
                            else if (Numeric_Value_vergl(3, 8))
                            {
                                Numeric_Value_ändern(8, false);
                                goto case 8;
                            }
                            else
                            {
                                break;
                            }
                        case 7:
                            if (Numeric_Value_vergl(7, 2))
                            {
                                Numeric_Value_ändern(2);
                                goto case 2;
                            }
                            else if (Numeric_Value_vergl(7, 3))
                            {
                                Numeric_Value_ändern(3, false);
                                goto case 3;
                            }
                            else
                            {
                                break;
                            }
                        case 2:
                            if (Numeric_Value_vergl(2, 6))
                            {
                                Numeric_Value_ändern(6);
                                break;
                            }
                            else if (Numeric_Value_vergl(2, 7))
                            {
                                Numeric_Value_ändern(7, false);
                                goto case 7;
                            }
                            else
                            {
                                break;
                            }
                    }
                }
                


            }
            
        }

        private void Numeric_Value_ändern(int Position, bool niedriger = true)
        {
            ((NumericUpDown)tableLayoutPanel1.Controls["TxB_" + Position.ToString()]).ValueChanged -= Num_ValueChanged;
            if (niedriger)
            {
                ((NumericUpDown)tableLayoutPanel1.Controls["TxB_" + Position.ToString()]).Value--;
            }
            else
            {
                ((NumericUpDown)tableLayoutPanel1.Controls["TxB_" + Position.ToString()]).Value++;
            }
            ((NumericUpDown)tableLayoutPanel1.Controls["TxB_" + Position.ToString()]).ValueChanged += Num_ValueChanged;
        }

        private bool Numeric_Value_vergl(int feld1,int feld2)
        {
            if (((NumericUpDown)tableLayoutPanel1.Controls["TxB_" + feld1.ToString()]).Value == ((NumericUpDown)this.Controls[0].Controls["TxB_" + feld2.ToString()]).Value)
                return true;
            else
                return false;
        }
    }
}
