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
        private readonly string url = "https://jsonplaceholder.typicode.com/users";
        private HttpClient httpClient = new HttpClient();

        // GET: ApiPublica
        public async Task<ActionResult> ConsumirApiPublica()
        {
            var respuesta = await httpClient.GetStringAsync(url);
            var usuariosView = JsonConvert.DeserializeObject<UsuariosView[]>(respuesta);
            return View(usuariosView);
        }
    }
}