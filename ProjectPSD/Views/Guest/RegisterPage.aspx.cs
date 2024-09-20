using ProjectPSD.Controllers;
using ProjectPSD.Factories;
using ProjectPSD.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GenderRBL.SelectedIndex = 0;
            DOB.SelectedDate = DateTime.Today; // set dob to today
        }
        UserController userController = new UserController();
        UserFactory userFactory= new UserFactory();
        protected void toLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/LoginPage.aspx");
        }
        protected void register_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string email = emailTB.Text;
            string gender = GenderRBL.SelectedValue;
            string password = passwordTB.Text;
            string cfPassword = cfPasswordTB.Text;
            DateTime dob = DOB.SelectedDate;
            string err = userController.registerValidation(username, email, gender, password, cfPassword, dob);
            if (err.Equals(""))
            {
                Response.Redirect("~/Views/Guest/LoginPage.aspx");
            }
            errMsg.Text = err;   
        }
    }
}