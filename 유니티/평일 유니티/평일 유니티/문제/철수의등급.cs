using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class 철수의등급
    {
        public static void Main()
        {
            Console.WriteLine("점수를 입력하세요.");
            int score = int.Parse(Console.ReadLine());

            if ((score >= 0) && (score <= 100))
            {
                if (score >= 95) 
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
                    Console.WriteLine("재수강");
            }
            else
            {
                Console.WriteLine("점수가 잘못 입력되었습니다.");
            }
        }
    }
}
