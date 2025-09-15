using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public abstract class BaseDecorator : ICoffee
    {
        protected ICoffee coffee;

        public BaseDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }

        public virtual string GetDescription() 
        {
            return coffee.GetDescription();
        }
    }
}
