using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        int id;
        UserController userController = new UserController();
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
                usernameTB.Text = userController.getName(id);
                emailTB.Text = userController.getEmail(id);
                genderTB.Text = userController.getGender(id);
                DOBTB.Text = userController.getDOB(id).ToString();
            }
        }
        protected void editBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfileEditPage.aspx?");
        }

        protected void cPassBtn_Click(object sender, EventArgs e)
        {
            changePass.Style["display"] = "block";
        }

        protected void savePass_Click(object sender, EventArgs e)
        {
            string op = currPass.Text;
            string np = newPass.Text;
            errMsg.Text = userController.changePassword(id, np, op);
            Thread.Sleep(1000);
            if (id == 1)
            {
                Response.Redirect("~/Views/Admin/adminHome.aspx");
            }
            else
            {
                Response.Redirect("~/Views/User/userHome.aspx");
            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            if(id == 1)
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