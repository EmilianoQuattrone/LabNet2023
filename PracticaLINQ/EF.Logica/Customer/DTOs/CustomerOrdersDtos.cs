using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logica.Customer.DTOs
{
    public class CustomerOrdersDtos
    {
        public string NombreCliente { get; set; }
        public string Region { get; set; }
        public DateTime OrdenFecha { get; set; }
    }
}