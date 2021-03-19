using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            line = line.ToLower();
            string ans = "";
            for(int i=0; i < line.Length; i++)
            {
                if(!isVowel(line[i]))
                {
                    ans += "." + line[i];
                }
            }
            Console.WriteLine(ans);
        }

        public static bool isVowel(char a)
        {
            if (a == 'a' || a == 'o' || a == 'y' || a == 'e' || a == 'u' || a == 'i')
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}