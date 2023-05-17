using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._02_Refference
{
    class _01_ref_문제2
    {
        public static int Total(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static float Average(int n1, int n2, int n3)
        {
            return (float)(n1 + n2 + n3) / 3;
        }

        public static int HighScore(int n1, int n2, int n3)
        {
            int temp = Math.Max(n1, n2);
            return Math.Max(temp, n3);
        }

        public static void Main()
        {
            Console.WriteLine("철수의 국어, 영어, 수학점수를 입력하세요.");
            int kor = int.Parse(Console.ReadLine());
            int eng = int.Parse(Console.ReadLine());
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine($"점수의 총함은 {Total(kor, eng, math)}점 입니다.");
            Console.WriteLine($"점수의 평균은 {Average(kor, eng, math)}점 입니다.");
            Console.WriteLine($"최고점수는 {HighScore(kor, eng, math)}점 입니다.");


        }
    }
}
