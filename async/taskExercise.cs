using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example
{
    class Program
    {
        static async Task<int> AsyncTest()
        {
            var task = new Task<int>(() =>
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += i;
                    // 0.1초 단위로 1씩 증감
                    Thread.Sleep(100);
                }
                return sum;
            });
            task.Start();
            // 외부에서 await에서 기다린다.
            await task;
            
            // wait가 호출되면 통과한다.
            Console.WriteLine(task.Result); //45
            return 10;
        }

        static void Main(string[] args)
        {
            var task = AsyncTest();
            Console.WriteLine("pass await 1");

            // wait
            task.Wait();
            Console.WriteLine("pass await 2");
            // return까지 기다린다.

            int result = task.Result;
            Console.WriteLine(result);
            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }
    }
}
