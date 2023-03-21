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
        private CategoriasView _categoriasView = new CategoriasView();

        public ActionResult ObtenerCategorias()
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
                return RedirectToAction("ObtenerCategorias", "Categorias");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index","Error");
            }
        }

        public ActionResult EliminarCategoria(int id)
        {
            try
            {
                var entidad = _categoriasLogica.ObtenerUno(id);

                _categoriasView.Id = entidad.CategoryID;
                _categoriasView.Nombre = entidad.CategoryName;
                _categoriasView.Descripcion = entidad.Description;

                return View(_categoriasView);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult EliminarCategoria(CategoriasView categoriasView)
        {
            try
            {              
                _categoriasLogica.Eliminar(categoriasView.Id);
                return RedirectToAction("ObtenerCategorias");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}