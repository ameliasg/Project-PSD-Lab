using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        TransactionController transactionController = new TransactionController();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            if (Session["user"] != null) id = Convert.ToInt32(Session["user"]);
            else id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            if (!IsPostBack)
            {
                transactionGV.DataSource = transactionController.getUserTransaction(id);
                transactionGV.DataBind();
            }
        }

        protected void details_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((Button)sender).NamingContainer;
            Response.Redirect("~/Views/DetailPage.aspx?id=" + row.Cells[0].Text);
        }

        protected void back_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                Response.Redirect("~/Views/Admin/adminHome.aspx");
            }
            else
            {
                Response.Redirect("~/Views/User/userHome.aspx");
            }
        }
    }
}