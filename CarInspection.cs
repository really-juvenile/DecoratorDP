using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal class CarInspection :ICarService
    {
        public double GetCost()
        {
            return 1000;
        }
    }
}
