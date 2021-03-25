using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int dangerous = 1;
            int i = 0, j = 1;
            bool ans = false;
            while (j < line.Length)
            {
                if (line[i] == line[j])
                {
                    dangerous++;
                    if (dangerous >= 7)
                    {
                        ans = true;
                    }
                }
                else
                {
                    i = j;
                    dangerous = 1;
                }
                j++;
            }
            Console.WriteLine(ans ? "YES" : "NO");
        }
    }
}
