using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public class OracleConnection : DBConnection
    {
        public override void Execute()
        {
            Console.WriteLine("Oracle connection is running...");
        }
    }
}
