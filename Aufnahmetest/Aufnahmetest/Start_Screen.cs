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
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
