using Shared;
using Shared.GCode.V1;
using System.Diagnostics;

Console.WriteLine("Timing...");

var lines = SampleData.GCodeSamples;
Console.WriteLine($"Parsing {lines} lines of code...");
BasicTiming.Run(lines);

internal static class BasicTiming
{
    public static void Run(string[] lines)
    {
        var stopwatch = Stopwatch.StartNew();
        List<Code?> codes;
        try
        {
            codes = lines.Select(Code.Parse).ToList();
        }
        finally
        {
            Console.WriteLine(stopwatch.Elapsed);
        }
    }
}