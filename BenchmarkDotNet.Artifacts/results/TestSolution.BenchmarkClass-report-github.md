``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Unknown processor
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|                 Method |     Mean |     Error |    StdDev |   Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |---------:|----------:|----------:|---------:|-------:|------:|------:|----------:|
| SampleMethodSortedList | 3.506 μs | 0.0805 μs | 0.2298 μs | 3.470 μs | 0.7668 |     - |     - |      1 KB |
| SampleMethodDictionary | 2.326 μs | 0.0451 μs | 0.1235 μs | 2.289 μs | 1.2894 |     - |     - |      2 KB |
|    SampleMethodHashset | 2.212 μs | 0.0178 μs | 0.0158 μs | 2.213 μs | 1.3695 |     - |     - |      2 KB |
