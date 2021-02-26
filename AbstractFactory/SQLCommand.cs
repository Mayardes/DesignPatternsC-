using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class SQLCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executing SqlCommand");
        }
    }
}
