using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Staff : People
    {
        public string Department { get; set; }

        public void ToWork()
        {
            Console.WriteLine( Name + " is Working");
        }

        public override void ToSleep()
        {
            Console.WriteLine(Name + " is wide awake");
        }

        public override void ToAwake()
        {
            Console.WriteLine("I Awake!");
        }
    }
}
