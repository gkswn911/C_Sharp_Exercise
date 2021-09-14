using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack 객체 선언
            Stack _stack = new Stack();

            // Stack 객체에 Data Push
            _stack.Push("First Value");
            _stack.Push("Second Value");
            _stack.Push("Final Value BYEBYE");

            Console.WriteLine("Stack Value 출력하기 :");

            foreach(var str in _stack)
            {
                Console.WriteLine(String.Format("Value : {0}", str));
            }
            Console.WriteLine();
        }
    }
}
