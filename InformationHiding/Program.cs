using System;

namespace InformationHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Fiat");

            car.TurnOn();
            car.ToFillUp();
            car.ToMove();
        }
    }
}
