using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _05_구구단
    {
        public static void Main()
        {
            int count = 1;

            Console.WriteLine("구구단 몇 단을 출력할까요?");
            uint inputNum = uint.Parse(Console.ReadLine());

            while (count < 10)
            {
                Console.WriteLine($"{inputNum} X {count} = {inputNum * count}");
                count++;
            }

        }
    }
}
