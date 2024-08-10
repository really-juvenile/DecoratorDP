using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
    internal class OilChange : CarServiceDecorator
    {
        private ICarService _carService { get; set; }
        public OilChange(ICarService carService) 
        {
            _carService = carService;   
        }

        public double GetCost()
        {
            return base.GetCost();
        }
    }

}
