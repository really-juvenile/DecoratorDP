namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService car = new CarInspection();
            OilChange carOil = new OilChange();
            WheelAlign carWheel = new WheelAlign(carOil);
            carWheel.GetCost();

        }
    }
}
