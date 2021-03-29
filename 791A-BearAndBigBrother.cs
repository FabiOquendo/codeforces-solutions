using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] array = line.Split(" ");
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);
            int ans = 0;
            while (a <= b)
            {
                a *= 3;
                b *= 2;
                ans++;
            }         
            Console.WriteLine(ans);
        }
    }
}
