using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);
            int ans = 0;
            while (n > 0)
            {
                if (n - 5 >= 0)
                {
                    ans++;
                    n -= 5;
                }
                else if(n - 4 >= 0)
                {
                    ans++;
                    n -= 4;
                }
                else if (n - 3 >= 0)
                {
                    ans++;
                    n -= 3;
                }
                else if (n - 2 >= 0)
                {
                    ans++;
                    n -= 2;
                }
                else if (n - 1 >= 0)
                {
                    ans++;
                    n--;
                }
            }         
            Console.WriteLine(ans);
        }
    }
}
