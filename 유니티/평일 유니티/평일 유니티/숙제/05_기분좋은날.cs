using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class _05_기분좋은날
    {
        public static void Main()
        {
            int[] arrNum = new int[30];

            for (int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = (i + 31);
                Console.WriteLine($"arrNum[{i}] : {arrNum[i]}");
            }

        }
    }
}
