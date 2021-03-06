﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _3AbsctractFactory
{
    public class SQLFactory : DbFactory
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
