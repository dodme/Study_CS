using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._09_점프문
{
    // 점프문
    /// break continue return

    class _01_점프문
    {
        public static void Main()
        {
            int count = 0;

            while (true)
            {
                count++;
                Console.WriteLine(count);

                if (count == 5)
                {
                    //Console.WriteLine("break!");
                    //break;
                    
                    //Console.WriteLine("Continue!");
                    //continue;
                    
                    //Console.WriteLine("Return");
                    //return;
                    
                    Console.WriteLine("돌았졍");
                }
            }

            Console.WriteLine("실행!");
        }
    }
}
