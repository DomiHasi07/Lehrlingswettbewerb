using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Principal;
using System.Runtime.InteropServices;
using Aufnahmetest;

namespace WindowsFormsApp3
{
    public partial class Start_Screen : Form
    {

        public static Button pressed_Button;
        public static string txt_Name;
        bool button_pressed = false;
        int Themen = 0;
        bool finished = false;
        bool Admin = false;
       
        DataSet tempDS = new DataSet();
        Button[] buttons;

        public Start_Screen()
        {
            InitializeComponent();
            buttons = new Button[] { Btn_1, Btn_2, Btn_3, Btn_4 };
            tbl_Buttons.Enabled = false;
            Btn_Start.Enabled = false;

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                this.ControlBox = false;
                this.Size = new Size(685, 245);
            }
            else
            {
                Btn_Settings.Visible = true;
                Admin = true;
                //Admin
            }
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {
        }

        private void Auswahl_getroffen(object sender, EventArgs e)
        {
            Button_Farbe();
            (sender as Button).BackColor = Color.White;
            pressed_Button = (sender as Button);
            button_pressed = true;
            Btn_Start.Enabled = true;
        }

        private void Button_Farbe()
        {
            foreach (Button button in buttons)
            {
                if(button.BackColor!= SystemColors.ControlDarkDark)
                    button.BackColor = SystemColors.ControlLight;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (!finished)
            {
                if (!button_pressed)
                {
                    return;
                }
                else
                {
                    if (Themen < 4)
                    {
                        TBx_Name.ReadOnly = true;
                        txt_Name = TBx_Name.Text.Replace(" ","_");
                        pressed_Button.Enabled = false;
                        pressed_Button.BackColor = SystemColors.ControlDarkDark;
                        Main mainForm = new Main();
                        if(!Admin)
                        {
                            mainForm.ControlBox = false;
                        }
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Show();
                        Themen++;
                        if (Themen < 3)
                        {
                            button_pressed = false;
                            Btn_Start.Enabled = false;
                        }
                        else if (Themen == 3)
                        {
                            foreach (Button button in buttons)
                            {
                                if (button.Enabled)
                                {
                                    pressed_Button = button;
                                    button.Focus();
                                    button.BackColor = SystemColors.ControlLight;
                                }
                            }
                        }
                        else if (Themen == 4)
                        {
                            Btn_Start.Text = "Beenden";
                            pressed_Button = null;
                            finished = true;
                        }
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void tB_Name_TextChanged(object sender, EventArgs e)
        {
            if(TBx_Name.TextLength > 0)
            {
                tbl_Buttons.Enabled = true;
            }
            else
            {
                Button_Farbe();
                tbl_Buttons.Enabled = false;
                Btn_Start.Enabled = false;
            }
        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        { 
            Frm_Test sub_frm = new Frm_Test();
            var result = sub_frm.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
        }
    }
}
