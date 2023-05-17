using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _10_철수의성적
    {
        public static int Total(int kor, int eng, int math)
        {
            return kor + eng + math;
        }

        public static float Average(int kor, int eng, int math)
        {
            return Total(kor, eng, math) / 3.0f;
        }

        public static int Max(int kor, int eng, int math)
        {
            // 삼항연산자?
            /// (검사할 식) ? true : false;

            int max = (kor > eng) ? kor : eng;
            max = (max > math) ? max : math;
            return max;


            /*int max = Math.Max(kor, eng);
            return Math.Max(max, math);*/
        }

        public static void Main()
        {
            Console.WriteLine("국어점수를 입력하세요.");
            int kor = int.Parse(Console.ReadLine());

            Console.WriteLine("영어점수를 입력하세요.");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("수학점수를 입력하세요.");
            int math = int.Parse(Console.ReadLine());
        }
    }
}
