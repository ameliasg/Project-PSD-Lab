using ProjectPSD.Controllers;
using ProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class DetailPage : System.Web.UI.Page
    {
        int id;
        int uID;
        TransactionController transactionController = new TransactionController();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request["id"]);
            List<TransactionDetail> details = transactionController.getDetail(id);
            DetailGV.DataSource = details;
            DetailGV.DataBind();
            tID.Text = details.FirstOrDefault().TransactionID.ToString();
        }
        protected void back_Click(object sender, EventArgs e)
        {
            if (Request["from"] != null && Request["from"] == "handler") Response.Redirect("~/Views/Admin/TransactionHandler.aspx");
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }
    }
}