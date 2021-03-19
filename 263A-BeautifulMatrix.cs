using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, ans = 0;
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();
            string line5 = Console.ReadLine();
            string line = "";
            if (line1.Contains('1'))
            {
                line = line1;
                i = 1;
            } 
            else if (line2.Contains('1'))
            {
                line = line2;
                i = 2;
            }
            else if (line3.Contains('1'))
            {
                line = line3;
                i = 3;
            }
            else if (line4.Contains('1'))
            {
                line = line4;
                i = 4;
            }
            else if (line5.Contains('1'))
            {
                line = line5;
                i = 5;
            }

            if(line[0] == '1')
            {
                j = 1;
            }
            else if (line[2] == '1')
            {
                j = 2;
            }
            else if (line[4] == '1')
            {
                j = 3;
            }
            else if (line[6] == '1')
            {
                j = 4;
            }
            else if (line[8] == '1')
            {
                j = 5;
            }

            ans = Math.Abs(i - 3) + Math.Abs(j - 3);

            Console.WriteLine(ans);
        }
    }
}
