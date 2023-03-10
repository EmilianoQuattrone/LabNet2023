using System;
using System.Data.Entity.Validation;

namespace Lab.EF.UI.InterfazUsuario
{
    public class MensajesPantalla
    {
        public static void MenuInicio()
        {
            Console.WriteLine("----Menu Principal----");
            Console.WriteLine();
            Console.WriteLine("Presione 1 - Listar Empleados");
            Console.WriteLine("Presione 2 - Listar Categorias");
            Console.WriteLine();
            Console.WriteLine("Presione 3 - Ingresar nueva Categoria");
            Console.WriteLine("Presione 4 - Modificar Categoria");
            Console.WriteLine("Presione 5 - Eliminar Categoria");
            Console.WriteLine("Presione 0 - Salir");
        }

        public static void MenuFinPrograma()
        {
            Console.WriteLine("Fin del Programa...");
            Console.ReadLine();
        }

        public static void VolverAIntentarlo()
        {
            Console.WriteLine("¿Volver a intentarlo? \nPresione 1 para volver a intentar." +
                "\nPresione cualquier NUMERO para salir del programa.");
        }

        public static void MensajeEmpleados()
        {
            Console.WriteLine("Empleados: ");
        }

        public static void MensajeCategorias()
        {
            Console.WriteLine("Categorias: ");
        }
        public static void MensajeExcepciones(DbEntityValidationException ex)
        {
            string mensaje = "El campo nombre acepta un manximo de letras 15..";
            Console.WriteLine($"{ex.Message}. \n{mensaje}");
        }

        public static void MensajeIngreseCategoria()
        {
            Console.WriteLine("Ingrese una nueva Categoria: ");
            Console.WriteLine();
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
    }
}