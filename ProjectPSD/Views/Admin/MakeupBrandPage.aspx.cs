using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class MakeupBrandPage : System.Web.UI.Page
    {
        int id = -1;
        AdminController adminController = new AdminController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["id"] != null) id = Convert.ToInt32(Request["id"]);
            if (!IsPostBack)
            {
                if (id != -1)
                {
                    brandTB.Text = adminController.getBrandByID(id);
                    ratingTB.Text = adminController.getBRatingByID(id);
                }
            } 
        }
        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageMakeupPage.aspx");
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            string brandName = brandTB.Text;
            int rating = Convert.ToInt32(ratingTB.Text);
            string state = Request["state"];
            string err = adminController.makeupBrandValidation(id, brandName, state,rating);
            if (err != "")
            {
                errMsg.Text = err;
            }
            Response.Redirect("~/Views/Admin/ManageMakeupPage.aspx");
        }
    }
}