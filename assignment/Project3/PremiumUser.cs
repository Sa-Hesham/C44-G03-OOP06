using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    public class PremiumUser : User
    {
        public PremiumUser(string name)  {
            Name = name;
                
         }
    
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
