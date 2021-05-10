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
        // GET: ApiPublic
        public async Task<ActionResult> ListApiPublic()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://digimon-api.vercel.app/api/digimon");
            var listaDigimons = JsonConvert.DeserializeObject<List<DigimonView>>(json);
            return View(listaDigimons);
        }
    }
}