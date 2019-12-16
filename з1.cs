using System;

namespace лаб.раб__20
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a;
            char b;
            b = 'C';
            a = Convert.ToByte(b);
            Console.WriteLine("Код предшествующего символа равен: " + (a - 1));
            Console.WriteLine("Код следующего символа равен: " +(a + 1));
            Console.ReadLine();
        }
    }
}
