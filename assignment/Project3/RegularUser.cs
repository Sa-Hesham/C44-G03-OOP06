using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    internal class RegularUser : User
    {
        public RegularUser(string name)
        {
            Name=name; 
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
