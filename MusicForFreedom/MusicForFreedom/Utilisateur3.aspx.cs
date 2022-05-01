using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MusicForFreedom
{
    public partial class UserFormsTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonClick(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=BDDMusicForFree;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into UtilisateurSet values('" + Name.Text + "')", cn);
            cmd.ExecuteNonQuery();
        }
    }
}