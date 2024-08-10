using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal class WheelAlign : CarServiceDecorator
    {
        private ICarService _carService { get; set; }
        public WheelAlign(ICarService carService)
        {
            _carService = carService;
        }

        public double GetCost()
        {
            return base.GetCost();
        }
    }
}
