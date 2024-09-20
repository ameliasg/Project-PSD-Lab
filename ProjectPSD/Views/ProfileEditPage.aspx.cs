using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class ProfileEditPage : System.Web.UI.Page
    {
        UserController userController = new UserController();
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
                usernameTB.Text = userController.getName(id);
                emailTB.Text = userController.getEmail(id);
                GenderRBL.SelectedIndex = 0;
                DOB.VisibleDate = userController.getDOB(id).Date;
                DOB.SelectedDate = userController.getDOB(id).Date;
            }
        }
        protected void saveBtn_Click(object sender, EventArgs e)
        {
            string name = usernameTB.Text;
            string email = emailTB.Text;
            string gender = GenderRBL.SelectedValue;
            DateTime dob = DOB.SelectedDate;
            string err = userController.editValidation(id, name, email, gender, dob);
            if (err.Equals(""))
            {
                Response.Redirect("~/Views/ProfilePage.aspx");
            }
            errMsg.Text = err;
        }
    }
}