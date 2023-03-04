using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBenchmarkDotNet
{
    public static class Test
    {
        public static string ReplaceFirst(this string str, string search, string replace, StringComparison comparisonType = StringComparison.Ordinal)
        {
            //Check.NotNull(str, nameof(str));

            var pos = str.IndexOf(search, comparisonType);
            if (pos < 0)
            {
                return str;
            }

            return str.Substring(0, pos) + replace + str.Substring(pos + search.Length);
        }

        public static string ReplaceFirst2(this string str, string search, string replace, StringComparison comparisonType = StringComparison.Ordinal)
        {
            //Check.NotNull(str, nameof(str));
            int pos = str.IndexOf(search, comparisonType);
            if (pos < 0)
            {
                return str;
            }

            var searchLength = search.Length;
            var replaceLength = replace.Length;
            var newLength = str.Length - searchLength + replaceLength;

            Span<char> buffer = stackalloc char[newLength];

            // Copy the part of the original string before the search term
            str.AsSpan(0, pos).CopyTo(buffer);

            // Copy the replacement text
            replace.AsSpan().CopyTo(buffer.Slice(pos));

            // Copy the remainder of the original string
            str.AsSpan(pos + searchLength).CopyTo(buffer.Slice(pos + replaceLength));

            return buffer.ToString();
        }
    }
}
