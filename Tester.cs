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
        public void ReplaceSubstring()
        {
            "Test string".ReplaceSubstring("s", "X");
            "Test test test".ReplaceSubstring("test", "XX");
            "Test test test".ReplaceSubstring("test", "XX", StringComparison.OrdinalIgnoreCase);
        }

        [Benchmark]
        public void ReplaceSpan()
        {
            "Test string".ReplaceSpan("s", "X");
            "Test test test".ReplaceSpan("test", "XX");
            "Test test test".ReplaceSpan("test", "XX", StringComparison.OrdinalIgnoreCase);
        }
    }
}
