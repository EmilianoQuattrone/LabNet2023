using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.Categorias;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Lab.EF.MVC.API.Controllers
{
    public class CategoriasController : System.Web.Http.ApiController
    {
        private CategoriasLogica _categoriasLogica = new CategoriasLogica();
        private CategoriasView _categoriasView = new CategoriasView();

        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_categoriasLogica.ObtenerTodos());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo obtener las Categorias");
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                Categories categories = _categoriasLogica.ObtenerUno(id);
                _categoriasView.Id = categories.CategoryID;
                _categoriasView.Nombre = categories.CategoryName;
                _categoriasView.Descripcion = categories.Description;
                return Ok(_categoriasView);
            }
            catch (Exception)
            {
                return BadRequest("No existe una categoria con ese Id.");
            }
        }

        public IHttpActionResult Post([FromBody] CategoriasView categoriasView)
        {
            try
            {
                CategoriasDto categoriasDto = new CategoriasDto()
                {
                    Nombre = categoriasView.Nombre,
                    Descripcion = categoriasView.Descripcion
                };
                _categoriasLogica.Add(categoriasDto);
                //id devuelve 0 por que es un insertar
                return CreatedAtRoute("DefaultApi", new { id = categoriasView }, categoriasView);
            }
            catch (Exception)
            {

                return BadRequest("No se puedo insertar la categoria.");
            }
        }

        public void Put(int id, [FromBody] CategoriasView categoriasView)
        {
            if (id == categoriasView.Id)
            {
                CategoriasDto categoriasDto = new CategoriasDto()
                {
                    Id = categoriasView.Id,
                    Nombre = categoriasView.Nombre,
                    Descripcion = categoriasView.Descripcion
                };
                _categoriasLogica.Modificar(categoriasDto);
            }
        }

        public void Delete(int id)
        {
            _categoriasLogica.Eliminar(id);
        }
    }
}