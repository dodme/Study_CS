using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._04_객체복사
{
    class Sample
    {
        public int Num;

        public Sample DeepCopy()
        {
            Sample copy = new Sample();

            copy.Num = Num;

            return copy;
        }
    }

    class _01_객체복사
    {
        public static void Main()
        {
            Sample s1 = new Sample();
            s1.Num = 10;
            Sample s2 = s1.DeepCopy();

            /*Sample s2 = s1;*/
            s1.Num = 20;
            s2.Num = 30;

            Console.WriteLine(s1.Num);
            Console.WriteLine(s2.Num);
        }
    }
}
