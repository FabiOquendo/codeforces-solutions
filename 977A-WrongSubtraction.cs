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
            long k = long.Parse(array[1]);
            while (k > 0)
            {
                if (n % 10 == 0)
                {
                    n /= 10;
                }
                else
                {
                    n--;
                }
                k--;
            }         
            Console.WriteLine(n);
        }
    }
}
