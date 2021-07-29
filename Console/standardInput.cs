using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 원하는 키를 입력하면 입력된 키 값을 출력하기.

            ConsoleKeyInfo KeyInfo;

            Console.WriteLine("원하는 커맨드를 입력해주세요.");

            do
            {
                KeyInfo = Console.ReadKey(true);
                // 대소문자 구분없이 특정 문자(A)가 입력되면 실행한다.
                //if (KeyInfo.Key == ConsoleKey.A)
                  //  Console.WriteLine("A가 눌렸습니다."); 

                // 대소문자를 구분한 특정 문자가 입력되면 실행한다.
                if (KeyInfo.KeyChar == 'A')
                    Console.WriteLine("A가 눌렸습니다.");
                Console.Write(KeyInfo.KeyChar);
            } while (KeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
