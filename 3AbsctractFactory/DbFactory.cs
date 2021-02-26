using System;
using System.Collections.Generic;
using System.Text;

namespace _3AbsctractFactory
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();
        public abstract DbCommand CreateCommand();
    }
}
