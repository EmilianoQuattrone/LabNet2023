using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Data
{
    public abstract class NorthwindLogica
    {
        protected readonly NorthwindContext northwindContext;

        public NorthwindLogica()
        {
            northwindContext = new NorthwindContext();
        }
    }
}
