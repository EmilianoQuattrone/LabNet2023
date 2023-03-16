using EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logica.Context
{
    public class Northwind
    {
        protected NorthwindContext northwindContext;

        public Northwind() 
        {
            northwindContext = new NorthwindContext();
        }
    }
}