using System;

namespace ConsoleApp8
{

    public struct MyStruct
    {
        public int kor, math, eng, total;
        public float average;

        public void compute()
        {
            total = kor + math + eng;
            average = total / 3.0f;
        }
        public void print()
        {
            Console.WriteLine("국어 : {0} 수학 : {1} 영어 : {2} 총 점 : {3} 평균 : {4:f1}",
                kor, math, eng, total, average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct struct1 = new MyStruct();
            struct1.kor = 98;
            struct1.math = 100;
            struct1.eng = 95;
            struct1.compute();
            struct1.print();
            
        }
    }
}
