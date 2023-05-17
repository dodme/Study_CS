using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._18_대리자
{
    // 대리자
    /// > delegate
    /// > 함수를 참조하는 변수

    class _01_대리자
    {
        private delegate void MyDelegate();
        private delegate int MyDelegate2(int A, int B);

        public static void Sample()
        {
            Console.WriteLine("Hello?");
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static void Main()
        {
            Sample();
            MyDelegate myDelegate = new MyDelegate(Sample);
            MyDelegate2 myDelegate2 = new MyDelegate2(Plus);

            myDelegate();
            Console.WriteLine(myDelegate2(10, 20));

            myDelegate2 = new MyDelegate2(Minus);
            Console.WriteLine(myDelegate2(10, 20));
        }
    }
}
