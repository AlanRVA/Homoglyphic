using System;
using System.Collections.Generic;
using System.Text;

namespace Homoglyphic
{
    public class SearchResult
    {
        public int Index;
        public string Match;
        public string Text;

        public SearchResult(int index, string match, string text)
        {
            Index = index;
            Match = match;
            Text = text;
        }

        public string ToString()
        {
            return string.Format("\'{0}\' at position {1} matches \'{2}\'", Match, Index, Text);
        }
    }
}
