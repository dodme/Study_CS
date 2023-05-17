using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _06_for문연습
    {
        public static void Main()
        {
            #region 10!
            int result = 1;

            for (int i = 1; i < 11; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);

            #endregion

            #region 31~60

            for (int i = 31; i < 61; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
