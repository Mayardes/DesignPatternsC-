using Polymorphism;
using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            MeansOfTransportation car = new Car()
            {
                Brand = "Volkswagen",
                Model = "nivus"
            };

            car.ToMove();

            MeansOfTransportation air = new Airplane()
            {
                Model = "Boeing 787"
            };

            air.ToMove();
        }
    }
}
