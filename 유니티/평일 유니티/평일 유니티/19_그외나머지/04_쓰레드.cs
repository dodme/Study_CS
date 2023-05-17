using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 평일_유니티._19_그외나머지
{
    class _04_쓰레드
    {
        public static void Main()
        {
            Thread t1 = new Thread(() =>
            {
                int[] arrNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                foreach (int i in arrNum)
                {
                    Thread.Sleep(100);

                    Console.WriteLine("T1   " + i);
                }
            });

            Thread t2 = new Thread(() =>
            {
                int[] arrNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                foreach (int i in arrNum)
                {
                    Thread.Sleep(100);

                    Console.WriteLine("         T2   " + i);
                }
            });

            t1.Start();

            t2.Start();

            t1.Join();  // 쓰레드 종료까지 대기
            t2.Join();  // 쓰레드 종료까지 대기

            Console.WriteLine("프로그램 종료");

        }
    }
}
