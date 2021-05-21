using EjercicioMVC.MVC.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class DigimonExternalApiLogic
    {
        public async Task<List<Digimon>> GetDigimons()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://digimon-api.vercel.app/api/digimon");
            var listaDigimons = JsonConvert.DeserializeObject<List<Digimon>>(json);
            return listaDigimons;
        }

    }
}
