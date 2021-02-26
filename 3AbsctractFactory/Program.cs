using System;

namespace _3AbsctractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DbFactory fac = new SQLFactory();
            var cmd = fac.CreateCommand();
            cmd.Open();

            var conn = fac.CreateConnection();
            conn.Execute();
        }
    }
}
