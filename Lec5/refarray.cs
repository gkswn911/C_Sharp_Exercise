using System;

namespace ConsoleApp3
{
    class Program
    {
        static void TransArray(string [] arr)
        {
            string[] HangulDays = new string[] { "하나", "둘", "셋", "넷", "다섯" };
            for (int i = 0; i < HangulDays.Length; i++)
            {
                arr[i] = HangulDays[i];
            }
        }
        static void Main(string[] args)
        {
            string[] Days = new string[] { "one", "two", "three", "four", "five" };

            Console.Write("Ref Before  ");
            foreach (string str1 in Days)
                Console.Write("{0}  ", str1);

            TransArray(Days);

            Console.Write("\nRef After  ");
            foreach (string str1 in Days)
                Console.Write("{0}  ", str1);

        }
    }
}
