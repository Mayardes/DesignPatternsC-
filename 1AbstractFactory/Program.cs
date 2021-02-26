using System;

namespace _1AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
           DBFactory db = new SQLFactory();
           var cmd = db.CreateCommand();
           cmd.Execute();

           var conn = db.CreateConnection();
            conn.Open();

        }
    }
}
