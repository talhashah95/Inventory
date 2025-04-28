using Invent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashBoard()
        {
            Equipment.LstEquipment();
            return View();
        }

    }
}