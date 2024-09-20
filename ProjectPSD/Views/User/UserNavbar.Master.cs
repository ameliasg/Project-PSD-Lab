using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.User
{
    public partial class UserNavbar : System.Web.UI.MasterPage
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }

            if (Session["user"] != null) id = Convert.ToInt32(Session["user"]);
            else id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
        }

        protected void orderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/User/OrderPage.aspx");

        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");

        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["user_cookie"] != null)
            {
                HttpCookie cookie = new HttpCookie("user_cookie");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            Session["user"] = null;
            Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }
    }
}