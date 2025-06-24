using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
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

        // Novo método para Collection Initializer
        public void Add(T item)
        {
            for (int i = 0; i < itens.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(itens[i], default(T)))
                {
                    itens[i] = item;
                    return;
                }
            }
            // Se não houver espaço, pode ignorar ou lançar exceção
            throw new InvalidOperationException("A coleção já contém 3 elementos.");
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in itens)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}