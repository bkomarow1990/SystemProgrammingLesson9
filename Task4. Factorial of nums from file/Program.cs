using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Factorial_of_nums_from_file
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
            Parallel.ForEach(nums, (el) => { Factorial(el); });
        }
        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Factorial of {x}, Result of factorial: {result}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
