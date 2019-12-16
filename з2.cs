using System;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            foreach (char ch in str)
            {
                Console.Write(ch + " ");
            }
            Console.ReadLine();
        }
    }
}
