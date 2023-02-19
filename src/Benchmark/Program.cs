// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Benchmarking...");

var stopWatch = Stopwatch.StartNew();
try
{
    DoSomething();
}
finally
{
    Console.WriteLine(stopWatch.Elapsed);
}

static void DoSomething() { }