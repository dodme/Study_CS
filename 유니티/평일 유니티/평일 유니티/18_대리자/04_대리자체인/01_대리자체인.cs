using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._18_대리자._04_대리자체인
{
    class _01_대리자체인
    {
        private static void Sample()
        {
            Console.WriteLine("Sample");
        }

        private static void Sample2()
        {
            Console.WriteLine("Sample2");
        }

        private static void Sample3()
        {
            Console.WriteLine("Sample3");
        }

        private delegate void Chain();

        // +, -, +=, -= 체인가능!

        public static void Main()
        {
            Chain chain = new Chain(Sample) + Sample3;

            chain();

            chain += Sample2;
            // chain = chain + Sample2;

            chain();




        }
    }
}
