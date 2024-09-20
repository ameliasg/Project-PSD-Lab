using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.User
{
    public partial class userHome : System.Web.UI.Page
    {
        HomeController homeHandler = new HomeController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            int id;
            if(Session["user"] != null) id = Convert.ToInt32(Session["user"]);
            else id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            userWelcome.Text = homeHandler.welcome(id);
        }
    }
}