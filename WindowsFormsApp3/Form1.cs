using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

    

        private void LandToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

            OpenFileDialog dlg = new OpenFileDialog();
       
            dlg.Filter = "HTML File|*.html";

            dlg.ShowDialog();

            string filename = dlg.FileName;
            string readfile = File.ReadAllText(filename);
            richTextBox1.Text = readfile;
        }
    }
}
