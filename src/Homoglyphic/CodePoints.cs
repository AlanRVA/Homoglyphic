using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homoglyphic
{
    public class CodePoints
    {
        private readonly string _text;
        private readonly int[] _codePoints;

        public string Text { get { return _text; } }
        public int Length { get { return _codePoints.Length; } }

        public int this[int i]
        {
            get { return _codePoints[i]; }
            set { _codePoints[i] = value; }
        }

        public CodePoints(string text)
        {
            _text = text;

            var codepointList = new List<int>();

            for (int i = 0; i < text.Length;)
            {
                codepointList.Add(char.ConvertToUtf32(text, i));
                i += char.IsSurrogatePair(text, i) ? 2 : 1;
            }

            _codePoints = codepointList.ToArray();
        }
    }
}
