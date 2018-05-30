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
    
    public partial class Beenden : Form
    {

        public string ReturnValue1 { get; set; }
        public Beenden()
        {
            InitializeComponent();
        }

        private void Auswertung_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = "Beenden";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Auswertung_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = "Auswertung";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_restart_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = "Restart";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
