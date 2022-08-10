using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace Homoglyphic
{
    public class HomoglyphLoader
    {
        public static List<HashSet<int>> LoadSets(string filePath)
        {
            var homoglyphs = new List<HashSet<int>>();
            int[] points;

            foreach (var line in File.ReadAllLines(filePath))
            {
                // Skip comments or blank lines
                if (line.Length == 0 || line[0] == '#')
                    continue;

                points = line.Split(',').Select(x => int.Parse(x, NumberStyles.HexNumber)).ToArray();

                homoglyphs.Add(new HashSet<int>(points));
            }

            return homoglyphs;
        }
    }
}
