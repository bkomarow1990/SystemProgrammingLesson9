using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Sum__Max__Min_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            string[] numsInStrings = File.ReadAllLines("nums.dat")[0].Split(' ');
            foreach (var item in numsInStrings)
            {
                nums.Add(Int32.Parse(item));
            }
            Console.WriteLine($"Min: {nums.AsParallel().Min()}");
            Console.WriteLine($"Max: {nums.AsParallel().Max()}");
            Console.WriteLine($"Sum: {nums.AsParallel().Sum()}");
        }
    }
}
