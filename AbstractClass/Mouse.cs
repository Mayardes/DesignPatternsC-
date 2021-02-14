using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Mouse : USB
    {
        public override void Plugar()
        {
            Console.WriteLine("Plugando o Mouse");
        }
    }
}
