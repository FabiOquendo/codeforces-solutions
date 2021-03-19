using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            line1 = line1.ToLower();
            line2 = line2.ToLower();
            Console.WriteLine(line1.CompareTo(line2));
        }
    }
}