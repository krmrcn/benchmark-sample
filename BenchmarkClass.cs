using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace TestSolution
{
    [MemoryDiagnoser]
    public class BenchmarkClass
    {
        public readonly List<int> sampleList = new List<int> 
        { 
            2, 2, 3, 5, 6, 6, 2, 2, 3, 5, 6, 6, 7, 7, 7, 7, 8, 8, 9, 10, 11, 12, 13, 14, 15,
            16, 17, 3, 18, 21, 55, 8, 9, 10, 87, 41, 9, 1, 3, 2, 10, 6, 5, 3, 9, 9, 6, 1, 23,
            2, 2, 3, 5, 6, 6, 2, 2, 3, 5, 6, 6, 7, 7, 7, 7, 8, 8, 9, 10, 11, 12, 13, 14, 15 
        };

        [Benchmark]
        public List<int> SampleMethodList()
        {
            var uniqueList = new List<int>();

            foreach (var item in sampleList)
            {
                if (!uniqueList.Contains(item))
                    uniqueList.Add(item);
            }

            return uniqueList;
        }

        [Benchmark]
        public List<int> SampleMethodSortedList()
        {
            var uniqueList = new SortedList<int, int>();

            foreach (var item in sampleList)
            {
                if (!uniqueList.ContainsKey(item))
                    uniqueList.Add(item, item);
            }

            return uniqueList.Select(s => s.Value).ToList();
        }

        [Benchmark]
        public List<int> SampleMethodDictionary()
        {
            var uniqueList = new Dictionary<int, int>();

            foreach (var item in sampleList)
            {
                if (!uniqueList.ContainsKey(item))
                    uniqueList.Add(item, item);
            }

            return uniqueList.Select(s => s.Value).ToList();
        }

        [Benchmark]
        public List<int> SampleMethodHashset()
        {
            var uniqueList = new HashSet<int>(sampleList);

            return uniqueList.ToList();
        }
    }
}
