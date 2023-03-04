using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleBenchmarkDotNet
{
    //[SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    //[SimpleJob(RuntimeMoniker.NetCoreApp30)]
    //[SimpleJob(RuntimeMoniker.NativeAot70)]
    // [SimpleJob(RuntimeMoniker.Mono)]
    [MemoryDiagnoser]
    public class Tester
    {
        [GlobalSetup]
        public void Setup()
        {
        }

        [Benchmark]
        public void ReplaceFirst_Tests()
        {
            "Test string".ReplaceFirst("s", "X");
            "Test test test".ReplaceFirst("test", "XX");
            "Test test test".ReplaceFirst("test", "XX", StringComparison.OrdinalIgnoreCase);
        }

        [Benchmark]
        public void ReplaceFirst2_Tests()
        {
            "Test string".ReplaceFirst2("s", "X");
            "Test test test".ReplaceFirst2("test", "XX");
            "Test test test".ReplaceFirst2("test", "XX", StringComparison.OrdinalIgnoreCase);
        }
    }
}
