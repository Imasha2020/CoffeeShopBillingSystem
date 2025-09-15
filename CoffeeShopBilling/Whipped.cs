using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class Whipped : BaseDecorator
    {
        public Whipped(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 70 * 1.1;
        }

        public override string GetDescription()
        {
            if (base.GetDescription() == "")
            {
                return base.GetDescription() + "Whipped-Cream";
            }
            else
            {
                return base.GetDescription() + ",Whipped-Cream";
            }

        }
    }
}
