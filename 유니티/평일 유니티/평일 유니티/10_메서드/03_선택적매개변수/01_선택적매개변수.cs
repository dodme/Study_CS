using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._03_선택적매개변수
{
    class _01_선택적매개변수
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public static void Main()
        {
            Console.WriteLine(Add(10, 20));
        }
    }
}
