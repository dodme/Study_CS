using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class _04_쑥제
    {
        public static void Main()
        {
            Console.WriteLine("몇단을 출력할까요?");
            // 몇 단?
            int num = int.Parse(Console.ReadLine());
            // X 9 까지 반복돌릴 변수
            int count = 1;

            // C언어에서는 for문썼는데 왜 여기선 while문 썼지..?
            while (count < 10)
            {
                Console.WriteLine($"{num} X {count} = {num * count}");
                count++;
            }

        }
    }
}
