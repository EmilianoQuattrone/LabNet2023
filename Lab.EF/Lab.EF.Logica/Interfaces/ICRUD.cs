using System.Collections.Generic;

namespace Lab.EF.Logica
{
    internal interface ICRUD<T>
    {
        List<T> ObtenerTodos();
        void Add(T entidad);
        void Modificar(T entidad);
        void Eliminar(int id);
    }
}