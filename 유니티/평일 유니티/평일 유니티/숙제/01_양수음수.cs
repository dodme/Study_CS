using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class _01_양수음수
    {
        public static void Main()
        {
            Console.WriteLine("정수를 입력하세요.");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
                Console.WriteLine("양수입니다.");
            else if(num <0)
                Console.WriteLine("음수입니다.");
            else
                Console.WriteLine("0입니다.");

        }
    }
}
