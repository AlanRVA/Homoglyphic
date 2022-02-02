using System;
using System.Collections.Generic;
using System.Text;
using static Homoglyphic.HomoglyphReplacer;

namespace Homoglyphic
{
    internal class CompareHomoglyphPairs : IComparer<HomoglyphPair>
    {
        public int Compare(HomoglyphPair x, HomoglyphPair y)
        {
            return x.HomoglyphUnicodePoint.CompareTo(y.HomoglyphUnicodePoint);
        }
    }
}
