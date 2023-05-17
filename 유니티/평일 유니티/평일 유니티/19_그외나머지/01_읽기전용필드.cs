using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._19_그외나머지
{
    class Sample
    {
        public readonly int num = 10;
        // readonly보단 const를 쓰자

        public Sample()
        {
            num = 30; // 생성자에서는 재설정 가능
        }

        public void SampleMethod()
        {
            //num = 20; / 클래스 내부에서도 재설정 불가능
        }
    }

    class _01_읽기전용필드
    {
        public static void Main()
        {
            int num = 10;

            Sample s1 = new Sample();
            //s1.num = 10; / 값 재설정 불가능


        }
    }
}
