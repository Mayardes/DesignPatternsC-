using System;
using System.Collections.Generic;
using System.Text;

namespace _1AbstractFactory
{
    public class SQLCommmand : DBCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executing SQLCommand");
        }
    }
}
