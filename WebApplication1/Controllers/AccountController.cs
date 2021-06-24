using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            if (avm.account.Username.Equals("rj") && avm.account.Password.Equals("123"))

            {
                Session["username"] = avm.account.Username;
                return View("Welcome");
            }
            else
            {
               
            }
            ViewBag.Error = "Invalid Account";
            return View("Index");
        }
            public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}