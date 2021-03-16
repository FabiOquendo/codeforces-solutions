using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {

            // 4A-Watermelon

            string line = Console.ReadLine();
            int n = int.Parse(line);
            if (n != 2 && n % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
