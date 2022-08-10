using System.Collections.Generic;

namespace Homoglyphic
{
    public class HomoglyphSearch
    {
        private List<HashSet<int>> _homoglyphSets;

        public HomoglyphSearch(List<HashSet<int>> homoglyphPairs)
        {
            _homoglyphSets = homoglyphPairs;
        }

        public List<SearchResult> Search(string text, List<string> findList)
        {
            var results = new List<SearchResult>();
            var searchInCodePoints = new CodePoints(text);

            foreach (var find in findList)
            {
                results.AddRange(Search(text, find));
            }

            return results;
        }

        public List<SearchResult> Search(string text, string find)
        {
            var textPoints = new CodePoints(text);
            var findPoints = new CodePoints(find);
            var results = new List<SearchResult>();
            var lastIndex = text.Length - find.Length;

            for (var i = 0; i <= lastIndex; i++)
            {
                if (HasTextAtIndex(textPoints, findPoints, i))
                    results.Add(new SearchResult(i, textPoints.Text.Substring(i, findPoints.Length), findPoints.Text));
            }

            return results;
        }

        private bool HasTextAtIndex(CodePoints textPoints, CodePoints findPoints, int index)
        {
            for (var i = 0; i < findPoints.Length; i++)
            {
                var textChar = textPoints[index + i];
                var findCharUpper = char.ToUpper(char.ConvertFromUtf32(findPoints[i])[0]);
                var findCharLower = char.ToLower(char.ConvertFromUtf32(findPoints[i])[0]);

                if (!HasCharAtIndex(textChar, findCharUpper) && !HasCharAtIndex(textChar, findCharLower))
                    return false;
            }

            return true;
        }

        private bool HasCharAtIndex(int textChar, int findChar)
        {
            foreach (var set in _homoglyphSets)
            {
                if (set.Contains(findChar))
                    return set.Contains(textChar);
            }

            return false;
        }
    }
}
