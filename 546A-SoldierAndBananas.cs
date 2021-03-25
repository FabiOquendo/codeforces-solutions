using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] array = line.Split(" ");
            long k = long.Parse(array[0]);
            long n = long.Parse(array[1]);
            long w = long.Parse(array[2]);
            long ans = (((w * (w + 1)) / 2) * k) - n;          
            Console.WriteLine((ans > 0) ? ans : 0);
        }
    }
}
