using Benchmark;
using BenchmarkDotNet.Running;

Console.WriteLine("Benchmarking...");

//_ = BenchmarkRunner.Run<MyBenchmark>();
_ = BenchmarkRunner.Run<FactorialBenchmark>();
//_ = BenchmarkRunner.Run<StringBuilderBenchmark>();
//_ = BenchmarkRunner.Run<LoopBenchmark>();
