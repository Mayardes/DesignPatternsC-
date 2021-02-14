using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class USB
    {
        public abstract void Plugar();
        public void Desconectar()
        {
            Console.WriteLine("");
        }
    }
}
