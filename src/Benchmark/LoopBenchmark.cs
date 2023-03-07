using BenchmarkDotNet.Attributes;
using Shared;

namespace Benchmark;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class LoopBenchmark
{
    [Params(1, 10, 1000, 100000)]
    public int Value { get; set; }

    [Benchmark]
    public int For()
    {
        for (int i = 0; i < Value; i++)
        {
            DoSomething();
        }

        return Value;
    }

    [Benchmark]
    public int Range()
    {
        foreach (var i in 0..Value)
        {
            DoSomething();
        }

        return Value;
    }

    private void DoSomething() { }
}