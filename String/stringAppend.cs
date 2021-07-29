using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3 = str1 + str2;
            Console.WriteLine("Line 1 = {0}, Line 2 = {1} ", str3, str3[4]);
        }
    }
}
