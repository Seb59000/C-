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


namespace Recherche_dans_une_BDD
{
    public partial class Form2 : Form
    {
        int value;

        public Form2(int valeur)
        {
            InitializeComponent();
            value= valeur;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection();

            ConnectionStringSettings oConfig = ConfigurationManager.ConnectionStrings["Recherche_dans_une_BDD.Properties.Settings.BDPapyrus"];
            if (oConfig != null)
            {
                // affectation de la chaine de connection extraite
                sqlConnect.ConnectionString = oConfig.ConnectionString;
            }
            
            try
            {
                sqlConnect.Open();
                SqlCommand sqlCde = new SqlCommand();
            
                sqlCde.Connection = sqlConnect;  
                SqlDataReader resultatRequete;
                
                sqlCde.CommandType = CommandType.Text;
                sqlCde.CommandText = "select NOMFOU,RUEFOU,POSFOU,VILFOU, CONFOU,SATISF from stgCDI.FOURNIS where NUMFOU="+value;
                resultatRequete = sqlCde.ExecuteReader();


                resultatRequete.Read();

                textBox1.Text = resultatRequete.GetString(0);
                textBox2.Text = resultatRequete.GetString(1);
                textBox3.Text = resultatRequete.GetString(2);
                textBox4.Text = resultatRequete.GetString(3);
                textBox5.Text = resultatRequete.GetString(4);
                textBox6.Text = Convert.ToString(resultatRequete.GetByte(5));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void RetourButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
