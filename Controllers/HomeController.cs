using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Publicitaria.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Elaborado por: Maria Zamora, Edwin Fuentes y Luis Lombana";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Diseño y Desarrollo web.";

            return View();
        }
    }
}