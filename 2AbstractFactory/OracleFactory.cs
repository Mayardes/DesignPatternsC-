using System;
using System.Collections.Generic;
using System.Text;

namespace _2AbstractFactory
{
    public abstract class OracleFactory
    {
        public abstract OracleCommand CreateOracleCommand();
        public abstract OracleConnection CreateOracleConnection();
    }
}
