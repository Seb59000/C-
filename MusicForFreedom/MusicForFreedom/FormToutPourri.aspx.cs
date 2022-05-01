using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicForFreedom
{
    public partial class FormToutPourri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection cn = new SqlConnection();
            ConnectionStringSettings oconfig = ConfigurationManager.ConnectionStrings["MusicForFreeNouvelleConnexion.Properties.Settings.BDDMusicForFree"];
            cn.ConnectionString = oconfig.ConnectionString;
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into [dbo].[UtilisateurSet] (NomUtilisateur,MailUtilisateur,MotDePasseUtilisateur) values('" + tbPseudo.Text + "', '" + tbMail.Text + "','" + tbMotdePasse.Text + "')", cn);
            cmd.ExecuteNonQuery();

            Response.Redirect("Accueil.aspx");
        }
    }
}