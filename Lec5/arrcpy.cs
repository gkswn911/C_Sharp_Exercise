using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2, 3, 4 };
            int[] nCloneArray = (int[])nArray1.Clone();

            nCloneArray[2] = 30;
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            foreach (int m in nCloneArray)
                Console.Write(m);
            Console.WriteLine();

            string[] name = new string[] { "dog", "cat", "tiger" };
            string[] nameCpy = new string[] { };
            nameCpy = (string[])name.Clone();

            foreach (string m in nameCpy)
                Console.Write(m + " ");
        }
    }
}
