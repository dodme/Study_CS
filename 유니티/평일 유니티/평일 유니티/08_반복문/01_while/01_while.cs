using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._08_반복문._01_while
{
    // 반복문
    /// while(조건식) ~동안에
    /// {
    ///     조건식이 참인 동안에 반복할 코드;
    /// }
    /// 
    /// for(int i = 0; i < max; i++) ~를 향해
    /// {
    ///     조건이 참인 동안에 반복할 코드;
    /// }

    class _01_while
    {
        public static void Main()
        {
            int count = 0;

            // 무한루프
            while (count < 10)
            {
                count++;
                Console.WriteLine("반복!");
            }

            Console.WriteLine("반복 끝!");
        
        }
    }
}

/// while을 이용하여 1 ~ 10까지의 총합을 출력하세요
