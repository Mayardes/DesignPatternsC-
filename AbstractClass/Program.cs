using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook acer = new Notebook("acer");
            acer.Porta1 = new iPhone();
            acer.Porta1.Plugar();


            acer.Porta2 = new Keyboard();
            acer.Porta2.Plugar();

            acer.Porta3 = new Mouse();
            acer.Porta2.Plugar();
            acer.Porta3.Desconectar();

        }
    }
}
