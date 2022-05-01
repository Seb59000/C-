using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_et_radioButtons
{
    public partial class CheckBoxEtRadioButton : Form
    {
        public CheckBoxEtRadioButton()
        {
            InitializeComponent();
            Fond.Hide();
            caracteres.Hide();
            Casse.Hide();
            Choix.Enabled = false;
        }


        private void textSaisi_TextChanged(object sender, EventArgs e) 
        {
        Resultat.Text = textSaisi.Text;    //transfert texte zone de saisi vers label
        if (textSaisi.Text == null)
        {
            Choix.Enabled = false; 
        }
        else
        {
            Choix.Enabled = true;
            //foreach(Control test in )
            //{
            //    ((RadioButton)test).Checked= false;
            //}
        }
        }

        private void CouleurDuFond_CheckedChanged(object sender, EventArgs e)
        {
            if (CouleurDuFond.Checked)
            {
                Fond.Show();
            }
            else
            {
                Fond.Hide();
                Rouge.Checked = false;
                Vert.Checked = false;
                Bleu.Checked = false;
                Resultat.BackColor = Color.Transparent;
            }
        }

        private void CouleurDesCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (CouleurDesCaracteres.Checked)
            {
                caracteres.Show();
            }
            else
            {
                caracteres.Hide();
                Rouge2.Checked = false;
                Blanc.Checked = false;
                Noir.Checked = false;
                Resultat.ForeColor = Color.Black;
            }
        }

        private void checkCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCasse.Checked)
            {
                Casse.Show();
            }
            else
            {
                Casse.Hide();
                Majuscules.Checked = false;
                Minuscules.Checked = false;
                Resultat.Text = textSaisi.Text;
            }
        }

        private void Rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (Rouge.Checked)
            {
                Resultat.BackColor = Color.Red;
            }
        }

        private void Vert_CheckedChanged(object sender, EventArgs e)
        {
            if (Vert.Checked)
            {
                Resultat.BackColor = Color.Green;
            }
        }

        private void Bleu_CheckedChanged(object sender, EventArgs e)
        {
            if (Bleu.Checked)
            {
                Resultat.BackColor = Color.Blue;
            }
        }

        private void Rouge2_CheckedChanged(object sender, EventArgs e)
        {
            if (Rouge2.Checked)
            {
                Resultat.ForeColor = Color.Red;
            }
        }

        private void Blanc_CheckedChanged(object sender, EventArgs e)
        {
            if (Blanc.Checked)
            {
                Resultat.ForeColor = Color.White;
            }
        }

        private void Noir_CheckedChanged(object sender, EventArgs e)
        {
            if (Noir.Checked)
            {
                Resultat.ForeColor = Color.Black;
            }
        }

        private void Minuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (Minuscules.Checked)
            {
                Resultat.Text = Resultat.Text.ToLower();
            }
        }

        private void Majuscules_CheckedChanged(object sender, EventArgs e)
        {
            if (Majuscules.Checked)
            {
                Resultat.Text = Resultat.Text.ToUpper();
            }
        }
    }
}
