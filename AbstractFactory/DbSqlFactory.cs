using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class DbSqlFactory : DbAbsFactory
    {
        public override DbCommand CreateCommand()
        {
            return new SQLCommand();
        }

        public override DbConnection CreateConnection()
        {
            return new SQLConnection();
        }
    }
}
