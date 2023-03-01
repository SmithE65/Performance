using BenchmarkDotNet.Attributes;
using System.Text;

namespace Benchmark;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringBuilderBenchmark
{
    readonly string _a = "a";
    readonly string _b = "b";
    readonly string _c = "c";
    readonly string _d = "d";

    [Benchmark]
    public string Interp()
    {
        return $"{_a}{_b}{_c}{_d}";
    }

    [Benchmark]
    public string MikesTest()
    {
        return _a + _b + _c + _d;
    }

    [Benchmark]
    public string Builder()
    {
        StringBuilder builder = new();
        _ = builder.Append(_a);
        builder.Append(_b);
        builder.Append(_c);
        builder.Append(_d);
        return builder.ToString();
    }
}