using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Publicitaria.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Pedidos()
        {
            ViewBag.Message = "Bienvneido, Aca prodra ralizar su orden de compra.";
            return View();
        }
    }
}