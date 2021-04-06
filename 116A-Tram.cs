using System;
 
namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);
            int a, b, sum = 0, ans = 0;
            string[] array;
            while (n > 0)
            {
                line = Console.ReadLine();
                array = line.Split(" ");
                a = int.Parse(array[0]);
                b = int.Parse(array[1]);
                sum -= a;
                sum += b;
                if(sum > ans) {
                    ans = sum;
                }
                n--;
            }   
            Console.WriteLine(ans);
        }
    }
}
