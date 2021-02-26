using System;
using System.Collections.Generic;
using System.Text;

namespace _3AbsctractFactory
{
    public class SQLConnection : DbConnection
    {
        public override void Execute()
        {
            Console.WriteLine("Executing DbConnection...");
        }
    }
}
