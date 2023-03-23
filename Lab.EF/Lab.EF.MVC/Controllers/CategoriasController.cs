using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.Categorias;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class CategoriasController : Controller
    {

        private CategoriasLogica _categoriasLogica = new CategoriasLogica();
        private CategoriasView _categoriasView = new CategoriasView();

        public ActionResult ObtenerCategorias()
        {
            try
            {
                List<CategoriasDto> categoriasLogicaLista = _categoriasLogica.ObtenerTodos();
                return View(categoriasLogicaLista);
            }
            catch (Exception)
            {
                return RedirectToAction("ErrorVista","Error");
            }
        }

        public ActionResult Insertar()
        {
            try
            {
                return View("InsertarModificarCategoria", new CategoriasView());
            }
            catch (Exception)
            {
                return RedirectToAction("ErrorVista","Error");
            }
        }

        public ActionResult Modificar(int id)
        {
            try
            {
                Categories entidad = _categoriasLogica.ObtenerUno(id);
                CategoriasView view = new CategoriasView()
                {
                    Id = entidad.CategoryID,
                    Nombre = entidad.CategoryName,
                    Descripcion = entidad.Description
                };
                return View("InsertarModificarCategoria", view);
            }
            catch (Exception)
            {
                return RedirectToAction("ErrorVista", "Error");
            }
        }

        [HttpPost]
        public ActionResult InsertarModificarCategoria(CategoriasView view)
        {
            if (ModelState.IsValid)
            {
                if (view.Id > 0)
                {
                    _categoriasLogica.Modificar(new CategoriasDto
                    {
                        Id = view.Id,
                        Nombre = view.Nombre,
                        Descripcion = view.Descripcion,
                    });
                }
                else
                {
                    _categoriasLogica.Add(new CategoriasDto
                    {
                        Nombre = view.Nombre,
                        Descripcion = view.Descripcion,
                    });
                }

                return RedirectToAction("ObtenerCategorias");
            }
            else
            {
                if (view.Id > 0)
                {
                    return View("InsertarModificarCategoria");
                }
                else
                {
                    return View("InsertarModificarCategoria", new CategoriasView());
                }
            }
        }

        public ActionResult EliminarCategoria(int id)
        {
            try
            {
                Categories entidad = _categoriasLogica.ObtenerUno(id);
                CategoriasView view = new CategoriasView()
                {
                    Id = entidad.CategoryID,
                    Nombre = entidad.CategoryName,
                    Descripcion = entidad.Description
                };
                return View(view);
            }
            catch (Exception)
            {
                return RedirectToAction("ErrorVista", "Error");
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
                return RedirectToAction("ErrorVista", "Error");
            }
        }

        public ActionResult VolverPaginaPrincipal()
        {
            return RedirectToAction("ObtenerCategorias");
        }
    }
}