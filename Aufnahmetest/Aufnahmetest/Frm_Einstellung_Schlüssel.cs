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
        

        public Frm_Einstellung_Schlüssel()
        {
            InitializeComponent();
            Settings.ReadXml(@"Settings.xml");

            string data;
            for (int i =0;i<5;i++)
            {
                data = Settings.Tables[1].Rows[0][i].ToString();
                string[] arr_data = data.Split('-');
                this.Controls[0].Controls["TxB_" + (i+1).ToString()].Text = arr_data[0];
                this.Controls[0].Controls["TxB_" + (i + 6).ToString()].Text = arr_data[1];
            }
        }

        private void Frm_Einstellung_Schlüssel_Load(object sender, EventArgs e)
        {

        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<5; i++)
            {
                Settings.Tables[1].Rows[0][i] = this.Controls[0].Controls["TxB_" + (i+1).ToString()].Text + "-" + this.Controls[0].Controls["TxB_" + (i+6).ToString()].Text;
            }
            Settings.WriteXml(@"Settings.xml");
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
