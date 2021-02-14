using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Photo : File, IPrintable, IEditable
    {
        public void Editable()
        {
            Console.WriteLine("File is editable");
        }

        public void Printable()
        {
            Console.WriteLine("File is printable");
        }
    }
}
