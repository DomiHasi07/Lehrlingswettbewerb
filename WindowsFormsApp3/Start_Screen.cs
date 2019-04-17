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
        public static bool cb1_status;
        DataSet tempDS = new DataSet();

        public Start_Screen()
        {
            InitializeComponent();
            tempDS.ReadXml(@"C:\Users\DomiHasi\Source\Repos\Lehrlingswettbewerb\WindowsFormsApp3\Resources\Dateipfade.xml"); 
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tempDS.Tables[0].Rows.Count;i++)
                CmB_1.Items.Add(tempDS.Tables[0].Rows[i][2]);
        }

        private void CmB_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filepath = tempDS.Tables[0].Rows[CmB_1.SelectedIndex][1].ToString();
            Btn_Start.Enabled = true;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            cb1_status = cb1.Checked;
            this.Visible = false;
            Main Main_Diaglog = new Main();
            Main_Diaglog.ShowDialog();
            this.Visible = true;
        }
    }
}
