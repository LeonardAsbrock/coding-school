using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cars
{
    class Tire
    {
        private int _size;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public Tire(int size)
        {
            this.Size = size;
        }
    }
}
