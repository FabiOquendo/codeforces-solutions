using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array;
            int flag, ans = 0;
            string line = Console.ReadLine();
            int n = int.Parse(line);
            while(n > 0)
            {
                line = Console.ReadLine();
                array = line.Split(" ");
                flag = int.Parse(array[0]) + int.Parse(array[1]) + int.Parse(array[2]);
                if (flag >= 2)
                {
                    ans++;
                }
                n--;
            }
            Console.WriteLine(ans);
        }
    }
}