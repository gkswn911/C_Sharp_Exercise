using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("올바른 값이다.");
            }
            else
            {
                Console.WriteLine("Null 값이다.");
            }
            Console.WriteLine("num1's value is = {0}", num1);
        }
    }
}
