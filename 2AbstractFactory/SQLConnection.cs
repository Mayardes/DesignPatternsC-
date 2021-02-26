using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public class SQLConnection : DBConnection
    {
        public override void Execute()
        {
            Console.WriteLine("Executing SQLConnection");
        }
    }
}
