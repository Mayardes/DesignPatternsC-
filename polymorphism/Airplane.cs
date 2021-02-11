using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Airplane : MeansOfTransportation
    {
        public override void ToMove()
        {
            Console.WriteLine(Model + " is flying");
        }
    }
}
