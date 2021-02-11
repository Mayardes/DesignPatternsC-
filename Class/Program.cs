using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Calc cal = new Calc();
            int r = cal.Sum(x,y);
            Console.WriteLine(r);
        }

    
    }
}
