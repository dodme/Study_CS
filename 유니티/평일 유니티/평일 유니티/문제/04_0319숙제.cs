using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _04_0319숙제
    {
        public static void Main()
        {
            //Console.WriteLine("철수가 일한 시간");
            //int time = int.Parse(Console.ReadLine());

            #region 1번문제
            /*if (inputNum > 0)
            {
                Console.WriteLine("양수");
            }
            else if (inputNum == 0)
            {
                Console.WriteLine("0");
            }
            else if (inputNum < 0)
            { 
                Console.WriteLine("음수");
            }*/
            #endregion


            #region 2번문제
            if (inputNum % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else if (inputNum % 2 == 1)
            { 
                Console.WriteLine("홀수");
            }
            #endregion


            #region 3번문제
         /*   int pay = 8720;

            if (time > 8)
            {
                time -= 8;
                Console.WriteLine($"철수의 임금은 : {(time * (pay * 1.5f) + (8 * pay))}");
            }
            else if (time <= 8 && time >= 0)
            {
                Console.WriteLine($"철수의 임금은 : {time * pay}");
            }*/

            #endregion


            #region 4번문제
            int count = 0;
            int result = 0;

            while (count < 11)
            {
                count++;
                result += count;
            }
            Console.WriteLine(result);


            #endregion


        }
    }
}
