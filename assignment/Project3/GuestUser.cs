using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    internal class GuestUser : User
    {
        public GuestUser()
        {
            Name = "guestuser";
        }
        public override Discount GetDiscount()
        {
            return new NoDiscount();
        }
    }
}
