using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 314;
            string str1 = value1.ToString();
            Console.WriteLine("This is convert result that Int to String -> {0}", str1);


            int value2 = Convert.ToInt32(str1);
            Console.WriteLine("This is convert result that String to Int -> {0}", value2);

            string str2 = "3.14";
            float value3 = float.Parse(str2);
            Console.Write("This is convert result that String to float -> {0}", value3);
        }
    }
}
