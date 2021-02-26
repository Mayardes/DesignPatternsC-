using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public class SQLFactory : DBFactory
    {
        public override DBCommand CreateDBCommand()
        {
            return new SQLCommand();
        }

        public override DBConnection CreateDBConnection()
        {
            return new SQLConnection();
        }

    }
}
