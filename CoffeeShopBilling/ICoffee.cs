using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopBilling
{
    public interface ICoffee
    {
        double GetCost();
        string GetDescription();
    }
}
