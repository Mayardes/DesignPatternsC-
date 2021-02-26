using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SQLConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opening Connection");
        }
    }
}
