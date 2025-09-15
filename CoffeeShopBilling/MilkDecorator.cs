using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public class MilkDecorator : BaseDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        { 
        }

        public override double GetCost()
        {
            return base.GetCost() + 30 * 1.1;
        }

        public override string GetDescription()
        {
            if (base.GetDescription() == "")
            {
                return base.GetDescription() + "Milk";
            }
            else {
                return base.GetDescription() + ",Milk";
            }
                
        }
    }
}
