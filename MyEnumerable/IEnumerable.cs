using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEnumerable
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T[] itens = new T[3];

        public void SetItem(int i, T item)
        {
            if (i < 0 || i >= 3)
                throw new ArgumentOutOfRangeException(nameof(i), "Index must be 0, 1 or 2.");
            itens[i] = item;
        }

        public T GetItem(int i)
        {
            if (i < 0 || i >= 3)
                throw new ArgumentOutOfRangeException(nameof(i), "Index must be 0, 1 or 2.");
            return itens[i];
        }

        // Implementação de IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in itens)
            {
                yield return item;
            }
        }

        // Implementação não genérica para compatibilidade
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}