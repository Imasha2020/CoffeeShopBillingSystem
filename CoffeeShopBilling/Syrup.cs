using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class Syrup : BaseDecorator
    {
        public Syrup(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 50 * 1.1;
        }

        public override string GetDescription()
        {
            if (base.GetDescription() == "")
            {
                return base.GetDescription() + "Syrup";
            }
            else
            {
                return base.GetDescription() + ",Syrup";
            }

        }
    }
}
