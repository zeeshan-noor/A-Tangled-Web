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
using System.Collections;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        public  Stack<string> readHtml = new Stack<string>();
        public Stack<string> writeHtml = new Stack<string>();

        public string readfile;
        public string readfile01;

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
            readfile = File.ReadAllText(filename);
            //readHtml.Push(File.ReadAllText(filename));
            //richTextBox1.Text = readHtml.Pop();
            richTextBox1.Text = readfile.ToString();
            string[] readline1 = File.ReadAllLines(filename);
            foreach (string s in readline1)
            {
                readHtml.Push(s);
            }

            //readHtml.Push(File.ReadAllText(filename));

        }

        private void CheckTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            foreach (var ab in readHtml)
            {
                if (ab == "</html>" || ab == "</body>")
                {
                    writeHtml.Push("Found Opening Tag \n Found Closing tag \n ");
                    writeHtml.Push("Found Opening Tag \n Found Closing tag \n ");
                    writeHtml.Push("Found Opening Tag \n Found Closing tag \n ");

                }
                else
                {
                    writeHtml.Push("Found non opening Tag");
                }
        }
            foreach (var ab in writeHtml)
            {
                richTextBox1.Text = ab.ToString();
            }
            string adrs = @"C:\Users\Shanu\source\repos\WindowsFormsApp3\WindowsFormsApp3\New folder\New Text Document.txt";
            string filename = adrs;
            readfile01 = File.ReadAllText(filename);
          
            richTextBox1.Text = readfile01.ToString();

    }
    }
}
