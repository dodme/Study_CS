using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._01_상속
{
    // 다중상속? X
    // 중첩상속? O

    class A
    {
        public A()
        {
            Console.WriteLine("A");
        }
        ~A()
        { Console.WriteLine("~A"); }

    }

    class B : A
    {
        public B()
        { Console.WriteLine("B"); }

        ~B()
            { Console.WriteLine("~B"); }
    }

    class C : B
    {
        public C()
        { Console.WriteLine("C"); }

        ~C()
        { Console.WriteLine("~C"); }
    }

    class _03_상속
    {
        public static void Main()
        {
            C c = new C();
        }
    }
}
