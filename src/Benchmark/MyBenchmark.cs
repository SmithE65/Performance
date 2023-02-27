using BenchmarkDotNet.Attributes;
using Shared;
using V1 = Shared.GCode.V1;
using V2 = Shared.GCode.V2;

namespace Benchmark;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class MyBenchmark
{
    private readonly string[] _lines = SampleData.GCodeSamples;

    [Benchmark]
    public V1.Code?[] Initial() => _lines.Select(V1.Code.Parse).ToArray();

    [Benchmark]
    public V2.Code?[] Updated() => _lines.Select(V2.Code.Parse).ToArray();
}
