﻿using System;
using System.Collections.Generic;

namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {

            // 236A-BoyOrGirl

            string line = Console.ReadLine();
            HashSet<char> characters = new HashSet<char>();
            for(int i = 0; i < line.Length; i++)
            {
                characters.Add(line[i]);
            }
            string ans;
            if(characters.Count % 2 == 0)
            {
                ans = "CHAT WITH HER!";
            }
            else
            {
                ans = "IGNORE HIM!";
            }
            Console.WriteLine(ans);
        }
    }
}
