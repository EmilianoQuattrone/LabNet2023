using Lab.EF.Entidades;
using Lab.EF.Logica;
using Lab.EF.Logica.Categorias;
using Lab.EF.MVC.Models;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Lab.EF.MVC.API.Controllers
{
    [EnableCors("*","*","*")]
    public class CategoriasController : System.Web.Http.ApiController
    {
        private CategoriasLogica _categoriasLogica = new CategoriasLogica();
        private CategoriasView _categoriasView = new CategoriasView();
        private CategoriasDto _categoriasDto = new CategoriasDto();


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
                if (ModelState.IsValid)
                {
                    _categoriasDto.Nombre = categoriasView.Nombre;
                    _categoriasDto.Descripcion = categoriasView.Descripcion;
                    _categoriasLogica.Add(_categoriasDto);
                    //id devuelve 0 por que es un insertar
                    return CreatedAtRoute("DefaultApi", new { id = categoriasView }, 
                        categoriasView);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {
                return BadRequest("No se puedo insertar la categoria.");
            }
        }

        public IHttpActionResult Put(int id, [FromBody] CategoriasView categoriasView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Categories categories = _categoriasLogica.ObtenerUno(id);
                    if (categories.CategoryID == categoriasView.Id)
                    {
                        _categoriasDto.Id = categoriasView.Id;
                        _categoriasDto.Nombre = categoriasView.Nombre;
                        _categoriasDto.Descripcion = categoriasView.Descripcion;

                        _categoriasLogica.Modificar(_categoriasDto);
                    }
                    return Ok(_categoriasDto);
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception)
            {
                return BadRequest("El id no existe");
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                Categories categories = _categoriasLogica.ObtenerUno(id);
                _categoriasLogica.Eliminar(categories.CategoryID);
                return Ok("La categoria se elimino.");
            }
            catch (Exception)
            {
                return BadRequest("El id no existe");
            }
        }
    }
}