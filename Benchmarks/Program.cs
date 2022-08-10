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
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Becnhmarks>();
        }
    }
}
