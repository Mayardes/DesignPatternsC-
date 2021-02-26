using System;

namespace _2AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory factory = new SQLFactory();
            var conn = factory.CreateDBConnection();
            conn.Execute();

            var cmd = factory.CreateDBCommand();
            cmd.Open();
        }
    }
}
