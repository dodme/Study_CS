using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._02_생성자종료자
{
    // 생성자
    /// > 특정한 역할만 하는 특수 메서드
    ///   객체에 대한 클래스의 정보 전달
    ///   생성자를 오버로딩해서 객체에 대한 초기값 전달을 많이 사용한다

    class Sample
    {
        int num;

        // 기본생성자
        public Sample()
        { 
            
        }

        // 생성자 : 객체를 만들 때 자동적으로 호출되는 메서드
        //          클래스의 정보 전달하는 역할
        public Sample(int num)
        {
            Console.WriteLine("생성자 입니다.");
        }

        // 소멸자 : 객체에 대한 메모리가 해제될 떄 호출되는 메서드
        ~Sample()
        {
            Console.WriteLine("종료자/소멸자 입니다.");
        }

    }

    class _01_생성자
    {
        public static void Main()
        {
            Sample s1 = new Sample();
        }
    }
}
