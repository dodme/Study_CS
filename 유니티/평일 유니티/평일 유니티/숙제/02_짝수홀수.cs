using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class _02_짝수홀수
    {
        public static void Main()
        {
            Console.WriteLine("자연수를 입력하세요.");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            { 
                if((num % 2) == 0)
                    Console.WriteLine("양수입니다.");
                else
                    Console.WriteLine("음수입니다.");
            }
            else
                Console.WriteLine("0 이하의 수입니다.");

        }
    }
}
