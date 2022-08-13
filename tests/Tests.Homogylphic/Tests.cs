using Homoglyphic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests.Homogylphic
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Search_WithHomoglyphText_SingleFind_Success()
        {
            var sets = HomoglyphLoader.LoadSets($"homoglyphs.csv");
            var search = new HomoglyphSearch(sets);

            var result = search.Search("Th1s Is A Test", "This");

            Assert.IsTrue(result.Count == 1 && result[0].Text == "This");
        }

        [TestMethod]
        public void Search_WithHomoglyphText_MultipleFinds_Success()
        {
            var sets = HomoglyphLoader.LoadSets($"homoglyphs.csv");
            var search = new HomoglyphSearch(sets);

            var result = search.Search("Th1s Is A Test", new List<string>() { "This", "Test" });

            Assert.IsTrue(result.Count == 2 && result[0].Text == "This" && result[1].Text == "Test");
        }

        [TestMethod]
        public void Search_WithoutHomoglyphText_SingleFind_Success()
        {
            var sets = HomoglyphLoader.LoadSets($"homoglyphs.csv");
            var search = new HomoglyphSearch(sets);

            var result = search.Search("This Is A Test", "This");

            Assert.IsTrue(result.Count == 1 && result[0].Text == "This");
        }

        [TestMethod]
        public void Search_WithoutHomoglyphText_MultipleFinds_Success()
        {
            var sets = HomoglyphLoader.LoadSets($"homoglyphs.csv");
            var search = new HomoglyphSearch(sets);

            var result = search.Search("This Is A Test", new List<string>() { "This", "Test" });

            Assert.IsTrue(result.Count == 2 && result[0].Text == "This" && result[1].Text == "Test");
        }

        [TestMethod]
        public void Search_WithoutResults_SingleFind_Success()
        {
            var sets = HomoglyphLoader.LoadSets($"homoglyphs.csv");
            var search = new HomoglyphSearch(sets);

            var result = search.Search("This Is A Test", "Hello");

            Assert.IsTrue(result.Count == 0);
        }
    }
}
