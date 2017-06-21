using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace IdentityManagerMVC.Controllers
{
    public class IdentityManagerController : Controller
    {
        // GET: IdentityManager
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            if(username == "admin" && password == "pass")
            {
                var claims = new Claim[]
                {
                    new Claim("name", "David"),
                    new Claim("role", "Adminssss"),  

                };
                var id = new ClaimsIdentity(claims, "Cookies");
                Request.GetOwinContext().Authentication.SignIn(id);
                return Redirect(returnUrl);
            }
            ViewBag.TheResult = true;
            return View();
        }
    }
}