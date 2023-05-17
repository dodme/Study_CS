using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 유니티._02_변수와_자료형
{
    class _02_변수
    {
        public static void Main()
        {
            // 자료형 변수이름

            // 정수형식
            // 변수의 선언
            int characterHp;

            // 변수의 초기화
            characterHp = 100;
            // = : 대입 연산자
            Console.WriteLine("당신의 체력은 : " + characterHp);

            // 실수
            // 변수의 선언과 동시에 초기화한다.
            float fNum = 10.1f;
            Console.WriteLine(fNum);

            // 문자
            char c = 'A';
            Console.WriteLine(c);

            string str = "Hello World!";
            Console.WriteLine(str);

            bool b = true;
            Console.WriteLine(b);

            // 참조형식
            object o = 10;
            Console.WriteLine(o);


        }
    }
}
