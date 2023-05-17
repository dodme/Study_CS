using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._02_변수와자료형._01_기본데이터형식
{
    class _01_기본데이터형식
    {
        // 데이터 형식 / 자료형

        // bit = 메모리의 최소단위
        // 1byte = 8bit


        // 정수형식             값을 담을 수 있는 범위
        //  sbyte : 1Byte       -128 ~ 127
        //  short : 2Byte       -32768 ~ 32767
        //  int   : 4Byte       -21억 ~ 21억
        //  long  : 8Byte       -922경 ~ 922경

        // 실수형식
        // float  : 4Byte        소숫점 6번째자리까지
        // double : 8Byte        소숫점 16번째자리까지

        // 문자형식 
        // char   : 1Byte

        // 문자열 형식
        // String 

        // 논리형식
        // bool

        public static void Main()
        {
            // 정수
            int num = 10;
            Console.WriteLine(num);

            // 실수
            float fNum = 10.5f;
            Console.WriteLine(fNum);

        }
    }
}
