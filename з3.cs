using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string line = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsUpper(line[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
