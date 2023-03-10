using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Data
{
    public abstract class Northwind : NorthwindContext
    {
        protected readonly NorthwindContext northwindContext;

        public Northwind()
        {
            northwindContext = new NorthwindContext();
        }
    }
}
