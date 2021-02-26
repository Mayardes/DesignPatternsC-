using System;
using System.Collections.Generic;
using System.Text;

namespace _1AbstractFactory
{
    public class SQLConnection : DBConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opening connection SQLConnection");
        }
    }
}
