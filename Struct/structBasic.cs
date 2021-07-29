using System;

namespace ConsoleApp7
{   
    public struct MyStruct
    {
        // static하게 Main에서도 변수를 사용하고 싶다면 Const도 사용 가능하다.
        // public const int Age = 12;
        // public static float PI = 4.14f;
        public int Age;
        public MyStruct(int age)
        {
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct mystruct1;
            mystruct1.Age = 12;
            Console.WriteLine("This is mystruct1's value {0}", mystruct1.Age);

            MyStruct mystruct2 = new MyStruct();
            Console.WriteLine("This is mystruct1's value {0}", mystruct2.Age);

            MyStruct mystruct3 = new MyStruct(20);
            Console.WriteLine("This is mystruct1's value {0}", mystruct3.Age);

        }
    }
}
