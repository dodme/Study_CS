using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _08_유클리드
    {
        public static void Main()
        {
            Console.WriteLine("두개 입력해");
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            while (M != 0)
            {
                int temp = N % M;
                N = M;
                M = temp;
            }

            Console.WriteLine($"최대 공약수 : {N}");


        }
    }
}
