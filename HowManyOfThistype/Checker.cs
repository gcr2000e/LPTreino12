using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items), "The collection cannot be null.");
            }

            return items.Count(item => item is T);
        }
    }
}