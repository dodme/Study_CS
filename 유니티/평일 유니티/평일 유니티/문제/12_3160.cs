using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _12_3160
    {
        public static void Main()
        {
            int[] arrNum = new int[30];

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = i + 31;
                Console.WriteLine(arrNum[i]);
            }
        }
    }
}
