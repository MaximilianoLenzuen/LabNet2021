using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioMVC.MVC.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult IndexEmployees()
        {
            return View();
        }

        public ActionResult IndexOrders()
        {
            return View();
        }
    }
}