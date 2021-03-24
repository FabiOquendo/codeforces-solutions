using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);
            line = Console.ReadLine();
            int ans = 0;
            int i = 0, j = 1;
            while (j < n)
            {
                if(line[i] == line[j])
                {
                    ans++;
                } 
                else
                {
                    i = j;
                }
                j++;
            }
            Console.WriteLine(ans);
        }
    }
}
