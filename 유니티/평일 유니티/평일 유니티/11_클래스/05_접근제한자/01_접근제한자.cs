using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._05_접근제한자
{
    // 은닉성

    // 접근 제한자               클래스 외부          클래스 내부
    /// private                     X                   O
    /// protected                   To be Continue..
    /// public                      O                   O
    /// internal                    O                   O
    /// private protected           To be Continue..
    /// protected internal          To be Continue..

    class Sample
    {
        //public int Num;
        private int _num;

        // 접근자 Getter
        public int GetNum()
        { return _num; }

        // 설정자 Setter
        public void SetNum(int num)
        { _num = num; }

        public void Method()
        {
            _num = 10;
        }
    }

    class _01_접근제한자
    {
        public static void Main()
        {
            Sample s1 = new Sample();

            s1.SetNum(10);

            Console.WriteLine(s1.GetNum());
        }
    }
}
