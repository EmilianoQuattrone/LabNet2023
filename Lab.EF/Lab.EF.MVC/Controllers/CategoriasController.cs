using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.Categorias;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class CategoriasController : Controller
    {

        private CategoriasLogica _categoriasLogica = new CategoriasLogica();

        public ActionResult Index()
        {
            List<CategoriasDto> categoriasLogicaLista = _categoriasLogica.ObtenerTodos();
            return View(categoriasLogicaLista);
        }

        public ActionResult InsertarCategoria() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertarCategoria(CategoriasView categoriesView)
        {
            try
            {
                CategoriasDto nuevaCategoria = new CategoriasDto
                {
                    Nombre = categoriesView.Nombre,
                    Descripcion = categoriesView.Descripcion,
                };
                _categoriasLogica.Add(nuevaCategoria);
                return RedirectToAction("Index", "Categorias");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index","Error");
            }
        }
    }
}