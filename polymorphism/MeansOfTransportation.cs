using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class MeansOfTransportation
    {
        public string Model { get; set; }
        public abstract void ToMove();
    }
}
