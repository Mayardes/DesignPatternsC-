using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Car : MeansOfTransportation
    {
        public string Brand { get; set; }

        public override void ToMove()
        {
            Console.WriteLine(Brand + " " + Model + " is moving");
        }
    }
}
