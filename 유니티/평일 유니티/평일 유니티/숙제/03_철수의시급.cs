using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class _03_철수의시급
    {
        public static void Main()
        {
            Console.WriteLine("철수가 일한 시간을 입력하세요.");
            int time = int.Parse(Console.ReadLine());
            int pay = 8720

            if (time >= 0 && time <= 24)
            { 
                if(time <= 8)
                    Console.WriteLine($"철수가 받을 금액은 {pay * time}원 입니다.");
                else
                    Console.WriteLine("철수가 받을 금액은" +
                        $"{(pay * 8) + ((pay * 1.5) * (time - 8))}원 입니다.");
            }
            else
                Console.WriteLine("하루는 몇시간일까요?");

        }
    }
}
