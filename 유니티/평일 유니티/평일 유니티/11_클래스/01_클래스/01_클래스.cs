using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._01_클래스
{
    // 자료구조 Data Structure
    /// > 메모리를 효율적으로 사용하기위한 구조

    // 클래스
    /// > 여러 정보들의 집합
    /// > 사용자 정의 자료형 / 복합 데이터 형식

    class Sample
    {
        // 인스턴스 필드
        // 멤버
        public int num; // 멤버변수
        public float f_Num;

        public void SampleMethod() // 멤버함수 / 메서드
        {
            Console.WriteLine("Hello World!");
        }
    }

    class _01_클래스
    {
        public static void Main()
        {
            Sample s1 = new Sample();

            s1.num = 10;
            s1.f_Num = 10.4f;
            s1.SampleMethod();
            Console.WriteLine(s1.num);
            Console.WriteLine(s1.f_Num);
        }
    }
}
