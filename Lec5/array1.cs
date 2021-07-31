using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 4, 5 };

            for( int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.WriteLine(array[i][j]);
            }
        }
    }
}
