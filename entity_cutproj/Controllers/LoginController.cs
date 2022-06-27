using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using entity_cutproj.DataAcess;
using entity_cutproj.Models;

namespace entity_cutproj.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Authenticate()
        {
            return View("Login");
        }
        public ActionResult Validate()
        {
            


                string userName = Request.Form["txtuser"].Trim();
                string password = Request.Form["txtpwd"].Trim();
                custdal dal = new custdal();

                List<Login> users = (from u in dal.Logins
                                     where ((u.UserEmail == userName)
                                     && (u.Password == password))
                                     select u).ToList<Login>();
                //return View("Login");

                if (users.Count == 1)
                {
                    FormsAuthentication.SetAuthCookie("Cookie", true);
                    return View("GotoHome");
                }
                else
                {
                    return View("Login");
                }
            
           
                
            

        }
    }
}