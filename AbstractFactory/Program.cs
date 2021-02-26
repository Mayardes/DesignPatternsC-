using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAbsFactory db = new DbSqlFactory();

            var con = db.CreateConnection();
                con.Open();
            
            var cmd = db.CreateCommand();
            cmd.Execute();
          
        }
    }
}
