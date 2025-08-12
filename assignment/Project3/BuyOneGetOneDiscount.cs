using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    internal class BuyOneGetOneDiscount:Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = $"  Buy One Get One Discount  to get 50% off on second item";
        }

        public override decimal CalculateDiscaount(decimal price, int quantity)
        {
            if (quantity <= 1)
                return 0;

            return (price / 2) * (quantity / 2);

        }
    }
}
