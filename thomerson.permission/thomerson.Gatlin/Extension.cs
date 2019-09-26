using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.Gatlin
{
    public static class Extension
    {
        public static void CheckNullOrEmpty(this string val, string paramName = null)
        {
            if (string.IsNullOrEmpty(val))
                throw new ArgumentNullException($"{paramName ?? "param"}", $"{paramName ?? nameof(val)} can't be null or empty");
        }

        public static void CheckNullParam(this object val, string paramName = null)
        {
            if (val == null)
                throw new ArgumentNullException($"{paramName ?? "param"}", $"{paramName ?? nameof(val)} can't be null");
        }
    }
}
