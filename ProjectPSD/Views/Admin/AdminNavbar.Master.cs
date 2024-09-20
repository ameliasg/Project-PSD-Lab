using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class AdminNavbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["user"]) != 1) Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/adminHome.aspx");
        }

        protected void manageMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageMakeupPage.aspx");
        }

        protected void orderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionHandler.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void tReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionReport.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }

        protected void tHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }
    }
}