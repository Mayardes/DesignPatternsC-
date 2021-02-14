using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document()
            {   Description = "oi1",
                SizeFile = 10
            };
          

            doc.Printable();
            doc.Abrir();

            File file = new MP3()
            {
                Description = "some file",
                SizeFile = 23
            };

            file.Abrir();
        }
    }
}
