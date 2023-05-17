using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._18_대리자._02_Action_Func
{
    // Func<반환형식>
    /// 반환값이 있는 메서드를 대리할수있는 대리자

    class _02_Func
    {
        public static int Sample()
        {
            return 0;
        }

        public static int Sample(int v1)
        {
            return v1;
        }

        public static float Sample(float v1)
        {
            return v1;
        }

        public int Method()
        {
            return 0;
        }

        public static void Main()
        {
            // 반환형식이 int이고 매개변수가 없는 메서드
            Func<int> func1 = Sample;
            Console.WriteLine(func1());

            // 반환형식이 int이고 매개변수가 int인 메서드
            Func<int, int> func2 = Sample;
            Console.WriteLine(func2(10));

            Func<float, float> func3 = Sample;
            Console.WriteLine(func3(10));

            //Func<int> func4 = Method;

        }
    }
}
