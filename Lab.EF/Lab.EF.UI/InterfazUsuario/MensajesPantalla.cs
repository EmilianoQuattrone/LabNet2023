using Lab.EF.Entidades;
using Lab.EF.UI.OtrasFuncionalidades;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Lab.EF.UI.InterfazUsuario
{
    public class MensajesPantalla
    {
        public static void MenuInicio()
        {
            Console.WriteLine("----Menu Principal----");
            LimpiarPantalla.SaltoLinea();
            Console.WriteLine("Presione 1 - Listar Empleados");
            Console.WriteLine("Presione 2 - Listar Categorias");
            LimpiarPantalla.SaltoLinea();
            Console.WriteLine("Presione 3 - Ingresar nueva Categoria");
            Console.WriteLine("Presione 4 - Modificar Categoria");
            Console.WriteLine("Presione 5 - Eliminar Categoria");
            Console.WriteLine("Presione 0 - Salir");
        }

        public static void MenuFinPrograma()
        {
            Console.WriteLine("Fin del Programa...");
            Console.ReadKey();
        }

        public static void VolverAIntentarlo()
        {
            Console.WriteLine("¿Volver a intentarlo? \nPresione 1 para volver a intentar." +
                "\nPresione cualquier NUMERO para salir del programa.");
        }

        public static void MensajeListaEmpleado(Employees item)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName}");
        }

        public static void MensajeEmpleados()
        {
            LimpiarPantalla.Limpiar();
            Console.WriteLine("Empleados: ");
        }
        public static void ListadoCategorias(Categories item)
        {
            Console.WriteLine($"ID: {item.CategoryID} - Nombre: {item.CategoryName} - Descripcion: {item.Description}");
        }

        public static void MensajeCategorias()
        {
            LimpiarPantalla.Limpiar();
            Console.WriteLine("Categorias: ");
        }
        public static void MensajeDeConfirmacion()
        {
            Console.WriteLine("Categoria guardada.");
        }

        public static void MensajeDeConfirmacion2()
        {
            Console.WriteLine("Categoria modificada.");
        }

        public static void MensajeDeConfirmacion3()
        {
            Console.WriteLine("Categoria eliminada.");
        }

        public static void MensajeCategoriaModificacion()
        {
            Console.WriteLine("Modificar categoria: ");
            LimpiarPantalla.Limpiar();
        }

        public static void MensajeCategoriaEliminar()
        {
            Console.WriteLine("Eliminar categoria: ");
            LimpiarPantalla.Limpiar();
        }

        public static void MensajeIngreseCategoria()
        {
            Console.WriteLine("Ingrese una nueva Categoria: ");
            LimpiarPantalla.Limpiar();
        }

        public static void MensajeIdCategoria()
        {
            Console.WriteLine("Ingrese identificador: ");
        }

        public static void MensajeDefaul()
        {
            Console.WriteLine("Opcione no valida");
        }
        public static void MensajeNombreCategoria()
        {
            Console.WriteLine("Nombre de la categoria: ");
        }
        public static void MensajeDescripcion()
        {
            Console.WriteLine("Nombre de la descripcion: ");
        }

        public static void MensajeDescripcionCategoria()
        {
            Console.WriteLine("Descripcion: ");
        }

        public static void MensajeSoloLetras()
        {
            Console.WriteLine("Solo admite letras");
        }
        public static void MensajeExcepcionesGenerico(Exception ex)
        {
            Console.WriteLine($"{ex.Message}.");
        }

        public static void MensajeExcepciones(DbEntityValidationException ex)
        {
            string mensaje = "El campo nombre acepta un manximo de letras 15.";
            Console.WriteLine($"{mensaje} \n{ex.Message}");
        }
        public static void MensajeExcepciones2(ArgumentNullException ex)
        {
            Console.WriteLine($"Esta intetando borrar una categoria que no existe.\n{ex.Message}");
        }

        public static void MensajeExcepcion3(InvalidOperationException ex)
        {
            Console.WriteLine($"Esta intentado modificar una categoria que no existe. \n{ex.Message}");
        }

        public static void MensajeExcepcion4(DbUpdateException ex)
        {
            Console.WriteLine($"Esta intentado eliminar una categoria no permitida por el admin. \n{ex.Message}");
        }
    }
}