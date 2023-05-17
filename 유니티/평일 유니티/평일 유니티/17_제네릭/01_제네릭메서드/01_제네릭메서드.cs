using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._17_제네릭._01_제네릭메서드
{
    // 일반화 프로그래밍
    /// 특수한 개념으로부터 공통된 개념으로 묶는것

    // 제네릭?
    /// 다양한 데이터형식을 공통된(하나의) 데이터 형식으로 묶는것
    /// 호출당시에 자료형을 결정 지어주는것

    class _01_제네릭메서드
    {
        public static void Print<T>(T v1, T v2)
        //public static void Print<T, U>(T v1, U v2)
        {
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }

        public static void Main()
        {
            Print<int>(10, 20);
            Print<float>(10.1f, 20.2f);
            Print<char>('A','B');
            Print<string>("Hello","World!");
        }
    }
}
