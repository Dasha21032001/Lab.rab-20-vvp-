using System;

namespace з5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку s: ");
            string s = Console.ReadLine();
            Console.WriteLine("Введите строку s0: ");
            string s0 = Console.ReadLine();
            int i = 0;  
            int x = -1; 
            int count = -1; 
            while (i != -1)
            {
                i = s.IndexOf(s0, x + 1); 
                x = i; 
                count++;  
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
