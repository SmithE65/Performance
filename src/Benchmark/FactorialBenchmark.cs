using BenchmarkDotNet.Attributes;
using Shared;

namespace Benchmark;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class FactorialBenchmark
{
    [Params(5)]
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
}
