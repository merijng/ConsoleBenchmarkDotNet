using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBenchmarkDotNet
{
    public static class Test
    {
        public static string ReplaceSubstring(this string str, string search, string replace, StringComparison comparisonType = StringComparison.Ordinal)
        {
            //Check.NotNull(str, nameof(str));

            var pos = str.IndexOf(search, comparisonType);
            if (pos < 0)
            {
                return str;
            }

            return string.Concat(str.Substring(0, pos), replace, str.Substring(pos + search.Length));
        }

        public static string ReplaceSpan(this string str, string search, string replace, StringComparison comparisonType = StringComparison.Ordinal)
        {
            //Check.NotNull(str, nameof(str));
            int pos = str.IndexOf(search, comparisonType);
            if (pos < 0)
            {
                return str;
            }

            var sourceSpan = str.AsSpan();
            return string.Concat(sourceSpan.Slice(0, pos), replace, sourceSpan.Slice(pos + search.Length));
        }
    }
}
