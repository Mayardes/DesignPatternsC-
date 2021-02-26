using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public class SQLCommand :DBCommand
    {
        public override void Open()
        {
            Console.WriteLine("Opening SQLCommand");
        }
    }
}
