using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Notebook
    {
        private string _name;
        public Notebook(string name)
        {
            _name = name;
        }
        public string GetName
        {
            get {  return this._name;}
        }

        public USB Porta1 { get; set; }
        public USB Porta2 { get; set; }
        public USB Porta3 { get; set; }



    }
}
