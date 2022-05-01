using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Connexion_BDD
{
    public partial class Form1 : Form
    {
        // objet ADO.net
        private SqlConnection sqlConnect;

        public Form1()
        {
            InitializeComponent();
            
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // accés à la base
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "Data Source=localhost;Initial Catalog=" + BDDTextBox.Text + ";Integrated Security=True; Connect timeout = 5";
            // Ouvre la connection.
            if (BDDTextBox.Text==""|| BDDTextBox.Text!=null)
            {MessageErreur.Text = "veuillez entrer un nom de base de données";
                
            }
            else
            {
                try
                {
                    sqlConnect.Open();
                    etatConnexionLabel.Text = "Open";
                    MessageErreur.Text = "";
                }
                catch (Exception ex)
                {

                    MessageErreur.Text += "Message: "+ ex.Message;
                    //MessageBox.Show("Erreur de connexion à la base " + ex.Message, "Connexion",
                    //MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void BDDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BDDTextBox_TextChanged(object sender, EventArgs e)
        {
            //string BDD;
            //BDD = BDDTextBox.Text;
            //MessageErreur.Text = BDD;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlConnect.Close();
            etatConnexionLabel.Text = "Closed";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show( "Voulez vous quitter?","Attention!", MessageBoxButtons.YesNo);
            if (dr ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
