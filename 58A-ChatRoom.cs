using System;
 
namespace codeforces_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int a = 0;
            for(int i = 0; i < line.Length; i++) {
            	if(a == 0 && line[i] == 'h') {
            		a++;
            	} 
            	else if(a == 1 && line[i] == 'e') {
            		a++;
            	}
            	else if((a == 2 || a == 3) && line[i] == 'l') {
            		a++;
            	}
            	else if(a == 4 && line[i] == 'o') {
            		a++;
            	}
            }
            Console.WriteLine((a == 5) ? "YES" : "NO");
        }
    }
}
