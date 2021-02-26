using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public class OracleCommand : DBCommand
    {
        public override void Open()
        {
            Console.WriteLine("oracle command is running...");
        }
    }
}
