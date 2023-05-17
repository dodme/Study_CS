using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._07_분기문._01_IF문
{
    class 철수의시험등급_문제
    {
        public static void Main()
        {
            Console.WriteLine("시험점수를 입력하세요.");
            int score = int.Parse(Console.ReadLine());

            if (score <= 100 && score >= 0)
            { 
                if(score >= 95)
                    Console.WriteLine("A+");
                else if (score >= 90)
                    Console.WriteLine("A");
                else if (score >= 85)
                    Console.WriteLine("B+");
                else if (score >= 80)
                    Console.WriteLine("B");
                else if (score >= 75)
                    Console.WriteLine("C+");
                else if (score >= 70)
                    Console.WriteLine("C");
                else if (score >= 65)
                    Console.WriteLine("D+");
                else if (score >= 60)
                    Console.WriteLine("D");
                else
                    Console.WriteLine("불합격");
            }
            else
                Console.WriteLine("0 ~ 100 사이의 시험점수를 입력하세요.");
        }
    }
}
