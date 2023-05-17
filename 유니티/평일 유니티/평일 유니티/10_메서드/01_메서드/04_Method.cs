using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._01_메서드
{
    class _04_Method
    {
        public static int Plus(int n1, int n2)
        {
            return n1 + n2;
        }

        public static void Add(int value1)
        {
            value1 += 10;
        }

        public static void Main()
        {
            int value = 10;
            Add(value);
            Console.WriteLine(value);

            //Console.WriteLine(Plus(10, 20));
            
        }
    }
}
