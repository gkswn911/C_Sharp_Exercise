using System;

namespace csharp_lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            if (nValue is float)
                Console.WriteLine("호환된다.");
            else
                Console.WriteLine("호환 안 된다.");

            if (nValue is object) // Boxing 가능
                Console.WriteLine("호환 된다.");
            else
                Console.WriteLine("호환 안 된다.");

            object obj = nValue;
            if (obj is int) // unboxing
                Console.WriteLine("호환 된다.");
            else
                Console.WriteLine("호환 안 된다.");
    }
    }               
}
