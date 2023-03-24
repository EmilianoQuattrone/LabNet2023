using Lab.EF.MVC.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.API.Controllers
{
    public class ApiPublicaController : Controller
    {
        public string url = "https://jsonplaceholder.typicode.com/users";
        // GET: ApiPublica
        public async Task<ActionResult> ConsumirApiPublica()
        {
            var httpClient = new HttpClient();
            //json de momento devuelve un string por el metodo
            var respuesta = await httpClient.GetStringAsync(url);
            var modelo = JsonConvert.DeserializeObject<UsuariosView[]>(respuesta);
            return View(modelo);
        }
    }
}