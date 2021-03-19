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
            while(n > 0)
            {
                line = Console.ReadLine();
                if(line[1] == '+')
                {
                    ans++;
                } else
                {
                    ans--;
                }
                n--;
            }
            Console.WriteLine(ans);
        }
    }
}