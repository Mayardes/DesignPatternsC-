using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Document : File, IPrintable
    {
        public void Printable()
        {
            Console.WriteLine("this file is printable");
        }
    }
}
