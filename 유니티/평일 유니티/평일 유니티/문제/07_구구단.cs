using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _07_구구단
    {
        public static void Main()
        {
            Console.WriteLine("몇단이 궁금해?");
            uint gugudan = uint.Parse(Console.ReadLine()) ;


            Console.WriteLine($"*******{gugudan}단********");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{gugudan} X {i} = {gugudan * i}");
            }

        }
    }
}
