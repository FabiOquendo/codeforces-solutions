using System;
using System.Collections.Generic;
using System.Linq;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            string line = Console.ReadLine();
            string[] array = line.Split("+");
            Dictionary<int, int> nums = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                int n = int.Parse(array[i]);
                if (nums.ContainsKey(n))
                {
                    int value = nums.GetValueOrDefault(n);
                    nums.Remove(n);
                    nums.Add(n, value + 1);
                }
                else
                {
                    nums.Add(n, 1);
                }
            }

            var list = nums.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                for(int i = 0; i < nums[key]; i++)
                {
                    ans += key + "+";
                }
            }

            Console.WriteLine(ans.Substring(0, ans.Length-1));
        }
    }
}
