using ProjectPSD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        GuestController guestCtrl = new GuestController();
        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string name = usernameTB.Text;
            string password = passwordTB.Text;
            string resp = guestCtrl.doLogin(name, password);
            
            if (Regex.IsMatch(resp, @"^\d+$")) // check resp integer or not
             {
                if (Request.Cookies["user_cookie"] != null)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);
                }
                if(resp == "1") // admin
                {
                    Session["user"] = 1;
                    Response.Redirect("~/Views/Admin/adminHome.aspx");
                }
                else
                {
                    if (rememberCB.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = resp;
                        cookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(cookie);
                    }
                    Session["user"] = resp;
                    Response.Redirect("~/Views/User/userHome.aspx");
                }
            }
            errMsg.Text = resp;
        }

        protected void RegBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Guest/RegisterPage.aspx");
        }
    }
}