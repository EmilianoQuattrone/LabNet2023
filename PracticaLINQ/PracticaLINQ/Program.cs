using EF.Entidades;
using EF.Logica.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerLogica customerLogica = new CustomerLogica();

            IEnumerable<CustomerDtos> customers = customerLogica.ObtenerTodo();

            var query = customers.Select(c => c.Nombre);

            var query1 = from c in customers select c.Id;

            foreach (var item in query)
            {
                Console.WriteLine($"Query: {item}");
            }

            foreach (var item in query1) 
            { 
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}