using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._03_Static
{
    // static
    /// 정적화
    /// 유일성을 보장합니다.

    class Sample
    {
        // 인스턴스 필드
        public int Num;

        public void Method()
        {
            Console.WriteLine(Num);
        }

        // 정적 필드
        public static int BossHp;

    }

    class _01_Static
    {
        public static void Main()
        {
            Sample s1 = new Sample();
            Sample s2 = new Sample();

            s1.Num = 10;
            Sample.BossHp = 200;

        }
    }
}
