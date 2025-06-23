using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T item)
        where T : IComparable<T>
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items), "The collection cannot be null.");
            }

            return items.Where(item => item.CompareTo(item) < 0);
        }
    }
}