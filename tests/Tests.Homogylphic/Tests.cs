using Homoglyphic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Homoglyphic.HomoglyphReplacer;

namespace Tests.Homogylphic
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Replace_AllHomoglyphsWithBaseCharacter_Success()
        {
            var pairs = HomoglyphLoader.LoadPairs($"../../../../Data/homoglyphs.csv");
            var replacer = new HomoglyphReplacer(pairs);

            foreach (var pair in pairs)
            {
                var result = replacer.Replace(char.ConvertFromUtf32(pair.HomoglyphUnicodePoint));

                Assert.AreEqual(pair.BaseChar, result);
            }
        }
    }
}
