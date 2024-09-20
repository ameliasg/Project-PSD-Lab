using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class TransactionHandler : System.Web.UI.Page
    {
        TransactionController transactionController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();
            }
        }

        public void refreshGV()
        {
            unhandledGV.DataSource = transactionController.getUserTransaction(false);
            unhandledGV.DataBind();
            handledGV.DataSource = transactionController.getUserTransaction(true);
            handledGV.DataBind();
        }
        protected void details_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((Button)sender).NamingContainer;
            Response.Redirect("~/Views/DetailPage.aspx?id=" + row.Cells[0].Text + "&from=handler");
        }
        protected void handle_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((Button)sender).NamingContainer;
            int id = Convert.ToInt32(row.Cells[0].Text);
            transactionController.handle(id);
            refreshGV();
        }
    }
}