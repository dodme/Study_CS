using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._02_Reference
{
    // 값복사
    /// Call By Value
    // 참조복사
    /// Call By Refference

    class _01_ref
    {
        public static void Add(ref int value1)
        {
            value1 += 10;
        }

        public static void Main()
        {
            int value = 10;
            Add(ref value);
            Console.WriteLine(value);
        }
    }
}

// 문제
/// 정수 2개를 입력받아
/// 두 정수를 Swap하는 메서드를 작성하세요.
/// ex) A = 10, B = 20
/// Swap(A,B)
/// B = 20, A = 10

/// 철수의 성적평가 프로그램을 만듭니다.
/// 철수의 총점, 평균, 최고점수를 구하는 프로그램을 작성하세요.
/// 총점, 평균, 최고점수는 각각의 메서드로 작성!




