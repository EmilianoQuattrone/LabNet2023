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

        public void Post([FromBody] string value)
        {
        }

        public void Put(int id, [FromBody] string value)
        {
        }

        public void Delete(int id)
        {
        }
    }
}