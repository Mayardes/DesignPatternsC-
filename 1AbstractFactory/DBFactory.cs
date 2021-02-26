using System;
using System.Collections.Generic;
using System.Text;

namespace _1AbstractFactory
{
    public abstract class DBFactory
    {
        public abstract DBCommand CreateCommand();
        public abstract DBConnection CreateConnection();

        public abstract OracleCommand CreateOracleCommand();
        public abstract OracleConnection CreateOracleConnection();
    }
}
