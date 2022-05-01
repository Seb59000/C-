using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicForFreedom
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Request.QueryString["email"];
            TextBox2.Text = Request.QueryString["password"];
            //TextBox1.Text = Request.Form ["email"];
            //TextBox2.Text = Request.Form ["password"];




        }
    }
}