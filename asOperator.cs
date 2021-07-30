using System;

namespace ConsoleApp1
{

    class A { }
    class B { }
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);
            // 가능

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;
            if (test2 == null)
                Console.WriteLine("형변환 실패!");
            else
                Console.WriteLine("형변환 성공");
        }
    }
}
