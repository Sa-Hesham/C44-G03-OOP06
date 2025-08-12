using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    internal class FlatDiscount : Discount
    {
        private readonly decimal amount;

        public FlatDiscount( decimal amount)
        {
            this.amount = amount;
            Name= $"Percentage Discount ({amount}%)";
        }
        public override decimal CalculateDiscaount(decimal price, int quantity)
        {
            return amount * Math.Min(quantity, 1);
        }
    }
}
