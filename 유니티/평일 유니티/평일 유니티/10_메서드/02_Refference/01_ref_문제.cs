using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._02_Refference
{
    class _01_ref_문제
    {
        public static void Swap(ref int n1, ref int n2)
        {
            int n3 = n2;
            n2 = n1;
            n1 = n3;
        }

        public static void Main()
        {
            Console.WriteLine("Enter Two Integer..");

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());


            Swap(ref A, ref B);

            Console.WriteLine($"{A}, {B}");
        }
    }
}
