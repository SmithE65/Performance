using Benchmark;
using BenchmarkDotNet.Running;

Console.WriteLine("Benchmarking...");

//_ = BenchmarkRunner.Run<MyBenchmark>();
_ = BenchmarkRunner.Run<FactorialBenchmark>();
