// Thread Queue
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentApp
{
class Program 
{
    static void Main(string[] args) {
	
        var q = new ConcurrentQueue<int> ();

        // data를 Queue에 넣는 쓰레드
        Task tEnq = Task.Factory.StartNew(() =>
        {
            for(int i = 0; i < 100; i++)
            {
                q.Enqueue(i);
                Thread.Sleep(100);
            }
        });

        // data를 Queue에서 읽는 쓰레드
        Task tDeq = Task.Factory.StartNew(() =>
        {
            int n = 0;
            int result;

            while (n < 100)
            {
                // First In First Out => FIFO로 출력된다.
                if(q.TryDequeue(out result))
                {
                    Console.WriteLine(result);
                    n++;
                }
            }
        });
		// 두 쓰레드가 끝날 때까지 대기
        Task.WaitAll(tEnq, tDeq);
    }
}
}