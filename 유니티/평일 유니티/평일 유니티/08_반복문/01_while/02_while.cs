using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._08_반복문._01_while
{
    class _02_while
    {
        public static void Main()
        {
            int count = 10;
            int result = 1;

            while (count > 0)
            {
                result *= count;
                count--;
            }
            Console.WriteLine(result);
        }
    }
}
