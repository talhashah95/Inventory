using Invent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invent.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            ViewBag.Message = " ";
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account Model)
        {
            if (String.IsNullOrEmpty(Model.UserName) || String.IsNullOrEmpty(Model.Password))
                ViewBag.Message = "Input needed";
            if (Model.UserName == "Osama" && Model.Password == "123")
            {
                Session["User"] = Model.UserName;
                ViewBag.Message = "Login Success";

            }
            else
            {
                ViewBag.Message = "Login Failed";

            }
            return View();
        }



        public ActionResult Logout()
        {
            Session.Remove("User"); //"User"])
            //Response.Redirect(Url.Action("Login", "Auth"));
            return RedirectToAction("Login");
        }
    }
}