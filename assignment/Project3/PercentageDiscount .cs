using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Project3
{
    public class PercentageDiscount : Discount
    {

        private decimal percentage;

        public PercentageDiscount( decimal percentage)
        {
            this .percentage = percentage;
            Name = $"Percentage Discount ({percentage}%)";
        }
        public override decimal CalculateDiscaount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100m);
        }
    }
}
