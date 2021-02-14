using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Keyboard : USB
    {
        public override void Plugar()
        {
            Console.WriteLine("Plugando o teclado");
        }
    }
}
