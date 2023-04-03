using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult ErrorVista()
        {
            return View();
        }

        public ActionResult EliminarSinPermiso() 
        {
            return View();
        }

        public ActionResult UrlConLetras()
        {
            return View();
        }
    }
}