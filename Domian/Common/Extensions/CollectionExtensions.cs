using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domian.Entities.Common.Extensions
{
    public static class CollectionExtensions
    {
        public static string Join(this IEnumerable<string> source, char delimiter)
        {
            return string.Join(delimiter, source);
        }

        public static IEnumerable<int> To(this int from, int to)
        {
            return Enumerable.Range(from, to - from + 1);
        }
    }
}
