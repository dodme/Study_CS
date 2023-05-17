using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._04_오버로딩
{
    class _01_오버로딩
    {
        // OverLoading
        /// > 같은 이름의 함수를 여러 중복정의 하는것

        // 오버로딩의 조건
        /// 1. 매개변수의 갯수를 다르게 하거나,
        /// 2. 매개변수의 자료형을 다르게하여 중복정의 합니다.

        public static int Plus(int A, int B)
        {
            return A + B;
        }

        public static int Plus(int A, int B, int C)
        {
            return A + B + C;
        }

        public static void Main()
        {
            Plus(10, 20);
        }
    }
}
