using System;
using System.Collections.Generic;
using System.Text;

namespace _1AbstractFactory
{
    public abstract class OracleConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Method Open Oracle has been called");
        }
    }
}
