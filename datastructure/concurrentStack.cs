// Thread Stack
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace concurrentStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new ConcurrentStack<int>();

            Task tPush = Task.Factory.StartNew(() => 
            {
                for(int i = 0; i < 100; i ++)
                {
                    s.Push(i);
                    Thread.Sleep(100);
                }
            });

            Task tPop = Task.Factory.StartNew(() => 
            {
                int n = 0;
                int result;
                while(n < 100)
                {
                    if(s.TryPop(out result))
                    {
                        System.Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(150);
                }
            });

            Task.WaitAll(tPush, tPop);
        }
    }
}