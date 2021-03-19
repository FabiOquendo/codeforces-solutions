using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] array = line.Split(" ");
            int n = int.Parse(array[0]);
            int m = int.Parse(array[1]);
            int ans = ((m / 2) * n) + ((m % 2) * (n / 2));
            Console.WriteLine(ans);
        }
    }
}
