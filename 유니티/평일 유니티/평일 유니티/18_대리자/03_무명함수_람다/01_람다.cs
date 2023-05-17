using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._18_대리자._03_무명함수_람다
{
    //람다
    /// 이름없는 함수
    /// () =>

    class _01_람다
    {
        private delegate void Anonymous();
        private delegate int AnonymousFunction(int a, int b);

        static void Main()
        {
            Anonymous anonymous = () =>
            {
                Console.WriteLine("이름이");
                Console.WriteLine("없어");
            };

            anonymous();

            AnonymousFunction anonymousFunction2 = (a, b) => a + b;

            AnonymousFunction anonymousFunction = (a, b) =>
            {
                Console.WriteLine(a);
                Console.WriteLine(b);

                return a + b;
            };

            Console.WriteLine(anonymousFunction(10, 20));
            Console.WriteLine(anonymousFunction2(10, 20));


        }
    }
}
