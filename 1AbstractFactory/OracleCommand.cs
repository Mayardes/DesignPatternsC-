using System;
using System.Collections.Generic;
using System.Text;

namespace _1AbstractFactory
{
    public abstract class OracleCommand : SQLCommmand
    {
        public override void Execute()
        {
            base.Execute();
        }
    }
}
