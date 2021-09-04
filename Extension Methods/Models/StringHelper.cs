using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Methods.Models
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            return char.IsUpper(s[0]);
        }
        public static T First<T>(this IEnumerable<T> sequence)
        {
            foreach (T element in sequence)
                return element;
            throw new InvalidOperationException("No elements!");
        }
    }

    static class ObjectHelper
    {
        public static bool IsCapitalized(this object s) => true;
    }
}
