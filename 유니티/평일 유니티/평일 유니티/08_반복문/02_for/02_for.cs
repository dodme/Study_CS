using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._08_반복문._02_for
{
    class _02_for
    {
        public static void Main()
        {
            int result = 1;

            for (int i = 1; i < 10; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);

            Console.WriteLine();

            for (int i = 31; i < 61; i++)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
