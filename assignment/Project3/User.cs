using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    public abstract class User
    {
        public string  Name { get; set; }
        public abstract Discount GetDiscount();
    }
}
