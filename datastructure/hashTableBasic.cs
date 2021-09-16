// Basic HashTable
using System;
using System.Collections;
using System.Collections.Concurrent; // ConcurrentDictionary
using System.Threading;
using System.Threading.Tasks;

namespace hashTableBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var ht = new Hashtable();

            ht.Add("leesin", "jungle");
            ht.Add("garen", "top");

            if(ht.Contains("leesin"))
            {
                System.Console.WriteLine(ht["leesin"]);
            }
            else
            {
                System.Console.WriteLine(ht["garen"]);
            }
        }
    }
}