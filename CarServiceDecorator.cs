using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal abstract class CarServiceDecorator : ICarService
    {
        private ICarService carObj { get; set; }

        public CarServiceDecorator() { }


        public  double GetCost()
        {
            return carObj.GetCost();
        }


    }
}
