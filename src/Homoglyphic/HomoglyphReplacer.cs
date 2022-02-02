using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homoglyphic
{
    public class HomoglyphReplacer
    {
        private List<HomoglyphPair> _homoglyphPairs;

        public HomoglyphReplacer(List<HomoglyphPair> homoglyphPairs)
        {
            _homoglyphPairs = homoglyphPairs;
        }

        public string Replace(string input)
        {
            var output = new List<string>(input.Length);
            var comparer = new CompareHomoglyphPairs();
            int pairIdx;

            for (var i = 0; i < input.Length; i++)
            {
                pairIdx = _homoglyphPairs.BinarySearch(
                    new HomoglyphPair { HomoglyphUnicodePoint = char.ConvertToUtf32(input, i) },
                    comparer);

                output.Add(pairIdx > -1 ? _homoglyphPairs[pairIdx].BaseChar : input.Substring(i, 1));

                if (char.IsSurrogatePair(input, i))
                    i++;
            }

            return string.Concat(output);
        }
    }
}
