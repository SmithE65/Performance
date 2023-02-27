// See https://aka.ms/new-console-template for more information

using Benchmark;
using BenchmarkDotNet.Running;
using Shared;

Console.WriteLine("Benchmarking...");

//var result = BenchmarkRunner.Run<MyBenchmark>();
var result = BenchmarkRunner.Run<FactorialBenchmark>();
