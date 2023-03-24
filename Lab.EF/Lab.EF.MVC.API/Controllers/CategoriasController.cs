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

        public IEnumerable<CategoriasDto> Get()
        {
            return _categoriasLogica.ObtenerTodos();
        }

        public CategoriasView Get(int id)
        {
            Categories categories = _categoriasLogica.ObtenerUno(id);
            _categoriasView.Id = categories.CategoryID;
            _categoriasView.Nombre = categories.CategoryName;
            _categoriasView.Descripcion = categories.Description;
            return _categoriasView;
        }

        public void Post([FromBody] CategoriasView categoriasView)
        {
            CategoriasDto categoriasDto = new CategoriasDto()
            {
                Nombre = categoriasView.Nombre,
                Descripcion = categoriasView.Descripcion
            };
            _categoriasLogica.Add(categoriasDto);
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