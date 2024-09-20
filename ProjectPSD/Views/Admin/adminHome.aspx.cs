using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class adminHome : System.Web.UI.Page
    {
        AdminController adminController= new AdminController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                customerGV.DataSource = adminController.getCustomerList();
                customerGV.DataBind();
            }
        }
    }
}