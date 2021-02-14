using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class File
    {
        private int _sizeFile;
        private string _description;

        public int SizeFile
        {
            get { return this._sizeFile;}
            set { this._sizeFile = value;}
        }

        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public void Abrir()
        {
            Console.WriteLine("Open file " + this._description);
        }

    }
}
