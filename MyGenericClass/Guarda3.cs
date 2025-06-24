using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T[] items = new T[3];

        public Guarda3()
        {

        }

        public void SetItem(int index, T item)
        {
            if (index < 0 || index > 2)
                throw new IndexOutOfRangeException();
            items[index] = item;
        }

        public T GetItem(int index)
        {
            if (index < 0 || index > 2)
                throw new IndexOutOfRangeException();
            return items[index];
        }
    }
}