using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class Sugar : BaseDecorator
    {
        public Sugar(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 10 * 1.1;
        }

        public override string GetDescription()
        {
            if (base.GetDescription() == "")
            {
                return base.GetDescription() + "Sugar";
            }
            else
            {
                return base.GetDescription() + ",Sugar";
            }

        }
    }
}
