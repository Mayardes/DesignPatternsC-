using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class DbAbsFactory
    {
        public abstract DbConnection CreateConnection();
        public abstract DbCommand CreateCommand();
    }
}
