using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._07_분기문._01_IF문
{
    class _02_ifelse
    {
        // if else 구문
        // if(조건식)
        /// {
        ///     조건식이 참일때만 실행할 코드;
        /// }
        /// else
        /// {
        ///     조건식이 거짓일때 실행할 코드;
        /// }

        enum Key
        {
            W,
            S,
        }

        public static void Main()
        {
            Key key = Key.W;

            if (key == Key.W)
            {
                Console.WriteLine("앞으로 전진");
            }
            else
            {
                Console.WriteLine("안 움직임");
            }

        }
    }
}

// 숙제
/// 철수의 국어성적 영어성적 수학성적을 입력받아
/// 총점과 평균을 구하고
/// 철수의 평균이 70점 이상 이라면 합격
/// 미만 이라면 불합격을 출력하는 프로그램을 작성하세요.
