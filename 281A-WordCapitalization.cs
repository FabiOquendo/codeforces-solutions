using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string letter = line.Substring(0, 1);
            letter = letter.ToUpper();
            string ans = letter + line.Substring(1, line.Length-1);

            Console.WriteLine(ans);
        }
    }
}