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

namespace WindowsFormsApp3
{
    public partial class Start_Screen : Form
    {
        public static string filepath;
        string pressed_Button;
        bool button_pressed = false;
        
        DataSet tempDS = new DataSet();
        Button[] buttons;

        public Start_Screen()
        {
            InitializeComponent();
            buttons = new Button[] { Btn_1, Btn_2, Btn_3, Btn_4 };
            tbl_Buttons.Enabled = false;
            Btn_Start.Enabled = false;
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {
            
        }

        private void Auswahl_getroffen(object sender, EventArgs e)
        {
            Button_Farbe();
            (sender as Button).BackColor = Color.White;
            pressed_Button = (sender as Button).Tag.ToString();
            button_pressed = true;
            Btn_Start.Enabled = true;
        }

        private void Button_Farbe()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = SystemColors.ControlLight;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if(!button_pressed)
            {
                return;
            }
            else
            {
                filepath = Path.Combine(Directory.GetCurrentDirectory(), "\\Test" + pressed_Button + ".xml");
            }
        }

        private void tB_Name_TextChanged(object sender, EventArgs e)
        {
            if(tB_Name.TextLength > 0)
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
    }
}
