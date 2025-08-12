using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    internal class NoDiscount : Discount
    {
        public NoDiscount() {
            Name = "No descount";
        
        }
        public override decimal CalculateDiscaount(decimal price, int quantity)
        {
            return 0;
        }
    }
}
