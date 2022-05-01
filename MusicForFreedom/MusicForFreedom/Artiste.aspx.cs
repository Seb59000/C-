using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicForFreedom
{
    public partial class Artiste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            string ext = Path.GetExtension(fuPhoto.FileName).ToUpper();

            if ((ext != ".JPG") || (ext != ".PNG") || (ext != ".GIF"))
                lblErreur.Visible = true;
            else
                lblErreur.Visible = false;
            try
            {
                SqlConnection cn = new SqlConnection();
                ConnectionStringSettings oconfig =
                ConfigurationManager.ConnectionStrings["MusicForFreedom.Properties.Settings.BDDMusicForFreedom"];
                cn.ConnectionString = oconfig.ConnectionString;
                cn.Open();

                                          //insert into[dbo].[ArtisteSet] ([NomArtiste],[DescriptionArtiste],[LogoArtiste],[MailArtiste],[MotDePasseArtiste],[NumPaypall]) values('MOMO', 'musique de ouf','A78.jpg','momo@live.fr','MOMO','AF4654FS6456FFG')

                SqlCommand cmd = new SqlCommand("insert into [dbo].[ArtisteSet] ([NomArtiste],[DescriptionArtiste],[LogoArtiste],[MailArtiste],[MotDePasseArtiste],[NumPaypall],[LienTelechargement]) values('" + tbNomArtiste.Text +"','"+tbPresentation.Text+"','"+tbNomArtiste.Text + ext+"','" +tbMail.Text+"','"+tbMotdePasse.Text +"','"+tbPaypall.Text +"','"+tblien.Text+"')", cn);
                //SqlCommand cmd = new SqlCommand("insert into [dbo].[ArtisteSet] ([NomArtiste],[DescriptionArtiste],[MailArtiste],[MotDePasseArtiste],[NumPaypall]) values('"+tbNomArtiste.Text +"','"+tbPresentation.Text+"','"+tbMail+"','"+tbMotdePasse+"','"+tbPaypall+"')", cn);
                cmd.ExecuteNonQuery();
               

                fuPhoto.SaveAs(Server.MapPath("Logos") + "/" + tbNomArtiste.Text + ext); //attention, on met Server.MapPath/ pour quand le projet sera hébergé et changer de localisation

                //fuPhoto.SaveAs(Server.MapPath("Images")+"/"+ txtRef.Text + ext); //attention, on met Server.MapPath/ pour quand le projet sera hébergé et changer de localisation
                //sinon, on mettrait (txtref.Text+ext) ??, ne marche pas????? mais ajoute quand même dans la BDD?!
                Response.Redirect("Accueil.aspx");

            }
            catch (Exception)
            {
                Response.Redirect("Oups.aspx");

            }
        }
    }
}