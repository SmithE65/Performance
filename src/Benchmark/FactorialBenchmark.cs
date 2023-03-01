using BenchmarkDotNet.Attributes;
using Shared;

namespace Benchmark;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class FactorialBenchmark
{
    [Params(1, 6, 12)]
    public int Value { get; set; }

    [Benchmark]
    public long Linq() => Factorial.Linq(Value);

    [Benchmark]
    public long Recursive() => Factorial.Recursive(Value);

    [Benchmark]
    public long For() => Factorial.For(Value);

    [Benchmark]
    public long While() => Factorial.While(Value);

    [Benchmark]
    public long Lookup() => Factorial.Lookup(Value);

    [Benchmark]
    public long Bob() => Factorial.Array(Value);
}

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