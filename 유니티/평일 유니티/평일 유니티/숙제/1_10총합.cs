using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class _1_10총합
    {
        public static void Main()
        {
            // 총합을 담아둘 변수
            int num = 0;

            // 1씩 증가할 변수
            int count = 0;

            while (count < 10)
            {
                count++;
                num += count;
            }

            Console.WriteLine($"1 ~ 10까지의 총합은 {num}입니다.");
        }
    }
}
