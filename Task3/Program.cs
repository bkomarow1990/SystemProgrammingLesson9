using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] bounds = new int[2];
        static void Main(string[] args)
        {
            Console.WriteLine("Enter left-side number");
            bounds[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter right-side number");
            bounds[1] = Int32.Parse(Console.ReadLine());
            Parallel.For(bounds[0], bounds[1], PrintMultTableWithRange);
        }

        private static void PrintMultTableWithRange(int left)
        {
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");

                }
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
