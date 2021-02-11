using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public abstract class People
    {
        public string Name { get; set; }

        public abstract void ToAwake();

        public virtual void ToSleep()
        {
            Console.WriteLine(Name + " is Sleeping");
        }

        public void test()
        {
            Console.WriteLine("testing");
        }
        
  
    }
}
