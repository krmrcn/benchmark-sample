``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19043.1110 (21H1/May2021Update)
Unknown processor
.NET SDK=5.0.302
  [Host]     : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT
  DefaultJob : .NET Core 3.1.17 (CoreCLR 4.700.21.31506, CoreFX 4.700.21.31502), X64 RyuJIT


```
|                 Method |       Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |-----------:|---------:|---------:|-------:|------:|------:|----------:|
|       SampleMethodList |   869.6 ns |  9.76 ns |  8.15 ns | 0.2346 |     - |     - |     368 B |
| SampleMethodSortedList | 3,157.5 ns | 15.85 ns | 14.05 ns | 0.7629 |     - |     - |   1,208 B |
| SampleMethodDictionary | 2,099.2 ns | 34.13 ns | 30.26 ns | 1.2894 |     - |     - |   2,032 B |
|    SampleMethodHashset | 2,200.1 ns | 14.92 ns | 13.96 ns | 1.3695 |     - |     - |   2,152 B |
