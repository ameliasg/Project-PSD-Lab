using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class ManageMakeupPage : System.Web.UI.Page
    {
        AdminController adminController = new AdminController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                refreshGV();
            }
        }
        private void refreshGV()
        {
            makeupBrandGV.DataSource = adminController.getBrandList();
            makeupTypeGV.DataSource = adminController.getTypeList();
            makeupGV.DataSource = adminController.getMakeupList();
            makeupGV.DataBind();
            makeupTypeGV.DataBind();
            makeupBrandGV.DataBind();
        }

        protected void rowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupGV.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Admin/MakeupPage.aspx?id=" + id + "&state=edit");
            refreshGV();
        }

        protected void rowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupGV.Rows[e.RowIndex];
            string id = row.Cells[0].Text.ToString();
            adminController.removeMakeup(Convert.ToInt32(id));
            refreshGV();
        }

        protected void newMU_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/MakeupPage.aspx?state=new");
            refreshGV();
        }

        protected void newMUT_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/MakeupTypePage.aspx?state=new");
        }

        protected void newMUB_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/MakeupBrandPage.aspx?state=new");  
        }

        protected void muTypeEdit(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupTypeGV.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Admin/MakeupTypePage.aspx?id=" + id + "&state=edit");
            refreshGV();
        }
        protected void muBrandEdit(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupBrandGV.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text.ToString();
            Response.Redirect("~/Views/Admin/MakeupBrandPage.aspx?id=" + id + "&state=edit");
            refreshGV();
        }
    }
}