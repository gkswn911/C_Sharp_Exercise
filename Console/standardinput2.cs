using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReadLine() 메서드를 통해서 값을 성적 읽기.

            int kor, math, eng, total;
            float average;

            Console.Write("국어 점수를 입력하세요 : ");
            kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요 : ");
            math = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요 : ");
            eng = Convert.ToInt32(Console.ReadLine());

            total = kor + math + eng;
            average = total / 3f;

            Console.Write("국어 : {0} 수학 : {1} 영어 : {2} 총합 : {3} 평균 : {4:f1}", kor, math, eng, total, average);
        }
    }
}
