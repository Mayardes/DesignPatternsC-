using System;
using System.Collections.Generic;
using System.Text;

namespace _1AbstractFactory
{
    public class SQLFactory : DBFactory
    {
        public override DBCommand CreateCommand()
        {
            return new SQLCommmand();
        }

        public override DBConnection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}
