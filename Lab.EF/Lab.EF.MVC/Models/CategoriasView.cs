using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.EF.MVC.Models
{
    public class CategoriasView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "El nombre de categorias no acepta valores numericos")]
        [StringLength(15)]
        public string Nombre { get; set; }
        [RegularExpression("^[^0-9]+$", ErrorMessage = "La descripcion no acepta valores numericos")]
        public string Descripcion { get; set; }
    }
}