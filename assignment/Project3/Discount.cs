using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    public abstract class Discount
    {
        public string? Name { get; set; }


        public abstract decimal CalculateDiscaount(decimal price ,int quantity );

    }
}
