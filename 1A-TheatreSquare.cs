using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] array = line.Split(" ");
            long n = long.Parse(array[0]);
            long m = long.Parse(array[1]);
            long a = long.Parse(array[2]);
            long l1 = (n % a == 0) ? (n / a) : (n / a) + 1;
            long l2 = (m % a == 0) ? (m / a) : (m / a) + 1;
            long ans = l1 * l2;
            Console.WriteLine(ans);
        }
    }
}