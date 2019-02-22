using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{

    abstract public class AbstractTV
    {
        private int _size;
        private int _ports;
        private decimal _price;
        private bool _IsMountable;
        public int Size { get { return _size; } set { _size = value; } }
        public int Ports { get { return _ports; } set { _ports = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public bool IsMountable { get { return _IsMountable; } set { _IsMountable = value; } }


        public abstract void Remote();      //Method of tv that uses a remote

        public AbstractTV(int size, int ports, decimal price, bool IsMountable)
        {
            this._size = size;
            this._ports = ports;
            this._price = price;
            this._IsMountable = IsMountable;
        }
        public AbstractTV(int size, bool IsMountable)
            : this(size, 2, 249.50m, IsMountable)
        {

        }
    }
}
