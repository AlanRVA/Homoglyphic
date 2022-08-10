using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Homoglyphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Becnhmarks
{
    [MemoryDiagnoser]
    [RankColumn]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class Becnhmarks
    {
        private HomoglyphSearch _homoglyphSearch;

        [GlobalSetup]
        public void Setup()
        {
            var sets = HomoglyphLoader.LoadSets(@"C:\inetpub\wwwroot\Homoglyphic\homoglyphs.csv");
            _homoglyphSearch = new HomoglyphSearch(sets);
        }

        [Benchmark]
        public void Search()
        {
            var result = _homoglyphSearch.Search("Th1s Is A Test", "This");
        }

        [Benchmark]
        public void LongSearch()
        {
            var result = _homoglyphSearch.Search("Th1s Is A Test Th1s Is A Test Th1s Is A Test Th1s Is A Test Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test Th1s Is A Test Th1s Is A Test Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf Th1s Is A Test Th1s Is A Test dasf asdfadsfdsf sdfadsf asdfs fasdf asdfadsf asdf f sadfaf sadfsadfasdfasdf sdafds fdsf", "This");
        }
    }
}
