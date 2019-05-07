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
        }

        private void Start_Screen_Load(object sender, EventArgs e)
        {
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            cb1_status = cb1.Checked;
            this.Visible = false;
            Main_Frm Main_Diaglog = new Main_Frm();
            Main_Diaglog.ShowDialog();
            this.Visible = true;
        }

        private void load_file()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (String.Equals(Path.GetExtension(ofd.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    filepath = ofd.FileName;
                    Btn_File.Text = Path.GetFileName(filepath);
                    Btn_Start.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Dieser Dateityp wird nicht unterstützt. Wählen Sie bitte eine XML Datei aus", "Falscher Dateityp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_File_Click(object sender, EventArgs e)
        {
            load_file();
        }
    }
}
