using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class rapport_de_plantage : Form
    {
        string temp;

        public rapport_de_plantage(string info)
        {
            InitializeComponent();
            temp = info;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fsOut = new FileStream("problemes.txt", FileMode.Append);

            StreamWriter sWiter = new StreamWriter(fsOut, Encoding.Default);
            sWiter.WriteLine(temp+ "\r\n"+textBox1.Text);
            sWiter.Close();
            fsOut.Close();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
