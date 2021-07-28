using BenchmarkDotNet.Running;

namespace TestSolution
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkClass>();
        }
    }
}
