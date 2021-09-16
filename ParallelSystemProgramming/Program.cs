using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelSystemProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num for Factorial: ");
            int num = Int32.Parse(Console.ReadLine());
            Parallel.Invoke(
                Display,
                () => {
                    Console.WriteLine($"Task executing {Task.CurrentId}");
                    Thread.Sleep(3000);
                    Console.WriteLine($"Task ended  {Task.CurrentId}");
                },
                () => Factorial(num), () => GetCountDigits(num), () => GetSumOfDigits(num));

            Console.ReadLine();
        }

        private static void GetCountDigits(int num)
        {
            int count = num.ToString().Length;
            Console.WriteLine("----------------------------------");
            
            Console.WriteLine($"Count digits: {count}");
        }
        private static void GetSumOfDigits(int num)
        {
            int count = num.ToString().Length;
            int[] nums = new int[count];
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                nums[i] = num % 10;
                num /= 10;
                sum += nums[i];
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Summ of digits: {sum}");

        }
        
        static void Display()
        {
            Console.WriteLine($"Task executing {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Task ended {Task.CurrentId}");
        }

        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Task executing {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Result of factorial: {result}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
