using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student : People
    {
        public int Register { get; set; }

        public void ToStudy()
        {
            Console.WriteLine(Name + " is Studying");
        }

        public override void ToAwake()
        {
            Console.WriteLine(Name + "is still sleeping");
        }
    }
}
