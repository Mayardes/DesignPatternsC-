using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public abstract class DBFactory
    {
        public abstract DBCommand CreateDBCommand();
        public abstract DBConnection CreateDBConnection();

        public abstract OracleCommand CreateOracleCommand();
        public abstract OracleConnection CreateOracleConnection();
    }
}
