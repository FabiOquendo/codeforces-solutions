using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            string[] array;
            string line = Console.ReadLine();
            array = line.Split(" ");
            int n = int.Parse(array[0]);
            int k = int.Parse(array[1]);
            line = Console.ReadLine();
            array = line.Split(" ");
            int[] scores = new int[n] ;
            for (int i = 0; i < n; i++)
            {
                scores[i] = int.Parse(array[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if(scores[i] > 0 && scores[i] >= scores[k-1])
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}