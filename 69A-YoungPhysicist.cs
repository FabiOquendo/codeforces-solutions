using System;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int n = int.Parse(line);
            string[] array;
            int xi, yi, zi;
            int x = 0, y = 0, z = 0;
            while (n > 0)
            {
                line = Console.ReadLine();
                array = line.Split(" ");
                xi = int.Parse(array[0]);
                yi = int.Parse(array[1]);
                zi = int.Parse(array[2]);
                x += xi; y += yi; z += zi;
                n--;
            }
            bool ans = false;
            if (x == 0 && y == 0 && z == 0)
            {
                ans = true;
            }            
            Console.WriteLine(ans ? "YES" : "NO");
        }
    }
}
