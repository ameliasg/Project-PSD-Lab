using ProjectPSD.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPSD.Controllers
{
    public class HomeController
    {
        UserHandler userHandler = new UserHandler();
        public string welcome(int id)
        {
            if (id > 0)
            {
                return "UserName : " + userHandler.getNameByID(id) + "<br>Role:" + userHandler.getRoleByID(id);
            }
            return "";
        }
    }
}