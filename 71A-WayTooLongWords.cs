using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);
            while (n > 0)
            {
                line = Console.ReadLine();
                if (line.Length > 10)
                {
                    line = "" + line[0] + (line.Length-2) + line[line.Length-1];
                }
                Console.WriteLine(line);
                n--;
            }
            
        }
    }
}