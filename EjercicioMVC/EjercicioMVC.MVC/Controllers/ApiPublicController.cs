using EjercicioMVC.Logic;
using EjercicioMVC.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EjercicioMVC.MVC.Controllers
{
    public class ApiPublicController : Controller
    {

        DigimonExternalApiLogic logic = new DigimonExternalApiLogic();

        // GET: ApiPublic
        public ActionResult ListApiPublic()
        {
            var digimons = logic.GetDigimons();
            DigimonView dgView = new DigimonView()
            {
                dgView.name = digimon.name,
                dgView.img = digimon.img,
                dgView.Level = digimons.
            }
            return View(list);

        }
    }
}