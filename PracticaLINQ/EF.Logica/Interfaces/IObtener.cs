using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logica.Interfaces
{
    public interface IObtener<T>
    {
        IEnumerable<T> ObtenerConsulta();   
    }
}