using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicForFreedom
{
    public partial class PageArtiste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //frame1.Attributes["src"] = "http://www.w3schools.com";
            string request = Request.QueryString["link"];
            TextBox1.Text = request;
            //frame1.Src = request;
            //frame1.Attributes["src"] = request;
            frame1.Src = "http://www.reverbnation.com/";

        }
    }
}