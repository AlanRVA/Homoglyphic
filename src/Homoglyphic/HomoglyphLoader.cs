using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homoglyphic
{
    public class HomoglyphLoader
    {
        public static List<HomoglyphPair> LoadPairs(string filePath)
        {
            var homoglyphs = new List<HomoglyphPair>();
            var comparer = new CompareHomoglyphPairs();
            int[] points;

            foreach (var line in File.ReadAllLines(filePath))
            {
                // Skip comments or blank lines
                if (line.Length == 0 || line[0] == '#')
                    continue;

                points = line.Split(',').Select(x => int.Parse(x, System.Globalization.NumberStyles.HexNumber)).ToArray();

                for (var i = 1; i < points.Length; i++)
                {
                    homoglyphs.Add(new HomoglyphPair { HomoglyphUnicodePoint = points[i], BaseChar = char.ConvertFromUtf32(points[0]) });
                }
            }

            homoglyphs.Sort(comparer);

            return homoglyphs;
        }
    }
}
