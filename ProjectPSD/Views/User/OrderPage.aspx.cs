using ProjectPSD.Controllers;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.User
{
    public partial class OrderPage : System.Web.UI.Page
    {
        int id;
        OrderController orderController = new OrderController();
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
                MakeupGV.DataSource = orderController.getMakeupList();
                MakeupGV.DataBind();
                cartGV.DataSource = orderController.getCartList(id);
                cartGV.DataBind();
            }
        }

        protected void orderBtn_Click(object sender, EventArgs e)
        {
            GridViewRow row = (GridViewRow)((Button)sender).NamingContainer;
            TextBox qtyTB = row.FindControl("itemQty") as TextBox;
            Label errMsg = row.FindControl("errMsg") as Label;
            int qty = Convert.ToInt32(qtyTB.Text);
            string err = orderController.validateOrderButton(qty);
            if (err.Equals(""))
            {
                int muID = Convert.ToInt32(row.Cells[0].Text);
                orderController.addToCart(id,muID,qty);
                cartGV.DataSource = orderController.getCartList(id);
                cartGV.DataBind();
            }
            else
            {
                errMsg.Text = "Qty must be bigger than 0";
            }
        }

        protected void clearCart_Click(object sender, EventArgs e)
        {
            orderController.deleteAllItem(id);
            cartGV.DataBind();
        }

        protected void checkOut_Click(object sender, EventArgs e)
        {
            orderController.checkOut(id);
            cartGV.DataBind();
        }
    }
}