using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._18_대리자._02_Action_Func
{
    // Action
    /// 반환형식이 void인 메서드를 대리할수있는 대리자

    // Func
    /// 반환형식이 void가 아닌 메서드를 대리할수있는 대리자

    class _01_Action
    {
        public static void Sample()
        {
            Console.WriteLine("없어~");
        }

        public static void Sample(int v1)
        { 
            Console.WriteLine("int있어~");
        }

        public static void Sample(float v1)
        { 
            Console.WriteLine("float있어~");
        }

        public static void Main()
        {
            Action action1 = Sample;

            Action<int> action3 = null;
            Action<float> action4 = Sample;

            action3 = Sample;
            action3(10);
            action4(10);

            action1 += Sample;
            action1 += Sample;
            action1 += Sample;
            action1 += Sample;

            action1();

            Action action2 = null;
            action2 = Sample;
            action2();

        }
    }
}
