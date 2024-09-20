using Microsoft.SqlServer.Server;
using ProjectPSD.Controllers;
using ProjectPSD.Models;
using ProjectPSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class updateMakeupPage : System.Web.UI.Page
    {
        int id = 0;
        AdminController adminController = new AdminController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null) id = Convert.ToInt32(Request["id"]);
            if (!IsPostBack)
            {
                typeDDL.DataSource = adminController.getTypes();
                typeDDL.DataBind();
                brandDDL.DataSource = adminController.getBrands();
                brandDDL.DataBind();
                if (id != 0)
                {
                    Makeup mu = adminController.getMakeup(id);
                    name.Text = mu.MakeupName;
                    price.Text = mu.MakeupPrice.ToString();
                    weight.Text = mu.MakeupWeight.ToString();
                    typeDDL.SelectedValue = mu.MakeupType.ToString();
                    brandDDL.SelectedValue = mu.MakeupBrand.MakeupBrandName.ToString();
                }
            }

        }
        protected void saveBtn_Click(object sender, EventArgs e)
        {
            string muName = name.Text;
            int muPrice = Convert.ToInt32(price.Text);
            int muWeight = Convert.ToInt32(weight.Text);
            string type = typeDDL.SelectedValue;
            string brand = brandDDL.SelectedValue;
            string state = Request["state"];
            string err = adminController.makeupValidation(id, muName, muPrice, muWeight, type, brand, state);
            errMsg.Text = err;
            if(err == "") Response.Redirect("~/Views/Admin/ManageMakeupPage.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageMakeupPage.aspx");
        }
    }
}