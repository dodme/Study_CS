using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _09_Swap
    {
        public static void Swap(ref int A, ref int B)
        {
            int temp = A;
            A = B;
            B = temp;
        }

        public static void Main()
        {
            int A = 10;
            int B = 20;

            Swap(ref A, ref B);
            Console.WriteLine($"A : {A}");
            Console.WriteLine($"B : {B}");
        }
    }
}
