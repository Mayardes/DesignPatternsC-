using System;
using System.Collections.Generic;
using System.Text;

namespace _3AbsctractFactory
{
    public class SQLCommand : DbCommand
    {
        public override void Open()
        {
            Console.WriteLine("Opening command...");
        }
    }
}
