using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class ExtraShot : BaseDecorator
    {
        public ExtraShot(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 100 * 1.1;
        }

        public override string GetDescription()
        {
            if (base.GetDescription() == "")
            {
                return base.GetDescription() + "Extra-Shot";
            }
            else
            {
                return base.GetDescription() + ",Extra-Shot";
            }

        }
    }
}
