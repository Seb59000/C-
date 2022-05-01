using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Recherche_dans_une_BDD
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();

            codeFouTxtBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2( Convert.ToInt16( codeFouTxtBox.Text));
            form.Show();
        }

        private void QuitterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
