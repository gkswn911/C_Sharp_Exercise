using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            Array.Clear(nArray1, 2, 1);
            // 두 번째 인자 : 시작 인덱스  , 세 번째 인자 : 개수
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            // 인덱스 0 부터 끝까지 0으로 변경.
            Array.Clear(nArray1, 0, nArray1.Length);
            foreach (int n in nArray1)
                Console.Write(n);
        }
    }
}
